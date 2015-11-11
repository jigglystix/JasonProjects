using System.Data.Entity;

namespace CharacterTest.Core.Migrations
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<GameDBContext>
    {
        protected override void Seed(GameDBContext context)
        { }
    }
}
