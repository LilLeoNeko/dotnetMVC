using dotNetFrameworkMVC_MoshProject.Models;

namespace dotNetFrameworkMVC_MoshProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<dotNetFrameworkMVC_MoshProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(dotNetFrameworkMVC_MoshProject.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Customers.AddOrUpdate(x=>x.Id,
                new Customer(){Name = "John Smith", IsSubscribed = false, MembershipId = 1},
                new Customer() { Name = "Mary Williams", IsSubscribed = true, MembershipId = 2}
                );
        }
    }
}
