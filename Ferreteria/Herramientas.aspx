<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Herramientas.aspx.cs" Inherits="Ferreteria.Herramientas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <p>Gestion de inventario</p>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <asp:UpdatePanel runat="server">
            <ContentTemplate> 
                <div>
                    <table>
                        <tr>
                            <td><asp:Label runat="server" Text="Id Herramienta"></asp:Label></td>
                            <td><asp:TextBox runat="server" ID="txtidHerramienta"></asp:TextBox> </td>
                        </tr>
                        <tr>
                            <td><asp:Label runat="server" Text="Nombre Herramienta"></asp:Label></td>
                            <td><asp:TextBox runat="server" ID="txtnomHerramienta"></asp:TextBox> </td>                   
                        </tr>
                       
                        <tr>
                            <td><asp:Label runat="server" Text="Tipo Herramienta" /></td>
                            <td><asp:DropDownList runat="server" ID="cmbcodTipo"> </asp:DropDownList></td>                                                       
                        </tr>  

                        <tr>
                            <td><asp:Label runat="server" Text="Estado Herramienta" /></td>
                            <td><asp:DropDownList runat="server" ID="cmdIdEstado">
                                    <%--<asp:ListItem Text="Femenino" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Masculino" Value="2"></asp:ListItem>--%>
                                </asp:DropDownList></td>
                        </tr>
                      
                        <tr>
                            <td><asp:Button ID="BtnRegistrar" Text="Registrar" runat="server" OnClick="BtnRegistrar_Click1" /> </td>
                            <td><asp:Button ID="btnActualizar" Text="Actualizar" runat="server" /></td>
                            <td><asp:Button ID="btnEliminar" Text="Eliminar" runat="server" /></td>
                        </tr>



                        <%--<tr>
                            <td><asp:Label runat="server" Text="Nacionalidades" /></td>
                            <td>
                                <asp:ListBox runat="server" ID="DropDownList1">
                                    <asp:ListItem Text="Costarricense" Value="CR"></asp:ListItem>
                                    <asp:ListItem Text="Mexicano" Value="MX"></asp:ListItem>
                                    <asp:ListItem Text="Panameño" Value="PA"></asp:ListItem>
                                </asp:ListBox>
                            </td>
                        </tr>--%>
                    </table>
            
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
