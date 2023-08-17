using System;

namespace Inseto
{
  public class Borboleta : Inseto
  {
    public int QtdCores { get; set; }
    public void Voar()
    {
      Console.WriteLine("A borboleta está voando...");
    }
    public override string ToString()
    {
      return $"Nome: {Nome}\nQuantidade de cores: {QtdCores}";
    }
  }
}