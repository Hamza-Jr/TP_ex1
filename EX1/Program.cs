using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    class Program
    {
        public static bool isPremierNomber(int n)
        {
            bool isTrue = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }

        public void Main(string[] args)
        {

            Console.WriteLine("Donnez un nombre:");
            String n = Console.ReadLine();

            if (isPremierNomber(Convert.ToInt32(n)))
            {
                Console.WriteLine("Le nombre " + n + " est premier");
            }
            else
            {
                Console.WriteLine("Le nombre " + n + " n'est pas premier");
            }

        }
    }
}
