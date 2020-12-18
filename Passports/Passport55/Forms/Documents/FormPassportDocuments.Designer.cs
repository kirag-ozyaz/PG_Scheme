using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DataSql;

namespace Passport.Forms.Documents
{
	public class FormPassportDocuments : FormDocBase
	{
		public FormPassportDocuments(SQLSettings settings)
		{
			this.method_14();
			this.SqlSettings = settings;
			if (base.method_11("tP_DocList"))
			{
				if (MessageBox.Show("Документ открыт в режиме редактирования другим пользователем.\n\rОткрыть его в режиме \"только для чтения\"?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
				{
					base.Close();
				}
				this.Text = "Чтение";
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_1 != null)
			{
				this.icontainer_1.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_14()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormPassportDocuments));
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.splitContainer_0 = new SplitContainer();
			this.tableLayoutPanel_1 = new TableLayoutPanel();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.toolStrip_1 = new ToolStrip();
			((ISupportInitialize)this.dsDocuments_0).BeginInit();
			this.tableLayoutPanel_0.SuspendLayout();
			this.toolStrip_0.SuspendLayout();
			this.splitContainer_0.Panel1.SuspendLayout();
			this.splitContainer_0.SuspendLayout();
			this.tableLayoutPanel_1.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 1;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_0.Controls.Add(this.splitContainer_0, 0, 1);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 2;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.Size = new Size(947, 490);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripButton_1,
				this.toolStripButton_2
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "toolStrip1";
			this.toolStrip_0.Size = new Size(947, 25);
			this.toolStrip_0.TabIndex = 1;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = (Image)componentResourceManager.GetObject("toolStripButton1.Image");
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "toolStripButton1";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "toolStripButton1";
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = (Image)componentResourceManager.GetObject("toolStripButton2.Image");
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "toolStripButton2";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "toolStripButton2";
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = (Image)componentResourceManager.GetObject("toolStripButton3.Image");
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "toolStripButton3";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "toolStripButton3";
			this.splitContainer_0.Dock = DockStyle.Fill;
			this.splitContainer_0.Location = new Point(3, 28);
			this.splitContainer_0.Name = "splitContainer1";
			this.splitContainer_0.Panel1.Controls.Add(this.tableLayoutPanel_1);
			this.splitContainer_0.Size = new Size(941, 459);
			this.splitContainer_0.SplitterDistance = 242;
			this.splitContainer_0.TabIndex = 1;
			this.tableLayoutPanel_1.ColumnCount = 1;
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.Controls.Add(this.dataGridView_0, 0, 1);
			this.tableLayoutPanel_1.Controls.Add(this.toolStrip_1, 0, 0);
			this.tableLayoutPanel_1.Dock = DockStyle.Fill;
			this.tableLayoutPanel_1.Location = new Point(0, 0);
			this.tableLayoutPanel_1.Name = "tableLayoutPanel2";
			this.tableLayoutPanel_1.RowCount = 2;
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.Size = new Size(242, 459);
			this.tableLayoutPanel_1.TabIndex = 1;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.BackgroundColor = SystemColors.Window;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_6
			});
			this.dataGridView_0.Dock = DockStyle.Fill;
			this.dataGridView_0.Location = new Point(3, 28);
			this.dataGridView_0.MultiSelect = false;
			this.dataGridView_0.Name = "dgvPassportDocList";
			this.dataGridView_0.ReadOnly = true;
			this.dataGridView_0.RowHeadersVisible = false;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(236, 428);
			this.dataGridView_0.TabIndex = 1;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "dlId";
			this.dataGridViewTextBoxColumn_0.Name = "dlId";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "idObjList";
			this.dataGridViewTextBoxColumn_1.HeaderText = "dlIdObjList";
			this.dataGridViewTextBoxColumn_1.Name = "dlIdObjList";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "DateDoc";
			this.dataGridViewTextBoxColumn_2.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_2.Name = "dlDateDoc";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Width = 80;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "NumberDoc";
			this.dataGridViewTextBoxColumn_3.HeaderText = "Номер";
			this.dataGridViewTextBoxColumn_3.Name = "dlNumberDoc";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Width = 80;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "TypeDoc";
			this.dataGridViewTextBoxColumn_4.HeaderText = "Тип";
			this.dataGridViewTextBoxColumn_4.Name = "TypeDoc";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Width = 200;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "isActive";
			this.dataGridViewTextBoxColumn_5.HeaderText = "isActive";
			this.dataGridViewTextBoxColumn_5.Name = "isActive";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_6.HeaderText = "Deleted";
			this.dataGridViewTextBoxColumn_6.Name = "Deleted";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.toolStrip_1.Location = new Point(0, 0);
			this.toolStrip_1.Name = "toolStrip2";
			this.toolStrip_1.Size = new Size(242, 25);
			this.toolStrip_1.TabIndex = 2;
			this.toolStrip_1.Text = "toolStrip2";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(947, 490);
			base.Controls.Add(this.toolStrip_0);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormPassportDocuments";
			this.Text = "FormPassportDocuments";
			((ISupportInitialize)this.dsDocuments_0).EndInit();
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.splitContainer_0.Panel1.ResumeLayout(false);
			this.splitContainer_0.ResumeLayout(false);
			this.tableLayoutPanel_1.ResumeLayout(false);
			this.tableLayoutPanel_1.PerformLayout();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private IContainer icontainer_1;

		private TableLayoutPanel tableLayoutPanel_0;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private ToolStripButton toolStripButton_2;

		private SplitContainer splitContainer_0;

		private TableLayoutPanel tableLayoutPanel_1;

		private DataGridView dataGridView_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private ToolStrip toolStrip_1;
	}
}
