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
    public partial class playground : Form
    {
        public String record = "";
        public int Rocky = 100, Gamby = 100, Pargeet = 100, Simon = 100;
        public int BetAmount = 0;
        public playground()
        {
            InitializeComponent();
            //here we are going to divide task into parts 

            

        }

        private void btn_Race_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            selectPlayer SP = new selectPlayer();
            if (super1.Left <= 750)
            {
                SP.getNumber();
                super1.Left += SP.Num;
            }
            else {
                timer1.Stop();
                resetTask("1");
                MessageBox.Show("Car 1 won the Race ");
            }

            if (super2.Left <= 750)
            {
                SP.getNumber();
                super2.Left += SP.Num;
            }
            else
            {
                timer1.Stop();
                resetTask("2");

                MessageBox.Show("Car 2 won the Race ");
            }

            if (super3.Left <= 750)
            {
                SP.getNumber();
                super3.Left += SP.Num;
            }
            else
            {
                timer1.Stop();
                resetTask("3");

                MessageBox.Show("Car 3 won the Race ");
            }
            if (super4.Left <= 750)
            {
                SP.getNumber();
                super4.Left += SP.Num;
            }
            else
            {
                timer1.Stop();
                resetTask("4");

                MessageBox.Show("Car 4 won the Race ");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void playground_Load(object sender, EventArgs e)
        {
            int y = 0;
            for (y = 5; y <= 50; y = y + 5) {
                //here we need to pass the data from one space to other 
                selected_amount.Items.Add(y.ToString());
            }
        }

        private void Lock_btn_Click(object sender, EventArgs e)
        {
            String[] h = lblRecord.Text.Split(',');
            playerDetails.Text = h[0];
            
            carDetails.Text = h[1];

            if (h[0].Equals("Rocky"))
            {
                rocky_has.Text = "Rockey like to bet ," + h[1] + "," + selected_amount.Text;
                BetAmount = Convert.ToInt32(selected_amount.Text);
            }
            else if (h[0].Equals("Gamby"))
            {
                gamby_has.Text = "Gamby like to bet ," + h[1] + "," + selected_amount.Text;
                BetAmount = Convert.ToInt32(selected_amount.Text);
            }
            else if (h[0].Equals("Pargeet"))
            {
                pargeet_has.Text = "Pargeet like to bet ," + h[1] + "," + selected_amount.Text;
                BetAmount = Convert.ToInt32(selected_amount.Text);
            }
            else if (h[0].Equals("Simon"))
            {
                simon_has.Text = "Simon like to bet ," + h[1] + "," + selected_amount.Text;
                BetAmount = Convert.ToInt32(selected_amount.Text);
            }
            else {
                MessageBox.Show("you need to restart the Game ");
            }
            if (BetAmount>0) {
                btn_Race.Visible = true;
            }
            

        }

        public void resetTask(String Car)
        {
            selectPlayer sp = new selectPlayer();
            if (playerDetails.Text.Equals("Rocky"))
            {
                Rocky = sp.betAmount(carDetails.Text, Car,BetAmount,Rocky);
                rocky_has.Text = "Rocky has " + Rocky;
            }
            if (playerDetails.Text.Equals("Gamby"))
            {
                Gamby = sp.betAmount(carDetails.Text, Car, BetAmount, Gamby);
                gamby_has.Text = "Gamby has " + Gamby;
            }
            if (playerDetails.Text.Equals("Pargeet"))
            {
                Pargeet = sp.betAmount(carDetails.Text, Car, BetAmount, Pargeet);
                pargeet_has.Text = "Pargeet has " + Pargeet;
            }
            if (playerDetails.Text.Equals("Simon"))
            {
                Simon = sp.betAmount(carDetails.Text, Car, BetAmount, Simon);
                simon_has.Text = "Simon has " + Simon;
            }
            super1.Left = 0; super2.Left = 0; super3.Left = 0; super4.Left = 0;
            carDetails.Text = "";
            playerDetails.Text = "";
            selected_amount.Text = "";
            lblRecord.Text = "";
            BetAmount = 0;
            btn_Race.Visible = false;

        }
    }
}
