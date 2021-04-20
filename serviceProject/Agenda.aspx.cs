using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace serviceProject
{
    public partial class Agenda : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            btnAdd.Click += btnAdd_Click;
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var novaAgenda = new Models.Agenda();
            novaAgenda.Servico = txtService.Text;
            novaAgenda.Horario = txtHorario.Text;
            novaAgenda.Telefone = txtTelefone;

            bool cadastrado = DAO.Agenda.Cadastrar(novaAgenda);
            if (cadastrado)
            {
                ltMensagem.Text = novaAgenda.Servico + "foi cadastrado(a) com sucesso";
            }
            else
            {
                ltMensagem.Text = "Ocorreu um erro ao cadastrar" + novaAgenda.Servico;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}