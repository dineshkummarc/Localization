<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="font-size: medium; font-family: Arial">
    <form id="form1" runat="server">
    <div>
        <table width="100%">
            <tr>
                <td align="center" bgcolor="#ccccff" colspan="2" width="10%">
                    Translation Through Resources</td>
            </tr>
            <tr>
                <td width="10%">
                    1</td>
                <td width="90%">
                    <asp:Label ID="lbl1" runat="server" Text="Label" Width="100%"></asp:Label></td>
            </tr>
            <tr>
                <td width="10%">
                    2</td>
                <td width="90%">
                    <asp:Label ID="lbl2" runat="server" Text="Label" Width="100%"></asp:Label></td>
            </tr>
            <tr>
                <td width="10%">
                    3</td>
                <td width="90%">
                    <asp:Label ID="lbl3" runat="server" Text="Label" Width="100%"></asp:Label></td>
            </tr>
            <tr>
                <td width="10%">
                    4</td>
                <td width="90%">
                    <asp:Label ID="lbl4" runat="server" Text="Label" Width="100%"></asp:Label></td>
            </tr>
            <tr>
                <td width="10%">
                    5</td>
                <td width="90%">
                    <asp:Label ID="lbl5" runat="server" Text="Label" Width="100%"></asp:Label></td>
            </tr>
            <tr>
                <td style="height: 21px;" width="10%">
                    6</td>
                <td style="height: 21px;" width="90%">
                    <asp:Label ID="lbl6" runat="server" Text="Label" Width="100%"></asp:Label></td>
            </tr>
            <tr>
                <td width="10%">
                </td>
                <td width="90%">
                    &nbsp; &nbsp; &nbsp;
                </td>
            </tr>
            <tr>
                <td width="10%">
                </td>
                <td width="90%">
                    &nbsp;<asp:ImageButton ID="ibtUSA" runat="server" AlternateText="USA" ImageUrl="~/graphics/us.gif" />&nbsp;
                    <asp:ImageButton ID="ibtGermany" runat="server" AlternateText="Germany" ImageUrl="~/graphics/de.gif" />&nbsp;
                    <asp:ImageButton ID="ibtFrance" runat="server" AlternateText="France" ImageUrl="~/graphics/fr.gif" />&nbsp;
                    <asp:ImageButton ID="ibtSpain" runat="server" AlternateText="Spain" ImageUrl="~/graphics/es.gif" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
