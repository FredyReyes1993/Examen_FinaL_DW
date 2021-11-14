using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace examen_final_5390_18_10587.models
{
    public class ProductoModels
    {
        //Atributos de la clase producto
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código del producto")]
        public int CodigoProducto { get; set; }

        [Required]
        [Column(TypeName ="varchar(50)")]
        [Display(Name ="Nombre del producto")]
        public string NombreProducto { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Nombre del proveedor")]
        public string ProveedorProducto { get; set; }

        [Required]
        [Column(TypeName = "int")]
        [Display(Name = "Cantidad del producto")]
        public int CantidadProducto { get; set; }

        [Required]
        [Column(TypeName = "int")]
        [Display(Name = "Precio del producto")]
        public int PrecioProducto { get; set; }

        [Column(TypeName = "varchar(3)")]
        [Display(Name = "Estado del producto")]
        public string EstadoProducto { get; set; } = "ACT";



    }
}
