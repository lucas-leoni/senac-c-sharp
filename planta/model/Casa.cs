using System;

namespace Planta
{
  class Casa : Planta
  {
    public char PossuiJardim { get; set; }
    public char PossuiChurrasqueira { get; set; }
    public void LimparJardim()
    {
      switch (PossuiJardim)
      {
        case 's':
        case 'S':
          {
            Console.WriteLine("Limpando o jardim...");
            break;
          }
        case 'n':
        case 'N':
          {
            Console.WriteLine("Não temos jardim 😢");
            break;
          }
      }
    }
    public void FazerChurrasco()
    {
      switch (PossuiChurrasqueira)
      {
        case 's':
        case 'S':
          {
            Console.WriteLine("Fazendo um churras...");
            break;
          }
        case 'n':
        case 'N':
          {
            Console.WriteLine("Não temos churrasqueira 😢");
            break;
          }
      }
    }
    public void RetornaCasas(List<Casa> listaCasas)
    {
      foreach (Casa item in listaCasas)
      {
        Console.WriteLine("\n-----------------------------------------");
        Console.WriteLine($"Casa: {listaCasas.IndexOf(item) + 1}");
        Console.WriteLine($"Arquiteto: {item.Arquiteto}");
        Console.WriteLine($"Dimensão: {item.Dimensao}m²");
        Console.WriteLine($"Possui jardim: {item.PossuiJardim}");
        Console.WriteLine($"Possui churrasqueira: {item.PossuiChurrasqueira}");
      }
      Console.WriteLine("-----------------------------------------\n");
    }
    public override void Construir()
    {
      Console.WriteLine("Construindo a casa...");
    }
  }
}