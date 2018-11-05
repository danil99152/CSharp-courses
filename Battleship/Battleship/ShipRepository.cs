using System;
using System.Collections.Generic;
using System.Reflection;
using System.IO;

namespace BattleShip
{
    class ShipRepository
    {
        private static List<Ship> Ships = new List<Ship>(); 

        public void InitShips()
        {
            var dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugins");  
            foreach (var path in Directory.GetFiles(dir, "*.dll"))
            {
                var asm = Assembly.LoadFile(path);
                Ships.AddRange(CollectTypes<Ship, ShipAttribute>(asm));
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