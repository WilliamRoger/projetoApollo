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
    public partial class FormAgendamento : Form
    {
        public FormAgendamento()
        {
            InitializeComponent();
        }

        private void FormAgendamento_Load(object sender, EventArgs e)
        {
            comboBoxClientes.Items.Clear();
            Cliente cliente = new Cliente();
            Service1 service = new Service1();

            foreach(Cliente clienteLista in service.ListarCliente(cliente))
            {
                comboBoxClientes.Items.Add(clienteLista.ClienteNome);
            }
        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
