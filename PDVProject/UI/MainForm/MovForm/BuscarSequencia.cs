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
    public partial class BuscarSequencia : Form
    {
        public MovimentoForm movimentoForm { get; set; }
        public BuscarSequencia(MovimentoForm mf)
        {
            InitializeComponent();
            movimentoForm = mf;
        }
    }
}
