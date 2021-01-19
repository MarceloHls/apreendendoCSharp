using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{

    [Route("[controller]")]
    public class ClientesController : Controller
    {
        private static List<Cliente> clientes = new List<Cliente>();
  
        [HttpGet]

        public List<Cliente> GetCliente()
        {
         return clientes;
        }

        [HttpPost]

        public void AddCliente([FromBody] string nome )
        {
            if (!string.IsNullOrEmpty(nome))
            {
                clientes.Add(new Cliente(nome));
            }
        }

        [HttpDelete]

        public void DeletarCliente([FromBody] string nome)
        {
            try
            {
                clientes.RemoveAt(clientes.IndexOf(clientes.First(x => x.nome.Equals(nome))));
            }
            catch
            {

            }
           
        }

    }
}
