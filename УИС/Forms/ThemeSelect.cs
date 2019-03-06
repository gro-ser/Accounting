using System;
using System.Windows.Forms;

namespace УИС.Forms
{
    public partial class ThemeSelect : ThemeForm
    {
        static ThemeSelect self = new ThemeSelect();
        public static void ShowForm() { self.ShowDialog(); }

        Control[] cont;
        bool change; int ind;
        public ThemeSelect()
        {
            InitializeComponent();
            cont = new Control[] { _ForeColor, _BackColor, _Back, _Button };
            for (byte i = 0; i < 4; i++) cont[i].Tag = i;
            change = (ind = comboBox1.SelectedIndex = Properties.Settings.Default.theme) == 3;
        }
        private void Selected(object sender, EventArgs e)
        {
            int ind = comboBox1.SelectedIndex;
            change = ind == 3;
            var tmp = Theme.Current = Theme.Themes[ind];
            _Back.BackColor = tmp.Back;
            _Button.BackColor = tmp.Button;
            _ForeColor.BackColor = tmp.ForeColor;
            _BackColor.BackColor = tmp.BackColor;
            tmp.Apply(this);
        }
        private void ColorSelect(object sender, EventArgs e)
        {
            var but = sender as Control;
            if (change)
            {
                colorDialog1.Color = but.BackColor;
                if (colorDialog1.ShowDialog() != DialogResult.OK) return;
                var c = but.BackColor = colorDialog1.Color;
                switch ((byte)but.Tag)
                {
                    case 0: Theme.Current.ForeColor = c; break;
                    case 1: Theme.Current.BackColor = c; break;
                    case 2: Theme.Current.Back = c; break;
                    case 3: Theme.Current.Button = c; break;
                }
            }
            else
                switch ((byte)but.Tag)
                {
                    case 0: Theme.Another.ForeColor = but.BackColor; break;
                    case 1: Theme.Another.BackColor = but.BackColor; break;
                    case 2: Theme.Another.Back = but.BackColor; break;
                    case 3: Theme.Another.Button = but.BackColor; break;
                }
            Theme.Current.Apply(this);
        }
        private void Accept(object sender, EventArgs e)
        {
            Theme.Apply();
            Theme.Save();
        }
        private void Cancel(object sender, EventArgs e)
        {
            Theme.Current = Theme.Themes[comboBox1.SelectedIndex = ind];
        }
    }
}