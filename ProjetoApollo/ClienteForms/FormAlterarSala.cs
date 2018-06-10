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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja cancelar a edição ?", "Alterar Sala", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            /*try
            {
                Sala sala = new Sala();
                sala.SalaID = Int32.Parse(txtSalaID.Text);
                sala.SalaNome = txtNome.Text;
                sala.Descricao = txtDescricao.Text;
                sala.Valor = double.Parse(txtValor.Text);

            }*/
        }
    }
}
