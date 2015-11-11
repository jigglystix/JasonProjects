using CharacterTest.Core.DataAccess;

namespace CharacterTest.Core.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CharacterTest.GameDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CharacterTest.GameDBContext context)
        {
            AddRaces(context);
        }

        public void AddRaces(GameDBContext context)
        {
            AddOneRace(context, 1, "Human", 7, 7, 7, 7, 7);
        }

        public void AddOneRace(GameDBContext context, int id, string name, int strength, int agility, int vitality, int dexterity,
            int intelligence)
        {
            var raceService = new RaceService(context);
            raceService.Insert(new RaceObj()
            {
                Id = id,
                Name = name,
                STRENGTH = strength,
                AGILITY = agility,
                VITALITY = vitality,
                DEXTERITY = dexterity,
                INTELLIGENCE = intelligence,
                CreatedUtc = DateTime.UtcNow
            });
        }
    }
}
