using System;

namespace Programa
{
  public class Pessoa : Usuario
  {
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Endereco { get; set; }
    public bool Vivo { get; set; }
    public void Apresentar()
    {
      Console.WriteLine($"Olá meu nome é {Nome}. Eu tenho {Idade} anos. Moro em {Endereco}.");
    }
    public void Despedida()
    {
      Console.WriteLine("Goodbye!");
    }

    public override void Logar()
    {
      Console.WriteLine("Batata");
    }

    public override string ToString()
    {
      return $"Nome: {Nome}\nIdade: {Idade}\nEndereço: {Endereco}\n" +
      $"Login: {Login}\nEmail: {Email}\nSenha: {Senha}";
    }
  }
}