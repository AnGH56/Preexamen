using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preexamen.Controller
{
    class Alumno
    {
        public Alumno(int alumnoID, string nombre, string apellido, string fechaNacimiento, string correo)
        {
            AlumnoID = alumnoID;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Correo = correo;
        }

        public Alumno() { }
        public int AlumnoID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string Correo { get; set; }
    }
}
