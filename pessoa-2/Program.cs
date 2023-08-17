using System;

namespace Programa
{
  public class Program
  {
    static void Main(string[] args)
    {
      Pessoa[] pessoas = new Pessoa[5];
      string nome, email;
      int idade;

      for (int i = 0; i < 5; i++)
      {
        Console.Write($"Digite o nome da {i + 1}ª pessoa: ");
        nome = Console.ReadLine();
        Console.Write($"Digite a idade de {nome}: ");
        idade = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Digite o email de {nome}: ");
        email = Console.ReadLine();
        pessoas[i] = new Pessoa { Nome = nome, Email = email, Idade = idade };
      }

      for (int i = 0; i < 5; i++)
      {
        Console.WriteLine(pessoas[i].ToString());
        Console.WriteLine("----");
      }
    }
  }
}