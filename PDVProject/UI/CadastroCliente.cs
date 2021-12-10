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

namespace PDVProject.UI { 
    public partial class CadastroCliente : Form
{
    public CadastroCliente()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
            Cliente cliente = new Cliente();
            MessageBox.Show(""+ cliente.Ide);
    }
}
}
