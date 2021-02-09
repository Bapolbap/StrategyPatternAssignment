using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class JumpStrategy : IMovementInterface
    {
        public void Move()
        {
            Console.WriteLine("with your superhuman legs, you leap across the brick wall");
        }
    }
}
