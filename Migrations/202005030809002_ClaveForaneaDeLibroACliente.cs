namespace LibreriaMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClaveForaneaDeLibroACliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Libroes", "ClienteId", c => c.Int(nullable: false));
            CreateIndex("dbo.Libroes", "ClienteId");
            AddForeignKey("dbo.Libroes", "ClienteId", "dbo.Clientes", "ClienteId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Libroes", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Libroes", new[] { "ClienteId" });
            DropColumn("dbo.Libroes", "ClienteId");
        }
    }
}
