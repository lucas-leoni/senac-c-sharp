using System;

namespace Programa
{
  public class Program
  {
    static void Main(string[] args)
    {
      Pessoa pessoa = new Pessoa { };

      Console.Write("Digite o nome da 1ª pessoa: ");
      pessoa.Nome = Console.ReadLine();
      Console.Write($"Digite a idade de {pessoa.Nome}: ");
      pessoa.Idade = Convert.ToInt32(Console.ReadLine());
      Console.Write($"Digite o endereço de {pessoa.Nome}: ");
      pessoa.Endereco = Console.ReadLine();

      Console.WriteLine();

      Pessoa pessoa2 = new Pessoa { };
      Console.Write($"Digite o nome da 2ª pessoa: ");
      pessoa2.Nome = Console.ReadLine();
      Console.Write($"Digite a idade de {pessoa2.Nome}: ");
      pessoa2.Idade = Convert.ToInt32(Console.ReadLine());
      Console.Write($"Digite o endereço de {pessoa2.Nome}: ");
      pessoa2.Endereco = Console.ReadLine();

      Console.WriteLine();
      pessoa.Apresentar();

      Console.WriteLine();
      pessoa2.Apresentar();
      Console.WriteLine();

      if (pessoa.Idade < pessoa2.Idade)
      {
        Console.WriteLine($"{pessoa.Nome} é mais jovem que {pessoa2.Nome}!");
      }
      else
      {
        Console.WriteLine($"{pessoa2.Nome} é mais jovem que {pessoa.Nome}!");
      }
    }
  }
}