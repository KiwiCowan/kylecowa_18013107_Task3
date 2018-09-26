namespace task1_GADE_KyleCowan_18013107_V2
{
    abstract class Building
    {
        protected int hp;
        protected int xPos;
        protected int yPos;
        protected string symbol;
        protected string faction;
        protected int resourcePerTick;
        protected int hammerHeadR;
        protected int raggerToothR;
        //getters and setters
        public int Hp { get => hp; set => hp = value; }
        public int XPos { get => xPos; set => xPos = value; }
        public int YPos { get => yPos; set => yPos = value; }
        public string Symbol { get => symbol; set => symbol = value; }
        public string Faction { get => faction; set => faction = value; }
        public int HammerHeadR { get => hammerHeadR; set => hammerHeadR = value; }
        public int RaggerToothR { get => raggerToothR; set => raggerToothR = value; }
        public int ResourcePerTick { get => resourcePerTick; set => resourcePerTick = value; }

        public Building(int Xpos, int Ypos, string symbol, string faction)
        {

        }

        public virtual int HammerHeadR_Gen()
        {
            return 0;
        }

        public virtual int RaggerToothR_Gen()
        {
            return 0;
        }


    }
}
