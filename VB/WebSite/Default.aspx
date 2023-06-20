<%@ Page Language="VB" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>


<%@ Register Assembly="DevExpress.Xpo.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Xpo" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>How to perform ASPxGridView instant updating using different editors in the DataItem
        template</title>
    <script type="text/javascript">
        function encodeHtml(text) {
            if (text === undefined || text === null)
                return "";
            var replacements = [
                [/&amp;/g, '&ampx;'], [/&/g, '&amp;'], [/&quot;/g, '&quotx;'], [/"/g, '&quot;'],
                [/&lt;/g, '&ltx;'], [/</g, '&lt;'], [/&gt;/g, '&gtx;'], [/>/g, '&gt;']
            ];
            for (var i = 0; i < replacements.length; i++) {
                var repl = replacements[i];
                text = text.replace(repl[0], repl[1]);
            }
            return text;
        }
        function OnValueChanged(s, e, key, field) {
            var value = s.GetValue();
            if (s instanceof ASPxClientTextBox) { // encode text
                s.SetText(encodeHtml(s.GetText()));
                value = s.GetText();
            }
            if (s instanceof ASPxClientDateEdit)
                value = s.GetText();
            var param = key + "|" + field + "|" + value;
            cb.PerformCallback(param);
        }
    </script>
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
                                OnInit="editor_Init">
                            </dx:ASPxTextBox>
                        </DataItemTemplate>
                    </dx:GridViewDataTextColumn>
                    <dx:GridViewDataTextColumn FieldName="Item" VisibleIndex="2">
                        <DataItemTemplate>
                            <dx:ASPxComboBox ID="cmbItem" runat="server" ValueType="System.Int32" Value='<%# Eval("Item") %>'
                                OnInit="editor_Init">
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
                            <dx:ASPxDateEdit ID="edtDate" runat="server" Value='<%# Eval("SomeDate") %>' OnInit="editor_Init">
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
