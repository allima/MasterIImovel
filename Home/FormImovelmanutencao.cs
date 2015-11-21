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
    public partial class FormImovelmanutencao : Form
    {
        private int codigo; // armazena o codigo da classe selecionado no DataGridView 
        private string operacao; //armazena a operacao a ser realizada(inclusao ou alteração /exclusao).

        //Construdo chamado quando o usuario clica no botao "Novo **classe"(inclusão)
        public FormImovelmanutencao()
        {
            InitializeComponent();
            this.operacao = "inc";
        }

        //construdo chamado quando o usuario dá duplo clique em uma linha  do datagridView (alteração ou exclusao).
        public FormImovelmanutencao(int codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            this.operacao = "alt-exc";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Imovel imovel = new Imovel(); // Instancia a classe Cargos. 
                                          // Atribui o valor do campo "Nome do Cargo" ao atributo "nome" da classe Cargos. 
            imovel.Decricao = txtb_decricao.Text; // Atribui o valor do campo "Departamento" ao atributo "depto" da classe Cargos. 
            imovel.Endereco = txtb_endereco.Text;
            imovel.Valor = double.Parse(mktxtb_valor.Text);
            imovel.Valor_aluguel = double.Parse(mktxtb_valoraluguel.Text);
            imovel.Tipo_imovel = cobbox_tipo.SelectedIndex.ToString();


            if (operacao == "inc")
            { // Se operacao for de inclusao. 
              // Chama o metodo Incluir da classe CargosOperacoes, passando como argumento
              // contendo os dados do cargo a ser incluido. 
                ImovelOperacao.Incluir(imovel);
            }
            else
            { // Se operacao for de alteracao. 
              // Atribui o valor do campo "Cadigo" (recebido pelo construtor) ao atributo ' 
                imovel.Id = codigo; // Chama o metodo Alterar da classe CargosOperacoes, passando como argumento
                                    // contendo os dados do cargo a ser alterado. 
                ImovelOperacao.Alterar(imovel);
            }
            this.Close(); // Fecha o formulario de manutencao apps salvar. 
        }

        private void FormImovelmanutencao_Load(object sender, EventArgs e)
        {
            if (operacao == "alt-exc")
            {// Se a operacao for de alteracao ou exclusao. 
             // Chama o metodo Consultar da classe CargosOperacoes. 
                Imovel imovel = ImovelOperacao.Consultar(codigo);
                txtb_decricao.Text = imovel.Decricao.ToString();
                txtb_endereco.Text = imovel.Endereco.ToString();
                mktxtb_valor.Text = imovel.Valor.ToString();
                mktxtb_valoraluguel.Text = imovel.Valor_aluguel.ToString();
                cobbox_tipo.SelectedIndex = int.Parse(imovel.Tipo_imovel.ToString());

            }
        }
    }
}
