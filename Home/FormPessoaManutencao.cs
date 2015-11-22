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
    public partial class FormPessoaManutencao : Form
    {
        private int codigo; // armazena o codigo da classe selecionado no DataGridView 
        private string operacao; //armazena a operacao a ser realizada(inclusao ou alteração /exclusao).
               
        private char tipo;

        //Construdo chamado quando o usuario clica no botao "Novo **classe"(inclusão)
        public FormPessoaManutencao()
        {
            InitializeComponent();
        }

        public FormPessoaManutencao(char tipo)
        {
            this.tipo = tipo;
            this.operacao = "inc";
            InitializeComponent();
        }


        public FormPessoaManutencao(char tipo, int codigo)
        {
            this.tipo = tipo;
            InitializeComponent();
            this.codigo = codigo;
            this.operacao = "alt-exc";
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa(); // Instancia a classe Cargos. 
                                          // Atribui o valor do campo "Nome do Cargo" ao atributo "nome" da classe Cargos. 
            pessoa.Nome = txtb_nome.Text; // Atribui o valor do campo "Departamento" ao atributo "depto" da classe Cargos. 
            pessoa.Email = txtb_email.Text;
            pessoa.Endereco = txtb_endereco.Text;
            pessoa.Cpf = txtb_cpf.Text;
            pessoa.Rg= txtb_rg.Text;
            pessoa.Telefone = txtb_telefone.Text;
            pessoa.Tipo = tipo;

            if (operacao == "inc")
            { // Se operacao for de inclusao. 
              // Chama o metodo Incluir da classe CargosOperacoes, passando como argumento
              // contendo os dados do cargo a ser incluido. 
                PessoaOperacao.Incluir(pessoa);
            }
            else
            { // Se operacao for de alteracao. 
              // Atribui o valor do campo "Cadigo" (recebido pelo construtor) ao atributo ' 
                pessoa.Id = codigo; // Chama o metodo Alterar da classe CargosOperacoes, passando como argumento
                                    // contendo os dados do cargo a ser alterado. 
                PessoaOperacao.Alterar(pessoa);
            }
            this.Close(); // Fecha o formulario de manutencao apps salvar. 
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            // Emite uma mensagem para confirmacao da exclus5o. 
            if (MessageBox.Show("Confirma a excluir essa Pessoa?", "Atencão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Chama o metodo Excluir da classe CargosOperacoes,
                // passando como argumento o cedigo do cargo a ser excluido.
                PessoaOperacao.Excluir(codigo);
                this.Close(); // Fecha o formulario de manutencão apes excluir. 
            }
        }

        private void FormPessoaManutencao_Load(object sender, EventArgs e)
        {
            if (operacao == "alt-exc")
            {// Se a operacao for de alteracao ou exclusao. 
             // Chama o metodo Consultar da classe CargosOperacoes. 
                Pessoa pessoa = PessoaOperacao.Consultar(codigo);
                txtb_nome.Text = pessoa.Nome;
                txtb_email.Text = pessoa.Email;
                txtb_endereco.Text = pessoa.Endereco;
                txtb_cpf.Text = pessoa.Cpf;
                txtb_rg.Text = pessoa.Rg;
                txtb_telefone.Text = pessoa.Telefone;

            }
        }
    }
}
