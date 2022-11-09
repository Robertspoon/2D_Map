﻿using System;
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
            for (int y = 0; y<= 11; y++)
            {
                 Console.Write("|");
                for(int x = 0; x<= 29; x++)
                {
                    Console.Write(map[y,x]);
                }
                 Console.Write("|");
                Console.WriteLine();

            }

        }

        static void DisplayMap(int scale)
        {
            for (int y = 0; y <= 11; y++)
            {
                for(int scaleY = 0; scaleY < scale; scaleY++)
                { 
                   
                   Console.Write("|");
                   for (int x = 0; x <= 29; x++)
                   {
                       for(int scaleX = 0; scaleX < scale; scaleX++)
                       {
                         Console.Write(map[y, x]);
                         TileColour(y, x);
                            
                       }
                   }
                        Console.Write("|");
                    Console.WriteLine();
                }      
            } 
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
