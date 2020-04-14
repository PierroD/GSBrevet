namespace BackEndGSBrevet.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BackEndGSBrevet.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BackEndGSBrevet.GSBrevetDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BackEndGSBrevet.GSBrevetDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
           // context.Users.AddOrUpdate( new User { last_name="Durand", first_name="Victor",   birth_date = new DateTime(2000, 02, 12), username="victordrnd", password="pwd" });
            // seed to create a user
        }
    }
}
