using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataSql;
using FormLbr;
/// <summary>
/// "Выбор оборудования"
/// </summary>
internal partial class FormChooseDamageCharacter : FormBase
{
    /// <summary>
    /// возврат списка повреждений (оборудования)
    /// </summary>
    internal IEnumerable<int> getListDamage()
    {
        return this.listDamage.AsEnumerable<int>();
    }

    internal FormChooseDamageCharacter()
    {
        this.InitializeComponent();
    }

    internal FormChooseDamageCharacter(int? idParentDocument = null, List<int> listIdCharacterParent = null, int? idDocument = null)
    {
        this.InitializeComponent();
        this.IdParentDocument = idParentDocument;
        this.ListIdCharacterParent = listIdCharacterParent;
        this.IdDocument = idDocument;
    }

    private void FormChooseDamageCharacter_Load(object sender, EventArgs e)
    {
        if (this.IdParentDocument != null)
        {
            this.LoadDataGrid();
        }
    }

    private void LoadDataGrid()
    {
        this.schmObjColumn.ReadOnly = true;
        this.idLineSectionColumn.ReadOnly = true;
        this.dgv.Rows.Clear();
        string strIdDocument = "";
        if (this.IdDocument != null)
        {
            strIdDocument = " and dd.id <> " + this.IdDocument.Value.ToString();
        }
        string str2 = "";
        if (this.ListIdCharacterParent != null && this.ListIdCharacterParent.Count > 0)
        {
            foreach (int num in this.ListIdCharacterParent)
            {
                if (string.IsNullOrEmpty(str2))
                {
                    str2 = num.ToString();
                }
                else
                {
                    str2 = str2 + "," + num.ToString();
                }
            }
            str2 = " and d.id not in (" + str2 + ") ";
        }
        SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
        this.tJ_DamageCharacter = sqlDataCommand.SelectSqlData(string.Format("select d.[ID], d.[IDDAMAGE], d.[IDSCHMOBJ],\r\n\t                                          d.[IDLINESECTION], ctype.name as typeSchm\r\n                            from tJ_DamageCharacter d\r\n\t                                left join tr_classifier cType on cType.id = d.col1 \r\n                            where d.idDamage = {0} and  d.id not in (\r\n                                      select c.idCharacterParent from tJ_damage dd\r\n\t                                         inner join tJ_damageCharacter c on c.idDAmage = dd.id\r\n                                      where idParent = {0} and typeDoc = {1} {2}) {3}", new object[]
        {
            this.IdParentDocument.Value,
            1874,
            strIdDocument,
            str2
        }));
        int num2 = 0;
        foreach (DataRow dataRow in this.tJ_DamageCharacter.Rows)
        {
            this.dgv.Rows.Add();
            this.dgv[this.idColumn.Index, num2].Value = dataRow["id"];
            this.dgv[this.typeSchmDgvColumn.Index, num2].Value = dataRow["typeSChm"];
            if (dataRow["idSchmObj"] != DBNull.Value)
            {
                this.dgv[this.idSchmObjColumn.Index, num2].Value = dataRow["idSchmObj"];
                object idSchmObj = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
                {
                    dataRow["idSchmObj"].ToString()
                });
                if (idSchmObj != null && idSchmObj != DBNull.Value)
                {
                    this.dgv[this.schmObjColumn.Index, num2].Value = idSchmObj.ToString();
                }
                DataGridViewComboBoxCell dataGridViewComboBoxCell = this.dgv[this.idLineSectionColumn.Index, num2] as DataGridViewComboBoxCell;
                DataTable dataTable = new DataTable("tP_CabSection");
                dataTable.Columns.Add("id", typeof(int));
                dataTable.Columns.Add("number", typeof(int));
                base.SelectSqlData(dataTable, true, "where idObjList = " + dataRow["idSchmObj"].ToString() + " order by number", null, false, 0);
                dataGridViewComboBoxCell.DataSource = dataTable;
                dataGridViewComboBoxCell.ValueMember = "id";
                dataGridViewComboBoxCell.DisplayMember = "number";
                if (dataRow["idLineSection"] != DBNull.Value)
                {
                    dataGridViewComboBoxCell.Value = Convert.ToInt32(dataRow["idLineSection"]);
                }
                else
                {
                    dataGridViewComboBoxCell.Value = null;
                }
            }
            num2++;
        }
    }

    private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        if (this.dgv.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
        {
            e.Cancel = true;
        }
    }

    private void FormChooseDamageCharacter_FormClosing(object sender, FormClosingEventArgs e)
    {
        /// вернем список поврежденного обоудования (характер повреждения)
        if (base.DialogResult == DialogResult.OK)
        {
            this.listDamage = new List<int>();
            foreach (DataGridViewRow dataGridViewRow in ((IEnumerable)this.dgv.Rows))
            {
                if (dataGridViewRow.Cells[this.checkedColumn.Name].Value != null && Convert.ToBoolean(dataGridViewRow.Cells[this.checkedColumn.Name].Value))
                {
                    this.listDamage.Add(Convert.ToInt32(dataGridViewRow.Cells[this.idColumn.Name].Value));
                }
            }
            // проверка на создание акта расследования без оборудования (пустого)
            if (this.ListIdCharacterParent == null && this.IdDocument == null && this.listDamage.Count == 0)
            {
                DataTable dataTable = new DataTable("tJ_Damage");
                dataTable.Columns.Add("id", typeof(int));
                dataTable.Columns.Add("numRequest", typeof(string));
                dataTable.Columns.Add("dateDoc", typeof(DateTime));
                base.SelectSqlData(dataTable, true, string.Format("where idParent = {0} and typeDoc = {1} \r\n                        and not exists(select id from tJ_DamageCharacter where idDAmage = tj_damage.id)", this.IdParentDocument, 1874), null, false, 0);
                if (dataTable.Rows.Count > 0)
                {
                    MessageBox.Show(string.Format("Акт без оборудования уже существует. (Акт №{0} от {1})\r\nНевозможно создать акт.", dataTable.Rows[0]["numRequest"].ToString(), Convert.ToDateTime(dataTable.Rows[0]["dateDoc"]).ToString("dd.MM.yyyy")), "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    base.DialogResult = DialogResult.Cancel;
                    return;
                }
            }
        }
    }

    private int? IdParentDocument;
    /// <summary>
    /// возвращаемый список повреждений
    /// </summary>
    private List<int> listDamage;
    /// <summary>
    ////список повреждений
    /// </summary>
    private List<int> ListIdCharacterParent;

    private int? IdDocument;

}
