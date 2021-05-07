namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atributunique : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Categories", "Libelle", unique: true);
            CreateIndex("dbo.Marques", "Nom", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Marques", new[] { "Nom" });
            DropIndex("dbo.Categories", new[] { "Libelle" });
        }
    }
}
