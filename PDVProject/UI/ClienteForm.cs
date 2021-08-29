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

namespace PDVProject
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
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
            ClienteBLL.getLast();
            Cliente cliente1 = new Cliente();
            cliente1.Nome = txtNome.Text;
            cliente1.Email = txtEmail.Text;

            try
            {
                ClienteBLL.save(cliente1);
                MessageBox.Show("Cadastrado com sucesso!");
                txtNome.Text = "";
                txtEmail.Text = "";

            }
            catch(Exception)
            {
                MessageBox.Show("Erro");
            }
        }
    }
}
