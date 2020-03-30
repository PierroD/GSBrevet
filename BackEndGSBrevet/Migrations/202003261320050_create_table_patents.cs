namespace BackEndGSBrevet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_patents : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.patents",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    molecule_id = c.Int(nullable: false),
                    company_id = c.Int(nullable: false),
                    country = c.String(maxLength: 255),
                    number = c.String(maxLength: 255),
                    deposit_date = c.DateTime(),
                    duration = c.Int(),
                })
                .PrimaryKey(t => new { t.id });
            AddForeignKey("dbo.patents", "molecule_id", "dbo.molecules", "id", cascadeDelete: true);
            AddForeignKey("dbo.patents", "company_id", "dbo.companies", "id", cascadeDelete: true);
        }


        public override void Down()
        {
            DropTable("dbo.patents");
        }
    }
}
