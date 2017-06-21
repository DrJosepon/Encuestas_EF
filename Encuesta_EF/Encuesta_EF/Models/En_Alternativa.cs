using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Encuesta_EF.Models
{
    public class En_Alternativa : BaseEntidad
    {
        [Key]
        public int Cod_Alternativa { get; set; }

        [MaxLength(200)]
        public string Des_Alternativa { get; set; }

        [ForeignKey("En_Pregunta")]
        public int Cod_Pregunta { get; set; }

        public En_Pregunta En_Pregunta { get; set; }
    }
}