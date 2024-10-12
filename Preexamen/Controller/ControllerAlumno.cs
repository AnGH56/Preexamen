using Preexamen.Models.DsUniversidadTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace Preexamen.Controller
{
    class ControllerAlumno : IAlumno
    {

        List<Alumno> listaalumnos = new List<Alumno>();
        Alumno ali = new Alumno();
        public List<Alumno> ObtenerAlumnos()
        {
            try
            {
                using (alumnosTableAdapter alumnos = new alumnosTableAdapter())
                {
                    var datos = alumnos.GetData();

                    foreach (DataRow row in datos)
                    {
                        ali.AlumnoID = Convert.ToInt32(row["AlumnoID"]);
                        ali.Nombre= Convert.ToString(row["Nombre"]);
                        ali.Apellido = Convert.ToString(row["Apellido"]);
                        ali.Correo= Convert.ToString(row["Correo"]);
                        ali.FechaNacimiento = Convert.ToString(row["FechaNacimiento"]);

                        listaalumnos.Add(new Alumno(ali.AlumnoID, ali.Nombre, ali.Apellido, ali.FechaNacimiento, ali.Correo));
                    }
                }
                return listaalumnos;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }

        }
        public bool Actualizar(string nombre, string apellido, string fechaNacimiento, string correo, int alumnoid)
        {
            try
            {
                using (alumnosTableAdapter alumnos = new alumnosTableAdapter())
                {
                    var actualizar = listaalumnos.FirstOrDefault(x => x.AlumnoID == alumnoid);
                    if (actualizar != null)
                    {
                        actualizar.Nombre = nombre;
                        actualizar.Apellido = apellido;
                        actualizar.FechaNacimiento = fechaNacimiento;
                        actualizar.Correo = correo;

                        alumnos.UpdateAlumno(nombre, apellido, fechaNacimiento, correo, alumnoid);

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            throw new NotImplementedException();    
        }

        public bool Eliminar(int alumnoID)
        {
            try
            {
                using (alumnosTableAdapter alumnos = new alumnosTableAdapter())
                {
                    var verificar = alumnos.GetDataByID(alumnoID);

                    if (verificar.Rows.Count>0)
                    {
                        alumnos.DeleteAlumno(alumnoID);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public bool Insertar(int alumnoId,string nombre, string apellido, string fechaNacimiento, string correo)
        {
            try
            {
                using (alumnosTableAdapter alumnos = new alumnosTableAdapter())
                {
                    ali.AlumnoID = alumnoId;
                    ali.Nombre = nombre;
                    ali.Apellido = apellido;
                    ali.FechaNacimiento = fechaNacimiento;
                    ali.Correo = correo;

                   var datos = alumnos.InsertAlumnos( ali.AlumnoID, ali.Nombre, ali.Apellido, ali.FechaNacimiento, ali.Correo);
                    return true;
                }
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
           
        }

       
    }
}
