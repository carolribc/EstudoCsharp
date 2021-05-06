using System;

namespace app2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("## app 02##");

            //Pasta local do projeto
            string caminhoDaPastaLocal = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine();
            Console.WriteLine("caminhoDaPastaLocal: {0}", caminhoDaPastaLocal);

            //Combino o caminho da pasta local 
            string caminhoDoArquivo = System.IO.Path.Combine(caminhoDaPastaLocal, $"pessoas.txt");
            Console.WriteLine();
            Console.WriteLine("caminhoDoArquivo: {0}", caminhoDoArquivo);

            string conteudoDoArquivo = System.IO.File.ReadAllText(caminhoDoArquivo);
            Console.WriteLine();
            Console.WriteLine("conteudoDoArquivo: {0}", conteudoDoArquivo);


            string[] nomes = conteudoDoArquivo.Split(';');

            Console.WriteLine();
            Console.WriteLine("Array de Tamanho: {0}", nomes.Length);

            Console.WriteLine();
            Console.WriteLine("foreach");
            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            
            Console.WriteLine();
            Console.WriteLine("for");
            for (int i = 0; i < nomes.Length; i++) 
            {
                string nome = nomes[i];
                Console.WriteLine(nomes[i]);
            }

                 
            Console.WriteLine();
            Console.WriteLine("while");
            int index = 0;
            while (index < nomes.Length) 
            {
                string nome = nomes[index];
                Console.WriteLine(nome);
                index++;
            }

        }
    }
}
