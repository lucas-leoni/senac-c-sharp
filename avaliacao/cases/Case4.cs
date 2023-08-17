using System;

namespace Avaliacao
{
  public class Case4
  {

    public static void Run()
    {
      //Exercício 23. FUP que solicite um numero e escreva "Batata" enquanto o usuario digita 1;
      Console.WriteLine("Exercício 4 \n");

      double num;

      do
      {
        Console.Write("Digite um número: ");
        num = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(num == 1 ? "Batata!\n" : "");
      } while (num == 1);

      Console.WriteLine("-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
