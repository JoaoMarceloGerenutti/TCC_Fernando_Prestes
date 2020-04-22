using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espaco_da_Beleza_Gerenciamento.Dao
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin(String senha)
        {
            cmd.CommandText = "SELECT * FROM Usuarios WHERE senha = @senha";
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows){
                    tem = true;
                }
            }
            catch(SqlException)
            {
                this.mensagem = "Erro com Banco de Dados!";
            }

            return tem;
        }
    }
}
