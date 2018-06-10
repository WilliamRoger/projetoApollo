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
            //ListaInstrumento();
            ListarSala();
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

        public void ListaInstrumento()
        {
            Instrumento instrumento = new Instrumento();
            Service1 service = new Service1();
            listViewInstrumentos.Items.Clear();

            foreach (Instrumento listaInstrumento in service.ListarInstrumento(instrumento))
            {
                ListViewItem item = listViewInstrumentos.Items.Add(listaInstrumento.InstrumentoID.ToString());
                item.SubItems.Add(listaInstrumento.Nome);
                item.SubItems.Add(listaInstrumento.Valor.ToString());
                item.SubItems.Add(listaInstrumento.TipoID.ToString());
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
            ListaInstrumento();
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

       
        private void btnNovoInstrumento_Click(object sender, EventArgs e)
        {
            FormCadastrarInstrumento formCadastrarInstrumento = new FormCadastrarInstrumento();
            formCadastrarInstrumento.ShowDialog();
        }

        private void btnExcluirInstrumento_Click(object sender, EventArgs e)
        {
            try
            {
                Instrumento instrumento = new Instrumento();
                instrumento.InstrumentoID = Int32.Parse(listViewInstrumentos.SelectedItems[0].SubItems[0].Text);
                Service1 service = new Service1();
                if (MessageBox.Show("Tem certeza que deseja excluir esse instrumento?", "Excluir Instrumento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    service.DeletarInstrumento(instrumento);
                }
                MessageBox.Show("Instrumento excluido com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarInstrumento_Click(object sender, EventArgs e)
        {
            FormAlterarInstrumento editar = new FormAlterarInstrumento();
            editar.TextBoxID = listViewInstrumentos.SelectedItems[0].SubItems[0].Text;
            editar.TextBoxNome = listViewInstrumentos.SelectedItems[0].SubItems[1].Text;
            editar.TextBoxValor = listViewInstrumentos.SelectedItems[0].SubItems[2].Text;
            editar.TextBoxTipo = listViewInstrumentos.SelectedItems[0].SubItems[3].Text;
            editar.ShowDialog();
        }

        
        private void btnNovaSala_Click_2(object sender, EventArgs e)
        {
            FormCadastrarSala formCadastrarSala = new FormCadastrarSala();
            formCadastrarSala.ShowDialog();            
            ListarSala();
            
        }

        private void btnExcluirSala_Click(object sender, EventArgs e)
        {
            try
            {
                Sala sala = new Sala();
                sala.SalaID = Int32.Parse(listViewSala.SelectedItems[0].SubItems[0].Text);

                Service1 service = new Service1();
                if (MessageBox.Show("Tem certeza que deseja excluir esta sala?", "Excluir Sala", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    service.DeletarSala(sala);
                }

                MessageBox.Show("Sala deletada com sucesso!");
                ListarSala();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnEditarSala_Click(object sender, EventArgs e)
        {

        }
    }
}
