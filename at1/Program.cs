using System.ComponentModel.Design;

namespace PrimeirosExercicios
{
    internal class Programa
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Preciso de dois nomes.");
            Console.WriteLine();
            Console.WriteLine("Me informe o nome da primeira pessoa:");
            string nome1 = (Console.ReadLine());

            Console.WriteLine("Me informe a idade dessa pessoa:");
            int idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Me informe o nome da segunda pessoa:");
            string nome2 = Console.ReadLine();

            Console.WriteLine("Informe a idade dessa pessoa:");
            int idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Irei informa o nome da pessoa mais velha.");


            if (idade1 == idade2)
            {
                Console.WriteLine("Ambas pessoas possuí a mesma idade");
            }

            else if (idade1 > idade2)
            {
                Console.WriteLine($"{nome1} é mais velha(o).");
            }

            else { Console.WriteLine($"{nome2} é a pessoa mais velha(o)."); }

        }
    }
}
