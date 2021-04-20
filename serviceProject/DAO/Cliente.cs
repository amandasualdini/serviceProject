using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace serviceProject.DAO
{
    public class Cliente
    {
        public static bool Cadastrar(Models.Cliente cliente)
        {
            try
            {
                using (var conexao = new Models.ProjetoEntities())
                {
                    conexao.Cliente.Add(cliente);
                    conexao.SaveChanges();
                    return true;
                }
            }
            catch (Exception erro)
            {
                return false;
            }
        }
    }
}