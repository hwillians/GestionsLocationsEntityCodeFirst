namespace Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datefinnull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locations", "DateFin", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locations", "DateFin", c => c.DateTime(nullable: false));
        }
    }
}
