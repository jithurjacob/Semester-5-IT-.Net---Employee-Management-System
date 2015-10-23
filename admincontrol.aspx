<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="admincontrol.aspx.cs" Inherits="admincontrol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/empreg.aspx">EMPLOYEE REGISTRATION</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/addpolicy.aspx">ADD POLICY</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink3" runat="server" 
            NavigateUrl="~/policyrequest.aspx">POLICY DETAILS</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink7" runat="server" 
            NavigateUrl="~/employeepolicy.aspx">EMPLOYEE POLICY DETAILS</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink6" runat="server" 
            NavigateUrl="~/admin_policyrequest.aspx">POLICY REQUESTS</asp:HyperLink>
    </p>
    <p>
        <asp:HyperLink ID="HyperLink4" runat="server" 
            NavigateUrl="~/adminaddpolicy.aspx">ADD POLICY ON EMPLOYEE</asp:HyperLink>
    </p>
     <p>
        <asp:HyperLink ID="HyperLink5" runat="server" 
            NavigateUrl="~/">LOG OUT</asp:HyperLink>
    </p>
    <p>
        <br />
    </p>
</asp:Content>

