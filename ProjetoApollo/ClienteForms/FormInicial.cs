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
            listViewCliente.Items.Clear();

            foreach (Cliente clienteLista in sv.ListarCliente(c))
            {
                ListViewItem item = listViewCliente.Items.Add(clienteLista.ClienteID.ToString());
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
    }
}
