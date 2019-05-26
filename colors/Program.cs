using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colors
{
    class Program
    {

        

        public int Red;
        public int Blue;
        public int White;
        

        public static string Examine(string[] matrix, int posIdx)
        {
            return matrix[posIdx];
        }

        public static void Swap(ref string[] matrix, int posA, int posB) 
        {
            string temp = matrix[posA];
            matrix[posA] = matrix[posB];
            matrix[posB] = temp;
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            string[] matrix = new string[] { "R", "W", "B", "B", "R","W", "W", "B", "B", "W", "R" };
            p.Red = 0;
            p.Blue = 0;
            p.White = matrix.Length - 1;

           
            while (p.Blue <= p.White)
            {
                if (Examine(matrix, p.Blue) == "R") Swap(ref matrix, p.Red++, p.Blue++);
                else if (Examine(matrix, p.Blue) == "W") Swap(ref matrix, p.Blue, p.White--);
                else if (Examine(matrix, p.Blue) == "B") p.Blue++;

            }

            foreach (var item in matrix)
            {
                Console.Write(item);
            }
            Console.ReadLine();
        }
    }
}