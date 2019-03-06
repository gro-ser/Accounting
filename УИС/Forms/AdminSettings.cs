using System;
using System.Windows.Forms;

namespace УИС.Forms
{
    public partial class AdminSettings : ThemeForm
    {
        static AdminSettings self = new AdminSettings();
        static public void ShowForm() { self.ShowDialog(); }
        public AdminSettings() { InitializeComponent(); }
        private void Save(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
        }
        private void Reset(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }
        private void Exit(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}