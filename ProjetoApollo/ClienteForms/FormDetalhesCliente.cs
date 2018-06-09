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
    public partial class FormDetalhesCliente : Form
    {
        internal object txtID;

        public FormDetalhesCliente()
        {
            InitializeComponent();
        }

        public string TextBoxID
        {
            get { return txtIDCliente.Text; }
            set { txtIDCliente.Text = value; }
        }
        public string TextBoxNome
        {
            get { return txtNomeCliente.Text; }
            set { txtNomeCliente.Text = value; }
        }
        public string TextBoxTelefone
        {
            get { return txtTelefoneCliente.Text; }
            set { txtTelefoneCliente.Text = value; }
        }
        public string TextBoxEmail
        {
            get { return txtEmailCliente.Text; }
            set { txtEmailCliente.Text = value; }
        }
    }
}
