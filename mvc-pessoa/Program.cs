using System;

namespace Programa
{
    public class Program 
    {
        static void Main(string[] args)
        {
            int op = 0;

            do{
                Console.WriteLine("Infome a opção desejada");
                Console.WriteLine("1- Adicionar");
                Console.WriteLine("2- Listar");
                Console.WriteLine("5- Sair");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1: {
                        Views.PessoaView.AddPessoa();
                        break;
                    }
                    case 2: {
                        break;
                    }
                    case 5: {
                        Console.WriteLine("Saindo");
                        break;
                    }
                    default: {
                        Console.WriteLine("Op Inválida");
                        break;
                    }
                }

            }while(op !=5);
        }
    }
}