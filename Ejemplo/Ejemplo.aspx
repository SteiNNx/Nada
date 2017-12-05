<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejemplo.aspx.cs" Inherits="Ejemplo.Ejemplo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rp_padre" runat="server" OnItemDataBound="rp_padre_ItemDataBound">
                <ItemTemplate>
                    <dl>
                        <dt>
                            <div><%# DataBinder.Eval(Container.DataItem,"profundidad") %></div>
                        </dt>
                        <dd>
                           <%-- <asp:Repeater ID="rp_hijo" runat="server">
                                <ItemTemplate>
                                    <div><%# DataBinder.Eval(Container.DataItem,"id") %></div>
                                </ItemTemplate>
                                <SeparatorTemplate>,</SeparatorTemplate>
                            </asp:Repeater>--%>
                        </dd>
                    </dl>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
