using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using FormLbr;

namespace Scheme.Forms.LinkCellPoint
{
	public partial class FormLinkOnOffAbn : FormBase
	{
		public FormLinkOnOffAbn()
		{
			
			
			this.method_0();
		}

		public FormLinkOnOffAbn(List<int> idlink)
		{
			
			
			this.method_0();
			this.list_0 = idlink;
		}

		private void FormLinkOnOffAbn_Load(object sender, EventArgs e)
		{
			this.dateTimePicker_0.Value = DateTime.Now.Date;
			if (this.list_0 == null)
			{
				return;
			}
			string text = "";
			foreach (int num in this.list_0)
			{
				text = text + num.ToString() + ",";
			}
			if (text != "")
			{
				text = text.Remove(text.Length - 1);
				base.SelectSqlData(this.class19_0, this.class19_0.vL_CellPointAbn, true, " where id in (" + text + ")");
			}
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы уверены, что хотите подключить текущих абонентов " + this.dateTimePicker_0.Value.ToShortDateString(), "Подключение", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				SqlDataConnect sqlDataConnect = new SqlDataConnect();
				try
				{
					sqlDataConnect.OpenConnection(this.SqlSettings);
					foreach (object obj in this.class19_0.vL_CellPointAbn.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						try
						{
							new SqlCommand(string.Concat(new string[]
							{
								"insert into tL_cellPointReg (idLink, OnPoint, DateChange)  values (",
								dataRow["id"].ToString(),
								", 1 ,'",
								this.dateTimePicker_0.Value.ToString("yyyyMMdd"),
								"')"
							}), sqlDataConnect.Connection).ExecuteNonQuery();
						}
						catch (Exception ex)
						{
							if (MessageBox.Show(ex.Message + "\n Продолжить подключение?", ex.Source, MessageBoxButtons.YesNo) == DialogResult.No)
							{
								break;
							}
						}
					}
					base.DialogResult = DialogResult.OK;
				}
				catch (Exception ex2)
				{
					MessageBox.Show(ex2.Message, ex2.Source);
				}
				finally
				{
					sqlDataConnect.CloseConnection();
				}
			}
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы уверены, что хотите отключить текущих абонентов " + this.dateTimePicker_0.Value.ToShortDateString(), "Отключение", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				SqlDataConnect sqlDataConnect = new SqlDataConnect();
				try
				{
					sqlDataConnect.OpenConnection(this.SqlSettings);
					foreach (object obj in this.class19_0.vL_CellPointAbn.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						try
						{
							new SqlCommand(string.Concat(new string[]
							{
								"insert into tL_cellPointReg (idLink, OnPoint, DateChange)  values (",
								dataRow["id"].ToString(),
								", 0 ,'",
								this.dateTimePicker_0.Value.ToString("yyyyMMdd"),
								"')"
							}), sqlDataConnect.Connection).ExecuteNonQuery();
						}
						catch (Exception ex)
						{
							if (MessageBox.Show(ex.Message + "\n Продолжить отключение?", ex.Source, MessageBoxButtons.YesNo) == DialogResult.No)
							{
								break;
							}
						}
					}
					base.DialogResult = DialogResult.OK;
				}
				catch (Exception ex2)
				{
					MessageBox.Show(ex2.Message, ex2.Source);
				}
				finally
				{
					sqlDataConnect.CloseConnection();
				}
			}
		}

		private void method_0()
		{
			this.icontainer_0 = new Container();
			this.class19_0 = new Class19();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
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
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
			this.label_0 = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.button_2 = new Button();
			((ISupportInitialize)this.class19_0).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dataGridViewExcelFilter_0).BeginInit();
			base.SuspendLayout();
			this.class19_0.DataSetName = "DataSetScheme";
			this.class19_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.bindingSource_0.DataMember = "vL_CellPointAbn";
			this.bindingSource_0.DataSource = this.class19_0;
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_0,
				this.dataGridViewCheckBoxColumn_1,
				this.dataGridViewCheckBoxColumn_2,
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
				this.dataGridViewTextBoxColumn_11,
				this.dataGridViewTextBoxColumn_12,
				this.dataGridViewTextBoxColumn_13,
				this.dataGridViewTextBoxColumn_14,
				this.dataGridViewTextBoxColumn_15,
				this.dataGridViewTextBoxColumn_16
			});
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_0.Name = "dgvSchmAbn";
			this.dataGridViewExcelFilter_0.ReadOnly = true;
			this.dataGridViewExcelFilter_0.RowHeadersWidth = 21;
			this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_0.Size = new Size(809, 359);
			this.dataGridViewExcelFilter_0.TabIndex = 2;
			this.dataGridViewExcelFilter_0.VirtualMode = true;
			this.dataGridViewCheckBoxColumn_0.DataPropertyName = "OnSchmObj";
			this.dataGridViewCheckBoxColumn_0.HeaderText = "OnSchmObj";
			this.dataGridViewCheckBoxColumn_0.Name = "OnSchmObjDgvColumn";
			this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_0.Visible = false;
			this.dataGridViewCheckBoxColumn_1.DataPropertyName = "OnPoint";
			this.dataGridViewCheckBoxColumn_1.HeaderText = "OnPoint";
			this.dataGridViewCheckBoxColumn_1.Name = "OnPointDgvColumn";
			this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_1.Visible = false;
			this.dataGridViewCheckBoxColumn_2.DataPropertyName = "ActiveAbn";
			this.dataGridViewCheckBoxColumn_2.HeaderText = "ActiveAbn";
			this.dataGridViewCheckBoxColumn_2.Name = "activeAbnDgvColumn";
			this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "SchmObjName";
			this.dataGridViewTextBoxColumn_0.FillWeight = 15f;
			this.dataGridViewTextBoxColumn_0.HeaderText = "Ячейка";
			this.dataGridViewTextBoxColumn_0.Name = "SchmObjNameDgvColumn";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "CodeAbonent";
			this.dataGridViewTextBoxColumn_1.FillWeight = 10f;
			this.dataGridViewTextBoxColumn_1.HeaderText = "Код";
			this.dataGridViewTextBoxColumn_1.Name = "codeAbnDgvColumn";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_2.FillWeight = 25f;
			this.dataGridViewTextBoxColumn_2.HeaderText = "Абонент";
			this.dataGridViewTextBoxColumn_2.Name = "nameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "streetName";
			this.dataGridViewTextBoxColumn_3.FillWeight = 25f;
			this.dataGridViewTextBoxColumn_3.HeaderText = "Улица";
			this.dataGridViewTextBoxColumn_3.Name = "streetNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "house";
			this.dataGridViewTextBoxColumn_4.FillWeight = 8f;
			this.dataGridViewTextBoxColumn_4.HeaderText = "Дом";
			this.dataGridViewTextBoxColumn_4.Name = "houseDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "objName";
			this.dataGridViewTextBoxColumn_5.FillWeight = 25f;
			this.dataGridViewTextBoxColumn_5.HeaderText = "Объект";
			this.dataGridViewTextBoxColumn_5.Name = "objNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "pName";
			this.dataGridViewTextBoxColumn_6.FillWeight = 7f;
			this.dataGridViewTextBoxColumn_6.HeaderText = "Т.У.";
			this.dataGridViewTextBoxColumn_6.Name = "pNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_7.HeaderText = "id";
			this.dataGridViewTextBoxColumn_7.Name = "idDgvColumn";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "idSchmObj";
			this.dataGridViewTextBoxColumn_8.HeaderText = "idSchmObj";
			this.dataGridViewTextBoxColumn_8.Name = "idSchmObjDgvColumn";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "idPoint";
			this.dataGridViewTextBoxColumn_9.HeaderText = "idPoint";
			this.dataGridViewTextBoxColumn_9.Name = "idPointDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.Visible = false;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "idAbnObj";
			this.dataGridViewTextBoxColumn_10.HeaderText = "idAbnObj";
			this.dataGridViewTextBoxColumn_10.Name = "idAbnObjDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.Visible = false;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "DateBegin";
			this.dataGridViewTextBoxColumn_11.HeaderText = "DateBegin";
			this.dataGridViewTextBoxColumn_11.Name = "dateBeginDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.Visible = false;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "DateEnd";
			this.dataGridViewTextBoxColumn_12.HeaderText = "DateEnd";
			this.dataGridViewTextBoxColumn_12.Name = "dateEndDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.Visible = false;
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "idABn";
			this.dataGridViewTextBoxColumn_13.HeaderText = "idABn";
			this.dataGridViewTextBoxColumn_13.Name = "idABnDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.Visible = false;
			this.dataGridViewTextBoxColumn_14.DataPropertyName = "TypeAbn";
			this.dataGridViewTextBoxColumn_14.HeaderText = "TypeAbn";
			this.dataGridViewTextBoxColumn_14.Name = "typeAbnDgvColumn";
			this.dataGridViewTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewTextBoxColumn_14.Visible = false;
			this.dataGridViewTextBoxColumn_15.DataPropertyName = "idMap";
			this.dataGridViewTextBoxColumn_15.HeaderText = "idMap";
			this.dataGridViewTextBoxColumn_15.Name = "idMapDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewTextBoxColumn_15.Visible = false;
			this.dataGridViewTextBoxColumn_16.DataPropertyName = "Street";
			this.dataGridViewTextBoxColumn_16.HeaderText = "Street";
			this.dataGridViewTextBoxColumn_16.Name = "streetDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewTextBoxColumn_16.Visible = false;
			this.label_0.AutoSize = true;
			this.label_0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.label_0.Location = new Point(12, 373);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(37, 13);
			this.label_0.TabIndex = 3;
			this.label_0.Text = "Дата";
			this.dateTimePicker_0.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.dateTimePicker_0.Location = new Point(55, 367);
			this.dateTimePicker_0.Name = "dateTimePicker";
			this.dateTimePicker_0.Size = new Size(159, 20);
			this.dateTimePicker_0.TabIndex = 4;
			this.button_0.ForeColor = Color.Green;
			this.button_0.Location = new Point(548, 367);
			this.button_0.Name = "buttonOn";
			this.button_0.Size = new Size(83, 23);
			this.button_0.TabIndex = 5;
			this.button_0.Text = "Подключить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.ForeColor = Color.Red;
			this.button_1.Location = new Point(637, 368);
			this.button_1.Name = "buttonOff";
			this.button_1.Size = new Size(91, 22);
			this.button_1.TabIndex = 6;
			this.button_1.Text = "Отключить";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.button_2.DialogResult = DialogResult.Cancel;
			this.button_2.Location = new Point(734, 368);
			this.button_2.Name = "buttonCancel";
			this.button_2.Size = new Size(75, 23);
			this.button_2.TabIndex = 7;
			this.button_2.Text = "Отмена";
			this.button_2.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(809, 395);
			base.Controls.Add(this.button_2);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.dateTimePicker_0);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.dataGridViewExcelFilter_0);
			base.Name = "FormLinkOnOffAbn";
			this.Text = "Включение/отключение абонентов";
			base.Load += this.FormLinkOnOffAbn_Load;
			((ISupportInitialize)this.class19_0).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dataGridViewExcelFilter_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private List<int> list_0;

		private Class19 class19_0;

		private BindingSource bindingSource_0;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;

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

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		private Label label_0;

		private DateTimePicker dateTimePicker_0;

		private Button button_0;

		private Button button_1;

		private Button button_2;
	}
}
