using System;

namespace Avaliacao
{
  public class Menu
  {

    public static void Run()
    {
      int op, i;

      do
      {
        Console.WriteLine("\n \t Escolha uma opção a seguir: \n");
        for (i = 1; i <= 6; i++)
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
              //Exercício 3. FUP que solicite o peso de 5 pessoas e calcule a media; Imprima o resultado;
              Case1.Run();
              break;
            };
          case 2:
            {
              /*
                Exercício 10. FUP que calcule o IMC -solicite se é H ou M e faça o calculo;
                - para homens: (72.7*h)-58
                - para mulheres: (62.1*h)-44.7
              */
              Case2.Run();
              break;
            };
          case 3:
            {
              /*
                Exercício 20. FUP que leia:

                • a percentagem do IPI a ser acrescido no valor das peças
                • o código da peça 1, valor unitário da peça 1, quantidade de peças 1
                • o código da peça 2, valor unitário da peça 2, quantidade de peças 2

                O algoritmo deve calcular o valor total a ser pago e apresentar o resultado.
                Fórmula : ValorTotal = (valor1*quant1 + valor2*quant2)*(IPI/100 + 1)
              */
              Case3.Run();
              break;
            };
          case 4:
            {
              //Exercício 23. FUP que solicite um numero e escreva "Batata" enquanto o usuario digita 1;
              Case4.Run();
              break;
            };
          case 5:
            {
              //Exercício 24. FUP que imprima a tabuada de um numero de 0 a 10;
              Case5.Run();
              break;
            };
          case 6:
            {
              Case6.Run();
              break;
            };
          case 7:
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
      } while (op != 7);
      Console.WriteLine("\n\n\n\n\n - Até mais \n\n\n\n\n");
    }
  }
}
