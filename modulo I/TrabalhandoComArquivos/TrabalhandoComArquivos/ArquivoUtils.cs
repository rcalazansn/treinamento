using System;
using System.IO;

namespace TrabalhandoComArquivos
{
    public class ArquivoUtils 
    {
        public void DiretorioExiste()
        {
            if (Directory.Exists(@"C:\Temp\NovaPasta"))
            {
                Console.WriteLine("diretorio existe");
            }
            else
            {
                Console.WriteLine("diretorio não existe");
            }
        }

        public void ArquivoExiste()
        {
            bool existe = File.Exists("C:\\Temp\\arquivo.txt");

            if (existe)
            {
                Console.WriteLine("arquivo existe");
            }
            else
            {
                Console.WriteLine("arquivo não existe");
            }
        }

        public void InformacoesArquivo()
        {
            FileInfo info = new FileInfo("C:\\Temp\\arquivo.txt");

            Console.WriteLine(info.FullName);
            Console.WriteLine(info.Extension);
            Console.WriteLine(info.Name);
            Console.WriteLine(info.Length);
            Console.WriteLine(info.CreationTime);
            Console.WriteLine(info.LastWriteTime);
            Console.WriteLine(info.DirectoryName);
        }

        public void CriarDiretorio()
        {
            Directory.CreateDirectory($@"C:\Temp\{Guid.NewGuid()}");
        }

        public void CriarEscreverArquivo()
        {
            string path = Path.Combine(@"C:\Temp", $"{Guid.NewGuid()}.txt");

            // using (StreamWriter sw = new StreamWriter(path))
            //{

            StreamWriter sw = new StreamWriter(path);

            sw.WriteLine($"Data:{DateTime.Now}");
            sw.Write("Rodrigo ");
            sw.Write("Calazans");

            sw.Dispose();
            //}
        }

        public void LerArquivo()
        {
            string path = Path.Combine(@"C:\Temp", "bb26cb6f-6ba0-4b57-bc49-c67416c2b8c4.txt");

            using (StreamReader sr = new StreamReader(path))
            {
                string linha = sr.ReadToEnd();
                Console.WriteLine(linha);
            }
        }


    }
}
