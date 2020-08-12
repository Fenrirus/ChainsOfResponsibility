using System;
using System.Collections.Generic;
using System.Text;

namespace ChainsOfResponsibility
{
    public class Weapon : MonsterModifier
    {
        public Weapon(Monster monster) : base(monster)
        {
        }

        public override void Handle()
        {
            _monster.Atack += 3;
            base.Handle();
        }
    }
}