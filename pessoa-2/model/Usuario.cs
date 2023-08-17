using System;

namespace Programa
{
  public class Usuario
  {
    public string? Login { get; set; }
    public string? Email { get; set; }
    public string? Senha { get; set; }
    public virtual void Logar()
    {
      Console.WriteLine("Acessando o sistema...");
    }
  }
}