<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="requeststatus.aspx.cs" Inherits="requeststatus" %>

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
            NavigateUrl="~/updateempform.aspx">HOME</asp:HyperLink>
&nbsp;
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/ordrforins.aspx">ORDER FOR INSURANCE</asp:HyperLink>
&nbsp;
<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/requeststatus.aspx">REQUEST STATUS</asp:HyperLink>
&nbsp;
<asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/policydetails.aspx">POLICY DETAILS</asp:HyperLink>
&nbsp;
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/">LOGOUT</asp:HyperLink>
    </p>
    <p class="style5">
        <strong>REQUEST STATUS</strong></p>
    <p>

        <asp:Label ID="Label1" runat="server"></asp:Label>

    </p>

    <p>
    
        <asp:GridView ID="GridView1" runat="server" Width="329px">
        </asp:GridView>
    
    </p>
</asp:Content>

