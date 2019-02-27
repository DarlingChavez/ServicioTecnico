using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicioTecnico
{
    [Table("Garantias")]
    public class Garantia
    {
        [Key]
        public int IdGarantia { get; set; }
        public byte Indice { get; set; } = 1;
        //[Required]
        //[ForeignKey("Equipo")]
        public int IdEquipo { get; set; }
        public string Descripcion { get; set; }
        //[Required]
        //[ForeignKey("Estado")]
        public int IdEstado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string EstadoRegistro { get; set; }

        public virtual Equipo Equipo { get; set; }
        public virtual Estado Estado { get; set; }

    }
}
