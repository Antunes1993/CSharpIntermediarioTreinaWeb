using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoSQL.DAO
{
    public class EstoqueDAO //Essa classe vai manipular a tabela de banco de dados. 
    {
        //Esse metodo vai se conectar ao banco de dados, carregar e exibir os registros do database.
        public DataTable GetProdutos() //Trocar para DataTable quando for usar DataTable.
        {
            DbConnection conexao = DAOUtils.GetConexao();  //Conexao aberta com a base configurada na conection string.
            DbCommand comando = DAOUtils.GetComando(conexao); //Cria comando apontando para a conexão.
            comando.CommandType = CommandType.Text; //Comando executado do tipo texto. 
            comando.CommandText = "SELECT * FROM Produtos"; //Instrução passada ao comando.
            DbDataReader reader = DAOUtils.GetDataReader(comando); //Envia o comando e retorna as informações

            /* Problema: O datagrid view não consegue ser abastecido com um reader. Enão não adianta dar return reader.
             * Ele só consegue ser abastecido com DataTables ou DataSets. Caso só queira visualizar os dados no banco de 
             * dados, utilize DataReader. Caso queira alterar os valores, use DataSet.
             */

            //Usando DataTable
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;

            //Usando Dataset
            //DbDataAdapter adapter = new SqlDataAdapter((SqlCommand)comando);
            //DataSet ds = new DataSet();
            //adapter.Fill(ds, "Produtos");
            //return ds;
        }
        public void ExcluirProdutos(int id)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            /* Concatenar o comando SQL com uma string abre brecha para SQL Injection.
             * Neste caso não teria tanto problema pois estamos enviando um id inteiro.
             * No entanto se estivéssemos enviando um string, estaríamos abrindo margem
             * para o sql injection. */
            //comando.CommandText = "DELETE FROM Produtos WHERE ID = " + id.ToString();

            //Jeito certo:
            comando.CommandText = "DELETE FROM Produtos WHERE ID = @id";
            comando.Parameters.Add(new SqlParameter("@id", id)); //Essa classe SqlParameter já se protege contra SqlInjection.

            /* Como não iremos trazer nada do Db usamos ExecuteNonQuery. Se fossemos trazer algo do banco de dados usamos 
             * ExecuteReader. Só o que o ExecuteNonQuery retornará é o número de linhas afetadas. */
            comando.ExecuteNonQuery(); 
        }

    }
}
