using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using DataSql;
using Passport.Classes;
using Passport.DataSets;

namespace Passport.Controls
{
	public class PanelClutch : Panel
	{
		public PanelClutch()
		{
			this.method_4();
		}

		public PanelClutch(SQLSettings settings, int int_3, StateFormCreate State)
		{
			this.method_4();
			this.sqlsettings_0 = settings;
			this.int_0 = ((this.stateFormCreate_0 == 1) ? int_3 : -1);
			this.int_1 = ((this.stateFormCreate_0 == null) ? int_3 : -1);
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

		public void Fill(SQLSettings settings, int int_3, StateFormCreate state)
		{
			this.SqlSettings = settings;
			if (state == null)
			{
				this.int_1 = int_3;
			}
			if (state == 1)
			{
				this.int_0 = int_3;
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
				this.sqlDataCommand_0.SelectSqlData(this.dsPassport_0.tSchm_ObjList, true, "WHERE id = " + this.int_0.ToString(), null, false, 0);
				if (this.dsPassport_0.tSchm_ObjList.Rows.Count == 0)
				{
					MessageBox.Show("Не найдена муфта", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
				else
				{
					this.cbNameClutch.Text = this.dsPassport_0.tSchm_ObjList.Rows[0]["Name"].ToString();
				}
				this.int_2 = PassportData.GetActivePassport(this.SqlSettings, this.int_0);
				if (this.int_2 != -1)
				{
					this.sqlDataCommand_0.SelectSqlData(this.dsPassport_0.tP_Passport, true, string.Format("where id = '{0}'", this.int_2), null, false, 0);
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
					this.DataGridViewPassport1.SaveInsertedData(this.int_0, this.dtpDatePassport.Value, Convert.ToInt32(this.dsPassport_0.tP_Passport[0]["Number"]));
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
				this.DataGridViewPassport1.SaveUpdatedData(this.dtpDatePassport.Value, Convert.ToInt32(this.dsPassport_0.tP_Passport[0]["Number"]));
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
			DataRow dataRow = this.dsPassport_0.tP_Passport.NewRow();
			dataRow["idObjList"] = this.int_0;
			dataRow["Number"] = 0;
			dataRow["date"] = DateTime.Now;
			dataRow["dateIn"] = DateTime.Now;
			dataRow["deleted"] = false;
			dataRow["isActive"] = true;
			dataRow.EndEdit();
			this.dsPassport_0.tP_Passport.Rows.Add(dataRow);
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
			if (this.dsPassport_0.tSchm_ObjList.Rows.Count > 0)
			{
				this.sqlDataCommand_0 = new SqlDataCommand(this.sqlsettings_0);
				this.dsPassport_0.tSchm_ObjList.Rows[0]["Name"] = this.cbNameClutch.Text;
				return this.sqlDataCommand_0.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tSchm_ObjList);
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
			this.dsPassport_0 = new dsPassport();
			this.lblDate = new Label();
			this.nUpDwnPassportNum = new NumericUpDown();
			this.lblPassportNumber = new Label();
			this.lblPasspInfo = new Label();
			this.tlpName = new TableLayoutPanel();
			this.cbNameClutch = new TextBox();
			this.lblName = new Label();
			this.dataGridViewCheckBoxColumn14 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn13 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn12 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn11 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn10 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn9 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn8 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn7 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn6 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn5 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn3 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn2 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn4 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
			this.DataGridViewPassport1 = new DataGridViewPassport();
			this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn15 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn71 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn72 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn73 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn74 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn75 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn66 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn67 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn68 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn69 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn70 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn61 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn62 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn63 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn64 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn65 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn56 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn57 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn58 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn59 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn60 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn51 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn52 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn53 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn54 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn55 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn46 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn47 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn48 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn49 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn50 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn41 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn42 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn43 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn44 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn45 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn36 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn37 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn38 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn39 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn40 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn31 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn32 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn33 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn34 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn35 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn26 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn27 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn28 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn29 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn30 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn21 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn22 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn23 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn24 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn25 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn20 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
			this.tlpClutch.SuspendLayout();
			this.tlpPassportInfo.SuspendLayout();
			((ISupportInitialize)this.dsPassport_0).BeginInit();
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
			this.dtpDatePassport.DataBindings.Add(new Binding("Value", this.dsPassport_0, "tP_Passport.Date", true));
			this.dtpDatePassport.Dock = DockStyle.Fill;
			this.dtpDatePassport.Location = new Point(184, 6);
			this.dtpDatePassport.Margin = new Padding(3, 6, 3, 3);
			this.dtpDatePassport.Name = "dtpDatePassport";
			this.dtpDatePassport.Size = new Size(135, 20);
			this.dtpDatePassport.TabIndex = 12;
			this.dsPassport_0.DataSetName = "dsPassport";
			this.dsPassport_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.lblDate.AutoSize = true;
			this.lblDate.Dock = DockStyle.Fill;
			this.lblDate.Location = new Point(145, 6);
			this.lblDate.Margin = new Padding(5, 6, 3, 0);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new Size(33, 23);
			this.lblDate.TabIndex = 11;
			this.lblDate.Text = "Дата";
			this.lblDate.TextAlign = ContentAlignment.MiddleLeft;
			this.nUpDwnPassportNum.DataBindings.Add(new Binding("Value", this.dsPassport_0, "tP_Passport.Number", true));
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
			this.cbNameClutch.DataBindings.Add(new Binding("Text", this.dsPassport_0, "tSchm_ObjList.Name", true));
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
			this.dataGridViewCheckBoxColumn14.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn14.Name = "dataGridViewCheckBoxColumn14";
			this.dataGridViewCheckBoxColumn14.ReadOnly = true;
			this.dataGridViewCheckBoxColumn14.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn14.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn14.Visible = false;
			this.dataGridViewCheckBoxColumn13.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn13.Name = "dataGridViewCheckBoxColumn13";
			this.dataGridViewCheckBoxColumn13.ReadOnly = true;
			this.dataGridViewCheckBoxColumn13.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn13.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn13.Visible = false;
			this.dataGridViewCheckBoxColumn12.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn12.Name = "dataGridViewCheckBoxColumn12";
			this.dataGridViewCheckBoxColumn12.ReadOnly = true;
			this.dataGridViewCheckBoxColumn12.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn12.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn12.Visible = false;
			this.dataGridViewCheckBoxColumn11.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn11.Name = "dataGridViewCheckBoxColumn11";
			this.dataGridViewCheckBoxColumn11.ReadOnly = true;
			this.dataGridViewCheckBoxColumn11.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn11.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn11.Visible = false;
			this.dataGridViewCheckBoxColumn10.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn10.Name = "dataGridViewCheckBoxColumn10";
			this.dataGridViewCheckBoxColumn10.ReadOnly = true;
			this.dataGridViewCheckBoxColumn10.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn10.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn10.Visible = false;
			this.dataGridViewCheckBoxColumn9.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn9.Name = "dataGridViewCheckBoxColumn9";
			this.dataGridViewCheckBoxColumn9.ReadOnly = true;
			this.dataGridViewCheckBoxColumn9.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn9.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn9.Visible = false;
			this.dataGridViewCheckBoxColumn8.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn8.Name = "dataGridViewCheckBoxColumn8";
			this.dataGridViewCheckBoxColumn8.ReadOnly = true;
			this.dataGridViewCheckBoxColumn8.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn8.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn8.Visible = false;
			this.dataGridViewCheckBoxColumn7.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn7.Name = "dataGridViewCheckBoxColumn7";
			this.dataGridViewCheckBoxColumn7.ReadOnly = true;
			this.dataGridViewCheckBoxColumn7.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn7.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn7.Visible = false;
			this.dataGridViewCheckBoxColumn6.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
			this.dataGridViewCheckBoxColumn6.ReadOnly = true;
			this.dataGridViewCheckBoxColumn6.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn6.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn6.Visible = false;
			this.dataGridViewCheckBoxColumn5.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
			this.dataGridViewCheckBoxColumn5.ReadOnly = true;
			this.dataGridViewCheckBoxColumn5.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn5.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn5.Visible = false;
			this.dataGridViewCheckBoxColumn3.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
			this.dataGridViewCheckBoxColumn3.ReadOnly = true;
			this.dataGridViewCheckBoxColumn3.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn3.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn3.Visible = false;
			this.dataGridViewCheckBoxColumn2.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
			this.dataGridViewCheckBoxColumn2.ReadOnly = true;
			this.dataGridViewCheckBoxColumn2.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn2.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn2.Visible = false;
			this.dataGridViewCheckBoxColumn4.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
			this.dataGridViewCheckBoxColumn4.ReadOnly = true;
			this.dataGridViewCheckBoxColumn4.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn4.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn4.Visible = false;
			this.dataGridViewCheckBoxColumn1.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn1.ReadOnly = true;
			this.dataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn1.Visible = false;
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
			this.dataGridViewTextBoxColumn1.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.dataGridViewTextBoxColumn2.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn2.Visible = false;
			this.dataGridViewTextBoxColumn3.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Visible = false;
			this.dataGridViewCheckBoxColumn15.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn15.Name = "dataGridViewCheckBoxColumn15";
			this.dataGridViewCheckBoxColumn15.ReadOnly = true;
			this.dataGridViewCheckBoxColumn15.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn15.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn15.Visible = false;
			this.dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn4.FillWeight = 150f;
			this.dataGridViewTextBoxColumn4.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn4.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn4.Width = 5;
			this.dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn5.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn5.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn71.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
			this.dataGridViewTextBoxColumn71.ReadOnly = true;
			this.dataGridViewTextBoxColumn71.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn71.Visible = false;
			this.dataGridViewTextBoxColumn72.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn72.Name = "dataGridViewTextBoxColumn72";
			this.dataGridViewTextBoxColumn72.ReadOnly = true;
			this.dataGridViewTextBoxColumn72.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn72.Visible = false;
			this.dataGridViewTextBoxColumn73.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn73.Name = "dataGridViewTextBoxColumn73";
			this.dataGridViewTextBoxColumn73.ReadOnly = true;
			this.dataGridViewTextBoxColumn73.Visible = false;
			this.dataGridViewTextBoxColumn74.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn74.FillWeight = 150f;
			this.dataGridViewTextBoxColumn74.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn74.Name = "dataGridViewTextBoxColumn74";
			this.dataGridViewTextBoxColumn74.ReadOnly = true;
			this.dataGridViewTextBoxColumn74.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn74.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn75.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn75.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn75.Name = "dataGridViewTextBoxColumn75";
			this.dataGridViewTextBoxColumn75.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn75.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn66.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
			this.dataGridViewTextBoxColumn66.ReadOnly = true;
			this.dataGridViewTextBoxColumn66.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn66.Visible = false;
			this.dataGridViewTextBoxColumn67.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
			this.dataGridViewTextBoxColumn67.ReadOnly = true;
			this.dataGridViewTextBoxColumn67.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn67.Visible = false;
			this.dataGridViewTextBoxColumn68.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
			this.dataGridViewTextBoxColumn68.ReadOnly = true;
			this.dataGridViewTextBoxColumn68.Visible = false;
			this.dataGridViewTextBoxColumn69.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn69.FillWeight = 150f;
			this.dataGridViewTextBoxColumn69.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn69.Name = "dataGridViewTextBoxColumn69";
			this.dataGridViewTextBoxColumn69.ReadOnly = true;
			this.dataGridViewTextBoxColumn69.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn69.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn70.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn70.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn70.Name = "dataGridViewTextBoxColumn70";
			this.dataGridViewTextBoxColumn70.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn70.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn61.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
			this.dataGridViewTextBoxColumn61.ReadOnly = true;
			this.dataGridViewTextBoxColumn61.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn61.Visible = false;
			this.dataGridViewTextBoxColumn62.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
			this.dataGridViewTextBoxColumn62.ReadOnly = true;
			this.dataGridViewTextBoxColumn62.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn62.Visible = false;
			this.dataGridViewTextBoxColumn63.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
			this.dataGridViewTextBoxColumn63.ReadOnly = true;
			this.dataGridViewTextBoxColumn63.Visible = false;
			this.dataGridViewTextBoxColumn64.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn64.FillWeight = 150f;
			this.dataGridViewTextBoxColumn64.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
			this.dataGridViewTextBoxColumn64.ReadOnly = true;
			this.dataGridViewTextBoxColumn64.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn64.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn65.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn65.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
			this.dataGridViewTextBoxColumn65.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn65.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn56.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
			this.dataGridViewTextBoxColumn56.ReadOnly = true;
			this.dataGridViewTextBoxColumn56.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn56.Visible = false;
			this.dataGridViewTextBoxColumn57.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
			this.dataGridViewTextBoxColumn57.ReadOnly = true;
			this.dataGridViewTextBoxColumn57.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn57.Visible = false;
			this.dataGridViewTextBoxColumn58.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
			this.dataGridViewTextBoxColumn58.ReadOnly = true;
			this.dataGridViewTextBoxColumn58.Visible = false;
			this.dataGridViewTextBoxColumn59.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn59.FillWeight = 150f;
			this.dataGridViewTextBoxColumn59.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
			this.dataGridViewTextBoxColumn59.ReadOnly = true;
			this.dataGridViewTextBoxColumn59.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn59.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn60.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn60.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
			this.dataGridViewTextBoxColumn60.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn60.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn51.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
			this.dataGridViewTextBoxColumn51.ReadOnly = true;
			this.dataGridViewTextBoxColumn51.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn51.Visible = false;
			this.dataGridViewTextBoxColumn52.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
			this.dataGridViewTextBoxColumn52.ReadOnly = true;
			this.dataGridViewTextBoxColumn52.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn52.Visible = false;
			this.dataGridViewTextBoxColumn53.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
			this.dataGridViewTextBoxColumn53.ReadOnly = true;
			this.dataGridViewTextBoxColumn53.Visible = false;
			this.dataGridViewTextBoxColumn54.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn54.FillWeight = 150f;
			this.dataGridViewTextBoxColumn54.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
			this.dataGridViewTextBoxColumn54.ReadOnly = true;
			this.dataGridViewTextBoxColumn54.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn54.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn55.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn55.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
			this.dataGridViewTextBoxColumn55.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn55.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn46.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
			this.dataGridViewTextBoxColumn46.ReadOnly = true;
			this.dataGridViewTextBoxColumn46.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn46.Visible = false;
			this.dataGridViewTextBoxColumn47.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
			this.dataGridViewTextBoxColumn47.ReadOnly = true;
			this.dataGridViewTextBoxColumn47.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn47.Visible = false;
			this.dataGridViewTextBoxColumn48.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
			this.dataGridViewTextBoxColumn48.ReadOnly = true;
			this.dataGridViewTextBoxColumn48.Visible = false;
			this.dataGridViewTextBoxColumn49.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn49.FillWeight = 150f;
			this.dataGridViewTextBoxColumn49.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
			this.dataGridViewTextBoxColumn49.ReadOnly = true;
			this.dataGridViewTextBoxColumn49.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn49.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn50.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn50.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
			this.dataGridViewTextBoxColumn50.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn50.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn41.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
			this.dataGridViewTextBoxColumn41.ReadOnly = true;
			this.dataGridViewTextBoxColumn41.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn41.Visible = false;
			this.dataGridViewTextBoxColumn42.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
			this.dataGridViewTextBoxColumn42.ReadOnly = true;
			this.dataGridViewTextBoxColumn42.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn42.Visible = false;
			this.dataGridViewTextBoxColumn43.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
			this.dataGridViewTextBoxColumn43.ReadOnly = true;
			this.dataGridViewTextBoxColumn43.Visible = false;
			this.dataGridViewTextBoxColumn44.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn44.FillWeight = 150f;
			this.dataGridViewTextBoxColumn44.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
			this.dataGridViewTextBoxColumn44.ReadOnly = true;
			this.dataGridViewTextBoxColumn44.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn44.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn45.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn45.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
			this.dataGridViewTextBoxColumn45.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn45.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn36.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
			this.dataGridViewTextBoxColumn36.ReadOnly = true;
			this.dataGridViewTextBoxColumn36.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn36.Visible = false;
			this.dataGridViewTextBoxColumn37.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
			this.dataGridViewTextBoxColumn37.ReadOnly = true;
			this.dataGridViewTextBoxColumn37.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn37.Visible = false;
			this.dataGridViewTextBoxColumn38.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
			this.dataGridViewTextBoxColumn38.ReadOnly = true;
			this.dataGridViewTextBoxColumn38.Visible = false;
			this.dataGridViewTextBoxColumn39.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn39.FillWeight = 150f;
			this.dataGridViewTextBoxColumn39.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
			this.dataGridViewTextBoxColumn39.ReadOnly = true;
			this.dataGridViewTextBoxColumn39.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn39.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn40.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn40.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
			this.dataGridViewTextBoxColumn40.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn40.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn31.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
			this.dataGridViewTextBoxColumn31.ReadOnly = true;
			this.dataGridViewTextBoxColumn31.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn31.Visible = false;
			this.dataGridViewTextBoxColumn32.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
			this.dataGridViewTextBoxColumn32.ReadOnly = true;
			this.dataGridViewTextBoxColumn32.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn32.Visible = false;
			this.dataGridViewTextBoxColumn33.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
			this.dataGridViewTextBoxColumn33.ReadOnly = true;
			this.dataGridViewTextBoxColumn33.Visible = false;
			this.dataGridViewTextBoxColumn34.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn34.FillWeight = 150f;
			this.dataGridViewTextBoxColumn34.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
			this.dataGridViewTextBoxColumn34.ReadOnly = true;
			this.dataGridViewTextBoxColumn34.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn34.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn35.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn35.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
			this.dataGridViewTextBoxColumn35.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn35.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn26.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
			this.dataGridViewTextBoxColumn26.ReadOnly = true;
			this.dataGridViewTextBoxColumn26.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn26.Visible = false;
			this.dataGridViewTextBoxColumn27.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
			this.dataGridViewTextBoxColumn27.ReadOnly = true;
			this.dataGridViewTextBoxColumn27.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn27.Visible = false;
			this.dataGridViewTextBoxColumn28.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
			this.dataGridViewTextBoxColumn28.ReadOnly = true;
			this.dataGridViewTextBoxColumn28.Visible = false;
			this.dataGridViewTextBoxColumn29.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn29.FillWeight = 150f;
			this.dataGridViewTextBoxColumn29.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
			this.dataGridViewTextBoxColumn29.ReadOnly = true;
			this.dataGridViewTextBoxColumn29.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn29.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn30.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn30.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
			this.dataGridViewTextBoxColumn30.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn30.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn21.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
			this.dataGridViewTextBoxColumn21.ReadOnly = true;
			this.dataGridViewTextBoxColumn21.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn21.Visible = false;
			this.dataGridViewTextBoxColumn22.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
			this.dataGridViewTextBoxColumn22.ReadOnly = true;
			this.dataGridViewTextBoxColumn22.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn22.Visible = false;
			this.dataGridViewTextBoxColumn23.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
			this.dataGridViewTextBoxColumn23.ReadOnly = true;
			this.dataGridViewTextBoxColumn23.Visible = false;
			this.dataGridViewTextBoxColumn24.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn24.FillWeight = 150f;
			this.dataGridViewTextBoxColumn24.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
			this.dataGridViewTextBoxColumn24.ReadOnly = true;
			this.dataGridViewTextBoxColumn24.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn24.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn25.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn25.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
			this.dataGridViewTextBoxColumn25.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn25.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn16.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
			this.dataGridViewTextBoxColumn16.ReadOnly = true;
			this.dataGridViewTextBoxColumn16.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn16.Visible = false;
			this.dataGridViewTextBoxColumn17.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
			this.dataGridViewTextBoxColumn17.ReadOnly = true;
			this.dataGridViewTextBoxColumn17.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn17.Visible = false;
			this.dataGridViewTextBoxColumn18.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
			this.dataGridViewTextBoxColumn18.ReadOnly = true;
			this.dataGridViewTextBoxColumn18.Visible = false;
			this.dataGridViewTextBoxColumn19.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn19.FillWeight = 150f;
			this.dataGridViewTextBoxColumn19.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
			this.dataGridViewTextBoxColumn19.ReadOnly = true;
			this.dataGridViewTextBoxColumn19.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn19.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn20.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn20.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
			this.dataGridViewTextBoxColumn20.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn20.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn11.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			this.dataGridViewTextBoxColumn11.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn11.Visible = false;
			this.dataGridViewTextBoxColumn12.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.ReadOnly = true;
			this.dataGridViewTextBoxColumn12.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn12.Visible = false;
			this.dataGridViewTextBoxColumn13.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn13.ReadOnly = true;
			this.dataGridViewTextBoxColumn13.Visible = false;
			this.dataGridViewTextBoxColumn14.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn14.FillWeight = 150f;
			this.dataGridViewTextBoxColumn14.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn14.ReadOnly = true;
			this.dataGridViewTextBoxColumn14.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn14.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn15.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn15.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
			this.dataGridViewTextBoxColumn15.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn15.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn6.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn6.Visible = false;
			this.dataGridViewTextBoxColumn7.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn7.Visible = false;
			this.dataGridViewTextBoxColumn8.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			this.dataGridViewTextBoxColumn8.Visible = false;
			this.dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn9.FillWeight = 150f;
			this.dataGridViewTextBoxColumn9.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			this.dataGridViewTextBoxColumn9.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn9.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn10.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn10.SortMode = DataGridViewColumnSortMode.Programmatic;
			base.Controls.Add(this.tlpClutch);
			base.Size = new Size(370, 423);
			this.tlpClutch.ResumeLayout(false);
			this.tlpClutch.PerformLayout();
			this.tlpPassportInfo.ResumeLayout(false);
			this.tlpPassportInfo.PerformLayout();
			((ISupportInitialize)this.dsPassport_0).EndInit();
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

		private dsPassport dsPassport_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;

		internal DataGridViewPassport DataGridViewPassport1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;

		private TableLayoutPanel tlpName;

		private TableLayoutPanel tlpPassportInfo;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;

		private Label lblPassportNumber;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;

		private NumericUpDown nUpDwnPassportNum;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn15;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;
	}
}
