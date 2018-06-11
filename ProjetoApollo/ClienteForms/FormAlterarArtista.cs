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
    public partial class FormAlterarArtista : Form
    {
        public FormAlterarArtista()
        {
            InitializeComponent();
        }

        public string TextBoxID
        {
            get { return txtIDArtista.Text; }
            set { txtIDArtista.Text = value; }
        }

        public string TextBoxNome
        {
            get { return txtNomeArtista.Text; }
            set { txtNomeArtista.Text = value; }
        }

        public string TextBoxTelefone
        {
            get { return txtTelefoneArtista.Text; }
            set { txtTelefoneArtista.Text = value; }
        }

        public string TextBoxEmail
        {
            get { return txtEmailArtista.Text; }
            set { txtEmailArtista.Text = value; }
        }

        private void btnAtualizarArtista_Click(object sender, EventArgs e)
        {
            try
            {
                Artista artista = new Artista();
                artista.ArtistaID = Int32.Parse(txtIDArtista.Text);
                artista.Nome = txtNomeArtista.Text;
                artista.Telefone = txtTelefoneArtista.Text;
                artista.Email = txtEmailArtista.Text;

                Service1 service = new Service1();
                service.AlterarArtista(artista);
                MessageBox.Show("Artista alterado com sucesso! ");

                txtIDArtista.Clear();
                txtNomeArtista.Clear();
                txtTelefoneArtista.Clear();
                txtEmailArtista.Clear();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar Artista - " + ex.Message);
            }

        }

        private void btnCancelarAtualizarArtista_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja cancelar a edição?", "Alterar Artista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
