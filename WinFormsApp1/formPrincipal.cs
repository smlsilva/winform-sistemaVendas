using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class formPrincipal : Form
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCad form = new formCad();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formVendas vendas = new formVendas();
            vendas.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formEstoque estoque = new formEstoque();
            estoque.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formFinanceiro financeiro = new formFinanceiro();
            financeiro.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formRelatorio relatorio = new formRelatorio();
            relatorio.ShowDialog();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            //string connection = "server=localhost;uid=root;database=sistemaMercado";
            //var conexao = new MySqlConnection(connection);
            //conexao.Open();
        }
    }
}
