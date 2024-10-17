namespace Project_63135350.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMessageMoreorder : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Order", "Message", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Order", "Message");
        }
    }
}
