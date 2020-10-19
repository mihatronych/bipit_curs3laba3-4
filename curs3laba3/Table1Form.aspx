<%@ Page Title="" Language="C#" MasterPageFile="~/Universal_Thing.Master" AutoEventWireup="true" CodeBehind="Table1Form.aspx.cs" Inherits="curs3laba3.Table1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Читатели<br />
<br />
<br />
<asp:GridView ID="GridView1" runat="server" CellPadding="4" GridLines="Horizontal" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="420px" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px">
    <FooterStyle BackColor="White" ForeColor="#333333" />
    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="White" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F7F7F7" />
    <SortedAscendingHeaderStyle BackColor="#487575" />
    <SortedDescendingCellStyle BackColor="#E5E5E5" />
    <SortedDescendingHeaderStyle BackColor="#275353" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:libraryConnectionStringFirst %>" SelectCommand="SELECT * FROM [Readers]"></asp:SqlDataSource>
<br />
<br />
<br />
</asp:Content>
