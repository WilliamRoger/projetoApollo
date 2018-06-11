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
            Tipo tipo = new Tipo();
            Service1 service = new Service1();
            listViewInstrumentos.Items.Clear();

            foreach (Instrumento listaInstrumento in service.ListarInstrumento(instrumento))
            {
                ListViewItem item = listViewInstrumentos.Items.Add(listaInstrumento.InstrumentoID.ToString());
                item.SubItems.Add(listaInstrumento.Nome);
                item.SubItems.Add(listaInstrumento.Valor.ToString());
                item.SubItems.Add(listaInstrumento.TipoID.TipoID.ToString());

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

        public void ListarHorario()
        {
            Horario horario = new Horario();
            Service1 service = new Service1();
            listViewHorarios.Items.Clear();

            foreach(Horario horarioLista in service.ListarHorario(horario))
            {
                ListViewItem item = listViewHorarios.Items.Add(horarioLista.HorarioID.ToString());
                item.SubItems.Add(horarioLista.HorarioInicial.ToString());
                item.SubItems.Add(horarioLista.HorarioFinal.ToString());
            }
        }

        public void ListarArtista()
        {
            Artista artista = new Artista();
            Service1 service = new Service1();
            listViewArtistas.Items.Clear();

            foreach (Artista artistaLista in service.ListarArtista(artista))
            {
                ListViewItem item = listViewArtistas.Items.Add(artistaLista.ArtistaID.ToString());
                item.SubItems.Add(artistaLista.Nome);
                item.SubItems.Add(artistaLista.Telefone);
                item.SubItems.Add(artistaLista.Email);
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
            ListarHorario();
        }

        private void btnTabArtistas_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectTab(4);
            ListarArtista();
        }

        private void btnTabInstrumentos_Click(object sender, EventArgs e)
        {
            tabControlMenu.SelectTab(5);
            ListaInstrumento();
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
            ListarCliente();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            FormAlterarCliente editar = new FormAlterarCliente();
            editar.TextBoxID = listViewClientes.SelectedItems[0].SubItems[0].Text;
            editar.TextBoxNome = listViewClientes.SelectedItems[0].SubItems[1].Text;
            editar.TextBoxTelefone = listViewClientes.SelectedItems[0].SubItems[2].Text;
            editar.TextBoxEmail = listViewClientes.SelectedItems[0].SubItems[3].Text;
            editar.ShowDialog();
            ListarCliente();
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
                ListarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovaSala_Click(object sender, EventArgs e)
        {
            FormCadastrarSala cadastrarSala = new FormCadastrarSala();
            cadastrarSala.ShowDialog();
       
        }

        private void btnNovoInstrumento_Click(object sender, EventArgs e)
        {
            FormCadastrarInstrumento formCadastrarInstrumento = new FormCadastrarInstrumento();
            formCadastrarInstrumento.ShowDialog();
            ListaInstrumento();
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
                ListaInstrumento();
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
            ListaInstrumento();
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
                    MessageBox.Show("Sala deletada com sucesso!");
                }

                ListarSala();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnEditarSala_Click(object sender, EventArgs e)
        {
            FormAlterarSala alterarSala = new FormAlterarSala();
            alterarSala.TxtSalaID = listViewSala.SelectedItems[0].SubItems[0].Text;
            alterarSala.TxtSalaNome = listViewSala.SelectedItems[0].SubItems[1].Text;
            alterarSala.TxtDescricaoSala = listViewSala.SelectedItems[0].SubItems[2].Text;
            alterarSala.TxtValorSala = listViewSala.SelectedItems[0].SubItems[3].Text;
            alterarSala.ShowDialog();
            ListarSala();
        }

        private void btnNovoTipo_Click(object sender, EventArgs e)
        {
            FormCadastrarTipo formCadastrarTipo = new FormCadastrarTipo();
            formCadastrarTipo.ShowDialog();
            ListarTipo();
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
                    MessageBox.Show("Tipo excluido com sucesso!");
                }
                ListarTipo();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao excluir Tipo! " + exception.Message);
            }
        }

        private void btnEditarTipo_Click(object sender, EventArgs e)
        {
            FormAlterarTipo editar = new FormAlterarTipo();
            editar.TextBoxID = listViewTipos.SelectedItems[0].SubItems[0].Text;
            editar.TextBoxNome = listViewTipos.SelectedItems[0].SubItems[1].Text;
            editar.ShowDialog();
            ListarTipo();
        }

        private void listViewInstrumentos_MouseClick(object sender, MouseEventArgs e)
        {
            FormAlterarInstrumento form = new FormAlterarInstrumento();
            form.TextBoxID = listViewInstrumentos.SelectedItems[0].SubItems[0].Text;
            form.TextBoxNome = listViewInstrumentos.SelectedItems[0].SubItems[1].Text;
            form.TextBoxValor = listViewInstrumentos.SelectedItems[0].SubItems[2].Text;
            form.TextBoxTipo = listViewInstrumentos.SelectedItems[0].SubItems[3].Text;
        }

        private void btnNovoHorario_Click(object sender, EventArgs e)
        {
            FormCadastrarHorario formCadastrarHorario = new FormCadastrarHorario();
            formCadastrarHorario.ShowDialog();
            ListarHorario();
        }

        private void btnNovoAgendamento_Click(object sender, EventArgs e)
        {
            FormAgendamento formAgendamento = new FormAgendamento();
            formAgendamento.ShowDialog();
        }

        private void btnNovoArtista_Click(object sender, EventArgs e)
        {
            FormCadastrarArtista formCadastrarArtista = new FormCadastrarArtista();
            formCadastrarArtista.ShowDialog();
            ListarArtista();
        }

        private void btnEditarHorario_Click(object sender, EventArgs e)
        {
            FormAlterarHorario formEditar = new FormAlterarHorario();
            formEditar.TextBoxID = listViewHorarios.SelectedItems[0].SubItems[0].Text;
            formEditar.TextBoxHoraInicio = listViewHorarios.SelectedItems[0].SubItems[1].Text;
            formEditar.TextBoxHoraFinal = listViewHorarios.SelectedItems[0].SubItems[2].Text;
            formEditar.ShowDialog();
            ListarHorario();
        }

        private void btnExcluirHorario_Click(object sender, EventArgs e)
        {
            try
            {
                Horario horario = new Horario();
                horario.HorarioID = Int32.Parse(listViewHorarios.SelectedItems[0].SubItems[0].Text);

                Service1 service = new Service1();
                if (MessageBox.Show("Tem certeza que deseja excluir este Horario?", "Excluir Horario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    service.DeletarHorario(horario);
                }
                MessageBox.Show("Horario excluido com sucesso! ");
                ListarHorario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir Horario - " + ex.Message);
            }
            
        }

        private void btnEditarArtista_Click(object sender, EventArgs e)
        {
            FormAlterarArtista formEditar = new FormAlterarArtista();
            formEditar.TextBoxID = listViewArtistas.SelectedItems[0].SubItems[0].Text;
            formEditar.TextBoxNome = listViewArtistas.SelectedItems[0].SubItems[1].Text;
            formEditar.TextBoxTelefone = listViewArtistas.SelectedItems[0].SubItems[2].Text;
            formEditar.TextBoxEmail = listViewArtistas.SelectedItems[0].SubItems[3].Text;
            formEditar.ShowDialog();
            ListarArtista();
        }

        private void btnExcluirArtista_Click(object sender, EventArgs e)
        {
            try
            {
                Artista artista = new Artista();
                artista.ArtistaID = Int32.Parse(listViewArtistas.SelectedItems[0].SubItems[0].Text);

                Service1 service = new Service1();
                if (MessageBox.Show("Tem certeza que deseja excluir este Artista?", "Excluir Artista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    service.DeletarArtista(artista);
                    MessageBox.Show("Artista excluido com sucesso! ");
                }
                ListarArtista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o Artista - " + ex.Message);
            }
        }
    }
}
