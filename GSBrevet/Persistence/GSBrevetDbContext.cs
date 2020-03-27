namespace BackEndGSBrevet
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using BackEndGSBrevet.Models;
    public class GSBrevetDbContext : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « GSBrevetDbContext » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « BackEndGSBrevet.GSBrevetDbContext » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « GSBrevetDbContext » dans le fichier de configuration de l'application.
        /*
        - bdd mysql :
         connectionString="server=localhost;user id=root;password=root;database=gsbapp" providerName="MySql.Data.MySqlClient"
        - bdd sql :
        connectionString="data source=(LocalDb)\MSSQLLocalDB;initial catalog=BackEndGSBrevet.GSBrevetDbContext;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework" providerName="System.Data.SqlClient"
          
        Pour se connecter à Microsoft SQL Server Management Studio : (LocalDb)\MSSQLLocalDB
             */
        public GSBrevetDbContext()
            : base("name=GSBrevetDbContext")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<GSBrevetDbContext>());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Molecule> Molecules { get; set; }
        public DbSet<Utility> Utilities { get; set; }
        public DbSet<Patent> Patents { get; set; }
        public DbSet<Contract> Contracts { get; set; }


        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}