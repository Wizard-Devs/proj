using System;
using System.Data.Entity;
using System.Windows.Forms;
using Temple7k_iShopping.Model;

namespace Temple7k_iShopping
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new AppInitializer());
            using (iShoppingContext context = new iShoppingContext())
            {
                context.Database.Initialize(false);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (FormLogin login = new FormLogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FormPrincipal());
                }
            }
        }
    }
}
