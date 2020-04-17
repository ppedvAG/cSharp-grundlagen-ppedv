using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int zähler = 0;

        void PrüfeGewinner(string x_oder_o)
        {
            if (button1.Text == x_oder_o && button2.Text == x_oder_o && button3.Text == x_oder_o)
            {
                MessageBox.Show(x_oder_o + " hat gewonnen!");
            }
            else if (button4.Text == x_oder_o && button5.Text == x_oder_o && button6.Text == x_oder_o)
            {
                MessageBox.Show(x_oder_o + " hat gewonnen!");
            }
            else if (button7.Text == x_oder_o && button8.Text == x_oder_o && button9.Text == x_oder_o)
            {
                MessageBox.Show(x_oder_o + " hat gewonnen!");
            }
            else if (button1.Text == x_oder_o && button4.Text == x_oder_o && button7.Text == x_oder_o)
            {
                MessageBox.Show(x_oder_o + " hat gewonnen!");
            }
            else if (button2.Text == x_oder_o && button5.Text == x_oder_o && button8.Text == x_oder_o)
            {
                MessageBox.Show(x_oder_o + " hat gewonnen!");
            }
            else if (button3.Text == x_oder_o && button6.Text == x_oder_o && button9.Text == x_oder_o)
            {
                MessageBox.Show(x_oder_o + " hat gewonnen!"); }

            else if (button1.Text == x_oder_o && button5.Text == x_oder_o && button9.Text == x_oder_o)
            {// diagonale \
                MessageBox.Show(x_oder_o + " - Du bist der Gewinner.");
                
            }
            else if (button3.Text == x_oder_o && button5.Text == x_oder_o && button7.Text == x_oder_o)
            {// diagonale /
                MessageBox.Show(x_oder_o + " - Du bist der Gewinner.");
                
            
            }
            else if (zähler == 8)
            {
                MessageBox.Show("Untentschieden, macht liebe Sport!");
                Environment.Exit(0);
            }
        }

        void SchrittFunktion(object senderobj)
        {
            string buttontext = ((Button)senderobj).Text;
            if (buttontext == "")
            {
                if (zähler % 2 == 0)
                {
                    ((Button)senderobj).Text = "X";
                    PrüfeGewinner("X");
                }
                else
                {
                    ((Button)senderobj).Text = "O";
                    PrüfeGewinner("O");
                }
                zähler++;
            }
            else
            {
                MessageBox.Show("Klick wo anders, du!");
            }
        }
        private void button1_Click(object sender, EventArgs e)

        {
            SchrittFunktion(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SchrittFunktion(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SchrittFunktion(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SchrittFunktion(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SchrittFunktion(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SchrittFunktion(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SchrittFunktion(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SchrittFunktion(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SchrittFunktion(sender);
        }
    }
}
