namespace Reference.Forms
{
	public partial class FormEquipment : FormLbr.FormBase
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dgvEquipment = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbEquipmentAdd = new System.Windows.Forms.ToolStripButton();
			this.tsbEquipmentDel = new System.Windows.Forms.ToolStripButton();
			this.tsbEquipmentInfo = new System.Windows.Forms.ToolStripButton();
			this.class1_0 = new Class1();
			this.tsbEquipmentEdit = new System.Windows.Forms.ToolStripButton();
			this.idEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idTypeEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NameEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DescriptionEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CommentEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DeletedEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvEquipment).BeginInit();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.class1_0).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.Controls.Add(this.dgvEquipment, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24f));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.74074f));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 378);
			this.tableLayoutPanel1.TabIndex = 0;
			this.dgvEquipment.AllowUserToAddRows = false;
			this.dgvEquipment.BackgroundColor = System.Drawing.Color.White;
			this.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.idEquipment,
				this.idTypeEquipment,
				this.NameEquipment,
				this.DescriptionEquipment,
				this.CommentEquipment,
				this.DeletedEquipment
			});
			dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvEquipment.DefaultCellStyle = dataGridViewCellStyle;
			this.dgvEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvEquipment.Location = new System.Drawing.Point(3, 27);
			this.dgvEquipment.MultiSelect = false;
			this.dgvEquipment.Name = "dgvEquipment";
			this.dgvEquipment.RowHeadersVisible = false;
			this.dgvEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEquipment.Size = new System.Drawing.Size(544, 348);
			this.dgvEquipment.TabIndex = 3;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.tsbEquipmentAdd,
				this.tsbEquipmentDel,
				this.tsbEquipmentEdit,
				this.tsbEquipmentInfo
			});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(550, 24);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			this.tsbEquipmentAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbEquipmentAdd.Image = Reference.Properties.Resources.smethod_9();
			this.tsbEquipmentAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEquipmentAdd.Name = "tsbEquipmentAdd";
			this.tsbEquipmentAdd.Size = new System.Drawing.Size(23, 21);
			this.tsbEquipmentAdd.Text = "Добавление оборудования";
			this.tsbEquipmentAdd.Click += new System.EventHandler(this.tsbEquipmentAdd_Click);
			this.tsbEquipmentDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbEquipmentDel.Image = Reference.Properties.Resources.smethod_10();
			this.tsbEquipmentDel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEquipmentDel.Name = "tsbEquipmentDel";
			this.tsbEquipmentDel.Size = new System.Drawing.Size(23, 21);
			this.tsbEquipmentDel.Text = "Удаление оборудования";
			this.tsbEquipmentDel.Click += new System.EventHandler(this.tsbEquipmentDel_Click);
			this.tsbEquipmentInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbEquipmentInfo.Image = Reference.Properties.Resources.smethod_8();
			this.tsbEquipmentInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEquipmentInfo.Name = "tsbEquipmentInfo";
			this.tsbEquipmentInfo.Size = new System.Drawing.Size(23, 21);
			this.tsbEquipmentInfo.Text = "Информация об оборудовании";
			this.tsbEquipmentInfo.Click += new System.EventHandler(this.tsbEquipmentInfo_Click);
			this.class1_0.DataSetName = "DataSetEquipment";
			this.class1_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.tsbEquipmentEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbEquipmentEdit.Image = Reference.Properties.Resources.smethod_11();
			this.tsbEquipmentEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEquipmentEdit.Name = "tsbEquipmentEdit";
			this.tsbEquipmentEdit.Size = new System.Drawing.Size(23, 21);
			this.tsbEquipmentEdit.Text = "Редактирование оборудования";
			this.tsbEquipmentEdit.Visible = false;
			this.tsbEquipmentEdit.Click += new System.EventHandler(this.tsbEquipmentEdit_Click);
			this.idEquipment.DataPropertyName = "id";
			this.idEquipment.HeaderText = "idEquipment";
			this.idEquipment.Name = "idEquipment";
			this.idEquipment.Visible = false;
			this.idTypeEquipment.DataPropertyName = "idTypeEquipment";
			this.idTypeEquipment.HeaderText = "idTypeEquipment";
			this.idTypeEquipment.Name = "idTypeEquipment";
			this.idTypeEquipment.Visible = false;
			this.NameEquipment.DataPropertyName = "Name";
			this.NameEquipment.HeaderText = "Оборудование";
			this.NameEquipment.Name = "NameEquipment";
			this.NameEquipment.Width = 200;
			this.DescriptionEquipment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DescriptionEquipment.DataPropertyName = "Description";
			this.DescriptionEquipment.HeaderText = "Описание";
			this.DescriptionEquipment.Name = "DescriptionEquipment";
			this.CommentEquipment.DataPropertyName = "Comment";
			this.CommentEquipment.HeaderText = "CommentEquipment";
			this.CommentEquipment.Name = "CommentEquipment";
			this.CommentEquipment.Visible = false;
			this.DeletedEquipment.DataPropertyName = "Deleted";
			this.DeletedEquipment.HeaderText = "DeletedEquipment";
			this.DeletedEquipment.Name = "DeletedEquipment";
			this.DeletedEquipment.Visible = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(550, 378);
			base.Controls.Add(this.tableLayoutPanel1);
			base.Name = "FormEquipment";
			this.Text = "FormEquipment";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvEquipment).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.class1_0).EndInit();
			base.ResumeLayout(false);
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		private System.Windows.Forms.DataGridView dgvEquipment;

		private System.Windows.Forms.ToolStrip toolStrip1;

		private System.Windows.Forms.ToolStripButton tsbEquipmentAdd;

		private System.Windows.Forms.ToolStripButton tsbEquipmentDel;

		private Class1 class1_0;

		private System.Windows.Forms.ToolStripButton tsbEquipmentInfo;

		private System.Windows.Forms.DataGridViewTextBoxColumn idEquipment;

		private System.Windows.Forms.DataGridViewTextBoxColumn idTypeEquipment;

		private System.Windows.Forms.DataGridViewTextBoxColumn NameEquipment;

		private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionEquipment;

		private System.Windows.Forms.DataGridViewTextBoxColumn CommentEquipment;

		private System.Windows.Forms.DataGridViewTextBoxColumn DeletedEquipment;

		private System.Windows.Forms.ToolStripButton tsbEquipmentEdit;
	}
}
