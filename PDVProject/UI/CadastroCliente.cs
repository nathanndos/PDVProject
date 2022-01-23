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
    }
    public CadastroCliente(string nome, string sobrenome, string email, string cpf)
    {
        InitializeComponent();
        txtNomeCliente.Text = nome; 
        txtSobrenome.Text = sobrenome;  
        txtCpfCliente.Text = cpf;
        txtEmailCliente.Text = email;   
    }

    private void button1_Click(object sender, EventArgs e)
    {
            //ClienteBLL.getLast();
            Cliente cliente = new Cliente();
            cliente.Nome = txtNomeCliente.Text;
            cliente.SobreNome = txtSobrenome.Text;
            cliente.Email = txtEmailCliente.Text;
            cliente.Cpf = txtCpfCliente.Text;
            ClienteBLL.save(cliente);
            MessageBox.Show($"Cliente {cliente.Nome} salvo com sucesso!({cliente.Codigo})");
    }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
