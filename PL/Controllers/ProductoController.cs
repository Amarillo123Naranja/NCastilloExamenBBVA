using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Producto()
        {
            ML.Producto producto = new ML.Producto();
            ML.Result result = BL.Producto.GetAll();
            producto.Productos = result.Objects;
            return View(producto);
        }

        [HttpGet]

        public ActionResult Compra(int IdProducto)
        {
            ML.Producto producto = new ML.Producto();
            ML.Result result = BL.Producto.GetById(IdProducto);

            if (result.Correct)
            {
                producto = (ML.Producto)result.Object;
                return View(producto);
            }
            else
            {
                result.ErrorMessage = "Ocurrio un error";
                return View();
            }


        }

        [HttpPost]
        public ActionResult Compra(int moneda10, int moneda50, int moneda100)
        {
            ML.Producto aux = new ML.Producto();
            ML.Result result = BL.Producto.Comprar(moneda10, moneda50, moneda100);

            if (result.Correct)
            {
                aux = (ML.Producto)result.Object;
                ViewBag.Mensaje = "Tu cambio es: " + aux.Cambio + "$" + aux.Millares + "$" + aux.Centenas + "$" + aux.Decenas + "$" + "$" + aux.Unidades;
                return PartialView("Modal");
            }
            else
            {
                result.ErrorMessage = "Ocurrio un error!";
            }
            return View(aux);

        }


    }
}