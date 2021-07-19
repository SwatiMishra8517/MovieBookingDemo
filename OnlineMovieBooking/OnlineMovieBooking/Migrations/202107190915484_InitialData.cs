namespace OnlineMovieBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        FeedbackId = c.Int(nullable: false, identity: true),
                        Rating = c.Int(nullable: false),
                        Review = c.String(nullable: false),
                        UserId = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FeedbackId)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.MovieId);
            
            AlterColumn("dbo.CinemaHalls", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Cinemas", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Cities", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Cities", "State", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.ShowSeats", "Status", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Movies", "Language", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "Username", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Users", "MobileNo", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false));
            CreateIndex("dbo.Users", "Username", unique: true);
            CreateIndex("dbo.Users", "MobileNo", unique: true);
            CreateIndex("dbo.Users", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Feedbacks", "UserId", "dbo.Users");
            DropForeignKey("dbo.Feedbacks", "MovieId", "dbo.Movies");
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "MobileNo" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Feedbacks", new[] { "MovieId" });
            DropIndex("dbo.Feedbacks", new[] { "UserId" });
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Email", c => c.String());
            AlterColumn("dbo.Users", "MobileNo", c => c.String());
            AlterColumn("dbo.Users", "Username", c => c.String(maxLength: 15));
            AlterColumn("dbo.Users", "Name", c => c.String());
            AlterColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            AlterColumn("dbo.Movies", "Description", c => c.String());
            AlterColumn("dbo.Movies", "Language", c => c.String());
            AlterColumn("dbo.Movies", "Name", c => c.String());
            AlterColumn("dbo.ShowSeats", "Status", c => c.String());
            AlterColumn("dbo.Cities", "State", c => c.String());
            AlterColumn("dbo.Cities", "Name", c => c.String());
            AlterColumn("dbo.Cinemas", "Name", c => c.String());
            AlterColumn("dbo.CinemaHalls", "Name", c => c.String());
            DropTable("dbo.Feedbacks");
        }
    }
}
