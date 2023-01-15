namespace SinqiaEstude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();

            Console.ReadKey();
        }

        public static void Menu()
        {
            var menu = new MenuAluno.Menu();
            menu.MenuSinqiaEstude();           
        }
    }
}