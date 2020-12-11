using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourHanoi
{
    class Input
    {
        public int GetPosition()
        {            
            while (true)
            {
                ConsoleKeyInfo keyInput = Console.ReadKey(true);
                
                switch(keyInput.Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        Console.Write("1");
                        return 0;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        Console.Write("2");
                        return 1;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        Console.Write("3");
                        return 2;
                    case ConsoleKey.Q:
                        Console.Write("q");
                        return -1;
                }
            }
        }

        public int GetDiscCount()
        {
            int number = 0;

            while (true)
            {
                try
                {
                    Console.Write("Combien de disques (2...5): ");
                    number = Convert.ToInt32(Console.ReadLine());

                    if (number < 2 || number > 5)
                    {
                        throw new Exception();
                    }

                    return number;
                }
                catch
                {
                    Console.WriteLine("Nombre non valide.");
                }
            }
        }
    }
}
