using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebApi.Models
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int Cantidad { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public int CantidadDias { get; set; }
        public int CantidadDiasReales { get; set; }
        public decimal TotalPagado { get; set; }
        public int IdEncargado { get; set; }
        public int IdReserva { get; set; }

        public Encargado Encargado { get; set; }
        public Reserva Reserva { get; set; }
    }
}
