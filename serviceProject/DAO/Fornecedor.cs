using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace serviceProject.DAO
{
    public class Fornecedor
    {
        public static bool Cadastrar(Models.Fornecedor fornecedor)
        {
            try
            {
                using (var conexao = new Models.ProjetoEntities())
                {
                    conexao.Fornecedor.Add(fornecedor);
                    conexao.SaveChanges();
                    return true;
                }
            } catch (Exception erro)
            {
                return false;
            }
        }
    }
}