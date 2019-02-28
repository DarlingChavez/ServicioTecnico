using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServicioTecnico
{
    public class BaseContext : DbContext
    {
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Garantia> Garantias { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        public DbSet<MotivoCierre> Motivos { get; set; }
        public DbSet<TipoProducto> Tipos { get; set; }

        public BaseContext() : base("name=defaultconnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

            CrearRelaciones(ref modelBuilder);

            //CrearIndentities(ref modelBuilder);

        }

        //private void CrearIndentities(ref DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Equipo>().Property(x => x.IdEquipo).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        //    modelBuilder.Entity<Garantia>().Property(x => x.IdGarantia).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        //    modelBuilder.Entity<Inventario>().Property(x => x.IdInventario).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        //}

        /// <summary>
        /// Crear las foreign keys
        /// </summary>
        /// <param name="modelBuilder"></param>
        private void CrearRelaciones(ref DbModelBuilder modelBuilder)
        {
            //relacion equipo - marca
            modelBuilder.Entity<Equipo>()
            .HasRequired<Marca>(x => x.Marca)
            .WithMany()
            .WillCascadeOnDelete(false);
            //relacion equipo - procesador
            modelBuilder.Entity<Equipo>()
            .HasRequired<Procesador>(x => x.Procesador)
            .WithMany()
            .WillCascadeOnDelete(false);
            //relacion equipo - estado
            modelBuilder.Entity<Equipo>()
            .HasRequired<Estado>(x => x.Estado)
            .WithMany()
            .WillCascadeOnDelete(false);
            //relacion equipo - motivo cierre
            modelBuilder.Entity<Equipo>()
            .HasRequired<MotivoCierre>(x => x.MotivoCierre)
            .WithMany()
            .WillCascadeOnDelete(false);
            //************************************************************
            //relacion garantia - equipo
            modelBuilder.Entity<Garantia>()
            .HasRequired<Equipo>(x => x.Equipo)
            .WithMany()
            .WillCascadeOnDelete(false);
            //relacion garantia - estado
            modelBuilder.Entity<Garantia>()
            .HasRequired<Estado>(x => x.Estado)
            .WithMany()
            .WillCascadeOnDelete(false);
            //************************************************************
            //relacion inventario - tipoProducto
            modelBuilder.Entity<Inventario>()
            .HasRequired<TipoProducto>(x => x.TipoProducto)
            .WithMany()
            .WillCascadeOnDelete(false);
            //relacion inventario - estado
            modelBuilder.Entity<Inventario>()
            .HasRequired<Estado>(x => x.Estado)
            .WithMany()
            .WillCascadeOnDelete(false);
        }
    }
}
