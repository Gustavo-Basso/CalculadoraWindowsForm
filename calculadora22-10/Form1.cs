using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora22_10 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        double valor = 0;
        double valor2 = 0;
        string operacao = "";

        private void button12_Click(object sender, EventArgs e) {
            textResult.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e) {
            textResult.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e) {
            textResult.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e) {
            textResult.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e) {
            textResult.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e) {
            textResult.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e) {
            textResult.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e) {
            textResult.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e) {
            textResult.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e) {
            textResult.Text += "0";
        }

        private void button14_Click(object sender, EventArgs e) {
            textResult.Text = "";

        }

        private void button4_Click(object sender, EventArgs e) {
            if (textResult.Text != "") {
                valor = double.Parse(textResult.Text, CultureInfo.InvariantCulture);
                textResult.Text = "";
                operacao = "SOMA";
                IBLoperator.Text = "+";
            }
        }

        private void textResult_TextChanged(object sender, EventArgs e) {

        }

        private void button17_Click(object sender, EventArgs e) {
            valor2 = double.Parse(textResult.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA") {
                double soma = valor + valor2;
                textResult.Text = soma.ToString(CultureInfo.InvariantCulture);
                IBLoperator.Text = "=";
            }
            else if (operacao == "MENOS") {
                double menos = valor - valor2;
                textResult.Text = menos.ToString(CultureInfo.InvariantCulture);
                IBLoperator.Text = "=";
            }
            else if (operacao == "MULT") {
                double mult = valor * valor2;
                textResult.Text = mult.ToString(CultureInfo.InvariantCulture);
                IBLoperator.Text = "=";
            }
            else if (operacao == "DIV") {
                double div = valor / valor2;
                textResult.Text = div.ToString(CultureInfo.InvariantCulture);
                IBLoperator.Text = "=";
            }
            else {
                double pot = Math.Pow(valor, valor2);
                textResult.Text = pot.ToString(CultureInfo.InvariantCulture);
                IBLoperator.Text = "=";
            }


        }

        private void button5_Click(object sender, EventArgs e) {
            if (textResult.Text != "") {
                valor = double.Parse(textResult.Text, CultureInfo.InvariantCulture);
                textResult.Text = "";
                operacao = "MENOS";
                IBLoperator.Text = "-";
            }
        }

        private void button9_Click(object sender, EventArgs e) {
            if (textResult.Text != "") {
                valor = double.Parse(textResult.Text, CultureInfo.InvariantCulture);
                textResult.Text = "";
                operacao = "MULT";
                IBLoperator.Text = "*";
            }
        }

        private void button18_Click(object sender, EventArgs e) {
            textResult.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e) {
            if (textResult.Text != "") {
                valor = double.Parse(textResult.Text, CultureInfo.InvariantCulture);
                textResult.Text = "";
                operacao = "DIV";
                IBLoperator.Text = "/";
            }
        }

        private void button16_Click(object sender, EventArgs e) {
            if (textResult.Text != "") {
                valor = double.Parse(textResult.Text, CultureInfo.InvariantCulture);
                textResult.Text = "";
                operacao = "POT";
                IBLoperator.Text = "Pot";
            }
        }

        private void iblop_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button19_Click(object sender, EventArgs e) {
            textResult.Text = "";
            valor = 0;
            valor2 = 0;
            IBLoperator.Text = "";
        }
    }
}
