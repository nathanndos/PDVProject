using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDVProject.UI.MainForm.MovForm
{
    public partial class FinanceiroForm : Form
    {
        public decimal ValorTotal { get; set; }
        MovimentoForm movimentoForm;
        public FinanceiroForm(decimal total, MovimentoForm mf)
        {
            InitializeComponent();
            ValorTotal = total;
            movimentoForm = mf;
            txtTotal.Text = ValorTotal.ToString();
        }

        private void FinanceiroForm_Load(object sender, EventArgs e)
        {

        }
    }
}
