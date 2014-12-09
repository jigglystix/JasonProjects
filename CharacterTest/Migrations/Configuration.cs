namespace CharacterTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CharacterTest.GameDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CharacterTest.GameDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.RaceObjects.AddOrUpdate(
                r => r.Name,
                new RaceObj
                {
                    Name = "Elf",
                    STRENGTH = 10,
                    AGILITY = 15,
                    VITALITY = 10,
                    INTELLIGENCE = 20,
                    DEXTERITY = 15,
                    CreatedUtc = DateTime.UtcNow,
                    CreatedBy = "seed"
                });
        }
    }
}
