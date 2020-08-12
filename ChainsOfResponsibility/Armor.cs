namespace ChainsOfResponsibility
{
    public class Armor : MonsterModifier
    {
        public Armor(Monster monster) : base(monster)
        {
        }

        public override void Handle()
        {
            _monster.Def += 3;
            base.Handle();
        }
    }
}