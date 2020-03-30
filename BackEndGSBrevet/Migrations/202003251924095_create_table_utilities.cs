namespace BackEndGSBrevet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_utilities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.utilities",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    molecule_id = c.Int(nullable: false),
                    name = c.String(maxLength: 255),
                    description = c.String(maxLength: 255),
                })
                .PrimaryKey(t => new { t.id });
            AddForeignKey("dbo.utilities", "molecule_id", "dbo.molecules", "id", cascadeDelete: true);

        }

        // 1 molecule has many utility   
        // with ef syntaxe = many utilities have 1 molecule

        public override void Down()
        {
            DropTable("dbo.utilities");
        }
    }
}
