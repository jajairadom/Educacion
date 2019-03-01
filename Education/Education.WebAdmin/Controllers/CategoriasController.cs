﻿using Education.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Education.WebAdmin.Controllers
{
    public class CategoriasController : Controller
    {
        CategoriasBL _categoriasBL;

        public CategoriasController()
        {
            _categoriasBL = new CategoriasBL();
        }

        // GET: Categorias
        public ActionResult Index()
        {
            var listadeCategorias = _categoriasBL.ObtenerCategorias();

            return View(listadeCategorias);
        }
        public ActionResult Crear()
        {
            var nuevaCategoria = new Categoria();
            return View(nuevaCategoria);
        }

        [HttpPost]
        public ActionResult Crear(Categoria alumno)
        {
            _categoriasBL.GuardarCategoria(alumno);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            var alumno = _categoriasBL.ObtenerCategoria(id);

            return View(alumno);
        }

        [HttpPost]
        public ActionResult Editar(Categoria alumno)
        {
            _categoriasBL.GuardarCategoria(alumno);

            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int id)
        {
            var alumno = _categoriasBL.ObtenerCategoria(id);
            return View(alumno);
        }

        public ActionResult Eliminar(int id)
        {
            var alumno = _categoriasBL.ObtenerCategoria(id);
            return View(alumno);
        }

        [HttpPost]
        public ActionResult Eliminar(Categoria alumno)
        {
            _categoriasBL.EliminarCategoria(alumno.Id);
            return RedirectToAction("Index");
        }
    }
}
