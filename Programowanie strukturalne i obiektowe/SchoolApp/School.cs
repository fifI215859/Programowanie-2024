﻿using SchoolApp.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    class School
    {
        private SchoolDatabase schoolDatabase = new SchoolDatabase();

        public void Run()
        {
            while(true)
            {
                ShowMenu();

                Console.WriteLine("Wybierz:");
                if (!int.TryParse(Console.ReadLine(), out int option))
                    continue;
                
                switch(option)
                {
                    case 1:
                        //uzupełnić metodę
                        break;
                    case 2:
                        //uzupełnić metodę
                        break;
                    case 3:
                        //usupełnić metodę
                        break;
                    case 4:
                        //uzupełnić metodę
                        break;

                    case 0:
                        return;
                }
            }
        }

        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Lista dostepnych opcji:");
            //CRUD
            Console.WriteLine("1. Dodanie nowej klasy."); //C - create
            Console.WriteLine("2. Usunięcie klasy.");   //D - delete
            Console.WriteLine("3. Modyfikacja klasy."); //U - update
            Console.WriteLine("4. Wyświetlenie wszystkich klas."); //R - read


            Console.WriteLine("0. Koniec programu.");
        }



    }
}
