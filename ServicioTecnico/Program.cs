using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System.Configuration;

namespace ServicioTecnico
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            string feel = ConfigurationManager.AppSettings["feel"].ToString();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(feel);
            Application.Run(new FrmMain());
        }
    }
}
