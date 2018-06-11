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
    public partial class FormCadastrarArtista : Form
    {
        public FormCadastrarArtista()
        {
            InitializeComponent();
        }

        private void btnCadastrarArtista_Click(object sender, EventArgs e)
        {
            try
            {
                Artista artista = new Artista();
                artista.Nome = txtNomeArtista.Text;
                artista.Telefone = txtTelefoneArtista.Text;
                artista.Email = txtEmailArtista.Text;

                Service1 service = new Service1();
                service.InserirArtista(artista);
                MessageBox.Show("Artista cadastrado com sucesso! ");

                txtNomeArtista.Clear();
                txtTelefoneArtista.Clear();
                txtEmailArtista.Clear();
                txtNomeArtista.Focus();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Artista - " + ex.Message);
            }
            
        }

        private void btnCancelarCadastrarArtista_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja cancelar o cadastro?", "Cadastrar Artista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
