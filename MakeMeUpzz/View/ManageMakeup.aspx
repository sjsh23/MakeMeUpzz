<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="ManageMakeup.aspx.cs" Inherits="MakeMeUpzz.View.ManageMakeup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Manage Makeup</h1>
    </div>
    <div>
        <h2>Makeup</h2>
    </div>
    <div>
        <asp:GridView ID="makeupGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="makeupGV_RowDeleting" OnRowEditing="makeupGV_RowEditing">
            <Columns>
                <asp:BoundField DataField="MakeupID" HeaderText="ID" SortExpression="MakeupID" />
                <asp:BoundField DataField="MakeupName" HeaderText="Name" SortExpression="MakeupName" />
                <asp:BoundField DataField="MakeupPrice" HeaderText="Price" SortExpression="MakeupPrice" />
                <asp:BoundField DataField="MakeupWeight" HeaderText="Weight" SortExpression="MakeupWeight" />
                <asp:BoundField DataField="MakeupTypeID" HeaderText="Type ID" SortExpression="MakeupTypeID" />
                <asp:BoundField DataField="MakeupBrandID" HeaderText="Brand ID" SortExpression="MakeupBrandID" />
                <asp:CommandField ButtonType="Button" HeaderText="Action" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Label ID="errorlbl1" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Button ID="insertMakeupbtn" runat="server" Text="Insert Makeup" OnClick="insertMakeupbtn_Click" />
    </div>
    <div>
        <h2>MakeupBrand</h2>
    </div>
    <div>
        <asp:GridView ID="makeupBrandGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="makeupBrandGV_RowDeleting" OnRowEditing="makeupBrandGV_RowEditing">
            <Columns>
                <asp:BoundField DataField="MakeupBrandID" HeaderText="ID" SortExpression="MakeupBrandID" />
                <asp:BoundField DataField="MakeupBrandName" HeaderText="Brand Name" SortExpression="MakeupBrandName" />
                <asp:BoundField DataField="MakeupBrandRating" HeaderText="Rating" SortExpression="MakeupBrandRating" />
                <asp:CommandField ButtonType="Button" HeaderText="Action" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Label ID="errorlbl2" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Button ID="insertBrandbtn" runat="server" Text="Insert Makeup Brand" OnClick="insertBrandbtn_Click" />
    </div>
    <div>
        <h2>MakeUpType</h2>
    </div>
    <div>
        <asp:GridView ID="makeupTypeGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="makeupTypeGV_RowDeleting" OnRowEditing="makeupTypeGV_RowEditing">
            <Columns>
                <asp:BoundField DataField="MakeupTypeID" HeaderText="ID" SortExpression="MakeupTypeID" />
                <asp:BoundField DataField="MakeupTypeName" HeaderText="Name" SortExpression="MakeupTypeName" />
                <asp:CommandField ButtonType="Button" HeaderText="Action" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView >
    </div>
    <div>
        <asp:Label ID="errorlbl3" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>
    <div>
        <asp:Button ID="insertTypebtn" runat="server" Text="Insert Makeup Type" OnClick="insertTypebtn_Click" />
    </div>
</asp:Content>
