<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateMakeup.aspx.cs" Inherits="MakeMeUpzz.View.MakeupUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <h1>Insert Makeup</h1>
    </div>
    <div>
       Name <asp:TextBox ID="nameTB" runat="server"></asp:TextBox>
    </div>
    <div>
        Price <asp:TextBox ID="priceTB" runat="server"></asp:TextBox>
    </div>
    <div>
       Weight <asp:TextBox ID="weightTB" runat="server"></asp:TextBox>
    </div>
    <div>
        Type ID <asp:DropDownList ID="TypeIDDDL" runat="server"></asp:DropDownList>
    </div>
    <div>
        Brand ID<asp:DropDownList ID="BrandIDDDL" runat="server"></asp:DropDownList>
    </div>
    <div>
       <asp:Label ID="errorlbl" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Button ID="updatebtn" runat="server" Text="Update" OnClick="updatebtn_Click"/>
        <asp:Button ID="backbtn" runat="server" Text="Back" OnClick="backbtn_Click" />
    </div>
</asp:Content>
