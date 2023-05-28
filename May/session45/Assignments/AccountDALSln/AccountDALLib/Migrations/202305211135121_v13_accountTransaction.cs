namespace AccountDALLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v13_accountTransaction : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Transactions", "AvailableBalance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Transactions", "Balance");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Transactions", "Balance", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Transactions", "AvailableBalance");
            DropColumn("dbo.Transactions", "Amount");
        }
    }
}
