using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreWebApi.Models
{
    public class Usuario
    {
        public Usuario()
        {
            Encargado = new HashSet<Encargado>();
            Cliente = new HashSet<Cliente>();
        }

        public int IdUsuario { get; set; }
        public string UserName { get; set; }


        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Encargado> Encargado { get; set; }
    }
}
