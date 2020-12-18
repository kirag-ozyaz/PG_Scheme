using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormChooseDamageCharacter : FormLbr.FormBase
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}

    private System.ComponentModel.IContainer components = null;


    private void InitializeComponent()
    {
        this.components = new Container();
        this.dgv = new DataGridView();
        this.buttonOK = new Button();
        this.buttonCancel = new Button();
        this.ds = new DataSet();
        this.tJ_DamageCharacter = new DataTable();
        this.columnId = new DataColumn();
        this.columnIdDamage = new DataColumn();
        this.columnIdSchmObj = new DataColumn();
        this.columnIdLineSection = new DataColumn();
        this.bindingSource_0 = new BindingSource(this.components);
        this.columnTypeSchm = new DataColumn();
        this.checkedColumn = new DataGridViewCheckBoxColumn();
        this.idColumn = new DataGridViewTextBoxColumn();
        this.idDamageColumn = new DataGridViewTextBoxColumn();
        this.idSchmObjColumn = new DataGridViewTextBoxColumn();
        this.typeSchmDgvColumn = new DataGridViewTextBoxColumn();
        this.schmObjColumn = new DataGridViewTextBoxColumn();
        this.idLineSectionColumn = new DataGridViewComboBoxColumn();
        ((ISupportInitialize)this.dgv).BeginInit();
        ((ISupportInitialize)this.ds).BeginInit();
        ((ISupportInitialize)this.tJ_DamageCharacter).BeginInit();
        ((ISupportInitialize)this.bindingSource_0).BeginInit();
        base.SuspendLayout();
        this.dgv.AllowUserToAddRows = false;
        this.dgv.AllowUserToDeleteRows = false;
        this.dgv.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
        this.dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgv.Columns.AddRange(new DataGridViewColumn[]
        {
            this.checkedColumn,
            this.idColumn,
            this.idDamageColumn,
            this.idSchmObjColumn,
            this.typeSchmDgvColumn,
            this.schmObjColumn,
            this.idLineSectionColumn
        });
        this.dgv.EditMode = DataGridViewEditMode.EditOnEnter;
        this.dgv.Location = new Point(0, 0);
        this.dgv.Name = "dgv";
        this.dgv.Size = new Size(391, 299);
        this.dgv.TabIndex = 0;
        this.dgv.DataError += this.dgv_DataError;
        this.buttonOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
        this.buttonOK.DialogResult = DialogResult.OK;
        this.buttonOK.Location = new Point(12, 305);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new Size(75, 23);
        this.buttonOK.TabIndex = 1;
        this.buttonOK.Text = "ОК";
        this.buttonOK.UseVisualStyleBackColor = true;
        this.buttonCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
        this.buttonCancel.DialogResult = DialogResult.Cancel;
        this.buttonCancel.Location = new Point(306, 305);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new Size(75, 23);
        this.buttonCancel.TabIndex = 2;
        this.buttonCancel.Text = "Отмена";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.ds.DataSetName = "NewDataSet";
        this.ds.Tables.AddRange(new DataTable[]
        {
            this.tJ_DamageCharacter
        });
        this.tJ_DamageCharacter.Columns.AddRange(new DataColumn[]
        {
            this.columnId,
            this.columnIdDamage,
            this.columnIdSchmObj,
            this.columnIdLineSection,
            this.columnTypeSchm
        });
        this.tJ_DamageCharacter.Constraints.AddRange(new Constraint[]
        {
            new UniqueConstraint("Constraint1", new string[]
            {
                "id"
            }, true)
        });
        this.tJ_DamageCharacter.PrimaryKey = new DataColumn[]
        {
            this.columnId
        };
        this.tJ_DamageCharacter.TableName = "tJ_DamageCharacter";
        this.columnId.AllowDBNull = false;
        this.columnId.ColumnName = "id";
        this.columnId.DataType = typeof(int);
        this.columnIdDamage.AllowDBNull = false;
        this.columnIdDamage.ColumnName = "idDamage";
        this.columnIdDamage.DataType = typeof(int);
        this.columnIdSchmObj.ColumnName = "idSchmObj";
        this.columnIdSchmObj.DataType = typeof(int);
        this.columnIdLineSection.ColumnName = "idLineSection";
        this.bindingSource_0.DataMember = "tJ_DamageCharacter";
        this.bindingSource_0.DataSource = this.ds;
        this.columnTypeSchm.ColumnName = "typeSchm";


        this.checkedColumn.HeaderText = "";
        this.checkedColumn.Name = "checkedColumn";
        this.checkedColumn.Width = 30;
        this.idColumn.HeaderText = "idColumn";
        this.idColumn.Name = "idColumn";
        this.idColumn.Visible = false;
        this.idDamageColumn.HeaderText = "idDamageColumn";
        this.idDamageColumn.Name = "idDamageColumn";
        this.idDamageColumn.Visible = false;
        this.idSchmObjColumn.HeaderText = "idSchmObj";
        this.idSchmObjColumn.Name = "idSchmObjColumn";
        this.idSchmObjColumn.Visible = false;
        this.typeSchmDgvColumn.HeaderText = "Тип";
        this.typeSchmDgvColumn.Name = "typeSchmDgvColumn";
        this.typeSchmDgvColumn.Width = 60;
        this.schmObjColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.schmObjColumn.HeaderText = "Объект";
        this.schmObjColumn.Name = "schmObjColumn";
        this.schmObjColumn.Resizable = DataGridViewTriState.True;
        this.schmObjColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
        this.idLineSectionColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        this.idLineSectionColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
        this.idLineSectionColumn.FillWeight = 40f;
        this.idLineSectionColumn.HeaderText = "Участок";
        this.idLineSectionColumn.Name = "idLineSectionColumn";
        this.idLineSectionColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
        base.AcceptButton = this.buttonOK;
        base.AutoScaleDimensions = new SizeF(6f, 13f);
        base.AutoScaleMode = AutoScaleMode.Font;
        base.CancelButton = this.buttonCancel;
        base.ClientSize = new Size(393, 336);
        base.Controls.Add(this.buttonCancel);
        base.Controls.Add(this.buttonOK);
        base.Controls.Add(this.dgv);
        base.Name = "FormChooseDamageCharacter";
        base.StartPosition = FormStartPosition.CenterParent;
        this.Text = "Выбор оборудования";
        this.FormClosing += new FormClosingEventHandler(this.FormChooseDamageCharacter_FormClosing);
        this.Load += new System.EventHandler(this.FormChooseDamageCharacter_Load);
        ((ISupportInitialize)this.dgv).EndInit();
        ((ISupportInitialize)this.ds).EndInit();
        ((ISupportInitialize)this.tJ_DamageCharacter).EndInit();
        ((ISupportInitialize)this.bindingSource_0).EndInit();
        base.ResumeLayout(false);
    }

    private DataGridView dgv;

    private Button buttonOK;

    private Button buttonCancel;

    private DataSet ds;

    private DataTable tJ_DamageCharacter;

    private DataColumn columnId;

    private DataColumn columnIdDamage;

    private DataColumn columnIdSchmObj;

    private DataColumn columnIdLineSection;

    private BindingSource bindingSource_0;

    private DataGridViewCheckBoxColumn checkedColumn;

    private DataGridViewTextBoxColumn idColumn;

    private DataGridViewTextBoxColumn idDamageColumn;

    private DataGridViewTextBoxColumn idSchmObjColumn;

    private DataGridViewTextBoxColumn typeSchmDgvColumn;

    private DataGridViewTextBoxColumn schmObjColumn;

    private DataGridViewComboBoxColumn idLineSectionColumn;

    private DataColumn columnTypeSchm;
}
