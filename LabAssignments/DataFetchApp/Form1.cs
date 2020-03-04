using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFetchApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int _counter = 0;
        int _retrylimit = 500;

        private void button1_Click(object sender, EventArgs e)
        {

           

            var data = FetchData();



            if (data != null)
            {
                var textData = data.MessageBody;
                var date = data.DataDate;

                var textToDisplay = date + Environment.NewLine + textData;
                MessageBox.Show("Tries before success: " + _counter);

                textBox1.Text = textToDisplay;


            }
            else
            {
                textBox1.Text = "Error fetching data.";
            }

            _counter = 0;
        }



        private Data FetchData()
        {
            var data = FetchMessageData.FetchData();
            

            if (data == null && _counter < _retrylimit)
            {
                _counter++;
                //System.Threading.Thread.Sleep(100);
                textBox1.Text = "retry : + " + _counter;
                textBox1.Refresh();
                //Console.WriteLine("Data was null, trying to fetch data again.");
                data = FetchData();
            }
            else
            {
                MessageBox.Show("Retries has reached maxmium: " + _retrylimit);
            }

            return data;

        }


    }
}
