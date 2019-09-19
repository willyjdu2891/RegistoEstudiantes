using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroEstudiante.data.Servicios
{
    public class CursoServiceTest : ICursosService
    {
        public IEnumerable<Curso> ListarCurso()
        {
            var listaCursos = new List<Curso>();
            listaCursos.Add(new Curso { Id = 1, Nombre = "Programación C#", NombreFacilitador = "Josh Smith", FechaApertura = new DateTime(2019, 10, 10), Objetivo = "Dotar de conocimiento básico del lenguaje de programación C#" });
            listaCursos.Add(new Curso { Id = 2, Nombre = "Programación C++", NombreFacilitador = "Juan Carrillo", FechaApertura = new DateTime(2019,11, 10), Objetivo = "Dotar de conocimiento básico del lenguaje de programación C++" });
            listaCursos.Add(new Curso { Id = 3, Nombre = "Programación Angular", NombreFacilitador = "Jose Morillo", FechaApertura = new DateTime(2019, 12, 10), Objetivo = "Dotar de conocimiento básico del lenguaje de programación Angular" });
            listaCursos.Add(new Curso { Id = 4, Nombre = "Programación Java", NombreFacilitador = "Pedro Caminero", FechaApertura = new DateTime(2019, 10, 10), Objetivo = "Dotar de conocimiento básico del lenguaje de programación Java" });
            listaCursos.Add(new Curso { Id = 5, Nombre = "Programación Python", NombreFacilitador = "Kawhi Leonard", FechaApertura = new DateTime(2019,11, 10 ), Objetivo = "Dotar de conocimiento básico del lenguaje de programación Python" });
            listaCursos.Add(new Curso { Id = 6, Nombre = "Programación Pearl", NombreFacilitador = "Tim Duncam", FechaApertura = new DateTime(2019, 11, 10), Objetivo = "Dotar de conocimiento básico del lenguaje de programación Pearl" });
            listaCursos.Add(new Curso { Id = 7, Nombre = "Programación Visual Basic", NombreFacilitador = "Tony Parker", FechaApertura = new DateTime(2019,12, 10), Objetivo = "Dotar de conocimiento básico del lenguaje de programación Visual Basic" });
            listaCursos.Add(new Curso { Id = 8, Nombre = "Programación Node JS", NombreFacilitador = "Manu Ginobilli", FechaApertura = new DateTime(2019, 12, 10), Objetivo = "Dotar de conocimiento básico del lenguaje de programación Node JS" });
            listaCursos.Add(new Curso { Id = 9, Nombre = "Programación PHP", NombreFacilitador = "Derrick White", FechaApertura = new DateTime(2019, 11, 10), Objetivo = "Dotar de conocimiento básico del lenguaje de programación PHP" });
            listaCursos.Add(new Curso { Id = 10, Nombre = "Programación F#", NombreFacilitador = "Demar Derozan", FechaApertura = new DateTime(2019, 10, 10), Objetivo = "Dotar de conocimiento básico del lenguaje de programación F#" });

            return listaCursos;
            throw new NotImplementedException();
        }
    }
}

//<assemblies>
//        <add assembly = "netstandard, Version=2.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51" />
//      </ assemblies >
