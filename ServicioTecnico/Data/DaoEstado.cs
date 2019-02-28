using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnico
{
    public class DaoEstado
    {
        private BaseRepository<Estado> repository;
        private DbContext context;

        public DaoEstado()
        {
            context = new BaseContext();
            repository = new BaseRepository<Estado>(context);
        }

        public Estado Get(int id)
        {
            var entity = repository.Get(id);
            return entity;
        }

        public List<Estado> GetEstados(string tipo)
        {
            var query = repository.Find(x => x.Tipo.Equals(tipo)).Where(e => e.EstadoRegistro == General.Estados.Activo);
            var list = query.ToList();
            return list;
        }

    }
}
