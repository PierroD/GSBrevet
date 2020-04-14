namespace BackEndGSBrevet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_users : DbMigration
    {
        public override void Up()
        {
            CreateTable("dbo.users",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    last_name = c.String(maxLength: 255),
                    first_name = c.String(maxLength: 255),
                    birth_date = c.DateTime(),
                    username = c.String(maxLength: 255),
                    password = c.String(maxLength: 255),
                }).PrimaryKey(t => t.id)
                ; 
        }

        public override void Down()
        {
            DropTable("dbo.users");
        }
    }
}
