namespace homework_theme_18.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<homework_theme_18.BeanMagas>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "homework_theme_18.BeanMagas";
        }

        protected override void Seed(homework_theme_18.BeanMagas context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
