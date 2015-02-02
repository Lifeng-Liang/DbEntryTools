using System;
using System.Windows.Forms;
using Leafing.Data;

namespace SqlQuerier
{
    static class Program
    {
        public static MainForm Form;

        [STAThread]
        static void Main()
        {
            // force to read the default App.config
            DbEntry.Provider.ExecuteScalar("select 1");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form = new MainForm();
            Application.Run(Form);
        }
    }
}