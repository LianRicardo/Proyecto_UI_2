using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_UI_2
{
    public partial class Form1 : Form
    {
        public int i, a;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(numericUpDown1.Value);
            a = Convert.ToInt32(numericUpDown2.Value);
            if (i != 0)
            {
                if (a != 0)
                {
                    Form2 f2 = new Form2(i, a);
                    f2.Show();
                }
                else
                {
                    MessageBox.Show("El valor de ser diferente de 0");
                }
            }
            else
            {
                MessageBox.Show("El valor de ser diferente de 0");
            }
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
