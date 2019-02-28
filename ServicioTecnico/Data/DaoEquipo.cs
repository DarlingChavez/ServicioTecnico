using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnico
{
    public class DaoEquipo
    {
        private BaseRepository<Equipo> repository;
        private DbContext context;

        public DaoEquipo()
        {
            context = new BaseContext();
            repository = new BaseRepository<Equipo>(context);
        }

        public Equipo Get(int id)
        {
            var entity = repository.Get(id);
            return entity;
        }

        public List<Equipo> GetEquipos()
        {
            var query = repository.GetAll().Where(e=>e.EstadoRegistro == General.Estados.Activo);
            var list = query.ToList();
            return list;
        }

        public List<Equipo> FindEquipos(DateTime desde, DateTime hasta)
        {
            var query = repository.Find(x => x.FechaIngreso >= desde && x.FechaIngreso <= hasta);
            var list = query.ToList();
            return list;
        }

        public bool Insert(Equipo entity)
        {
            repository.Insert(entity);
            bool save = repository.SaveChanges();
            return save;
        }
        
        public bool Update(Equipo entity)
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
