<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="InsertMakeupBrand.aspx.cs" Inherits="MakeMeUpzz.View.InsertMakeupBrand" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Insert Makeup Brand</h1>
    </div>
    <div>Name <asp:TextBox ID="nameTB" runat="server"></asp:TextBox></div>
    <div>Rating <asp:TextBox ID="ratingTB" runat="server"></asp:TextBox></div>
    <div><asp:Label ID="errorlbl" runat="server" Text="" ForeColor="Red"></asp:Label></div>
    <div><asp:Button ID="insertbtn" runat="server" Text="Insert" OnClick="insertbtn_Click" /></div>
</asp:Content>
