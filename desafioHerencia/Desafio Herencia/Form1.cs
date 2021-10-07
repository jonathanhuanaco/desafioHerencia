using Desafio_Herencia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Herencia
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        public Form1()
        {
            InitializeComponent();
            form1 = this;
        }

        private void radioPiso_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPisoNro.Enabled = true;
            textBoxNroDeVentanas.Enabled = false;
        }

        private void radioLocal_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNroDeVentanas.Enabled = true;
            textBoxPisoNro.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // PISO

            try
            {
                if (textBoxPisoNro.Enabled)
                {

                    Piso piso = new Piso(textBoxDireccion.Text, int.Parse(textBoxSuperficie.Text), int.Parse(textBoxAntiguedad.Text), float.Parse(textBoxPrecioBase.Text), int.Parse(textBoxPisoNro.Text));

                    lblPrecio.Text = string.Format("El precio final del Piso es: {0}", piso.CalcularDescuentos());

                }
                else
                {
                    Local local = new Local(textBoxDireccion.Text, int.Parse(textBoxSuperficie.Text), int.Parse(textBoxAntiguedad.Text), float.Parse(textBoxPrecioBase.Text), int.Parse(textBoxNroDeVentanas.Text));
                    lblPrecio.Text = string.Format("El precio final del Piso es: {0}", local.CalcularDescuentos());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan Datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
