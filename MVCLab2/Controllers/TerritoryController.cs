﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLab2.Servicio;

namespace MVCLab2.Controllers
{
    public class TerritoryController : Controller
    {

        private ServicioClient servicio = new ServicioClient();

        public ActionResult Index()
        {
            ViewBag.listCustomerTerritory = servicio.ObtenerClientes();

            return View();
        }

        public ActionResult Search(FormCollection fc)
        {
            //string condition = fc["condition"];
            string keyword = fc["keyword"];
            //if (condition.Equals("byID"))
                ViewBag.listCustomerTerritory = servicio.ObtenerClientesNombreCliente(keyword);
            //else
                //ViewBag.listCustomerTerritory = servicio.ObtenerClientesNombrePais(keyword);

            return View("Index");
        }
    }
}