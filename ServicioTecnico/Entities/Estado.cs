﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicioTecnico
{
    [Table("Estados")]
    public class Estado
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEstado { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string EstadoRegistro { get; set; }

        //public virtual ICollection<Equipo> Equipos { get; set; }
        //public virtual ICollection<Garantia> Garantias { get; set; }
        //public virtual ICollection<Inventario> Inventario { get; set; }

    }
}
