using System;
using System.Windows.Forms;
using SpectrumSuite.Riesgos.Formularios;

namespace SpectrumSuite
{
    static class SpectrumFondos
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmPlaza());
        }
    }
}
