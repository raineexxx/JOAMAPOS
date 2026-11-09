using System;
using System.Windows.Forms;

namespace JOAMAPOS.WinForms
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                using (var login = new frmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                        break;                       // Exit or closed
                }

                var dash = new frmDashboard();
                Application.Run(dash);

                if (!dash.LogoutRequested)
                    break;                           // closed or Exit, so quit
            }
        }
    }
}