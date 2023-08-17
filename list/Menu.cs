using System;

namespace List
{
  public class Menu
  {
    public static void Run()
    {
      int op, i;

      do
      {
        Console.WriteLine("\n \t Escolha uma opção a seguir: \n");
        for (i = 1; i <= 2; i++)
        {
          Console.WriteLine($"[{i}] Exemplo {i}");
        }
        Console.WriteLine($"[{i}] Encerrar \n");
        op = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (op)
        {
          case 1:
            {
              Case1.Run();
              break;
            };
          case 2:
            {
              Case2.Run();
              break;
            };
          case 3:
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
      } while (op != 3);
      Console.WriteLine("\n\n\n\n\n - Até mais \n\n\n\n\n");
    }
  }
}