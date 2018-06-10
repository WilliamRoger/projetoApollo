using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteForms.localhost;

namespace ClienteForms
{
    public partial class FormCadastrarCliente : Form
    {
        public FormCadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cli = new Cliente();
                cli.ClienteNome = txtNomeCliente.Text;
                cli.Telefone = txtTelefoneCliente.Text;
                cli.Email = txtEmailCliente.Text;

                Service1 sv = new Service1();
                sv.InserirCliente(cli);
                MessageBox.Show("Cliente cadastrado com sucesso!");

                txtNomeCliente.Clear();
                txtTelefoneCliente.Clear();
                txtEmailCliente.Clear();
                txtNomeCliente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCancelarCadastrarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja cancelar o cadastro?", "Cadastrar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
