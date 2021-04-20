using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace serviceProject.DAO
{
    public class Agenda
    {
        public static bool Cadastrar(Models.Agenda agenda)
        {
            try
            {
                using (var conexao = new Models.ProjetoEntities())
                {
                    conexao.Agenda.Add(agenda);
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