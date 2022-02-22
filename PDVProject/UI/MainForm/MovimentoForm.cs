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
        public MovimentoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                Cliente cliente = null;
                cliente = ClienteBLL.getData(int.Parse(txtCliente.Text));
                disableCliente.Text = $"{ cliente.Nome} {cliente.SobreNome}";
            }
        }
        private void txtVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                removeSound(e);
                Funcionario funcionario = null;
                funcionario = FuncionarioBLL.getData(int.Parse(txtVendedor.Text));
                disableVendedor.Text = funcionario.Nome;
            }
        }
        public void removeSound(KeyEventArgs e) => e.SuppressKeyPress = true;

        private void txtCodProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                removeSound(e);
                Produto produto = null; 
                produto = ProdutoBLL.getData(int.Parse(txtCodProduto.Text))
            }
        }

        private void d_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
        