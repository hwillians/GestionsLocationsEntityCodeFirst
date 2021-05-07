namespace Models.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class auterstables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientID = c.Int(nullable: false),
                        VehiculeID = c.Int(nullable: false),
                        NbKm = c.Int(nullable: false),
                        DateDebut = c.DateTime(nullable: false),
                        DateFin = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientID, cascadeDelete: true)
                .ForeignKey("dbo.Vehicules", t => t.VehiculeID, cascadeDelete: true)
                .Index(t => t.ClientID)
                .Index(t => t.VehiculeID);
            
            CreateTable(
                "dbo.Vehicules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Immatriculation = c.String(nullable: false, maxLength: 50),
                        Modele = c.String(nullable: false, maxLength: 100),
                        Couleur = c.String(nullable: false, maxLength: 50),
                        MarqueID = c.Int(nullable: false),
                        CategorieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategorieID, cascadeDelete: true)
                .ForeignKey("dbo.Marques", t => t.MarqueID, cascadeDelete: true)
                .Index(t => t.MarqueID)
                .Index(t => t.CategorieID);
            
            CreateTable(
                "dbo.Marques",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Categories", "Libelle", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Locations", "VehiculeID", "dbo.Vehicules");
            DropForeignKey("dbo.Vehicules", "MarqueID", "dbo.Marques");
            DropForeignKey("dbo.Vehicules", "CategorieID", "dbo.Categories");
            DropForeignKey("dbo.Locations", "ClientID", "dbo.Clients");
            DropIndex("dbo.Vehicules", new[] { "CategorieID" });
            DropIndex("dbo.Vehicules", new[] { "MarqueID" });
            DropIndex("dbo.Locations", new[] { "VehiculeID" });
            DropIndex("dbo.Locations", new[] { "ClientID" });
            AlterColumn("dbo.Categories", "Libelle", c => c.String(nullable: false, maxLength: 30));
            DropTable("dbo.Marques");
            DropTable("dbo.Vehicules");
            DropTable("dbo.Locations");
        }
    }
}
