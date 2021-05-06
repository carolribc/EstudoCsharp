using System;
using System.IO;

namespace app4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string currentDirectory = Directory.GetCurrentDirectory();

            var app = new MyApp(currentDirectory);
            
            app.CarregarLista();
            app.ImprimirLista();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Digite o primeiro nome da pessoa para busca: ");
            string primeiroNome = Console.ReadLine();

            Pessoa pessoinha = app.BuscarPessoa(primeiroNome);
            
            if (pessoinha != null) {
                Console.WriteLine("Pessoa encontrada!");

                string resposta1 = "";

                do{
                    Console.WriteLine();
                    Console.Write("Deseja mudar o nome? (S/N)");
                    resposta1 = Console.ReadLine();
                    if (resposta1 == "S") {
                        do {
                            Console.WriteLine();
                            Console.WriteLine("Digite o nome: ");
                            pessoinha.NomeCompleto = Console.ReadLine();
                        } while (String.IsNullOrWhiteSpace(pessoinha.NomeCompleto));
                    }
                } while (resposta1 != "S" && resposta1 != "N");

                
                do{
                    Console.WriteLine();
                    Console.Write("Deseja editar a data de nascimento? (S/N)");
                    resposta1 = Console.ReadLine();
                    if (resposta1 == "S") {
                        do {
                            Console.WriteLine();
                            Console.WriteLine("Digite a data de nascimento: (dd/MM/yyyy) ");
                            pessoinha.DataNascimento = Console.ReadLine();
                        } while (String.IsNullOrWhiteSpace(pessoinha.DataNascimento));
                    }
                } while (resposta1 != "S" && resposta1 != "N");    

                do{
                    Console.WriteLine();
                    Console.Write("Deseja editar o email? (S/N)");
                    resposta1 = Console.ReadLine();
                    if (resposta1 == "S") {
                        do {
                            Console.WriteLine();
                            Console.WriteLine("Digite o email: ");
                            pessoinha.Email = Console.ReadLine();
                        } while (String.IsNullOrWhiteSpace(pessoinha.Email));
                    }
                } while (resposta1 != "S" && resposta1 != "N");    

                do{
                    Console.WriteLine();
                    Console.Write("Deseja mudar o telefone (S/N)");
                    resposta1 = Console.ReadLine();
                    if (resposta1 == "S") {
                        do {
                            Console.WriteLine();
                            Console.WriteLine("Digite o telefone: ");
                            pessoinha.Telefone = Console.ReadLine();
                        } while (String.IsNullOrWhiteSpace(pessoinha.Telefone));
                    }
                } while (resposta1 != "S" && resposta1 != "N");   

                /*Envelhecer
                Console.Write("Deseja envelhecer essa pessoa em um ano? (S/N) ");
                string resposta2 = Console.ReadLine();
                if (resposta2 == "S"){
                    var data = DateTime.Parse(pessoinha.DataNascimento);
                    data = data.AddYears(-1);
                    pessoinha.DataNascimento = data.ToString("dd/MM/yyyy");

                }*/
            
            app.SalvarLista();
            app.ImprimirLista();
            }
        }
    }
}

