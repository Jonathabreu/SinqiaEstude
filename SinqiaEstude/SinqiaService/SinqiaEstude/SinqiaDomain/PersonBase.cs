using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinqiaEstude.SinqiaDomain
{
    public class PersonBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public PersonBase(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
