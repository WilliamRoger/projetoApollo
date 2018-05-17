using Biblioteca.pacoteConexao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteConexao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoSQLServer conexao = new ConexaoSQLServer();
                conexao.AbrirConexao();
                MessageBox.Show("A Conexao tá rolando malandro!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
