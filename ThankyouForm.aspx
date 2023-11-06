<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ThankyouForm.aspx.cs" Inherits="Policy_Portal.ThankyouForm" %>

<%@ MasterType VirtualPath ="~/Site1.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <h1><center class="auto-style1">THANK YOU!</center></h1>
            <br />
            <br />
    <br />
    <br />
    <br />
    <br />
            <center class="auto-style1"><asp:Label ID="msg" runat="server" Text="The quiz response has been succesfully submitted" Font-Bold="true"></asp:Label></center>
            <br />
            <center class="auto-style1"><asp:Label ID="result" runat="server" Text="Your quiz percentage is:" Font-Bold="true" Font-Size="Larger"></asp:Label></center>
            <br />
            <center class="auto-style1"><asp:Label ID="remarks" runat="server" Text="You're score is below the benchmark (Try again later)" Font-Bold="true"></asp:Label></center>
</asp:Content>