using examen_final_5390_18_10587.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_final_5390_18_10587.conecction
{
    public class Conn : DbContext
    {

        public Conn(DbContextOptions<Conn> options) : base(options) { }

        public DbSet<ProductoModels> tbl_producto { get; set; }

        public DbSet<ProveedorModels> tbl_proveedor { get; set; }

        public DbSet<IngresoProductoModels> tbl_Ingreso_producto { get; set; }


    }
}
