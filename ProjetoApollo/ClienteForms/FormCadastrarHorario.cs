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
    public partial class FormCadastrarHorario : Form
    {
        public FormCadastrarHorario()
        {
            InitializeComponent();
        }

        private void btnCadastrarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                Horario horario = new Horario();
                horario.HorarioInicial = txtHorarioInicio.Text;
                horario.HorarioFinal = txtHorarioFim.Text;

                Service1 service = new Service1();
                service.InserirHorario(horario);
                MessageBox.Show("Horário cadastrado com sucesso!");

                txtHorarioInicio.Clear();
                txtHorarioFim.Clear();
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao cadastrar Horário! " + exception.Message);
            }
        }
    }
}
