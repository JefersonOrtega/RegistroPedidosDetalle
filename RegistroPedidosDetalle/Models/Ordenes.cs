using RegistroPedidosDetalle.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace RegistroPedidosDetalle.Models
{
    public class Ordenes
    {
        [Key]
        public int OrdenId { get; set; }
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage="Es necesario seleccionar el suplidor")]
        public int SuplidorId { get; set; }

        [ForeignKey("SuplidorId")]
        public virtual Suplidores Suplidor { get; set; }

        [Required(ErrorMessage="Es necesario introducir el Monto")]
        public decimal Monto { get; set; }

        [ForeignKey("OrdenId")]
        public virtual List<OrdenesDetalles> OrdenesDetalle { get; set; }

        public class OrdenesDetalles
        {
            [Key]
            public int Id { get; set; }
            public int OrdenId { get; set; }
            public int Cantidad { get; set; }
            public decimal Costo { get; set; }

        }
    }
}
