using System;
using System.Collections.Generic;

namespace Repositories
{
  public class TarefaRepository
  {
    static List<Models.Tarefa> tarefas = new List<Models.Tarefa>();

    public static void addTarefa(Models.Tarefa tarefa)
    {
      tarefas.Add(tarefa);
      int index = tarefas.IndexOf(tarefa);
      tarefa.getIndex(index);
    }

    public static List<Models.Tarefa> listarTarefas()
    {
      return tarefas;
    }

    public static Models.Tarefa? getTarefa(int index)
    {
      if (index < 0 || index >= tarefas.Count)
      {
        return null;
      }
      else
      {
        return tarefas[index];
      }
    }

    public static void updateTarefa(int index, Models.Tarefa tarefa)
    {
      tarefas[index] = tarefa;
    }

    public static void alterarStatus(int index, Models.Tarefa tarefa)
    {
      tarefas[index] = tarefa;
    }

    public static void deletarTarefa(int index)
    {
      tarefas.RemoveAt(index);
    }
  }
}