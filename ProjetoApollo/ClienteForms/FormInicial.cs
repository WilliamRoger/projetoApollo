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
            Cliente cliente = new Cliente();
            Service1 service = new Service1();
            listViewClientes.Items.Clear();

            foreach (Cliente clienteLista in service.ListarCliente(cliente))
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

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            FormCadastrarCliente novo = new FormCadastrarCliente();
            novo.ShowDialog();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            FormAlterarCliente editar = new FormAlterarCliente();
            editar.TextBoxID = listViewClientes.SelectedItems[0].SubItems[0].Text;
            editar.TextBoxNome = listViewClientes.SelectedItems[0].SubItems[1].Text;
            editar.TextBoxTelefone = listViewClientes.SelectedItems[0].SubItems[2].Text;
            editar.TextBoxEmail = listViewClientes.SelectedItems[0].SubItems[3].Text;
            editar.ShowDialog();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.ClienteID = Int32.Parse(listViewClientes.SelectedItems[0].SubItems[0].Text);
      
                Service1 service = new Service1();
                if (MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Excluir Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    service.DeletarCliente(cliente);
                }

                MessageBox.Show("Cliente excluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
