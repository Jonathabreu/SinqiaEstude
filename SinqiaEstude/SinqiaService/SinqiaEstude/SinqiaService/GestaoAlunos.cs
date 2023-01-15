namespace MenuGestaoAlunos
{
    public class GestaoDeAlunos
    {
        public void GestaoAlunos()
        {
            Console.WriteLine("1 - Listar Alunos:\n");
            Console.WriteLine("2 - Cadastrar Alunos\n");
            Console.WriteLine("3 - Cadastrar Matérias\n");
            Console.WriteLine("4 - Cadastrar Nota\n");
            Console.WriteLine("5 - Excluir Aluno\n");
            Console.WriteLine("6 - Sair\n");

            var opcao = int.Parse(Console.ReadLine());
        }
    }
}
