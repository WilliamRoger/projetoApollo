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

        private void ComboBoxCliente()
        {
            try
            {
                Cliente cliente = new Cliente();
                Service1 service = new Service1();
                
                foreach(Cliente clienteLista in service.ListarCliente(cliente))
                {
                    comboBoxClientes.Items.Add(clienteLista.ClienteNome);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
