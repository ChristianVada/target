using System;
using Target;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("Escolha um exercício para executar:");
            Console.WriteLine("1 - Exercicio 1");
            Console.WriteLine("2 - Exercicio 2");
            Console.WriteLine("3 - Exercicio 3");
            Console.WriteLine("4 - Exercicio 4");
            Console.WriteLine("5 - Exercicio 5");
            Console.WriteLine("0 - Sair");
            Console.Write("Digite o número do exercício (ou 0 para sair): ");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    ExecutarExercicio(new Ex1());
                    break;
                case "2":
                    ExecutarExercicio(new Ex2());
                    break;
                case "3":
                    ExecutarExercicio(new Ex3());
                    break;
                case "4":
                    ExecutarExercicio(new Ex4());
                    break;
                case "5":
                    ExecutarExercicio(new Ex5());
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }

    static void ExecutarExercicio(dynamic exercicio)
    {
        exercicio.Resultado();
        bool repetir = true;

        while (repetir)
        {
            Console.Write("Deseja executar este exercício novamente? (S/N): ");
            string resposta = Console.ReadLine().ToUpper();

            if (resposta == "S")
            {
                exercicio.Resultado();
            }
            else if (resposta == "N")
            {
                repetir = false;
            }
            else
            {
                Console.WriteLine("Resposta inválida. Digite 'S' para sim ou 'N' para não.");
            }
        }
    }
}
