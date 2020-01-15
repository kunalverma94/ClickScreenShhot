using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
     class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
           var t= new gc();
            Application.Run();
        }


    }
}
