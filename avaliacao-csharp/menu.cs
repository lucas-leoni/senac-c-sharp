using System;

namespace Programa
{
  public class Menu
  {
    public static void Run()
    {
      int option = 0;

      do
      {
        Console.WriteLine("\nDigite uma opção:\n");
        Console.WriteLine("1- Adicionar tarefa");
        Console.WriteLine("2- Listar tarefas");
        Console.WriteLine("3- Alterar tarefa");
        Console.WriteLine("4- Alterar status da tarefa");
        Console.WriteLine("5- Deletar tarefa");
        Console.WriteLine("6- Sair\n");
        option = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        switch (option)
        {
          case 1:
            {
              Views.TarefaView.addTarefa();
              break;
            }
          case 2:
            {
              Views.TarefaView.listarTarefas();
              break;
            }
          case 3:
            {
              Views.TarefaView.updateTarefa();
              break;
            }
          case 4:
            {
              Views.TarefaView.alterarStatus();
              break;
            }
          case 5:
            {
              Views.TarefaView.deletarTarefa();
              break;
            }
          case 6:
            {
              Console.WriteLine("Saindo...");
              break;
            }
          default:
            {
              Console.WriteLine("Opção Inválida");
              break;
            }
        }

      } while (option != 6);
    }
  }
}