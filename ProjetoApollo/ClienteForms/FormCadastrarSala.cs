using ClienteForms.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ClienteForms
{
    public partial class FormCadastrarSala : Form
    {
        public FormCadastrarSala()
        {
            InitializeComponent();
                       
        }        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefoneCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarCadastrarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Sala sala = new Sala();
                sala.SalaNome = txtNomeSala.Text;
                sala.Descricao = txtDescricaoSala.Text;
                sala.Valor = Double.Parse(txtValorSala.Text);

                Service1 sv = new Service1();
                sv.InserirSala(sala);

                MessageBox.Show("Sala Cadastrada com Sucesso.");
                txtDescricaoSala.Clear();
                txtNomeSala.Clear();
                txtValorSala.Clear();
                txtNomeSala.Focus();

                this.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
            

        }
    }
}
