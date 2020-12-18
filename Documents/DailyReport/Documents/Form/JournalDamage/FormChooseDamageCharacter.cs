using DataSql;
using FormLbr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
/// <summary>
/// Выбор оборудования
/// Список поврежденного обоудования (харктер повреждения)
/// c0002d8
/// </summary>
internal class FormChooseDamageCharacter : FormBase
{
    private BindingSource bindingSource_0;
    private Button buttonOK;
    private Button buttonCancel;
    private DataColumn dataColumn_0;
    private DataColumn dataColumn_1;
    private DataColumn dataColumn_2;
    private DataColumn dataColumn_3;
    private DataColumn dataColumn_4;
    private DataGridView dgv;
    private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;
    private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;
    private DataSet dataSet_0;
    private DataTable dataTable_0;
    private IContainer components=null;
    /// <summary>
    /// возвращаемый список повреждений
    /// </summary>
    private List<int> listDamage;
    /// <summary>
    ////список повреждений
    /// </summary>
    private List<int> ListIdCharacterParent;
    private int? IdParentDocument;
    private int? IdDocument;

    internal FormChooseDamageCharacter()
    {
        this.InitializeComponent();
    }

    internal FormChooseDamageCharacter(int? idParentDocument = new int?(), List<int> listIdCharacterParent = null, int? idDocument = new int?())
    {
        this.InitializeComponent();
        this.IdParentDocument = idParentDocument;
        this.ListIdCharacterParent = listIdCharacterParent;
        this.IdDocument = idDocument;
    }

