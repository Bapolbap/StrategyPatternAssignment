using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class WalkStrategy : IMovementInterface
    {
        public void Move()
        {
            Console.WriteLine("you choose to walk around the wall");
        }
    }
}
