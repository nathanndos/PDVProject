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

namespace PDVProject
{
    public partial class ClienteForm : Form
    {
        int linhaAtual;
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
            //ClienteBLL.getLast();
            cadastrocliente.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridClienteUmClique(object sender, DataGridViewCellMouseEventArgs e)
        {
            getLinha(e);
        }

        private void dataGridClienteDoisCliques(object sender, DataGridViewCellMouseEventArgs e)
        {
            Cliente cliente = getClienteLinha(e);
            CadastroCliente cadastroCliente = new CadastroCliente(cliente.Codigo,cliente.Nome, cliente.SobreNome, cliente.Email, cliente.Cpf);
            cadastroCliente.Show();
        }

        private void dataGridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dataGridCliente.DataSource = ClienteBLL.getDataTable();
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            Cliente cliente = ClienteBLL.getClient(linhaAtual);
            startEdicao(cliente);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string txt = txtBuscarCliente.Text;
            if (txt.Trim() == "")
            {
                dataGridCliente.DataSource = ClienteBLL.getDataTable();
                txtBuscarCliente.Text = "";
            }
            else
            {
                try
                {
                    dataGridCliente.DataSource = ClienteBLL.getClienteCodigo(Convert.ToInt32(txt));
                }
                catch
                {
                    dataGridCliente.DataSource = ClienteBLL.consultaNome(txtBuscarCliente.Text);
                }
            }
        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Cliente cliente = ClienteBLL.getClient(linhaAtual);
            ClienteBLL.deleteClient(cliente.Codigo);
            btnAtualizar_Click(sender, e);
        }

        //-----------------
        public int getLinha(DataGridViewCellMouseEventArgs e)
        {

            linhaAtual =  (int)dataGridCliente.Rows[e.RowIndex].Cells[0].Value;
            return linhaAtual;
            
        }
        public Cliente getClienteLinha(DataGridViewCellMouseEventArgs e)
        {

            Cliente cliente = ClienteBLL.getClient(getLinha(e));
            return cliente;
        }
        private void startEdicao(Cliente cliente)
        {
            CadastroCliente cadastroCliente = new CadastroCliente(cliente.Codigo, cliente.Nome, cliente.SobreNome, cliente.Email, cliente.Cpf);
            cadastroCliente.Show();
        }




    }
}
