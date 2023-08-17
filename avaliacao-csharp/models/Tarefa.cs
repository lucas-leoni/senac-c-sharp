using System;
namespace Models
{
  public class Tarefa
  {
    public int Indice { get; set; }
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public string Data { get; set; }
    public string Hora { get; set; }
    public bool Concluida { get; set; }

    public Tarefa(string? nome, string? descricao)
    {
      this.Nome = nome;
      this.Descricao = descricao;
      this.Data = DateTime.Now.ToString("dd/MM/yyyy");
      this.Hora = DateTime.Now.ToString("HH:mm:ss");
      this.Concluida = false;

      Repositories.TarefaRepository.addTarefa(this);
    }

    public void getIndex(int index)
    {
      this.Indice = index;
    }

    public static List<Models.Tarefa> listarTarefas()
    {
      return Repositories.TarefaRepository.listarTarefas();
    }

    public static Tarefa? getTarefa(int index)
    {
      return Repositories.TarefaRepository.getTarefa(index);
    }

    public static void updateTarefa(
      int index,
      string? nome,
      string? descricao
    )
    {
      Tarefa? tarefa = Tarefa.getTarefa(index);
      if (tarefa != null)
      {
        tarefa.Nome = nome;
        tarefa.Descricao = descricao;

        Repositories.TarefaRepository.updateTarefa(index, tarefa);
      }
    }

    public static void alterarStatus(int index)
    {
      Tarefa? tarefa = Tarefa.getTarefa(index);
      if (tarefa != null)
      {
        tarefa.Concluida = !tarefa.Concluida;

        Repositories.TarefaRepository.alterarStatus(index, tarefa);
      }
    }

    public static void deletarTarefa(int index)
    {
      Tarefa? tarefa = Tarefa.getTarefa(index);
      if (tarefa != null)
      {
        Repositories.TarefaRepository.deletarTarefa(index);
      }
    }

    public override string ToString()
    {
      string concluidaString = Concluida ? "Sim" : "Não";
      return $"------------------------\n{Indice + 1}ª tarefa\nNome: {Nome}\nDescrição: {Descricao}\nData criação: {Data}\nHora criação: {Hora}\nConcluída: {concluidaString}\n------------------------\n";
    }
  }
}