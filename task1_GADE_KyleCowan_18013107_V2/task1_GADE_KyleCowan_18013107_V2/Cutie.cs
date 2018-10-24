using System;

namespace task1_GADE_KyleCowan_18013107_V2
{
    class Cutie:Unit 
    {
        
            Random r = new Random();

            public Cutie(int Xpos, int Ypos, string faction, string symbol) : base(Xpos, Ypos, faction, symbol)
            {
                this.XPos = Xpos;
                this.YPos = Ypos;
                this.hp = 150;
                this.atk = 7;
                this.range = 2;
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


                for (int k = 0; k < units.Length; k++)
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

            //int distanceX = 0;
            //int distanceY = 0;


            //distanceX = units[hero].XPos - units[enemy].XPos;
            //distanceY = units[hero].YPos - units[enemy].YPos;



            //if (distanceX < distanceY)
            //{
            //    if (distanceX < 0)
            //    {
            //        XPos = XPos - 1;
            //    }
            //    else if (distanceX > 0)
            //    {
            //        XPos = XPos + 1;
            //    }
            //}
            //else
            //{
            //    if (distanceY < 0)
            //    {
            //        YPos = YPos - 1;
            //    }
            //    else if (distanceX > 0)
            //    {
            //        YPos = YPos + 1;
            //    }
            //}
            if (units[enemy] != null)
            {
                //int DistanceX = (enemy.Xposition - Xposition);
                //int DistanceY = (enemy.Yposition - Yposition);
                int distanceX = 0;
                int distanceY = 0;
                distanceX = units[hero].XPos - units[enemy].XPos;
                distanceY = units[hero].YPos - units[enemy].YPos;
                if (Math.Abs(distanceX) < Math.Abs(distanceY))
                {
                    if (distanceX < 0)
                        units[hero].XPos--;
                    else if (distanceX > 0)
                        units[hero].XPos++;
                }
                else if (Math.Abs(distanceY) < Math.Abs(distanceX))
                {
                    if (distanceY < 0)
                        units[hero].YPos--;
                    else if (distanceY > 0)
                        units[hero].YPos++;
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

            public override void Combat(Unit hero, Unit enemy)
            {
                int newHp = 0;
                newHp = enemy.Hp - hero.Atk;
                enemy.Hp = newHp;
                if (newHp <= 0)
                {
                    hero = null;
                }

            }

            public override void RunRandom(Unit hero)
            {

                int move = 0;
                Random rand = new Random(6);
                move = rand.Next(1, 5);


                switch (move)
                {
                    case 1:


                        if (hero.YPos > 0)
                        {
                            hero.YPos--; //Up
                        }
                        else
                        {
                            hero.YPos++;
                        }
                        break;
                    case 2:
                        if (hero.XPos < 19)
                        {
                            hero.XPos++; //Right
                        }
                        else
                        {
                            hero.XPos++;
                        }
                        break;
                    case 3:
                        if (hero.YPos < 19)
                        {
                            hero.YPos++; //Down
                        }
                        else
                        {
                            hero.YPos--;
                        }
                        break;
                    case 4:
                        if (hero.XPos > 0)
                        {
                            hero.XPos--; //Left
                        }
                        else
                        {
                            hero.XPos++;
                        }
                        break;
                }

            }


        }
    }



