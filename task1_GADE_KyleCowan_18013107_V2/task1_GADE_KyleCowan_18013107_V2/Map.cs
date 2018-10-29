using System;
using System.IO;

namespace task1_GADE_KyleCowan_18013107_V2
{
    class Map
    {
        public string[,] GameMap = new string[20, 20];
        public Unit[] units = new Unit[10];

        Random rand = new Random();


        public Map()
        {

        }

        public void GenMap()
        {
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    GameMap[y, x] = ",";
                    

                }
            }
        }

        public void MapDisplay()
        {
<<<<<<< HEAD
            UnitSpawner();
            BuildingSpawner();

            for (int j = 0; j < units.Length - 1; j++)
            {
                Console.WriteLine(units[j].ToString());
            }
            for (int k = 0; k < buildings.Length - 1; k++)
=======
            GenMap();
            UnitSpawner();
            for (int j = 0; j < units.Length; j++)
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229
            {
                GameMap[units[j].YPos, units[j].XPos] = units[j].Symbol;
            }
        }

        public void UnitSpawner()
        {
            for (int j = 0; j < units.Length; j++)
            {
                int UnitType;
                int factionAllocte;

                int x = rand.Next(1, 20);
                int y = rand.Next(1, 20);
                string faction = "";
                string symbol = "";
                UnitType = rand.Next(1, 3);

                switch (UnitType)
                {
                    case 1: //Melee baby sharks
                        factionAllocte = rand.Next(1, 3);
                        switch (factionAllocte)
                        {
                            case 1: //hammerHead sharks
                                faction = "Hammerhead";
                                symbol = "H";
                                break;

                            case 2: //raggertooth sharks 
                                faction = "Raggertooth";
                                symbol = "R";
                                break;
                        }
                        units[j] = new MeleeUnit(x, y, faction, symbol);
                        break;

                    case 2: //Ranged baby sharks
                        factionAllocte = rand.Next(1, 3);
                        switch (factionAllocte)
                        {
                            case 1:
                                faction = "Hammerhead";
                                symbol = "h";
                                break;

                            case 2:
                                faction = "Raggertooth";
                                symbol = "r";
                                break;
                        }
                        units[j] = new RangeUnit(x, y, faction, symbol);
                        break;

                }
               
            }
        }

        public void MoveUnitPosMap(Unit unit)
        {

            GameMap[unit.YPos, unit.XPos] = ",";
            unit.MoveUnitPos(unit.ClosestUnit(units));
            GameMap[unit.YPos, unit.XPos] = unit.Symbol;

        }
        
    }

}
