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
    public partial class FormPessoa : Form
    {
        private char tipo;
        int codigo=0;
        public FormPessoa()
        {
            InitializeComponent();
        }
        public FormPessoa(char tipo)
        {
            this.tipo = tipo;
            InitializeComponent();
        }

        private void FormPessoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterimovelDataSet.proprietario_imovel' table. You can move, or remove it, as needed.
            //  this.proprietario_imovelTableAdapter.Fill(this.masterimovelDataSet.proprietario_imovel);
            // TODO: This line of code loads data into the 'masterimovelDataSet.pessoa' table. You can move, or remove it, as needed.
            /*   switch (tipo)
               {
                   case 'C':
                       //  Console.WriteLine("Case 1");
                       this.pessoaTableAdapter.FillByc(this.masterimovelDataSet.pessoa);//corretor
                       this.Text = "Corretor";
                       break;
                   case 'P':
                       // Console.WriteLine("Case 2");
                       this.pessoaTableAdapter.FillByp(this.masterimovelDataSet.pessoa);//proprietario
                       this.Text = "Proprietario";
                       break;
                   case 'I':
                       //   Console.WriteLine("Case 2");
                       this.pessoaTableAdapter.FillBya(this.masterimovelDataSet.pessoa);//inquilino
                       this.Text = "Inquilino";
                       break;
                   default:
                       Console.WriteLine("full");
                       this.pessoaTableAdapter.Fill(this.masterimovelDataSet.pessoa);
                       break;
               }*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPessoaManutencao formPessoaManutencao = new FormPessoaManutencao(tipo);
            formPessoaManutencao.ShowDialog(this);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            // Obtem o codigo do do gride da linha selecionad pelo duplo clique.
            try {
                 codigo = Convert.ToInt32(dgv_pessoa.SelectedRows[0].Cells[0].Value.ToString());
            }
            catch (Exception ) {
             
            }
            // Instancia a clesse FormeClasseManutencao enviando o codigo da classe como argumento
            FormPessoaManutencao formPessoaManutencao = new FormPessoaManutencao(tipo, codigo);
            formPessoaManutencao.ShowDialog(this);
        }

        private void FormPessoa_Activated(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case 'C':
                    //  Console.WriteLine("Case 1");
                    this.pessoaTableAdapter.FillByc(this.masterimovelDataSet.pessoa);//corretor
                    this.Text = "Corretor";
                    btn_novo.Text = "Novo Corretor";
                    break;
                case 'P':
                    // Console.WriteLine("Case 2");
                    this.pessoaTableAdapter.FillByp(this.masterimovelDataSet.pessoa);//proprietario
                    this.Text = "Proprietario";
                    btn_novo.Text = "Novo Proprietario";
                    break;
                case 'I':
                    //   Console.WriteLine("Case 2");
                    this.pessoaTableAdapter.FillBya(this.masterimovelDataSet.pessoa);//inquilino
                    this.Text = "Inquilino";
                    btn_novo.Text = "Novo Inquilino";
                    break;
                default:
                    Console.WriteLine("full");
                    this.pessoaTableAdapter.Fill(this.masterimovelDataSet.pessoa);
                    break;
            }
        }
    }
}
