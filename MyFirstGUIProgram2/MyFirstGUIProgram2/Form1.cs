using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstGUIProgram2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Choice of color with button to display a message box.

        private void btn1_Click(object sender, EventArgs e)
        {

            if (rdbRed.Checked == true)
            {
                MessageBox.Show("You chose Red.");
            }

            if (rdbBlue.Checked == true)
            {
                MessageBox.Show("You chose Blue.");
            }

            if (rdbGreen.Checked == true)
            {
                MessageBox.Show("You chose Green.");
            }

            if (rdbYellow.Checked == true)
            {
                MessageBox.Show("You chose Yellow.");
            }

            if (rdbOrange.Checked == true)
            {
                MessageBox.Show("You chose Orange.");

            }

            if (rdbPurple.Checked == true)
            {
                MessageBox.Show("You chose Purple.");
            }

            if (rdbPink.Checked == true)
            {
                MessageBox.Show("You chose Pink.");
            }

            if (rdbBlack.Checked == true)
            {
                MessageBox.Show("You chose Black.");
            }
        }

        // PLacement of House Buttons are here. Just for fun.
        private void Button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("You have been placed in Gryffindor House.");

        }

        private void btnSly_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been placed in Slytherin House.");
        }

        private void btnHuff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been placed in Hufflepuff House.");
        }

        private void btnRave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been placed in Ravenclaw House.");
        }




        // This is an example of how to display 
        // text in a text box using buttons, 
        // radio buttons and another text box.
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }



        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (rdb1.Checked)
            {
                textBox2.Text = textBox1.Text;
            }

            if (rdb5.Checked)
            {
                for (int i = 0; i < 5; i++)

                {
                    textBox2.Text = textBox2.Text + textBox1.Text + Environment.NewLine;
                }
            }

            if (rdb10.Checked)
            {
                for (int i = 0; i < 10; i++)
                {
                    textBox2.Text = textBox2.Text + textBox1.Text + Environment.NewLine;
                }
            }
        }
    }   
}
