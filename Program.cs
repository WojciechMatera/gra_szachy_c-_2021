using System;
namespace gra
{
    class Program
    {
        static void Main(string[] args)
        {

            szachy sz = new szachy();

            // wyświetlanie szachownicy

            int count = 0;
            int[] tablica = new int[] { 1, 3, 5, 7, 9 };
            String nazwa = "";
            Console.WriteLine("Witam w naszek pierwszej grze:");
            // nazwa = Console.ReadLine();
            nazwa = "zaczynamy";
            if ( nazwa == "zaczynamy")
            {
                Console.WriteLine("gra szachy ");

                foreach (int element in tablica  )
                {
                 //   Console.WriteLine($"Element #{count}: {element}");
                }
                sz.szachownica(0, 0);
                sz.pozycja_f(0, 0);
                sz.gra();
                baza bz = new baza();
                bz.dodaj_ruch();
                Console.ReadKey();
            }



        }
    }
}
