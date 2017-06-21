using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Encuesta_EF.Models
{
    public class BaseEntidad
    {
        [MaxLength(1)]
        public string Ind_Estado { get; set; }

        [MaxLength(15)]
        public string Cod_Registro { get; set; }

        [MaxLength(15)]
        public string Cod_Modifico { get; set; }

        public DateTime? Fec_Registro { get; set; }
        public DateTime? Fec_Modifico { get; set; }
        public DateTime? Fec_Servidor { get; set; }
    }
}