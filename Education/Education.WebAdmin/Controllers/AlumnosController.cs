using Education.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education.WebAdmin.Controllers
{
    public class AlumnosController : Controller
    {
        AlumnosBL _alumnosBL;
      

        public AlumnosController()
        {
            _alumnosBL = new AlumnosBL();
           
        }


        // GET: Alumnos
        public ActionResult Index()
        {
            var listadeAlumnos = _alumnosBL.ObtenerAlumnos();
            return View(listadeAlumnos);
        }
        public ActionResult Crear()
        {
           var nuevoAlumno = new Alumno();
            
            return View(nuevoAlumno);
        }


        [HttpPost]
        public ActionResult Crear(Alumno alumno)
        {
            _alumnosBL.GuardarAlumno(alumno);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
           var alumno = _alumnosBL.ObtenerAlumno(id);
           
            return View(alumno);
        }

        [HttpPost]
        public ActionResult Editar(Alumno alumno)
        {
            _alumnosBL.GuardarAlumno(alumno);

            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int id)
        {
            var alumno = _alumnosBL.ObtenerAlumno(id);
            return View(alumno);
        }

        public ActionResult Eliminar(int id)
        {
            var alumno = _alumnosBL.ObtenerAlumno(id);
            

            return View(alumno);
        }

        [HttpPost]
        public ActionResult Eliminar(Alumno alumno)
        {
            _alumnosBL.EliminarAlumno(alumno.Id);
            return RedirectToAction("Index");
        }

       
    }
}