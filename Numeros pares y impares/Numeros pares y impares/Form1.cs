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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            lbPares.Items.Clear();
            lbImpares.Items.Clear();

            try
            {
               
                string input = TbNumeros.Text;

                
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Por favor ingrese algunos números.");
                    return;
                }

                
                string[] numerosArray = input.Split(new[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                List<int> numeros = new List<int>();

                
                foreach (var numeroStr in numerosArray)
                {
                    if (int.TryParse(numeroStr.Trim(), out int numero))
                    {
                        numeros.Add(numero);
                    }
                    else
                    {
                        MessageBox.Show($"El valor '{numeroStr.Trim()}' no es un número válido.");
                        return;
                    }
                }

                Numeros numeroObj = new Numeros();
                
                numeroObj.ProcesarNumeros(numeros);

               
                foreach (var numero in numeroObj.Pares)
                {
                    lbPares.Items.Add(numero);
                }

                foreach (var numero in numeroObj.Impares)
                {
                    lbImpares.Items.Add(numero);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }

}


