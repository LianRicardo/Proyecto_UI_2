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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            celda w = new celda(); ;
            w.createcell();
            
        }
    }
}

class celda
{ 
    public int x;
    public int y;
    public PictureBox g;
    public int n_celdas;

    public celda()
    {

    }

    ~celda()
    {
        x = 0;
        y = 0;
        g = null;
        n_celdas = 0;
    }
    public void createcell()
    {
        int j = 0;
        int i = 0;
        j = 10;
        for (i = 0; i < j; i++)
        {
            celda ncelda = new celda();
            ncelda.n_celdas++;
            ncelda.x = ncelda.n_celdas;
            ncelda.y = ncelda.n_celdas;
        }
    }
};

/*   private void Form2_Load(object sender, EventArgs e)
       {
            private celda[] tablero = new celda[] { };
            int i = 0;
            int j = 10;
            for(i=0; i < j; i++)
            {
                celda ncelda = new celda();
                ncelda.n_celdas ++
                ncelda.x = ncelda.n_celdas += 1;
                ncelda.y = ncelda.nceldas -= 1;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}

class celda
{
    int x;
    int y;
    PictureBox g;
    int n_celdas;

    celda ()
    {
    x=0;
    y=0;
    g=null;
    n_celdas=0;
    }

    ~celda()
    {
    g.close();
    delete celda
}*/