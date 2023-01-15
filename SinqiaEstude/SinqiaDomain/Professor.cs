using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinqiaEstude.SinqiaDomain
{
    internal class Professor : PersonBase
    {
        public string Materia { get; set; }
        public Professor(string nome, string email) : base(nome, email)
        {
        }
    }
}
