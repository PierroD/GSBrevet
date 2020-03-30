namespace BackEndGSBrevet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class create_table_contracts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.contracts",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    company_id = c.Int(nullable: false),
                    patent_id = c.Int(nullable: false),
                    create_date = c.DateTime(),
                    duration = c.Int(),
                    price = c.Double(),
                })
                .PrimaryKey(t => new { t.id });
            AddForeignKey("dbo.contracts", "company_id", "dbo.companies", "id", cascadeDelete: true);
            AddForeignKey("dbo.contracts", "patent_id", "dbo.patents", "id", cascadeDelete: false);
        }

        public override void Down()
        {
            DropTable("dbo.contracts");
        }
    }
}
