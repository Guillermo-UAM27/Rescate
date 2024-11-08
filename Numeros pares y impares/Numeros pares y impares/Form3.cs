using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_pares_y_impares
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 numeros=new Form1();
            numeros.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 numeros=new Form2();
            numeros.ShowDialog();
        }
    }
}
