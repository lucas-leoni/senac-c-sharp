using System;

namespace ExerciciosFuncao
{
  public class Case1
  {

    public static void Run()
    {
      /*
        Exercício 31. FUP que leia um número inteiro de 1 a 3 e imprima o 
        tipo de combustível correspondente,sendo 1 - Álcool, 2 - Gasolina, 
        3 - Diesel, utilizando a estrutura switch case. Implemente umafunção 
        que recebe o número e retorna o tipo de combustível correspondente.
      */
      Console.WriteLine("Exercício 1 \n");

      int op;

      Console.WriteLine("\t Escolha uma opção a seguir: \n");
      Console.WriteLine("[1] Álcool");
      Console.WriteLine("[2] Gasolina");
      Console.WriteLine("[3] Diesel\n");
      op = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("");
      Combustivel(op);

      Console.WriteLine("\n-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }

    public static void Combustivel(int op)
    {
      switch (op)
      {
        case 1:
          {
            Console.WriteLine("Combustível escolhido: Álcool!");
            break;
          };
        case 2:
          {
            Console.WriteLine("Combustível escolhido: Gasolina!");
            break;
          };
        case 3:
          {
            Console.WriteLine("Combustível escolhido: Diesel!");
            break;
          };
        default:
          {
            Console.WriteLine("Opção inválida!");
            break;
          }
      }
    }
  }
}
