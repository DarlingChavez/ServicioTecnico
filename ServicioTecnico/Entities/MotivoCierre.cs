using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicioTecnico
{
    [Table("MotivosCierre")]
    public class MotivoCierre
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdMotivoCierre { get; set; }
        public string Descripcion { get; set; }
        public string EstadoRegistro { get; set; }

        //public virtual ICollection<MotivoCierre> MotivosCierre { get; set; }
    }
}
