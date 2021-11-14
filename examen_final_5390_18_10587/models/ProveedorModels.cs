using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace examen_final_5390_18_10587.models
{
    public class ProveedorModels
    {
        //Atributos de la clase proveedor
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código del proveedor")]
        public int CodigoProveedor { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Nombre del proveedor")]
        public string NombreProveedor { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Dirección del proveedor")]
        public string DireccionProducto { get; set; }

        [Required]
        [Column(TypeName = "int")]
        [Display(Name = "Teléfono del proveedor")]
        public int Telefonoproveedor{ get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Producto que proporciona")]
        public string ProveedorProducto { get; set; }

        [Column(TypeName = "varchar(3)")]
        [Display(Name = "Estado del proveedor")]
        public string EstadoProveedor { get; set; } = "ACT";


    }
}
