namespace Project_63135350.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSeo1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_Product", "SeoTitle");
            DropColumn("dbo.tb_Product", "SeoDescription");
            DropColumn("dbo.tb_Product", "SeoKeywords");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Product", "SeoKeywords", c => c.String(maxLength: 250));
            AddColumn("dbo.tb_Product", "SeoDescription", c => c.String(maxLength: 500));
            AddColumn("dbo.tb_Product", "SeoTitle", c => c.String(maxLength: 250));
        }
    }
}
