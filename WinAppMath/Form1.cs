using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMath
{
    public partial class Form1 : Form
    {
        double respuesta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxNumero.Focus();
            labelRespuesta.Visible = false;
            labelNota.Visible = false;
            textBoxNumero2.Visible = false;
            labelNumero2.Visible = false;
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (textBoxNumero.Text.Length == 0)
                {
                    MessageBox.Show("No se ha ingresado un número", "Número no ingresado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBoxOperaciones.Focus();
                }
            }
            Validar.validar(e);
        }

        private void comboBoxOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOperaciones.SelectedIndex == 0)
            {
                respuesta = Math.Abs(double.Parse(textBoxNumero.Text));
                respuesta = Math.Round(respuesta, 3);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 1)
            {
                if (double.Parse(textBoxNumero.Text) <= 1 && double.Parse(textBoxNumero.Text) >= -1)
                {
                    respuesta = Math.Acos(double.Parse(textBoxNumero.Text));
                    respuesta = Math.Round(respuesta, 3);
                    labelRespuesta.Text = respuesta.ToString();
                    labelRespuesta.Visible = true;
                }
                else
                {
                    textBoxNumero.Focus();
                    MessageBox.Show("Debe ingresar un número entre -1 y 1", "Valores errados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxOperaciones.SelectedIndex == 2)
            {
                if (double.Parse(textBoxNumero.Text) <= 1 && double.Parse(textBoxNumero.Text) >= -1)
                {
                    respuesta = Math.Asin(double.Parse(textBoxNumero.Text));
                    respuesta = Math.Round(respuesta, 3);
                    labelRespuesta.Text = respuesta.ToString();
                    labelRespuesta.Visible = true;
                }
                else
                {
                    textBoxNumero.Focus();
                    MessageBox.Show("Debe ingresar un número entre -1 y 1", "Valores errados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxOperaciones.SelectedIndex == 3)
            {
                respuesta = Math.Atan(double.Parse(textBoxNumero.Text));
                respuesta = Math.Round(respuesta, 3);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 4)
            {
                MessageBox.Show("Ingrese otro número y seleccione la opción de Multiplicar nuevamente", "Ingrese otro número", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelNumero2.Visible = true;
                textBoxNumero2.Visible = true;
                textBoxNumero2.Focus();
                int numero1 = Convert.ToInt32(double.Parse(textBoxNumero.Text));
                int numero2 = Convert.ToInt32(double.Parse(textBoxNumero2.Text));
                respuesta = Math.BigMul(numero1, numero2);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
                labelNota.Text = "Para la operación BigMul se utilizará solo el entero del número ingresado";
                labelNota.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 5)
            {
                respuesta = Math.Ceiling(double.Parse(textBoxNumero.Text));
                respuesta = Math.Round(respuesta, 3);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 6)
            {
                respuesta = Math.Cos(double.Parse(textBoxNumero.Text));
                respuesta = Math.Round(respuesta, 3);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
                labelNota.Text = "Para la operación Cos se entenderá el valor ingresado en radianes";
                labelNota.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 7)
            {
                respuesta = Math.Cosh(double.Parse(textBoxNumero.Text));
                respuesta = Math.Round(respuesta, 3);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
                labelNota.Text = "Para la operación Cosh se entenderá el valor ingresado en radianes";
                labelNota.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 8)
            {
                MessageBox.Show("Ingrese otro número y seleccione la opción DivRem nuevamente", "Ingrese otro número", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelNumero2.Visible = true;
                textBoxNumero2.Visible = true;
                textBoxNumero2.Focus();
                int numero1 = Convert.ToInt32(double.Parse(textBoxNumero.Text));
                int numero2 = Convert.ToInt32(double.Parse(textBoxNumero2.Text));
                if (numero2 == 0)
                {
                    MessageBox.Show("No existe división para cero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Math.DivRem(numero1, numero2, out int respuesta);
                }

                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
                labelNota.Text = "Para la operación DivRem se utilizará solo el entero del número ingresado";
                labelNota.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 9)
            {
                respuesta = Math.Exp(double.Parse(textBoxNumero.Text));
                respuesta = Math.Round(respuesta, 3);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 10)
            {
                respuesta = Math.Floor(double.Parse(textBoxNumero.Text));
                respuesta = Math.Round(respuesta, 3);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 11)
            {
                MessageBox.Show("Ingrese otro número y seleccione la opción IEEE Remainder nuevamente", "Ingrese otro número", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelNumero2.Visible = true;
                textBoxNumero2.Visible = true;
                textBoxNumero2.Focus();
                double numero1 = double.Parse(textBoxNumero.Text);
                double numero2 = double.Parse(textBoxNumero2.Text);
                if (numero2 == 0)
                {
                    MessageBox.Show("No existe división para cero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    respuesta = Math.IEEERemainder(numero1, numero2);
                }

                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 12)
            {
                if (double.Parse(textBoxNumero.Text) >= 0)
                {
                    respuesta = Math.Log(double.Parse(textBoxNumero.Text));
                    respuesta = Math.Round(respuesta, 3);
                    labelRespuesta.Text = respuesta.ToString();
                    labelRespuesta.Visible = true;
                }
                else
                {
                    MessageBox.Show("No existen logaritmos naturales de números negativos", "Operación errónea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxOperaciones.SelectedIndex == 13)
            {
                if (double.Parse(textBoxNumero.Text) >= 0)
                {
                    respuesta = Math.Log10(double.Parse(textBoxNumero.Text));
                    respuesta = Math.Round(respuesta, 3);
                    labelRespuesta.Text = respuesta.ToString();
                    labelRespuesta.Visible = true;
                }
                else
                {
                    MessageBox.Show("No existen logaritmos naturales de números negativos", "Operación errónea", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBoxOperaciones.SelectedIndex == 14)
            {
                MessageBox.Show("Ingrese otro número y seleccione la opción de Máximo nuevamente", "Ingrese otro número", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelNumero2.Visible = true;
                textBoxNumero2.Visible = true;
                textBoxNumero2.Focus();
                double numero1 = double.Parse(textBoxNumero.Text);
                double numero2 = double.Parse(textBoxNumero2.Text);
                respuesta = Math.Max(numero1, numero2);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 15)
            {
                MessageBox.Show("Ingrese otro número y seleccione la opción de Mínimo nuevamente", "Ingrese otro número", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelNumero2.Visible = true;
                textBoxNumero2.Visible = true;
                textBoxNumero2.Focus();
                double numero1 = double.Parse(textBoxNumero.Text);
                double numero2 = double.Parse(textBoxNumero2.Text);
                respuesta = Math.Min(numero1, numero2);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 16)
            {
                MessageBox.Show("Ingrese otro número y seleccione la opción de Potencia nuevamente", "Ingrese otro número", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelNumero2.Visible = true;
                textBoxNumero2.Visible = true;
                textBoxNumero2.Focus();
                double numero1 = double.Parse(textBoxNumero.Text);
                double numero2 = double.Parse(textBoxNumero2.Text);
                respuesta = Math.Pow(numero1, numero2);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 17)
            {
                labelNumero2.Visible = true;
                double numero1 = double.Parse(textBoxNumero.Text);
                respuesta = Math.Round(numero1);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 18)
            {
                labelNumero2.Visible = true;
                double numero1 = double.Parse(textBoxNumero.Text);
                respuesta = Math.Sign(numero1);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 19)
            {
                labelNumero2.Visible = true;
                double numero1 = double.Parse(textBoxNumero.Text);
                respuesta = Math.Sin(numero1);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 20)
            {
                labelNumero2.Visible = true;
                double numero1 = double.Parse(textBoxNumero.Text);
                respuesta = Math.Sinh(numero1);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 21)
            {
                labelNumero2.Visible = true;
                double numero1 = double.Parse(textBoxNumero.Text);
                if (numero1 < 0)
                {
                    MessageBox.Show("No existen raices de números negativos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    respuesta = Math.Sign(numero1);
                    labelRespuesta.Text = respuesta.ToString();
                    labelRespuesta.Visible = true;
                }
            }
            else if (comboBoxOperaciones.SelectedIndex == 22)
            {
                labelNumero2.Visible = true;
                double numero1 = double.Parse(textBoxNumero.Text);
                respuesta = Math.Tan(numero1);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
            else if (comboBoxOperaciones.SelectedIndex == 23)
            {
                labelNumero2.Visible = true;
                double numero1 = double.Parse(textBoxNumero.Text);
                respuesta = Math.Tanh(numero1);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
            else
            {
                labelNumero2.Visible = true;
                double numero1 = double.Parse(textBoxNumero.Text);
                respuesta = Math.Truncate(numero1);
                labelRespuesta.Text = respuesta.ToString();
                labelRespuesta.Visible = true;
            }
        }

        private void textBoxNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (textBoxNumero.Text.Length == 0)
                {
                    MessageBox.Show("No se ha ingresado un número", "Número no ingresado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    comboBoxOperaciones.Focus();
                }
            }
            Validar.validar(e);
        }
    }
}