using System;

namespace ExerciciosFuncao
{
  public class Menu
  {

    public static void Run()
    {
      int op, i;

      do
      {
        Console.WriteLine("\n \t Escolha uma opção a seguir: \n");
        for (i = 1; i <= 4; i++)
        {
          Console.WriteLine($"[{i}] Exercício {i}");
        }
        Console.WriteLine($"[{i}] Encerrar \n");
        op = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (op)
        {
          case 1:
            {
              //Exercício 31.
              Case1.Run();
              break;
            };
          case 2:
            {
              //Exercício 32.
              Case2.Run();
              break;
            };
          case 3:
            {
              // Exercício 33.
              Case3.Run();
              break;
            };
          case 4:
            {
              //Exercício 34.
              Case4.Run();
              break;
            };
          case 5:
            {
              Console.WriteLine("\nFinalizando...");
              break;
            };
          default:
            {
              Console.WriteLine("\nOpção inválida!");
              break;
            }
        }
      } while (op != 5);
      Console.WriteLine("\n\n\n\n\n - Até mais \n\n\n\n\n");
    }
  }
}
