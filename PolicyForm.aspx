<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PolicyForm.aspx.cs" Inherits="Policy_Portal.PolicyForm" %>

<%@ MasterType VirtualPath ="~/Site1.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div>
            <h1><center>IT DEPARTMENT POLICIES</center></h1>
            <br />
            <div>
    <div>
    <table class="table table-striped custab">
    <thead>
        <tr>
            <th>ID</th>
            <th>Policy Name</th>
            <th class="text-center">Action</th>
        </tr>
    </thead>
            <tr>
                <td>1</td>
                <td>Automated Patch Management Policy</td>
                <td class="text-center"><a><span><asp:Button ID="Button1" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile1" /></span></a></td>
            </tr>
            <tr>
                <td>2</td>
                <td>Backup Restoration and Retention Policy</td>
                <td class="text-center"><a><span><asp:Button ID="Button2" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile2" /></span></a></td>
            </tr>
            <tr>
                <td>3</td>
                <td>IT Risk Management Policy</td>
                <td class="text-center"><a><span><asp:Button ID="Button3" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile3" /></span></a></td>
            </tr>
            <tr>
                <td>4</td>
                <td>Standard Operating Procedure (SOP) For End of Day (EOD)</td>
                <td class="text-center"><a><span><asp:Button ID="Button4" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile4" /></span></a></td>
            </tr>

               <tr>
                <td>5</td>
                <td>Active Directory and Email Access Management</td>
                <td class="text-center"><a><span><asp:Button ID="Button5" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile5" /></span></a></td>
            </tr>
         <tr>
                <td>6</td>
                <td>Software Development Policy and Procedure</td>
                <td class="text-center"><a><span><asp:Button ID="Button6" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile6" /></span></a></td>
            </tr>
         <tr>
                <td>7</td>
                <td>Capacity Planning</td>
                <td class="text-center"><a><span><asp:Button ID="Button7" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile7" /></span></a></td>
            </tr>
         <tr>
                <td>8</td>
                <td>Change Management</td>
                <td class="text-center"><a><span><asp:Button ID="Button8" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile8" /></span></a></td>
            </tr>
         <tr>
                <td>9</td>
                <td>Database Management</td>
                <td class="text-center"><a><span><asp:Button ID="Button9" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile9" /></span></a></td>
            </tr>
         <tr>
                <td>10</td>
                <td>Emergency Change Management</td>
                <td class="text-center"><a><span><asp:Button ID="Button10" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile10" /></span></a></td>
            </tr>
         <tr>
                <td>11</td>
                <td>Helpdesk / Technology Support</td>
                <td class="text-center"><a><span><asp:Button ID="Button11" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile11" /></span></a></td>
            </tr>
         <tr>
                <td>12</td>
                <td>IT Asset Management</td>
                <td class="text-center"><a><span><asp:Button ID="Button12" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile12" /></span></a></td>
            </tr>
         <tr>
                <td>13</td>
                <td>Technology Budgeting Policy</td>
                <td class="text-center"><a><span><asp:Button ID="Button13" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile13" /></span></a></td>
            </tr>
                 <tr>
                <td>14</td>
                <td>Technology Governance Policy</td>
                <td class="text-center"><a><span><asp:Button ID="Button14" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile14" /></span></a></td>
            </tr>
                 <tr>
                <td>15</td>
                <td>IT Monitoring</td>
                <td class="text-center"><a><span><asp:Button ID="Button15" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile15" /></span></a></td>
            </tr>
                 <tr>
                <td>16</td>
                <td>Technology Personnel Management, Training and Job Description</td>
                <td class="text-center"><a><span><asp:Button ID="Button16" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile16" /></span></a></td>
            </tr>
                 <tr>
                <td>17</td>
                <td>Physical Access Management</td>
                <td class="text-center"><a><span><asp:Button ID="Button17" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile17" /></span></a></td>
            </tr>
                 <tr>
                <td>18</td>
                <td>Technology Strategic Planning</td>
                <td class="text-center"><a><span><asp:Button ID="Button18" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile18" /></span></a></td>
            </tr>
                 <tr>
                <td>19</td>
                <td>Logical Access Management</td>
                <td class="text-center"><a><span><asp:Button ID="Button19" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile19" /></span></a></td>
            </tr>
                 <tr>
                <td>20</td>
                <td>Network Management</td>
                <td class="text-center"><a><span><asp:Button ID="Button20" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile20" /></span></a></td>
            </tr>
             <tr>
                <td>21</td>
                <td>Project Documentation Policy</td>
                <td class="text-center"><a><span><asp:Button ID="Button21" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile21" /></span></a></td>
            </tr>
            <tr>
                <td>22</td>
                <td>Quality Assurance</td>
                <td class="text-center"><a><span><asp:Button ID="Button22" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile22" /></span></a></td>
            </tr>
                         <tr>
                <td>23</td>
                <td>Supplier Management</td>
                <td class="text-center"><a><span><asp:Button ID="Button23" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile23" /></span></a></td>
            </tr>
                         <tr>
                <td>24</td>
                <td>System Management and Administration</td>
                <td class="text-center"><a><span><asp:Button ID="Button24" runat="server" class="btn btn-danger btn-xs" href="#" Text="Download File" OnClick="DownloadFile24" /></span></a></td>
            </tr>
    </table>
    </div>
</div>
</div>

</asp:Content>

