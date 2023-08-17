using System;

namespace Inseto
{
  public class Formiga : Inseto
  {
    public double Tamanho { get; set; }
    public void CarregarFolha()
    {
      Console.WriteLine("A formiga está carregando uma folha...");
    }
    public override string ToString()
    {
      return $"Nome: {Nome}\nTamanho: {Tamanho}";
    }
  }
}