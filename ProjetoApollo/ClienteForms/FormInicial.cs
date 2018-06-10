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
            ListarTipo();
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

        public void ListarSala()
        {
            Sala sala = new Sala();
            Service1 service1 = new Service1();
            listViewSala.Items.Clear();

            foreach (Sala listarsala in service1.ListarSala(sala))
            {
                ListViewItem item = listViewSala.Items.Add(listarsala.SalaID.ToString());
                item.SubItems.Add(listarsala.SalaNome);
                item.SubItems.Add(listarsala.Descricao);
                item.SubItems.Add(listarsala.Valor.ToString());
            }

        }

        public void ListarTipo()
        {
            Tipo tipo = new Tipo();
            Service1 service = new Service1();
            listViewTipos.Items.Clear();

            foreach(Tipo tipoLista in service.ListarTipo(tipo))
            {
                ListViewItem item = listViewTipos.Items.Add(tipoLista.TipoID.ToString());
                item.SubItems.Add(tipoLista.Nome);
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
            ListarSala();
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
            ListarTipo();
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

        private void btnNovaSala_Click(object sender, EventArgs e)
        {
            FormCadastrarSala formCadastrarSala = new FormCadastrarSala();
            formCadastrarSala.Show();
       
        }

        private void btnNovoTipo_Click(object sender, EventArgs e)
        {
            FormCadastrarTipo formCadastrarTipo = new FormCadastrarTipo();
            formCadastrarTipo.Show();
        }

        private void btnEditarTipo_Click(object sender, EventArgs e)
        {
            FormAlterarTipo editar = new FormAlterarTipo();
            editar.TextBoxID = listViewTipos.SelectedItems[0].SubItems[0].Text;
            editar.TextBoxNome = listViewTipos.SelectedItems[0].SubItems[1].Text;
            editar.Show();
        }

        private void btnExcluirTipo_Click(object sender, EventArgs e)
        {
            try
            {
                Tipo tipo = new Tipo();
                tipo.TipoID = Int32.Parse(listViewTipos.SelectedItems[0].SubItems[0].Text);

                Service1 service = new Service1();
                if (MessageBox.Show("Tem certeza que deseja excluir este Tipo?", "Excluir Tipo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    service.DeletarTipo(tipo);
                }

                MessageBox.Show("Tipo excluido com sucesso!");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao excluir Tipo! " + exception.Message);
            }
        }
    }
}
