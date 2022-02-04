<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BusDetails.aspx.cs" Inherits="CityBusManagementSystem.BusDetails" %>
%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BusDetail.aspx.cs" Inherits="CityBusManagementSystem.WebForm1" %>

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
                       <asp:Label ID="Label2" runat="server" Text="Bus Name"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtBusName" runat="server"></asp:TextBox>

                   </td>
               </tr>
                <tr>
                   <td>
                       <asp:Label ID="Label3" runat="server" Text="Bus Number"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtBusNum" runat="server"></asp:TextBox>

                   </td>
               </tr>
                <tr>
                   <td>
                       <asp:Label ID="Label4" runat="server" Text="Route Number"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtRouteNo" runat="server"></asp:TextBox>

                   </td>
               </tr>
                <tr>
                   <td>
                       <asp:Label ID="Label5" runat="server" Text="Arrival Time"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TxtArrival" runat="server"></asp:TextBox>

                   </td>
               </tr>
                   <tr>
                   <td>
                       <asp:Label ID="Label1" runat="server" Text="Departure Time"></asp:Label>

                   </td>
                   <td>
                       <asp:TextBox ID="TextDepart" runat="server"></asp:TextBox>

                   </td>
               </tr>
            </table>
        </div>
        <asp:Button ID="BtnAdd" runat="server" Text="Add" OnClick="BtnAdd_Click" />
        <asp:Button ID="BtnSave" runat="server" Text="Save" OnClick="BtnSave_Click" />
        <asp:Button ID="Btndelete" runat="server" Text="Delete" OnClick="Btndelete_Click" />
        <asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" />
        
       
        
        <p>
            <asp:Label ID="lblResult" runat="server" Text="Result : "></asp:Label>
        </p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        
    </form>
</body>
</html>
