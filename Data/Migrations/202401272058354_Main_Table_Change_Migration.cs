namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Main_Table_Change_Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Certificates",
                c => new
                    {
                        CertificateId = c.Int(nullable: false, identity: true),
                        CertificateName = c.String(nullable: false, maxLength: 32),
                        IssuingOrganization = c.String(nullable: false, maxLength: 32),
                        IssueDate = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CertificateId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomUsers",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.FileTableModels",
                c => new
                    {
                        SourceFileId = c.Int(nullable: false, identity: true),
                        TargetFileId = c.Int(nullable: false),
                        PagesInSourceFile = c.Int(nullable: false),
                        PagesInTargetFile = c.Int(nullable: false),
                        SourceFileLink = c.String(),
                        TargetFileLink = c.String(),
                    })
                .PrimaryKey(t => t.SourceFileId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        SourceLanguage = c.String(nullable: false),
                        FinalLanguage = c.String(nullable: false),
                        Status = c.Boolean(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        OrderCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentTypeId = c.Int(nullable: false, identity: true),
                        PaymentName = c.String(nullable: false, maxLength: 32),
                        PaymentStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentTypeId);
            
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        RatingId = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                        TranslatorName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.RatingId);
            
            CreateTable(
                "dbo.Translators",
                c => new
                    {
                        ID_Переводчика = c.Int(nullable: false, identity: true),
                        Рейтинг = c.Int(nullable: false),
                        Зарплата = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Дата_рождения = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID_Переводчика);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Rating = c.Int(nullable: false),
                        FullName = c.String(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Translators");
            DropTable("dbo.Ratings");
            DropTable("dbo.Payments");
            DropTable("dbo.Orders");
            DropTable("dbo.FileTableModels");
            DropTable("dbo.CustomUsers");
            DropTable("dbo.Comments");
            DropTable("dbo.Certificates");
        }
    }
}
