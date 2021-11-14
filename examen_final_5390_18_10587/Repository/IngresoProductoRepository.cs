using examen_final_5390_18_10587.conecction;
using examen_final_5390_18_10587.models;
using examen_final_5390_18_10587.Repository.iRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_final_5390_18_10587.Repository
{
    public class IngresoProductoRepository : iIngresoProductoRepository
    {
        private readonly Conn _db;

        public IngresoProductoRepository(Conn db)
        {
            _db = db;
        }

        public bool ActualizarIngresoProducto(IngresoProductoModels ingreso)
        {
            _db.tbl_Ingreso_producto.Update(ingreso);
            return GuardarIngresoProducto();
        }

        public bool BorrarIngresoProducto(IngresoProductoModels ingreso)
        {
            _db.tbl_Ingreso_producto.Remove(ingreso);
            return GuardarIngresoProducto();
        }

        public bool CrearIngresoProducto(IngresoProductoModels ingreso)
        {
            _db.tbl_Ingreso_producto.Add(ingreso);
            return GuardarIngresoProducto();
        }

        public IngresoProductoModels GetIngresoProducto(int nIngresoProducto)
        {
            return _db.tbl_Ingreso_producto.FirstOrDefault(p => p.IngresoProducto == nIngresoProducto);
        }

        public ICollection<IngresoProductoModels> GetIngresoProductoModels()
        {
            return _db.tbl_Ingreso_producto.OrderBy(p => p.NombreProductoIngreso).ToList();
        }

        public bool GuardarIngresoProducto()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
