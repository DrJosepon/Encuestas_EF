using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Encuesta_EF.Models
{
    public class Encuesta_EFContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        //
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public Encuesta_EFContext() : base("name=Encuesta_EFContext")
        {
        }

        public System.Data.Entity.DbSet<Encuesta_EF.Models.En_Encuesta> En_Encuesta { get; set; }
        public System.Data.Entity.DbSet<Encuesta_EF.Models.En_Alternativa> En_Alternativa { get; set; }
        public System.Data.Entity.DbSet<Encuesta_EF.Models.En_Pregunta> En_Pregunta { get; set; }
        public System.Data.Entity.DbSet<Encuesta_EF.Models.En_Respuesta> En_Respuesta { get; set; }
    }
}