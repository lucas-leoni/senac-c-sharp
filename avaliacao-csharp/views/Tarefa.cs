using System;
using System.Collections.Generic;

namespace Views
{
  public class TarefaView
  {
    public static void addTarefa()
    {
      string? nome, descricao;

      Console.Write("Digite o nome da tarefa: ");
      nome = Console.ReadLine();

      Console.Write("Digite a descrição da tarefa: ");
      descricao = Console.ReadLine();

      Controllers.TarefaController.addTarefa(
        nome,
        descricao
      );

      Console.WriteLine("-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }

    public static void listarTarefas()
    {
      List<Models.Tarefa> tarefas = Controllers.TarefaController.listarTarefas();

      Console.WriteLine("Lista de tarefas:\n");
      foreach (var tarefa in tarefas)
      {
        Console.WriteLine(tarefa.ToString());
      }

      Console.WriteLine("-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }

    public static void updateTarefa()
    {
      int index;
      string? nome, descricao;

      Console.Write("Digite o número da tarefa que você deseja atualizar: ");
      index = Convert.ToInt32(Console.ReadLine());

      Console.Write("Digite o nome da tarefa: ");
      nome = Console.ReadLine();

      Console.Write("Digite a descrição da tarefa: ");
      descricao = Console.ReadLine();

      Controllers.TarefaController.updateTarefa(
        index - 1,
        nome,
        descricao
      );

      Console.WriteLine("-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }

    public static void alterarStatus()
    {
      int index;

      Console.Write("Digite o número da tarefa que você deseja alterar o status: ");
      index = Convert.ToInt32(Console.ReadLine());

      Controllers.TarefaController.alterarStatus(index - 1);

      Console.WriteLine("-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }

    public static void deletarTarefa()
    {
      int index;

      Console.Write("Digite o número da tarefa que você deseja deletar: ");
      index = Convert.ToInt32(Console.ReadLine());

      Controllers.TarefaController.deletarTarefa(index - 1);

      Console.WriteLine("-----------------------------------------");
      Console.Write("Aperte qualquer tecla para continuar... ");
      Console.ReadKey();
      Console.Clear();
    }
  }
}