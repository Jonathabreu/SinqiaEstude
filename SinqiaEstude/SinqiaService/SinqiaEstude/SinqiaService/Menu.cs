namespace MenuAluno
{
    public class Menu
    {
        public void MenuSinqiaEstude()
        {
            Console.WriteLine("- Menu:\n");
            Console.WriteLine("1 - Gestão de Alunos\n");
            Console.WriteLine("2 - Gestão de Professores\n");
            Console.WriteLine("3 - Currículo Escolar\n");
            Console.WriteLine("4 - Gestão Financeira\n");

            var opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("***********************************\n");

            switch(opcao)
            {
                case 1:
                    var menuGestaoAlunos = new MenuGestaoAlunos.GestaoDeAlunos();
                    menuGestaoAlunos.GestaoAlunos();
                    break;
                case 2:
                    var menuGestaoProfessores = new MenuGestaoProfessores.GestaoProfessores();
                    menuGestaoProfessores.GestãoProfessores();
                    break;
            }
        }        
    }
}
