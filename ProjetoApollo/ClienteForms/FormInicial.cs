using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteForms.localhost;
using System.Windows.Forms;

namespace ClienteForms
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
            ListarCliente();
        }

        public void ListarCliente() {
            Cliente c = new Cliente();
            Service1 sv = new Service1();
            listViewClientes.Items.Clear();

            foreach (Cliente clienteLista in sv.ListarCliente(c))
            {
                ListViewItem item = listViewClientes.Items.Add(clienteLista.ClienteID.ToString());
                item.SubItems.Add(clienteLista.ClienteNome);
                item.SubItems.Add(clienteLista.Telefone);
                item.SubItems.Add(clienteLista.Email);
            }
        }

        private void btnTabAgendamentos_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectTab(0);
        }

        private void btnTabClientes_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectTab(1);
            ListarCliente();
        }

        private void btnTabSalas_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectTab(2);
        }

        private void btnTabHorarios_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectTab(3);
        }

        private void btnTabArtistas_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectTab(4);
        }

        private void btnTabInstrumentos_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectTab(5);
        }

        private void btnTabTipos_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectTab(6);
        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormDetalhesCliente formDetalhe = new FormDetalhesCliente();
            formDetalhe.TextBoxID = listViewClientes.SelectedItems[0].SubItems[0].Text;
            formDetalhe.TextBoxNome = listViewClientes.SelectedItems[0].SubItems[1].Text;
            formDetalhe.TextBoxTelefone = listViewClientes.SelectedItems[0].SubItems[2].Text;
            formDetalhe.TextBoxEmail = listViewClientes.SelectedItems[0].SubItems[3].Text;
            formDetalhe.Show();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            FormCadastrarCliente novo = new FormCadastrarCliente();
            novo.ShowDialog();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            FormAlterarCliente editar = new FormAlterarCliente();
            editar.ShowDialog();
        }

        private void listViewClientes_MouseClick(object sender, MouseEventArgs e)
        {
            FormDetalhesCliente formDetalhe = new FormDetalhesCliente();
            formDetalhe.TextBoxID = listViewClientes.SelectedItems[0].SubItems[0].Text;
            formDetalhe.TextBoxNome = listViewClientes.SelectedItems[0].SubItems[1].Text;
            formDetalhe.TextBoxTelefone = listViewClientes.SelectedItems[0].SubItems[2].Text;
            formDetalhe.TextBoxEmail = listViewClientes.SelectedItems[0].SubItems[3].Text;

        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FormDetalhesCliente formDetalhe = new FormDetalhesCliente();
                Cliente cli = new Cliente();
                cli.ClienteID = Int32.Parse(formDetalhe.TextBoxID);
                cli.ClienteNome = formDetalhe.TextBoxNome;
                cli.Telefone = formDetalhe.TextBoxTelefone;
                cli.Email = formDetalhe.TextBoxEmail;

                Service1 sv = new Service1();
                sv.DeletarCliente(cli);

                listViewClientes.Items.RemoveAt(listViewClientes.SelectedIndices[0]);
                MessageBox.Show("Cliente excluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
