<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="MakeMeUpzz.View.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Change Password</h1>
    </div>
    <div>
        Old Password <asp:TextBox ID="oldpasswordTB" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        New Password <asp:TextBox ID="newpasswordTB" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        Confirm Password <asp:TextBox ID="confirmPasswordTB" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="errorlbl" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Button ID="changebtn" runat="server" Text="Change Button" OnClick="changebtn_Click" />
    </div>
</asp:Content>
