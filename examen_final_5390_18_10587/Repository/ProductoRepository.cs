using examen_final_5390_18_10587.conecction;
using examen_final_5390_18_10587.models;
using examen_final_5390_18_10587.Repository.iRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_final_5390_18_10587.Repository
{
    public class ProductoRepository : iProductoRepository
    {

        private readonly Conn _db;

        public ProductoRepository(Conn db)
        {
            _db = db;

        }

        public bool ActualizarProducto(ProductoModels producto)
        {
            _db.tbl_producto.Update(producto);
            return GuardarProducto();
        }

        public bool BorrarProducto(ProductoModels producto)
        {
            _db.tbl_producto.Remove(producto);
            return GuardarProducto();
        }

        public bool CrearProducto(ProductoModels producto)
        {
            _db.tbl_producto.Add(producto);
            return GuardarProducto();

        }

        public ProductoModels GetProducto(int nCodigoProducto)
        {
            return _db.tbl_producto.FirstOrDefault(p => p.CodigoProducto == nCodigoProducto);
        }

        public ICollection<ProductoModels> GetProductoModels()
        {
            return _db.tbl_producto.OrderBy(p => p.NombreProducto).ToList();
        }

        public bool GuardarProducto()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
