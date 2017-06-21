namespace Encuesta_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.En_Alternativa",
                c => new
                    {
                        Cod_Alternativa = c.Int(nullable: false, identity: true),
                        Des_Alternativa = c.String(maxLength: 200),
                        Cod_Pregunta = c.Int(nullable: false),
                        Ind_Estado = c.String(maxLength: 1),
                        Cod_Registro = c.String(maxLength: 15),
                        Cod_Modifico = c.String(maxLength: 15),
                        Fec_Registro = c.DateTime(),
                        Fec_Modifico = c.DateTime(),
                        Fec_Servidor = c.DateTime(),
                    })
                .PrimaryKey(t => t.Cod_Alternativa)
                .ForeignKey("dbo.En_Pregunta", t => t.Cod_Pregunta, cascadeDelete: true)
                .Index(t => t.Cod_Pregunta);
            
            CreateTable(
                "dbo.En_Pregunta",
                c => new
                    {
                        Cod_Pregunta = c.Int(nullable: false, identity: true),
                        Des_Pregunta = c.String(maxLength: 200),
                        Cod_Encuesta = c.Int(nullable: false),
                        Ind_Estado = c.String(maxLength: 1),
                        Cod_Registro = c.String(maxLength: 15),
                        Cod_Modifico = c.String(maxLength: 15),
                        Fec_Registro = c.DateTime(),
                        Fec_Modifico = c.DateTime(),
                        Fec_Servidor = c.DateTime(),
                    })
                .PrimaryKey(t => t.Cod_Pregunta)
                .ForeignKey("dbo.En_Encuesta", t => t.Cod_Encuesta, cascadeDelete: true)
                .Index(t => t.Cod_Encuesta);
            
            CreateTable(
                "dbo.En_Encuesta",
                c => new
                    {
                        Cod_Encuesta = c.Int(nullable: false, identity: true),
                        Des_Encuesta = c.String(),
                        Ind_Estado = c.String(maxLength: 1),
                        Cod_Registro = c.String(maxLength: 15),
                        Cod_Modifico = c.String(maxLength: 15),
                        Fec_Registro = c.DateTime(),
                        Fec_Modifico = c.DateTime(),
                        Fec_Servidor = c.DateTime(),
                    })
                .PrimaryKey(t => t.Cod_Encuesta);
            
            CreateTable(
                "dbo.En_Respuesta",
                c => new
                    {
                        Cod_Respuesta = c.Int(nullable: false, identity: true),
                        Des_Respuesta = c.String(maxLength: 200),
                        Cod_Usuario = c.String(),
                        Cod_Alternativa = c.Int(nullable: false),
                        Cod_Area = c.String(),
                    })
                .PrimaryKey(t => t.Cod_Respuesta)
                .ForeignKey("dbo.En_Alternativa", t => t.Cod_Alternativa, cascadeDelete: true)
                .Index(t => t.Cod_Alternativa);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.En_Respuesta", "Cod_Alternativa", "dbo.En_Alternativa");
            DropForeignKey("dbo.En_Alternativa", "Cod_Pregunta", "dbo.En_Pregunta");
            DropForeignKey("dbo.En_Pregunta", "Cod_Encuesta", "dbo.En_Encuesta");
            DropIndex("dbo.En_Respuesta", new[] { "Cod_Alternativa" });
            DropIndex("dbo.En_Pregunta", new[] { "Cod_Encuesta" });
            DropIndex("dbo.En_Alternativa", new[] { "Cod_Pregunta" });
            DropTable("dbo.En_Respuesta");
            DropTable("dbo.En_Encuesta");
            DropTable("dbo.En_Pregunta");
            DropTable("dbo.En_Alternativa");
        }
    }
}
