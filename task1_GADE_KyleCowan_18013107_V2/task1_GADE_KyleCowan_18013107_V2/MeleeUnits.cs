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
            this.atk = 15;
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

<<<<<<< HEAD
<<<<<<< HEAD
        public override int ClosestUnitPos(Unit[] units, int mainUnit)
=======
        public override Unit closestUnit(Unit[] units)
>>>>>>> parent of 3c627e0... Revert "v12"
        {
            int tDistance = 500;
            int Distance = tDistance;
            Unit feedBackUnit = null;
<<<<<<< HEAD
=======
            int closestDist = 500;
            int distanceX = 0;
            int distanceY = 0;
            int distanceAbs = 0;
            int closestUnit = 0;
=======
        public override Unit ClosestUnit(Unit[] units)
        {
            int distance = 500;
            int closestUnit = distance;
            Unit returnunit = null;
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229
=======
>>>>>>> parent of 3c627e0... Revert "v12"

            for (int k = 0; k < units.Length; k++)
            {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of 3c627e0... Revert "v12"
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

                            closestUnit = Math.Abs(xDistance + yDistance );

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

<<<<<<< HEAD
            }
            return closestUnit;
=======
            return returnunit;
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229
=======
>>>>>>> parent of 3c627e0... Revert "v12"
        }

        public override void MoveUnitPos(Unit units)
        {


            if (units != null)
            {

<<<<<<< HEAD
                int distanceX = 0;
                int distanceY = 0;
                distanceX = units.XPos - XPos;
                distanceY = units.YPos - YPos;
                Map m = new Map();

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
<<<<<<< HEAD
                        units[hero].XPos = units[hero].XPos - 1;
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
=======
                        XPos = XPos - 1;
>>>>>>> parent of 3c627e0... Revert "v12"
                    }

                    else
                    {
<<<<<<< HEAD
<<<<<<< HEAD
                        units[hero].XPos = units[hero].XPos +1;
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
=======
                        XPos = XPos + 1;
>>>>>>> parent of 3c627e0... Revert "v12"
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

<<<<<<< HEAD
<<<<<<< HEAD
            distanceX = Math.Abs(units[enemy].XPos - units[hero].XPos);
            distanceY = Math.Abs(units[enemy].YPos - units[hero].YPos);
=======
            distanceX = Math.Abs(unit.XPos - XPos);
            distanceY = Math.Abs(unit.YPos - YPos);
>>>>>>> parent of 3c627e0... Revert "v12"
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
            return returnVal;
        }

        public override void Combat(Unit units)
        {
            int newHp = 0;
<<<<<<< HEAD
<<<<<<< HEAD
            newHp = units[enemy].Hp - units[hero].Atk;
            units[enemy].Hp = newHp;
            if (newHp <= 0)
            {
                units[hero] = null;
=======
            newHp = units.Hp - Atk;
            units.Hp = newHp;
            if (IsDead(newHp) == true)
            {
               // units = null;
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229
=======
            newHp = units.Hp - Atk;
            units.Hp = newHp;
            if (newHp <= 0)
            {
                units = null;
>>>>>>> parent of 3c627e0... Revert "v12"
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
