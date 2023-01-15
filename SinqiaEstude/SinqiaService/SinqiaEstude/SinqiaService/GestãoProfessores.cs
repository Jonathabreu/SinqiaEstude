namespace MenuGestaoProfessores
{
    public class GestaoProfessores
    {
        public void GestãoProfessores()
        {
            Console.WriteLine("1 - Listar Professores:\n");
            Console.WriteLine("2 - Cadastrar Professores\n");
            Console.WriteLine("3 - Cadastrar Matéria\n");
            Console.WriteLine("5 - Excluir Professores\n");
            Console.WriteLine("6 - Sair\n");

            var opcao = int.Parse(Console.ReadLine());
        }
    }
}
