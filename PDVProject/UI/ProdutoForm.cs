using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVProject.UI
{
    public partial class ProdutoForm : Form
    {
        public ProdutoForm()
        {
            InitializeComponent();
            //dataGridProduto.DataSource = ProdutoBLL.getDataTable();
            //dataGridProduto.Columns[0].Width = 70;
            //dataGridProduto.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dataGridProduto.Columns[1].Width = 180;
            //dataGridProduto.Columns[3].Width = 230;
            //dataGridProduto.Columns[4].Width = 110;
            //dataGridProduto.Columns[5].Width = 200;
            //dataGridProduto.Columns[6].Width = 120;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            CadastroProduto cadastroProduto = new CadastroProduto();
            cadastroProduto.Show();
        }
    }
}
