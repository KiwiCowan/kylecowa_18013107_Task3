namespace task1_GADE_KyleCowan_18013107_V2
{
    abstract class Unit
    {
        //varibles
        protected int xPos;
        protected int yPos;
        protected int hp;
        protected int atk;
        protected int range;
        protected string faction;
        protected string symbol;
        protected int maxHP;
        protected bool attacking;
        //getters and setters
        public int XPos { get => xPos; set => xPos = value; }
        public int YPos { get => yPos; set => yPos = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Atk { get => atk; set => atk = value; }
        public int Range { get => range; set => range = value; }
        public string Faction { get => faction; set => faction = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public int MaxHP { get => maxHP; set => maxHP = value; }
        public bool Attacking { get => attacking; set => attacking = value; }

        public Unit(int Xpos, int Ypos, string faction, string symbol)
        {
        }

        public abstract int ClosestUnitPos(Unit[] units, int mainUnit);

        public abstract bool AttackRangeCheck(Unit[] units, int hero, int enemy);

        public abstract void MoveUnitPos(int hero, int enemy, Unit[] units);

        public abstract void Combat(int hero, int enemy, Unit[] units);

        public abstract void RunRandom();

        

    }
}
    
