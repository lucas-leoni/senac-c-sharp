using System;

namespace Inseto
{
  public class Program
  {
    static void Main(string[] args)
    {
      Borboleta[] borboletas = new Borboleta[2];
      string nome;
      int qtd_cores;

      for (int i = 0; i < 2; i++)
      {
        Console.Write($"Digite o nome da {i + 1}º borboleta: ");
        nome = Console.ReadLine();
        Console.Write($"Digite a quantidade de cores do(a) {nome}: ");
        qtd_cores = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("");
        borboletas[i] = new Borboleta
        {
          Nome = nome,
          QtdCores = qtd_cores
        };
      }

      for (int i = 0; i < 2; i++)
      {
        Console.WriteLine(borboletas[i].ToString());
        Console.WriteLine("----");
      }

      Formiga[] formigas = new Formiga[2];
      string nome2;
      double tamanho;

      for (int i = 0; i < 2; i++)
      {
        Console.Write($"Digite o nome da {i + 1}º formiga: ");
        nome2 = Console.ReadLine();
        Console.Write($"Digite o tamanho do(a) {nome2}: ");
        tamanho = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("");
        formigas[i] = new Formiga
        {
          Nome = nome2,
          Tamanho = tamanho
        };
      }

      for (int i = 0; i < 2; i++)
      {
        Console.WriteLine(formigas[i].ToString());
        Console.WriteLine("----");
      }
    }
  }
}