    private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        if (this.dgv.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
        {
            e.Cancel = true;
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && (this.components != null))
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void FormChooseDamageCharacter_FormClosing(object sender, FormClosingEventArgs e)
    {
        /// вернем список поврежденного обоудования (харктер повреждения)
        if (base.DialogResult == DialogResult.OK)
        {
            this.listDamage = new List<int>();
            foreach (DataGridViewRow row in (IEnumerable) this.dgv.Rows)
            {
                if ((row.Cells[this.dataGridViewCheckBoxColumn_0.Name].Value != null) && Convert.ToBoolean(row.Cells[this.dataGridViewCheckBoxColumn_0.Name].Value))
                {
                    this.listDamage.Add(Convert.ToInt32(row.Cells[this.dataGridViewTextBoxColumn_0.Name].Value));
                }
            }
            // проверка на создание акта расследования без оборудования (пустого)
            if (((this.ListIdCharacterParent == null) && !this.IdDocument.HasValue) && (this.listDamage.Count == 0))
            {
                DataTable table = new DataTable("tJ_Damage");
                table.Columns.Add("id", typeof(int));
                table.Columns.Add("numRequest", typeof(string));
                table.Columns.Add("dateDoc", typeof(DateTime));
                base.SelectSqlData(table, true, string.Format("where idParent = {0} and typeDoc = {1} \r\n                        and not exists(select id from tJ_DamageCharacter where idDAmage = tj_damage.id)", this.IdParentDocument, 0x752), null, false, 0);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show(string.Format("Акт без оборудования уже существует. (Акт №{0} от {1})\r\nНевозможно создать акт.", table.Rows[0]["numRequest"].ToString(), Convert.ToDateTime(table.Rows[0]["dateDoc"]).ToString("dd.MM.yyyy")), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    base.DialogResult = DialogResult.Cancel;
                }
            }
        }
    }

    private void FormChooseDamageCharacter_Load(object sender, EventArgs e)
    {
        if (this.IdParentDocument.HasValue)
        {
            this.method_1();
        }
    }
    /// <summary>
    /// возврат списка повреждений (оборудования)
    /// </summary>
    internal IEnumerable<int> getListDamage()
    {
        return this.listDamage.AsEnumerable<int>();
    }

    private void method_1()
    {
        this.dataGridViewTextBoxColumn_4.ReadOnly = true;
        this.dataGridViewComboBoxColumn_0.ReadOnly = true;
        this.dgv.Rows.Clear();
        string str = "";
        if (this.IdDocument.HasValue)
        {
            str = " and dd.id <> " + this.IdDocument.Value.ToString();
        }
        string str2 = "";
        if ((this.ListIdCharacterParent != null) && (this.ListIdCharacterParent.Count > 0))
        {
            foreach (int num3 in this.ListIdCharacterParent)
            {
                if (string.IsNullOrEmpty(str2))
                {
                    str2 = num3.ToString();
                }
                else
                {
                    str2 = str2 + "," + num3.ToString();
                }
            }
            str2 = " and d.id not in (" + str2 + ") ";
        }
        this.dataTable_0 = new SqlDataCommand(this.SqlSettings).SelectSqlData(string.Format("select d.[ID], d.[IDDAMAGE], d.[IDSCHMOBJ],\r\n\t                                          d.[IDLINESECTION], ctype.name as typeSchm\r\n                            from tJ_DamageCharacter d\r\n\t                                left join tr_classifier cType on cType.id = d.col1 \r\n                            where d.idDamage = {0} and  d.id not in (\r\n                                      select c.idCharacterParent from tJ_damage dd\r\n\t                                         inner join tJ_damageCharacter c on c.idDAmage = dd.id\r\n                                      where idParent = {0} and typeDoc = {1} {2}) {3}", new object[] { this.IdParentDocument.Value, 0x752, str, str2 }));
        int num = 0;
        foreach (DataRow row in this.dataTable_0.Rows)
        {
            this.dgv.Rows.Add();
            this.dgv[this.dataGridViewTextBoxColumn_0.Index, num].Value = row["id"];
            this.dgv[this.dataGridViewTextBoxColumn_3.Index, num].Value = row["typeSChm"];
            if (row["idSchmObj"] != DBNull.Value)
            {
                this.dgv[this.dataGridViewTextBoxColumn_2.Index, num].Value = row["idSchmObj"];
                string[] textArray1 = new string[] { row["idSchmObj"].ToString() };
                object obj2 = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", textArray1);
                if ((obj2 != null) && (obj2 != DBNull.Value))
                {
                    this.dgv[this.dataGridViewTextBoxColumn_4.Index, num].Value = obj2.ToString();
                }
                DataGridViewComboBoxCell cell = this.dgv[this.dataGridViewComboBoxColumn_0.Index, num] as DataGridViewComboBoxCell;
                DataTable table = new DataTable("tP_CabSection");
                table.Columns.Add("id", typeof(int));
                table.Columns.Add("number", typeof(int));
                base.SelectSqlData(table, true, "where idObjList = " + row["idSchmObj"].ToString() + " order by number", null, false, 0);
                cell.DataSource = table;
                cell.ValueMember = "id";
                cell.DisplayMember = "number";
                if (row["idLineSection"] != DBNull.Value)
                {
                    cell.Value = Convert.ToInt32(row["idLineSection"]);
                }
                else
                {
                    cell.Value = null;
                }
            }
            num++;
        }
    }

    private void InitializeComponent()
    {
        this.components = new Container();
        this.dgv = new DataGridView();
        this.buttonOK = new Button();
        this.buttonCancel = new Button();
        this.dataSet_0 = new DataSet();
        this.dataTable_0 = new DataTable();
        this.dataColumn_0 = new DataColumn();
        this.dataColumn_1 = new DataColumn();
        this.dataColumn_2 = new DataColumn();
        this.dataColumn_3 = new DataColumn();
        this.bindingSource_0 = new BindingSource(this.components);
        this.dataColumn_4 = new DataColumn();
        this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
        this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
        this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
        ((ISupportInitialize) this.dgv).BeginInit();
        this.dataSet_0.BeginInit();
        this.dataTable_0.BeginInit();
        ((ISupportInitialize) this.bindingSource_0).BeginInit();
        base.SuspendLayout();
        this.dgv.AllowUserToAddRows = false;
        this.dgv.AllowUserToDeleteRows = false;
        this.dgv.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top;
        this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { this.dataGridViewCheckBoxColumn_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewTextBoxColumn_1, this.dataGridViewTextBoxColumn_2, this.dataGridViewTextBoxColumn_3, this.dataGridViewTextBoxColumn_4, this.dataGridViewComboBoxColumn_0 };
        this.dgv.Columns.AddRange(dataGridViewColumns);
        this.dgv.EditMode = DataGridViewEditMode.EditOnEnter;
        this.dgv.Location = new Point(0, 0);
        this.dgv.Name = "dgv";
        this.dgv.Size = new Size(0x187, 0x12b);
        this.dgv.TabIndex = 0;
        this.dgv.DataError += new DataGridViewDataErrorEventHandler(this.dgv_DataError);
        this.buttonOK.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
        this.buttonOK.DialogResult = DialogResult.OK;
        this.buttonOK.Location = new Point(12, 0x131);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new Size(0x4b, 0x17);
        this.buttonOK.TabIndex = 1;
        this.buttonOK.Text = "ОК";
        this.buttonOK.UseVisualStyleBackColor = true;
        this.buttonCancel.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
        this.buttonCancel.DialogResult = DialogResult.Cancel;
        this.buttonCancel.Location = new Point(0x132, 0x131);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new Size(0x4b, 0x17);
        this.buttonCancel.TabIndex = 2;
        this.buttonCancel.Text = "Отмена";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.dataSet_0.DataSetName = "NewDataSet";
        DataTable[] tables = new DataTable[] { this.dataTable_0 };
        this.dataSet_0.Tables.AddRange(tables);
        DataColumn[] columns = new DataColumn[] { this.dataColumn_0, this.dataColumn_1, this.dataColumn_2, this.dataColumn_3, this.dataColumn_4 };
        this.dataTable_0.Columns.AddRange(columns);
        Constraint[] constraints = new Constraint[1];
        string[] columnNames = new string[] { "id" };
        constraints[0] = new UniqueConstraint("Constraint1", columnNames, true);
        this.dataTable_0.Constraints.AddRange(constraints);
        this.dataTable_0.PrimaryKey = new DataColumn[] { this.dataColumn_0 };
        this.dataTable_0.TableName = "tJ_DamageCharacter";
        this.dataColumn_0.AllowDBNull = false;
        this.dataColumn_0.ColumnName = "id";
        this.dataColumn_0.DataType = typeof(int);
        this.dataColumn_1.AllowDBNull = false;
        this.dataColumn_1.ColumnName = "idDamage";
        this.dataColumn_1.DataType = typeof(int);
        this.dataColumn_2.ColumnName = "idSchmObj";
        this.dataColumn_2.DataType = typeof(int);
        this.dataColumn_3.ColumnName = "idLineSection";
        this.bindingSource_0.DataMember = "tJ_DamageCharacter";
        this.bindingSource_0.DataSource = this.dataSet_0;
        this.dataColumn_4.ColumnName = "typeSchm";
        this.dataGridViewCheckBoxColumn_0.HeaderText = "";
        this.dataGridViewCheckBoxColumn_0.Name = "checkedColumn";
        this.dataGridViewCheckBoxColumn_0.Width = 30;
        this.dataGridViewTextBoxColumn_0.HeaderText = "idColumn";
        this.dataGridViewTextBoxColumn_0.Name = "idColumn";
        this.dataGridViewTextBoxColumn_0.Visible = false;
        this.dataGridViewTextBoxColumn_1.HeaderText = "idDamageColumn";
        this.dataGridViewTextBoxColumn_1.Name = "idDamageColumn";
        this.dataGridViewTextBoxColumn_1.Visible = false;
        this.dataGridViewTextBoxColumn_2.HeaderText = "idSchmObj";
        this.dataGridViewTextBoxColumn_2.Name = "idSchmObjColumn";
        this.dataGridViewTextBoxColumn_2.Visible = false;
        this.dataGridViewTextBoxColumn_3.HeaderText = "Тип";
        this.dataGridViewTextBoxColumn_3.Name = "typeSchmDgvColumn";
        this.dataGridViewTextBoxColumn_3.Width = 60;
        this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewTextBoxColumn_4.HeaderText = "Объект";
        this.dataGridViewTextBoxColumn_4.Name = "schmObjColumn";
        this.dataGridViewTextBoxColumn_4.Resizable = DataGridViewTriState.True;
        this.dataGridViewTextBoxColumn_4.SortMode = DataGridViewColumnSortMode.Programmatic;
        this.dataGridViewComboBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.dataGridViewComboBoxColumn_0.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
        this.dataGridViewComboBoxColumn_0.FillWeight = 40f;
        this.dataGridViewComboBoxColumn_0.HeaderText = "Участок";
        this.dataGridViewComboBoxColumn_0.Name = "idLineSectionColumn";
        this.dataGridViewComboBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
        base.AcceptButton = this.buttonOK;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.buttonCancel;
        base.ClientSize = new Size(0x189, 0x150);
        base.Controls.Add(this.buttonCancel);
        base.Controls.Add(this.buttonOK);
        base.Controls.Add(this.dgv);
        base.Name = "FormChooseDamageCharacter";
        base.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Выбор оборудования";
        base.FormClosing += new FormClosingEventHandler(this.FormChooseDamageCharacter_FormClosing);
        base.Load += new EventHandler(this.FormChooseDamageCharacter_Load);
        ((ISupportInitialize) this.dgv).EndInit();
        this.dataSet_0.EndInit();
        this.dataTable_0.EndInit();
        ((ISupportInitialize) this.bindingSource_0).EndInit();
        base.ResumeLayout(false);
    }
}

