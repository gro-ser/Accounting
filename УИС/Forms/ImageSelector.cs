using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace УИС.Forms
{
    public partial class ImageSelector : ThemeForm
    {
        static ImageSelector self = new ImageSelector();

        public static Image Image { get; set; }

        static public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        static public byte[] imageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        static public DialogResult ShowForm(object img)
        {
            if (img is byte[]) self.pictureBox1.Image = byteArrayToImage(img as byte[]);
            else if (img is Image) self.pictureBox1.Image = img as Image;
            else
            { MessageBox.Show("Why??? Type of img is " + img.GetType() + "\r\nNot for Image or Bitmap!", "WTF/ERROR!"); }
            Image = self.pictureBox1.Image;
            return self.ShowDialog();
        }

        public ImageSelector()
        {
            InitializeComponent();
        }

        private void delete(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
        private void open(object sender, EventArgs e)
        {
            if (openDialog.ShowDialog() != DialogResult.OK) return;
            Image = pictureBox1.Image = Image.FromFile(openDialog.FileName);
        }
        private void save(object sender, EventArgs e)
        {
            if (saveDialog.ShowDialog() != DialogResult.OK) return;
            pictureBox1.Image.Save(saveDialog.FileName);
        }
        private void resize(float scale)
        {
            if (scale > 0) pictureBox1.Image = new Bitmap(Image, (int)(Image.Size.Width * scale / 100), (int)(Image.Size.Height * scale / 100));
        }
        private void resize(object sender, System.EventArgs e)
        {
            float scale; if (float.TryParse((sender as ToolStripItem).Text.TrimEnd('%'), out scale)) resize(scale);
        }
        private void accept(object sender, EventArgs e)
        {
            Image = pictureBox1.Image;
        }
    }
}