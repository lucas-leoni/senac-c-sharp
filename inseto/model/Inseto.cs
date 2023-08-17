using System;

namespace Inseto
{
  public class Inseto
  {
    public string? Nome { get; set; }
    public void Comer()
    {
      Console.WriteLine("O inseto está comendo...");
    }
  }
}