using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroEstudiante.data.Servicios
{
    public class EstudianteServiceTest : IEstudiantesService
    {
        public IEnumerable<Estudiante> Listar()
        {
            var listaEstudiantes = new List<Estudiante>();
            listaEstudiantes.Add(new Estudiante { ID = 0, Nombres = "jose", Apellidos = "Perez", FechaNacimiento = new DateTime(1990, 1, 1) });
            listaEstudiantes.Add(new Estudiante { ID = 1, Nombres = "pedro", Apellidos = "Sanchez", FechaNacimiento = new DateTime(1993, 3, 4) });
            listaEstudiantes.Add(new Estudiante { ID = 0, Nombres = "Juan", Apellidos = "Gabriel", FechaNacimiento = new DateTime(1995, 4, 12) });

            return listaEstudiantes;
            throw new NotImplementedException();
        }
    }
}
