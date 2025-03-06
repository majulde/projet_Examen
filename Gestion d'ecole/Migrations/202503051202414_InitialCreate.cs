namespace Gestion_d_ecole.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CoursMatieres", "Cours_Id", "dbo.Cours");
            DropForeignKey("dbo.CoursMatieres", "Matiere_Id", "dbo.Matieres");
            DropIndex("dbo.CoursMatieres", new[] { "Cours_Id" });
            DropIndex("dbo.CoursMatieres", new[] { "Matiere_Id" });
            DropColumn("dbo.CoursMatieres", "IdCours");
            DropColumn("dbo.CoursMatieres", "IdMatiere");
            RenameColumn(table: "dbo.CoursMatieres", name: "Cours_Id", newName: "IdCours");
            RenameColumn(table: "dbo.CoursMatieres", name: "Matiere_Id", newName: "IdMatiere");
            DropPrimaryKey("dbo.CoursMatieres");
            AlterColumn("dbo.CoursMatieres", "IdCours", c => c.Int(nullable: false));
            AlterColumn("dbo.CoursMatieres", "IdMatiere", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.CoursMatieres", new[] { "IdCours", "IdMatiere" });
            CreateIndex("dbo.CoursMatieres", "IdCours");
            CreateIndex("dbo.CoursMatieres", "IdMatiere");
            AddForeignKey("dbo.CoursMatieres", "IdCours", "dbo.Cours", "Id", cascadeDelete: true);
            AddForeignKey("dbo.CoursMatieres", "IdMatiere", "dbo.Matieres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CoursMatieres", "IdMatiere", "dbo.Matieres");
            DropForeignKey("dbo.CoursMatieres", "IdCours", "dbo.Cours");
            DropIndex("dbo.CoursMatieres", new[] { "IdMatiere" });
            DropIndex("dbo.CoursMatieres", new[] { "IdCours" });
            DropPrimaryKey("dbo.CoursMatieres");
            AlterColumn("dbo.CoursMatieres", "IdMatiere", c => c.Int());
            AlterColumn("dbo.CoursMatieres", "IdCours", c => c.Int());
            AddPrimaryKey("dbo.CoursMatieres", new[] { "IdCours", "IdMatiere" });
            RenameColumn(table: "dbo.CoursMatieres", name: "IdMatiere", newName: "Matiere_Id");
            RenameColumn(table: "dbo.CoursMatieres", name: "IdCours", newName: "Cours_Id");
            AddColumn("dbo.CoursMatieres", "IdMatiere", c => c.Int(nullable: false));
            AddColumn("dbo.CoursMatieres", "IdCours", c => c.Int(nullable: false));
            CreateIndex("dbo.CoursMatieres", "Matiere_Id");
            CreateIndex("dbo.CoursMatieres", "Cours_Id");
            AddForeignKey("dbo.CoursMatieres", "Matiere_Id", "dbo.Matieres", "Id");
            AddForeignKey("dbo.CoursMatieres", "Cours_Id", "dbo.Cours", "Id");
        }
    }
}
