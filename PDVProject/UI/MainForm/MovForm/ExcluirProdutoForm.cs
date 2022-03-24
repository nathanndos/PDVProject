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
using PDVProject.UI;

namespace PDVProject.UI.MainForm.MovForm
{
    public partial class ExcluirProdutoForm : Form
    {
        MovimentoForm movimentoForm = null;
        public ExcluirProdutoForm(MovimentoForm mf)
        {
            InitializeComponent();
            movimentoForm = mf; 
        }

        private void button2_Click(object sender, EventArgs e) => Close();

        public void remover_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtLinha.Text)>=0 && int.Parse(txtLinha.Text)<= movimentoForm.movimentoProdutos.Count) {
                movimentoForm.movimentoProdutos.RemoveAt(int.Parse(txtLinha.Text) - 1);
                int i = 0;
                foreach (var p in movimentoForm.movimentoProdutos)
                {
                    p.Linha = ++i;
                }
            }
            movimentoForm.configGrid();
            button2_Click(sender, e);
        }
    }
}
