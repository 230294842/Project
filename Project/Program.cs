using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SalesManagerPanel());
            //Application.Run(new EditPersonalInformation());
            //Application.Run(new Login());
            //Application.Run(new AdminPanel());
            //Application.Run(new ManageReturn());
            //Application.Run(new SearchProduct());
            //Application.Run(new Register());
            Application.Run(new CarTire_List());
        }
    }
}
