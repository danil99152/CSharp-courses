using BattleShip;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShipLibrary
{
    [Player]
    public class BotShip : Player
    {
        public override int[,] MainField => BotField;

        public override Player Ship() => new BotShip();
    }
}