namespace XD_WEB.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoreAlias : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pages", "Alias", c => c.String(maxLength: 256));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pages", "Alias");
        }
    }
}
