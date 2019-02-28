using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnico
{
    public class DaoInventario
    {
        private BaseRepository<Inventario> repository;
        private DbContext context;

        public DaoInventario()
        {
            context = new BaseContext();
            repository = new BaseRepository<Inventario>(context);
        }

        public Inventario Get(int id)
        {
            var entity = repository.Get(id);
            return entity;
        }

        public List<Inventario> GetInventarios()
        {
            var query = repository.GetAll().Where(e => e.EstadoRegistro == General.Estados.Activo);
            var list = query.ToList();
            return list;
        }

        public List<Inventario> FindInventarios(DateTime desde, DateTime hasta)
        {
            var query = repository.Find(x => x.FechaRegistro >= desde && x.FechaRegistro <= hasta);
            var list = query.ToList();
            return list;
        }

        public bool Insert(Inventario entity)
        {
            repository.Insert(entity);
            bool save = repository.SaveChanges();
            return save;
        }

        public bool Update(Inventario entity)
        {
            repository.Update(entity);
            bool save = repository.SaveChanges();
            return save;
        }

        public bool Destroy(object id)
        {
            var entity = repository.Get(id);
            entity.EstadoRegistro = General.Estados.Inactivo;
            repository.Update(entity);
            bool save = repository.SaveChanges();
            return save;
        }
    }
}
