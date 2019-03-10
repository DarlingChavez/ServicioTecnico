using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicioTecnico
{
    public partial class UcMantenimiento : UserControl
    {
        #region Declare Events
        public delegate void NuevoDelegate();
        public event NuevoDelegate NuevoEvent;

        public delegate void EditarDelegate();
        public event EditarDelegate EditarEvent;

        public delegate void CancelarDelegate();
        public event CancelarDelegate CancelarEvent;

        public delegate void GuardarDelegate();
        public event GuardarDelegate GuardarEvent;

        public delegate void BorrarDelegate();
        public event BorrarDelegate BorrarEvent;

        public delegate void BuscarDelegate(DateTime desde, DateTime hasta);
        public event BuscarDelegate BuscarEvent;

        public delegate void CerrarDelegate();
        public event CerrarDelegate CerrarEvent;
        #endregion

        public UcMantenimiento()
        {
            InitializeComponent();
        }
        #region Raise Events
        private void barButtonItemNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NuevoEvent();
        }

        private void barButtonItemEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditarEvent();
        }

        private void barButtonItemCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CancelarEvent();
        }

        private void barButtonItemGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GuardarEvent();
        }

        private void barButtonItemBorrar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BorrarEvent();
        }

        private void simpleButtonSearch_Click(object sender, EventArgs e)
        {
            BuscarEvent(dateEditDesde.DateTime,dateEditHasta.DateTime);
        }

        private void simpleButtonExit_Click(object sender, EventArgs e)
        {
            CerrarEvent();
        }
        #endregion

        #region Enable Buttons

        public bool SetEnableNuevo
        {
            set { barButtonItemNuevo.Enabled = value; }
        }

        public bool SetEnableEditar
        {
            set { barButtonItemEditar.Enabled = value; }
        }

        public bool SetEnableCancelar
        {
            set { barButtonItemCancelar.Enabled = value; }
        }

        public bool SetEnableGuardar
        {
            set { barButtonItemGuardar.Enabled = value; }
        }

        public bool SetEnableBorrar
        {
            set { barButtonItemBorrar.Enabled = value; }
        }

        #endregion

    }
}
