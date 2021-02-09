using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("you come across a brick wall, how will you get past it? (run, jump, walk around)");
            while(true)
            {
                string answer = Console.ReadLine();
                if (answer == "run" || answer == "jump" || answer == "walk around")
                {
                    Traverse(answer);
                    break;
                }
                else
                {
                    Console.WriteLine("please try again");
                }
            }

        }

        public static void Traverse(string movementoption)
        {
            MovementType movement = new MovementType();
            switch(movementoption)
            {
                case "run": movement.SetMovementType(new RunStrategy());
                    break;
                case "jump": movement.SetMovementType(new JumpStrategy());
                    break;
                case "walk around": movement.SetMovementType(new WalkStrategy());
                    break;
                default: break;
            }
            movement.MovementInterface();
        }
    }
}
