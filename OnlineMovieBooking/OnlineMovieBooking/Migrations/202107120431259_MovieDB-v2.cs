namespace OnlineMovieBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieDBv2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cities", "ZipCode", c => c.String(maxLength: 6));
            AlterColumn("dbo.Users", "Username", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Username", c => c.String());
            AlterColumn("dbo.Cities", "ZipCode", c => c.String());
        }
    }
}
