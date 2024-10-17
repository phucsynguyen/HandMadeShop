namespace Project_63135350.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData123 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Order", "TypePayment", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Order", "TypePayment");
        }
    }
}
