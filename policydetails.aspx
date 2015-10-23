<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="policydetails.aspx.cs" Inherits="policydetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            font-size: x-large;
            color: #800000;
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
<asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/policydetails.aspx">POLICY DETAILS</asp:HyperLink>
&nbsp;
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/">LOGOUT</asp:HyperLink>
    </p>
    <p class="style4">
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <strong><span class="style5">&nbsp;&nbsp; POLICY DETAILS&nbsp;</span></strong></p>
   
   <p>
   
       <asp:GridView ID="GridView1" runat="server" style="margin-right: 97px" 
           Width="781px" Height="258px">
       </asp:GridView>
   
   </p>
</asp:Content>

