<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateMakeupType.aspx.cs" Inherits="MakeMeUpzz.View.UpdateMakeupType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <h1>Insert Makeup Type</h1>
     </div>
     <div>Name <asp:TextBox ID="nameTB" runat="server"></asp:TextBox></div>
     <div><asp:Label ID="errorlbl" runat="server" Text="" ForeColor="Red"></asp:Label></div>
     <div><asp:Button ID="insertbtn" runat="server" Text="Insert" OnClick="insertbtn_Click" /></div>
</asp:Content>
