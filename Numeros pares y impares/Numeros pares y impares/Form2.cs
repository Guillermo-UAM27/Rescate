using Numeros_pares_y_impares.Nombres;
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
    public partial class Form2 : Form
    {
        Nom nombreObj = new Nom();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnAgg_Click(object sender, EventArgs e)
        {
            lbNombres.Items.Clear();
            lbOtros.Items.Clear();

            try
            {
               
                string input = tbNombre.Text;

               
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Por favor ingrese los nombres.");
                    return;
                }

               
                List<string> nombres = new List<string>();
                var nombresArray = input.Split(new[] { ',', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var nombre in nombresArray)
                {
                    var nombreTrimmed = nombre.Trim();
                   
                    if (nombreTrimmed.Length >= 10 && nombreTrimmed.Length <= 60)
                    {
                        nombres.Add(nombreTrimmed);
                    }
                    else
                    {
                        MessageBox.Show($"El nombre '{nombreTrimmed}' no tiene entre 10 y 60 caracteres.");
                        return;
                    }
                }


               
                
                nombreObj.ProcesarNombres(nombres);

              
                foreach (var nombre in nombreObj.NombresConJ)
                {
                    lbNombres.Items.Add(nombre);
                }

              
                foreach (var nombre in nombreObj.OtrosNombres)
                {
                    lbOtros.Items.Add(nombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

