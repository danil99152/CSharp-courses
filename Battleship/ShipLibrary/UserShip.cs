using BattleShip;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShipLibrary
{
    [Player]
    public class UserShip : Player
    {
        public override int[,] MainField =>  UserField;

        public override Player Ship() => new UserShip();
    }
}