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

            for (int j = 0; j < map.units.Length; j++) //runs though all units 
            {
                if (map.units[j] != null)
                {
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
                            }
                            else
                            {
                                map.MoveUnitPosMap(map.units[j]);
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
                else
                {

                }
                //System.Console.WriteLine(map.units[j].ToString());
                //Unit clostest = map.units[j].closestUnit(map.units);
                //System.Console.WriteLine("unit " + j + "is looking for " + clostest.ToString());
            }
        }

        public void StartGame()
        {
            map.MapDisplay();
           
        }
    }
}
