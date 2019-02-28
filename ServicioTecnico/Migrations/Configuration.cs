namespace ServicioTecnico.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<ServicioTecnico.BaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ServicioTecnico.BaseContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            InsertEstados(ref context);
            InsertMarcas(ref context);
            InsertMotivosCierre(ref context);
            InsertProcesadores(ref context);
            InsertTiposProducto(ref context);
        }

        private void InsertTiposProducto(ref BaseContext context)
        {
            context.Database.ExecuteSqlCommand("DELETE FROM [TiposProducto]");

            IList<TipoProducto> defaultTipo = new List<TipoProducto>();

            defaultTipo.Add(new TipoProducto() { IdTipoProducto = 1, Descripcion = "Sin especificar", EstadoRegistro = "A" });
            defaultTipo.Add(new TipoProducto() { IdTipoProducto = 2, Descripcion = "PC Desktop", EstadoRegistro = "A" });
            defaultTipo.Add(new TipoProducto() { IdTipoProducto = 3, Descripcion = "Laptop", EstadoRegistro = "A" });
            defaultTipo.Add(new TipoProducto() { IdTipoProducto = 4, Descripcion = "Ram", EstadoRegistro = "A" });
            defaultTipo.Add(new TipoProducto() { IdTipoProducto = 5, Descripcion = "Procesador", EstadoRegistro = "A" });
            defaultTipo.Add(new TipoProducto() { IdTipoProducto = 6, Descripcion = "Disco Duro", EstadoRegistro = "A" });
            defaultTipo.Add(new TipoProducto() { IdTipoProducto = 7, Descripcion = "Pantalla", EstadoRegistro = "A" });
            defaultTipo.Add(new TipoProducto() { IdTipoProducto = 8, Descripcion = "Bateria", EstadoRegistro = "A" });
            defaultTipo.Add(new TipoProducto() { IdTipoProducto = 9, Descripcion = "Cargador", EstadoRegistro = "A" });
            
            context.Tipos.AddRange(defaultTipo);

            base.Seed(context);

        }

        private void InsertProcesadores(ref BaseContext context)
        {
            context.Database.ExecuteSqlCommand("DELETE FROM [Procesadores]");

            IList<Procesador> defaultProcesador = new List<Procesador>();

            defaultProcesador.Add(new Procesador() { IdProcesador = 1, Descripcion = "Sin especificar", Fabricante = "Sin especificar", EstadoRegistro = "A" });
            defaultProcesador.Add(new Procesador() { IdProcesador = 2, Descripcion = "Dual Core", Fabricante = "Intel", EstadoRegistro = "A" });
            defaultProcesador.Add(new Procesador() { IdProcesador = 3, Descripcion = "Core 2 Duo", Fabricante = "Intel", EstadoRegistro = "A" });
            defaultProcesador.Add(new Procesador() { IdProcesador = 4, Descripcion = "Core I3", Fabricante = "Intel", EstadoRegistro = "A" });
            defaultProcesador.Add(new Procesador() { IdProcesador = 5, Descripcion = "Core I5", Fabricante = "Intel", EstadoRegistro = "A" });
            defaultProcesador.Add(new Procesador() { IdProcesador = 6, Descripcion = "Core I7", Fabricante = "Intel", EstadoRegistro = "A" });
            defaultProcesador.Add(new Procesador() { IdProcesador = 7, Descripcion = "Core I9", Fabricante = "Intel", EstadoRegistro = "A" });
            defaultProcesador.Add(new Procesador() { IdProcesador = 8, Descripcion = "Otro", Fabricante = "Sin especificar", EstadoRegistro = "A" });
            defaultProcesador.Add(new Procesador() { IdProcesador = 9, Descripcion = "Ryzen™ Threadripper", Fabricante = "AMD", EstadoRegistro = "A" });
            defaultProcesador.Add(new Procesador() { IdProcesador = 10, Descripcion = "Ryzen™ con gráficos Radeon™ Vega", Fabricante = "AMD", EstadoRegistro = "A" });
            defaultProcesador.Add(new Procesador() { IdProcesador = 11, Descripcion = "Athlon™ con gráficos Radeon™ Vega", Fabricante = "AMD", EstadoRegistro = "A" });
            defaultProcesador.Add(new Procesador() { IdProcesador = 12, Descripcion = "Serie A™ con gráficos Radeon™", Fabricante = "AMD", EstadoRegistro = "A" });
            defaultProcesador.Add(new Procesador() { IdProcesador = 13, Descripcion = "FX™", Fabricante = "AMD", EstadoRegistro = "A" });
            defaultProcesador.Add(new Procesador() { IdProcesador = 14, Descripcion = "Ryzen™ PRO", Fabricante = "AMD", EstadoRegistro = "A" });
            defaultProcesador.Add(new Procesador() { IdProcesador = 15, Descripcion = "Athlon™ PRO con gráficos Radeon™ Vega", Fabricante = "AMD", EstadoRegistro = "A" });
            defaultProcesador.Add(new Procesador() { IdProcesador = 16, Descripcion = "PRO Serie A", Fabricante = "AMD", EstadoRegistro = "A" }); 

            context.Procesadores.AddRange(defaultProcesador);

            base.Seed(context);

        }

        private void InsertMotivosCierre(ref BaseContext context)
        {
            context.Database.ExecuteSqlCommand("DELETE FROM [MotivosCierre]");

            IList<MotivoCierre> defaultMotivo = new List<MotivoCierre>();

            defaultMotivo.Add(new MotivoCierre() { IdMotivoCierre = 1, Descripcion = "Recibido", EstadoRegistro = "A" });
            defaultMotivo.Add(new MotivoCierre() { IdMotivoCierre = 2, Descripcion = "En proceso de arreglo", EstadoRegistro = "A" });
            defaultMotivo.Add(new MotivoCierre() { IdMotivoCierre = 3, Descripcion = "Arreglado y entregado", EstadoRegistro = "A" });
            defaultMotivo.Add(new MotivoCierre() { IdMotivoCierre = 4, Descripcion = "Entregado sin arreglar", EstadoRegistro = "A" });
            defaultMotivo.Add(new MotivoCierre() { IdMotivoCierre = 5, Descripcion = "Comprado", EstadoRegistro = "A" });
            defaultMotivo.Add(new MotivoCierre() { IdMotivoCierre = 6, Descripcion = "Abandonado", EstadoRegistro = "A" });

            context.Motivos.AddRange(defaultMotivo);

            base.Seed(context);

        }

        private void InsertMarcas(ref BaseContext context)
        {
            context.Database.ExecuteSqlCommand("DELETE FROM [Marcas]");

            IList<Marca> defaultMarca = new List<Marca>();

            defaultMarca.Add(new Marca() { IdMarca = 1, Descripcion = "Sin especificar", EstadoRegistro = "A" });
            defaultMarca.Add(new Marca() { IdMarca = 2, Descripcion = "DELL", EstadoRegistro = "A" });
            defaultMarca.Add(new Marca() { IdMarca = 3, Descripcion = "HP", EstadoRegistro = "A" });
            defaultMarca.Add(new Marca() { IdMarca = 4, Descripcion = "Lenovo", EstadoRegistro = "A" });
            defaultMarca.Add(new Marca() { IdMarca = 5, Descripcion = "Acer", EstadoRegistro = "A" });
            defaultMarca.Add(new Marca() { IdMarca = 6, Descripcion = "SONY", EstadoRegistro = "A" });
            defaultMarca.Add(new Marca() { IdMarca = 7, Descripcion = "Asus", EstadoRegistro = "A" });

            context.Marcas.AddRange(defaultMarca);
            
            base.Seed(context);

        }

        private void InsertEstados(ref BaseContext context)
        {
            context.Database.ExecuteSqlCommand("DELETE FROM [Estados]");

            IList<Estado> defaultEstados = new List<Estado>();

            defaultEstados.Add(new Estado() { IdEstado = 1, Descripcion = "Recibido", Tipo="Mantenimiento", EstadoRegistro="A" });
            defaultEstados.Add(new Estado() { IdEstado = 2, Descripcion = "En Proceso", Tipo = "Mantenimiento", EstadoRegistro = "A" });
            defaultEstados.Add(new Estado() { IdEstado = 3, Descripcion = "Entregado", Tipo = "Mantenimiento", EstadoRegistro = "A" });
            defaultEstados.Add(new Estado() { IdEstado = 4, Descripcion = "Devuelto", Tipo = "Garantia", EstadoRegistro = "A" });
            defaultEstados.Add(new Estado() { IdEstado = 5, Descripcion = "En Proceso", Tipo = "Garantia", EstadoRegistro = "A" });
            defaultEstados.Add(new Estado() { IdEstado = 6, Descripcion = "Entregado", Tipo = "Garantia", EstadoRegistro = "A" });

            context.Estados.AddRange(defaultEstados);

            base.Seed(context);

        }

    }
}
