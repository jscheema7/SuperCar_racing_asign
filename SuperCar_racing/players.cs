using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCar_racing
{
    public partial class players : Form
    {
        public int car = 0;
        public String PlayerName = "";
        public players()
        {
            InitializeComponent();
            
        }

        private void players_Load(object sender, EventArgs e)
        {

        }

        private void supercar1_CheckedChanged(object sender, EventArgs e)
        {
            if (Playercar1.Checked==true) {
                PlayerName = "Rocky";
                Playercar2.Checked = false;
                playercar3.Checked = false;
                playercar4.Checked = false;
            }
        }

        private void Playercar2_CheckedChanged(object sender, EventArgs e)
        {
            if (Playercar2.Checked == true)
            {
                PlayerName = "Gamby";
                Playercar1.Checked = false;
                playercar3.Checked = false;
                playercar4.Checked = false;
            }
        }

        private void playercar3_CheckedChanged(object sender, EventArgs e)
        {
            if (playercar3.Checked == true)
            {
                PlayerName = "Pargeet";
                Playercar1.Checked = false;
                Playercar2.Checked = false;
                playercar4.Checked = false;
            }
        }

        private void playercar4_CheckedChanged(object sender, EventArgs e)
        {
            if (playercar4.Checked == true)
            {
                PlayerName = "Simon";
                Playercar1.Checked = false;
                playercar3.Checked = false;
                Playercar2.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playground playground = new playground();
            PlayerName +=","+lblCarNo.Text;
            playground.lblRecord.Text= PlayerName;
            playground.Show();
        }
    }
}
