using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnico
{
    public class DaoGarantia
    {
        private BaseRepository<Garantia> repository;
        private DbContext context;

        public DaoGarantia()
        {
            context = new BaseContext();
            repository = new BaseRepository<Garantia>(context);
        }

        public Garantia Get(int id)
        {
            var entity = repository.Get(id);
            return entity;
        }

        public List<Garantia> GetGarantias()
        {
            var query = repository.GetAll().Where(e => e.EstadoRegistro == General.Estados.Activo);
            var list = query.ToList();
            return list;
        }

        public List<Garantia> FindGarantias(DateTime desde, DateTime hasta)
        {
            var query = repository.Find(x => x.FechaRegistro >= desde && x.FechaRegistro <= hasta);
            var list = query.ToList();
            return list;
        }

        public bool Insert(Garantia entity)
        {
            repository.Insert(entity);
            bool save = repository.SaveChanges();
            return save;
        }

        public bool Update(Garantia entity)
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
