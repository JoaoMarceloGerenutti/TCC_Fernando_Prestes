using Espaco_da_Beleza_Gerenciamento.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Espaco_da_Beleza_Gerenciamento.Model
{
    public class Controle
    {
        public bool tem;
        public String mensagem = ""; 

        public bool acessar(String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
    }
}
