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
            // TODO: This line of code loads data into the 'masterimovelDataSet.pessoa' table. You can move, or remove it, as needed.
            switch (tipo)
            {
                case 'C':
                    //  Console.WriteLine("Case 1");
                    this.pessoaTableAdapter.FillByc(this.masterimovelDataSet.pessoa);//corretor
                    break;
                case 'P':
                    // Console.WriteLine("Case 2");
                    this.pessoaTableAdapter.FillByp(this.masterimovelDataSet.pessoa);//proprietario
                    break;
                case 'I':
                    //   Console.WriteLine("Case 2");
                    this.pessoaTableAdapter.FillBya(this.masterimovelDataSet.pessoa);//inquilino
                    break;
                default:
                    Console.WriteLine("full");
                    this.pessoaTableAdapter.Fill(this.masterimovelDataSet.pessoa);
                    break;
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
