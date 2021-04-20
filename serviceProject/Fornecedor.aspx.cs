using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace serviceProject
{
    public partial class Fornecedor : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            btnCadastrar.Click += btnCadastrar_Click;
        }

        void btnCadastrar_Click(object sender, EventArgs e)
        {
            var novoFornecedor = new Models.Fornecedor();
            novoFornecedor.Nome = txtNome.Text;
            novoFornecedor.Email = txtEmail.Text;
            novoFornecedor.Telefone = txtTelefone.Text;
            novoFornecedor.Endereco = txtEndereco.Text;
            novoFornecedor.Servico = txtService.Text;

            bool cadastrado = DAO.Fornecedor.Cadastrar(novoFornecedor);
            {
                ltMensagem.Text = novoFornecedor.Nome + "foi cadastrado(a) com sucesso";
            }
            else
            {
                ltMensagem.Text ="Ocorreu um erro ao cadastrar" +novoFornecedor.Nome;
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}