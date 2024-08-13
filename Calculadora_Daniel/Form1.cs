using System.ComponentModel;

namespace Calculadora_Daniel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textOperador.Text += "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textOperador.Text += "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {

            textOperador.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string operacion = textOperador.Text;
            try
            {

                double resultado = EvaluarExpresion(operacion);
                textResultado.Text = resultado.ToString();
                textOperador.Text = resultado.ToString();
                listHistorial.Items.Add(textResultado.Text);
            }
            catch (Exception ex)
            {
                textResultado.Text = "Error" + ex.Message;
            }
        }


        private static double EvaluarExpresion(string expresion)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expresion, ""));
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //boton limpiar
            textOperador.Text = "";
            textResultado.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textOperador.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textOperador.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textOperador.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textOperador.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textOperador.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textOperador.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textOperador.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textOperador.Text += "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //boton -
            textOperador.Text += "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //boton /

            textOperador.Text += "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //boton *

            textOperador.Text += "*";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textOperador.Text) && !string.IsNullOrEmpty(textResultado.Text))
            {
                decimal numero1 = Convert.ToDecimal(textOperador.Text);
                decimal numero2 = Convert.ToDecimal(textResultado.Text);

                Decimal resultadoMod = numero1 % numero2;
                textResultado.Text = resultadoMod.ToString();
                listHistorial.Items.Add(textResultado.Text);

                textOperador.Text = "";
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (textOperador.Text.Length > 0)
            {
                textOperador.Text = textOperador.Text.Remove(textOperador.Text.Length - 1);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textResultado.Text))
            {
                decimal numero = Convert.ToDecimal(textResultado.Text);
                decimal resultadoRaiz = (decimal)Math.Pow((double)numero, 2);

                textResultado.Text = resultadoRaiz.ToString();
                textOperador.Text = resultadoRaiz.ToString();
                listHistorial.Items.Add(textResultado.Text);
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            textOperador.Text += "(";
        }

        private void buttonParentesisRight_Click(object sender, EventArgs e)
        {
            textOperador.Text += ")";
        }

        private void listHistorial_SelectedIndexChanged(object sender, EventArgs e)
        {
            listHistorial.Items.Add(textResultado.Text);
        }

        private void buttonClearHistorial_Click(object sender, EventArgs e)
        {
            listHistorial.Items.Clear();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            //boton +
            textOperador.Text += "+";
        }

        private void botonRaiz_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textResultado.Text))
            {
                decimal numero = Convert.ToDecimal(textResultado.Text);
                decimal resultadoRaiz = (decimal)Math.Sqrt((double)numero);

                textResultado.Text = resultadoRaiz.ToString();
                textOperador.Text = resultadoRaiz.ToString();
                listHistorial.Items.Add(textResultado.Text);
            }
        }
    }
}

