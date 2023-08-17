using System;

namespace Controllers
{
    public class PessoaController
    {
        public static void AddPessoa(
            string nome,
            string endereco,
            int idade,
            bool vivo
        ){
            new Models.Pessoa(
                nome,
                endereco,
                idade,
                vivo
            );
        }
    }
}