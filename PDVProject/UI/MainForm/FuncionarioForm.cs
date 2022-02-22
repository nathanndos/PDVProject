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
    public partial class FuncionarioForm : Form
    {
        public int linhaAtual;
        public FuncionarioForm()
        {
            InitializeComponent();
            //  
            dataGridFuncionarios.DataSource = FuncionarioBLL.getListAll();
            configurarGrid();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
            cadastroFuncionario.Show();
        }
        private void btn_editar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = FuncionarioBLL.getData(linhaAtual);
            startEdicao(funcionario);
            txtConsultaFunc.Text = "";
        }
        private void btnAtualizar_Click(object sender, EventArgs e) => dataGridFuncionarios.DataSource = FuncionarioBLL.getListAll();
        //------------------
        public int getLinha(DataGridViewCellMouseEventArgs e)
        {
            linhaAtual = (int)dataGridFuncionarios.Rows[e.RowIndex].Cells[0].Value;
            return linhaAtual;
        }
        public Funcionario getFuncLinha(DataGridViewCellMouseEventArgs e)
        {
            Funcionario cliente = FuncionarioBLL.getData(getLinha(e));
            return cliente;
        }

        private void dataGridFuncionarios_UmClique(object sender, DataGridViewCellMouseEventArgs e) => getLinha(e);


        private void dataGridFuncionarios_DoisCliques(object sender, DataGridViewCellMouseEventArgs e)
        {
            Funcionario func = getFuncLinha(e);
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario(func.Codigo,func.Nome,func.Comissao,func.Funcao);
            cadastroFuncionario.Show();
        }
        private void startEdicao(Funcionario funcionario)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario(funcionario.Codigo, funcionario.Nome, funcionario.Comissao, funcionario.Funcao);
            cadastroFuncionario.Show();
        }
        public void configurarGrid()
        {
            dataGridFuncionarios.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridFuncionarios.Columns[0].Width = 70;
            dataGridFuncionarios.Columns[1].Width = 230;
            dataGridFuncionarios.Columns[2].Width = 200;
            dataGridFuncionarios.Columns[3].Width = 100;
            dataGridFuncionarios.Columns[4].Width = 60;
            dataGridFuncionarios.Columns[5].Width = 130;
            dataGridFuncionarios.Columns[6].Width = 130;
            dataGridFuncionarios.Columns[7].Width = 80;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = FuncionarioBLL.getData(linhaAtual);
            FuncionarioBLL.delete(funcionario.Codigo);
            btnAtualizar_Click(sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string txt = txtConsultaFunc.Text;
            if (txt.Trim() == "")
            {
                dataGridFuncionarios.DataSource = FuncionarioBLL.getListAll();
                dataGridFuncionarios.Text = "";
            }
            else
                dataGridFuncionarios.DataSource = FuncionarioBLL.searchByName(txtConsultaFunc.Text);
            configurarGrid();

        }
    }
}
