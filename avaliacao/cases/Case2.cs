using System;

namespace Avaliacao
{
  public class Case2
  {

    public static void Run()
    {
      /*
        Exercício 10. FUP que calcule o IMC -solicite se é H ou M e faça o calculo;
        - para homens: (72.7*h)-58
        - para mulheres: (62.1*h)-44.7
      */
      Console.WriteLine("Exercício 2 \n");

      char genero;
      double altura, peso, imc;

      Console.Write("Digite [H] se você é Homem ou [M] se você é Mulher: ");
      genero = Convert.ToChar(Console.ReadLine());
      Console.Write("Digite a sua altura em metros: ");
      altura = Convert.ToDouble(Console.ReadLine());
      if (genero == 'H' || genero == 'h')
      {
        Console.WriteLine("\nSeu IMC fictício é: " + ((72.7 * altura) - 58).ToString("0.00"));
      }
      else if (genero == 'M' || genero == 'm')
      {
        Console.WriteLine("\nSeu IMC fictício é: " + ((62.1 * altura) - 44.7).ToString("0.00"));
      }
      Console.WriteLine("\n-----------------------------------------");
      Console.WriteLine("\nAgora vamos calcular o seu IMC seguindo a fórmula padrão...");
      Console.Write("\nPara que possamos calcular digite o seu peso em Kg: ");
      peso = Convert.ToDouble(Console.ReadLine());
      imc = peso / (altura * altura);
      Console.Write("\nO seu IMC é: " + imc.ToString("0.00"));
      if (imc < 18.5)
      {
        Console.Write(" você está muito magro!");
      }
      else if (imc >= 18.5 && imc <= 24.9)
      {
        Console.Write(" seu peso está normal!");
      }
      else if (imc >= 25 && imc <= 29.9)
      {
        Console.Write(" você está em sobrepeso!");
      }
      else if (imc >= 30 && imc <= 39.9)
      {
        Console.Write(" você está com obesidade!");
      }
      else if (imc > 40)
      {
        Console.Write(" você está com obesidade grave!");
      }

      Console.WriteLine("\n\n-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
