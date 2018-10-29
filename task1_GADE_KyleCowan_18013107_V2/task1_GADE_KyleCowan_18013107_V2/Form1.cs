using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1_GADE_KyleCowan_18013107_V2
{
    public partial class frmGame : Form
    {
        int Timer = 0;

        int hammerHead;
        int raggerTooth;

        GameEngine gameE = new GameEngine();


        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {

        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            cmbUnitsDesplay.Items.Clear();
            for (int l = 0; l < gameE.map.units.Length - 1; l++)
            {
                if (gameE.map.units[l] != null)
                    cmbUnitsDesplay.Items.Add(gameE.map.units[l].ToString());
            }

            gameE.PlayGame();

            RedrawMap();
            

            Timer++;
            lblTimer.Text = "Time: " + Timer;



        }

        public void RedrawMap()
        {
            lblMap.Text = "";
            for (int y = 0; y < 20; y++)
            {
                for (int x = 0; x < 20; x++)
                {
                    lblMap.Text += gameE.map.GameMap[y, x];
                }
                lblMap.Text += "\n";
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            Timer = 0;
<<<<<<< HEAD
            gameE.map.GenMap();
            gameE.map.PopMap();
            gameE.map.UnitSpawner();
            gameE.PlayGame();
=======
            gameE.StartGame();
>>>>>>> 29ef97d2b55e6eae9bc0499326477d690f893229
            tmrTimer.Start();

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmrTimer.Stop();
        }
    }
}

