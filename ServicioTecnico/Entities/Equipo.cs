using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnico
{
    public class Equipo
    {
        public int IdEquipo { get; set; }
        public int IdMarca { get; set; }
        public int IdProcesador { get; set; }
        public string Cliente { get; set; }
        public string Descripcion { get; set; }
        public string SerieMainBoard { get; set; }
        public int IdEstado { get; set; }
        public int IdMotivoCierre { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string EstadoRegistro { get; set; }
        
    }
}
