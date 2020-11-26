namespace LibreriaMvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClaveForaneaDeLibroAAutor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Libroes", "AutorId", c => c.Int(nullable: false));
            CreateIndex("dbo.Libroes", "AutorId");
            AddForeignKey("dbo.Libroes", "AutorId", "dbo.Autors", "AutorId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Libroes", "AutorId", "dbo.Autors");
            DropIndex("dbo.Libroes", new[] { "AutorId" });
            DropColumn("dbo.Libroes", "AutorId");
        }
    }
}
