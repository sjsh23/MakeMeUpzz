<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="MakeMeUpzz.View.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                REGISTER PAGE
            </h1>
        </div>
        <div>
            Username <asp:TextBox ID="usernameTB" runat="server"></asp:TextBox>
        </div>
        <div>
            Email <asp:TextBox ID="emailTB" runat="server"></asp:TextBox>
        </div>
        <div>
            Gender <asp:RadioButton ID="rbMale" runat="server" Text="Male" GroupName="Gender" />
            <asp:RadioButton ID="rbFemale" runat="server" Text="Female" GroupName="Gender" />
        </div>
        <div>
            Password <asp:TextBox ID="passwordTB" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            Confirm Password <asp:TextBox ID="confirmPasswordTB" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            Date of Birth:
        </div>
        <div>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </div>
        <div>
            <asp:Label ID="errorlbl" runat="server" Text="" ForeColor="Red"></asp:Label>
        </div>
        <div>
            <asp:Button ID="registerbtn" runat="server" Text="Register" OnClick="registerbtn_Click" />
        </div>
        <div>
            Already have an account? <asp:HyperLink ID="LoginHL" runat="server" NavigateUrl="~/View/loginPage.aspx">Login</asp:HyperLink>
        </div>
    </form>
</body>
</html>
