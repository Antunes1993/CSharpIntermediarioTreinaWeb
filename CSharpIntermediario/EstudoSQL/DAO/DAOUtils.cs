using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoSQL.DAO
{
    public class DAOUtils
    {
        public static DbConnection GetConexao()
        {
            //Nao posso dar um new DbConnection, pois DbConnection é uma classe abstrata. Ela só serve de base para os providers.
            DbConnection conexao = new SqlConnection(@"Server=.\SQLEXPRESS;Database=TreinaWebCSharpIntermediario;User Id=LeonardoSantos;Password=Fumacento#3013;"); //Inserir a string de conexão do banco de dados. 
            conexao.Open();
            return conexao;
        }
        public static DbCommand GetComando(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand(); //Com esse objeto eu posso criar e executar comandos SQL na minha base de dados. 
            return comando; 
        }
        public static DbDataReader GetDataReader(DbCommand comando) //Método para ler as informações da tabela do banco de dados. 
        {
            return comando.ExecuteReader(); //Devolve um DbDataReader com os resultados que o comando contém. 
        }
    }
}
