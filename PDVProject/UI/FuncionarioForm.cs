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

namespace PDVProject.UI
{
    public partial class FuncionarioForm : Form
    {
        public FuncionarioForm()
        {
            InitializeComponent();
          //  
            dataGridFuncionarios.DataSource = FuncionarioBLL.getDataTable();
            dataGridFuncionarios.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridFuncionarios.Columns[0].Width = 70;
            dataGridFuncionarios.Columns[1].Width = 180;
            dataGridFuncionarios.Columns[3].Width = 230;
            dataGridFuncionarios.Columns[4].Width = 110;
            dataGridFuncionarios.Columns[5].Width = 200;
            dataGridFuncionarios.Columns[6].Width = 120;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();    
            cadastroFuncionario.Show();
        }
    }
}
