﻿using Laboratorio4.Handlers;
using Laboratorio4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Laboratorio4.Controllers
{
    public class PlanetasController : Controller
    {
        public ActionResult listadoDePlanetas()
        { 
            PlanetasHandler accesoDatos = new PlanetasHandler();
            ViewBag.planetas = accesoDatos.obtenerTodoslosPlanetas();
            return View();
        }


    }
}