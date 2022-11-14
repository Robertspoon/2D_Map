using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Map
{
    internal class Program
    {
        static char[,] map = new char[,] // dimensions defined by following data:
        {
            {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
            {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
            {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
            {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
            {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
            {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        };

        
        
        

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees
        static void Main(string[] args)
        {

            DisplayMap(2);





            Console.ReadKey(true);
        }

        static void DisplayMap()
        {
            Console.Write("<");
            for (int top = 0; top < map.GetLength(1); top++)
            {
                Console.Write("-");
            }
                Console.Write(">");
                Console.WriteLine();

            for (int y = 0; y<= 11; y++)
            {
                 Console.Write("|");
                for(int x = 0; x<= 29; x++)
                {
                    TileColour(y, x);
                    Console.Write(map[y,x]);
                }

                 Console.Write("|");
                Console.WriteLine();

            }
            Console.Write("<");
            for (int top = 0; top < map.GetLength(1); top++)
            {
                Console.Write("-");
            }
            Console.Write(">");
            Console.WriteLine();

        }

        static void DisplayMap(int scale)
        {
            Console.Write("<");
            for (int top = 0; top < map.GetLength(1); top++)
               for (int scaleBT = 0; scaleBT < scale; scaleBT++)
               {
                    Console.Write("-");
               }
               Console.Write(">");
               Console.WriteLine();


            for (int y = 0; y <= 11; y++)
            {
                for (int scaleY = 0; scaleY < scale; scaleY++)
                { 
                   
                   Console.Write("|");
                   for (int x = 0; x <= 29; x++)
                   {
                       for(int scaleX = 0; scaleX < scale; scaleX++)
                       {
                         Console.BackgroundColor = ConsoleColor.Black;
                         TileColour(y, x);
                         Console.Write(map[y, x]);
                            
                       }
                   }
                        Console.Write("|");
                    Console.WriteLine();
                }

            }
             Console.Write("<");
              for (int top = 0; top < map.GetLength(1); top++)
               for (int scaleBB = 0; scaleBB < scale; scaleBB++)
               {
                   Console.Write("-");
               }
                  Console.Write(">");
                  Console.WriteLine();
            Console.WriteLine("Map Legend");
            Console.WriteLine("^ = mountain");
            Console.WriteLine("` = grass");
            Console.WriteLine("~ = water");
            Console.WriteLine("* = trees");

        }
        static void TileColour(int y, int x)
        {
            switch(map[y,x])
            {

                case '`':
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;

                case '^':
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    break;

                case '~':
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;

                case '*':
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    break;
            }
        }
    }
}
