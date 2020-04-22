using Espaco_da_Beleza_Gerenciamento.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espaco_da_Beleza_Gerenciamento.Dao
{
    class BancoSQL
    {
        private SqlConnection conexao = new SqlConnection(Settings.Default.db_salaoConnectionString);
    

        public void Conexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }

        public bool InserirDeletarAtualizar(string sql)
        {
            Conexao();
            SqlCommand cmd = new SqlCommand(sql, conexao);
            return cmd.ExecuteNonQuery() > 0;


        }
        public DataTable QueryAsDataTable(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conexao);
            DataSet ds = new DataSet();
            da.Fill(ds, "result");
            return ds.Tables["result"];

        }
    }
}
