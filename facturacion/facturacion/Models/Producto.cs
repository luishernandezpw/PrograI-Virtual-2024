using System.ComponentModel.DataAnnotations;

namespace facturacion.Models {
    public class Producto {
        [Key]
        public int idProducto { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        public string presentacion { get; set; }
        public decimal precio { get; set; }
    }
}
