using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace PDVProject.UI { 
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
            limparLabel();
        }
        public CadastroCliente(int codigo,string nome, string sobrenome, string email, string cpf)
        {
            InitializeComponent();
            limparLabel();
            txtCodigo.Text = codigo.ToString();
            txtNomeCliente.Text = nome; 
            txtSobrenome.Text = sobrenome;  
            txtCpfCliente.Text = cpf;
            txtEmailCliente.Text = email;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salvarCadastro();
            Close();
        }
        private void btnSalvarContinuar_Click(object sender, EventArgs e)
        {
            salvarCadastro();
            LabelMsgCliente.Text = "Salvo com sucesso!";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text = "";
            txtCpfCliente.Text = "";
            txtSobrenome.Text = "";
            txtEmailCliente.Text = "";
            limparLabel();

        }
        //-----------------------

        public void salvarCadastro()
        {
            Cliente cliente = null;
            if (txtCodigo.Text == "")
            {
                ClienteBLL.getLast();
                cliente = new Cliente();
            }
            else
            {
                cliente = new Cliente(Int32.Parse(txtCodigo.Text));
            }
            cliente.Nome = txtNomeCliente.Text;
            cliente.SobreNome = txtSobrenome.Text;
            cliente.Email = txtEmailCliente.Text;
            cliente.Cpf = txtCpfCliente.Text;
            ClienteBLL.save(cliente);
        }

        public void limparLabel()
        {
            LabelMsgCliente.Text = "";
        }
       
    }
}
