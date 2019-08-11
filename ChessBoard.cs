using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            char place = 'X';
   
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(place);
                    place = (place == 'X') ? 'O' : 'X';
                }
                Console.WriteLine();
                place = (place == 'X') ? 'O' : 'X';

            }
        }
    }
}
