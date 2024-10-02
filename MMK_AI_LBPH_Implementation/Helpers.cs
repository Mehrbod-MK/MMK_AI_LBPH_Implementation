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
    }
}
