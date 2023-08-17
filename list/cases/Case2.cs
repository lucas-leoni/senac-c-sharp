using System;

namespace List
{
  public class Case2
  {
    public static void Run()
    {
      Console.WriteLine("\nExemplo 2\n");

      // Criando uma nova lista vazia do tipo "int".
      List<int> numeros = new List<int>();

      // Adicionando elementos à lista.
      numeros.AddRange(new int[] { -4, -2, 0, 2, 4 });
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("\nAdicionando...\n");
      Console.WriteLine("-----------------------------------------");

      // Retornando os elementos da lista.
      Console.WriteLine("Elementos da lista:\n");
      foreach (int numero in numeros)
      {
        Console.WriteLine($"Índice: {numeros.IndexOf(numero)} | Elemento: {numero}");
      }

      // Atualizando elementos da lista através do seu índice.
      numeros[0] = -2;
      numeros[1] = -1;
      numeros[3] = 1;
      numeros[4] = 2;
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("\nAtualizando...\n");
      Console.WriteLine("-----------------------------------------");

      // Retornando novamente os elementos da lista, para visualizar as alterações.
      Console.WriteLine("Elementos da lista:\n");
      foreach (int numero in numeros)
      {
        Console.WriteLine($"Índice: {numeros.IndexOf(numero)} | Elemento: {numero}");
      }

      // Excluindo elementos da lista através do índice.
      numeros.RemoveAt(1);
      numeros.RemoveAt(2);
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("\nExcluindo...\n");
      Console.WriteLine("-----------------------------------------");

      // Retornando novamente os elementos da lista, para visualizar as exclusões.
      Console.WriteLine("Elementos da lista:\n");
      foreach (int numero in numeros)
      {
        Console.WriteLine($"Índice: {numeros.IndexOf(numero)} | Elemento: {numero}");
      }

      Console.WriteLine("-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
