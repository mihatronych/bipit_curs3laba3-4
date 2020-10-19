<%@ Page Title="" Language="C#" MasterPageFile="~/UniversalSite1.Master" AutoEventWireup="true" CodeBehind="AddForm.aspx.cs" Inherits="curs3laba4.AddForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style2 {
        height: 630px;
    }
    .auto-style3 {
        margin-left: 0px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style2" style="padding: 20px">
    <br />
    ID:
    <asp:TextBox ID="TextID" runat="server" CssClass="auto-style3" ReadOnly="True"></asp:TextBox>
    <br />
    <br />
    Читатель:
    <asp:DropDownList ID="DropDownListReaders" runat="server" Width="279px">
    </asp:DropDownList>
&nbsp;<br />
    <br />
    Книга:
    <asp:DropDownList ID="DropDownListBooks" runat="server" Height="22px" Width="277px">
    </asp:DropDownList>
    <br />
    <br />
    Книга взята на срок от:
    <asp:TextBox ID="TextBoxFrom" runat="server"></asp:TextBox>
    <br />
    <br />
    Книга взята на срок до:
    <asp:TextBox ID="TextBoxTo" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" BackColor="#33CC33" BorderStyle="Inset" OnClick="Button1_Click" Text="Добавить" />
    <br />
    <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/ListForm.aspx" Visible="False">HyperLink</asp:HyperLink>
</div>
</asp:Content>
