using examen_final_5390_18_10587.conecction;
using examen_final_5390_18_10587.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_final_5390_18_10587.controller
{
    public class ProductoController : Controller
    {
        private readonly ILogger<ProductoController> _logger;
        private readonly Conn _context;

        public ProductoController(Conn context)
        {
            _context = context;

        }

        public IActionResult Producto()
        {
            return View();
        }

        //Lista toda la informacion de la tabla producto
        public async Task<IActionResult> Index()
        {
            return View(await _context.tbl_producto.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Producto([Bind("CodigoProducto,NombreProducto,ProveedorProducto,CantidadProducto,PrecioProducto,EstadoProducto")] ProductoModels productomodels)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productomodels);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productomodels);
        }

    }
}
