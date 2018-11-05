using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    [Ship]
    public abstract class Ship: Battleship
    {
        public virtual void Four(int[,] Field)
        {
        }

        public virtual void Three(int[,] Field)
        {
        }

        public virtual void Two(int[,] Field)
        {
        }

        public virtual void One(int[,] Field)
        { 
        }
    }
}