using System;

namespace ExerciciosFuncao
{
  public class Case4
  {

    public static void Run()
    {
      /*
        Exercício 34. FUP que leia um caractere digitado pelo usuário e 
        verifique se ele é uma vogal ou uma consoante, utilizando a 
        estrutura switch case. Implemente uma função que recebe o 
        caractere e retorna se ele é uma vogal ou uma consoante.
      */
      Console.WriteLine("Exercício 4 \n");

      char letra;

      Console.Write("Digite uma letra: ");
      letra = Convert.ToChar(Console.ReadLine());
      Console.WriteLine();
      Vogal(letra);

      Console.WriteLine("\n-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }

    public static void Vogal(char letra)
    {
      switch (letra)
      {
        case 'a':
        case 'A':
          {
            Console.WriteLine($"A letra '{letra}' é uma vogal!");
            break;
          };
        case 'e':
        case 'E':
          {
            Console.WriteLine($"A letra '{letra}' é uma vogal!");
            break;
          };
        case 'i':
        case 'I':
          {
            Console.WriteLine($"A letra '{letra}' é uma vogal!");
            break;
          };
        case 'o':
        case 'O':
          {
            Console.WriteLine($"A letra '{letra}' é uma vogal!");
            break;
          };
        case 'u':
        case 'U':
          {
            Console.WriteLine($"A letra '{letra}' é uma vogal!");
            break;
          };
        default:
          {
            Console.WriteLine($"A letra '{letra}' é uma consoante!");
            break;
          }
      }
    }
  }
}
