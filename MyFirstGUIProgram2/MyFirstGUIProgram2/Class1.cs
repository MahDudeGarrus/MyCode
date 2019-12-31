using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGUIProgram2
{
    class Class1
    {

        public void DisFunction(string str, int num)

        {
            MessageBox.Show($"showing: {str} and {num}");
        }





        public void DisFunctionToo(string str, int num, bool ShowAdditonalMessage)

        {
            MessageBox.Show($"showing: {str} and {num}");

            if (ShowAdditonalMessage == true)

            {
                MessageBox.Show($"showing addional message!");
            }
        }
    }
}
