using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinqiaEstude.SinqiaDomain
{
    public class Aluno : PersonBase
    {
        public List<Materia> Materias { get; set; }
        public Aluno(string nome, string email) : base(nome, email)
        {
        }
    }
}
