using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebApi.DTOs
{
    public class UsuarioDTO
    {
        public int IdUsuario { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<ClienteDTO> Cliente { get; set; }
        public List<EncargadoDTO> Encargado { get; set; }
    }
}
