using MMK_AI_LBPH_Implementation.LBPH;
using System.ComponentModel;

namespace MMK_AI_LBPH_Implementation
{
    public partial class MainLBPHForm : Form
    {
        LBPHContext context = new LBPHContext();

        public MainLBPHForm()
        {
            InitializeComponent();
        }

        private void toolStripButtonAddTrainImage_Click(object sender, EventArgs e)
        {
            // Get some input image files.
            var newImageFiles = Helpers.OpenFiles("تصاویر جدید را انتخاب کنید.",
                "فایل‌های تصاویر|*.png;*.bmp;*.jpg;*.jpeg;*.tif|تمامی فایل‌ها|*.*", true);

            // Process files.
            if (newImageFiles != null)
                ProcessNewImageFiles(newImageFiles);
        }

        private void ProcessNewImageFiles(string[] inputFiles)
        {
            BackgroundWorker workerAddImages = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true,
            };
            LoadingForm loadingForm = new LoadingForm(workerAddImages);

            string currentStatus = string.Empty;
            int imagesLoaded = 0;
            string currentImageFilePath = string.Empty;
            LBPHImage? lbphImage = null;

            workerAddImages.DoWork += (sender, e) =>
            {
                foreach (var bitmapFile in inputFiles)
                {
                    currentImageFilePath = bitmapFile;

                    currentStatus = $"بارگزاری تصویر:  {Path.GetFileName(bitmapFile)}";
                    workerAddImages.ReportProgress(0);

                    try
                    {
                        lbphImage = new LBPHImage()
                        {
                            ImageName = Path.GetFileName(bitmapFile),
                            Label = Path.GetFileNameWithoutExtension(bitmapFile),
                        };
                        using (Bitmap bitmap = new Bitmap(bitmapFile))
                        {
                            currentStatus = $"در حال تبدیل به تصویر سیاه‌سفید:  {Path.GetFileName(bitmapFile)}";
                            workerAddImages.ReportProgress(0);

                            lbphImage.LoadGrayscale(bitmap);

                            lbphImage = ImageDisplay.EditLBPHImageProperties(lbphImage);

                            if (lbphImage != null)
                            {
                                currentStatus = $"در حال به‌روزرسانی مدل:  {Path.GetFileName(bitmapFile)}";
                                workerAddImages.ReportProgress(0);

                                // Train image.
                                lbphImage.Train(context.Radius, context.GridX, context.GridY);

                                workerAddImages.ReportProgress(1);

                                imagesLoaded++;
                                workerAddImages.ReportProgress(0);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        if (Helpers.ShowErrorMessageBox("خطای بارگزاری تصویر",
                            $"خطایی در بارگزاری تصویر پیش آمد:\n\n{ex.ToString()}\n\nآیا مایل به ادامه فرایند بارگیری تصاویر هستید؟",
                            MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button1)
                                == DialogResult.No)
                        {
                            break;
                        };
                    }
                }
            };
            workerAddImages.ProgressChanged += (sender, e) =>
            {
                switch (e.ProgressPercentage)
                {
                    case 0:
                        loadingForm.progressBarProgress.Maximum = inputFiles.Length;
                        loadingForm.progressBarProgress.Value = imagesLoaded;
                        loadingForm.labelStatus.Text = currentStatus;
                        break;

                    case 1:
                        if (lbphImage != null)
                        {
                            context.TrainImages.Add(lbphImage);

                            listViewTrain.Items.Add(new ListViewItem(new string[] { lbphImage.ImageName, lbphImage.Label, currentImageFilePath, $"{lbphImage.ImageObject?.Width} در {lbphImage.ImageObject?.Height}" }));
                        }
                        break;
                }
            };
            workerAddImages.RunWorkerCompleted += (sender, e) =>
            {
                loadingForm.ForceClose();

                Enabled = true;
            };


            Enabled = false;
            workerAddImages.RunWorkerAsync();
            loadingForm.ShowDialog();
        }

        private void toolStripButtonRemoveSelectedTrainImage_Click(object sender, EventArgs e)
        {
            if (listViewTrain.SelectedIndices.Count > 0)
            {
                listViewTrain.Items.RemoveAt(listViewTrain.SelectedIndices[0]);
                context.TrainImages.RemoveAt(listViewTrain.SelectedIndices[0]);
            }
        }

        private void listViewTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTest.SelectedIndices.Count <= 0)
            {
                pictureBoxTestImage.Image = null;
            }
            else
            {
                pictureBoxTestImage.Image = context.TestImages[listViewTest.SelectedIndices[0]];
            }
        }

        private void buttonPredictTestImage_Click(object sender, EventArgs e)
        {
            label1.Text = context.Predict(context.TestImages[listViewTest.SelectedIndices[0]]);
        }

        private void toolStripButtonAddTestImage_Click(object sender, EventArgs e)
        {
            var newImageFiles = Helpers.OpenFiles("تصاویر آزمایشی را انتخاب کنید.",
                "فایل‌های تصاویر|*.png;*.bmp;*.jpg;*.jpeg;*.tif|تمامی فایل‌ها|*.*", true);

            if (newImageFiles == null)
                return;

            foreach(var imageFile in newImageFiles)
            {
                context.TestImages.Add(new Bitmap(imageFile));
                listViewTest.Items.Add(new ListViewItem(new string[] { imageFile }));
            }
        }
    }
}
