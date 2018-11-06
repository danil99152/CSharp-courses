using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public abstract class Player : ShipGenerator
    {
        public virtual int[,] MainField { get; }

        public Player()
        {
            Number = 0;
            Four(MainField);
            while (Number < 2)
            {
                Three(MainField);
            }
            Number = 0;
            while (Number < 3)
            {
                Two(MainField);
            }
            Number = 0;
            while (Number < 4)
            {
                One(MainField);
            }
        }

        public abstract Player Ship();
    }
}
