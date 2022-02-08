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
    public partial class CadastroFuncionario : Form
    {
        public RadioButton[] arrayButtons = null;
        public CadastroFuncionario()
        {
            InitializeComponent();
            createArrayButtons();
        }
        public CadastroFuncionario(int codigo, string nome, decimal comissao, string funcao)
        {
            InitializeComponent();
            createArrayButtons();
            txtCodigo.Text = codigo.ToString();
            txtComissao.Text = comissao.ToString();
            txtNome.Text = nome.ToString();
            checkRadioButton(funcao);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                salvarCadastro();
                Close();

            }catch(Exception ex)
            {
                MessageBox.Show(""+txtComissao.Text+getValueButton()+ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void btnSalvarContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                salvarCadastro();
                lbFuncionario.Text = "Cadastro salvo com sucesso!";
            }
            catch
            {
                lbFuncionario.Text = "Ocorreu um erro, tente novamente";
            }
        }
        private void rbTecnico_CheckedChanged(object sender, EventArgs e)
        {

        }
        //-----------------------

        public void createArrayButtons()
        {
            arrayButtons = new RadioButton[5] { rbCaixa, rbEntregador, rbGerente, rbTecnico, rbVendedor };
        }
        public void salvarCadastro()
        {
            Funcionario funcionario = null;
            if (txtCodigo.Text == "")
            {
                FuncionarioBLL.getLast();
                funcionario = new Funcionario();
            }
            else
            {
                funcionario = new Funcionario(Int32.Parse(txtCodigo.Text));
            }
            
            funcionario.Nome = txtNome.Text;
            funcionario.Funcao = getValueButton();
            funcionario.Comissao = Decimal.Parse(txtComissao.Text); 
            FuncionarioBLL.save(funcionario);
        }
        public string getValueButton()
        {
            foreach (RadioButton rb in arrayButtons)
            {
                if (rb.Checked == true)
                    return rb.Text;
            }
            return "";
        }
        public void clear()
        {
            txtNome.Text = "";
            txtCodigo.Text = "";
            txtComissao = null;
        }
        public void checkRadioButton(string valor)
        {
            foreach (RadioButton radioButton in arrayButtons)
            {
                if (valor == radioButton.Text)
                {
                    radioButton.Checked = true;
                    return;
                }                                 
            }
        }

        }
}
