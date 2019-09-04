using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[ , , ] threeDimensions = new int[10, 10, 10];
            List<int> List01 = new List<int>();
            Dictionary<string,string> geography = new Dictionary<string,string>();
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        threeDimensions[i, j, k] = (i+1)*(j+1)*(k+1);
                        List01.Add(threeDimensions[i, j, k]);
                        //Console.Write(threeDimensions[i, j, k] + " ");
                    }
                    //Console.WriteLine();
                }
                //Console.WriteLine();
            }
            Console.WriteLine(threeDimensions[2,3,7]);
            Console.WriteLine();
            Console.WriteLine(threeDimensions[1,2,6]);
            Console.WriteLine();
            foreach (int element in List01)
            {
                Console.Write(element + " ");
                sum = sum + element;
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine();

            geography.Add("Russia", "Moscow");
            geography.Add("Romania", "Bucharest");
            geography.Add("Hungary", "Budapest");
            geography.Add("Poland", "Warsaw");
            geography.Add("Greece", "Athens");
            geography.Add("Bulgaria", "Sofia");
            geography.Add("Italy", "Rome");
            geography.Add("Spain", "Madrid");
            geography.Add("Serbia", "Belgrad");
            geography.Add("finland", "Helsinki");
            foreach (KeyValuePair<string,string> countryAndCapital in geography)
            {
                Console.WriteLine(countryAndCapital + " ");
            }

            Queue<int> numbers = new Queue<int>();
            for(int i = 1; i<= 100; i++)
            {
                numbers.Enqueue((int)Math.Pow(i, 3));
            }
            for (int i = 1; i <= 10; i++)
            {
                numbers.Dequeue();
            }
            Console.WriteLine();
            Console.WriteLine("Queue Sum: " + numbers.Sum());

            Stack<int> numbers2 = new Stack<int>();
            for (int i = 1; i <= 100; i++)
            {
                numbers2.Push((int)Math.Pow(i, 3));
            }
            for (int i = 100; i <= 91; i--)
            {
                numbers2.Pop();
            }
            Console.WriteLine();
            Console.WriteLine("Stack Sum: " + numbers2.Sum());
            Console.Read();
        }
    }
}
