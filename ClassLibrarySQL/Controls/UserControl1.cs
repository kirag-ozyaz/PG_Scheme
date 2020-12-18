using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class UserControl1 : UserControl
    {
        [Browsable(false)]
        public  DataSql.SQLSettings SqlSettings { get; set; }
        [Browsable(false)]
        public string TableDocumentDoc { get; set; } = "tJ_DamageDoc";
        [Browsable(true)]
        [Description("Идентификатор документа")]
        public int IdDocument { get; set; }
        [Browsable(true)]
        [Description("Тип документа")]
        public int TypeDocument { get; set; }

        public UserControl1()
        {
            //InitializeComponent();
        }
        public UserControl1(IContainer container)
        {
            container.Add(this);
            //InitializeComponent();
        }
    }
}
