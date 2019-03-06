using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using УИС.Forms;

namespace УИС
{
    public class Theme
    {
        public Color BackColor, ForeColor, Back, Button;
        public static readonly Theme White = new Theme() { ForeColor = Color.FromArgb(70, 70, 70), Back = Color.WhiteSmoke, BackColor = Color.White, Button = Color.FromArgb(240, 240, 240) };
        public static readonly Theme Default = new Theme() { ForeColor = Color.Black, Back = Color.FromArgb(-4934476), BackColor = Color.White, Button = Color.FromArgb(-8355712) };
        public static readonly Theme Black = new Theme() { ForeColor = Color.LightGray, Back = Color.Black, BackColor = Color.FromArgb(75, 75, 75), Button = Color.FromArgb(100, 100, 100) };
        public static Theme Another, Current;
        public static Theme[] Themes = { White, Default, Black, null };
        static List<ThemeForm> list = new List<ThemeForm>();
        public static ThemeForm Add(ThemeForm form)
        {
            Current.Apply(form);
            list.Add(form);
            return form;
        }
        internal static void Remove(ThemeForm form)
        {
            list.Remove(form);
        }

        public static void Apply()
        {
            foreach (var f in list) Current.Apply(f);
        }
        public void Apply(ThemeForm form)
        {
            form.BackColor = Back;
            Apply(form.Controls);
        }
        public void Apply(Control.ControlCollection Controls)
        {
            foreach (Control i in Controls) Apply(i);
        }
        public Control Apply(Control control)
        {
            Apply(control.Controls);
            control.ForeColor = ForeColor;
            if (control.Tag == null || !(control.Tag is int)) return control;
            int x = (int)control.Tag;
            if (x == 0) control.BackColor = BackColor;
            if (x == 1) control.BackColor = Button;
            if (x == 2)
            {
                var d = (DataGridView)control;
                d.DefaultCellStyle.ForeColor = ForeColor;
                d.DefaultCellStyle.BackColor = BackColor;
                d.ColumnHeadersDefaultCellStyle.ForeColor = ForeColor;
                d.ColumnHeadersDefaultCellStyle.BackColor = Button;
                d.RowHeadersDefaultCellStyle.BackColor = Button;
                d.BackgroundColor = Back;
            }
            return control;
        }

        static Theme()
        {
            var p = Properties.Settings.Default;
            Another = new Theme()
            {
                BackColor = p.BackColor,
                ForeColor = p.ForeColor,
                Back = p.Back,
                Button = p.Button
            };
            Themes[3] = Another;
            Current = Themes[p.theme];
        }
        public static void Save()
        {
            var p = Properties.Settings.Default;
            p.BackColor = Another.BackColor;
            p.ForeColor = Another.ForeColor;
            p.Back = Another.Back;
            p.Button = Another.Button;
            p.theme = Array.IndexOf(Themes, Current);
            p.Save();
        }
        static string rgb(Color c) { return string.Format("#{0:X2}{1:X2}{2:X2}", c.R, c.G, c.B); }
        public string GetStyle()
        {
            return string.Format("<style type='text/css'>body{{font-family:Consolas;font-size:10pt;background:{0};color:{1}}}th,td{{border:solid 1px #A0A0A0}}th{{background:{2}}}td{{background:{3}}}</style>", rgb(Back), rgb(ForeColor), rgb(Button), rgb(BackColor));
        }
    }
}