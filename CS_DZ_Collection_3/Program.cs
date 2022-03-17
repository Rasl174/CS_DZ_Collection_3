using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Collection_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool canExit = false;
            

            Console.WriteLine("Для сложения введите sum. Для выхода введите exit.");

            while (!canExit)
            {
                Console.Write("Введите числa которые нужно сложить , sum или exit: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "sum":
                        Sum(numbers);
                        break;

                    case "exit":
                        canExit = true;
                        break;
                }

                if (int.TryParse(userInput, out int result))
                {
                    numbers.Add(result);
                }
            }
        }

        static public List<int> Sum(List<int> numbers)
        {
            int numbersSum = 0;

            foreach (var item in numbers)
            {
                numbersSum += item;
            }

            Console.Clear();
            Console.WriteLine("Сумма: " + numbersSum);
            return numbers;
        }
    }
}
