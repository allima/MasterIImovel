using Home.modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.dao
{
    class PessoaOperacao
    {
        private static string stringConexao = ConfigurationManager.
          ConnectionStrings[@"FormHome.Properties.Settings.masterimovelConnectionString"].
          ConnectionString;

        public static void Incluir(Pessoa pessoa)
        {

            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados. 
            string comando = @"insert into pessoa
           (nome
           , email
           , endereco
           , cpf
           , rg
           , telefone) values ('" + // Instruc5o SQL a ser executada.
            pessoa.Nome + "','" +
            pessoa.Email + "','" +
            pessoa.Endereco + "','" +
            pessoa.Cpf + "','" +
            pessoa.Rg + "','" +
            pessoa.Telefone + "')";
            conexao.Open(); // Abre a conexao com o banco de dados.
                            // Determina a instruc5o SQL e a string de conexio a ser usada. 
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucio SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }

        public static void Alterar(Pessoa pessoa)
        {
            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados. 
            string comando = @"update pessoa set " + // Instrucao SQL a ser executada. 
                "nome = '" + pessoa.Nome + "', " +
                "email = '" + pessoa.Email + "', " +
                "endereco = '" + pessoa.Endereco + "', " +
                "cpf = '" + pessoa.Cpf + "', " +
                "rg = '" + pessoa.Rg + "',  " +
                "telefone = '" + pessoa.Telefone + "' " +
                "where id = " + pessoa.Id;
            conexao.Open(); // Abre a conexao com o banco de dados.
                            // Determina a instrucao SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucao SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }

        public static void Excluir(int codigo)
        {
            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados.
            string comando = @"delete from pessoa where id = " +  // Instrucao SQL a ser executada. 
                codigo.ToString();
            conexao.Open(); // Abre a conexao com o banco de dados. 
                            // Determina a instruc5o SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucao SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }

        public static Pessoa Consultar(int codigo)
        {
            Pessoa corretor = new Pessoa(); // Instancia a classe Cargos. 
            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados.
            string comando = "select * from pessoa where id = " + // Instrucao SQL a ser executada.
            codigo.ToString();
            conexao.Open(); // Abre a conexao com o banco de dados. 
                            // Determina a instrucao SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            // Cria um objeto Sq1DataReader pars ler os registros retornados pela consulta. 
            SqlDataReader dr = sql.ExecuteReader();
            dr.Read(); // La os registros retornados pela consulta. 
                       // Obtem o valor do campo "Cedigo" da linha selecionada no DataGridView e
                       // atribui este valor ao atributo "id" da classe Cargos.
            corretor.Id = dr.GetInt32(0); // Obtem o valor do campo "Nome do Cargo" da linha selecionada no DataGridView e
                                          // atribui este valor ao atributo "nome" da classe Cargos. 
                                          // corretor.Id = dr.GetInt32(1); // Obtem o valor do campo "Departamento" da linha selecionada no DataGridView e 
                                          // atribui este valor ao atributo "depto" da classe Cargos.
            corretor.Nome = dr.GetString(2);
            corretor.Email = dr.GetString(3);
            corretor.Endereco = dr.GetString(4);
            corretor.Cpf = dr.GetString(5);
            corretor.Rg = dr.GetString(6);
            corretor.Telefone = dr.GetString(6);
            dr.Close(); // Fecha o objeto Sq1DataReader.
            conexao.Close(); // Fecha a conexao com o banco de dados.
            return (corretor);
            // Retorna o objeto cargos contendo os valores dos tras campos. 

        }
    }
}
