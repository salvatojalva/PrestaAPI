using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebApi.DTOs
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public decimal precio { get; set; }
        public int IdCategoria { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }

        public CategoriaDTO Categoria { get; set; }
        public List<ProductoInventarioDTO> ProductoInventario { get; set; }
    }
}
