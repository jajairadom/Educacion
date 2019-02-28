using Education.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education.Web.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            var alumno1 = new AlumnoModel();
            alumno1.Id = 1;
            alumno1.Descripcion = "Sirley";

            var alumno2 = new AlumnoModel();
            alumno2.Id = 2;
            alumno2.Descripcion = "Roger";

            var alumno3 = new AlumnoModel();
            alumno3.Id = 3;
            alumno3.Descripcion = "Jajaira";

            var alumno4 = new AlumnoModel();
            alumno4.Id = 4;
            alumno4.Descripcion = "Edgar";

            var listadeAlumnos = new List<AlumnoModel>();
            listadeAlumnos.Add(alumno1);
            listadeAlumnos.Add(alumno2);
            listadeAlumnos.Add(alumno3);
            listadeAlumnos.Add(alumno4);

            return View(listadeAlumnos);
        }
    }
}