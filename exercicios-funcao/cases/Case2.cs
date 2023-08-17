using System;

namespace ExerciciosFuncao
{
  public class Case2
  {

    public static void Run()
    {
      /*
        Exercício 32. FUP que leia um número inteiro de 1 a 7 e imprima o 
        dia da semana correspondente, utilizando a estrutura switch case. 
        Implemente uma função que recebe o número e retorna o nome do dia 
        da semana correspondente.
      */
      Console.WriteLine("Exercício 2 \n");

      int i, op;
      string[] dias = new string[] { "Domingo", "Segunda-Feira", "Terça-Feira",
      "Quarta-Feira", "Quinta-Feira", "Sexta-Feira", "Sábado" };

      Console.WriteLine("\t Escolha uma opção a seguir: \n");
      for (i = 0; i < 7; i++)
      {
        Console.WriteLine($"[{i + 1}] {dias[i]}");
      }
      Console.WriteLine();
      op = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();
      DiaSemana(op, dias);

      Console.WriteLine("\n-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }

    public static void DiaSemana(int op, string[] dias)
    {
      switch (op)
      {
        case 1:
          {
            Console.WriteLine($"Dia escolhido: {dias[0]}!");
            break;
          };
        case 2:
          {
            Console.WriteLine($"Dia escolhido: {dias[1]}!");
            break;
          };
        case 3:
          {
            Console.WriteLine($"Dia escolhido: {dias[2]}!");
            break;
          };
        case 4:
          {
            Console.WriteLine($"Dia escolhido: {dias[3]}!");
            break;
          };
        case 5:
          {
            Console.WriteLine($"Dia escolhido: {dias[4]}!");
            break;
          };
        case 6:
          {
            Console.WriteLine($"Dia escolhido: {dias[5]}!");
            break;
          };
        case 7:
          {
            Console.WriteLine($"Dia escolhido: {dias[6]}!");
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
