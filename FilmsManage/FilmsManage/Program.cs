using FilmsManage.GUI;
using FilmsManage.GUI.DataUserControl;
using FilmsManage.GUI.Forms;
using FilmsManage.GUI.Forms.BanVe_Form;

namespace FilmsManage
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {  
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            List<string> list = new List<string>();
            Application.Run(new Login());
        }
    }
}