﻿namespace task1_GADE_KyleCowan_18013107_V2
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

<<<<<<< HEAD
<<<<<<< HEAD
        public abstract int ClosestUnitPos(Unit[] units, int mainUnit);
=======
        public abstract Unit ClosestUnit(Unit[] units);
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229
=======
        public abstract Unit closestUnit(Unit[] units);
>>>>>>> parent of 3c627e0... Revert "v12"

        public abstract bool AttackRangeCheck(Unit unit);

        public abstract void MoveUnitPos(Unit unit);

        public abstract void Combat(Unit unit);

        public abstract void RunRandom();

        

    }
}
    
