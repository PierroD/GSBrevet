namespace BackEndGSBrevet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class create_table_molecules : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.molecules",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    generic_name = c.String(maxLength: 255),
                    real_name = c.String(maxLength: 255),
                    formula = c.String(maxLength: 255),
                })
                .PrimaryKey(t => t.id);

        }

        public override void Down()
        {
            DropTable("dbo.molecules");
        }
    }
}
