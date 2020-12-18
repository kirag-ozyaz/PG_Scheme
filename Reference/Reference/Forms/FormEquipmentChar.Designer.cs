namespace Reference.Forms
{
	public partial class FormEquipmentChar : FormLbr.FormBase
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.icontainer_0 = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tbcDeviceChar = new System.Windows.Forms.TabControl();
			this.tbpCommonChar = new System.Windows.Forms.TabPage();
			this.dgvEquipmentChar = new System.Windows.Forms.DataGridView();
			this.idDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idEquipmentDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idTypeEquipmentDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idEquipmentCharDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ValueDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmsEquipChar = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
			this.tscEqupCharAdd = new System.Windows.Forms.ToolStripComboBox();
			this.tbpComment = new System.Windows.Forms.TabPage();
			this.tbComment = new System.Windows.Forms.TextBox();
			this.tbpManufacturer = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOk = new System.Windows.Forms.Button();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbTypeEquipment = new System.Windows.Forms.ComboBox();
			this.cbEquipment = new System.Windows.Forms.ComboBox();
			this.miniToolStrip = new System.Windows.Forms.ToolStrip();
			this.class1_0 = new Class1();
			this.tableLayoutPanel1.SuspendLayout();
			this.tbcDeviceChar.SuspendLayout();
			this.tbpCommonChar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvEquipmentChar).BeginInit();
			this.cmsEquipChar.SuspendLayout();
			this.tbpComment.SuspendLayout();
			this.tbpManufacturer.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.class1_0).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.Controls.Add(this.tbcDeviceChar, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32f));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36f));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 374);
			this.tableLayoutPanel1.TabIndex = 0;
			this.tbcDeviceChar.Controls.Add(this.tbpCommonChar);
			this.tbcDeviceChar.Controls.Add(this.tbpComment);
			this.tbcDeviceChar.Controls.Add(this.tbpManufacturer);
			this.tbcDeviceChar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbcDeviceChar.Location = new System.Drawing.Point(3, 35);
			this.tbcDeviceChar.Name = "tbcDeviceChar";
			this.tbcDeviceChar.SelectedIndex = 0;
			this.tbcDeviceChar.Size = new System.Drawing.Size(592, 300);
			this.tbcDeviceChar.TabIndex = 0;
			this.tbcDeviceChar.TabIndexChanged += new System.EventHandler(this.tbcDeviceChar_TabIndexChanged);
			this.tbpCommonChar.Controls.Add(this.dgvEquipmentChar);
			this.tbpCommonChar.Location = new System.Drawing.Point(4, 22);
			this.tbpCommonChar.Name = "tbpCommonChar";
			this.tbpCommonChar.Padding = new System.Windows.Forms.Padding(3);
			this.tbpCommonChar.Size = new System.Drawing.Size(584, 274);
			this.tbpCommonChar.TabIndex = 0;
			this.tbpCommonChar.Text = "Общие";
			this.tbpCommonChar.UseVisualStyleBackColor = true;
			this.dgvEquipmentChar.AllowUserToAddRows = false;
			this.dgvEquipmentChar.BackgroundColor = System.Drawing.Color.White;
			this.dgvEquipmentChar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEquipmentChar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.idDGV,
				this.idEquipmentDGV,
				this.idTypeEquipmentDGV,
				this.idEquipmentCharDGV,
				this.dataGridViewTextBoxColumn_0,
				this.ValueDGV
			});
			this.dgvEquipmentChar.ContextMenuStrip = this.cmsEquipChar;
			dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvEquipmentChar.DefaultCellStyle = dataGridViewCellStyle;
			this.dgvEquipmentChar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvEquipmentChar.Location = new System.Drawing.Point(3, 3);
			this.dgvEquipmentChar.MultiSelect = false;
			this.dgvEquipmentChar.Name = "dgvEquipmentChar";
			this.dgvEquipmentChar.RowHeadersVisible = false;
			this.dgvEquipmentChar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEquipmentChar.Size = new System.Drawing.Size(578, 268);
			this.dgvEquipmentChar.TabIndex = 2;
			this.idDGV.DataPropertyName = "id";
			this.idDGV.HeaderText = "idDGV";
			this.idDGV.Name = "idDGV";
			this.idDGV.Visible = false;
			this.idEquipmentDGV.DataPropertyName = "idEquipment";
			this.idEquipmentDGV.HeaderText = "idEquipmentDGV";
			this.idEquipmentDGV.Name = "idEquipmentDGV";
			this.idEquipmentDGV.Visible = false;
			this.idTypeEquipmentDGV.DataPropertyName = "idTypeEquipment";
			this.idTypeEquipmentDGV.HeaderText = "idTypeEquipmentDGV";
			this.idTypeEquipmentDGV.Name = "idTypeEquipmentDGV";
			this.idTypeEquipmentDGV.Visible = false;
			this.idEquipmentCharDGV.DataPropertyName = "idNameChar";
			this.idEquipmentCharDGV.HeaderText = "idEquipmentCharDGV";
			this.idEquipmentCharDGV.Name = "idEquipmentCharDGV";
			this.idEquipmentCharDGV.Visible = false;
			this.dataGridViewTextBoxColumn_0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_0.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_0.Name = "NameCharDGV";
			this.ValueDGV.DataPropertyName = "Value";
			this.ValueDGV.HeaderText = "Номинал";
			this.ValueDGV.Name = "ValueDGV";
			this.cmsEquipChar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.tscEqupCharAdd
			});
			this.cmsEquipChar.Name = "cmsEquipChar";
			this.cmsEquipChar.Size = new System.Drawing.Size(215, 53);
			this.cmsEquipChar.Opened += new System.EventHandler(this.cmsEquipChar_Opened);
			this.toolStripMenuItem_0.Name = "добавитьХарактеристикуToolStripMenuItem";
			this.toolStripMenuItem_0.Size = new System.Drawing.Size(214, 22);
			this.toolStripMenuItem_0.Text = "Добавить характеристику";
			this.tscEqupCharAdd.Name = "tscEqupCharAdd";
			this.tscEqupCharAdd.Size = new System.Drawing.Size(121, 23);
			this.tscEqupCharAdd.SelectedIndexChanged += new System.EventHandler(this.tscEqupCharAdd_SelectedIndexChanged);
			this.tbpComment.Controls.Add(this.tbComment);
			this.tbpComment.Location = new System.Drawing.Point(4, 22);
			this.tbpComment.Name = "tbpComment";
			this.tbpComment.Padding = new System.Windows.Forms.Padding(3);
			this.tbpComment.Size = new System.Drawing.Size(584, 274);
			this.tbpComment.TabIndex = 2;
			this.tbpComment.Text = "Комментарий";
			this.tbpComment.UseVisualStyleBackColor = true;
			this.tbComment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbComment.Location = new System.Drawing.Point(3, 3);
			this.tbComment.Multiline = true;
			this.tbComment.Name = "tbComment";
			this.tbComment.Size = new System.Drawing.Size(578, 268);
			this.tbComment.TabIndex = 0;
			this.tbpManufacturer.Controls.Add(this.tableLayoutPanel3);
			this.tbpManufacturer.Location = new System.Drawing.Point(4, 22);
			this.tbpManufacturer.Name = "tbpManufacturer";
			this.tbpManufacturer.Padding = new System.Windows.Forms.Padding(3);
			this.tbpManufacturer.Size = new System.Drawing.Size(584, 274);
			this.tbpManufacturer.TabIndex = 3;
			this.tbpManufacturer.Text = "Производитель";
			this.tbpManufacturer.UseVisualStyleBackColor = true;
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.toolStrip1, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24f));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(578, 268);
			this.tableLayoutPanel3.TabIndex = 0;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.GridColor = System.Drawing.Color.White;
			this.dataGridView1.Location = new System.Drawing.Point(3, 27);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(572, 238);
			this.dataGridView1.TabIndex = 0;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripButton1,
				this.toolStripButton2,
				this.toolStripButton3
			});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(578, 24);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = Reference.Properties.Resources.smethod_0();
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 21);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = Reference.Properties.Resources.smethod_7();
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 21);
			this.toolStripButton2.Text = "toolStripButton2";
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = Reference.Properties.Resources.smethod_1();
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 21);
			this.toolStripButton3.Text = "toolStripButton3";
			this.tableLayoutPanel2.ColumnCount = 4;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100f));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8f));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84f));
			this.tableLayoutPanel2.Controls.Add(this.btnCancel, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnOk, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 341);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(592, 30);
			this.tableLayoutPanel2.TabIndex = 1;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(511, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnOk.Location = new System.Drawing.Point(403, 3);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(94, 23);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "Применить";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			this.tableLayoutPanel4.ColumnCount = 4;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35f));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60f));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89f));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40f));
			this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.label2, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.cbTypeEquipment, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.cbEquipment, 3, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(592, 26);
			this.tableLayoutPanel4.TabIndex = 2;
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Тип";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(318, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "Наименование";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cbTypeEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbTypeEquipment.FormattingEnabled = true;
			this.cbTypeEquipment.Location = new System.Drawing.Point(38, 3);
			this.cbTypeEquipment.Name = "cbTypeEquipment";
			this.cbTypeEquipment.Size = new System.Drawing.Size(274, 21);
			this.cbTypeEquipment.TabIndex = 6;
			this.cbEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cbEquipment.FormattingEnabled = true;
			this.cbEquipment.Location = new System.Drawing.Point(407, 3);
			this.cbEquipment.Name = "cbEquipment";
			this.cbEquipment.Size = new System.Drawing.Size(182, 21);
			this.cbEquipment.TabIndex = 7;
			this.miniToolStrip.AutoSize = false;
			this.miniToolStrip.CanOverflow = false;
			this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.miniToolStrip.Location = new System.Drawing.Point(55, 3);
			this.miniToolStrip.Name = "miniToolStrip";
			this.miniToolStrip.Size = new System.Drawing.Size(684, 25);
			this.miniToolStrip.TabIndex = 2;
			this.class1_0.DataSetName = "DataSetEquipment";
			this.class1_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(598, 374);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Name = "FormEquipmentChar";
			this.Text = "FormEquipment";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tbcDeviceChar.ResumeLayout(false);
			this.tbpCommonChar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvEquipmentChar).EndInit();
			this.cmsEquipChar.ResumeLayout(false);
			this.tbpComment.ResumeLayout(false);
			this.tbpComment.PerformLayout();
			this.tbpManufacturer.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.class1_0).EndInit();
			base.ResumeLayout(false);
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		private System.Windows.Forms.Button btnCancel;

		private System.Windows.Forms.Button btnOk;

		private System.Windows.Forms.TabControl tbcDeviceChar;

		private System.Windows.Forms.TabPage tbpCommonChar;

		private System.Windows.Forms.TabPage tbpComment;

		private System.Windows.Forms.ToolStrip miniToolStrip;

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

		private System.Windows.Forms.Label label1;

		private System.Windows.Forms.Label label2;

		private System.Windows.Forms.DataGridView dgvEquipmentChar;

		private Class1 class1_0;

		private System.Windows.Forms.ContextMenuStrip cmsEquipChar;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_0;

		private System.Windows.Forms.ToolStripComboBox tscEqupCharAdd;

		private System.Windows.Forms.TextBox tbComment;

		private System.Windows.Forms.ComboBox cbTypeEquipment;

		private System.Windows.Forms.ComboBox cbEquipment;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDGV;

		private System.Windows.Forms.DataGridViewTextBoxColumn idEquipmentDGV;

		private System.Windows.Forms.DataGridViewTextBoxColumn idTypeEquipmentDGV;

		private System.Windows.Forms.DataGridViewTextBoxColumn idEquipmentCharDGV;

		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private System.Windows.Forms.DataGridViewTextBoxColumn ValueDGV;

		private System.Windows.Forms.TabPage tbpManufacturer;

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

		private System.Windows.Forms.DataGridView dataGridView1;

		private System.Windows.Forms.ToolStrip toolStrip1;

		private System.Windows.Forms.ToolStripButton toolStripButton1;

		private System.Windows.Forms.ToolStripButton toolStripButton2;

		private System.Windows.Forms.ToolStripButton toolStripButton3;
	}
}
