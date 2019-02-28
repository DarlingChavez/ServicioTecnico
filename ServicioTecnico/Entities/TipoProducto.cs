using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicioTecnico
{
    [Table("TiposProducto")]
    public class TipoProducto
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTipoProducto { get; set; }
        public string Descripcion { get; set; }
        public string EstadoRegistro { get; set; }

        //public virtual ICollection<Inventario> Inventario { get; set; }

    }
}
