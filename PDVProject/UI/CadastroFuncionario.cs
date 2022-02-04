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
            arrayButtons = new RadioButton[5] { rbCaixa, rbEntregador, rbGerente,rbTecnico,rbVendedor};
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                salvarCadastro();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //-----------------------

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
                {
                    return rb.Text;
                }
            }
            return "";
        }

        private void rbTecnico_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
