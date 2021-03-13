namespace OdvozOtpada.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodanGrad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "gradovi",
                c => new
                {
                    idGrad = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    imeGrad = c.String(nullable: false, maxLength: 256, storeType: "nvarchar"),
                })
                .PrimaryKey(t => t.idGrad)
                .Index(t => t.imeGrad, unique: true, name: "ImeGradaIndex");
        }
        
        public override void Down()
        {
            DropTable("gradovi");
            DropIndex("gradovi", "ImeGradaIndex");
        }
    }
}
