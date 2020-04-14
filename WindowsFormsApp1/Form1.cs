using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        double resultado;
        string operacion;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            this.txtPantalla.Focus();
            this.btnBorrar.Enabled = false; 
            this.btnIgual.Enabled = false;

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Text = this.txtPantalla.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Text = this.txtPantalla.Text + ".";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Text = this.txtPantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Text = this.txtPantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Text = this.txtPantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Text = this.txtPantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Text = this.txtPantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Text = this.txtPantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Text = this.txtPantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Text = this.txtPantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Text = this.txtPantalla.Text + "9";
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.txtPantalla.Text = txtPantalla.Text.Substring(0, this.txtPantalla.Text.Count() - 1);
        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPantalla.Text != "")
            {
                this.btnBorrar.Enabled = true;
                this.btnIgual.Enabled = true;
            }
            else
            {
                this.btnIgual.Enabled = false;
                this.btnBorrar.Enabled = false;
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = Convert.ToDouble(this.txtPantalla.Text);
            this.txtPantalla.Clear();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = Convert.ToDouble(this.txtPantalla.Text);
            this.txtPantalla.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = Convert.ToDouble(this.txtPantalla.Text);
            this.txtPantalla.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = Convert.ToDouble(this.txtPantalla.Text);
            this.txtPantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = Convert.ToDouble(this.txtPantalla.Text);

            switch (operacion)
            {
                case "+":
                    resultado = primero + segundo;
                    this.txtPantalla.Text = Convert.ToString(resultado);
                    break;

                case "-":
                    resultado = primero - segundo;
                    this.txtPantalla.Text = Convert.ToString(resultado);
                    break;

                case "*":
                    resultado = primero * segundo;
                    this.txtPantalla.Text = Convert.ToString(resultado);
                    break;

                case "/":
                    resultado = primero / segundo;
                    this.txtPantalla.Text = Convert.ToString(resultado);
                    break;
            }
        }
    }
}
