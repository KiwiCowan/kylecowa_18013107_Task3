using System;
using System.IO;

namespace task1_GADE_KyleCowan_18013107_V2
{
    class RangeUnit : Unit
    {
        Random r = new Random();

        public RangeUnit(int Xpos, int Ypos, string faction, string symbol) : base(Xpos, Ypos, faction, symbol)
        {
            this.XPos = Xpos;
            this.YPos = Ypos;
            this.hp = 100;
            this.atk = 5;
            this.range = 3;
            this.faction = faction;
            this.symbol = symbol;
            this.maxHP = MaxHP = 100;
            this.attacking = Attacking = false;
        }

        public override string ToString()
        {
            string[] unitType = GetType().ToString().Split('.');
            string myType = unitType[unitType.Length - 1];

            return Faction + "." + myType + "." + (XPos + 1) + "." + (YPos + 1) + "." + Hp;
        }

        public override int ClosestUnitPos(Unit[] units, int mainUnit)
        {
            int closestDist = 100;
            int distanceX = 0;
            int distanceY = 0;
            int distanceAbs = 0;
            int closestUnit = 0;


            for (int k = 0; k < units.Length -1 ; k++)
            {
                if (units[k] != units[mainUnit])
                {
                    if (units[k] != null)
                    {
                        if (units[k].Faction != units[mainUnit].Faction)
                        {
                            distanceX = Math.Abs(units[mainUnit].XPos - units[k].XPos);
                            distanceY = Math.Abs(units[mainUnit].YPos - units[k].YPos);
                            distanceAbs = Convert.ToInt32(Math.Sqrt((Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2))));

                            if (distanceAbs < closestDist)
                            {
                                closestUnit = k;
                            }
                        }
                    }
                }




            }
            return closestUnit;
        }

        public override void MoveUnitPos(int hero, int enemy, Unit[] units)
        {
            if (units[enemy] != null)
            {

                int distanceX = 0;
                int distanceY = 0;
                distanceX = units[enemy].XPos - units[hero].XPos;
                distanceY = units[enemy].YPos - units[hero].YPos;
                if (Math.Abs(distanceX) <= Math.Abs(distanceY))
                {
                    if (distanceX < 0)
                    {
                        units[hero].XPos--;
                    }
                    else if (distanceX > 0)
                    {
                        units[hero].XPos++;
                    }
                }

                else
                {
                    if (distanceY < 0)
                    {
                        units[hero].YPos--;
                    }
                    else if (distanceY > 0)
                    {
                        units[hero].YPos++;
                    }
                }


            }
        }

        public override bool AttackRangeCheck(Unit[] units, int hero, int enemy)
        {

            int distanceX = 0;
            int distanceY = 0;
            int distanceAbs = 0;

            distanceX = Math.Abs(units[hero].XPos - units[enemy].XPos);
            distanceY = Math.Abs(units[hero].YPos - units[enemy].YPos);
            distanceAbs = Convert.ToInt32(Math.Sqrt((Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2))));
            if (distanceAbs <= units[hero].Range)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public override void Combat(int hero, int enemy, Unit[] units)
        {
            int newHp = 0;
            newHp = units[enemy].Hp - units[hero].Atk;
            units[enemy].Hp = newHp;
            if (newHp <= 0)
            {
                units[hero] = null;
            }

        }

        public override void RunRandom()
        {

            int move = 0;
            Random rand = new Random();
            move = rand.Next(1, 5);


            switch (move)
            {
                case 1:


                    if (YPos > 0)
                    {
                        YPos--; //Up
                    }
                    else
                    {
                        YPos++;
                    }
                    break;
                case 2:
                    if (XPos < 19)
                    {
                        XPos++; //Right
                    }
                    else
                    {
                        XPos++;
                    }
                    break;
                case 3:
                    if (YPos < 19)
                    {
                        YPos++; //Down
                    }
                    else
                    {
                        YPos--;
                    }
                    break;
                case 4:
                    if (XPos > 0)
                    {
                        XPos--; //Left
                    }
                    else
                    {
                        XPos++;
                    }
                    break;
            }

        }


    }
}