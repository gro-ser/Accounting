using System;
using System.Windows.Forms;

namespace УИС.Forms
{
    public class ThemeForm : Form
    {
    
        public ThemeForm()
        {
            InitializeComponent();
            Theme.Add(this);
            Load += new EventHandler(ThemeForm_Load);
        }
        protected override void Dispose(bool disposing)
        {
            Theme.Remove(this);
            base.Dispose(disposing);
        }

        private void ThemeForm_Load(object sender, EventArgs e)
        {
            Theme.Current.Apply(this);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ThemeForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ThemeForm";
            this.ResumeLayout(false);
            this.ShowIcon = false;
        }
    }
}
