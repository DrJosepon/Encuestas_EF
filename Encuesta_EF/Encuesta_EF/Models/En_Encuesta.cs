using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Encuesta_EF.Models
{
    public class En_Encuesta : BaseEntidad
    {
        [Key]
        public int Cod_Encuesta { get; set; }

        [MaxLength(200)]
        public string Des_Encuesta { get; set; }
    }
}