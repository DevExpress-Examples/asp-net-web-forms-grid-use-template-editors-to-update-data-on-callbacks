<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v10.1, Version=10.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPanel" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v10.1, Version=10.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxCallback" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxEditors.v10.1, Version=10.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Xpo.v10.1.Web, Version=10.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Xpo" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.ASPxGridView.v10.1, Version=10.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>How to perform ASPxGridView instant updating using different editors in the DataItem
        template</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" DataSourceID="xds"
                KeyFieldName="Oid" EnableRowsCache="false">
                <Columns>
                    <dx:GridViewDataTextColumn FieldName="Oid" ReadOnly="True" VisibleIndex="0" SortIndex="0"
                        SortOrder="Ascending">
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Title" VisibleIndex="1">
                        <DataItemTemplate>
                            <dx:ASPxTextBox ID="txtTitle" runat="server" Width="170px" Value='<%# Eval("Title") %>'
                                OnInit="txtTitle_Init">
                            </dx:ASPxTextBox>
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Item" VisibleIndex="2">
                        <DataItemTemplate>
                            <dx:ASPxComboBox ID="cmbItem" runat="server" ValueType="System.Int32" Value='<%# Eval("Item") %>'
                                OnInit="cmbItem_Init">
                                <Items>
                                    <dx:ListEditItem Value="0" Text="Zero" />
                                    <dx:ListEditItem Value="1" Text="One" />
                                    <dx:ListEditItem Value="2" Text="Two" />
                                </Items>
                            </dx:ASPxComboBox>
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="SomeDate" VisibleIndex="2">
                        <DataItemTemplate>
                            <dx:ASPxDateEdit ID="edtDate" runat="server" Value='<%# Eval("SomeDate") %>' OnInit="edtDate_Init">
                            </dx:ASPxDateEdit>
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
                </Columns>
            </dx:ASPxGridView>
            <dx:XpoDataSource ID="xds" runat="server" TypeName="MyObject">
            </dx:XpoDataSource>
            <dx:ASPxCallback ID="cb" runat="server" ClientInstanceName="cb" OnCallback="cb_Callback">
            </dx:ASPxCallback>
        </div>
    </form>
</body>
</html>
