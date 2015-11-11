using System.Data.Entity.Migrations;

namespace CharacterTest.Core.Migrations
{
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CharacterObjs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100),
                        ClassObjId = c.Int(nullable: false),
                        RaceObjId = c.Int(nullable: false),
                        CreatedUtc = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 100),
                        LastModifiedUTC = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClassObjs", t => t.ClassObjId, cascadeDelete: true)
                .ForeignKey("dbo.RaceObjs", t => t.RaceObjId, cascadeDelete: true)
                .Index(t => t.ClassObjId)
                .Index(t => t.RaceObjId);
            
            CreateTable(
                "dbo.ClassObjs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        STRModifier = c.Int(nullable: false),
                        AGIModifier = c.Int(nullable: false),
                        VITModifier = c.Int(nullable: false),
                        INTModifier = c.Int(nullable: false),
                        DEXModifier = c.Int(nullable: false),
                        CreatedUtc = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 100),
                        LastModifiedUTC = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ItemObjs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ItemName = c.String(nullable: false, maxLength: 100),
                        IsConsumable = c.Boolean(nullable: false),
                        IsEquippable = c.Boolean(nullable: false),
                        Weight = c.Int(nullable: false),
                        STRModify = c.Int(nullable: false),
                        AGIModify = c.Int(nullable: false),
                        VITModify = c.Int(nullable: false),
                        INTModify = c.Int(nullable: false),
                        DEXModify = c.Int(nullable: false),
                        CreatedUtc = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 100),
                        LastModifiedUTC = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RaceObjs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        STRENGTH = c.Int(nullable: false),
                        AGILITY = c.Int(nullable: false),
                        VITALITY = c.Int(nullable: false),
                        INTELLIGENCE = c.Int(nullable: false),
                        DEXTERITY = c.Int(nullable: false),
                        CreatedUtc = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 100),
                        LastModifiedUTC = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InventoryObjs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CharacterObjId = c.Int(nullable: false),
                        ItemObjId = c.Int(nullable: false),
                        ItemName = c.String(),
                        IsConsumable = c.Boolean(nullable: false),
                        IsEquippable = c.Boolean(nullable: false),
                        Weight = c.Int(nullable: false),
                        STRModify = c.Int(nullable: false),
                        AGIModify = c.Int(nullable: false),
                        VITModify = c.Int(nullable: false),
                        INTModify = c.Int(nullable: false),
                        DEXModify = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        CreatedUtc = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 100),
                        LastModifiedUTC = c.DateTime(),
                        LastModifiedBy = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemObjs", t => t.ItemObjId, cascadeDelete: true)
                .ForeignKey("dbo.CharacterObjs", t => t.CharacterObjId, cascadeDelete: true)
                .Index(t => t.CharacterObjId)
                .Index(t => t.ItemObjId);
            
            CreateTable(
                "dbo.ExcludedItemsDB",
                c => new
                    {
                        ClassObjId = c.Int(nullable: false),
                        ItemObjId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClassObjId, t.ItemObjId })
                .ForeignKey("dbo.ClassObjs", t => t.ClassObjId, cascadeDelete: true)
                .ForeignKey("dbo.ItemObjs", t => t.ItemObjId, cascadeDelete: true)
                .Index(t => t.ClassObjId)
                .Index(t => t.ItemObjId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InventoryObjs", "CharacterObjId", "dbo.CharacterObjs");
            DropForeignKey("dbo.InventoryObjs", "ItemObjId", "dbo.ItemObjs");
            DropForeignKey("dbo.CharacterObjs", "RaceObjId", "dbo.RaceObjs");
            DropForeignKey("dbo.CharacterObjs", "ClassObjId", "dbo.ClassObjs");
            DropForeignKey("dbo.ExcludedItemsDB", "ItemObjId", "dbo.ItemObjs");
            DropForeignKey("dbo.ExcludedItemsDB", "ClassObjId", "dbo.ClassObjs");
            DropIndex("dbo.ExcludedItemsDB", new[] { "ItemObjId" });
            DropIndex("dbo.ExcludedItemsDB", new[] { "ClassObjId" });
            DropIndex("dbo.InventoryObjs", new[] { "ItemObjId" });
            DropIndex("dbo.InventoryObjs", new[] { "CharacterObjId" });
            DropIndex("dbo.CharacterObjs", new[] { "RaceObjId" });
            DropIndex("dbo.CharacterObjs", new[] { "ClassObjId" });
            DropTable("dbo.ExcludedItemsDB");
            DropTable("dbo.InventoryObjs");
            DropTable("dbo.RaceObjs");
            DropTable("dbo.ItemObjs");
            DropTable("dbo.ClassObjs");
            DropTable("dbo.CharacterObjs");
        }
    }
}
