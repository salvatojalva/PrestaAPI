using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebApi.DTOs
{
    public class RetornoDTO
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

        public EncargadoDTO Encargado { get; set; }
        public ReservaDTO Reserva { get; set; }
    }
}
