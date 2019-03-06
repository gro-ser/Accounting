using System;
using System.IO;
using System.Windows.Forms;

namespace УИС.Forms
{
    public partial class Print : ThemeForm
    {
        public static void Show(string html) { new Print(html).Show(); }

        Print(string html)
        {
            InitializeComponent(); webBrowser.DocumentText = html;
        }

        private void Cancel(object sender, EventArgs e)
        { Close(); }

        private void PreView(object sender, EventArgs e)
        {
            webBrowser.ShowPrintPreviewDialog();
        }
        private void DoPrint(object sender, EventArgs e)
        {
            webBrowser.ShowPrintDialog();
        }
        private void FastPrint(object sender, EventArgs e)
        {
            webBrowser.Print();
        }

        private void Save(object sender, EventArgs e)
        {
            saveFileDialog.FileName = webBrowser.DocumentTitle;
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
            File.WriteAllText(saveFileDialog.FileName, webBrowser.DocumentText);
        }
        private void Exit(object sender, EventArgs e) { Close(); }
    }
}
