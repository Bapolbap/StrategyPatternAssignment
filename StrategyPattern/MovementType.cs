using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class MovementType
    {
        private IMovementInterface _strategy;

        public void SetMovementType(IMovementInterface strategy)
        {
            _strategy = strategy;
        }

        public void MovementInterface()
        {
            _strategy.Move();
        }
    }
}
