<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Site1.Master" AutoEventWireup="true" CodeBehind="OrderMakeup.aspx.cs" Inherits="MakeMeUpzz.View.OrderMakeup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Order Makeup</h1>
    </div>

    <div>
        <asp:GridView ID="makeupGV" runat="server" AutoGenerateColumns="False" OnRowUpdating="makeupGV_RowUpdating">
            <Columns>
                <asp:BoundField DataField="MakeupName" HeaderText="Name" SortExpression="MakeupName" />
                <asp:BoundField DataField="MakeupPrice" HeaderText="Price" SortExpression="MakeupPrice" />
                <asp:BoundField DataField="MakeupWeight" HeaderText="Weight" SortExpression="MakeupWeight" />
                <asp:BoundField DataField="MakeupType.MakeupTypeName" HeaderText="Type" SortExpression="MakeupType.MakeupTypeName" />
                <asp:BoundField DataField="MakeupBrand.MakeupBrandName" HeaderText="Brand" SortExpression="MakeupBrand.MakeupBrandName" />
                <asp:TemplateField HeaderText="Quantity">
                    <ItemTemplate>
                        <asp:HiddenField ID="IDhf" runat="server" Value='<%# Eval("MakeupID") %>' />
                        <asp:TextBox ID="quantityTB" runat="server" ></asp:TextBox> 
                        <asp:Label ID="errorlbl" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            
                <asp:ButtonField ButtonType="Button" CommandName="Update" HeaderText="Add to Cart" ShowHeader="True" Text="Add to Cart" />
            
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <h2>Cart</h2>
    </div>
    <div>
        <asp:GridView ID="cartGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Makeup.MakeupName" HeaderText="Makeup Name" SortExpression="Makeup.MakeupName" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
            </Columns>
        </asp:GridView>
    </div>
    <div>
    <asp:Label ID="alertlbl" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:Button ID="clearCartbtn" runat="server" Text="Clear Cart" OnClick="clearCartbtn_Click" />
        <asp:Button ID="checkoutbtn" runat="server" Text="Check Out" OnClick="checkoutbtn_Click" />
    </div>


</asp:Content>
