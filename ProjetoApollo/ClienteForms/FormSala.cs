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
    public partial class FormSala : Form
    {
        public FormSala()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Sala sala = new Sala();
                sala.SalaNome = txtNome.Text;
                sala.Descricao = txtDescricao.Text;
                sala.Valor = Convert.ToDouble(txtValor.Text);
                Service1 service1 = new Service1();
                service1.InserirSala(sala);
                MessageBox.Show("Sala Cadastrada com Sucesso.");
                txtNome.Clear();
                txtDescricao.Clear();
                txtValor.Clear();
                txtNome.Focus();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Sala sala = new Sala();
            Service1 service1 = new Service1();
            listViewSala.Items.Clear();

            foreach(Sala salaLista in service1.ListarSala(sala))
            {
                ListViewItem item = listViewSala.Items.Add(salaLista.SalaID.ToString());
                item.SubItems.Add(salaLista.SalaNome);
                item.SubItems.Add(salaLista.Valor.ToString());

            };
        }
    }
}
