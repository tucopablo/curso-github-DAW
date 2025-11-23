using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicoTelegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textoTelegrama;//añado coñentarios
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;
            textoTelegrama = txtTelegrama.Text;
            string[] palabras = textoTelegrama.Split(' '); //separa las palabras y las introduce en una estructura
                                                           //Leo el telegrama
                                                           // telegrama urgente?
            if (chkUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            if (checkOrdinario.Checked)
            {
                tipoTelegrama = 'o';
            }
            //Obtengo el número de palabras que forma el telegrama
            //numPalabras = textoTelegrama.Length;
            numPalabras = palabras.Length;
            //Si el telegrama es ordinario
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 3;//modif para el ejercicio 3-1
                }
                else
                {
                    coste = 0.55 * numPalabras;//modif para el ejercicio 3-1
                }
            }
            else
            //Si el telegrama es urgente
            {
                if (tipoTelegrama == 'u')
                {
                    if (numPalabras <= 10)
                    {
                        coste = 6;
                    }
                    else
                    {
                        coste = 5 + 0.75 * (numPalabras - 10);
                    }
                }
                else
                {
                    coste = 0;
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void checkOrdinario_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOrdinario.Checked)
                chkUrgente.Checked = false;
        }

        private void chkUrgente_CheckedChanged(object sender, EventArgs e)
        {
            if(chkUrgente.Checked)
                checkOrdinario.Checked = false;
        }
    }

    
}
