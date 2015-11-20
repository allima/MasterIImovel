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
                cobbox_tipo.Text = imovel.Tipo_imovel.ToString();
                
            }
        }
    }
}
