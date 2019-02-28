using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnico
{
    public class DaoMotivoCierre
    {
        private BaseRepository<MotivoCierre> repository;
        private DbContext context;

        public DaoMotivoCierre()
        {
            context = new BaseContext();
            repository = new BaseRepository<MotivoCierre>(context);
        }

        public MotivoCierre Get(int id)
        {
            var entity = repository.Get(id);
            return entity;
        }

        public List<MotivoCierre> GetMotivosCierre()
        {
            var query = repository.GetAll().Where(e => e.EstadoRegistro == General.Estados.Activo);
            var list = query.ToList();
            return list;
        }
    }
}
