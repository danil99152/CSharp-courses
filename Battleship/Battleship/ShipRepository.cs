using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

namespace BattleShip
{
    class ShipRepository
    {
        public static List<Player> Ships { get; }
        public static List<Player> Play { get; }

        public void InitShips()
        {
            var dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");
            foreach (var path in Directory.GetFiles(dir, "*.dll"))
            {
                var asm = Assembly.LoadFile(path);
                Ships.AddRange(CollectTypes<Player, PlayerAttribute>(asm));
            }
            foreach (var shipType in Ships)
            {
                foreach (shipType.MainField in Directory.GetFiles(dir, "*.dll"))
                {
                    Play.Add(shipType.Ship());
                }
            }
        }

        public static List<T> CollectTypes<T, TA>(Assembly asm)
            where TA : Attribute
        {
            var res = new List<T>();

            foreach (var type in asm.GetTypes())
            {
                var attr = type.GetCustomAttribute<TA>();
                if (attr != null)
                {
                    res.Add((T)Activator.CreateInstance(type));
                }
            }

            return res;
        }
    }
}