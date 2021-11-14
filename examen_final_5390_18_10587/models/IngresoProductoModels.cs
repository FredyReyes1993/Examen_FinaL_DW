using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace examen_final_5390_18_10587.models
{
    public class IngresoProductoModels
    {
        //Atributos de la clase Ingreso Producto
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código de Ingreso")]
        public int IngresoProducto { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Nombre de bodega de ingreso")]
        public string NombreBodegaIngreso { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Nombre del producto a ingresar")]
        public string NombreProductoIngreso { get; set; }


        [Required]
        [Column(TypeName = "int")]
        [Display(Name = "Cantidad del producto a ingresar")]
        public int CantidadProductoIngreso { get; set; }


        [Required]
        [Column(TypeName = "int")]
        [Display(Name = "Precio del producto a ingresar")]
        public int PrecioProductoIngreso { get; set; }


        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Proveedor")]
        public string ProveedorProductoIngreso { get; set; }



        [Column(TypeName = "varchar(3)")]
        [Display(Name = "Estado del Ingreso")]
        public string EstadoProveedor { get; set; } = "ACT";





    }
}
