using System;
using System.Linq;
// LINQ é um conjunto de métodos e operadores da linguagem C# cujo objetivo é permitir a realização de consultas a 
//coleções de objetos. Por meio desse recurso é possível efetuar tarefas comuns como localizar um objeto, somar e 
//contar dados, ordenar listas, etc.

namespace app4
{
    public class MyApp
    {
        private Pessoa[] _pessoas;
        private PessoaRepository _repository;

        public MyApp(string directory) {
            _repository = new PessoaRepository(directory);
        }

        public void CarregarLista() {
            Console.WriteLine();
            Console.WriteLine("## Carregar Lista ##");
            _pessoas = _repository.Read();
        }

        public void SalvarLista() {
            Console.WriteLine();
            Console.WriteLine("## Salvar Lista ##");
            _repository.Save(_pessoas);
        }

        public void ImprimirLista() {
            Console.WriteLine();
            Console.WriteLine("## Lista de Pessoas ##");
            foreach (var pessoa in _pessoas)
            {
                Console.WriteLine("Nome: {0}; DataNascimento: {1}; Email: {2}; Telefone: {3}", 
                pessoa.NomeCompleto, 
                pessoa.DataNascimento, 
                pessoa.Email, 
                pessoa.Telefone);

            }
        }

        public Pessoa BuscarPessoa (string nome)
        {
            Console.WriteLine();
            Console.WriteLine("## BuscarPessoa ##");
            var naoencontrado = false;

            foreach (var pessoa in _pessoas) 
            {
                if (pessoa.NomeCompleto.StartsWith(nome)){
                    return pessoa;
                } else {
                    naoencontrado = true;
                }    
            }
            
            if (naoencontrado == true){
                Console.Write("Pessoa não encontrada! ");
                }
        
            return null;
        }

    }
}