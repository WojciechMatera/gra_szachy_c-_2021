using System;
using System.Collections.Generic;
using System.Linq;

namespace gra
{
    class baza
    {

      
        public void dodaj_ruch()
        {
          
                // tworzymy listę obiektów typu Car
                List<ruch> list = new List<ruch>();
                ruch ru = new ruch();
                int i = 0;
                /*   Car car1 = new Car();
                   car1.Id = 1;
                   car1.Brand = "Audi";
                   car1.Model = "RS6";
                   Car car2 = new Car();
                   car2.Id = 2;
                   car2.Brand = "BMW";
                   car2.Model = "M3";
                   Car car3 = new Car();
                   car3.Id = 3;
                   car3.Brand = "Pagani";
                   car3.Model = "Zonda";
                   Car car4 = new Car();
                   car4.Id = 4;
                   car4.Brand = "Nissan";
                   car4.Model = "GTR";
                   // wszystkie obiekty dodajemy do listy*/
                ru.Id = i + 1;
                Console.WriteLine("Dodaj ruch:");
                ru.pozycja = Console.ReadLine();
                list.Add(ru);
                /* list.Add(car1);
                 list.Add(car2);
                 list.Add(car3);
                 list.Add(car4);*/
                // A dla przypomnienia inny sposób dodawania danych do listy
                //    list.Add(new Car { Id = 5, Brand = "Pontiac", Model = "GTO" });
                // używamy LINQ aby zwrócić uporządkowane dane z powyższej listy
                // sortowanie odbywa się po marce

                String nazwa = "";
                Console.WriteLine("Historia:");
                nazwa = Console.ReadLine();

                var sortedList = from l in list
                                 where l.pozycja == nazwa
                                 select l;
                // wypisanie w konsoli wszystkich elementów
                foreach (var item in sortedList)
                {
                    Console.WriteLine(item.Id + " " + item.pozycja);
                }
                Console.ReadKey();
            }
        
        class ruch
        {
            public int Id { get; set; }
            public string pozycja { get; set; }
        }
    }
}

