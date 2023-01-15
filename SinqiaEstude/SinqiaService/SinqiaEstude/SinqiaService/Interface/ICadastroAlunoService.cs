using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SinqiaEstude.SinqiaService.Interface
{
    public interface ICadastroAlunoService
    {
        public void CadastrarAluno(string nome, string email);
    }
}
