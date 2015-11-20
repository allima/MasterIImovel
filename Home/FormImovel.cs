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
    public partial class FormImovel : Form
    {
        public FormImovel()
        {
            InitializeComponent();
        }

        private void FormImovel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterimovelDataSet.imovel' table. You can move, or remove it, as needed.
            this.imovelTableAdapter.Fill(this.masterimovelDataSet.imovel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormImovelmanutencao formImovelmanutencao = new FormImovelmanutencao();
            formImovelmanutencao.ShowDialog(this);
        }
    }
}
