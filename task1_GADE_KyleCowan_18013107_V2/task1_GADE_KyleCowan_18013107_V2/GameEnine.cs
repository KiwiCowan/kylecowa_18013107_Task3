namespace task1_GADE_KyleCowan_18013107_V2
{
    class GameEngine
    {
        public Map map = new Map();

        public GameEngine()
        {

        }

        public void PlayGame()
        {

            for (int j = 0; j < 10; j++) //runs though all units 
            {
                if (map.units[j] != null)
                {
<<<<<<< HEAD


                    if (map.units[j].Hp > 0)
                    {
                        int closestUnit = map.units[j].ClosestUnitPos(map.units, j);
                        if (map.units[j].Hp / map.units[j].MaxHP * 100 > 25 / 100)
                        {

                            if (map.units[j].AttackRangeCheck(map.units, j, closestUnit) == true)
                            {
                                map.units[j].Combat(j, closestUnit, map.units);
                            }
                            else
                            {
                                map.units[j].MoveUnitPos(j, closestUnit, map.units);
                                map.GameMap[map.units[j].YPos, map.units[j].XPos] = map.units[j].Symbol;
=======
                    //map.GameMap[map.units[j].YPos, map.units[j].XPos] = ",";

                    if (map.units[j].Hp > 0)
                    {

                        //int closestUnit = map.units[j].ClosestUnitPos(map.units, j);
                        //System.Console.WriteLine(j + " unit " + map.units[j].Faction + " finds  unit " + closestUnit + " , " + map.units[j].Faction + " at" + map.units[closestUnit].XPos + " , "  + map.units[closestUnit].YPos);
                        if (map.units[j].Hp / map.units[j].MaxHP * 100 > 25 / 100)
                        {

                            if (map.units[j].AttackRangeCheck(map.units[j].ClosestUnit(map.units)) == true)
                            {
                                map.units[j].Combat(map.units[j].ClosestUnit(map.units));
                                //System.Console.WriteLine("unit " + j + " is fighing " + map.units[j].ClosestUnit(map.units));
                            }
                            else
                            {
                                map.MoveUnitPosMap(map.units[j]);
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229
                            }
                        }
                        else
                        {
                            map.units[j].RunRandom();
                        }
                    }
                    else
                    {
                        map.GameMap[map.units[j].YPos, map.units[j].XPos] = ",";
                        map.units[j] = null;
                    }
                }
<<<<<<< HEAD
=======
                //System.Console.WriteLine("unit " + j + " is fighing " + map.units[j].ClosestUnit(map.units));
                //System.Console.WriteLine(map.units[j].ToString());
                //Unit clostest = map.units[j].closestUnit(map.units);
                //System.Console.WriteLine("unit " + j + "is looking for " + clostest.ToString());
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229
            }
        }

        public void StartGame()
        {
            map.MapDisplay();
           
        }
    }
}
