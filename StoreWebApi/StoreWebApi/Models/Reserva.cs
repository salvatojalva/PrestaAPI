using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebApi.Models
{
    public class Reserva
    {
        public Reserva()
        {
            Prestamo = new HashSet<Prestamo>();
        }
        public int IdReserva { get; set; }
        public int Cantidad { get; set; }
        public decimal Adelanto { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }
        public int IdEncargado { get; set; }
        public int IdCliente { get; set; }

        public Encargado Encargado { get; set; }
        public Cliente Cliente { get; set; }
        public ProductoInventario Inventario { get; set; }

        public ICollection<Prestamo> Prestamo { get; set; }
    }
}
