using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQL_System.View;

namespace MySQL_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clienteForm_Click(object sender, EventArgs e)
        {
            frmClientes form = new View.frmClientes();
            form.Show();
        }

        private void btn_vendas_Click(object sender, EventArgs e)
        {
            frmVendas form = new View.frmVendas();
            form.Show();
        }
    }
}
