using System;

namespace ExerciciosFuncao
{
  public class Case3
  {

    public static void Run()
    {
      /*
        Exercício 33. FUP que leia um número inteiro de 1 a 12 e imprima o nome 
        do mês correspondente, utilizando a estrutura switch case. Implemente 
        uma função que recebe o número e retorna o nome do mês correspondente.
      */
      Console.WriteLine("Exercício 3 \n");

      int i, op;
      string[] meses = new string[] {
        "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
        "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
      };

      Console.WriteLine("\t Escolha uma opção a seguir: \n");
      for (i = 0; i < 12; i++)
      {
        Console.WriteLine($"[{i + 1}] {meses[i]}");
      }
      Console.WriteLine();
      op = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine();
      Mes(op, meses);

      Console.WriteLine("\n-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }

    public static void Mes(int op, string[] meses)
    {
      switch (op)
      {
        case 1:
          {
            Console.WriteLine($"Mês escolhido: {meses[0]}!");
            break;
          };
        case 2:
          {
            Console.WriteLine($"Mês escolhido: {meses[1]}!");
            break;
          };
        case 3:
          {
            Console.WriteLine($"Mês escolhido: {meses[2]}!");
            break;
          };
        case 4:
          {
            Console.WriteLine($"Mês escolhido: {meses[3]}!");
            break;
          };
        case 5:
          {
            Console.WriteLine($"Mês escolhido: {meses[4]}!");
            break;
          };
        case 6:
          {
            Console.WriteLine($"Mês escolhido: {meses[5]}!");
            break;
          };
        case 7:
          {
            Console.WriteLine($"Mês escolhido: {meses[6]}!");
            break;
          };
        case 8:
          {
            Console.WriteLine($"Mês escolhido: {meses[7]}!");
            break;
          };
        case 9:
          {
            Console.WriteLine($"Mês escolhido: {meses[8]}!");
            break;
          };
        case 10:
          {
            Console.WriteLine($"Mês escolhido: {meses[9]}!");
            break;
          };
        case 11:
          {
            Console.WriteLine($"Mês escolhido: {meses[10]}!");
            break;
          };
        case 12:
          {
            Console.WriteLine($"Mês escolhido: {meses[11]}!");
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
