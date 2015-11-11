using System.Data.Entity;
using CharacterTest.Core.DataAccess;

namespace CharacterTest.Core.Migrations
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<GameDBContext>
    {
        protected override void Seed(GameDBContext context)
        {
            
        }

       
    }
}


//strength, agility, vitality, dexterity, intelligence