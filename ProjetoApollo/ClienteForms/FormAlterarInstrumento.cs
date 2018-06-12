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
    public partial class FormAlterarInstrumento : Form
    {
        public FormAlterarInstrumento()
        {
            InitializeComponent();
        }

        public string TextBoxID
        {
            get { return txtIDInstrumento.Text; }
            set { txtIDInstrumento.Text = value; }
        }

        public string TextBoxNome
        {
            get { return txtNomeInstrumento.Text; }
            set { txtNomeInstrumento.Text = value; }
        }

        public string TextBoxValor
        {
            get { return txtValorInstrumento.Text; }
            set { txtValorInstrumento.Text = value; }
        }

        public string TextBoxTipo
        {
            get { return txtTipoInstrumentoID.Text; }
            set { txtTipoInstrumentoID.Text = value; }
        }

        private void btnAtualizarInstrumento_Click(object sender, EventArgs e)
        {
            try
            {
                Tipo tipo = new Tipo();
                Instrumento instrumento = new Instrumento();
                instrumento.InstrumentoID = Int32.Parse(txtIDInstrumento.Text);
                instrumento.Nome = txtNomeInstrumento.Text;
                instrumento.Valor = decimal.Parse(txtValorInstrumento.Text);
                tipo.TipoID = Int32.Parse(txtTipoInstrumentoID.Text);
                instrumento.TipoID = tipo; 

                Service1 service = new Service1();
                service.AlterarInstrumento(instrumento);
                MessageBox.Show("Instrumento alterado com sucesso! ");

                txtIDInstrumento.Clear();
                txtNomeInstrumento.Clear();
                txtValorInstrumento.Clear();
                txtTipoInstrumentoID.Clear();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o instrumento - " + ex.Message);
            }
        }

        private void btnCancelarAlterarInstrumento_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja cancelar a edição?", "Alterar Instrumento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormAlterarInstrumento_Load(object sender, EventArgs e)
        {
            try
            {
                Service1 service = new Service1();
                Tipo tipo = new Tipo();

                foreach (Tipo lista in service.ListarTipo(tipo))
                {
                    comboBoxListarTipo.DisplayMember = "Text";
                    comboBoxListarTipo.ValueMember = "Value";

                    comboBoxListarTipo.Items.Add(new { Text = lista.Nome, Value = lista.TipoID });


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxListarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = (comboBoxListarTipo.SelectedItem as dynamic).Value;
            txtTipoInstrumentoID.Text = value.ToString();
        }
    }
}
