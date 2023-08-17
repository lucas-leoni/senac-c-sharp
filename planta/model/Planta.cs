using System;

namespace Planta
{
  class Planta
  {
    public string? Arquiteto { get; set; }
    public double Dimensao { get; set; }
    public virtual void Construir()
    {
      Console.WriteLine("Iniciando a construção do projeto...");
    }
  }
}