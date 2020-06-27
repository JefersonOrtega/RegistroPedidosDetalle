using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroPedidosDetalle.Models
{
  
        public class OrdenesDetalle
        {
            [Key]
            public int Id { get; set; }
            public int OrdenId { get; set; }
            public int ProductoId { get; set; }
            [ForeignKey("ProductoId")]
            public virtual Productos Producto { get; set; }

            public int Cantidad { get; set; }
            public decimal Costo { get; set; }

        }
    
}
