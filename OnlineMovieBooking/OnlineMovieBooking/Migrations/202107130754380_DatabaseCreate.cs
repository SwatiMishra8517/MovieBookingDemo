namespace OnlineMovieBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseCreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "MobileNo", c => c.String(nullable: false, maxLength: 10));
            CreateIndex("dbo.Users", "Username", unique: true);
            CreateIndex("dbo.Users", "MobileNo", unique: true);
            CreateIndex("dbo.Users", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "MobileNo" });
            DropIndex("dbo.Users", new[] { "Username" });
            AlterColumn("dbo.Users", "MobileNo", c => c.String(nullable: false));
        }
    }
}
