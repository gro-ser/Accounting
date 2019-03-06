using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace УИС.Forms
{
    public class Help : /*Theme*/Form
    {
        static Help self = new Help();
        public static void ShowForm() { self.ShowDialog(); }
        public Help()
        {
            InitializeComponent();
            helpBox.Rtf =
                new StreamReader(
                    new GZipStream(
                        new MemoryStream(Properties.Resources.info),
                    CompressionMode.Decompress)
                ).ReadToEnd();
        }

        RichTextBox helpBox;
        private void InitializeComponent()
        {
            this.helpBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.helpBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.helpBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpBox.Location = new System.Drawing.Point(0, 0);
            this.helpBox.Name = "richTextBox1";
            this.helpBox.ReadOnly = true;
            this.helpBox.Size = new System.Drawing.Size(397, 291);
            this.helpBox.TabIndex = 0;
            // 
            // Help
            // 
            this.ClientSize = new System.Drawing.Size(397, 291);
            this.Controls.Add(this.helpBox);
            this.Name = "Help";
            this.ShowIcon = false;
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);

        }
    }
}
