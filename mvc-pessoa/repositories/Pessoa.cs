using System;

namespace Repositories
{
    public class PessoaRepository
    {
        static List<Models.Pessoa> pessoas = new List<Models.Pessoa>();

        public static void addPessoa(Models.Pessoa pessoa){
            pessoas.Add(pessoa);
        }
        
    }
}