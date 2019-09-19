using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroEstudiante.data
{
    public class Estudiante
    {
        public int ID { get; set; }
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int edad { get {
                return Convert.ToInt32((DateTime.Now - FechaNacimiento).TotalDays / 360);
            } }
    }
}
