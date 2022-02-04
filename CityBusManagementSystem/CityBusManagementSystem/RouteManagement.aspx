<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RouteManagement.aspx.cs" Inherits="CityBusManagementSystem.WebForm1" %>

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
                       <asp:Label ID="Label2" runat="server" Text="Route Number"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtRouteNum" runat="server"></asp:TextBox>

                   </td>
               </tr>
                <tr>
                   <td>
                       <asp:Label ID="Label3" runat="server" Text="Number Of Stops"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtNumOfStops" runat="server"></asp:TextBox>

                   </td>
               </tr>
                <tr>
                   <td>
                       <asp:Label ID="Label4" runat="server" Text="Start Time"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtStartTime" runat="server"></asp:TextBox>

                   </td>
               </tr>
                <tr>
                   <td>
                       <asp:Label ID="Label5" runat="server" Text="End Time"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtEndTime" runat="server"></asp:TextBox>

                   </td>
               </tr>
            </table>
        </div>
        <asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" />
        <asp:Button ID="Btndelete" runat="server" Text="Delete" OnClick="Btndelete_Click" />
        <asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" />
        <asp:Button ID="BtnExit" runat="server" Text="Exit" OnClick="BtnExit_Click" />
       
        
        <p>
            <asp:Label ID="lblResults" runat="server" Text="Result : "></asp:Label>
        </p>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        
    </form>
</body>
</html>
