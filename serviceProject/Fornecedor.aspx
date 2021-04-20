<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fornecedor.aspx.cs" Inherits="serviceProject.Cliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .container{
            width: 450px;
            margin: 0 auto;
        }

        .container h1{
            text-align: center;
        }

        .campo{
            padding: 10px;
        }

        .campo input[type="text"]{
            float: right;
            width: 350px;

        }

        .campo input[type="submit"]{
            float: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Cadastro de Fornecedor</h1>
            <div class="campo">
                <asp:Label runat="server" AssociatedControlID="txtNome">Nome:</asp:Label>
                <asp:TextBox runat="server" ID="txtNome"></asp:TextBox>
            </div>
            <div class="campo">
                <asp:Label runat="server" AssociatedControlID="txtEmail">Email:</asp:Label>
                <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
            </div>
            <div class="campo">
                <asp:Label runat="server" AssociatedControlID="txtTelefone">Telefone:</asp:Label>
                <asp:TextBox runat="server" ID="txtTelefone"></asp:TextBox>
            </div>
            <div class="campo">
                <asp:Label runat="server" AssociatedControlID="txtEnd">Endereço:</asp:Label>
                <asp:TextBox runat="server" ID="txtEnd"></asp:TextBox>
            </div>
            <div class="campo">
                <asp:Label runat="server" AssociatedControlID="txtService">Serviço:</asp:Label>
                <asp:TextBox runat="server" ID="txtService"></asp:TextBox>
            </div>
            
            <div class="campo">
                <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" />
            </div>
            <p><asp:Literal runat="server" ID="ltMensagem"></asp:Literal></p>
        </div>
    </form>
</body>
</html>
