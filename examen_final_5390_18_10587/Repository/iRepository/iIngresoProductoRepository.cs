using examen_final_5390_18_10587.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examen_final_5390_18_10587.Repository.iRepository
{
    interface iIngresoProductoRepository
    {
        //Obtengo el listado completo de todos los ingresos de productos
        ICollection<IngresoProductoModels> GetIngresoProductoModels();

        //Obtengo el producto ingresado segun el codigo que envie
        IngresoProductoModels GetIngresoProducto(int nIngresoProducto);

        //se crea un registro en la base de datos con la informacion de los ingresos de los productos
        bool CrearIngresoProducto(IngresoProductoModels ingreso);

        bool ActualizarIngresoProducto(IngresoProductoModels ingreso);

        bool BorrarIngresoProducto(IngresoProductoModels ingreso);

        bool GuardarIngresoProducto();



    }
}
