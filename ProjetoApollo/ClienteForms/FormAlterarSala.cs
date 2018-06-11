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
     public partial class FormAlterarSala : Form
    {
        public FormAlterarSala()
        {
            InitializeComponent();
        }

        public string TxtSalaID
        {
            get { return txtSalaID.Text; }
            set { txtSalaID.Text = value; }
        }

        public string TxtSalaNome
        {
            get { return txtSalaNome.Text; }
            set { txtSalaNome.Text = value;}
        }

        public string TxtDescricaoSala
        {
            get { return txtDescricaoSala.Text; }
            set { txtDescricaoSala.Text = value;}
        }

        public string TxtValorSala
        {
            get { return txtValorSala.Text; }
            set { txtValorSala.Text = value;}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja cancelar a edição ?", "Alterar Sala", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            try
            {
                Sala sala = new Sala();
                sala.SalaID = Int32.Parse(txtSalaID.Text);
                sala.SalaNome = txtSalaNome.Text;
                sala.Descricao = txtDescricaoSala.Text;
                sala.Valor = Convert.ToDecimal(txtValorSala.Text);

                Service1 service = new Service1();
                service.AlterarSala(sala);
                MessageBox.Show("Sala Alterar com Sucesso!");

                txtSalaID.Clear();
                txtSalaNome.Clear();
                txtDescricaoSala.Clear();
                txtValorSala.Clear();
                this.Close();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        //public void txtSalaID_TextChanged(object sender, EventArgs e)
        
    }
}
