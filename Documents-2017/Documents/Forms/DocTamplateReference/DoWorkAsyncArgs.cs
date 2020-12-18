namespace Documents.Forms.DocTamplateReference
{
    using DataSql;
    using System;
    using System.Runtime.CompilerServices;

    public class DoWorkAsyncArgs
    {
        [CompilerGenerated]
        private int int_0;
        [CompilerGenerated]
        private int int_1;
        [CompilerGenerated]
        private SQLSettings sqlsettings_0;
        [CompilerGenerated]
        private string string_0;

        public DoWorkAsyncArgs(SQLSettings settings, int idTemplate)
        {
            this.SqlSettings = settings;
            this.IdTemplate = idTemplate;
        }

        public DoWorkAsyncArgs(SQLSettings settings, int int_2, string fileName)
        {
            this.SqlSettings = settings;
            this.Id = int_2;
            this.FileName = fileName;
        }

        public DoWorkAsyncArgs(SQLSettings settings, int int_2, int idTemplate, string fileName)
        {
            this.SqlSettings = settings;
            this.Id = int_2;
            this.IdTemplate = idTemplate;
            this.FileName = fileName;
        }

        public string FileName
        {
            [CompilerGenerated]
            get
            {
                return this.string_0;
            }
            [CompilerGenerated]
            set
            {
                this.string_0 = value;
            }
        }

        public int Id
        {
            [CompilerGenerated]
            get
            {
                return this.int_0;
            }
            [CompilerGenerated]
            set
            {
                this.int_0 = value;
            }
        }

        public int IdTemplate
        {
            [CompilerGenerated]
            get
            {
                return this.int_1;
            }
            [CompilerGenerated]
            set
            {
                this.int_1 = value;
            }
        }

        public SQLSettings SqlSettings
        {
            [CompilerGenerated]
            get
            {
                return this.sqlsettings_0;
            }
            [CompilerGenerated]
            set
            {
                this.sqlsettings_0 = value;
            }
        }
    }
}

