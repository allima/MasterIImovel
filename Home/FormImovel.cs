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
           // this.imovelTableAdapter.Fill(this.masterimovelDataSet.imovel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormImovelmanutencao formImovelmanutencao = new FormImovelmanutencao();
            formImovelmanutencao.ShowDialog(this);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // Obtem o codigo do do gride da linha selecionad pelo duplo clique.
            int codigo = Convert.ToInt32(dgv_imovel.SelectedRows[0].Cells[0].Value.ToString());

            // Instancia a clesse FormeClasseManutencao enviando o codigo da classe como argumento
            FormImovelmanutencao FormImovelmanutencao = new FormImovelmanutencao(codigo);
            FormImovelmanutencao.ShowDialog(this);
        }

        private void FormImovel_Activated(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterimovelDataSet.imovel' table. You can move, or remove it, as needed.
            this.imovelTableAdapter.Fill(this.masterimovelDataSet.imovel);
        }
    }
}
