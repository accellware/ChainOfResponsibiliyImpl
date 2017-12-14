namespace ChainOfRespImpl.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ChainOfRespImpl.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            
        }

        protected override void Seed(ChainOfRespImpl.Models.ApplicationDbContext context)
        {
            // Disable lazy laoding
            context.Configuration.LazyLoadingEnabled = false;
        }
    }
}
