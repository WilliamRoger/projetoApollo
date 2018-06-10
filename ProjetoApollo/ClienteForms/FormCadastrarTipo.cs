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
    public partial class FormCadastrarTipo : Form
    {
        public FormCadastrarTipo()
        {
            InitializeComponent();
        }

        private void btnCadastrarTipo_Click(object sender, EventArgs e)
        {
            try
            {
                Tipo tipo = new Tipo();
                tipo.Nome = txtNomeTipo.Text;

                Service1 service = new Service1();
                service.InserirTipo(tipo);
                MessageBox.Show("Tipo cadastrado com sucesso!");

                txtNomeTipo.Clear();
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao cadastrar Tipo! " + exception.Message);
            }
        }

        private void btnCancelarCadastrarTipo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja cancelar o cadastro?", "Cadastrar Tipo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
