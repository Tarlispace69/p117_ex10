using System;

namespace p117_ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int[] weights = new int[34];
            string[] names = new string[34];
            int[] newWeights = new int[34];
            int i = 0, toLose = 0;

            //recieiving info for 34 participants
            for (i=0; i <= 34; i++)
            {
                //recieving name
                Console.WriteLine($"Participant {i}, please enter your name:");
                names[i] = Console.ReadLine();

                //recieving current weight
                Console.WriteLine("Please enter your weight:");
                weights[i] = int.Parse(Console.ReadLine());

                //recieving goal weight
                Console.WriteLine("Please enter your goal weight in 2 months:");
                newWeights[i] = int.Parse(Console.ReadLine());

                toLose = weights[i] - newWeights[i];

                //printing amount to lose
                Console.WriteLine($"you want to lose {toLose}kg");

                //if weight to lose is bigger than 12% of current weight; print unhealthy
                if (toLose > weights[i] * 0.12)
                {
                    Console.WriteLine("Unhealthy");
                }

            }

        }
    }
}
