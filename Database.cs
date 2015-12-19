using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;

namespace Centro_Loca_Mais
{
    class Database
    {
        MySqlCommand inserirComando;
        MySqlConnection conectar;
        public MySqlConnection conexaoBd()
        {
            MySqlConnection conexao = new MySqlConnection("Server=127.0.0.1;Database=centro_loca_mais;Uid=root;Pwd=root;");
            return conexao;
        }
        public MySqlCommand mysqlComando(string aExecultar)
        {
            conectar = conexaoBd();
            inserirComando = new MySqlCommand(aExecultar, conectar);
            return inserirComando;
        }
        public Database addParametro(string chave, object valor)
        {
            inserirComando.Parameters.AddWithValue(chave, valor);
            return this;
        }
        public Database execultaComando(string comando)
        {
            inserirComando = mysqlComando(comando);
            conectar.Open();
            inserirComando.ExecuteNonQuery();
            conectar.Close();
            return this;
        }
    }
}
