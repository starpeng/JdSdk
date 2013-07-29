<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Setting.aspx.cs" Inherits="WebSample.Setting" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <table border="1">
            <thead>
                <tr>
                    <td colspan="2">
                        获取授权
                    </td>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>
                        App key
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtAppKey" Width="250px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        App Secret
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtAppSecret" Width="250px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        回调地址</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtCallbackUrl" Width="250px">http://localhost:2345/loginok.aspx</asp:TextBox>
                    </td>
                </tr>
            </tbody>
        </table>
        <asp:Button ID="btnAuthon" runat="server" Text="授权" OnClick="btnAuthon_Click" Width="62px" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
