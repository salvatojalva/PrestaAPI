using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebApi.DTOs
{
    public class ProductoInventarioDTO
    {
        public int IdProductoInventario { get; set; }
        public string Nombre { get; set; }
        public int CantidadTotal { get; set; }
        public int CantidadActual { get; set; }
        public int Cantidadresrvado { get; set; }
        public int CantidadPrestado { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }

        public ProductoDTO Producto { get; set; }

        public List<ReservaDTO> Reservas { get; set; }
    }
}
