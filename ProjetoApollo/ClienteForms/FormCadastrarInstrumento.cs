using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteForms.localhost;

namespace ClienteForms
{
    public partial class FormCadastrarInstrumento : Form
    {
        public FormCadastrarInstrumento()
        {
            InitializeComponent();
        }

        private void FormInstrumento_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarInstrumento_Click(object sender, EventArgs e)
        {
            try
            {
                Tipo tipo = new Tipo();
                Instrumento instrumento = new Instrumento();
                instrumento.Nome = txtNomeInstrumento.Text;
                instrumento.Valor = Convert.ToDecimal(txtValorInstrumento.Text);
                tipo.TipoID = Convert.ToInt32(txtTipoInstrumento.Text);
                //instrumento.TipoID = tipo.TipoID;

                Service1 service = new Service1();
                service.InserirInstrumento(instrumento);
                MessageBox.Show("Instrumento cadastrado com sucesso!");

                txtNomeInstrumento.Clear();
                txtValorInstrumento.Clear();
                txtTipoInstrumento.Clear();
                txtNomeInstrumento.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarCadastrarInstrumento_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja cancelar o cadastro?", "Cadastrar Instrumento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
