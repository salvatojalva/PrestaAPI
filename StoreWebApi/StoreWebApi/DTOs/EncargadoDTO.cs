using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebApi.DTOs
{
    public class EncargadoDTO
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdUsuario { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Deleted { get; set; }

        public UsuarioDTO Usuario { get; set; }

        public List<ReservaDTO> Reservas { get; set; }
        public List<PrestamoDTO> Prestamos { get; set; }
        public List<RetornoDTO> Retornos { get; set; }
    }
}
