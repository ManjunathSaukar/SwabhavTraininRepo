namespace AccountDALLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v12_accountTransaction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "Account_Id", c => c.Int());
            CreateIndex("dbo.Transactions", "Account_Id");
            AddForeignKey("dbo.Transactions", "Account_Id", "dbo.Accounts", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "Account_Id", "dbo.Accounts");
            DropIndex("dbo.Transactions", new[] { "Account_Id" });
            DropColumn("dbo.Transactions", "Account_Id");
        }
    }
}
