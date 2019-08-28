using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbliva_Click(object sender, EventArgs e)
        {
         

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double iva; 
                double total;
                iva = double.Parse(txtprecio.Text) * 0.19;
                total = double.Parse(txtprecio.Text) + iva;
            lblresultado1.Text = iva.ToString();
            lblresultado2.Text = total.ToString();

        }      

        private void lblresultado1_Click(object sender, EventArgs e)
        {
             
           

           
        }
    }
}
