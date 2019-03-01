using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;

namespace ServicioTecnico
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        
        private bool ExisteHijo(Type tipo)
        {
            int count = this.MdiChildren.Where(h => h.GetType() == tipo).Count();
            if (count > 0)
            {
                this.MdiChildren.Where(h => h.GetType() == tipo).First().Activate();
                return true;
            }else
            {
                return false;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void barButtonItemSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItemAboutMe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAboutMe frm = new FrmAboutMe();
            frm.ShowDialog();
        }

        private void barButtonItemEquipo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool existe = ExisteHijo(typeof(FrmSoporte));
            if (existe) return;
            FrmSoporte frm = new FrmSoporte();
            frm.MdiParent = this;
            frm.LookAndFeel.UseDefaultLookAndFeel = true;
            frm.Show();
        }

        private void barButtonItemInventario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool existe = ExisteHijo(typeof(FrmMercaderia));
            if (existe) return;
            FrmMercaderia frm = new FrmMercaderia();
            frm.MdiParent = this;
            frm.LookAndFeel.UseDefaultLookAndFeel = true;
            frm.Show();
        }
    }
}