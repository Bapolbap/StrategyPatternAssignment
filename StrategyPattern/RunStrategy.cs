using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class RunStrategy : IMovementInterface
    {
        public void Move()
        {
            Console.WriteLine("you run straight into the brick wall, shattering all your teeth");
        }
    }
}
