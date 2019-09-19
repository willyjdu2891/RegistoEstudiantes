using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RegistroEstudiante.data
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Objetivo { get; set; }
        public string NombreFacilitador { get; set; }

        //[DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime FechaApertura { get; set; }
        
    }
}
