using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebApi.DTOs
{
    public class ReservaDTO
    {
        public int IdReserva { get; set; }
        public int Cantidad { get; set; }
        public decimal Adelanto { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }
        public int IdEncargado { get; set; }
        public int IdCliente { get; set; }

        public EncargadoDTO Encargado { get; set; }
        public ClienteDTO Cliente { get; set; }
        public ProductoInventarioDTO Inventario { get; set; }

        public List<PrestamoDTO> Prestamo { get; set; }
    }
}
