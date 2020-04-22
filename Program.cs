using Espaco_da_Beleza_Gerenciamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Espaco_Da_Beleza_Gerenciamento
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Espaco_da_Beleza_Gerenciamento.FrmSplashScreen());
        }
    }
}
