<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="MakeMeUpzz.View.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>
            Home
        </h1>
    </div>
    <div>
        Role: <%= user.UserRole %>
    </div>
    <div>
        Name: <%= user.Username %>
    </div>
    
    <div>
        <%if (user.UserRole.Equals("admin")) {%>
        <br />
        Customer List
        <asp:GridView ID="CustomerGV" runat="server"></asp:GridView>
        <%} %>
    </div>
</asp:Content>
