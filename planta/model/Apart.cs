using System;

namespace Planta
{
  class Apart : Planta
  {
    public int NumeroApart { get; set; }
    public char PossuiPiscina { get; set; }
    public void ReceberEncomenda()
    {
      Console.WriteLine($"Recebendo encomenda no apartamento nº {NumeroApart}...");
    }
    public void UsarPiscina()
    {
      switch (PossuiPiscina)
      {
        case 's':
        case 'S':
          {
            Console.WriteLine("Nadando...");
            break;
          }
        case 'n':
        case 'N':
          {
            Console.WriteLine("Não temos piscina 😢");
            break;
          }
      }
    }
    public void RetornaAparts(List<Apart> listaAparts)
    {
      foreach (Apart item in listaAparts)
      {
        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine($"Apart: {listaAparts.IndexOf(item) + 1}");
        Console.WriteLine($"Arquiteto: {item.Arquiteto}");
        Console.WriteLine($"Dimensão: {item.Dimensao}m²");
        Console.WriteLine($"Número do apartamento: {item.NumeroApart}");
        Console.WriteLine($"Possui piscina: {item.PossuiPiscina}");
      }
      Console.WriteLine("-----------------------------------------\n");
    }
    public override void Construir()
    {
      Console.WriteLine("Construindo o apartamento...");
    }
  }
}