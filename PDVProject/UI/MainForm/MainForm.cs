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
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        { 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteForm clienteForm = new ClienteForm();
            
            clienteForm.Show();
        }

        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            ProdutoForm produtoForm = new ProdutoForm();
            produtoForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       /* private void button2_Click(object sender, EventArgs e)
        {
            lb_caixa.Text = "CAIXA ABERTO";
            btnVenda.Text = "Iniciar Venda";
            btn_finalizar.Text = "Fechar Caixa";
        }*/

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            btnVenda.Text = "Iniciar Caixa";
            btn_finalizar.Text = "Finalizar";
        }

        private void btn_func_Click(object sender, EventArgs e)
        {
            FuncionarioForm funcionarioForm = new FuncionarioForm();    
            funcionarioForm.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            MovimentoForm movimento = new MovimentoForm();
            movimento.Show();
        }
    }
}
