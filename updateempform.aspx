<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="updateempform.aspx.cs" Inherits="updateempform" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style5
        {
            text-align: center;
            color: #990000;
            font-size: xx-large;
        }
        .style12
        {
            text-align:left;
            margin-left:40%;
            }
            .style14{}
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
&nbsp;
<asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="~/policydetails.aspx">POLICY DETAILS</asp:HyperLink>
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/">LOGOUT</asp:HyperLink>
    </p>
    <p class="style4">
        &nbsp;</p>
    <p class="style5">
        <strong>&nbsp;UPDATE EMPLOYEE FORM</strong></p>
    <p class="style5">
        &nbsp;</p>
       <center> <div class=style12>
    <p class="style14">
        FIRST NAME&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator3" 
            runat="server" ControlToValidate="TextBox1" 
            ErrorMessage="Enter a valid first name..." ValidationExpression="\w{3,40}"></asp:RegularExpressionValidator>
    </p>
    <p class="style14">
        LAST NAME&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
       &nbsp; <asp:RegularExpressionValidator ID="RegularExpressionValidator4" 
            runat="server" ControlToValidate="TextBox2" 
            ErrorMessage="Enter a valid last name..." ValidationExpression="\w{3,40}"></asp:RegularExpressionValidator>
    </p>
    <p class="style14">
        USERNAME&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:TextBox ID="TextBox3" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p class="style14">
        PASSWORD&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox4" runat="server" TextMode=SingleLine></asp:TextBox>
    </p>
    <p class="style14">
        CITY&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator5" 
            runat="server" ControlToValidate="TextBox5" 
            ErrorMessage="Enter a valid city name..." ValidationExpression="\w{3,40}"></asp:RegularExpressionValidator>
    </p>
    <p class="style14">
        ADDRESS&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox6" runat="server"  Height="86px" Rows="5" 
            TextMode="MultiLine" Width="179px"></asp:TextBox>
    </p>
    <p class="style14">
        &nbsp;CONTACT NO&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="TextBox7" ErrorMessage="Enter a valid  phone number" 
            ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
 
    </p>
     <p class="style14">
        &nbsp;SALARY&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="TextBox8" ErrorMessage="Enter a valid salary..." 
            ValidationExpression="\d{1,10}"></asp:RegularExpressionValidator>
    </p>
    <p class="style14">
        &nbsp;DESIGNATION&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator6" 
            runat="server" ControlToValidate="TextBox9" 
            ErrorMessage="Enter a valid designation name..." ValidationExpression="\w{2,40}"></asp:RegularExpressionValidator>
    </p>
    <p class="style14">
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p class="style14">
        <asp:Button ID="Button1" runat="server" Text="UPDATE" onclick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="CANCEL" />
        <br />
    </p>
    </div></center>
</asp:Content>

