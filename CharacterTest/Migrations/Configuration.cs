namespace CharacterTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CharacterTest.Core;
    using CharacterTest.Core.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CharacterTest.GameDBContext>
    {
        RaceObj race = new RaceObj();
        ClassObj cla = new ClassObj();

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GameDBContext context)
        {

            context.RaceObjects.AddOrUpdate(
                r => r.Name,
                new RaceObj
                {
                    Name = race.Name,
                    STRENGTH = race.STRENGTH,
                    AGILITY = race.AGILITY,
                    VITALITY = race.VITALITY,
                    INTELLIGENCE = race.INTELLIGENCE,
                    DEXTERITY = race.DEXTERITY,
                    CreatedUtc = DateTime.UtcNow,
                    CreatedBy = "seed"
                });

            context.ClassObjects.AddOrUpdate(
                c => c.Name,
                new ClassObj
                {
                    Name = cla.Name,
                    STRModifier = cla.STRModifier,
                    AGIModifier = cla.AGIModifier,
                    VITModifier = cla.VITModifier,
                    INTModifier = cla.INTModifier,
                    DEXModifier = cla.DEXModifier,
                    CreatedUtc = DateTime.UtcNow,
                    CreatedBy = "seed"
                });
        }
    }
}
