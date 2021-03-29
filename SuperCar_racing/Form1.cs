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
    public partial class Form1 : Form
    {
        int carNo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void supercar1_CheckedChanged(object sender, EventArgs e)
        {
            if (supercar1.Checked==true) {
                carNo = 1;
                supercar2.Checked = false;
                supercar3.Checked = false;
                supercar4.Checked = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // when car 3 selected

        private void supercar3_CheckedChanged(object sender, EventArgs e)
        {
            if (supercar3.Checked == true)
            {
                carNo = 3;
                supercar2.Checked = false;
                supercar1.Checked = false;
                supercar4.Checked = false;
            }
        }
        //// when car 2 is selected
        private void supercar2_CheckedChanged(object sender, EventArgs e)
        {
            if (supercar2.Checked == true)
            {
                carNo = 2;
                supercar1.Checked = false;
                supercar3.Checked = false;
                supercar4.Checked = false;
            }
        }


        // when car 4 is selected
        private void supercar4_CheckedChanged(object sender, EventArgs e)
        {
            if (supercar4.Checked == true)
            {
                carNo = 4;
                supercar2.Checked = false;
                supercar3.Checked = false;
                supercar1.Checked = false;
            }
        }
        /// <summary>
        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// selecting a car 
        private void button1_Click(object sender, EventArgs e)
        {
            players players = new players();
            players.lblCarNo.Text = ""+carNo;
            players.Show();
        }
    }
}
