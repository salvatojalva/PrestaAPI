using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebApi.Models
{
    public class Retorno
    {
        public int IdRetorno { get; set; }
        public int Cantidad { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }
        public DateTime FechaRetorno { get; set; }
        public int Perdidas { get; set; }
        public decimal Pagado { get; set; }
        public int IdEncargado { get; set; }
        public int IdReserva { get; set; }

        public Encargado Encargado { get; set; }
        public Prestamo Reserva { get; set; }
    }
}
