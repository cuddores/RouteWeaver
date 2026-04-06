using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RouteWeaver.AppForms;
using RouteWeaver.Models;

namespace RouteWeaver
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static PlacesModelDb context = new PlacesModelDb();
        [STAThread]
        static void Main()
        {
            //if (!context.Datebase.Exists())
            //{
            //    MessageBox.Show("Ну удается подключиться к базе данных");
            //    return;
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
