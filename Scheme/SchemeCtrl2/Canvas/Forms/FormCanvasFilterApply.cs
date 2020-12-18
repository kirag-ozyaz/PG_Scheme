using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;

namespace SchemeCtrl2.Canvas.Forms
{
	public partial class FormCanvasFilterApply : FormBase
	{
		public List<int> ListIdFilter
		{
			get
			{
				return this.list_0;
			}
		}

		public List<string> ListFilterName
		{
			get
			{
				return this.list_1;
			}
		}

		public List<int> ListIdObjects
		{
			get
			{
				return this.list_2;
			}
		}

		public bool IsOtherWindow
		{
			get
			{
				return this.bool_0;
			}
		}

		public FormCanvasFilterApply()
		{
			
			this.list_0 = new List<int>();
			this.list_1 = new List<string>();
			this.list_2 = new List<int>();
			
			this.method_0();
		}

		public FormCanvasFilterApply(CanvasSettings sett)
		{
			
			this.list_0 = new List<int>();
			this.list_1 = new List<string>();
			this.list_2 = new List<int>();
			
			this.method_0();
			this.canvasSettings_0 = sett;
			this.checkBox_5.Checked = this.canvasSettings_0.VisibleAutomaticEntryProvisionTool;
			this.checkBox_4.Checked = this.canvasSettings_0.VisibleSpecialLockingTool;
			this.checkBox_3.Checked = this.canvasSettings_0.VisibleTelemechanicsTool;
			this.checkBox_2.Checked = this.canvasSettings_0.VisibleTelemechanicsProtectionTool;
			this.checkBox_1.Checked = this.canvasSettings_0.VisibleResponsibleAbonentTool;
		}

