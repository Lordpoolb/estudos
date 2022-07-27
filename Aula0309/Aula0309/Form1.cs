using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula0309
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string nomeCliente = txtNomeCliente.Text;
            string marcaveiculo = txtMarcaCarro.Text;
            string modeloVeiculo = txtModeloCarro.Text;
            string placaVeiculo = txtPlaca.Text;
            string periodo = "";
            if (chkManha.Checked && chkTarde.Checked && chkNoite.Checked) 
                periodo = "TOTAL";      
            else
            {
                if (chkManha.Checked)               
                    periodo += " Manhã,";               
                if (chkTarde.Checked)                
                    periodo += " Tarde,";                
                if (chkNoite.Checked)                
                    periodo += "Noite.";
                 }
            string formaPgto;

            if (pgPix.Checked)

                formaPgto = "PIX";
            else if (pgCartao.Checked)
                formaPgto = "Cartão";
            else
                formaPgto = "Dinheiro";

            MessageBox.Show("Codigo: " + codigo
                + "\nNome Cliente: " + nomeCliente
                + "\nMarca Veiculo " + marcaveiculo
                + "\nModelo Veiculo: " + modeloVeiculo
                +"\nPlaca Veiculo: " + placaVeiculo
                +"\nForma de Pagamento: " + formaPgto
                +"\nPeríodo: "+periodo,
                "Reserva efetuada com sucesso!!");
          


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pgPix_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
