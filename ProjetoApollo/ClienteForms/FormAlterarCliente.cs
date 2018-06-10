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
    public partial class FormAlterarCliente : Form
    {
        public FormAlterarCliente()
        {
            InitializeComponent();
        }

        public string TextBoxID
        {
            get { return txtIDCliente.Text; }
            set { txtIDCliente.Text = value; }
        }

        public string TextBoxNome
        {
            get { return txtNomeCliente.Text; }
            set { txtNomeCliente.Text = value; }
        }

        public string TextBoxTelefone
        {
            get { return txtTelefoneCliente.Text; }
            set { txtTelefoneCliente.Text = value; }
        }

        public string TextBoxEmail
        {
            get { return txtEmailCliente.Text; }
            set { txtEmailCliente.Text = value; }
        }

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.ClienteID = Int32.Parse(txtIDCliente.Text);
                cliente.ClienteNome = txtNomeCliente.Text;
                cliente.Telefone = txtTelefoneCliente.Text;
                cliente.Email = txtEmailCliente.Text;

                Service1 service = new Service1();
                service.AlterarCliente(cliente);
                MessageBox.Show("Cliente alterado com sucesso!");

                txtIDCliente.Clear();
                txtNomeCliente.Clear();
                txtTelefoneCliente.Clear();
                txtEmailCliente.Clear();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Cliente! " + ex.Message);
            }
        }

        private void btnCancelarAlterarCliente_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você tem certeza que deseja cancelar a edição?", "Alterar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