		private void FormCanvasFilterApply_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class22_0, this.class22_0.tR_Classifier, true, " where [ParentKey] = ';SCM;FilterName;' and [IsGroup] = 0 and [deleted] = 0 order by name");
		}

		private void FormCanvasFilterApply_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				this.bool_0 = this.checkBox_0.Checked;
				foreach (object obj in ((IEnumerable)this.dataGridView_0.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					if (Convert.ToBoolean(dataGridViewRow.Cells["ColumnCheck"].Value))
					{
						this.list_0.Add(Convert.ToInt32(dataGridViewRow.Cells["idDgvTxtColumn"].Value));
						this.list_1.Add(dataGridViewRow.Cells["nameDataGridViewTextBoxColumn"].Value.ToString());
					}
				}
				string text = "";
				foreach (int num in this.list_0)
				{
					text = text + num.ToString() + ",";
				}
				if (text.Length > 0)
				{
					text = text.Remove(text.Length - 1);
					base.SelectSqlData(this.class22_0, this.class22_0.tSchm_ObjFilter, true, "where [idFilter] in (" + text + ")");
					foreach (DataRow dataRow in this.class22_0.tSchm_ObjFilter)
					{
						this.list_2.Add(Convert.ToInt32(dataRow["idObj"]));
					}
				}
				this.canvasSettings_0.VisibleAutomaticEntryProvisionTool = this.checkBox_5.Checked;
				this.canvasSettings_0.VisibleSpecialLockingTool = this.checkBox_4.Checked;
				this.canvasSettings_0.VisibleTelemechanicsTool = this.checkBox_3.Checked;
				this.canvasSettings_0.VisibleTelemechanicsProtectionTool = this.checkBox_2.Checked;
				this.canvasSettings_0.VisibleResponsibleAbonentTool = this.checkBox_1.Checked;
			}
		}

		private void method_0()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			this.class22_0 = new DataSetScheme();
			this.panel_0 = new Panel();
			this.checkBox_0 = new CheckBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.tabControl_0 = new TabControl();
			this.tabPage_0 = new TabPage();
			this.tabPage_1 = new TabPage();
			this.groupBox_0 = new GroupBox();
			this.checkBox_1 = new CheckBox();
			this.checkBox_2 = new CheckBox();
			this.checkBox_3 = new CheckBox();
			this.checkBox_4 = new CheckBox();
			this.checkBox_5 = new CheckBox();
			((ISupportInitialize)this.class22_0).BeginInit();
			this.panel_0.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			this.tabPage_1.SuspendLayout();
			this.groupBox_0.SuspendLayout();
			base.SuspendLayout();
			this.class22_0.DataSetName = "DataSetScheme";
			this.class22_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.panel_0.Controls.Add(this.checkBox_0);
			this.panel_0.Controls.Add(this.button_0);
			this.panel_0.Controls.Add(this.button_1);
			this.panel_0.Dock = DockStyle.Bottom;
			this.panel_0.Location = new Point(0, 327);
			this.panel_0.Name = "panel1";
			this.panel_0.Size = new Size(374, 62);
			this.panel_0.TabIndex = 0;
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Location = new Point(12, 6);
			this.checkBox_0.Name = "checkBoxOtherWindow";
			this.checkBox_0.Size = new Size(210, 17);
			this.checkBox_0.TabIndex = 2;
			this.checkBox_0.Text = "Расположить в отделньной вкладке";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_0.Visible = false;
			this.button_0.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Location = new Point(287, 29);
			this.button_0.Name = "buttonCancel";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 1;
			this.button_0.Text = "Отмена";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_1.DialogResult = DialogResult.OK;
			this.button_1.Location = new Point(12, 29);
			this.button_1.Name = "buttonOK";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 0;
			this.button_1.Text = "Применить";
			this.button_1.UseVisualStyleBackColor = true;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.AllowUserToResizeColumns = false;
			this.dataGridView_0.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = Color.FromArgb(224, 224, 224);
			this.dataGridView_0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_0.AutoGenerateColumns = false;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_0,
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1
			});
			this.dataGridView_0.DataMember = "tR_Classifier";
			this.dataGridView_0.DataSource = this.class22_0;
			this.dataGridView_0.Dock = DockStyle.Fill;
			this.dataGridView_0.Location = new Point(3, 3);
			this.dataGridView_0.Name = "dgvFilterName";
			this.dataGridView_0.RowHeadersVisible = false;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(360, 295);
			this.dataGridView_0.TabIndex = 1;
			this.dataGridViewCheckBoxColumn_0.HeaderText = "Выбор";
			this.dataGridViewCheckBoxColumn_0.Name = "ColumnCheck";
			this.dataGridViewCheckBoxColumn_0.Width = 45;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "Id";
			this.dataGridViewTextBoxColumn_0.Name = "idDgvTxtColumn";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_1.HeaderText = "Имя фильтра";
			this.dataGridViewTextBoxColumn_1.Name = "nameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Dock = DockStyle.Fill;
			this.tabControl_0.Location = new Point(0, 0);
			this.tabControl_0.Name = "tabControl1";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(374, 327);
			this.tabControl_0.TabIndex = 2;
			this.tabPage_0.Controls.Add(this.dataGridView_0);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tabPage1";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(366, 301);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Настраиваемый";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.tabPage_1.Controls.Add(this.groupBox_0);
			this.tabPage_1.Location = new Point(4, 22);
			this.tabPage_1.Name = "tabPage2";
			this.tabPage_1.Padding = new Padding(3);
			this.tabPage_1.Size = new Size(366, 301);
			this.tabPage_1.TabIndex = 1;
			this.tabPage_1.Text = "Надписи";
			this.tabPage_1.UseVisualStyleBackColor = true;
			this.groupBox_0.Controls.Add(this.checkBox_1);
			this.groupBox_0.Controls.Add(this.checkBox_2);
			this.groupBox_0.Controls.Add(this.checkBox_3);
			this.groupBox_0.Controls.Add(this.checkBox_4);
			this.groupBox_0.Controls.Add(this.checkBox_5);
			this.groupBox_0.Location = new Point(0, 3);
			this.groupBox_0.Name = "groupBoxRect";
			this.groupBox_0.Size = new Size(199, 143);
			this.groupBox_0.TabIndex = 0;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Подстанции";
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.Location = new Point(8, 111);
			this.checkBox_1.Name = "checkBoxRespAbn";
			this.checkBox_1.Size = new Size(157, 17);
			this.checkBox_1.TabIndex = 4;
			this.checkBox_1.Text = "Ответственный абоненты";
			this.checkBox_1.UseVisualStyleBackColor = true;
			this.checkBox_2.AutoSize = true;
			this.checkBox_2.Location = new Point(8, 88);
			this.checkBox_2.Name = "checkBoxTMProptect";
			this.checkBox_2.Size = new Size(138, 17);
			this.checkBox_2.TabIndex = 3;
			this.checkBox_2.Text = "Телемеханика-охрана";
			this.checkBox_2.UseVisualStyleBackColor = true;
			this.checkBox_3.AutoSize = true;
			this.checkBox_3.Location = new Point(8, 65);
			this.checkBox_3.Name = "checkBoxTM";
			this.checkBox_3.Size = new Size(100, 17);
			this.checkBox_3.TabIndex = 2;
			this.checkBox_3.Text = "Телемеханика";
			this.checkBox_3.UseVisualStyleBackColor = true;
			this.checkBox_4.AutoSize = true;
			this.checkBox_4.Location = new Point(8, 42);
			this.checkBox_4.Name = "checkBoxSpecLock";
			this.checkBox_4.Size = new Size(89, 17);
			this.checkBox_4.TabIndex = 1;
			this.checkBox_4.Text = "Спец. замки";
			this.checkBox_4.UseVisualStyleBackColor = true;
			this.checkBox_5.AutoSize = true;
			this.checkBox_5.Location = new Point(8, 19);
			this.checkBox_5.Name = "checkBoxAVR";
			this.checkBox_5.Size = new Size(47, 17);
			this.checkBox_5.TabIndex = 0;
			this.checkBox_5.Text = "АВР";
			this.checkBox_5.UseVisualStyleBackColor = true;
			base.AcceptButton = this.button_1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_0;
			base.ClientSize = new Size(374, 389);
			base.Controls.Add(this.tabControl_0);
			base.Controls.Add(this.panel_0);
			base.Name = "FormCanvasFilterApply";
			this.Text = "Применть фильтр(ы)";
			base.FormClosing += this.FormCanvasFilterApply_FormClosing;
			base.Load += this.FormCanvasFilterApply_Load;
			((ISupportInitialize)this.class22_0).EndInit();
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.tabPage_1.ResumeLayout(false);
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			base.ResumeLayout(false);
		}

		private List<int> list_0;

		private List<string> list_1;

		private List<int> list_2;

		private bool bool_0;

		private CanvasSettings canvasSettings_0;

		private DataSetScheme class22_0;

		private Panel panel_0;

		private Button button_0;

		private Button button_1;

		private DataGridView dataGridView_0;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private CheckBox checkBox_0;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private TabPage tabPage_1;

		private GroupBox groupBox_0;

		private CheckBox checkBox_1;

		private CheckBox checkBox_2;

		private CheckBox checkBox_3;

		private CheckBox checkBox_4;

		private CheckBox checkBox_5;
	}
}
