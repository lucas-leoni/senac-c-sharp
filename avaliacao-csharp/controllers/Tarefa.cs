using System;
using System.Collections.Generic;

namespace Controllers
{
  public class TarefaController
  {
    public static void addTarefa(string? nome, string? descricao)
    {
      new Models.Tarefa(nome, descricao);
      Console.WriteLine("\nTarefa adicionada com sucesso!\n");
    }

    public static List<Models.Tarefa> listarTarefas()
    {
      return Models.Tarefa.listarTarefas();
    }

    public static void updateTarefa(
      int index,
      string? nome,
      string? descricao
    )
    {
      Models.Tarefa.updateTarefa(
        index,
        nome,
        descricao
      );
      Console.WriteLine("\nTarefa alterada com sucesso!\n");
    }

    public static void alterarStatus(int index)
    {
      Models.Tarefa.alterarStatus(index);
      Console.WriteLine("\nStatus da tarefa alterado!\n");
    }

    public static void deletarTarefa(int index)
    {
      Models.Tarefa.deletarTarefa(index);
      Console.WriteLine("\nTarefa deletada com sucesso!\n");
    }
  }
}