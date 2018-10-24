namespace task1_GADE_KyleCowan_18013107_V2
{
    class GameEngine
    {
        public Map map = new Map();
        public ResourceBuilding resources = new ResourceBuilding(0, 0, ".", ".");

        public GameEngine()
        {

        }

        public void PlayGame()
        {
            StartGame();

            for (int j = 0; j < map.buildings.Length; j++)
            {
                if (map.buildings[j] != null)
                    map.GameMap[map.buildings[j].YPos, map.buildings[j].XPos] = map.buildings[j].Symbol;
            }
        }

        private void StartGame()
        {

            for (int j = 0; j < map.units.Length; j++) //runs though all units 
            {
                if (map.units[j] != null)
                {


                    if (map.units[j].Hp > 0)
                    {
                        int closestUnit = map.units[j].ClosestUnitPos(map.units, j);

                        if (map.units[j].AttackRangeCheck(map.units, j, closestUnit) == true)
                        {
                            map.units[j].Combat(map.units[j], map.units[closestUnit]);

                            if (map.units[j].Hp / map.units[j].MaxHP * 100 <= 25 / 100)
                            {
                                map.units[j].RunRandom(map.units[j]);

                            }
                            else
                            {
                                map.units[j].Combat(map.units[j], map.units[closestUnit]);
                            }
                        }
                        else
                        {
                            map.units[j].MoveUnitPos(j, closestUnit, map.units);
                        }
                        map.GameMap[map.units[j].YPos, map.units[j].XPos] = map.units[j].Symbol;
                    }
                    else
                    {
                        map.GameMap[map.units[j].YPos, map.units[j].XPos] = ",";
                        map.units[j] = null;
                    }
                }
            }
        }
    }
}
