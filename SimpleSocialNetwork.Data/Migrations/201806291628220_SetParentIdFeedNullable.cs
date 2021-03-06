using System.Data.Entity.Migrations;

namespace SimpleSocialNetwork.Data.Migrations
{
    public partial class SetParentIdFeedNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.feed", "parent_id", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.feed", "parent_id", c => c.Int(nullable: false));
        }
    }
}
