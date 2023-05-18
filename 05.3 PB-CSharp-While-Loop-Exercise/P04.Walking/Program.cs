using System;

namespace P04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();
            double goal = 0.0;

            while (true) {
                if (steps == "Going home")
                {
                    steps = Console.ReadLine();
                    goal += double.Parse(steps);
                    break;
                }
                else
                {
                    goal += double.Parse(steps);
                    if (goal >= 10000)
                        break;
                }
            steps= Console.ReadLine();
            }
            if (goal >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{goal - 10000} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{10000 - goal} more steps to reach goal.");
            }

        }
    }
}
