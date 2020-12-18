namespace Documents.Forms
{
    using DataSql;
    using Documents.DataSets;
    using Documents.Forms.GRPApplication;
    using Documents.Properties;
    using FormLbr;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    public class FormODS : FormBase
    {
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private BindingSource bindingSource_2;
        private BindingSource bindingSource_3;
        private bool bool_0;
        private Class202 class202_0;
        private Class203 class203_0;
        private Class207 class207_0;
        private DataGridView dataGridView_0;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;
        private FormFilter formFilter_0;
        private IContainer icontainer_0;
        private OrgDataSet orgDataSet_0;
        private string string_0;
        private string string_1;
        private string string_2;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolStripButton_0;
        private ToolStripButton toolStripButton_1;
        private ToolStripButton toolStripButton_2;
        private ToolStripButton toolStripButton_3;
        private ToolStripButton toolStripButton_4;
        private ToolStripButton toolStripButton_5;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripSeparator toolStripSeparator_2;

        public FormODS()
        {
            this.string_0 = string.Empty;
            this.string_1 = string.Empty;
            this.string_2 = string.Empty;
            this.formFilter_0 = new FormFilter();
            this.method_4();
            this.dataGridView_0.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        public FormODS(SQLSettings SqlSettings)
        {
            this.string_0 = string.Empty;
            this.string_1 = string.Empty;
            this.string_2 = string.Empty;
            this.formFilter_0 = new FormFilter();
            this.method_4();
            this.set_SqlSettings(SqlSettings);
            this.dataGridView_0.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void dataGridView_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.method_3();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void formFilter_0_Deactivate(object sender, EventArgs e)
        {
            this.method_2();
        }

        private void FormODS_Load(object sender, EventArgs e)
        {
            this.formFilter_0.Deactivate += new EventHandler(this.formFilter_0_Deactivate);
            this.formFilter_0.ShowPeriodApplication = false;
            this.formFilter_0.Legal = true;
            this.formFilter_0.Individual = true;
            this.formFilter_0.UsePeriodExecution = true;
            this.formFilter_0.BeginningOfPeriodExecution = DateTime.Today;
            this.formFilter_0.EndOfPeriodExecution = DateTime.Today;
            this.formFilter_0.Disconnection = true;
            this.formFilter_0.Resumption = true;
            this.formFilter_0.Cancel = true;
            this.formFilter_0.NetArea1 = true;
            this.formFilter_0.NetArea2 = true;
            this.formFilter_0.NetArea3 = true;
            this.formFilter_0.NetArea4 = true;
            this.formFilter_0.ODS = true;
            this.formFilter_0.SESNO = true;
            this.method_2();
        }

        private void method_0()
        {
            if (this.bindingSource_0.Count > 0)
            {
                this.orgDataSet_0.ReportODS.Clear();
            }
            if (!this.formFilter_0.SkipUnperformed && !this.bool_0)
            {
                IEnumerator enumerator;
                this.class203_0.vmethod_10(this.orgDataSet_0.tblAbnAplForDisconObjects, new DateTime?(this.formFilter_0.BeginningOfPeriodExecution));
                using (enumerator = this.bindingSource_1.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        OrgDataSet.Class411 row = (OrgDataSet.Class411) ((DataRowView) enumerator.Current).Row;
                        this.bindingSource_0.AddNew();
                        OrgDataSet.Class426 class3 = (OrgDataSet.Class426) ((DataRowView) this.bindingSource_0.Current).Row;
                        class3.method_23(true);
                        class3.method_3(row.Id);
                        switch (row.NetArea)
                        {
                            case 0:
                                class3.NetArea = "1";
                                break;

                            case 1:
                                class3.NetArea = "2";
                                break;

                            case 2:
                                class3.NetArea = "3";
                                break;

                            case 3:
                                class3.NetArea = "4";
                                break;

                            case 4:
                                class3.NetArea = "ОДС";
                                break;

                            case 5:
                                class3.NetArea = "СЭСНО";
                                break;
                        }
                        class3.method_9(row.method_0().ToString());
                        if (!row.method_66())
                        {
                            class3.method_9(class3.method_8() + ", " + row.method_20());
                        }
                        if (!row.method_88())
                        {
                            class3.method_27(row.method_30().ToString("dd.MM.yyyy HH:mm"));
                        }
                        if (!row.method_48())
                        {
                            class3.Code = row.Code.ToString();
                            if (!row.method_52())
                            {
                                class3.method_11(row.method_6());
                            }
                        }
                        else
                        {
                            class3.Code = "б/д";
                            class3.method_11(row.NoDogObj);
                        }
                        if (!row.method_40())
                        {
                            class3.Point = row.PlaceId;
                        }
                        class3.TypeAction = row.TypeAction;
                        switch (row.TypeAction)
                        {
                            case 0:
                                class3.method_15("Отключение");
                                break;

                            case 1:
                                class3.method_15("Возобновление");
                                break;

                            case 2:
                                class3.method_15("Отмена");
                                break;
                        }
                        class3.DateAction = row.DateAction;
                        if (!row.method_56())
                        {
                            class3.method_7(row.method_10());
                        }
                        if (!row.method_60())
                        {
                            class3.method_19(row.method_14());
                        }
                        if (!row.method_58())
                        {
                            class3.method_5(row.method_26());
                            if (!row.method_70())
                            {
                                class3.method_5(class3.method_4() + " (" + row.method_24() + ")");
                            }
                        }
                        if (!row.method_44())
                        {
                            class3.Comments = row.Comments;
                        }
                        if (!row.method_54() && (row.TypeAction != 2))
                        {
                            class3.method_25(row.method_8());
                            class3.method_13(row.method_8().ToString());
                        }
                    }
                }
                this.class207_0.vmethod_10(this.orgDataSet_0.tblAbnAplForDisconIndividualUsers, new DateTime?(this.formFilter_0.BeginningOfPeriodExecution));
                using (enumerator = this.bindingSource_2.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        OrgDataSet.Class415 class4 = (OrgDataSet.Class415) ((DataRowView) enumerator.Current).Row;
                        this.bindingSource_0.AddNew();
                        OrgDataSet.Class426 class5 = (OrgDataSet.Class426) ((DataRowView) this.bindingSource_0.Current).Row;
                        class5.method_23(false);
                        class5.method_3(class4.Id);
                        switch (class4.NetArea)
                        {
                            case 0:
                                class5.NetArea = "1";
                                break;

                            case 1:
                                class5.NetArea = "2";
                                break;

                            case 2:
                                class5.NetArea = "3";
                                break;

                            case 3:
                                class5.NetArea = "4";
                                break;

                            case 4:
                                class5.NetArea = "ОДС";
                                break;

                            case 5:
                                class5.NetArea = "СЭСНО";
                                break;
                        }
                        class5.method_9(class4.method_0() + ", " + class4.method_16());
                        if (!class4.method_74())
                        {
                            class5.method_27(class4.method_26().ToString("dd.MM.yyyy HH:mm"));
                        }
                        if (!class4.method_46())
                        {
                            class5.Code = class4.Code.ToString();
                        }
                        if (!class4.method_30())
                        {
                            class5.method_11(class4.FIO);
                            if (!class4.method_32())
                            {
                                class5.method_11(class5.method_10() + ",\r\n" + class4.Address);
                            }
                        }
                        else if (!class4.method_32())
                        {
                            class5.method_11(class4.Address);
                        }
                        if (!class4.method_52())
                        {
                            class5.Point = class4.Point;
                        }
                        switch (class4.TypeAction)
                        {
                            case 0:
                                class5.method_15("Отключение");
                                break;

                            case 1:
                                class5.method_15("Возобновление");
                                break;

                            case 2:
                                class5.method_15("Отмена");
                                break;
                        }
                        class5.DateAction = class4.DateAction;
                        if (!class4.method_56())
                        {
                            class5.method_7(class4.method_8());
                        }
                        if (!class4.method_62())
                        {
                            class5.method_19(class4.method_14());
                        }
                        if (!class4.method_58())
                        {
                            class5.method_5(class4.method_22() + " (" + class4.method_20() + ")");
                        }
                        if (!class4.method_40())
                        {
                            class5.Comments = class4.Comments;
                        }
                        if (!class4.method_50() && (class4.TypeAction != 2))
                        {
                            class5.method_25(class4.method_4());
                            class5.method_13(class4.method_4().ToString());
                        }
                        if (!class4.method_72())
                        {
                            class5.method_29(class4.method_24());
                        }
                    }
                }
            }
            this.class202_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDiscon);
            this.bindingSource_3.Filter = this.string_0;
            this.method_1();
            this.bindingSource_0.Filter = this.string_2;
            this.bindingSource_0.Sort = "DateAction";
        }

        private void method_1()
        {
            using (IEnumerator enumerator = this.bindingSource_3.GetEnumerator())
            {
                IEnumerator enumerator2;
            Label_000D:
                if (!enumerator.MoveNext())
                {
                    return;
                }
                OrgDataSet.Class410 row = (OrgDataSet.Class410) ((DataRowView) enumerator.Current).Row;
                if (row.method_6())
                {
                    if (this.bool_0)
                    {
                        this.class203_0.vmethod_8(this.orgDataSet_0.tblAbnAplForDisconObjects, new int?(row.Id));
                    }
                    else
                    {
                        this.class203_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDisconObjects, new int?(row.Id));
                    }
                    this.bindingSource_1.Filter = this.string_1;
                    using (enumerator2 = this.bindingSource_1.GetEnumerator())
                    {
                        while (enumerator2.MoveNext())
                        {
                            OrgDataSet.Class411 class3 = (OrgDataSet.Class411) ((DataRowView) enumerator2.Current).Row;
                            this.bindingSource_0.AddNew();
                            OrgDataSet.Class426 class4 = (OrgDataSet.Class426) ((DataRowView) this.bindingSource_0.Current).Row;
                            class4.method_23(true);
                            class4.method_3(class3.Id);
                            switch (row.NetArea)
                            {
                                case 0:
                                    class4.NetArea = "1";
                                    break;

                                case 1:
                                    class4.NetArea = "2";
                                    break;

                                case 2:
                                    class4.NetArea = "3";
                                    break;

                                case 3:
                                    class4.NetArea = "4";
                                    break;

                                case 4:
                                    class4.NetArea = "ОДС";
                                    break;

                                case 5:
                                    class4.NetArea = "СЭСНО";
                                    break;
                            }
                            class4.method_9(row.Id.ToString());
                            if (!class3.method_66())
                            {
                                class4.method_9(class4.method_8() + ", " + class3.method_20());
                            }
                            if (!row.method_28())
                            {
                                class4.method_27(row.method_8().ToString("dd.MM.yyyy HH:mm"));
                            }
                            if (!class3.method_48())
                            {
                                class4.Code = class3.Code.ToString();
                                if (!class3.method_52())
                                {
                                    class4.method_11(class3.method_6());
                                }
                            }
                            else
                            {
                                class4.Code = "б/д";
                                class4.method_11(class3.NoDogObj);
                            }
                            if (!class3.method_40())
                            {
                                class4.Point = class3.PlaceId;
                            }
                            class4.TypeAction = row.TypeAction;
                            switch (row.TypeAction)
                            {
                                case 0:
                                    class4.method_15("Отключение");
                                    break;

                                case 1:
                                    class4.method_15("Возобновление");
                                    break;

                                case 2:
                                    class4.method_15("Отмена");
                                    break;
                            }
                            class4.DateAction = row.DateAction;
                            if ((row.TypeAction == 0) && !class3.method_90())
                            {
                                if (class3.IsFullRestriction)
                                {
                                    class4.IsFullRestriction = "Полное";
                                }
                                else
                                {
                                    class4.IsFullRestriction = "Частичное";
                                }
                            }
                            if (!class3.method_56())
                            {
                                class4.method_7(class3.method_10());
                            }
                            if (!class3.method_60())
                            {
                                class4.method_19(class3.method_14());
                            }
                            if (!class3.method_58())
                            {
                                class4.method_5(class3.method_26() + " (" + class3.method_24() + ")");
                            }
                            if (!class3.method_44())
                            {
                                class4.Comments = class3.Comments;
                            }
                            if (!class3.method_54() && (row.TypeAction != 2))
                            {
                                class4.method_25(class3.method_8());
                                class4.method_13(class3.method_8().ToString());
                            }
                            if (!class3.method_78())
                            {
                                class4.method_29(class3.method_28());
                            }
                        }
                        goto Label_0732;
                    }
                }
                if (this.bool_0)
                {
                    this.class207_0.vmethod_4(this.orgDataSet_0.tblAbnAplForDisconIndividualUsers, new int?(row.Id));
                }
                else
                {
                    this.class207_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDisconIndividualUsers, new int?(row.Id));
                }
                this.bindingSource_2.Filter = this.string_1;
                using (enumerator2 = this.bindingSource_2.GetEnumerator())
                {
                    while (enumerator2.MoveNext())
                    {
                        OrgDataSet.Class415 class5 = (OrgDataSet.Class415) ((DataRowView) enumerator2.Current).Row;
                        this.bindingSource_0.AddNew();
                        OrgDataSet.Class426 class6 = (OrgDataSet.Class426) ((DataRowView) this.bindingSource_0.Current).Row;
                        class6.method_23(false);
                        class6.method_3(class5.Id);
                        switch (row.NetArea)
                        {
                            case 0:
                                class6.NetArea = "1";
                                break;

                            case 1:
                                class6.NetArea = "2";
                                break;

                            case 2:
                                class6.NetArea = "3";
                                break;

                            case 3:
                                class6.NetArea = "4";
                                break;

                            case 4:
                                class6.NetArea = "ОДС";
                                break;

                            case 5:
                                class6.NetArea = "СЭСНО";
                                break;
                        }
                        class6.method_9(row.Id + ", " + class5.method_16());
                        if (!row.method_28())
                        {
                            class6.method_27(row.method_8().ToString("dd.MM.yyyy HH:mm"));
                        }
                        if (!class5.method_46())
                        {
                            class6.Code = class5.Code.ToString();
                        }
                        if (!class5.method_30())
                        {
                            class6.method_11(class5.FIO);
                            if (!class5.method_32())
                            {
                                class6.method_11(class6.method_10() + ",\r\n" + class5.Address);
                            }
                        }
                        else if (!class5.method_32())
                        {
                            class6.method_11(class5.Address);
                        }
                        if (!class5.method_52())
                        {
                            class6.Point = class5.Point;
                        }
                        switch (row.TypeAction)
                        {
                            case 0:
                                class6.method_15("Отключение");
                                break;

                            case 1:
                                class6.method_15("Возобновление");
                                break;

                            case 2:
                                class6.method_15("Отмена");
                                break;
                        }
                        class6.DateAction = row.DateAction;
                        if ((row.TypeAction == 0) && !class5.method_84())
                        {
                            if (class5.IsFullRestriction)
                            {
                                class6.IsFullRestriction = "Полное";
                            }
                            else
                            {
                                class6.IsFullRestriction = "Частичное";
                            }
                        }
                        if (!class5.method_56())
                        {
                            class6.method_7(class5.method_8());
                        }
                        if (!class5.method_62())
                        {
                            class6.method_19(class5.method_14());
                        }
                        if (!class5.method_58())
                        {
                            class6.method_5(class5.method_22());
                            if (!class5.method_68())
                            {
                                class6.method_5(class6.method_4() + " (" + class5.method_20() + ")");
                            }
                        }
                        if (!class5.method_40())
                        {
                            class6.Comments = class5.Comments;
                        }
                        if (!class5.method_50() && (row.TypeAction != 2))
                        {
                            class6.method_25(class5.method_4());
                            class6.method_13(class5.method_4().ToString());
                        }
                        if (!class5.method_72())
                        {
                            class6.method_29(class5.method_24());
                        }
                    }
                }
            Label_0732:
                this.bindingSource_0.EndEdit();
                goto Label_000D;
            }
        }

        private void method_2()
        {
            this.Cursor = Cursors.WaitCursor;
            this.string_0 = string.Empty;
            this.string_1 = string.Empty;
            this.string_2 = string.Empty;
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();
            List<string> list3 = new List<string>();
            if (this.formFilter_0.UsePeriodExecution)
            {
                string[] textArray1 = new string[] { "DateAction>='", this.formFilter_0.BeginningOfPeriodExecution.ToString(), "' and DateAction<='", this.formFilter_0.EndOfPeriodExecution.ToString(), "'" };
                string item = string.Concat(textArray1);
                list.Add(item);
            }
            if (!this.formFilter_0.Legal)
            {
                list.Add("LegalAbns <> True");
            }
            if (!this.formFilter_0.Individual)
            {
                list.Add("LegalAbns <> false");
            }
            if (!this.formFilter_0.Disconnection && !this.bool_0)
            {
                list.Add("TypeAction<>0");
            }
            if (!this.formFilter_0.Resumption && !this.bool_0)
            {
                list.Add("TypeAction<>1");
            }
            if (!this.formFilter_0.Cancel && !this.bool_0)
            {
                list.Add("TypeAction<>2");
            }
            if (this.formFilter_0.DoNotDisplayCancelled && !this.bool_0)
            {
                list3.Add("IdCancelApl is null");
            }
            if (this.formFilter_0.DoNotDisplayPerformed && !this.bool_0)
            {
                list2.Add("DateExec is null");
            }
            if (this.formFilter_0.DoNotDisplayUnperformed || this.bool_0)
            {
                list2.Add("DateExec not is null");
            }
            if (this.formFilter_0.SkipUnsent && !this.bool_0)
            {
                list.Add("Sent NOT IS NULL");
            }
            if (!this.formFilter_0.NetArea1)
            {
                list.Add("NetArea<>0");
            }
            if (!this.formFilter_0.NetArea2)
            {
                list.Add("NetArea<>1");
            }
            if (!this.formFilter_0.NetArea3)
            {
                list.Add("NetArea<>2");
            }
            if (!this.formFilter_0.NetArea4)
            {
                list.Add("NetArea<>3");
            }
            if (!this.formFilter_0.ODS)
            {
                list.Add("NetArea<>4");
            }
            if (!this.formFilter_0.SESNO)
            {
                list.Add("NetArea<>5");
            }
            if (((list.Count == 0) && (list2.Count == 0)) && (list3.Count == 0))
            {
                this.method_0();
            }
            else
            {
                StringBuilder builder = new StringBuilder();
                bool flag = false;
                foreach (string str2 in list)
                {
                    if (flag)
                    {
                        builder.Append(" AND ");
                    }
                    else
                    {
                        flag = true;
                    }
                    builder.Append(str2);
                }
                this.string_0 = builder.ToString();
                builder = new StringBuilder();
                flag = false;
                foreach (string str3 in list2)
                {
                    if (flag)
                    {
                        builder.Append(" AND ");
                    }
                    else
                    {
                        flag = true;
                    }
                    builder.Append(str3);
                }
                this.string_1 = builder.ToString();
                builder = new StringBuilder();
                flag = false;
                foreach (string str4 in list3)
                {
                    if (flag)
                    {
                        builder.Append(" AND ");
                    }
                    else
                    {
                        flag = true;
                    }
                    builder.Append(str4);
                }
                this.string_2 = builder.ToString();
                this.method_0();
            }
            this.Cursor = Cursors.Default;
        }

        private void method_3()
        {
            FormODSEdit edit;
            OrgDataSet.Class426 row = (OrgDataSet.Class426) ((DataRowView) this.bindingSource_0.Current).Row;
            if (row.method_22())
            {
                this.class203_0.vmethod_4(this.orgDataSet_0.tblAbnAplForDisconObjects, new int?(row.method_2()));
                edit = new FormODSEdit(true, this.bindingSource_1[0], this.get_SqlSettings());
            }
            else
            {
                this.class207_0.vmethod_6(this.orgDataSet_0.tblAbnAplForDisconIndividualUsers, row.method_2());
                edit = new FormODSEdit(false, this.bindingSource_2[0], this.get_SqlSettings());
            }
            if (edit.ShowDialog() == DialogResult.OK)
            {
                if (row.method_22())
                {
                    this.class203_0.vmethod_12(this.orgDataSet_0.tblAbnAplForDisconObjects);
                }
                else
                {
                    this.class207_0.vmethod_12(this.orgDataSet_0.tblAbnAplForDisconIndividualUsers);
                }
                int position = this.bindingSource_0.Position;
                this.class202_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDiscon);
                this.method_0();
                this.bindingSource_0.Position = position;
            }
        }

        private void method_4()
        {
            this.icontainer_0 = new Container();
            this.dataGridView_0 = new DataGridView();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.orgDataSet_0 = new OrgDataSet();
            this.toolStrip_0 = new ToolStrip();
            this.toolStripButton_0 = new ToolStripButton();
            this.toolStripButton_3 = new ToolStripButton();
            this.toolStripButton_4 = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolStripButton_1 = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolStripButton_2 = new ToolStripButton();
            this.toolStripSeparator_2 = new ToolStripSeparator();
            this.toolStripButton_5 = new ToolStripButton();
            this.bindingSource_2 = new BindingSource(this.icontainer_0);
            this.class207_0 = new Class207();
            this.bindingSource_1 = new BindingSource(this.icontainer_0);
            this.class203_0 = new Class203();
            this.bindingSource_3 = new BindingSource(this.icontainer_0);
            this.class202_0 = new Class202();
            ((ISupportInitialize) this.dataGridView_0).BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.orgDataSet_0.BeginInit();
            this.toolStrip_0.SuspendLayout();
            ((ISupportInitialize) this.bindingSource_2).BeginInit();
            ((ISupportInitialize) this.bindingSource_1).BeginInit();
            ((ISupportInitialize) this.bindingSource_3).BeginInit();
            base.SuspendLayout();
            this.dataGridView_0.AllowUserToAddRows = false;
            this.dataGridView_0.AllowUserToDeleteRows = false;
            this.dataGridView_0.AutoGenerateColumns = false;
            this.dataGridView_0.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_0.BackgroundColor = Color.White;
            this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewCheckBoxColumn_0, this.dataGridViewTextBoxColumn_5, this.dataGridViewTextBoxColumn_6, this.dataGridViewTextBoxColumn_7, this.dataGridViewTextBoxColumn_8, this.dataGridViewTextBoxColumn_9, this.dataGridViewTextBoxColumn_10, this.dataGridViewTextBoxColumn_11, this.dataGridViewTextBoxColumn_12, this.dataGridViewTextBoxColumn_13, this.dataGridViewTextBoxColumn_14 };
            this.dataGridView_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridView_0.DataSource = this.bindingSource_0;
            this.dataGridView_0.Dock = DockStyle.Fill;
            this.dataGridView_0.Location = new Point(0, 0x19);
            this.dataGridView_0.Name = "dataGridView1";
            this.dataGridView_0.ReadOnly = true;
            this.dataGridView_0.RowHeadersVisible = false;
            this.dataGridView_0.RowHeadersWidth = 0x19;
            this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_0.Size = new Size(0x3fe, 0x28c);
            this.dataGridView_0.TabIndex = 0;
            this.dataGridView_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridView_0_CellDoubleClick);
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "NetArea";
            this.dataGridViewTextBoxColumn_0.HeaderText = "№ сетевого района";
            this.dataGridViewTextBoxColumn_0.Name = "netAreaDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Width = 0x37;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "NumDoc";
            this.dataGridViewTextBoxColumn_1.HeaderText = "№ заявки, причина";
            this.dataGridViewTextBoxColumn_1.Name = "numDocDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_2.DataPropertyName = "Sent";
            this.dataGridViewTextBoxColumn_2.HeaderText = "Дата и время отправки распоряжения";
            this.dataGridViewTextBoxColumn_2.Name = "Sent";
            this.dataGridViewTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.DataPropertyName = "Code";
            this.dataGridViewTextBoxColumn_3.HeaderText = "№ договора";
            this.dataGridViewTextBoxColumn_3.Name = "codeDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewTextBoxColumn_3.Width = 60;
            this.dataGridViewTextBoxColumn_4.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn_4.HeaderText = "Наименование и адрес объекта(ФИО физ. лица)";
            this.dataGridViewTextBoxColumn_4.MinimumWidth = 60;
            this.dataGridViewTextBoxColumn_4.Name = "titleDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewTextBoxColumn_4.Width = 120;
            this.dataGridViewCheckBoxColumn_0.DataPropertyName = "Matrix";
            this.dataGridViewCheckBoxColumn_0.FillWeight = 70f;
            this.dataGridViewCheckBoxColumn_0.HeaderText = "Подключён к матрице";
            this.dataGridViewCheckBoxColumn_0.Name = "Matrix";
            this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
            this.dataGridViewCheckBoxColumn_0.Width = 70;
            this.dataGridViewTextBoxColumn_5.DataPropertyName = "Point";
            this.dataGridViewTextBoxColumn_5.HeaderText = "Место выполнения";
            this.dataGridViewTextBoxColumn_5.Name = "pointDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewTextBoxColumn_6.DataPropertyName = "TypeActionCaption";
            this.dataGridViewTextBoxColumn_6.HeaderText = "Вид заявки";
            this.dataGridViewTextBoxColumn_6.Name = "typeActionDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewTextBoxColumn_7.DataPropertyName = "IsFullRestriction";
            this.dataGridViewTextBoxColumn_7.HeaderText = "Вид ограничения";
            this.dataGridViewTextBoxColumn_7.Name = "IsFullRestriction";
            this.dataGridViewTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewTextBoxColumn_7.Width = 0x55;
            this.dataGridViewTextBoxColumn_8.DataPropertyName = "Officer";
            this.dataGridViewTextBoxColumn_8.HeaderText = "Ответственный за выполнение";
            this.dataGridViewTextBoxColumn_8.Name = "officerDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewTextBoxColumn_9.DataPropertyName = "DateAction";
            this.dataGridViewTextBoxColumn_9.HeaderText = "Планируемая дата и время исполнения";
            this.dataGridViewTextBoxColumn_9.Name = "dateActionDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewTextBoxColumn_10.DataPropertyName = "DateExec";
            this.dataGridViewTextBoxColumn_10.HeaderText = "Фактическая дата и время исполнения";
            this.dataGridViewTextBoxColumn_10.Name = "dateExecDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_10.ReadOnly = true;
            this.dataGridViewTextBoxColumn_11.DataPropertyName = "ReasonFailure";
            this.dataGridViewTextBoxColumn_11.HeaderText = "Причина не выпонения";
            this.dataGridViewTextBoxColumn_11.Name = "reasonFailureDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_11.ReadOnly = true;
            this.dataGridViewTextBoxColumn_12.DataPropertyName = "FIOExec";
            this.dataGridViewTextBoxColumn_12.HeaderText = "ФИО исполнителя (№ сет. района, ОДС)";
            this.dataGridViewTextBoxColumn_12.Name = "fIOExecDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewTextBoxColumn_13.DataPropertyName = "NumCancelApl";
            this.dataGridViewTextBoxColumn_13.HeaderText = "Отмена (№ заявки)";
            this.dataGridViewTextBoxColumn_13.Name = "numCancelAplDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_13.ReadOnly = true;
            this.dataGridViewTextBoxColumn_14.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn_14.HeaderText = "Примечание";
            this.dataGridViewTextBoxColumn_14.Name = "commentsDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_14.ReadOnly = true;
            this.bindingSource_0.DataMember = "ReportODS";
            this.bindingSource_0.DataSource = this.orgDataSet_0;
            this.orgDataSet_0.DataSetName = "OrgDataSet";
            this.orgDataSet_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolStripButton_0, this.toolStripButton_3, this.toolStripButton_4, this.toolStripSeparator_0, this.toolStripButton_1, this.toolStripSeparator_1, this.toolStripButton_2, this.toolStripSeparator_2, this.toolStripButton_5 };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStrip1";
            this.toolStrip_0.Size = new Size(0x3fe, 0x19);
            this.toolStrip_0.TabIndex = 1;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_0.Image = Resources.Filtr;
            this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_0.Name = "toolStripButtonFilter";
            this.toolStripButton_0.Size = new Size(0x17, 0x16);
            this.toolStripButton_0.Text = "Фильтр";
            this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
            this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_3.Image = Resources.search2;
            this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_3.Name = "toolStripButton2";
            this.toolStripButton_3.Size = new Size(0x17, 0x16);
            this.toolStripButton_3.Text = "Начать поиск по адресу";
            this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
            this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_4.Image = Resources.filter_delete;
            this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_4.Name = "toolStripButton3";
            this.toolStripButton_4.Size = new Size(0x17, 0x16);
            this.toolStripButton_4.Text = "Обновить";
            this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_1.Image = Resources.printer;
            this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_1.Name = "toolStripButtonPrint";
            this.toolStripButton_1.Size = new Size(0x17, 0x16);
            this.toolStripButton_1.Text = "Печать";
            this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator2";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_2.Image = Resources.ButtonEdit;
            this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_2.Name = "toolStripButton1";
            this.toolStripButton_2.Size = new Size(0x17, 0x16);
            this.toolStripButton_2.Text = "Редактировать";
            this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
            this.toolStripSeparator_2.Name = "toolStripSeparator3";
            this.toolStripSeparator_2.Size = new Size(6, 0x19);
            this.toolStripButton_5.CheckOnClick = true;
            this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolStripButton_5.Image = Resources.AbonentsDel;
            this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
            this.toolStripButton_5.Name = "toolStripButtonDisconnected";
            this.toolStripButton_5.Size = new Size(0x17, 0x16);
            this.toolStripButton_5.Text = "Отключенные";
            this.toolStripButton_5.CheckedChanged += new EventHandler(this.toolStripButton_5_CheckedChanged);
            this.bindingSource_2.DataMember = "tblAbnAplForDisconIndividualUsers";
            this.bindingSource_2.DataSource = this.orgDataSet_0;
            this.class207_0.method_7(true);
            this.bindingSource_1.DataMember = "tblAbnAplForDisconObjects";
            this.bindingSource_1.DataSource = this.orgDataSet_0;
            this.class203_0.method_7(true);
            this.bindingSource_3.DataMember = "tblAbnAplForDiscon";
            this.bindingSource_3.DataSource = this.orgDataSet_0;
            this.class202_0.method_7(true);
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x3fe, 0x2a5);
            base.Controls.Add(this.dataGridView_0);
            base.Controls.Add(this.toolStrip_0);
            base.Name = "FormODS";
            this.Text = "Заявки на введение или отмену введения ограничения режима потребления электрической энергии";
            base.WindowState = FormWindowState.Maximized;
            base.Load += new EventHandler(this.FormODS_Load);
            ((ISupportInitialize) this.dataGridView_0).EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.orgDataSet_0.EndInit();
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            ((ISupportInitialize) this.bindingSource_2).EndInit();
            ((ISupportInitialize) this.bindingSource_1).EndInit();
            ((ISupportInitialize) this.bindingSource_3).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolStripButton_0_Click(object sender, EventArgs e)
        {
            this.formFilter_0.Location = new Point((base.Location.X + 0x19) + base.MdiParent.Location.X, (base.Location.Y + 110) + base.MdiParent.Location.Y);
            this.formFilter_0.Show();
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            DateTime minValue = DateTime.MinValue;
            DateTime endOfPeriodExecution = DateTime.MinValue;
            if (this.formFilter_0.UsePeriodExecution)
            {
                minValue = this.formFilter_0.BeginningOfPeriodExecution;
                endOfPeriodExecution = this.formFilter_0.EndOfPeriodExecution;
            }
            new Form5(minValue, endOfPeriodExecution, this.get_SqlSettings()) { 
                bindingSource_7 = { DataSource = this.bindingSource_0 },
                MdiParent = base.MdiParent
            }.Show();
        }

        private void toolStripButton_2_Click(object sender, EventArgs e)
        {
            this.method_3();
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm {
                radioButtonLegal = { Checked = true },
                comboBoxSearchType = { SelectedIndex = 0 }
            };
            if (form.ShowDialog() == DialogResult.OK)
            {
                IEnumerator enumerator;
                this.bindingSource_3.Filter = string.Empty;
                if (form.radioButtonLegal.Checked)
                {
                    if (form.comboBoxSearchType.SelectedIndex == 0)
                    {
                        this.class203_0.vmethod_2(this.orgDataSet_0.tblAbnAplForDisconObjects, "%" + form.textBoxName.Text + "%");
                    }
                    else if (form.comboBoxSearchType.SelectedIndex == 1)
                    {
                        this.class203_0.vmethod_6(this.orgDataSet_0.tblAbnAplForDisconObjects, "%" + form.textBoxName.Text + "%");
                    }
                    this.bindingSource_1.RemoveFilter();
                    if (this.bindingSource_0.Count > 0)
                    {
                        this.orgDataSet_0.ReportODS.Clear();
                    }
                    using (enumerator = this.bindingSource_1.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            OrgDataSet.Class411 row = (OrgDataSet.Class411) ((DataRowView) enumerator.Current).Row;
                            if (!row.method_34())
                            {
                                this.class202_0.vmethod_2(this.orgDataSet_0.tblAbnAplForDiscon, new int?(row.method_0()));
                                this.bindingSource_3.RemoveFilter();
                                OrgDataSet.Class410 class3 = (OrgDataSet.Class410) ((DataRowView) this.bindingSource_3[0]).Row;
                                this.bindingSource_0.AddNew();
                                OrgDataSet.Class426 class4 = (OrgDataSet.Class426) ((DataRowView) this.bindingSource_0.Current).Row;
                                class4.method_23(true);
                                class4.method_3(row.Id);
                                switch (class3.NetArea)
                                {
                                    case 0:
                                        class4.NetArea = "1";
                                        break;

                                    case 1:
                                        class4.NetArea = "2";
                                        break;

                                    case 2:
                                        class4.NetArea = "3";
                                        break;

                                    case 3:
                                        class4.NetArea = "4";
                                        break;

                                    case 4:
                                        class4.NetArea = "ОДС";
                                        break;

                                    case 5:
                                        class4.NetArea = "СЭСНО";
                                        break;
                                }
                                class4.method_9(class3.Id.ToString());
                                if (!row.method_66())
                                {
                                    class4.method_9(class4.method_8() + ", " + row.method_20());
                                }
                                if (!class3.method_28())
                                {
                                    class4.method_27(class3.method_8().ToString("dd.MM.yyyy HH:mm"));
                                }
                                if (!row.method_48())
                                {
                                    class4.Code = row.Code.ToString();
                                    if (!row.method_52())
                                    {
                                        class4.method_11(row.method_6());
                                    }
                                }
                                else
                                {
                                    class4.Code = "б/д";
                                    class4.method_11(row.NoDogObj);
                                }
                                if (!row.method_40())
                                {
                                    class4.Point = row.PlaceId;
                                }
                                class4.TypeAction = class3.TypeAction;
                                switch (class3.TypeAction)
                                {
                                    case 0:
                                        class4.method_15("Отключение");
                                        break;

                                    case 1:
                                        class4.method_15("Возобновление");
                                        break;

                                    case 2:
                                        class4.method_15("Отмена");
                                        break;
                                }
                                class4.DateAction = class3.DateAction;
                                if (!row.method_56())
                                {
                                    class4.method_7(row.method_10());
                                }
                                if (!row.method_60())
                                {
                                    class4.method_19(row.method_14());
                                }
                                if (!row.method_58())
                                {
                                    class4.method_5(row.method_26() + " (" + row.method_24() + ")");
                                }
                                if (!row.method_44())
                                {
                                    class4.Comments = row.Comments;
                                }
                                if (!row.method_54() && (class3.TypeAction != 2))
                                {
                                    class4.method_25(row.method_8());
                                    class4.method_13(row.method_8().ToString());
                                }
                                if (!row.method_78())
                                {
                                    class4.method_29(row.method_28());
                                }
                            }
                        }
                        return;
                    }
                }
                if (form.radioButtonIndiviual.Checked && (form.textBoxName.Text != string.Empty))
                {
                    if (form.comboBoxSearchType.SelectedIndex == 0)
                    {
                        this.class207_0.vmethod_8(this.orgDataSet_0.tblAbnAplForDisconIndividualUsers, "%" + form.textBoxName.Text + "%");
                    }
                    else if (form.comboBoxSearchType.SelectedIndex == 1)
                    {
                        this.class207_0.vmethod_2(this.orgDataSet_0.tblAbnAplForDisconIndividualUsers, "%" + form.textBoxName.Text + "%");
                    }
                    this.bindingSource_2.RemoveFilter();
                    if (this.bindingSource_0.Count > 0)
                    {
                        this.orgDataSet_0.ReportODS.Clear();
                    }
                    using (enumerator = this.bindingSource_2.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            OrgDataSet.Class415 class5 = (OrgDataSet.Class415) ((DataRowView) enumerator.Current).Row;
                            if (!class5.method_38())
                            {
                                this.class202_0.vmethod_2(this.orgDataSet_0.tblAbnAplForDiscon, new int?(class5.method_0()));
                                this.bindingSource_3.RemoveFilter();
                                OrgDataSet.Class410 class6 = (OrgDataSet.Class410) ((DataRowView) this.bindingSource_3[0]).Row;
                                this.bindingSource_0.AddNew();
                                OrgDataSet.Class426 class7 = (OrgDataSet.Class426) ((DataRowView) this.bindingSource_0.Current).Row;
                                class7.method_23(false);
                                class7.method_3(class5.Id);
                                switch (class6.NetArea)
                                {
                                    case 0:
                                        class7.NetArea = "Сетевой район 1";
                                        break;

                                    case 1:
                                        class7.NetArea = "Сетевой район 2";
                                        break;

                                    case 2:
                                        class7.NetArea = "Сетевой район 3";
                                        break;

                                    case 3:
                                        class7.NetArea = "Сетевой район 4";
                                        break;

                                    case 4:
                                        class7.NetArea = "ОДС";
                                        break;

                                    case 5:
                                        class7.NetArea = "СЭСНО";
                                        break;
                                }
                                class7.method_9(class6.Id + ", " + class5.method_16());
                                if (!class5.method_46())
                                {
                                    class7.Code = class5.Code.ToString();
                                }
                                if (!class5.method_30())
                                {
                                    class7.method_11(class5.FIO);
                                }
                                if (!class5.method_32())
                                {
                                    if (!class7.method_54())
                                    {
                                        class7.method_11(class7.method_10() + ",\r\n" + class5.Address);
                                    }
                                    else
                                    {
                                        class7.method_11(class5.Address);
                                    }
                                }
                                class7.Point = class5.Point;
                                switch (class6.TypeAction)
                                {
                                    case 0:
                                        class7.method_15("Отключение");
                                        break;

                                    case 1:
                                        class7.method_15("Возобнавление");
                                        break;

                                    case 2:
                                        class7.method_15("Отмена");
                                        break;
                                }
                                class7.DateAction = class6.DateAction;
                                if (!class5.method_56())
                                {
                                    class7.method_7(class5.method_8());
                                }
                                if (!class5.method_62())
                                {
                                    class7.method_19(class5.method_14());
                                }
                                if (!class5.method_58())
                                {
                                    class7.method_5(class5.method_22() + " (" + class5.method_20() + ")");
                                }
                                if (!class5.method_40())
                                {
                                    class7.Comments = class5.Comments;
                                }
                                if (!class5.method_66() && (class6.TypeAction != 2))
                                {
                                    class7.method_25(class5.method_4());
                                    class7.method_13(class5.method_18());
                                }
                                this.bindingSource_0.EndEdit();
                            }
                        }
                    }
                }
            }
        }

        private void toolStripButton_4_Click(object sender, EventArgs e)
        {
            this.formFilter_0.ShowPeriodApplication = false;
            this.formFilter_0.Legal = true;
            this.formFilter_0.Individual = true;
            this.formFilter_0.UsePeriodExecution = true;
            this.formFilter_0.BeginningOfPeriodExecution = DateTime.Today;
            this.formFilter_0.EndOfPeriodExecution = DateTime.Today;
            this.formFilter_0.Disconnection = true;
            this.formFilter_0.Resumption = true;
            this.formFilter_0.Cancel = true;
            this.formFilter_0.NetArea1 = true;
            this.formFilter_0.NetArea2 = true;
            this.formFilter_0.NetArea3 = true;
            this.formFilter_0.NetArea4 = true;
            this.formFilter_0.ODS = true;
            this.formFilter_0.SESNO = true;
            this.formFilter_0.DoNotDisplayCancelled = true;
            this.method_2();
            this.class202_0.vmethod_0(this.orgDataSet_0.tblAbnAplForDiscon);
            this.method_0();
        }

        private void toolStripButton_5_CheckedChanged(object sender, EventArgs e)
        {
            bool flag = this.toolStripButton_5.Checked;
            this.bool_0 = flag;
            this.formFilter_0.ForDisconected = !flag;
            this.method_2();
        }

        public override SQLSettings SqlSettings
        {
            get
            {
                return base.get_SqlSettings();
            }
            set
            {
                base.set_SqlSettings(value);
                this.class207_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
                this.class203_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
                this.class202_0.method_1().ConnectionString = this.get_SqlSettings().GetConnectionString();
            }
        }
    }
}

