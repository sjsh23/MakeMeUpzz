<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="MakeMeUpzz.View.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Profile</h1>
    </div>
    <div>
        Username <asp:TextBox ID="usernameTB" runat="server" ></asp:TextBox>
    </div>
    <div>
        Email <asp:TextBox ID="emailTB" runat="server" ></asp:TextBox>
    </div>
    <div>
        Gender <asp:RadioButton ID="rbMale" runat="server" Text="Male" GroupName="Gender" />
        <asp:RadioButton ID="rbFemale" runat="server" Text="Female" GroupName="Gender" />
    </div>
    <div>DOB </div>
    <div>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </div>
    <div>
        <asp:Label ID="errorlbl" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Button ID="updatebtn" runat="server" Text="Update Profile" OnClick="updatebtn_Click" />
        <asp:Button ID="changePasswordbtn" runat="server" Text="Change Password" OnClick="changePasswordbtn_Click"/>
    </div>
    
</asp:Content>
