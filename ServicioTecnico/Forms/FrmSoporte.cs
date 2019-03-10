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
    public partial class FrmSoporte : DevExpress.XtraEditors.XtraForm
    {
        public FrmSoporte()
        {
            InitializeComponent();
            ucMantenimientoEquipos.NuevoEvent += UcMantenimientoEquipos_NuevoEvent;
            ucMantenimientoEquipos.EditarEvent += UcMantenimientoEquipos_EditarEvent;
            ucMantenimientoEquipos.CancelarEvent += UcMantenimientoEquipos_CancelarEvent;
            ucMantenimientoEquipos.GuardarEvent += UcMantenimientoEquipos_GuardarEvent;
            ucMantenimientoEquipos.BorrarEvent += UcMantenimientoEquipos_BorrarEvent;
            ucMantenimientoEquipos.BuscarEvent += UcMantenimientoEquipos_BuscarEvent;
            ucMantenimientoEquipos.CerrarEvent += UcMantenimientoEquipos_CerrarEvent;
        }

        #region Eventos botones mantenimiento
        private void UcMantenimientoEquipos_CerrarEvent()
        {
            this.Close();
        }

        private void UcMantenimientoEquipos_BorrarEvent()
        {
            
        }

        private void UcMantenimientoEquipos_GuardarEvent()
        {
            
        }

        private void UcMantenimientoEquipos_CancelarEvent()
        {
            
        }

        private void UcMantenimientoEquipos_EditarEvent()
        {
            
        }

        private void UcMantenimientoEquipos_NuevoEvent()
        {
            
        }

        private void UcMantenimientoEquipos_BuscarEvent(DateTime desde, DateTime hasta)
        {

        }
        #endregion

        #region Load
        private void FrmSoporte_Load(object sender, EventArgs e)
        {
            try
            {
                CargarMarcas();
                CargarProcesadores();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void CargarMarcas()
        {
            using(DaoMarca dao = new DaoMarca())
            {
                List<Marca> marcas = dao.GetMarcas();
                searchLookUpEditMarca.Properties.DataSource = marcas;
            }
        }

        private void CargarProcesadores()
        {
            using (DaoProcesador dao = new DaoProcesador())
            {
                var procesadores = dao.GetProcesadores();
                searchLookUpEditProcesador.Properties.DataSource = procesadores;
            }
        }
        #endregion
    }
}