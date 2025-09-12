namespace WinFormsApp1
{
    public partial class formCad : Form
    {
        public formCad()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                if (tab.Text == "Cadastro de Clientes")
                {
                    tabControl1.SelectedTab = tab;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            textBox17.Text = DateTime.Now.ToString().Split(" ")[0];
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formVendas formularioVenda = new formVendas();
            formularioVenda.ShowDialog();
        }
    }
}
