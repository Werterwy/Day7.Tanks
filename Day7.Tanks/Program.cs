using MyClassLib.WordOfTanks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7.Tanks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tank[] T34 = new Tank[5];
            Tank[] Pantera= new Tank[5];    
            for(int j=0; j<T34.Length; j++)
            {
                Tank t34 = new Tank("T34-"+ string.Format("{0}", j+1));
                Tank pantera = new Tank("Pantera-" + string.Format("{0}", j + 1));
                T34[j] = t34;
                Pantera[j] = pantera;
            }
            Console.WriteLine("В танковом бою участвуют 5 танков «Т-34» и 5 танков «Pantera».\n  " +
                "Каждый танк участвует в парной битве, т.е. первый танк «Т-34» \nсражается с первым танком «Pantera» и т. д. " +
                "Победа присуждается тому танку,\n который превышает противника по двум и более параметрам из трех");
            Console.WriteLine("");
            Console.WriteLine("Сражение танков:");
            for (int i = 0; i < T34.Length; i++)
            {
                Tank winner = T34[i] * Pantera[i];

                if (winner != null)
                {
                    Console.WriteLine($"{winner.NameTank} победил в битве!");
                }
                else
                {
                    Console.WriteLine("Ничья в битве.");
                }
            }

        }
    }
}
