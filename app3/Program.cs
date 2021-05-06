using System;
using System.IO;

namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string currentDirectory = Directory.GetCurrentDirectory();
            // O método GetCurrentDirectory() é utilizado para buscar o caminho da pasta atual 
            //na qual sua aplicação de trabalho está armazenada.
            
            var app = new MyApp(currentDirectory);

            app.CarregarLista();
            app.ImprimirLista();

            Pessoa ricardo = app.BuscarPessoa("Aline");
            DateTime DataNascimento = DateTime.Parse(ricardo.DataNascimento);
            DataNascimento = DataNascimento.AddYears(-1);
            ricardo.DataNascimento = DataNascimento.ToString("dd/mm/yyyy");

            app.SalvarLista();
            app.ImprimirLista();
        }
    }
}
