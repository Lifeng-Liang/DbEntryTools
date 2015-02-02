
#region usings

using System;
using System.Collections.Generic;
using System.Windows.Forms;

#endregion

namespace AssemblyNameGetter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}