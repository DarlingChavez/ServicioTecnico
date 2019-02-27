using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnico
{
    public class Garantia
    {
        public int IdGarantia { get; set; }
        public sbyte Indice { get; set; }
        public int IdEquipo { get; set; }
        public string Descripcion { get; set; }
        public string IdEstado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string EstadoRegistro { get; set; }
    }
}
