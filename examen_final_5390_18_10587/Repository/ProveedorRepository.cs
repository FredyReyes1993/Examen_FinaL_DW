using examen_final_5390_18_10587.conecction;
using examen_final_5390_18_10587.models;
using examen_final_5390_18_10587.Repository.iRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_final_5390_18_10587.Repository
{
    public class ProveedorRepository : iProveedorRepository
    {
        private readonly Conn _db;

        public ProveedorRepository(Conn db)
        {
             _db = db;
        }

        public bool ActualizarProveedor(ProveedorModels proveedor)
        {
            _db.tbl_proveedor.Update(proveedor);
            return GuardarProveedor();
        }

        public bool BorrarProveedor(ProveedorModels proveedor)
        {
            _db.tbl_proveedor.Remove(proveedor);
            return GuardarProveedor();
        }

        public bool CrearProveedor(ProveedorModels proveedor)
        {
            _db.tbl_proveedor.Add(proveedor);
            return GuardarProveedor();
        }

        public ProveedorModels GetProveedor(int nCodigoProveedor)
        {
            return _db.tbl_proveedor.FirstOrDefault(p => p.CodigoProveedor == nCodigoProveedor);
        }

        public ICollection<ProveedorModels> GetProveedorModels()
        {
            return _db.tbl_proveedor.OrderBy(p => p.NombreProveedor).ToList();
        }

        public bool GuardarProveedor()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
