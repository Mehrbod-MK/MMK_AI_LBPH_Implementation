using MMK_AI_LBPH_Implementation.LBPH;

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

        }
    }
}
