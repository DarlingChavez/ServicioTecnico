using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnico
{
    public class Inventario
    {
        public int IdInventario { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoProducto { get; set; }
        public string Origen { get; set; }
        public decimal Compra { get; set; }
        public decimal Venta { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaVenta { get; set; }
        public int IdEstado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string EstadoRegistro { get; set; }
    }
}
