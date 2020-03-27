namespace BackEndGSBrevet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_roles : DbMigration
    {
        public override void Up()
        {
            CreateTable("dbo.roles",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    libelle = c.String(maxLength: 255),
                }).PrimaryKey(t => t.id)
                ;
        }

        public override void Down()
        {
            DropTable("dbo.roles");
        }
    }
}
