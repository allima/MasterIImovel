using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void imovelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormImovel formImovel = new FormImovel();
            formImovel.ShowDialog(this);
        }

        private void inquilinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPessoa formPessoa = new FormPessoa('I');
            formPessoa.ShowDialog(this);
        }

        private void corretorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPessoa formPessoa = new FormPessoa('C');
            formPessoa.ShowDialog(this);
        }

        private void proprietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPessoa formPessoa = new FormPessoa('P');
            formPessoa.ShowDialog(this);
        }
    }
}
