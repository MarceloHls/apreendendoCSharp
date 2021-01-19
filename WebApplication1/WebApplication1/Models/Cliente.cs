using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebApplication1.Models
{
    public class Cliente
    {
        public string nome { get; set; }

        public Cliente(string nome)
        {
            this.nome = nome;
        }
    }
}
