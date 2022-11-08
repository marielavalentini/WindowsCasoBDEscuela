namespace WindowsCasoBDEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NombresTablas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Carreras", newName: "Carrera");
            RenameTable(name: "dbo.Plans", newName: "Plan");
            RenameTable(name: "dbo.Planillas", newName: "PLanilla");
            RenameTable(name: "dbo.Cursoes", newName: "Curso");
            RenameTable(name: "dbo.Detalles", newName: "Detalle");
            RenameTable(name: "dbo.Estadoes", newName: "Estado");
            RenameTable(name: "dbo.Evaluacions", newName: "Evaluacion");
            RenameTable(name: "dbo.Estudiantes", newName: "Estudiante");
            RenameTable(name: "dbo.Localidads", newName: "Localidad");
            RenameTable(name: "dbo.Tipoes", newName: "Tipo");
            RenameTable(name: "dbo.Materias", newName: "Materia");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Materia", newName: "Materias");
            RenameTable(name: "dbo.Tipo", newName: "Tipoes");
            RenameTable(name: "dbo.Localidad", newName: "Localidads");
            RenameTable(name: "dbo.Estudiante", newName: "Estudiantes");
            RenameTable(name: "dbo.Evaluacion", newName: "Evaluacions");
            RenameTable(name: "dbo.Estado", newName: "Estadoes");
            RenameTable(name: "dbo.Detalle", newName: "Detalles");
            RenameTable(name: "dbo.Curso", newName: "Cursoes");
            RenameTable(name: "dbo.PLanilla", newName: "Planillas");
            RenameTable(name: "dbo.Plan", newName: "Plans");
            RenameTable(name: "dbo.Carrera", newName: "Carreras");
        }
    }
}
