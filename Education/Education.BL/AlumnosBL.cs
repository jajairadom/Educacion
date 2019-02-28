using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.BL
{
    public class AlumnosBL
    {
        public List<Alumno> ObtenerAlumnos()
        {
            var alumno1 = new Alumno();
            alumno1.Id = 1;
            alumno1.Descripcion = "Sirley";
            alumno1.RNE = 123456;

            var alumno2 = new Alumno();
            alumno2.Id = 2;
            alumno2.Descripcion = "Roger";
            alumno2.RNE = 234567;

            var alumno3 = new Alumno();
            alumno3.Id = 3;
            alumno3.Descripcion = "Jajaira";
            alumno3.RNE = 345678;

            var alumno4 = new Alumno();
            alumno4.Id = 4;
            alumno4.Descripcion = "Edgar";
            alumno4.RNE = 456789;

            var listadeAlumnos = new List<Alumno>();
            listadeAlumnos.Add(alumno1);
            listadeAlumnos.Add(alumno2);
            listadeAlumnos.Add(alumno3);
            listadeAlumnos.Add(alumno4);

            return listadeAlumnos;
        }
    }
}
