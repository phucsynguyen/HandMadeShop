namespace Project_63135350.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateOrder : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_OrderDetail", "CreatedBy");
            DropColumn("dbo.tb_OrderDetail", "CreatedDate");
            DropColumn("dbo.tb_OrderDetail", "ModifiedDate");
            DropColumn("dbo.tb_OrderDetail", "ModifiedBy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_OrderDetail", "ModifiedBy", c => c.String());
            AddColumn("dbo.tb_OrderDetail", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_OrderDetail", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_OrderDetail", "CreatedBy", c => c.String());
        }
    }
}
