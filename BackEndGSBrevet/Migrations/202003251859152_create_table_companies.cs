namespace BackEndGSBrevet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_companies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.companies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(maxLength: 255),
                        address = c.String(maxLength: 255),
                        city = c.String(maxLength: 255),
                        zip_code = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.companies");
        }
    }
}
