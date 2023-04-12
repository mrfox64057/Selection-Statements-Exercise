using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 10000000);
            Console.WriteLine("Bet you can't guess my favorite number :p");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput == favNumber)
            {
                Console.WriteLine("...lucky guess! I'd play the lottery if I were you");

            }

            else if (userInput < favNumber)
            {
                Console.WriteLine($"not even close... {userInput} is way too low");

            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is looking high to me");

            }
            else
            {
                Console.WriteLine("ooga booga");
            }


            }
        }
    } 
