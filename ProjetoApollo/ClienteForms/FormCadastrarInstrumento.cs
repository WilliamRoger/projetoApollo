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
            try
            {
                Service1 service = new Service1();
                Tipo tipo = new Tipo();

                foreach (Tipo lista in service.ListarTipo(tipo))
                {
                    comboBoxListaTipo.DisplayMember = "Text";
                    comboBoxListaTipo.ValueMember = "Value";

                    comboBoxListaTipo.Items.Add(new { Text = lista.Nome, Value = lista.TipoID });
                                      

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            



        }

        private void btnCadastrarInstrumento_Click(object sender, EventArgs e)
        {
            try
            {
                Tipo tipo = new Tipo();
                Instrumento instrumento = new Instrumento();
                instrumento.Nome = txtNomeInstrumento.Text;
                instrumento.Valor = Convert.ToDecimal(txtValorInstrumento.Text);
                tipo.TipoID = Convert.ToInt32(txtTipoInstrumentoID.Text);
                instrumento.TipoID = tipo;

                Service1 service = new Service1();
                service.InserirInstrumento(instrumento);
                MessageBox.Show("Instrumento cadastrado com sucesso!");

                txtNomeInstrumento.Clear();
                txtValorInstrumento.Clear();
                txtTipoInstrumentoID.Clear();
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

        private void comboBoxListaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = (comboBoxListaTipo.SelectedItem as dynamic).Text;
            int value = (comboBoxListaTipo.SelectedItem as dynamic).Value;
            //txtNomeSala.Text = text;
            txtTipoInstrumentoID.Text = value.ToString();
        }
    }
}
