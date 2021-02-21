using System;
using System.Collections.Generic;
using System.Text;

namespace gra
{
    class szachy
    {
        char[,] pozycja = new char[9, 9] {
                { ' ', '1', '2', '3','4','5','6','7','8'},
                { 'A','W', 'P', ' ',' ',' ',' ','P','W'},
                { 'B','S', 'P', ' ',' ',' ',' ','P','S',},
                { 'C','L', 'P', ' ',' ',' ',' ','P','L',},
                { 'D','D', 'P', ' ',' ',' ',' ','P','D',},
                { 'E','K', 'P', ' ',' ',' ',' ','P','K',},
                { 'F','L', 'P', ' ',' ',' ',' ','P','L',},
                { 'G','S', 'P', ' ',' ',' ',' ','P','S',},
                { 'H','W', 'P', ' ',' ',' ',' ','P','W'
                } };
        public int szachownica ( int pozycjax, int pozycjay)
        {
           
            char[,] szachownica = new char[9, 9] {
                { ' ', '1', '2', '3','4','5','6','7','8'},
                { 'A',' ', ' ', ' ',' ',' ',' ',' ',' '},
                { 'B',' ', ' ', ' ',' ',' ',' ',' ',' ',},
                { 'C',' ', ' ', ' ',' ',' ',' ',' ',' ',},
                { 'D',' ', ' ', ' ',' ',' ',' ',' ',' ',},
                { 'E',' ', ' ', ' ',' ',' ',' ',' ',' ',},
                { 'F',' ', ' ', ' ',' ',' ',' ',' ',' ',},
                { 'G',' ', ' ', ' ',' ',' ',' ',' ',' ',},
                { 'H',' ', ' ', ' ',' ',' ',' ',' ',' '
                } };
            int[] tablica = new int[] { 1, 3, 5, 7, 9 ,10, 11, 12};
            char[] pola = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            int next = 0;
            int next2 = 10;
            for (int k = 0; k < 9; k++)
            {
                for (int i = 0; i < 9; i++)
                {
                    next = next+3;
                    
                    Console.SetCursorPosition(next, next2);
                  /*  if (i % 2 == 0 && k % 2 != 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                            }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }*/
                    Console.Write("{0}", szachownica[i, k]);
                    //   Console.ReadKey();
                    
                }
                next2 = next2 + 2;
                next = 0;
            }
       /*     for (int i = 0; i < 8; i++)
                Console.Write(" |{0}{1} ", pola[i],tablica[i]);
            for (int i = 0; i < 8; i++)
                Console.Write(" |{0} ", pola[i]);
       */
            return 0;
        }

        public int pozycja_f(int x, int y)
        {

            Console.BackgroundColor = ConsoleColor.White;
            int next = 0;
            int next2 = 10;
            for (int k = 0; k < 9; k++)
            {
                for (int i = 0; i < 9; i++)
                {
                    next = next + 3;

                    
                    /*  if (i % 2 == 0 && k % 2 != 0)
                      {
                          Console.BackgroundColor = ConsoleColor.Black;
                              }
                      else
                      {
                          Console.BackgroundColor = ConsoleColor.White;
                      }*/
                    Console.Write("{0}", pozycja[i, k]);
                    //   Console.ReadKey();

                }
                next2 = next2 + 2;
                next = 0;
            }
            return 0;
        }
        public int gra()
        {
            Console.WriteLine("Ruch:");

            return 0;
        }
    }
}
