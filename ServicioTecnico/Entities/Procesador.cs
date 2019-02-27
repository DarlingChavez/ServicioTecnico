using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicioTecnico
{

    [Table("Procesadores")]
    public class Procesador
    {
        [Key]
        public int IdProcesador { get; set; }
        public string Descripcion { get; set; }
        public string Fabricante { get; set; }
        public string EstadoRegistro { get; set; }

        //public virtual ICollection<Equipo> Equipos { get; set; }
    }
}
