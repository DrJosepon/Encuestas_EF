namespace Encuesta_EF.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Encuesta_EF.Models.Encuesta_EFContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Encuesta_EF.Models.Encuesta_EFContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.En_Encuesta.AddOrUpdate(
                p => p.Cod_Encuesta,
                new En_Encuesta { Cod_Encuesta = 1, Des_Encuesta = "Nivel de satisfacción del cliente interno", Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now }
                );
            context.En_Pregunta.AddOrUpdate(
                p => p.Cod_Pregunta,
                new En_Pregunta { Cod_Pregunta = 1, Des_Pregunta = "¿Cómo califica la CALIDAD DE ATENCIÓN TELEFÓNICA, brindada por los colaboradores de esta área?", Cod_Encuesta = 1, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },
                new En_Pregunta { Cod_Pregunta = 2, Des_Pregunta = "¿Cómo califica la CALIDAD DE ATENCIÓN POR CORREO ELECTRÓNICO, brindada por los colaboradores de esta área?", Cod_Encuesta = 1, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },
                new En_Pregunta { Cod_Pregunta = 3, Des_Pregunta = "¿Cómo califica la CALIDAD DE ATENCIÓN CARA A CARA, brindada por los colaboradores de esta área?", Cod_Encuesta = 1, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now }
                );
            context.En_Alternativa.AddOrUpdate(
                p => p.Cod_Alternativa,
                new En_Alternativa { Cod_Alternativa = 1, Des_Alternativa = "Excelente", Cod_Pregunta = 1, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },
                new En_Alternativa { Cod_Alternativa = 2, Des_Alternativa = "Bueno", Cod_Pregunta = 1, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },
                new En_Alternativa { Cod_Alternativa = 3, Des_Alternativa = "Regular", Cod_Pregunta = 1, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },
                new En_Alternativa { Cod_Alternativa = 4, Des_Alternativa = "Malo", Cod_Pregunta = 1, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },
                new En_Alternativa { Cod_Alternativa = 5, Des_Alternativa = "Pésimo", Cod_Pregunta = 1, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },

                new En_Alternativa { Cod_Alternativa = 6, Des_Alternativa = "Excelente", Cod_Pregunta = 2, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },
                new En_Alternativa { Cod_Alternativa = 7, Des_Alternativa = "Bueno", Cod_Pregunta = 2, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },
                new En_Alternativa { Cod_Alternativa = 8, Des_Alternativa = "Regular", Cod_Pregunta = 2, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },
                new En_Alternativa { Cod_Alternativa = 9, Des_Alternativa = "Malo", Cod_Pregunta = 2, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },
                new En_Alternativa { Cod_Alternativa = 10, Des_Alternativa = "Pésimo", Cod_Pregunta = 2, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },

                new En_Alternativa { Cod_Alternativa = 11, Des_Alternativa = "Excelente", Cod_Pregunta = 3, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },
                new En_Alternativa { Cod_Alternativa = 12, Des_Alternativa = "Bueno", Cod_Pregunta = 3, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },
                new En_Alternativa { Cod_Alternativa = 13, Des_Alternativa = "Regular", Cod_Pregunta = 3, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },
                new En_Alternativa { Cod_Alternativa = 14, Des_Alternativa = "Malo", Cod_Pregunta = 3, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now },
                new En_Alternativa { Cod_Alternativa = 15, Des_Alternativa = "Pésimo", Cod_Pregunta = 3, Ind_Estado = "A", Cod_Registro = "AJCOLQUE_DEV", Fec_Registro = DateTime.Now }
                );
        }
    }
}