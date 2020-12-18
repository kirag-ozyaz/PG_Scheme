namespace Documents
{
    using FormLbr;
    using System;
    using System.ComponentModel;
    using System.Data.SqlClient;
    using System.Drawing;

    public class FormDocument : FormBase
    {
        private FormBase formBase_0;
        private int int_0 = -1;
        private int int_1 = 0x114;
        [Browsable(false)]
        public bool isInsert;
        public bool readOnly = true;
        [Browsable(false)]
        public SqlTransaction transaction;

        public FormDocument()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(FormDocument));
            base.Icon = (Icon) manager.GetObject("Document");
        }

        [Browsable(false)]
        public FormBase FormParent
        {
            get
            {
                return this.formBase_0;
            }
            set
            {
                this.formBase_0 = value;
            }
        }

        [Browsable(false)]
        public int Id
        {
            get
            {
                return this.int_0;
            }
            set
            {
                this.int_0 = value;
            }
        }

        [Browsable(false)]
        public int IdDocType
        {
            get
            {
                return this.int_1;
            }
            set
            {
                this.int_1 = value;
            }
        }

        [Browsable(true), Description("Статус полного доступа к элементам формы. false - update; true - insert")]
        public bool ReadOnly
        {
            get
            {
                return this.readOnly;
            }
            set
            {
                this.readOnly = value;
            }
        }
    }
}

