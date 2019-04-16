using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe2._0
{
    public partial class Form1 : Form
    {
        bool turn = true;
        bool winner = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void A1_Click(object sender, EventArgs e)
        {//A1_Click anfang
            Button b = (Button)sender;

            if (turn)
            {
                b.Text = "X";
                b.Enabled = false;
                player2.Visible = true;
                player1.Visible = false;
                turn = !turn;
            }
                else
            {
                b.Text = "O";
                b.Enabled = false;
                player2.Visible = false;
                player1.Visible = true;
                turn = !turn;
            }


            // all win combinations
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (A1.Enabled == false) && (A2.Enabled == false) && (A3.Enabled == false))
            {
                winner = true;
            }
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (B1.Enabled == false) && (B2.Enabled == false) && (B3.Enabled == false))
            {
                winner = true;
            }

            if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (C1.Enabled == false) && (C2.Enabled == false) && (C3.Enabled == false))
            {
                winner = true;
            }

            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (A1.Enabled == false) && (B2.Enabled == false) && (C3.Enabled == false))
            {
                winner = true;
            }

            if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (A3.Enabled == false) && (B2.Enabled == false) && (C1.Enabled == false))
            {
                winner = true;
            }

            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (A1.Enabled == false) && (B1.Enabled == false) && (C1.Enabled == false))
            {
                winner = true;
            }

            if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (A2.Enabled == false) && (B2.Enabled == false) && (C2.Enabled == false))
            {
                winner = true;
            }

            if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (A3.Enabled == false) && (B3.Enabled == false) && (C3.Enabled == false))
            {
                winner = true;
            }
            //end all win combinations for winner = true condition

            
            if (winner == true)
            {
                if (turn)
                {
                    textBox1.Text = "O won the game!";
                }
                else textBox1.Text = "X won the game!";
            }

            if (winner == true)
            {
                A1.Enabled = false;
                A2.Enabled = false;
                A3.Enabled = false;
                B1.Enabled = false;
                B2.Enabled = false;
                B3.Enabled = false;
                C1.Enabled = false;
                C2.Enabled = false;
                C3.Enabled = false;

                player1.Visible = false;
                player2.Visible = false;
            }



        }//A1_Click ende

        private void Player1_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;

            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";



            player1.Visible = true;
            player2.Visible = false;

            turn = true;
            winner = false;

            textBox1.Text = "";
        }
    }
}
