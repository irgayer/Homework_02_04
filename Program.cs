using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_02_04
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ИргалиевЕ\source\repos\Homework_02_04\databaseExample.mdf;Integrated Security=True
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
