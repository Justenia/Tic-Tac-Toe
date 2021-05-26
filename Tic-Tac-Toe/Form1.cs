using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_current = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
                button.Text = "X";
            else
                button.Text = "O";

            turn = !turn;
            button.Enabled = false;

            checkWinner();
        }

        private void checkWinner()
        {
            bool there_is_a_winner = false;
            //horizontal
            if ((btnX1.Text == btnX2.Text) && (btnX2.Text == btnX3.Text))
                there_is_a_winner = true;
            MessageBox.Show("You Win!");
            if ((btnY1.Text == btnY2.Text) && (btnY2.Text == btnY3.Text))
                there_is_a_winner = true;
            MessageBox.Show("You Win!");
            if ((btnZ1.Text == btnZ2.Text) && (btnZ2.Text == btnZ3.Text))
                there_is_a_winner = true;
            MessageBox.Show("You Win!");
        }


        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

        }
    }
}
