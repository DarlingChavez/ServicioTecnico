using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnico
{
    public class DaoTipoProducto
    {
        private BaseRepository<TipoProducto> repository;
        private DbContext context;

        public DaoTipoProducto()
        {
            context = new BaseContext();
            repository = new BaseRepository<TipoProducto>(context);
        }

        public TipoProducto Get(int id)
        {
            var entity = repository.Get(id);
            return entity;
        }

        public List<TipoProducto> GetTipoProducto()
        {
            var query = repository.GetAll().Where(e => e.EstadoRegistro == General.Estados.Activo);
            var list = query.ToList();
            return list;
        }
    }
}
