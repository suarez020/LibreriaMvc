namespace LibreriaMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autors",
                c => new
                    {
                        AutorId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        apellido = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Tematica = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.AutorId)
                .Index(t => new { t.Nombres, t.apellido }, name: "IX_NombreCompleto");
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombres = c.String(nullable: false, maxLength: 50),
                        apellido = c.String(nullable: false, maxLength: 50),
                        Identificacion = c.String(nullable: false, maxLength: 12),
                        Direccion = c.String(nullable: false, maxLength: 150),
                        Email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ClienteId)
                .Index(t => new { t.Nombres, t.apellido }, name: "IX_NombreCompleto")
                .Index(t => t.Identificacion, unique: true);
            
            CreateTable(
                "dbo.Libroes",
                c => new
                    {
                        libroId = c.Int(nullable: false, identity: true),
                        Titulo = c.String(nullable: false, maxLength: 50),
                        Tipolibro = c.String(nullable: false, maxLength: 50),
                        Editorial = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.libroId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Clientes", new[] { "Identificacion" });
            DropIndex("dbo.Clientes", "IX_NombreCompleto");
            DropIndex("dbo.Autors", "IX_NombreCompleto");
            DropTable("dbo.Libroes");
            DropTable("dbo.Clientes");
            DropTable("dbo.Autors");
        }
    }
}
