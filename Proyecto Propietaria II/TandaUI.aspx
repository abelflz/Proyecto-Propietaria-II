<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TandaUI.aspx.cs" Inherits="Proyecto_Propietaria_II.TandaUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <table style="font-family:Arial">
        <h3>Escoja su tanda de estudio</h3>
        <tr>
            <td>
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Matutino" GroupName="Tanda" /> 
            </td>
        </tr>
        <tr>
            <td>
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Mixto" GroupName="Tanda"/> 
            </td>
        </tr>
        <tr>
            <td>
                <asp:RadioButton ID="RadioButton3" runat="server" Text="Nocturno" GroupName="Tanda"/> 
            </td>
        </tr>
        <tr>
            <td>
                <b>Seleccion: </b>
            </td>
            <td>
                <asp:Label ID="Seleccion" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Confirmar" OnClick="Button1_Click1" />
            </td>
        </tr>

    </table>
    </form>
</body>
</html>
