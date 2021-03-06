﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnico
{
    public class DaoProcesador : IDisposable
    {
        private BaseRepository<Procesador> repository;
        private DbContext context;

        public DaoProcesador()
        {
            context = new BaseContext();
            repository = new BaseRepository<Procesador>(context);
        }

        public void Dispose()
        {
            repository.Dispose();
            context.Dispose();
        }

        public Procesador Get(int id)
        {
            var entity = repository.Get(id);
            return entity;
        }

        public List<Procesador> GetProcesadores()
        {
            var query = repository.GetAll().Where(e => e.EstadoRegistro == General.Estados.Activo);
            var list = query.ToList();
            return list;
        }
    }
}
