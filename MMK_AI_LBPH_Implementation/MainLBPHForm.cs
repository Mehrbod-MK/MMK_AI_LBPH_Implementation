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

            workerAddImages.DoWork += (sender, e) =>
            {
                foreach(var bitmapFile in inputFiles)
                {
                    currentStatus = $"Loading image:  {Path.GetFileName(bitmapFile)}";
                    workerAddImages.ReportProgress(0);

                    try
                    {
                        LBPHImage lbphImage = new LBPHImage();
                        using (Bitmap bitmap = new Bitmap(bitmapFile))
                        {
                            currentStatus = $"Converting image to grayscale:  {Path.GetFileName(bitmapFile)}";
                            workerAddImages.ReportProgress(0);

                            lbphImage.LoadGrayscale(bitmap);


                        }
                    }
                    catch (Exception ex)
                    {
                        if (Helpers.ShowErrorMessageBox("خطای بارگزاری تصویر", $"خطایی در بارگزاری تصویر پیش آمد:\n\n{ex.ToString()}\n\nآیا مایل به ادامه فرایند بارگیری تصاویر هستید؟", MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button1)
                        == DialogResult.No)
                        {
                            break;
                        };
                    }
                }
            };
            workerAddImages.ProgressChanged += (sender, e) =>
            {
                loadingForm.progressBarProgress.Maximum = inputFiles.Length;
                loadingForm.progressBarProgress.Value = imagesLoaded;
                loadingForm.labelStatus.Text = currentStatus;
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
    }
}
