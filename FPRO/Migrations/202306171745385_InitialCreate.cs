namespace FPRO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdiSoyad = c.String(),
                        Eposta = c.String(),
                        Kulanciadi = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Aciklama = c.String(),
                        Resim = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Email = c.String(),
                        Phone = c.Int(nullable: false),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Otellers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Aciklama = c.String(),
                        Fiyat = c.String(),
                        Bilgi = c.String(),
                        Resim = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Restoranlars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Aciklama = c.String(),
                        Resim = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Uyelers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AdiSoyad = c.String(),
                        Eposta = c.String(),
                        Telefon = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Uyelers");
            DropTable("dbo.Restoranlars");
            DropTable("dbo.Otellers");
            DropTable("dbo.Contacts");
            DropTable("dbo.Blogs");
            DropTable("dbo.Admins");
        }
    }
}
