using examen_final_5390_18_10587.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_final_5390_18_10587.Repository.iRepository
{
    interface iProductoRepository
    {

        //Obtengo el listado completo de todos los productos
        ICollection<ProductoModels> GetProductoModels();

        //Obtengo el producto segun el codigo que envie
        ProductoModels GetProducto(int nCodigoProducto);

        //se crea un registro en la base de datos con la informacion del producto
        bool CrearProducto(ProductoModels producto);

        bool ActualizarProducto(ProductoModels producto);

        bool BorrarProducto(ProductoModels producto);

        bool GuardarProducto();



    }
}
