using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FormLbr;
using Passport.Import;
using Passport.Properties;

namespace Passport.Forms.Transf
{
	public class FormImportOldTransf : FormBase
	{
		public FormImportOldTransf()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_2();
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			FormAddTransf formAddTransf = new FormAddTransf(this.SqlSettings, (int)this.comboBox_2.SelectedValue);
			if (formAddTransf.ShowDialog() == DialogResult.OK)
			{
				this.method_0();
				this.comboBox_1.SelectedValue = formAddTransf.Id;
			}
		}

		private void FormImportOldTransf_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tR_Classifier, true, "WHERE ParentKey = ';NetworkAreas;' AND Deleted = ((0)) AND isGroup = ((0))");
			this.bindingSource_2.ResetBindings(false);
			base.SelectSqlData(this.class107_0, this.class107_0.vP_GetOldPassportTransf, true);
			base.SelectSqlData(this.class107_0, this.class107_0.vP_SubstationByNetRegion, true);
			this.bindingSource_1.ResetBindings(false);
			base.SelectSqlData(this.class107_0, this.class107_0.tP_ValueLists, true, string.Format("WHERE (ParentId = 221 OR ParentId = 247 OR ParentId = 250 OR ParentId = 257) AND Deleted = ((0)) AND isGroup = ((0))", new object[0]));
		}

		private void bindingSource_2_CurrentChanged(object sender, EventArgs e)
		{
			this.bindingSource_1.Filter = string.Format("idNetRegion = {0}", ((DataRowView)this.bindingSource_2.Current)["id"]);
		}

		private void bindingSource_1_CurrentChanged(object sender, EventArgs e)
		{
			this.method_0();
		}

		private void method_0()
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tSchm_ObjList, true, string.Format("WHERE (idParent = {0} OR idParentAddl = {0}) AND TypeCodeId = 556 AND Deleted = ((0))", ((DataRowView)this.bindingSource_1.Current)["id"]));
		}

		private void dataGridView_0_SelectionChanged(object sender, EventArgs e)
		{
		}

		public int tP_PassportAddRow(int idObjList, DateTime date, bool isActive, bool deleted, int idOldPassport)
		{
			Class107.Class257 @class = this.class107_0.tP_Passport.method_5();
			@class.idObjList = idObjList;
			@class.idEquipment = -1;
			@class.Number = 0;
			@class.Date = date;
			@class.DateIn = DateTime.Now;
			@class.isActive = isActive;
			@class.Deleted = deleted;
			@class.idOldPassport = idOldPassport;
			this.class107_0.tP_Passport.method_0(@class);
			return base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tP_Passport);
		}

		public bool tP_ObjectCharAddRow(int idPassport, List<Parameter> parameters, bool deleted)
		{
			foreach (Parameter parameter in parameters)
			{
				Class107.Class208 @class = this.class107_0.tP_ObjectChar.method_5();
				@class.idPassport = idPassport;
				@class.idObjChar = parameter.IdParameter;
				@class.Value = parameter.Value;
				@class.Deleted = deleted;
				this.class107_0.tP_ObjectChar.method_0(@class);
			}
			return base.InsertSqlData(this.class107_0, this.class107_0.tP_ObjectChar);
		}

		public bool AddMoveTransf(int idOldTransf, int idTrandf)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.vP_I_OldMoveTransf, true, string.Format("WHERE id = " + idOldTransf.ToString(), new object[0]));
			foreach (object obj in this.class107_0.vP_I_OldMoveTransf.Rows)
			{
				Class107.Class268 @class = (Class107.Class268)obj;
				Class107.Class243 class2 = this.class107_0.tSchm_Move.method_5();
				class2.idObjList = idTrandf;
				class2.Action = @class.idAction;
				class2.Data = @class.Date;
				class2.Direction = @class.Direction;
				class2.Comment = @class.Comment;
				class2.Deleted = false;
				this.class107_0.tSchm_Move.method_0(class2);
			}
			return base.InsertSqlData(this.class107_0, this.class107_0.tSchm_Move);
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_0.SelectedRows != null && this.comboBox_1.SelectedValue != null)
			{
				Class322.smethod_7(this.SqlSettings, (int)this.comboBox_1.SelectedValue, false);
				int idPassport = this.tP_PassportAddRow((int)this.comboBox_1.SelectedValue, DateTime.Now, true, false, (int)this.dataGridView_0.SelectedRows[0].Cells["idOldPassport"].Value);
				List<Parameter> parameters = this.method_1();
				this.tP_ObjectCharAddRow(idPassport, parameters, false);
				if (!Class322.smethod_8(this.SqlSettings, (int)this.comboBox_1.SelectedValue))
				{
					this.AddMoveTransf((int)this.dataGridView_0.SelectedRows[0].Cells["idOldPassport"].Value, (int)this.comboBox_1.SelectedValue);
				}
			}
			base.SelectSqlData(this.class107_0, this.class107_0.vP_GetOldPassportTransf, true);
			this.dataGridView_0.Refresh();
		}

		private List<Parameter> method_1()
		{
			return new List<Parameter>
			{
				new Parameter(92, this.FfMmEaOaapl(this.dataGridView_0.SelectedRows[0].Cells["TypeTransf"].Value.ToString()).ToString()),
				new Parameter(93, this.FfMmEaOaapl(this.dataGridView_0.SelectedRows[0].Cells["Power"].Value.ToString()).ToString()),
				new Parameter(96, this.FfMmEaOaapl(this.dataGridView_0.SelectedRows[0].Cells["HighVoltage"].Value.ToString()).ToString()),
				new Parameter(97, this.FfMmEaOaapl(this.dataGridView_0.SelectedRows[0].Cells["LowVoltage"].Value.ToString()).ToString()),
				new Parameter(95, this.dataGridView_0.SelectedRows[0].Cells["InventoryNumber"].Value.ToString()),
				new Parameter(94, this.dataGridView_0.SelectedRows[0].Cells["SerialNumber"].Value.ToString()),
				new Parameter(99, this.dataGridView_0.SelectedRows[0].Cells["GR_OBMOTKA"].Value.ToString()),
				new Parameter(98, this.dataGridView_0.SelectedRows[0].Cells["BUILD_YEAR"].Value.ToString())
			};
		}

		private int FfMmEaOaapl(string string_0)
		{
			EnumerableRowCollection<int> source = from row in this.class107_0.tP_ValueLists
			where row.Name == string_0
			select row.id;
			if (source.Count<int>() == 0)
			{
				return -1;
			}
			return source.First<int>();
		}

		private void MpmmEsosFuT_Click(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.vP_GetOldPassportTransf, true);
			this.dataGridView_0.Refresh();
		}

		private void button_2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			FormImportOldTransf.STNah1Fw48kXZYIBDoS(this, disposing);
		}

		private void method_2()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.dataGridView_0 = new DataGridView();
			this.class107_0 = new Class107();
			this.panel_0 = new Panel();
			this.MpmmEsosFuT = new Button();
			this.button_2 = new Button();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.comboBox_1 = new ComboBox();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.label_1 = new Label();
			this.comboBox_2 = new ComboBox();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.label_2 = new Label();
			this.comboBox_0 = new ComboBox();
			this.bindingSource_2 = new BindingSource(this.icontainer_0);
			this.label_0 = new Label();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.tableLayoutPanel_0.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			((ISupportInitialize)this.class107_0).BeginInit();
			this.panel_0.SuspendLayout();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			((ISupportInitialize)this.bindingSource_2).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 3;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 244f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 157f));
			this.tableLayoutPanel_0.Controls.Add(this.dataGridView_0, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.panel_0, 1, 0);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Margin = new Padding(4);
			this.tableLayoutPanel_0.Name = "tlpGeneral";
			this.tableLayoutPanel_0.RowCount = 1;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.Size = new Size(1174, 668);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.AllowUserToOrderColumns = true;
			this.dataGridView_0.AutoGenerateColumns = false;
			this.dataGridView_0.BackgroundColor = Color.White;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewTextBoxColumn_8,
				this.dataGridViewTextBoxColumn_9,
				this.dataGridViewTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_11
			});
			this.dataGridView_0.DataMember = "vP_GetOldPassportTransf";
			this.dataGridView_0.DataSource = this.class107_0;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.White;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = Color.White;
			dataGridViewCellStyle2.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_0.Dock = DockStyle.Fill;
			this.dataGridView_0.Location = new Point(4, 4);
			this.dataGridView_0.Margin = new Padding(4);
			this.dataGridView_0.Name = "dgvOldTransf";
			this.dataGridView_0.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_0.RowHeadersVisible = false;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(765, 660);
			this.dataGridView_0.TabIndex = 2;
			this.dataGridView_0.SelectionChanged += this.dataGridView_0_SelectionChanged;
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableLayoutPanel_0.SetColumnSpan(this.panel_0, 2);
			this.panel_0.Controls.Add(this.MpmmEsosFuT);
			this.panel_0.Controls.Add(this.button_2);
			this.panel_0.Controls.Add(this.button_0);
			this.panel_0.Controls.Add(this.button_1);
			this.panel_0.Controls.Add(this.comboBox_1);
			this.panel_0.Controls.Add(this.label_1);
			this.panel_0.Controls.Add(this.comboBox_2);
			this.panel_0.Controls.Add(this.label_2);
			this.panel_0.Controls.Add(this.comboBox_0);
			this.panel_0.Controls.Add(this.label_0);
			this.panel_0.Dock = DockStyle.Fill;
			this.panel_0.Location = new Point(777, 4);
			this.panel_0.Margin = new Padding(4);
			this.panel_0.Name = "pnlImport";
			this.panel_0.Size = new Size(393, 660);
			this.panel_0.TabIndex = 3;
			this.MpmmEsosFuT.Location = new Point(19, 377);
			this.MpmmEsosFuT.Margin = new Padding(4);
			this.MpmmEsosFuT.Name = "btnRefresh";
			this.MpmmEsosFuT.Size = new Size(115, 28);
			this.MpmmEsosFuT.TabIndex = 9;
			this.MpmmEsosFuT.Text = "Обновить";
			this.MpmmEsosFuT.UseVisualStyleBackColor = true;
			this.MpmmEsosFuT.Click += this.MpmmEsosFuT_Click;
			this.button_2.DialogResult = DialogResult.Cancel;
			this.button_2.Location = new Point(275, 377);
			this.button_2.Margin = new Padding(9, 9, 4, 9);
			this.button_2.Name = "btnCancel";
			this.button_2.Size = new Size(100, 28);
			this.button_2.TabIndex = 8;
			this.button_2.Text = "Закрыть";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			this.button_0.Location = new Point(141, 377);
			this.button_0.Margin = new Padding(4);
			this.button_0.Name = "btnImport";
			this.button_0.Size = new Size(127, 28);
			this.button_0.TabIndex = 7;
			this.button_0.Text = "Привязать";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Image = Resources.smethod_0();
			this.button_1.Location = new Point(327, 111);
			this.button_1.Margin = new Padding(4);
			this.button_1.Name = "btnAddTransf";
			this.button_1.Size = new Size(48, 30);
			this.button_1.TabIndex = 6;
			this.button_1.Text = " ";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.comboBox_1.DataSource = this.bindingSource_0;
			this.comboBox_1.DisplayMember = "Name";
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(148, 113);
			this.comboBox_1.Margin = new Padding(4);
			this.comboBox_1.Name = "cbTransf";
			this.comboBox_1.Size = new Size(169, 24);
			this.comboBox_1.TabIndex = 5;
			this.comboBox_1.ValueMember = "Id";
			this.bindingSource_0.DataMember = "tSchm_ObjList";
			this.bindingSource_0.DataSource = this.class107_0;
			this.bindingSource_0.Sort = "Name";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(21, 117);
			this.label_1.Margin = new Padding(4, 0, 4, 0);
			this.label_1.Name = "label3";
			this.label_1.Size = new Size(115, 17);
			this.label_1.TabIndex = 4;
			this.label_1.Text = "Трансформатор";
			this.comboBox_2.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "IdParent", true));
			this.comboBox_2.DataSource = this.bindingSource_1;
			this.comboBox_2.DisplayMember = "FullName";
			this.comboBox_2.FormattingEnabled = true;
			this.comboBox_2.Location = new Point(148, 73);
			this.comboBox_2.Margin = new Padding(4);
			this.comboBox_2.Name = "cbSubstation";
			this.comboBox_2.Size = new Size(227, 24);
			this.comboBox_2.TabIndex = 3;
			this.comboBox_2.ValueMember = "id";
			this.bindingSource_1.DataMember = "vP_SubstationByNetRegion";
			this.bindingSource_1.DataSource = this.class107_0;
			this.bindingSource_1.Sort = "FullName";
			this.bindingSource_1.CurrentChanged += this.bindingSource_1_CurrentChanged;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(21, 76);
			this.label_2.Margin = new Padding(4, 0, 4, 0);
			this.label_2.Name = "label2";
			this.label_2.Size = new Size(88, 17);
			this.label_2.TabIndex = 2;
			this.label_2.Text = "Подстанция";
			this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_1, "idNetRegion", true));
			this.comboBox_0.DataSource = this.bindingSource_2;
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(148, 32);
			this.comboBox_0.Margin = new Padding(4);
			this.comboBox_0.Name = "cbNetRegion";
			this.comboBox_0.Size = new Size(227, 24);
			this.comboBox_0.TabIndex = 1;
			this.comboBox_0.ValueMember = "Id";
			this.bindingSource_2.DataMember = "tR_Classifier";
			this.bindingSource_2.DataSource = this.class107_0;
			this.bindingSource_2.Sort = "Name";
			this.bindingSource_2.CurrentChanged += this.bindingSource_2_CurrentChanged;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(21, 36);
			this.label_0.Margin = new Padding(4, 0, 4, 0);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(107, 17);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "Сетевой район";
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "Comment1";
			this.dataGridViewTextBoxColumn_0.HeaderText = "Подстанция";
			this.dataGridViewTextBoxColumn_0.Name = "NameSubstation";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "ID";
			this.dataGridViewTextBoxColumn_1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn_1.Name = "idOldPassport";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "idSubstation";
			this.dataGridViewTextBoxColumn_2.HeaderText = "idSubstation";
			this.dataGridViewTextBoxColumn_2.Name = "idSubstation";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_3.HeaderText = "№";
			this.dataGridViewTextBoxColumn_3.Name = "NumberTransf";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Width = 40;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "TR_TYPE";
			this.dataGridViewTextBoxColumn_4.HeaderText = "Тип";
			this.dataGridViewTextBoxColumn_4.Name = "TypeTransf";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "INV_NOMER";
			this.dataGridViewTextBoxColumn_5.HeaderText = "Инвентарный номер";
			this.dataGridViewTextBoxColumn_5.Name = "InventoryNumber";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "ZAV_NOMER";
			this.dataGridViewTextBoxColumn_6.HeaderText = "Заводской номер";
			this.dataGridViewTextBoxColumn_6.Name = "SerialNumber";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "POWER";
			this.dataGridViewTextBoxColumn_7.HeaderText = "Мощность";
			this.dataGridViewTextBoxColumn_7.Name = "Power";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Width = 60;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "HighVoltage";
			this.dataGridViewTextBoxColumn_8.HeaderText = "Напр.";
			this.dataGridViewTextBoxColumn_8.Name = "HighVoltage";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Width = 40;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "LowVoltage";
			this.dataGridViewTextBoxColumn_9.HeaderText = "LowVoltage";
			this.dataGridViewTextBoxColumn_9.Name = "LowVoltage";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.Visible = false;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "GR_OBMOTKA";
			this.dataGridViewTextBoxColumn_10.HeaderText = "Группа обмоток";
			this.dataGridViewTextBoxColumn_10.Name = "GR_OBMOTKA";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.Width = 60;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "BUILD_YEAR";
			this.dataGridViewTextBoxColumn_11.HeaderText = "Год постройки";
			this.dataGridViewTextBoxColumn_11.Name = "BUILD_YEAR";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_2;
			base.ClientSize = new Size(1174, 668);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Margin = new Padding(4);
			base.Name = "FormImportOldTransf";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Непрогруженные трансформаторы";
			base.Load += this.FormImportOldTransf_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			((ISupportInitialize)this.dataGridView_0).EndInit();
			((ISupportInitialize)this.class107_0).EndInit();
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			((ISupportInitialize)this.bindingSource_2).EndInit();
			base.ResumeLayout(false);
		}

		internal static void STNah1Fw48kXZYIBDoS(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private DataGridView dataGridView_0;

		private Class107 class107_0;

		private Panel panel_0;

		private ComboBox comboBox_0;

		private Label label_0;

		private Button button_0;

		private Button button_1;

		private ComboBox comboBox_1;

		private Label label_1;

		private ComboBox comboBox_2;

		private Label label_2;

		private BindingSource bindingSource_0;

		private BindingSource bindingSource_1;

		private BindingSource bindingSource_2;

		private Button MpmmEsosFuT;

		private Button button_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;
	}
}
