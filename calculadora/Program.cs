using System;

namespace Calculadora
{
  public class Program
  {
    static void Main(string[] args)
    {
      int op;
      double? resultado = null;

      do
      {
        Console.WriteLine("\n \t Escolha uma opção a seguir: \n");
        Console.WriteLine("[1] Calcular");
        Console.WriteLine("[2] Zerar");
        Console.WriteLine("[3] Sair \n");
        op = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (op)
        {
          case 1:
            {
              resultado = Calcular(resultado);
              break;
            };
          case 2:
            {
              resultado = Zerar();
              resultado = Calcular(resultado);
              break;
            };
          case 3:
            {
              Sair();
              break;
            };
          default:
            {
              Console.WriteLine("\nOpção inválida!");
              break;
            }
        }
      } while (op != 3);
    }
    public static double? Calcular(double? resultado)
    {
      char operacao;
      double num, resultado_parcial;

      if (resultado == null)
      {
        Console.Write("Digite o número: ");
        resultado = Convert.ToDouble(Console.ReadLine());
      }
      else
      {
        Console.WriteLine($"Resultado = {resultado}");
      }

      Console.Write("Digite o símbolo da operação. (Ex: +, -, x, / ): ");
      operacao = Convert.ToChar(Console.ReadLine());

      switch (operacao)
      {
        case '+':
          {
            Console.Write("Digite o número: ");
            num = Convert.ToDouble(Console.ReadLine());
            resultado_parcial = (double)Calculadora.Somar(resultado, num);
            Console.WriteLine($"\n{resultado} + {num} = {resultado_parcial}");
            resultado = resultado_parcial;
            Console.WriteLine("\n-----------------------------------------");
            Console.Write("Aperte qualquer tecla para continuar... ");
            Console.ReadKey();
            Console.Clear();
            break;
          };
        case '-':
          {
            Console.Write("Digite o número: ");
            num = Convert.ToDouble(Console.ReadLine());
            resultado_parcial = (double)Calculadora.Subtrair(resultado, num);
            Console.WriteLine($"\n{resultado} - {num} = {resultado_parcial}");
            resultado = resultado_parcial;
            Console.WriteLine("\n-----------------------------------------");
            Console.Write("Aperte qualquer tecla para continuar... ");
            Console.ReadKey();
            Console.Clear();
            break;
          };
        case 'x':
        case '*':
          {
            Console.Write("Digite o número: ");
            num = Convert.ToDouble(Console.ReadLine());
            resultado_parcial = (double)Calculadora.Multiplicar(resultado, num);
            Console.WriteLine($"\n{resultado} x {num} = {resultado_parcial}");
            resultado = resultado_parcial;
            Console.WriteLine("\n-----------------------------------------");
            Console.Write("Aperte qualquer tecla para continuar... ");
            Console.ReadKey();
            Console.Clear();
            break;
          };
        case '/':
          {
            Console.Write("Digite o número: ");
            num = Convert.ToDouble(Console.ReadLine());
            resultado_parcial = (double)Calculadora.Dividir(resultado, num);
            Console.WriteLine($"\n{resultado} / {num} = {resultado_parcial}");
            resultado = resultado_parcial;
            Console.WriteLine("\n-----------------------------------------");
            Console.Write("Aperte qualquer tecla para continuar... ");
            Console.ReadKey();
            Console.Clear();
            break;
          };
        default:
          {
            Console.WriteLine("\nOpção inválida!");
            break;
          }
      }
      return resultado;
    }
    public static double? Zerar()
    {
      Console.WriteLine("Resultado zerado!\n");
      return null;
    }
    public static void Sair()
    {
      Console.WriteLine("\nFinalizando...");
      Console.WriteLine("\n\n\n\n\n - Até mais \n\n\n\n\n");
    }
  }
}