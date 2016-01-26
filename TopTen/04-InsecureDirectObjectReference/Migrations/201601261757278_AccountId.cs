namespace _04_InsecureDirectObjectReference.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AccountId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "AccountId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Accounts", "AccountId");
        }
    }
}
