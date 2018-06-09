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

        
}
}
