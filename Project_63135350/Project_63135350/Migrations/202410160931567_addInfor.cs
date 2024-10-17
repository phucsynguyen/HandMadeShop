namespace Project_63135350.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addInfor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomerInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        Message = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CustomerInfoes");
        }
    }
}
