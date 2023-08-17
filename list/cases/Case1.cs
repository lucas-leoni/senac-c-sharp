using System;

namespace List
{
  public class Case1
  {
    public static void Run()
    {
      Console.WriteLine("\nExemplo 1\n");

      // Criando vagas para adicionar a lista.
      Vaga vaga = new Vaga(); // Instanciando a vaga.
      vaga.Titulo = "Desenvolvedor Backend Jr"; // Add valor ao atributo titulo.
      vaga.Salario = 2000.00; // Add valor ao atributo salario.

      Vaga vaga2 = new Vaga();
      vaga2.Titulo = "Desenvolvedor Frontend Jr";
      vaga2.Salario = 1900.00;

      Vaga vaga3 = new Vaga();
      vaga3.Titulo = "Desenvolvedor Fullstack Jr";
      vaga3.Salario = 2250.00;

      // Adicionando as vagas à lista.
      Vaga lista = new Vaga();
      lista.listaVagas.Add(vaga);
      lista.listaVagas.Add(vaga2);
      lista.listaVagas.Add(vaga3);
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("\nAdicionando...\n");

      // Retornando os elementos da lista.
      lista.RetornaVagas();

      // Atualizando elementos da lista através do seu índice.
      lista.listaVagas[lista.listaVagas.IndexOf(vaga2)].Salario = 2000.00;
      lista.listaVagas[lista.listaVagas.IndexOf(vaga3)].Titulo = "Desenvolvedor Fullstack Pleno";
      lista.listaVagas[lista.listaVagas.IndexOf(vaga3)].Salario = 4000.00;
      Console.WriteLine("\nAtualizando...\n");

      // Retornando novamente os elementos da lista, para visualizar as alterações.
      lista.RetornaVagas();

      // Excluindo elemento da lista através do índice.
      lista.listaVagas.RemoveAt(0);

      // Excluindo elemento da lista através do nome do objeto.
      lista.listaVagas.Remove(vaga3);
      Console.WriteLine("\nExcluindo...\n");

      // Retornando novamente os elementos da lista, para visualizar as exclusões.
      lista.RetornaVagas();

      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
