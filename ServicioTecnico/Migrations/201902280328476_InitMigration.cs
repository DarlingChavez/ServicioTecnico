namespace ServicioTecnico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipos",
                c => new
                    {
                        IdEquipo = c.Int(nullable: false, identity: true),
                        IdMarca = c.Int(nullable: false),
                        IdProcesador = c.Int(nullable: false),
                        Cliente = c.String(),
                        Descripcion = c.String(),
                        SerieMainBoard = c.String(),
                        IdEstado = c.Int(nullable: false),
                        IdMotivoCierre = c.Int(nullable: false),
                        FechaIngreso = c.DateTime(nullable: false),
                        EstadoRegistro = c.String(),
                    })
                .PrimaryKey(t => t.IdEquipo)
                .ForeignKey("dbo.Estados", t => t.IdEstado)
                .ForeignKey("dbo.Marcas", t => t.IdMarca)
                .ForeignKey("dbo.MotivosCierre", t => t.IdMotivoCierre)
                .ForeignKey("dbo.Procesadores", t => t.IdProcesador)
                .Index(t => t.IdMarca)
                .Index(t => t.IdProcesador)
                .Index(t => t.IdEstado)
                .Index(t => t.IdMotivoCierre);
            
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        IdEstado = c.Int(nullable: false),
                        Tipo = c.String(),
                        Descripcion = c.String(),
                        EstadoRegistro = c.String(),
                    })
                .PrimaryKey(t => t.IdEstado);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        IdMarca = c.Int(nullable: false),
                        Descripcion = c.String(),
                        EstadoRegistro = c.String(),
                    })
                .PrimaryKey(t => t.IdMarca);
            
            CreateTable(
                "dbo.MotivosCierre",
                c => new
                    {
                        IdMotivoCierre = c.Int(nullable: false),
                        Descripcion = c.String(),
                        EstadoRegistro = c.String(),
                    })
                .PrimaryKey(t => t.IdMotivoCierre);
            
            CreateTable(
                "dbo.Procesadores",
                c => new
                    {
                        IdProcesador = c.Int(nullable: false),
                        Descripcion = c.String(),
                        Fabricante = c.String(),
                        EstadoRegistro = c.String(),
                    })
                .PrimaryKey(t => t.IdProcesador);
            
            CreateTable(
                "dbo.Garantias",
                c => new
                    {
                        IdGarantia = c.Int(nullable: false),
                        Indice = c.Byte(nullable: false),
                        IdEquipo = c.Int(nullable: false),
                        Descripcion = c.String(),
                        IdEstado = c.Int(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        EstadoRegistro = c.String(),
                    })
                .PrimaryKey(t => t.IdGarantia)
                .ForeignKey("dbo.Equipos", t => t.IdEquipo)
                .ForeignKey("dbo.Estados", t => t.IdEstado)
                .Index(t => t.IdEquipo)
                .Index(t => t.IdEstado);
            
            CreateTable(
                "dbo.Inventario",
                c => new
                    {
                        IdInventario = c.Int(nullable: false),
                        Descripcion = c.String(),
                        IdTipoProducto = c.Int(nullable: false),
                        Origen = c.String(),
                        Compra = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Venta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FechaCompra = c.DateTime(nullable: false),
                        FechaVenta = c.DateTime(nullable: false),
                        IdEstado = c.Int(nullable: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        EstadoRegistro = c.String(),
                    })
                .PrimaryKey(t => t.IdInventario)
                .ForeignKey("dbo.Estados", t => t.IdEstado)
                .ForeignKey("dbo.TiposProducto", t => t.IdTipoProducto)
                .Index(t => t.IdTipoProducto)
                .Index(t => t.IdEstado);
            
            CreateTable(
                "dbo.TiposProducto",
                c => new
                    {
                        IdTipoProducto = c.Int(nullable: false),
                        Descripcion = c.String(),
                        EstadoRegistro = c.String(),
                    })
                .PrimaryKey(t => t.IdTipoProducto);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inventario", "IdTipoProducto", "dbo.TiposProducto");
            DropForeignKey("dbo.Inventario", "IdEstado", "dbo.Estados");
            DropForeignKey("dbo.Garantias", "IdEstado", "dbo.Estados");
            DropForeignKey("dbo.Garantias", "IdEquipo", "dbo.Equipos");
            DropForeignKey("dbo.Equipos", "IdProcesador", "dbo.Procesadores");
            DropForeignKey("dbo.Equipos", "IdMotivoCierre", "dbo.MotivosCierre");
            DropForeignKey("dbo.Equipos", "IdMarca", "dbo.Marcas");
            DropForeignKey("dbo.Equipos", "IdEstado", "dbo.Estados");
            DropIndex("dbo.Inventario", new[] { "IdEstado" });
            DropIndex("dbo.Inventario", new[] { "IdTipoProducto" });
            DropIndex("dbo.Garantias", new[] { "IdEstado" });
            DropIndex("dbo.Garantias", new[] { "IdEquipo" });
            DropIndex("dbo.Equipos", new[] { "IdMotivoCierre" });
            DropIndex("dbo.Equipos", new[] { "IdEstado" });
            DropIndex("dbo.Equipos", new[] { "IdProcesador" });
            DropIndex("dbo.Equipos", new[] { "IdMarca" });
            DropTable("dbo.TiposProducto");
            DropTable("dbo.Inventario");
            DropTable("dbo.Garantias");
            DropTable("dbo.Procesadores");
            DropTable("dbo.MotivosCierre");
            DropTable("dbo.Marcas");
            DropTable("dbo.Estados");
            DropTable("dbo.Equipos");
        }
    }
}
