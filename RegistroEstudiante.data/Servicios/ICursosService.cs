using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroEstudiante.data.Servicios
{
     public interface ICursosService
    {
        IEnumerable<Curso> ListarCurso();
    }
}
