using System;

namespace List
{
  /*
    Abaixo a criação da classe "Vaga", para poder criar objetos de 
    vagas e adicionar em uma lista.
  */
  public class Vaga
  {
    //Criando uma nova lista vazia do tipo "Vaga"(Objeto).
    public List<Vaga> listaVagas = new List<Vaga>();
    public string? Titulo { get; set; }
    public double Salario { get; set; }
    public void RetornaVagas() // Retorna os elementos da lista.
    {
      foreach (Vaga item in listaVagas)
      {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine($"Vaga: {listaVagas.IndexOf(item) + 1}");
        Console.WriteLine($"Título: {item.Titulo}");
        Console.WriteLine($"Salário: R$ {item.Salario}");
      }
      Console.WriteLine("-----------------------------------------");
    }
  }
}