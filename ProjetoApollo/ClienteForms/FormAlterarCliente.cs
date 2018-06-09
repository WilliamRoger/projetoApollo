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

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cli = new Cliente();
                cli.ClienteID = Int32.Parse(txtIDCliente.Text);
                cli.ClienteNome = txtNomeCliente.Text;
                cli.Telefone = txtTelefoneCliente.Text;
                cli.Email = txtEmailCliente.Text;

                FormInicial form = new FormInicial();
                //FormDetalhesCliente detalhes = new FormDetalhesCliente();
                form.listViewClientes.SelectedItems[0].Text = txtIDCliente.Text;
                form.listViewClientes.SelectedItems[1].Text = txtTelefoneCliente.Text;
                form.listViewClientes.SelectedItems[3].Text = txtEmailCliente.Text;

                Service1 sv = new Service1();
                sv.AlterarCliente(cli);
                MessageBox.Show("Alterado com sucesso!");
                txtIDCliente.Clear();
                txtNomeCliente.Clear();
                txtTelefoneCliente.Clear();
                txtEmailCliente.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
