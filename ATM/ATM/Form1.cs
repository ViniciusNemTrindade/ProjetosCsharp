using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {

        } 
       
        private void btnSaque_Click(object sender, EventArgs e)
        {

        }
        private void btnSaldo_Click(object sender, EventArgs e)
        {

        }
        private void btnEmprestimo_Click(object sender, EventArgs e)
        {

        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }
        private void lblEmprestimo_Click(object sender, EventArgs e)
        {

        }  
        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void lblSaque_Click(object sender, EventArgs e)
        {

        }

        private void lblDeposito_Click(object sender, EventArgs e)
        {

        }

        private void btn00_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text + "0";
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text + "1";
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text + "2";
        }
        private void btn03_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text + "3";
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text + "4";
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text + "5";
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text + "6";
        }
         private void btn07_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text + "7";
        }
        private void btn08_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text + "8";
        }
        private void btn09_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text + "9";
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void btnBranco_Click(object sender, EventArgs e)
        {

        }

        private void btnMais_Click(object sender, EventArgs e)
        {

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult aSair;

            aSair = MessageBox.Show("Cofirme para sair", "Sistema ATM", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (aSair == DialogResult.Yes) 
            {
                Application.Exit();    
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            lblDisplay.Text = "";
        }
    }
}
