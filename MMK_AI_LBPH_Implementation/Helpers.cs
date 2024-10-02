using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMK_AI_LBPH_Implementation
{
    internal class Helpers
    {
        public static string[]? OpenFiles(string title, string filter, bool multiselect)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                AddExtension = true,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = filter,
                Multiselect = multiselect,
                SupportMultiDottedExtensions = true,
                Title = title,
            };

            if(openFileDialog.ShowDialog() == DialogResult.OK)
                return openFileDialog.FileNames;

            return null;
        }

        public static DialogResult ShowErrorMessageBox(string title, string text, MessageBoxButtons buttons, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            return MessageBox.Show(
                caption: title,
                text: text,
                buttons: buttons,
                icon: MessageBoxIcon.Error,
                defaultButton: defaultButton,
                options: MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading
                );
        }

        public static DialogResult ShowWarningMessageBox(string title, string text, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            return MessageBox.Show(
                caption: title,
                text: text,
                buttons: buttons,
                icon: MessageBoxIcon.Warning,
                defaultButton: defaultButton,
                options: MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading
                );
        }

        public static bool IsBlankString(string? str)
        {
            return string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
        }

        public static void ShowImageFullDisplay(Image image)
        {
            Form form = new Form()
            {
                Text = "نمایشگر تصویر",
                RightToLeft = RightToLeft.Yes,
                RightToLeftLayout = true,
                WindowState = FormWindowState.Maximized,
                Size = new Size(640, 480),
            };
            PictureBox pictureBox = new PictureBox()
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill,
                Image = image,
            };

            form.Controls.Add(pictureBox);

            form.ShowDialog();
        }
    }
}
