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
    public partial class Form2 : Form
    {
        public int i, a, o = 0, e = 0, u = 0, d;
        Form1 f1 = new Form1();

        public Form2(int i, int a)
        {
            this.i = i;
            this.a = a;
            InitializeComponent();
            this.Size = new Size((i * 25) + 50, (a * 25) + 50);
            Crearboton();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        public void Crearboton()
        {


            while (u < a)
            {
                for (d = 0; d < i; d++)
                {
                    Button boton = new Button();
                    boton.Location = new Point((25 + o), (25 + e));
                    boton.Size = new Size(25, 25);
                    Controls.Add(boton);
                    boton.Visible = true;
                    o = o + 25;
                }
                u++;
                e = e + 25;
                o = 0;
            }
        }
    }
}
