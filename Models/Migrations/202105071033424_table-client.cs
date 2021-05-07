namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tableclient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 50),
                        Prenom = c.String(nullable: false, maxLength: 50),
                        DateNaissance = c.DateTime(nullable: false),
                        Adresse = c.String(maxLength: 150),
                        CodePostal = c.String(maxLength: 15),
                        Ville = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
