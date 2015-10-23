<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ordrforins.aspx.cs" Inherits="ordrforins" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            text-align: center;
            color: #990000;
            font-size: xx-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="style4" style="text-align: left">
&nbsp;
        <asp:HyperLink ID="HyperLink1" runat="server" 
            NavigateUrl="~/Default.aspx">HOME</asp:HyperLink>
&nbsp;
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/ordrforins.aspx">ORDER FOR INSURANCE</asp:HyperLink>
&nbsp;
<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/requeststatus.aspx">REQUEST STATUS</asp:HyperLink>
&nbsp;
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Default.aspx">LOGOUT</asp:HyperLink>
    &nbsp;&nbsp;
        <asp:HyperLink ID="HyperLink5" runat="server" 
            NavigateUrl="~/policydetails.aspx">POLICY DETAILS</asp:HyperLink>
    </p>
    <p class="style5">
        <strong>ORDER FOR INSURANCE POLICY</strong></p>
    <p>

    </p>
    <span id="span">
    <p class="style4">
        POLICY NAME&nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" 
            runat="server" DataSourceID="SqlDataSource1" DataTextField="policytypename" 
            DataValueField="policytypename" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:policyrequest %>" 
            SelectCommand="SELECT [policytypename] FROM [policy]"></asp:SqlDataSource>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
    <p class="style4">
        &nbsp;&nbsp;
        &nbsp;EMI&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <p class="style4">
        <asp:Button ID="Button1" runat="server" Text="ADD" onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="CANCEL" />
    </p>
    </span>
</asp:Content>

