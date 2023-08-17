using System;

namespace Avaliacao
{
  public class Case5
  {

    public static void Run()
    {
      //Exercício 24. FUP que imprima a tabuada de um numero de 0 a 10;
      Console.WriteLine("Exercício 5 \n");

      double num;
      int i;
      double[] resultados = new double[10];

      Console.Write("Digite um número para ver a sua tabuada de 1 a 10: ");
      num = Convert.ToDouble(Console.ReadLine());
      for (i = 0; i < 10; i++)
      {
        resultados[i] = num * (i + 1);
      }
      Console.WriteLine("");
      for (i = 0; i < 10; i++)
      {
        Console.Write(num + " X " + (i + 1) + " = " + resultados[i] + "\n");
      }

      Console.WriteLine("\n-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
