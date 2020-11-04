namespace ClinicManagement.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ClinicManagement.Persistence.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        public bool AutomaticMigrationsEnabled { get; }

        //protected override void Seed(ClinicManagement.Persistence.ApplicationDbContext context)
        //{
            
        //}
    }
}
