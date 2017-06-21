namespace Encuesta_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.En_Encuesta", "Des_Encuesta", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.En_Encuesta", "Des_Encuesta", c => c.String());
        }
    }
}
