using System;

namespace Views
{
    public class PessoaView
    {
        public static void AddPessoa(){
            string nome, endereco;
            int idade;
            bool vivo = true;

            Console.WriteLine("Informe o nome: ");
            nome = Console.ReadLine();
            
            Console.WriteLine("Informe o Endereço: ");
            endereco = Console.ReadLine();
            
            Console.WriteLine("Informe a idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            
            Controllers.PessoaController.AddPessoa(
                nome, endereco, idade, vivo
            );
        }
    }
}