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
            bool we_have_a_winner = false;

            //horizontal
            if ((btnX1.Text == btnX2.Text) && (btnX2.Text == btnX3.Text))
                we_have_a_winner = true;
            else if ((btnY1.Text == btnY2.Text) && (btnY2.Text == btnY3.Text))
                we_have_a_winner = true;
            else if ((btnZ1.Text == btnZ2.Text) && (btnZ2.Text == btnZ3.Text))
                we_have_a_winner = true;

            //vertical
            if ((btnX1.Text == btnY1.Text) && (btnY1.Text == btnZ1.Text))
                we_have_a_winner = true;
            else if ((btnX2.Text == btnY2.Text) && (btnY2.Text == btnZ2.Text))
                we_have_a_winner = true;
            else if ((btnX3.Text == btnY3.Text) && (btnY3.Text == btnZ3.Text))
                we_have_a_winner = true;

            //diagonal
            if ((btnX1.Text == btnY2.Text) && (btnY2.Text == btnZ3.Text))
                we_have_a_winner = true;
            else if ((btnX3.Text == btnY2.Text) && (btnY2.Text == btnZ1.Text))
                we_have_a_winner = true;
        }


        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

        }
    }
}
