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
            this.atk = 10;
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

<<<<<<< HEAD
        public override int ClosestUnitPos(Unit[] units, int mainUnit)
        {
<<<<<<< HEAD
            int tDistance = 500;
            int Distance = tDistance;
            Unit feedBackUnit = null;
=======
            int closestDist = 100;
            int distanceX = 0;
            int distanceY = 0;
            int distanceAbs = 0;
            int closestUnit = 0;

>>>>>>> parent of d876a44... v12
=======
        public override Unit ClosestUnit(Unit[] units)
        {
            int distance = 500;
            int closestUnit = distance;
            Unit returnunit = null;
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229

            for (int k = 0; k < units.Length -1 ; k++)
            {
<<<<<<< HEAD
<<<<<<< HEAD
                //finding the distance
                if (units[k] != null && units[k] != this && units[k].Hp > 0 && units[k].Faction != faction)
                    Distance = ((XPos - units[k].XPos) ^ 2 + (YPos - units[k].YPos) ^ 2) ^ 1 / 2;
                if (Distance < 0)
                    Distance = Math.Abs(Distance);
                if (Distance < tDistance)
=======
                if (units[k] != null)
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229
                {
                    if (units[k] != this)
                    {
                        if (units[k].Faction != faction)
                        {
                            int xDistance = (XPos - units[k].XPos);
                            int yDistance = (YPos - units[k].YPos);

                            closestUnit = Math.Abs(xDistance + yDistance);

                            if (closestUnit < distance)
                            {
                                distance = closestUnit;
                                returnunit = units[k];
                            }
                        }
                    }
                }
            }
<<<<<<< HEAD
            return feedBackUnit;
=======
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
>>>>>>> parent of d876a44... v12


=======
            return returnunit;
        }
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229


            }
            return closestUnit;
        }

        public override void MoveUnitPos(int hero, int enemy, Unit[] units)
        {
            if (units[enemy] != null)
            {

<<<<<<< HEAD
                int distanceX = 0;
                int distanceY = 0;
                distanceX = units[enemy].XPos - units[hero].XPos;
                distanceY = units[enemy].YPos - units[hero].YPos;
                if (Math.Abs(distanceX) <= Math.Abs(distanceY))
=======
                double distanceX = 0;
                double distanceY = 0;

                distanceX = units.XPos - XPos;
                distanceY = units.YPos - YPos;

                if (Math.Abs(distanceX) != 0 || Math.Abs(distanceY) != 0)
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229
                {
                    if (Math.Abs(distanceX) <= Math.Abs(distanceY))
                    {
<<<<<<< HEAD
                        units[hero].XPos--;
=======
                        if (distanceX < 0)
                        {
                            XPos = XPos - 1;
                        }
                        else if (distanceX > 0)
                        {
                            XPos = XPos + 1;
                        }
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229
                    }

                    else
                    {
<<<<<<< HEAD
                        units[hero].XPos++;
=======
                        if (distanceY < 0)
                        {
                            YPos = YPos - 1;
                        }
                        else if (distanceY > 0)
                        {
                            YPos = YPos + 1;
                        }
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229
                    }
                }
                else if (Math.Abs(distanceY) == 0)
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

        public override bool AttackRangeCheck(Unit[] units, int hero, int enemy)
        {

            int distanceX = 0;
            int distanceY = 0;
            int distanceAbs = 0;
            bool returnVal = false;

<<<<<<< HEAD
            distanceX = Math.Abs(units[enemy].XPos - units[hero].XPos);
            distanceY = Math.Abs(units[enemy].YPos - units[hero].YPos);
            distanceAbs = Convert.ToInt32(Math.Sqrt((Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2))));
            if (distanceAbs <= Range)
=======
            if (unit != null)
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229
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
<<<<<<< HEAD
=======
            return returnVal;
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229
        }

        public override void Combat(int hero, int enemy, Unit[] units)
        {
            int newHp = 0;
            newHp = units[enemy].Hp - units[hero].Atk;
            units[enemy].Hp = newHp;
            if (newHp <= 0)
            {
<<<<<<< HEAD
                units[hero] = null;
=======
              //  units = null;
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229
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