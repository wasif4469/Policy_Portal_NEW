<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Quiz.aspx.cs" Inherits="Policy_Portal.WebForm1" %>

<%@ MasterType VirtualPath ="~/Site1.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div>
            <h1><center class="auto-style1">QUIZ FOR POLICIES</center></h1>
            <br />
            <br />
            <asp:Label ID="Att" runat="server" Text="Attempt" Font-Bold="true"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Note" runat="server" Text="Note: Please complete the quiz in single attempt:" Font-Bold="true"></asp:Label><asp:Button ID="Button2" runat="server" class="btn btn-danger btn-xs" href="#" Text="Proceed" OnClick="Button2_Click" />
            <br />
            <br />
         
            <asp:Label ID="Label1" runat="server" Text="Q1. What is the objective of the Automated Patch Management Policy?" Font-Bold="True"></asp:Label>
            <asp:RadioButtonList ID="Q1" runat="server">
                <asp:ListItem Text="A. To generate and review patch compliance reports" Value="1" />
                <asp:ListItem Text="B. To maintain the integrity of network systems and data by applying the latest operating system and application patches" Value="2" />
                <asp:ListItem Text="C. To manually apply patches for certain applications" Value="3" />
                <asp:ListItem Text="D. To analyze and review patches before applying them" Value="4" />

            </asp:RadioButtonList>
            <br />


            <asp:Label ID="Label2" runat="server" Text="Q2. Who is responsible for coordinating patch analysis with system admins, network admins, DBAs, and application developers?" Font-Bold="True"></asp:Label>
            <asp:RadioButtonList ID="Q2" runat="server">
                <asp:ListItem Text="A.Network Operation" Value="1" />
                <asp:ListItem Text="B.Security Operations Centre" Value="2" />
                <asp:ListItem Text="C.Group Head Technology and Project Management" Value="3" />
                <asp:ListItem Text="D.SOC team" Value="4" />

            </asp:RadioButtonList>

            <br />

            
            <asp:Label ID="Label3" runat="server" Text="Q3. Which patches are applied through a manual process?" Font-Bold="True"></asp:Label>
            <asp:RadioButtonList ID="Q3" runat="server">
                <asp:ListItem Text="A.Core Application, Oracle Application Servers, Power BI Application, Web Server" Value="1" />
                <asp:ListItem Text="B.Client Java and JRE versions" Value="2" />
                <asp:ListItem Text="C.All unmanaged systems" Value="3" />
                <asp:ListItem Text="D.All servers and applications in the production environment" Value="4" />

            </asp:RadioButtonList>

            <br />

            
            <asp:Label ID="Label4" runat="server" Text="Q4. What should be done if a patch is not recommended by stakeholders?" Font-Bold="True" ></asp:Label>
            <asp:RadioButtonList ID="Q4" runat="server">
                <asp:ListItem Text="A.Initiate the Patch Exception process" Value="1" />
                <asp:ListItem Text="B.Revert any patches that have been applied" Value="2" />
                <asp:ListItem Text="C.Apply the patch without approval" Value="3" />
                <asp:ListItem Text="D.Update the centralized repository with the patch details" Value="4" />

            </asp:RadioButtonList>

            <br />

            
            <asp:Label ID="Label5" runat="server" Text="Q5. When will a patch be reversed during the Patch Reversal Process?" Font-Bold="True" ></asp:Label>
            <asp:RadioButtonList ID="Q5" runat="server">
                <asp:ListItem Text="A.If a backup of the old application/server is available" Value="1" />
                <asp:ListItem Text="B.If no solution is available in 3 business days or defined RTO of the application" Value="2" />
                <asp:ListItem Text="C.If there are any issues found in the application after applying the patch" Value="3" />
                <asp:ListItem Text="D.If the Group Head rejects the patch exception request" Value="4" />

            </asp:RadioButtonList>

            <br  />

            
            <asp:Label ID="Label6" runat="server" Text="Q6. Who is responsible for the installation of updates/upgrades of the backup software in the servers?" Font-Bold="True" ></asp:Label>
            <asp:RadioButtonList ID="Q6" runat="server">
                <asp:ListItem Text="A.Database Administrator" Value="1" />
                <asp:ListItem Text="B.Infrastructure team" Value="2" />
                <asp:ListItem Text="C.System Administrator" Value="3" />
                <asp:ListItem Text="D.Group Head Technology and Project Management" Value="4" />

            </asp:RadioButtonList>

            <br />
            
            <asp:Label ID="Label7" runat="server" Text="Q7. How long are daily backups retained?" Font-Bold="True"></asp:Label>
            <asp:RadioButtonList ID="Q7" runat="server">
                <asp:ListItem Text="A.1 year" Value="1" />
                <asp:ListItem Text="B.1 month" Value="2" />
                <asp:ListItem Text="C.4/5 weeks" Value="3" />
                <asp:ListItem Text="D.7 days" Value="4" />

            </asp:RadioButtonList>

            <br />

            
            <asp:Label ID="Label8" runat="server" Text="Q8. What action is taken when a server is added to the production environment?" Font-Bold="True"></asp:Label>
            <asp:RadioButtonList ID="Q8" runat="server">
                <asp:ListItem Text="A.It automatically starts receiving daily backups" Value="1" />
                <asp:ListItem Text="B.It is added to the backup system for scheduled or on demand backups" Value="2" />
                <asp:ListItem Text="C.Backup of the server is skipped" Value="3" />
                <asp:ListItem Text="D.Backup retention is reduced for that server" Value="4" />

            </asp:RadioButtonList>

            <br />


            
            <asp:Label ID="Label9" runat="server" Text="Q9. What is the retention period for monthly backups?" Font-Bold="True"></asp:Label>
            <asp:RadioButtonList ID="Q9" runat="server">
                <asp:ListItem Text="A. ~1 Month" Value="1" />
                <asp:ListItem Text="B. 4/5 weeks" Value="2" />
                <asp:ListItem Text="C. 7 days" Value="3" />
                <asp:ListItem Text="D. ~1 Year" Value="4" />

            </asp:RadioButtonList>
             <br  />


            
            <asp:Label ID="Label10" runat="server" Text="Q10. Who is responsible for restoring physical or logical data on request?" Font-Bold="True"></asp:Label>
            <asp:RadioButtonList ID="Q10" runat="server">
                <asp:ListItem Text="A.Fileserver Administrator" Value="1" />
                <asp:ListItem Text="B.Group Head Technology and Project Management" Value="2" />
                <asp:ListItem Text="C.Designated IT staff" Value="3" />
                <asp:ListItem Text="D.JLI Infrastructure team" Value="4" />

            </asp:RadioButtonList>
            <br />

            <asp:Button ID="Button1" runat="server" class="btn btn-danger btn-xs" href="#" Text="Submit" OnClick="condition" />

            <br />
          <br />
            


          <%--  <asp:Panel ID="Panel1" BorderWidth="100px" BorderStyle="None" BorderColor="Red" GroupingText="Result" Font-Bold="true" runat="server" Height="120px"> 

      
            </asp:Panel> --%>

                    <asp:Label ID="result" runat="server" Height="30px" Font-Bold="true" Font-Size="Large"></asp:Label>



            
       




        </div>
</asp:Content>

