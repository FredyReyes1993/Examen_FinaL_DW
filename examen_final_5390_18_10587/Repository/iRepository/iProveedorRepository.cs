using examen_final_5390_18_10587.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_final_5390_18_10587.Repository.iRepository
{
    interface iProveedorRepository
    {
        //Obtengo el listado completo de todos los proveedores
        ICollection<ProveedorModels> GetProveedorModels();

        //Obtengo el proveedor segun el codigo que envie
        ProveedorModels GetProveedor(int nCodigoProveedor);

        //se crea un registro en la base de datos con la informacion del proveedor
        bool CrearProveedor(ProveedorModels proveedor);

        bool ActualizarProveedor(ProveedorModels proveedor);

        bool BorrarProveedor(ProveedorModels proveedor);

        bool GuardarProveedor();


    }
}
