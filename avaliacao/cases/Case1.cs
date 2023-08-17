using System;

namespace Avaliacao
{
  public class Case1
  {

    public static void Run()
    {
      //Exercício 3. FUP que solicite o peso de 5 pessoas e calcule a media; Imprima o resultado;
      Console.WriteLine("Exercício 1 \n");

      int i, tamanho = 5;
      double[] pesos = new double[tamanho];
      double media;

      for (i = 0; i < tamanho; i++)
      {
        Console.Write("Digite o peso da " + (i + 1) + "ª pessoa em Kg: ");
        pesos[i] = Convert.ToDouble(Console.ReadLine());
      }
      media = (pesos[0] + pesos[1] + pesos[2] + pesos[3] + pesos[4]) / tamanho;
      Console.WriteLine("\nA média dos pesos é: " + media + " Kg");

      Console.WriteLine("\n-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
