namespace ChainsOfResponsibility
{
    public class MonsterModifier
    {
        protected Monster _monster;
        protected MonsterModifier next;

        public MonsterModifier(Monster monster)
        {
            _monster = monster;
        }

        public void Add(MonsterModifier mm)
        {
            if (next != null)
            {
                next.Add(mm);
            }
            else
            {
                next = mm;
            }
        }

        public virtual void Handle()
        {
            next?.Handle();
        }
    }
}