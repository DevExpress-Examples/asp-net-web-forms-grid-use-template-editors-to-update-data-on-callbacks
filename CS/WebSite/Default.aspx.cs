using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Xpo;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page
{
    Session session = XpoHelper.GetNewSession();

    const String CallbackArgumentFormat = "function (s, e) {{ OnValueChanged(s,e, {0}, '{1}'); }}";
    protected void Page_Init(object sender, EventArgs e)
    {
        xds.Session = session;
    }

    protected void editor_Init(object sender, EventArgs e)
    {
        ASPxEdit txt = sender as ASPxTextEdit;
        GridViewDataItemTemplateContainer container = txt.NamingContainer as GridViewDataItemTemplateContainer;

        txt.SetClientSideEventHandler("ValueChanged", String.Format(CallbackArgumentFormat,
            container.KeyValue,
            container.Column.FieldName));
    }

    protected void cb_Callback(object source, DevExpress.Web.CallbackEventArgs e)
    {
        String[] p = e.Parameter.Split('|');

        Int32 key = Convert.ToInt32(p[0]);
        String field = p[1];
        Object value = p[2];

        MyObject obj = session.GetObjectByKey<MyObject>(key);

        switch (field)
        {
            case "Title":
                if (value.ToString() == "null")
                    value = String.Empty;
                break;

            case "Item":
                value = Convert.ToInt32(value);
                break;

            case "SomeDate":
                DateTime result = DateTime.Now;
                if (DateTime.TryParse(value.ToString(), out result))
                    value = result;
                else
                    value = DateTime.Now;
                break;
        }

        obj.SetMemberValue(field, value);

        obj.Save();
    }
}
