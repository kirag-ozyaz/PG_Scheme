using FormLbr;
using References;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ASCAPC
{
    public partial class DlgStructFiderAddEdit : Form
    {
        public eActionRequestRepair eAction = eActionRequestRepair.Read;

        public DlgStructFiderAddEdit()
        {
            InitializeComponent();
        }

        private void DlgStructFiderAddEdit_Load(object sender, EventArgs e)
        {
            if (eAction == eActionRequestRepair.Edit)
            {
                this.Text = $"Редактирование: {this.controlFider1.IDC_NAME.Text} ({this.controlFider1.IDC_CODE.Text})";
            }
            else if (eAction == eActionRequestRepair.Add)
            {
                this.Text = "Добавить новый элемент";
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
