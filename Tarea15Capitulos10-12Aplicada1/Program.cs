using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tarea15Capitulos10_12Aplicada1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EjerciciosCapitulo12.Ejercicio1.Factorial();
            Application.Run(new FrmMain());
            
        }
    }
}
