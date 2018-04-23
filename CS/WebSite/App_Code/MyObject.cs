using System;
using DevExpress.Xpo;

public class MyObject : XPObject {
    public MyObject()
        : base() { }

    public MyObject(Session session)
        : base(session) { }

    public override void AfterConstruction() {
        base.AfterConstruction();
    }

    protected String _Title;
    public String Title {
        get { return _Title; }
        set { SetPropertyValue<String>("Title", ref _Title, value); }
    }

    private Int32 _Item;
    public Int32 Item {
        get { return _Item; }
        set { SetPropertyValue("Item", ref _Item, value); }
    }

    private DateTime _SomeDate;
    public DateTime SomeDate {
        get { return _SomeDate; }
        set { SetPropertyValue("SomeDate", ref _SomeDate, value); }
    }
}

