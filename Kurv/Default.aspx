<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KurvClass.Default" %>


<%@ Register Src="~/CartView.ascx" TagPrefix="uc1" TagName="CartView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>Produkt der skal lægges i kurven</h1>
    

        <table>
            <tr>
                <td>Id</td>
                <td><asp:TextBox ID="TextBox_id" runat="server"></asp:TextBox></td>
                  
            </tr>

            <tr>
                <td>Navn</td>
                <td><asp:TextBox ID="TextBox_navn" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>Pris</td>
                <td><asp:TextBox ID="TextBox_pris" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td>Antal</td>
                <td><asp:TextBox ID="TextBox_antal" runat="server"></asp:TextBox></td>
            </tr>

            <tr>
                <td colspan="2"><asp:Button ID="Button_submit" runat="server" Text="Put i kurv" OnClick="Button_submit_Click" /></td>
            </tr>
        </table>

        <uc1:CartView runat="server" id="CartViewControl" />

    </div>
    </form>
</body>
</html>

