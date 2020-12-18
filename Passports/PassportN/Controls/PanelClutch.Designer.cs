using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using DataSql;
using Passport.Classes;

namespace Passport.Controls
{
	public class PanelClutch : Panel
	{
		public PanelClutch()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_4();
		}

		public PanelClutch(SQLSettings settings, int id, StateFormCreate State)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_4();
			this.sqlsettings_0 = settings;
			this.int_0 = ((this.stateFormCreate_0 == 1) ? id : -1);
			this.int_1 = ((this.stateFormCreate_0 == null) ? id : -1);
			this.stateFormCreate_0 = State;
		}

		public SQLSettings SqlSettings
		{
			get
			{
				return this.sqlsettings_0;
			}
			set
			{
				this.sqlsettings_0 = value;
			}
		}

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

		public int IdCable
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

		public TypeClutch ClutchType
		{
			get
			{
				return this.typeClutch_0;
			}
		}

		public EndClutch ClutchEnd
		{
			get
			{
				return this.endClutch_0;
			}
		}

		public StateFormCreate CreateState
		{
			get
			{
				return this.stateFormCreate_0;
			}
			set
			{
				this.stateFormCreate_0 = value;
			}
		}

		public bool WithClutches
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				this.bool_2 = value;
			}
		}

		public void Fill(SQLSettings settings, int id, StateFormCreate state)
		{
			this.SqlSettings = settings;
			if (state == null)
			{
				this.int_1 = id;
			}
			if (state == 1)
			{
				this.int_0 = id;
			}
			this.stateFormCreate_0 = state;
			this.Fill();
		}

		public void Fill()
		{
			this.DataGridViewPassport1.SqlSettings = this.SqlSettings;
			Clutch.isExistEndClutchIntoCabSection(this.SqlSettings, this.int_1, out this.bool_0, out this.bool_1);
			this.typeClutch_0 = ((!this.bool_0 || !this.bool_1) ? TypeClutch.End : TypeClutch.Connective);
			this.endClutch_0 = ((!this.bool_0) ? EndClutch.First : ((!this.bool_1) ? EndClutch.Last : EndClutch.None));
			this.method_1();
			if (this.bool_2)
			{
				if (this.stateFormCreate_0 == null)
				{
					this.method_0();
					this.DataGridViewPassport1.AddRowAddingParemeter((int)this.typeClutch_0, this.SqlSettings);
					return;
				}
				this.sqlDataCommand_0 = new SqlDataCommand(this.sqlsettings_0);
				this.sqlDataCommand_0.SelectSqlData(this.class107_0.tSchm_ObjList, true, "WHERE id = " + this.int_0.ToString(), null, false, 0);
				if (this.class107_0.tSchm_ObjList.Rows.Count == 0)
				{
					MessageBox.Show("Не найдена муфта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					this.cbNameClutch.Text = this.class107_0.tSchm_ObjList.Rows[0]["Name"].ToString();
				}
				this.int_2 = PassportData.GetActivePassport(this.SqlSettings, this.int_0);
				if (this.int_2 != -1)
				{
					this.sqlDataCommand_0.SelectSqlData(this.class107_0.tP_Passport, true, string.Format("where id = '{0}'", this.int_2), null, false, 0);
					this.DataGridViewPassport1.AddRowEditingParameter(this.SqlSettings, this.int_2, DataGridViewPassport.CreateState.EditValue);
					this.stateFormCreate_0 = 1;
					return;
				}
				this.method_0();
				this.DataGridViewPassport1.AddRowAddingParemeter((int)this.typeClutch_0, this.sqlsettings_0);
				this.stateFormCreate_0 = 0;
			}
		}

		public bool Save()
		{
			if (string.IsNullOrEmpty(this.cbNameClutch.Text))
			{
				string caption = (this.stateFormCreate_0 == null) ? "Добавление муфты" : ((this.stateFormCreate_0 == 1) ? "Редактирование муфты" : "");
				MessageBox.Show("Не введено наименование муфты.", caption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			this.DataGridViewPassport1.SqlSettings = this.sqlsettings_0;
			StateFormCreate stateFormCreate = this.stateFormCreate_0;
			if (stateFormCreate == null)
			{
				this.int_0 = this.method_2(this.cbNameClutch.Text);
				if (this.int_0 > 0)
				{
					this.DataGridViewPassport1.SaveInsertedData(this.int_0, this.dtpDatePassport.Value, Convert.ToInt32(this.class107_0.tP_Passport[0]["Number"]));
				}
				else
				{
					MessageBox.Show("Ошибка при добавлении муфты.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				return true;
			}
			if (stateFormCreate != 1)
			{
				return stateFormCreate == 7;
			}
			if (this.method_3(this.cbNameClutch.Text))
			{
				this.DataGridViewPassport1.SaveUpdatedData(this.dtpDatePassport.Value, Convert.ToInt32(this.class107_0.tP_Passport[0]["Number"]));
				return true;
			}
			MessageBox.Show("Ошибка при редактировании муфты.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}

		public bool CheckData()
		{
			if (this.cbNameClutch.Text.Length == 0)
			{
				MessageBox.Show("Не введено имя муфты!", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return false;
			}
			return true;
		}

		private void method_0()
		{
			DataRow dataRow = this.class107_0.tP_Passport.NewRow();
			dataRow["idObjList"] = this.int_0;
			dataRow["Number"] = 0;
			dataRow["date"] = DateTime.Now;
			dataRow["dateIn"] = DateTime.Now;
			dataRow["deleted"] = false;
			dataRow["isActive"] = true;
			dataRow.EndEdit();
			this.class107_0.tP_Passport.Rows.Add(dataRow);
		}

		private void method_1()
		{
			this.cbNameClutch.Text = ((this.typeClutch_0 == TypeClutch.End) ? ((this.endClutch_0 == EndClutch.None) ? "" : ((this.endClutch_0 == EndClutch.First) ? "01" : "02")) : "");
			this.cbNameClutch.ReadOnly = (this.typeClutch_0 == TypeClutch.End && (this.endClutch_0 == EndClutch.First || this.endClutch_0 == EndClutch.Last));
		}

		private int method_2(string string_0)
		{
			int result;
			try
			{
				result = Clutch.Create(this.SqlSettings, this.int_1, string_0, this.typeClutch_0);
			}
			catch (Exception)
			{
				MessageBox.Show("Невозможно вставить муфту.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = -1;
			}
			return result;
		}

		private bool method_3(string string_0)
		{
			if (this.class107_0.tSchm_ObjList.Rows.Count > 0)
			{
				this.sqlDataCommand_0 = new SqlDataCommand(this.sqlsettings_0);
				this.class107_0.tSchm_ObjList.Rows[0]["Name"] = this.cbNameClutch.Text;
				return this.sqlDataCommand_0.UpdateSqlData(this.class107_0, this.class107_0.tSchm_ObjList);
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_4()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.tlpClutch = new TableLayoutPanel();
			this.tlpPassportInfo = new TableLayoutPanel();
			this.dtpDatePassport = new DateTimePicker();
			this.class107_0 = new Class107();
			this.lblDate = new Label();
			this.nUpDwnPassportNum = new NumericUpDown();
			this.lblPassportNumber = new Label();
			this.lblPasspInfo = new Label();
			this.tlpName = new TableLayoutPanel();
			this.cbNameClutch = new TextBox();
			this.lblName = new Label();
			this.DataGridViewPassport1 = new DataGridViewPassport();
			this.tlpClutch.SuspendLayout();
			this.tlpPassportInfo.SuspendLayout();
			((ISupportInitialize)this.class107_0).BeginInit();
			((ISupportInitialize)this.nUpDwnPassportNum).BeginInit();
			this.tlpName.SuspendLayout();
			((ISupportInitialize)this.DataGridViewPassport1).BeginInit();
			base.SuspendLayout();
			this.tlpClutch.ColumnCount = 1;
			this.tlpClutch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tlpClutch.Controls.Add(this.DataGridViewPassport1, 0, 3);
			this.tlpClutch.Controls.Add(this.tlpPassportInfo, 0, 2);
			this.tlpClutch.Controls.Add(this.lblPasspInfo, 0, 1);
			this.tlpClutch.Controls.Add(this.tlpName, 0, 0);
			this.tlpClutch.Dock = DockStyle.Fill;
			this.tlpClutch.Location = new Point(0, 0);
			this.tlpClutch.Margin = new Padding(10, 3, 3, 3);
			this.tlpClutch.Name = "tlpClutch";
			this.tlpClutch.RowCount = 4;
			this.tlpClutch.RowStyles.Add(new RowStyle());
			this.tlpClutch.RowStyles.Add(new RowStyle());
			this.tlpClutch.RowStyles.Add(new RowStyle(SizeType.Absolute, 35f));
			this.tlpClutch.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tlpClutch.Size = new Size(370, 423);
			this.tlpClutch.TabIndex = 0;
			this.tlpPassportInfo.ColumnCount = 5;
			this.tlpPassportInfo.ColumnStyles.Add(new ColumnStyle());
			this.tlpPassportInfo.ColumnStyles.Add(new ColumnStyle());
			this.tlpPassportInfo.ColumnStyles.Add(new ColumnStyle());
			this.tlpPassportInfo.ColumnStyles.Add(new ColumnStyle());
			this.tlpPassportInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tlpPassportInfo.Controls.Add(this.dtpDatePassport, 3, 0);
			this.tlpPassportInfo.Controls.Add(this.lblDate, 2, 0);
			this.tlpPassportInfo.Controls.Add(this.nUpDwnPassportNum, 1, 0);
			this.tlpPassportInfo.Controls.Add(this.lblPassportNumber, 0, 0);
			this.tlpPassportInfo.Dock = DockStyle.Fill;
			this.tlpPassportInfo.Location = new Point(3, 57);
			this.tlpPassportInfo.Name = "tlpPassportInfo";
			this.tlpPassportInfo.RowCount = 1;
			this.tlpPassportInfo.RowStyles.Add(new RowStyle());
			this.tlpPassportInfo.Size = new Size(364, 29);
			this.tlpPassportInfo.TabIndex = 0;
			this.dtpDatePassport.DataBindings.Add(new Binding("Value", this.class107_0, "tP_Passport.Date", true));
			this.dtpDatePassport.Dock = DockStyle.Fill;
			this.dtpDatePassport.Location = new Point(184, 6);
			this.dtpDatePassport.Margin = new Padding(3, 6, 3, 3);
			this.dtpDatePassport.Name = "dtpDatePassport";
			this.dtpDatePassport.Size = new Size(135, 20);
			this.dtpDatePassport.TabIndex = 12;
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.lblDate.AutoSize = true;
			this.lblDate.Dock = DockStyle.Fill;
			this.lblDate.Location = new Point(145, 6);
			this.lblDate.Margin = new Padding(5, 6, 3, 0);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new Size(33, 23);
			this.lblDate.TabIndex = 11;
			this.lblDate.Text = "Дата";
			this.lblDate.TextAlign = ContentAlignment.MiddleLeft;
			this.nUpDwnPassportNum.DataBindings.Add(new Binding("Value", this.class107_0, "tP_Passport.Number", true));
			this.nUpDwnPassportNum.Dock = DockStyle.Fill;
			this.nUpDwnPassportNum.Location = new Point(57, 6);
			this.nUpDwnPassportNum.Margin = new Padding(3, 6, 3, 3);
			NumericUpDown numericUpDown = this.nUpDwnPassportNum;
			int[] array = new int[4];
			array[0] = 100000000;
			numericUpDown.Maximum = new decimal(array);
			this.nUpDwnPassportNum.Name = "nUpDwnPassportNum";
			this.nUpDwnPassportNum.Size = new Size(80, 20);
			this.nUpDwnPassportNum.TabIndex = 0;
			this.lblPassportNumber.AutoSize = true;
			this.lblPassportNumber.Dock = DockStyle.Fill;
			this.lblPassportNumber.Location = new Point(10, 6);
			this.lblPassportNumber.Margin = new Padding(10, 6, 3, 0);
			this.lblPassportNumber.Name = "lblPassportNumber";
			this.lblPassportNumber.Size = new Size(41, 23);
			this.lblPassportNumber.TabIndex = 0;
			this.lblPassportNumber.Text = "Номер";
			this.lblPassportNumber.TextAlign = ContentAlignment.MiddleLeft;
			this.lblPasspInfo.AutoSize = true;
			this.lblPasspInfo.Dock = DockStyle.Fill;
			this.lblPasspInfo.Location = new Point(13, 41);
			this.lblPasspInfo.Margin = new Padding(13, 6, 3, 0);
			this.lblPasspInfo.Name = "lblPasspInfo";
			this.lblPasspInfo.Size = new Size(354, 13);
			this.lblPasspInfo.TabIndex = 10;
			this.lblPasspInfo.Text = "Паспортные данные:";
			this.tlpName.ColumnCount = 3;
			this.tlpName.ColumnStyles.Add(new ColumnStyle());
			this.tlpName.ColumnStyles.Add(new ColumnStyle());
			this.tlpName.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tlpName.Controls.Add(this.cbNameClutch, 1, 0);
			this.tlpName.Controls.Add(this.lblName, 0, 0);
			this.tlpName.Dock = DockStyle.Fill;
			this.tlpName.Location = new Point(3, 3);
			this.tlpName.Name = "tlpName";
			this.tlpName.RowCount = 1;
			this.tlpName.RowStyles.Add(new RowStyle(SizeType.Absolute, 35f));
			this.tlpName.Size = new Size(364, 29);
			this.tlpName.TabIndex = 0;
			this.cbNameClutch.DataBindings.Add(new Binding("Text", this.class107_0, "tSchm_ObjList.Name", true));
			this.cbNameClutch.Dock = DockStyle.Bottom;
			this.cbNameClutch.Location = new Point(99, 12);
			this.cbNameClutch.Margin = new Padding(3, 8, 3, 3);
			this.cbNameClutch.Name = "cbNameClutch";
			this.cbNameClutch.Size = new Size(120, 20);
			this.cbNameClutch.TabIndex = 3;
			this.lblName.AutoSize = true;
			this.lblName.Location = new Point(10, 16);
			this.lblName.Margin = new Padding(10, 16, 3, 5);
			this.lblName.Name = "lblName";
			this.lblName.Size = new Size(83, 13);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Наименование";
			this.lblName.TextAlign = ContentAlignment.BottomLeft;
			this.DataGridViewPassport1.AllowUserToAddRows = false;
			this.DataGridViewPassport1.AllowUserToDeleteRows = false;
			this.DataGridViewPassport1.AllowUserToResizeRows = false;
			this.DataGridViewPassport1.BackgroundColor = Color.White;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.DataGridViewPassport1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.DataGridViewPassport1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.White;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = Color.White;
			dataGridViewCellStyle2.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.DataGridViewPassport1.DefaultCellStyle = dataGridViewCellStyle2;
			this.DataGridViewPassport1.Dock = DockStyle.Fill;
			this.DataGridViewPassport1.DragDropComplite = false;
			this.DataGridViewPassport1.EditMode = DataGridViewEditMode.EditOnEnter;
			this.DataGridViewPassport1.Location = new Point(3, 92);
			this.DataGridViewPassport1.MultiSelect = false;
			this.DataGridViewPassport1.Name = "DataGridViewPassport1";
			this.DataGridViewPassport1.RowHeadersVisible = false;
			this.DataGridViewPassport1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.DataGridViewPassport1.Size = new Size(364, 328);
			this.DataGridViewPassport1.TabIndex = 13;
			base.Controls.Add(this.tlpClutch);
			base.Size = new Size(370, 423);
			this.tlpClutch.ResumeLayout(false);
			this.tlpClutch.PerformLayout();
			this.tlpPassportInfo.ResumeLayout(false);
			this.tlpPassportInfo.PerformLayout();
			((ISupportInitialize)this.class107_0).EndInit();
			((ISupportInitialize)this.nUpDwnPassportNum).EndInit();
			this.tlpName.ResumeLayout(false);
			this.tlpName.PerformLayout();
			((ISupportInitialize)this.DataGridViewPassport1).EndInit();
			base.ResumeLayout(false);
		}

		private SQLSettings sqlsettings_0;

		private int int_0;

		private int int_1;

		private TypeClutch typeClutch_0;

		private StateFormCreate stateFormCreate_0;

		private EndClutch endClutch_0;

		private int int_2;

		private bool bool_0;

		private bool bool_1;

		private SqlDataCommand sqlDataCommand_0;

		private bool bool_2;

		private IContainer icontainer_0;

		private TableLayoutPanel tlpClutch;

		private Label lblName;

		private TextBox cbNameClutch;

		private Label lblPasspInfo;

		private Label lblDate;

		private DateTimePicker dtpDatePassport;

		private Class107 class107_0;

		internal DataGridViewPassport DataGridViewPassport1;

		private TableLayoutPanel tlpName;

		private TableLayoutPanel tlpPassportInfo;

		private Label lblPassportNumber;

		private NumericUpDown nUpDwnPassportNum;
	}
}
