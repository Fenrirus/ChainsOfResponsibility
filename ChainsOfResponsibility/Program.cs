using System;

namespace ChainsOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var orc = new Monster("Orc", 3, 3, 3);
            Console.WriteLine("{3} = A:{0}, D:{1}, L:{2}"
                , orc.Atack, orc.Def, orc.Hp,
                orc.Name);

            var root = new MonsterModifier(orc);
            root.Add(new Weapon(orc));
            root.Add(new Armor(orc));
            root.Handle();

            Console.WriteLine("{3} = A:{0}, D:{1}, L:{2}"
                , orc.Atack, orc.Def, orc.Hp,
                orc.Name);
        }
    }
}