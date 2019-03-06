using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace УИС.Forms
{
    //UNDONE!!!
    public partial class ConnectForm : ThemeForm
    {
        static ConnectForm self = new ConnectForm();
        public static void ShowForm() { self.ShowDialog(); }

        public ConnectForm() { InitializeComponent(); }
        Properties.Settings settings = Properties.Settings.Default;
        string[] providers;
        void ResetProviders()
        {
            providers = settings.providers.Split('|');
            provider.Items.Clear();
            provider.Items.AddRange(providers);
            provider.SelectedIndex = settings.curProvider;
        }
        private void FormLoad(object sender, EventArgs e)
        {
            ResetProviders();
            openFileDialog1.FileName = fullpath.Text;
        }
        private void OpenFile(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            fullpath.Text = checkBox1.Checked ? openFileDialog1.FileName : openFileDialog1.SafeFileName;
        }
        private void Save(object sender, EventArgs e)
        {
            if (!DBControl.Connect())
            {
                MessageBox.Show(DBControl.LastError, "Не подключено!");
                return;
            }
            RewriteProviders();
            settings.Save();
            DialogResult = DialogResult.OK;
        }
        private void RewriteProviders()
        {
            if (provider.SelectedIndex != -1)
                settings.curProvider = provider.SelectedIndex;
            else
            {
                var s = provider.Text;
                var ind = Array.IndexOf(providers, s);
                if (ind == -1)
                {
                    settings.curProvider = providers.Length;
                    settings.providers += "|" + s;
                    ResetProviders();
                }
                else
                    settings.curProvider = ind;
            }
        }
        private void Reset(object sender, EventArgs e)
        {
            settings.Reset();
            ResetProviders();
        }
        private void Connect(object sender, EventArgs e)
        {
            RewriteProviders();
            MessageBox.Show(DBControl.Connect() ? "подключено" : DBControl.LastError);
        }
        private void provider_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.curProvider = provider.SelectedIndex;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            fullpath.Text = checkBox1.Checked ? openFileDialog1.FileName : openFileDialog1.SafeFileName;            
        }

        private void openFile(object sender, EventArgs e)
        {
            try
            {
                Process.Start(fullpath.Text);
            }
            catch { }
        }
    }
}