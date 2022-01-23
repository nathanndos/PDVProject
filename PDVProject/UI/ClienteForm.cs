using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDVProject.UI;
using BLL;

namespace PDVProject
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
            dataGridCliente.DataSource = ClienteBLL.getDataTable();
            dataGridCliente.Columns[0].Width = 70;
            dataGridCliente.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridCliente.Columns[1].Width = 180;
            dataGridCliente.Columns[3].Width = 230;
            dataGridCliente.Columns[4].Width = 110;
            dataGridCliente.Columns[5].Width = 200;
            dataGridCliente.Columns[6].Width = 120;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroCliente cadastrocliente = new CadastroCliente();
            cadastrocliente.Show();
            /*ClienteBLL.getLast();
            Cliente cliente1 = new Cliente();
            //cliente1.Nome = txtNome.Text;
            //cliente1.Email = txtEmail.Text;

            try
            {
                ClienteBLL.save(cliente1);
                MessageBox.Show("Cadastrado com sucesso!");
                //txtNome.Text = "";
                //txtEmail.Text = "";

            }
            catch(Exception)
            {
                MessageBox.Show("Erro");
            }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
