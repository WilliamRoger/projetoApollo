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
    public partial class FormAlterarTipo : Form
    {
        public FormAlterarTipo()
        {
            InitializeComponent();
        }

        public string TextBoxID
        {
            get { return txtIDTipo.Text; }
            set { txtIDTipo.Text = value; }
        }

        public string TextBoxNome
        {
            get { return txtNomeTipo.Text; }
            set { txtNomeTipo.Text = value; }
        }

        private void btnAtualizarTipo_Click(object sender, EventArgs e)
        {
            try
            {
                Tipo tipo = new Tipo();
                tipo.TipoID = Int32.Parse(txtIDTipo.Text);
                tipo.Nome = txtNomeTipo.Text;

                Service1 service = new Service1();
                service.AlterarTipo(tipo);
                MessageBox.Show("Tipo alterado com sucesso!");

                txtIDTipo.Clear();
                txtNomeTipo.Clear();

                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao alterar Tipo! " + exception.Message);
            }
        }

        private void btnCancelarAtualizarTipo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja cancelar a edição?", "Alterar Tipo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
