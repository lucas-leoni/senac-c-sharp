using System;

namespace Models
{
    public class Pessoa : Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Endereco { get; set; }
        public bool Vivo { get; set; }

        public Pessoa(
            string nome,
            string endereco,
            int idade,
            bool vivo
        ){
            this.Nome = nome;
            this.Endereco = endereco;
            this.Idade = idade;
            this.Vivo = vivo;

            Repositories.PessoaRepository.addPessoa(this);
        }

        public void Apresentar() {
            Console.WriteLine($"Olá, meu nome é {Nome}. E tenho {Idade} anos. Moro em {Endereco}");
        }
        public void Despedida(){
            Console.WriteLine("Txau");
        }

        public override string ToString(){
            return $"----\n Nome: {Nome}\nIdade: {Idade}\nEndereço: {Endereco}\n Login: {Login}\n Email: {Email}\n Senha: {Senha}";
        }
        
    }
}