using System;

namespace Avaliacao
{
  public class Case6
  {

    public static void Run()
    {
      Console.WriteLine("Exercício 6 \n");

      int qtd_sequencias, i = 1, primeiro = 0, segundo = 1;
      Console.Write("Digite a quantidade de sequências a serem impressas: ");
      qtd_sequencias = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("");
      for (; i <= qtd_sequencias; i++)
      {
        for (; primeiro < segundo; primeiro++)
        {
          Console.Write("*");
        }
        segundo += (i + 1);
        Console.WriteLine("");
        for (; primeiro < segundo; primeiro++)
        {
          Console.Write("*");
        }
        Console.WriteLine("");
        segundo += i;
        for (; primeiro < segundo; primeiro++)
        {
          Console.Write("*");
        }
        Console.WriteLine("");
        segundo += (i + 1);
      }

      Console.WriteLine("-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
