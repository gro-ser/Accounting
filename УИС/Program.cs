using System;
using System.Windows.Forms;
using УИС.Forms;

namespace УИС
{
    static class Program
    {
        [STAThread]
        static void Main(string[]args)
        {
            if (args.Length != 0)
            {
                Clipboard.SetText(Properties.Settings.Default.path);
                Properties.Settings.Default.path = args[0];
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loadder());
        }
    }
}