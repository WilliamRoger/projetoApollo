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
    public partial class FormAlterarHorario : Form
    {
        public FormAlterarHorario()
        {
            InitializeComponent();
        }

        public string TextBoxID
        {
            get { return txtHoraID.Text; }
            set { txtHoraID.Text = value; }
        }

        public string TextBoxHoraInicio
        {
            get { return txtHoraInicio.Text; }
            set { txtHoraInicio.Text = value; }
        }

        public string TextBoxHoraFinal
        {
            get { return txtHoraFinal.Text; }
            set { txtHoraFinal.Text = value; }
        }

        private void btnAtualizarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                Horario horario = new Horario();
                horario.HorarioID = Int32.Parse(txtHoraID.Text);
                horario.HorarioInicial = txtHoraInicio.Text;
                horario.HorarioFinal = txtHoraFinal.Text;

                Service1 service = new Service1();
                service.AlterarHorario(horario);
                MessageBox.Show("Horario alterado com sucesso! ");

                txtHoraID.Clear();
                txtHoraInicio.Clear();
                txtHoraFinal.Clear();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar o horario - " + ex.Message);
            }
        }

        private void btnCancelarCadastrarHorario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja cancelar a edição?", "Alterar Horario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
