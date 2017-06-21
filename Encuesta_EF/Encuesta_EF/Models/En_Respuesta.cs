using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Encuesta_EF.Models
{
    public class En_Respuesta
    {
        [Key]
        public int Cod_Respuesta { get; set; }

        [MaxLength(200)]
        public string Des_Respuesta { get; set; }

        public string Cod_Usuario { get; set; }
        public int Cod_Alternativa { get; set; }
        public string Cod_Area { get; set; }

        public En_Alternativa En_Alternativa { get; set; }
    }
}