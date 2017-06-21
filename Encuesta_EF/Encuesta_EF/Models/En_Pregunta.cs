using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Encuesta_EF.Models
{
    public class En_Pregunta : BaseEntidad
    {
        [Key]
        public int Cod_Pregunta { get; set; }

        [MaxLength(200)]
        public string Des_Pregunta { get; set; }

        [ForeignKey("En_Encuesta")]
        public int Cod_Encuesta { get; set; }

        public En_Encuesta En_Encuesta { get; set; }
    }
}