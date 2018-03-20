using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace garbageCollection
{
    public partial class Form1 : Form
    {
        Elephant Lucinda;
        Elephant Lloyd;

        public Form1()
        {
            InitializeComponent();
            Lucinda = new Elephant() { Name = "Lucinda", EarSize = 55 };
            Lloyd = new Elephant() { Name = "Lloyd", EarSize = 33 };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {

                Elephant Changer; //So if we want to swap references we have create empty object which gonna storage information for a while
                Changer = Lucinda;
                Lucinda = Lloyd;
                Lloyd = Changer;
                MessageBox.Show("Zamienione!");


        }
    }
}
