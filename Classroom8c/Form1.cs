using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classroom8c
{
    public partial class Form1 : Form
    {
        String[] myArray = {"Bob","Steve","Mike","Dave","Sally" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int myInt = Convert.ToInt32(textBox1.Text);

                //string strOne = myArray[myInt];

                MessageBox.Show($"Array selected is " + myArray[myInt]);
            }
            catch(System.FormatException sfe)
            {
                MessageBox.Show("Dude!");
            }

            catch (System.IndexOutOfRangeException ior)
            {
                MessageBox.Show(ior.Message.ToString());
            }
        }
    }
}
