using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTest
{
    public class GameDBContext : DbContext
    {
        public DbSet<ClassObj> ClassObjects { get; set; }
        public DbSet<RaceObj> RaceObjects { get; set; }
        public DbSet<ItemObj> ItemObjects { get; set; }
        public DbSet<CharacterObj> CharacterObjects { get; set; }

        public GameDBContext() : base("GameConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /* Creates the excluded items database, or class specific items */
            modelBuilder.Entity<ClassObj>()
                .HasMany(c => c.ExcludedItems)
                .WithMany()
                .Map(m =>
                {
                    m.MapLeftKey("ClassObjId");
                    m.MapRightKey("ItemObjId");
                    m.ToTable("ExcludedItemsDB");
                });

               
            base.OnModelCreating(modelBuilder);
        }
    }

}
