using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preexamen.Controller
{
    interface IAlumno
    {
        List<Alumno> ObtenerAlumnos();
        bool Eliminar(int alumnoID);
        bool Insertar(int alumnoId, string nombre, string apellido, string fechaNacimiento, string correo);
        bool Actualizar(string nombre, string apellido, string fechaNacimiento, string correo, int AlumnoID);

    }
}
