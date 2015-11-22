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
    class Proprietario_ImovelOperacao
    {
        private static string stringConexao = ConfigurationManager.
           ConnectionStrings[@"Home.Properties.Settings.masterimovelConnectionString"].
           ConnectionString;

        public static void Incluir(Proprietario_Imovel proprietario_imovel)
        {

            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados. 
            string comando = @"insert INTO proprietario_imovel
                                                 (id_imovel
                                                 ,id_proprietario) VALUES
                                                 (" + // Instruc5o SQL a ser executada.
                                                          "'" + proprietario_imovel.Imovel.Id + "'," +
                                                          "'" + proprietario_imovel.Proprietario.Id + "')";
            conexao.Open(); // Abre a conexao com o banco de dados.
                            // Determina a instruc5o SQL e a string de conexio a ser usada. 
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucio SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }

        public static void Alterar(Proprietario_Imovel proprietario_imovel)
        {
            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados. 
            string comando = @"update proprietario_imovel set " + // Instrucao SQL a ser executada. 
                                                         "id_imovel = '" + proprietario_imovel.Imovel.Id + "', " +
                                                         "id_proprietario = '" + proprietario_imovel.Proprietario.Id + "'" +
                                                         "where id = " + proprietario_imovel.Id;
            conexao.Open(); // Abre a conexao com o banco de dados.
                            // Determina a instrucao SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucao SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }

        public static void Excluir(int codigo)
        {
            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados.
            string comando = @"delete from proprietario_imovel where id = " +  // Instrucao SQL a ser executada. 
                codigo.ToString();
            conexao.Open(); // Abre a conexao com o banco de dados. 
                            // Determina a instruc5o SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            sql.ExecuteNonQuery(); // Executa a instrucao SQL no banco de dados. 
            conexao.Close(); // Fecha a conexao com o banco de dados. 
        }


        public static Proprietario_Imovel Consultar(int codigo)
        {
            Proprietario_Imovel proprietario_imovel = new Proprietario_Imovel(); // Instancia a classe Cargos. 
            SqlConnection conexao = new SqlConnection(stringConexao); // Define a conexao com o banco de dados.
            string comando = @" select * from proprietario_imovel where id = " + // Instrucao SQL a ser executada.
            codigo.ToString();
            conexao.Open(); // Abre a conexao com o banco de dados. 
                            // Determina a instrucao SQL e a string de conexao a ser usada.
            SqlCommand sql = new SqlCommand(comando, conexao);
            // Cria um objeto Sq1DataReader pars ler os registros retornados pela consulta. 
            SqlDataReader dr = sql.ExecuteReader();
            dr.Read(); // La os registros retornados pela consulta. 
                       // Obtem o valor do campo "Cedigo" da linha selecionada no DataGridView e
                       // atribui este valor ao atributo "id" da classe Cargos.
            proprietario_imovel.Id = dr.GetInt32(0); // Obtem o valor do campo "Nome do Cargo" da linha selecionada no DataGridView e
                                                     // atribui este valor ao atributo "nome" da classe Cargos. 
            proprietario_imovel.Imovel.Id = dr.GetInt32(1); // Obtem o valor do campo "Departamento" da linha selecionada no DataGridView e 
                                                            // atribui este valor ao atributo "depto" da classe Cargos.
            proprietario_imovel.Proprietario.Id = dr.GetInt32(2);
    
            dr.Close(); // Fecha o objeto SqlDataReader.
            conexao.Close(); // Fecha a conexao com o banco de dados.
            return (proprietario_imovel);
            // Retorna o objeto cargos contendo os valores dos tras campos. 

        }
    }
}
