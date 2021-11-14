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
    public class ProveedorController : Controller
    {
        private readonly ILogger<ProveedorController> _logger;
        private readonly Conn _context;

        public ProveedorController(Conn context)
        {
            _context = context;

        }
        public IActionResult Producto()
        {
            return View();
        }

        //Lista toda la informacion de la tabla proveedor
        public async Task<IActionResult> Index()
        {
            return View(await _context.tbl_proveedor.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Producto([Bind("CodigoProveedor,NombreProveedor,DireccionProducto,Telefonoproveedor,ProveedorProducto,EstadoProveedor")] ProveedorModels proveedormodels)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proveedormodels);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(proveedormodels);
        }

    }
}
