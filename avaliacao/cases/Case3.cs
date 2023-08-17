using System;

namespace Avaliacao
{
  public class Case3
  {

    public static void Run()
    {
      /*
        Exercício 20. FUP que leia:

        • a percentagem do IPI a ser acrescido no valor das peças
        • o código da peça 1, valor unitário da peça 1, quantidade de peças 1
        • o código da peça 2, valor unitário da peça 2, quantidade de peças 2

        O algoritmo deve calcular o valor total a ser pago e apresentar o resultado.
        Fórmula : ValorTotal = (valor1*quant1 + valor2*quant2)*(IPI/100 + 1)
      */
      Console.WriteLine("Exercício 3 \n");

      int i;
      int[] codigos = new int[2];
      int[] quantidades = new int[2];
      double ipi, valor_total;
      double[] valores = new double[2];

      Console.Write("Digite a porcentagem do IPI: ");
      ipi = Convert.ToDouble(Console.ReadLine());
      for (i = 0; i < 2; i++)
      {
        Console.Write("Digite o código da peça " + (i + 1) + ": ");
        codigos[i] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o valor unitário da peça " + (i + 1) + ": ");
        valores[i] = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a quantidade da peça " + (i + 1) + ": ");
        quantidades[i] = Convert.ToInt32(Console.ReadLine());
      }
      valor_total = (valores[0] * quantidades[0] + valores[1] * quantidades[1]) * (ipi / 100 + 1);
      Console.WriteLine("\nO valor total a ser pago é: R$ " + valor_total.ToString("0.00"));

      Console.WriteLine("\n-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
