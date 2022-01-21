<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="CityBusManagementSystem.EmployeeDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
    <table>
               
                <tr>
                   <td>
                       <asp:Label ID="Label2" runat="server" Text="Employee ID"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtEmpID" runat="server" ></asp:TextBox>
                 
                   </td>
               </tr>
    
                <tr>
                   <td>
                       <asp:Label ID="Label3" runat="server" Text="Employee Name"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtEmpName" runat="server"></asp:TextBox>

                   </td>
               </tr>
                <tr>
                   <td>
                       <asp:Label ID="Label4" runat="server" Text="Designation"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtDes" runat="server"></asp:TextBox>

                   </td>
               </tr>
           </table>
       
         <asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" />
       

        <asp:Label ID="LabelRslt" runat="server" Text="Label"></asp:Label>


               <asp:GridView ID="GridView1" runat="server">
               </asp:GridView>

       

   </div>
        </form>
           </body>
</html>




