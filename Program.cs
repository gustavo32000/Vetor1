using System;

namespace Vetor1
{
    class Program
    {
        static void Main(string[] args)
        {
         String [] cidades = {"Cuiabá", "São Paulo", "Rio de Janeiro", "Santos"};
         string cid = "Curitiba, Florianópolis, Fortaleza";
         Console.WriteLine(cidades[1]);     
         Console.WriteLine(cid.Substring(0,8));
        }
    }
}
