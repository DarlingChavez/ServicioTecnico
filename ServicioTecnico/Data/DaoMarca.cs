using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnico
{
    public class DaoMarca : IDisposable
    {
        private BaseRepository<Marca> repository;
        private DbContext context;

        public DaoMarca()
        {
            context = new BaseContext();
            repository = new BaseRepository<Marca>(context);
        }

        public void Dispose()
        {
            repository.Dispose();
            context.Dispose();
        }

        public Marca Get(int id)
        {
            var entity = repository.Get(id);
            return entity;
        }

        public List<Marca> GetMarcas()
        {
            var query = repository.GetAll().Where(e => e.EstadoRegistro == General.Estados.Activo);
            var list = query.ToList();
            return list;
        }
    }
}
