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
    public partial class MovimentoForm : Form
    {
        List<MovimentoProduto> movimentoProdutos = new List<MovimentoProduto>();
        Produto produto = null;
        Cliente cliente = null;
        Funcionario funcionario = null;
        Movimento movimento = null;
        MovimentoProduto mp = null;
        public MovimentoForm()
        {
            InitializeComponent();
            dgProdutosVenda.DataSource = movimentoProdutos;
            clearFields();
            txtTotalMov.Text = "0,0";
        }

        private void Movimento_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                removeSound(e);
                cliente = ClienteBLL.getData(int.Parse(txtCliente.Text));
                disableCliente.Text = $"{ cliente.Nome} {cliente.SobreNome}";
            }
        }
        private void txtVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                removeSound(e);
                funcionario = FuncionarioBLL.getData(int.Parse(txtVendedor.Text));
                disableVendedor.Text = funcionario.Nome;
            }
        }

        private void txtCodProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                removeSound(e);
                produto = ProdutoBLL.getData(int.Parse(txtCodProduto.Text));
                disableProduto.Text = produto.Nome;
                txtPrecoProduto.Text = produto.Preco.ToString();
            }
        }

        private void d_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        #region Funções manuais
        public void removeSound(KeyEventArgs e) => e.SuppressKeyPress = true;
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgProdutosVenda.DataSource = null;
            produto = ProdutoBLL.getData(int.Parse(txtCodProduto.Text));
            movimentoProdutos.Add(new MovimentoProduto(produto.Codigo,
                produto.Nome,
                produto.Ide,
                int.Parse(txtQtd.Text),
                produto.Preco, 
                funcionario.Codigo,
                funcionario.Nome,
                DateTime.Now));
            configGrid();
            setTotalFinal();
            clearFields();
            txtCodProduto.Focus();
            produto = null;

        }
        private void txtTotal_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtPrecoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                removeSound(e);
                decimal result = decimal.Parse(txtQtd.Text) * decimal.Parse(txtPrecoProduto.Text);
                txtTotal.Text = result.ToString();
            }
        }
        // -------------
        public void configGrid()
        {
            dgProdutosVenda.DataSource = movimentoProdutos;
            dgProdutosVenda.Columns["Produto__id"].DisplayIndex = 0;
            dgProdutosVenda.Columns["ProdutoNome"].DisplayIndex = 1;
            dgProdutosVenda.Columns["Quantidade"].DisplayIndex = 2;
            dgProdutosVenda.Columns["PrecoUnitario"].DisplayIndex = 3;
        }
        public void setTotalFinal()
        {
            decimal result = decimal.Parse(txtTotalMov.Text);
            result = result + (int.Parse(txtQtd.Text) * produto.Preco);
            txtTotalMov.Text = result.ToString();
        }
        public void clearFields()
        {
            txtQtd.Text = "1";
            txtCodProduto.Text = "";
            txtPrecoProduto.Text = "";
            txtTotal.Text = "";
            txtDesconto.Text = "0,0";

        }

        private void GravarMovimento(object sender, EventArgs e)
        {
            if(txtSequencia.Text != "")
            {
                MovimentoBLL.getLast();
            }
            else
            {
                movimento = new Movimento(convertDecimal(txtTotalMov),
                    convertDecimal(txtDesconto),
                    funcionario.Codigo,
                    cliente.Codigo);
                foreach (MovimentoProduto i in movimentoProdutos)
                {
                    i.movimento__id = movimento.Codigo;
                    MessageBox.Show(""+movimento.Codigo);
                    MovimentoProdutoProdutoBLL.save(i);
                }
            }
            MovimentoBLL.save(movimento);
        }
        public decimal convertDecimal(TextBox tb) => decimal.Parse(tb.Text);  

    }
}
        