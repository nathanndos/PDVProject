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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        public CadastroProduto(int codigo, string nome, string ncm, decimal preco, string codigoFornecedor)
        {
            InitializeComponent();
            txtCodigo.Text = codigo.ToString();
            txtNome.Text = nome.ToString();
            txtNcm.Text = ncm.ToString();
            txtPreco.Text = preco.ToString();
            txtCodFornecedor.Text = codigoFornecedor.ToString();
        }

        #region Funcoes padrão
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnSalvar(object sender, EventArgs e)
        {
            try
            {
                salvarCadastro();
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        #endregion

        #region Funcoes manuais
        public void salvarCadastro()
        {
            Produto produto = null;
            if (txtCodigo.Text == "")
            {
                ProdutoBLL.getLast();
                produto = new Produto();
            }
            else
                produto = new Produto(Int32.Parse(txtCodigo.Text));

            produto.Nome = txtNome.Text;
            produto.Preco = Decimal.Parse(txtPreco.Text);
            produto.Ncm = txtNcm.Text;
            produto.CodigoFornecedor = txtCodFornecedor.Text;
            ProdutoBLL.save(produto);
        }
        public void clear()
        {
            txtNome.Text = "";
            txtCodigo.Text = "";
            txtNcm.Text = "";
            txtPreco.Text = "";
            txtCodFornecedor.Text = "";
        }
        private void btnSalvarEContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                salvarCadastro();
                lbProduto.Text = "Cadastrado com sucessso!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }

            #endregion
        }
  
    }
}
