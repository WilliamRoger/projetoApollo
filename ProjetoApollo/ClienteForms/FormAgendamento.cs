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
    public partial class FormAgendamento : Form
    {
        public FormAgendamento()
        {
            InitializeComponent();

        }

        

        private void FormAgendamento_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Sala sala = new Sala();
            Horario horario = new Horario();
            Service1 service = new Service1();
            Instrumento instrumento = new Instrumento();

            foreach(Cliente clienteLista in service.ListarCliente(cliente))
            {
                comboBoxClientes.DisplayMember = "Text";
                comboBoxClientes.ValueMember = "Value";

                comboBoxClientes.Items.Add(new { Text = clienteLista.ClienteNome, Value = clienteLista.ClienteID });
            }

            foreach(Sala salaLista in service.ListarSala(sala))
            {
                comboBoxSalas.DisplayMember = "Text";
                comboBoxSalas.ValueMember = "Value";
                comboBoxSalas.ValueMember = "ValorSala";

                comboBoxSalas.Items.Add(new { Text = salaLista.SalaNome, Value = salaLista.SalaID, ValorSala = salaLista.Valor});
            }

            foreach (Horario horaInicioLista in service.ListarHorario(horario))
            {
                comboBoxHorario.DisplayMember = "Text";
                comboBoxHorario.ValueMember = "Value";

                comboBoxHorario.Items.Add(new { Text = horaInicioLista.HorarioInicial + '/' + horaInicioLista.HorarioFinal, Value = horaInicioLista.HorarioID });
            }

            

        }

        private void comboBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = (comboBoxClientes.SelectedItem as dynamic).Text;
            int value = (comboBoxClientes.SelectedItem as dynamic).Value;
            txtIDCliente.Text = value.ToString();
            txtNomeCliente.Text = text;
        }

        private void comboBoxSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = (comboBoxSalas.SelectedItem as dynamic).Text;
            int value = (comboBoxSalas.SelectedItem as dynamic).Value;
            decimal valorSala = (comboBoxSalas.SelectedItem as dynamic).ValorSala;
            txtNomeSala.Text = text;
            txtIDSala.Text = value.ToString();
            txtValorSala.Text = valorSala.ToString();

            

        }

        private void comboBoxHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = (comboBoxHorario.SelectedItem as dynamic).Text;
            int value = (comboBoxHorario.SelectedItem as dynamic).Value;
            txtHorario.Text = text;
            txtIDHorario.Text = value.ToString();
        }

        private void radioBtnInstrumentoNao_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxListaInstrumento.Enabled = false;
        }

        private void radioBtnInstrumentoSim_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxListaInstrumento.Enabled = true;
            txtValorInstrumento.Enabled = true;

            Service1 service = new Service1();
            Instrumento instrumento = new Instrumento();

            foreach (Instrumento instrumentoLista in service.ListarInstrumento(instrumento))
            {
                comboBoxListaInstrumento.DisplayMember = "Text";
                comboBoxListaInstrumento.ValueMember = "Value";

                comboBoxListaInstrumento.Items.Add(new { Text = instrumentoLista.Nome, Value = instrumentoLista.Valor });

            }
            
        }

        
        private void comboBoxListaInstrumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal valorinst = (comboBoxListaInstrumento.SelectedItem as dynamic).Value;
            txtValorInstrumento.Text = valorinst.ToString();
            
            

        }

        private void txtValorSala_TextChanged(object sender, EventArgs e)
        {
            

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal inst;
            decimal sala;
            decimal soma;

            sala = Convert.ToDecimal(txtValorSala.Text);
            inst = Convert.ToDecimal(txtValorInstrumento.Text);

            soma = sala + inst;

            ValorTotal.Text = soma.ToString();
            
            
        }

        private void ValorTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                Service1 service = new Service1();
                Cliente cliente = new Cliente();
                Locacao locacao = new Locacao();

                cliente.ClienteID = Convert.ToInt32(txtIDCliente.Text);
                locacao.ClienteID = cliente;
                locacao.DataVencimento = txtVencimento.Text;
                locacao.DataPagamento = txtPagamento.Text;
                locacao.DataCancelamento = t.Text;

                service.InserirLocacao(locacao);

                

                MessageBox.Show("Locaçao cadastrada com sucesso! Bom som!");

                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao cadastar locacao" + ex.Message);
            }



            
        }
    }

    
}

        
    

