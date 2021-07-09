namespace OnlineMovieBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieDBv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingId = c.Int(nullable: false, identity: true),
                        NumberOfSeats = c.Int(nullable: false),
                        Time = c.DateTime(nullable: false),
                        Status = c.String(),
                        UserId = c.Int(nullable: false),
                        ShowId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookingId)
                .ForeignKey("dbo.Shows", t => t.ShowId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.ShowId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        Time = c.DateTime(nullable: false),
                        DiscountCouponId = c.String(),
                        RemoteTransactionId = c.String(),
                        PaymentMethod = c.String(),
                        BookingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentId)
                .ForeignKey("dbo.Bookings", t => t.BookingId, cascadeDelete: true)
                .Index(t => t.BookingId);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        ShowId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        CinemaHallId = c.Int(nullable: false),
                        MovieId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShowId)
                .ForeignKey("dbo.CinemaHalls", t => t.CinemaHallId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.CinemaHallId)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.CinemaHalls",
                c => new
                    {
                        CinemaHallId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TotalSeats = c.Int(nullable: false),
                        CinemaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CinemaHallId)
                .ForeignKey("dbo.Cinemas", t => t.CinemaId, cascadeDelete: true)
                .Index(t => t.CinemaId);
            
            CreateTable(
                "dbo.Cinemas",
                c => new
                    {
                        CinemaId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TotalHalls = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CinemaId)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.CinemaSeats",
                c => new
                    {
                        CinemaSeatId = c.Int(nullable: false, identity: true),
                        SeatNumber = c.String(),
                        Type = c.Int(nullable: false),
                        CinemaHallId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CinemaSeatId)
                .ForeignKey("dbo.CinemaHalls", t => t.CinemaHallId, cascadeDelete: true)
                .Index(t => t.CinemaHallId);
            
            CreateTable(
                "dbo.ShowSeats",
                c => new
                    {
                        ShowSeatId = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                        Price = c.Double(nullable: false),
                        CinemaSeatId = c.Int(nullable: false),
                        ShowId = c.Int(nullable: false),
                        BookingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ShowSeatId)
                .ForeignKey("dbo.Bookings", t => t.BookingId, cascadeDelete: true)
                .ForeignKey("dbo.CinemaSeats", t => t.CinemaSeatId, cascadeDelete: false)
                .ForeignKey("dbo.Shows", t => t.ShowId, cascadeDelete: false)
                .Index(t => t.CinemaSeatId)
                .Index(t => t.ShowId)
                .Index(t => t.BookingId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Language = c.String(),
                        Genre = c.String(),
                        Duration = c.Int(nullable: false),
                        Description = c.String(),
                        ReleaseDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.MovieId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Username = c.String(),
                        MobileNo = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "UserId", "dbo.Users");
            DropForeignKey("dbo.Shows", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.Shows", "CinemaHallId", "dbo.CinemaHalls");
            DropForeignKey("dbo.ShowSeats", "ShowId", "dbo.Shows");
            DropForeignKey("dbo.ShowSeats", "CinemaSeatId", "dbo.CinemaSeats");
            DropForeignKey("dbo.ShowSeats", "BookingId", "dbo.Bookings");
            DropForeignKey("dbo.CinemaSeats", "CinemaHallId", "dbo.CinemaHalls");
            DropForeignKey("dbo.Cinemas", "CityId", "dbo.Cities");
            DropForeignKey("dbo.CinemaHalls", "CinemaId", "dbo.Cinemas");
            DropForeignKey("dbo.Bookings", "ShowId", "dbo.Shows");
            DropForeignKey("dbo.Payments", "BookingId", "dbo.Bookings");
            DropIndex("dbo.ShowSeats", new[] { "BookingId" });
            DropIndex("dbo.ShowSeats", new[] { "ShowId" });
            DropIndex("dbo.ShowSeats", new[] { "CinemaSeatId" });
            DropIndex("dbo.CinemaSeats", new[] { "CinemaHallId" });
            DropIndex("dbo.Cinemas", new[] { "CityId" });
            DropIndex("dbo.CinemaHalls", new[] { "CinemaId" });
            DropIndex("dbo.Shows", new[] { "MovieId" });
            DropIndex("dbo.Shows", new[] { "CinemaHallId" });
            DropIndex("dbo.Payments", new[] { "BookingId" });
            DropIndex("dbo.Bookings", new[] { "ShowId" });
            DropIndex("dbo.Bookings", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Movies");
            DropTable("dbo.ShowSeats");
            DropTable("dbo.CinemaSeats");
            DropTable("dbo.Cities");
            DropTable("dbo.Cinemas");
            DropTable("dbo.CinemaHalls");
            DropTable("dbo.Shows");
            DropTable("dbo.Payments");
            DropTable("dbo.Bookings");
        }
    }
}
