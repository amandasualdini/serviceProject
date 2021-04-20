using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace serviceProject
{
    public partial class Cliente : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            btnCadastrar.Click += btnCadastrar_Click;
        }

        void btnCadastrar_Click(object sender, EventArgs e)
        {
            var novoCliente = new Models.Cliente();
            novoCliente.Nome = txtNome.Text;
            novoCliente.Email = txtEmail.Text;
            novoCliente.Telefone = txtTelefone;
            novoCliente.Endereço = txtEnd.Text;

            bool cadastrado = DAO.Cliente.Cadastrar(novoCliente);
            if (cadastrado)
            {
                ltMensagem.Text = novoCliente.Nome + "foi cadastrado(a) com sucesso";
            }
            else
            {
                ltMensagem.Text = "Ocorreu um erro ao cadastrar" + novoCliente.Nome;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}