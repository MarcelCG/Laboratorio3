using Laboratorio3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Laboratorio3.Controllers
{
    public class CancionController : Controller
    {
        public IActionResult Index()
        {
            var cancion = GetCancion();
            ViewBag.MainTitle = "Mi canción favorita";
            return View(cancion);
        }
      private CancionModel GetCancion()
        {
            var cancion = new CancionModel();
            cancion.Nombre = "Speedometer";
            cancion.Autor = "Post Malone";
            cancion.Album = "Austin";
            cancion.Fecha = new DateTime(2023, 07, 28);
            cancion.Genero = "Synth-pop";

            return cancion;
        }
    }
}