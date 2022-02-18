using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace PDVProject.UI
{
    public partial class ProdutoForm : Form
    {
        int linhaAtual;
        public ProdutoForm()
        {
            InitializeComponent();
            reloadGrid();
            dataGridProduto.Columns[0].Width = 70;
            dataGridProduto.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridProduto.Columns[1].Width = 180;
            dataGridProduto.Columns[2].Width = 230;
            dataGridProduto.Columns[3].Width = 120;
            dataGridProduto.Columns[4].Width = 110;
            dataGridProduto.Columns[5].Width = 150;
            dataGridProduto.Columns[6].Width = 80;
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

        private void dataGridProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Atualizar_Click(object sender, EventArgs e) => reloadGrid();
        public void reloadGrid() => dataGridProduto.DataSource = ProdutoBLL.getListAll();
        private void dataGridUmClique(object sender, DataGridViewCellMouseEventArgs e) => getLinha(e);

        private void dataGridDoisCliques(object sender, DataGridViewCellMouseEventArgs e)
        {
            Produto produto = getDataRow(e);
            startEdition(produto);
        }
        ///--------
        public int getLinha(DataGridViewCellMouseEventArgs e)
        {
            linhaAtual = (int)dataGridProduto.Rows[e.RowIndex].Cells[0].Value;
            return linhaAtual;
        }
        public Produto getDataRow(DataGridViewCellMouseEventArgs e)
        {
            Produto produto = ProdutoBLL.getData(getLinha(e));
            return produto;
        }

        private void btn_editarProd_Click(object sender, EventArgs e)
        {
            Produto produto = ProdutoBLL.getData(linhaAtual);
            startEdition(produto);
        }

        public void startEdition(Produto produto)
        {
            CadastroProduto cadastroProduto = new CadastroProduto(produto.Codigo, produto.Nome, produto.Ncm, produto.Preco, produto.CodigoFornecedor);
            cadastroProduto.Show();
        }
    }
}
