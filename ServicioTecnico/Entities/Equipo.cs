using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicioTecnico
{
    [Table("Equipos")]
    public class Equipo
    {
        [Key]
        public int IdEquipo { get; set; }
        //[Required]
        //[ForeignKey("Marca")]
        public int IdMarca { get; set; }
        //[Required]
        //[ForeignKey("Procesador")]
        public int IdProcesador { get; set; }
        public string Cliente { get; set; }
        public string Descripcion { get; set; }
        public string SerieMainBoard { get; set; }
        //[Required]
        //[ForeignKey("Estado")]
        public int IdEstado { get; set; }
        //[Required]
        //[ForeignKey("MotivoCierre")]
        public int IdMotivoCierre { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string EstadoRegistro { get; set; }
        
        public virtual Marca Marca { get; set; }
        public virtual Procesador Procesador { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual MotivoCierre MotivoCierre { get; set; }

        //public virtual ICollection<Garantia> Garantias { get; set; }

    }
}
