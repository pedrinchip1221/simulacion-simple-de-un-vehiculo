using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Automovil auto = new Automovil();
        public Form1()
        {
            InitializeComponent();
            auto.seton_off(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtEstado.Text = "Apagado";
            txtVelocidad.Text = "0";
        }

        private void Apagar()
        {
            auto.seton_off(false);
            txtEstado.Text = "Apagado";
            txtVelocidad.Text = "0";
        }
        private void Encender() 
        { 
        auto.seton_off(true);
            txtEstado.Text = "Encendido";
        }
        private void Acelerar()
        {
            if (auto.geton_off() == false)
            {
                MessageBox.Show("Primero encienda el vehiculo");
            }
            else
            {
                int velocidad;
                if (int.TryParse(txtVelocidad.Text, out velocidad))
                {
                    velocidad += 4;
                    txtVelocidad.Text = velocidad.ToString();
                }
                else
                {
                    MessageBox.Show("El valor ingresado no es válido.");
                }
            }
        }
        private void Desacelerar()
        {
            int velocidad;
            if (auto.geton_off() == false)
            {
                MessageBox.Show("Primero encienda el vehiculo");
            }                       
            else 
            {
                
                if (int.TryParse(txtVelocidad.Text, out velocidad))
                {
                    velocidad -= 4;
                    txtVelocidad.Text = velocidad.ToString();
                }
                else
                {
                    MessageBox.Show("El valor ingresado no es válido.");
                }
            }
        }
        private void Pintura()
        {

            string cont;
            if (cbxPintura.SelectedItem != null)
            {
                cont = cbxPintura.SelectedItem.ToString();
                MessageBox.Show("El color del vehículo cambió a: " + cont);
                auto.setColor(cont);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún color.");
            }
        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            Encender();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Apagar();
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            Acelerar();
        }

        private void btnDesacelerar_Click(object sender, EventArgs e)
        {
            Desacelerar();
        }

        private void txtVelocidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxPintura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            Pintura();
        }
    }
}
