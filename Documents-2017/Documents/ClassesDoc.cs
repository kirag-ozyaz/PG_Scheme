namespace Documents
{
    using FormLbr;
    using System;
    using System.Globalization;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public class ClassesDoc
    {
        public double GetDoubleFromString(string aStr)
        {
            aStr = aStr.Trim(new char[] { '(', ')', ' ' });
            double result = 0.0;
            NumberFormatInfo info = new NumberFormatInfo();
            if (!double.TryParse(aStr, NumberStyles.Float, (IFormatProvider) info, out result))
            {
                if (info.NumberDecimalSeparator == ",")
                {
                    info.NumberDecimalSeparator = ".";
                }
                else if (info.NumberDecimalSeparator == ".")
                {
                    info.NumberDecimalSeparator = ",";
                }
                if (!double.TryParse(aStr, NumberStyles.Float, (IFormatProvider) info, out result))
                {
                    return -1.0;
                }
            }
            return result;
        }

        public decimal ReturnNumber(object param)
        {
            try
            {
                new NumberFormatInfo();
                if (param.ToString().IndexOf(',') >= 0)
                {
                    return Convert.ToDecimal(param);
                }
                if (param.ToString().IndexOf('.') >= 0)
                {
                    return Convert.ToDecimal(param.ToString().Replace('.', ','));
                }
                return Convert.ToInt32(param);
            }
            catch
            {
                return decimal.Zero;
            }
        }

        public void Show(Form owner, Type frmType, FormBase FormParent, int? nullable_0)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            FormDocument document = null;
            foreach (FormBase base2 in owner.MdiChildren)
            {
                if (base2.GetType() == frmType)
                {
                    int? nullable = nullable_0;
                    bool flag1 = (((FormDocument) base2).Id == nullable.GetValueOrDefault()) ? nullable.HasValue : false;
                    document = base2;
                    break;
                }
            }
            if (document == null)
            {
                object[] args = new object[] { nullable_0 };
                document = executingAssembly.CreateInstance(frmType.FullName, false, BindingFlags.CreateInstance | BindingFlags.Public | BindingFlags.Instance, null, args, null, null) as FormDocument;
                document.MdiParent = owner;
                document.set_SqlSettings(FormParent.get_SqlSettings());
                document.FormParent = FormParent;
                try
                {
                    document.Show();
                }
                catch
                {
                }
            }
            else
            {
                document.Activate();
            }
            if (document.WindowState != FormWindowState.Maximized)
            {
                document.WindowState = FormWindowState.Normal;
            }
            else
            {
                document.WindowState = FormWindowState.Maximized;
            }
            if (!document.Visible)
            {
                document.Visible = true;
            }
        }

        public class Parametry
        {
            [CompilerGenerated]
            private object object_0;
            [CompilerGenerated]
            private object object_1;

            public object Id
            {
                [CompilerGenerated]
                get
                {
                    return this.object_0;
                }
                [CompilerGenerated]
                set
                {
                    this.object_0 = value;
                }
            }

            public object Name
            {
                [CompilerGenerated]
                get
                {
                    return this.object_1;
                }
                [CompilerGenerated]
                set
                {
                    this.object_1 = value;
                }
            }
        }

        public class ParametryColumnsDataGridView
        {
            private bool bool_0;
            private object object_0;
            private object object_1;
            private string string_0;
            private string string_1;
            private string string_2;

            public ParametryColumnsDataGridView()
            {
                this.bool_0 = true;
            }

            public ParametryColumnsDataGridView(object Column, string Name)
            {
                this.bool_0 = true;
                this.object_0 = Column;
                this.string_0 = Name;
                this.bool_0 = true;
            }

            public ParametryColumnsDataGridView(object Column, string Name, bool Visible)
            {
                this.bool_0 = true;
                this.object_0 = Column;
                this.string_0 = Name;
                this.bool_0 = Visible;
            }

            public ParametryColumnsDataGridView(object Column, string Name, bool Visible, object DataSource, string DisplayMember, string ValueMember)
            {
                this.bool_0 = true;
                this.object_0 = Column;
                this.string_0 = Name;
                this.bool_0 = Visible;
                this.object_1 = DataSource;
                this.string_1 = DisplayMember;
                this.string_2 = ValueMember;
            }

            public object Column
            {
                get
                {
                    return this.object_0;
                }
                set
                {
                    this.object_0 = value;
                }
            }

            public object DataSource
            {
                get
                {
                    return this.object_1;
                }
                set
                {
                    this.object_1 = value;
                }
            }

            public string DisplayMember
            {
                get
                {
                    return this.string_1;
                }
                set
                {
                    this.string_1 = value;
                }
            }

            public string Name
            {
                get
                {
                    return this.string_0;
                }
                set
                {
                    this.string_0 = value;
                }
            }

            public string ValueMember
            {
                get
                {
                    return this.string_2;
                }
                set
                {
                    this.string_2 = value;
                }
            }

            public bool Visible
            {
                get
                {
                    return this.bool_0;
                }
                set
                {
                    this.bool_0 = value;
                }
            }
        }
    }
}

