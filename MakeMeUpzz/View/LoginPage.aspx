<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="MakeMeUpzz.View.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                LOGIN PAGE
            </h1>
        </div>
        <div>
            Username <asp:TextBox ID="UsernameTB" runat="server"></asp:TextBox>
        </div>
        <div>
            Password<asp:TextBox ID="PasswordTB" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="rememberMeCB" runat="server" Text="remember me" />
        </div>
        <div>
            <asp:Label ID="errorlbl" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
        <div>
            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
        </div>
        <div>
         Don't have an account? <asp:HyperLink ID="registerHL" runat="server" NavigateUrl="~/View/RegisterPage.aspx">Register</asp:HyperLink>
        </div>
        
    </form>
</body>
</html>
