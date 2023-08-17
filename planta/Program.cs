using System;

namespace Planta
{
  class Program
  {
    static void Main(string[] args)
    {
      Planta planta = new Planta();
      planta.Construir();
      Console.WriteLine();

      List<Casa> listaCasas = new List<Casa>();

      Casa casa = new Casa();
      Console.Write("Digite o nome do arquiteto da casa: ");
      casa.Arquiteto = Console.ReadLine();
      Console.Write("Digite a dimensão da casa em m²: ");
      casa.Dimensao = Convert.ToDouble(Console.ReadLine());
      Console.Write("A casa possui jardim? (s/n): ");
      casa.PossuiJardim = Convert.ToChar(Console.ReadLine());
      Console.Write("A casa possui churrasqueira? (s/n): ");
      casa.PossuiChurrasqueira = Convert.ToChar(Console.ReadLine());
      listaCasas.Add(casa);
      Console.WriteLine();
      casa.Construir();
      casa.LimparJardim();
      casa.FazerChurrasco();
      casa.RetornaCasas(listaCasas);

      planta.Construir();
      Console.WriteLine();

      List<Apart> listaAparts = new List<Apart>();

      Apart apart = new Apart();
      Console.Write("Digite o nome do arquiteto do apartamento: ");
      apart.Arquiteto = Console.ReadLine();
      Console.Write("Digite a dimensão do apartamento em m²: ");
      apart.Dimensao = Convert.ToDouble(Console.ReadLine());
      Console.Write("Digite o número do apartamento: ");
      apart.NumeroApart = Convert.ToInt32(Console.ReadLine());
      Console.Write("O apartamento possui piscina? (s/n): ");
      apart.PossuiPiscina = Convert.ToChar(Console.ReadLine());
      listaAparts.Add(apart);
      Console.WriteLine();
      apart.Construir();
      apart.ReceberEncomenda();
      apart.UsarPiscina();
      apart.RetornaAparts(listaAparts);
    }
  }
}