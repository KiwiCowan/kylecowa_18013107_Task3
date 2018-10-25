using System;
using System.IO;

namespace task1_GADE_KyleCowan_18013107_V2
{
    class MeleeUnit : Unit
    {
        Random r = new Random();

        public MeleeUnit(int Xpos, int Ypos, string faction, string symbol) : base(Xpos, Ypos, faction, symbol)
        {

            this.XPos = Xpos;
            this.YPos = Ypos;
            if (Xpos < 0)
            {
                Xpos = 1;
            }
            if (Ypos < 0)
            {
                Ypos = 1;
            }
            this.hp = 100;
            this.atk = 10;
            this.range = 1;
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

        public override Unit ClosestUnit(Unit[] units)
        {
            int distance = 500;
            int closestUnit = distance;
            Unit returnunit = null;

            for (int k = 0; k < units.Length; k++)
            {
                if (units[k] != null)
                {
                    if (units[k] != this)
                    {
                        if (units[k].Faction != faction)
                        {
                            int xDistance = (XPos - units[k].XPos);
                            int yDistance = (YPos - units[k].YPos);

                            closestUnit = Math.Abs((xDistance ^ 2 + yDistance ^ 2) ^ 1 / 2);

                            if (closestUnit < distance)
                            {
                                distance = closestUnit;
                                returnunit = units[k];
                            }
                        }
                    }
                }
            }
            return returnunit;
        }

        public override void MoveUnitPos(Unit units)
        {


            if (units != null)
            {

                double distanceX = 0;
                double distanceY = 0;

                distanceX = units.XPos - XPos;
                distanceY = units.YPos - YPos;

                if (Math.Abs(distanceX) != 0 || Math.Abs(distanceY) != 0)
                {
                    if (Math.Abs(distanceX) <= Math.Abs(distanceY))
                    {
                        if (distanceX < 0)
                        {
                            XPos = XPos - 1;
                        }
                        else if (distanceX > 0)
                        {
                            XPos = XPos + 1;
                        }
                    }

                    else
                    {
                        if (distanceY < 0)
                        {
                            YPos = YPos - 1;
                        }
                        else if (distanceY > 0)
                        {
                            YPos = YPos + 1;
                        }
                    }
                }
                else if (Math.Abs(distanceY) == 0)
                {
                    if (distanceY < 0)
                    {
                        YPos = YPos - 1;
                    }
                    else if (distanceY > 0)
                    {
                        YPos = YPos + 1;
                    }
                }
                else if (Math.Abs(distanceX) == 0)
                {
                    if (distanceX < 0)
                    {
                        XPos = XPos - 1;
                    }
                    else if (distanceX > 0)
                    {
                        XPos = XPos + 1;
                    }
                }


            }
        }

        public override bool AttackRangeCheck(Unit unit)
        {

            int distanceX = 0;
            int distanceY = 0;
            int distanceAbs = 0;
            bool returnVal = false;

            if (unit != null)
            {
                distanceX = Math.Abs(unit.XPos - XPos);
                distanceY = Math.Abs(unit.YPos - YPos);
                distanceAbs = Convert.ToInt32(Math.Sqrt((Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2))));
                if (distanceAbs <= Range)
                {
                    returnVal = true;
                }
                else
                {
                    returnVal = false;
                }
            }
            return returnVal;
        }

        public override void Combat(Unit units)
        {
            int newHp = 0;
            newHp = units.Hp - Atk;
            units.Hp = newHp;
            if (IsDead(newHp) == true)
            {
                units = null;
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

        public bool IsDead(int hp)
        {
            bool returnVal = false;
            if (hp <= 0)
            {
                returnVal = true;
            }
            return returnVal;
        }


    }
}
