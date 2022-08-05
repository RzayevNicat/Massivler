using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cokboyutludiziler2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matrislerin toplanmasi: ");
            int[,] matris1 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8} };
            int[,] matris2 = { { 17, 18, 19, 20 }, { 21, 22, 23, 24} };
            int[,] toplam = new int[2, 4];
            for (int i = 0; i < 2; i++)
            {
               
                for (int j = 0; j < 4; j++)
                {
                    toplam[i, j] = matris1[i, j] + matris2[i, j];
                    
                }
            }
            for (int g = 0; g < 2; g++)
            {
                Console.WriteLine();
                for (int l = 0; l < 4; l++)
                {
                    Console.Write(toplam[g,l] + " ");
                }
            }
          
            Console.Read();
        }
    }
}
