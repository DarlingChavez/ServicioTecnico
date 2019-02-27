using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicioTecnico
{
    [Table("Inventario")]
    public class Inventario
    {
        [Key]
        public int IdInventario { get; set; }
        public string Descripcion { get; set; }
        //[Required]
        //[ForeignKey("TipoProducto")]
        public int IdTipoProducto { get; set; }
        public string Origen { get; set; }
        public decimal Compra { get; set; }
        public decimal Venta { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaVenta { get; set; }
        //[Required]
        //[ForeignKey("Estado")]
        public int IdEstado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string EstadoRegistro { get; set; }

        public virtual TipoProducto TipoProducto { get; set; }
        public virtual Estado Estado { get; set; }

    }
}
