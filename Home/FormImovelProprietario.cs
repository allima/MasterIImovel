using Home.dao;
using Home.modelo;
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
    public partial class FormImovelProprietario : Form
    {
        private string operacao;
        private int codigo;


        public FormImovelProprietario()
        {
            this.operacao = "inc";
            InitializeComponent();
        }

        private void FormImovelProprietario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterimovelDataSet.pessoa' table. You can move, or remove it, as needed.
            this.pessoaTableAdapter.Fill(this.masterimovelDataSet.pessoa);
            // TODO: This line of code loads data into the 'masterimovelDataSet.imovel' table. You can move, or remove it, as needed.
            // this.imovelTableAdapter.Fill(this.masterimovelDataSet.imovel);
            this.imovelTableAdapter.FillByImovel(this.masterimovelDataSet.imovel);
        }

        private void fillByImovelToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.imovelTableAdapter.FillByImovel(this.masterimovelDataSet.imovel);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Proprietario_Imovel proprietario_imovel = new Proprietario_Imovel(); // Instancia a classe Cargos. 
                                                                                 // Atribui o valor do campo "Nome do Cargo" ao atributo "nome" da classe Cargos. 
            proprietario_imovel.Imovel.Id = (Int32) cbx_imovel.SelectedValue; // Atribui o valor do campo "Departamento" ao atributo "depto" da classe Cargos. 
            proprietario_imovel.Proprietario.Id = (Int32)cbx_pessoa.SelectedValue;
           

            if (operacao == "inc")
            { // Se operacao for de inclusao. 
              // Chama o metodo Incluir da classe CargosOperacoes, passando como argumento
              // contendo os dados do cargo a ser incluido. 
                Proprietario_ImovelOperacao.Incluir(proprietario_imovel);
            }
            else
            { // Se operacao for de alteracao. 
              // Atribui o valor do campo "Cadigo" (recebido pelo construtor) ao atributo ' 
                proprietario_imovel.Id = codigo; // Chama o metodo Alterar da classe CargosOperacoes, passando como argumento
                                                 // contendo os dados do cargo a ser alterado. 
                Proprietario_ImovelOperacao.Alterar(proprietario_imovel);
            }
            this.Close(); // Fecha o formulario de manutencao apps salvar. 
        }
    }
}
