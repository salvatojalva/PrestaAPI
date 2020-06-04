using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebApi.Models
{
    public class ProductoInventario
    {
        public ProductoInventario()
        {
            Reserva = new HashSet<Reserva>();
        }

        public int IdProductoInventario { get; set; }
        public string Nombre { get; set; }
        public int CantidadTotal { get; set; }
        public int CantidadActual { get; set; }
        public int Cantidadresrvado { get; set; }
        public int CantidadPrestado { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }

        public Producto Producto { get; set; }

        public ICollection<Reserva> Reserva { get; set; }
    }
}
