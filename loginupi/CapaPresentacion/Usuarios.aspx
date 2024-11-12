<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="loginupi.CapaPresentacion.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Style/EstiloBotones.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Catalogo de usuarios</h2>
        </div>
        <br />
        <div>

            <label>
                <br />
                <br />
                <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="187px" Width="375px">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
                <br />
                <br />
                <label>
                Codigo               
            </label>
            <br />
            <asp:TextBox ID="tcodigo"  runat="server" required></asp:TextBox>
            <br />
            Nombre               
            </label>
            <br />
            <asp:TextBox ID="tnombre" runat="server" required></asp:TextBox>
            <br />
            <label>clave                </label>
            <br />
            <asp:TextBox ID="tclave" runat="server" required></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="bagregar" class="button button1" runat="server" Text="Agregar" OnClick="bagregar_Click" />
            <asp:Button ID="bborrar" class="button button2" runat="server" Text="Borrar" OnClick="bborrar_Click" />
            <asp:Button ID="bmodificar" class="button button3" runat="server" Text="Modificar" OnClick="bmodificar_Click" />
            <asp:Button ID="bconsultar" class="button button4" runat="server" Text="Consultar" />


        </div>
    </form>
</body>
</html>
