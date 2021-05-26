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
            if ((btnX1.Text == btnX2.Text) && (btnX2.Text == btnX3.Text) && (!btnX1.Enabled))
                we_have_a_winner = true;
            else if ((btnY1.Text == btnY2.Text) && (btnY2.Text == btnY3.Text) && (!btnY1.Enabled))
                we_have_a_winner = true;
            else if ((btnZ1.Text == btnZ2.Text) && (btnZ2.Text == btnZ3.Text) && (!btnZ1.Enabled))
                we_have_a_winner = true;

            //vertical
            else if ((btnX1.Text == btnY1.Text) && (btnY1.Text == btnZ1.Text) && (!btnX1.Enabled))
                we_have_a_winner = true;
            else if ((btnX2.Text == btnY2.Text) && (btnY2.Text == btnZ2.Text) && (!btnX2.Enabled))
                we_have_a_winner = true;
            else if ((btnX3.Text == btnY3.Text) && (btnY3.Text == btnZ3.Text) && (!btnX3.Enabled))
                we_have_a_winner = true;

            //diagonal
            else if ((btnX1.Text == btnY2.Text) && (btnY2.Text == btnZ3.Text) && (!btnX1.Enabled))
                we_have_a_winner = true;
            else if ((btnX3.Text == btnY2.Text) && (btnY2.Text == btnZ1.Text) && (!btnX3.Enabled))
                we_have_a_winner = true;

            if (we_have_a_winner)
            {
                disableButtons();

                String Winner = "";
                if (turn)
                    Winner = "O";
                else
                    Winner = "X";

                MessageBox.Show(Winner + " Victory Belongs to You!", "Winner");
            }
            else
            {
                if(turn_current == 9)
                    MessageBox.Show("It's a Draw!");
            }
        }
        private void disableButtons()
        {
            foreach (Control c in Controls)
            {
                Button button = (Button)c;
                button.Enabled = false;
            }
        }


        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

        }
    }
}
