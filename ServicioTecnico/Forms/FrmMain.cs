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

namespace ServicioTecnico
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDelProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAboutMe frm = new FrmAboutMe();
            frm.ShowDialog();
        }

        private void soporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool existe = AbrirHijo(typeof(FrmSoporte));
            if( existe ) return;
            FrmSoporte frm = new FrmSoporte();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mercaderiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool existe = AbrirHijo(typeof(FrmMercaderia));
            if (existe) return;
            FrmMercaderia frm = new FrmMercaderia();
            frm.MdiParent = this;
            frm.Show();
        }

        private bool AbrirHijo(Type tipo)
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
    }
}