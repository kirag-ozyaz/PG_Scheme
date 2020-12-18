using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;
using Passport.Controls;

namespace Passport
{
	public class FormSettings : FormBase
	{
		public FormSettings(SQLSettings SqlSettings, TypeSettings typeSettings)
		{
			Class330.Mus9JxKz1CNxy();
			this.list_0 = new List<TreeNode>();
			base..ctor();
			this.method_4();
			this.SqlSettings = SqlSettings;
			this.typeSettings_0 = typeSettings;
			this.method_0(typeSettings);
		}

		private void method_0(TypeSettings typeSettings_1)
		{
			if (typeSettings_1 != 1 && typeSettings_1 == 2)
			{
				this.method_2();
				this.method_1("PanelPassport");
			}
		}

		private void method_1(string string_0)
		{
			this.list_0 = this.method_3(this.treeView_0.Nodes, this.list_0);
			foreach (TreeNode treeNode in this.list_0)
			{
				if (treeNode.Name == string_0)
				{
					this.treeView_0.SelectedNode = treeNode;
				}
			}
		}

		private void method_2()
		{
			this.panelPassportSettings_0 = new PanelPassportSettings(this.SqlSettings);
			this.tableLayoutPanel_0.Controls.Add(this.panelPassportSettings_0, 1, 0);
			this.panelPassportSettings_0.Dock = DockStyle.Fill;
		}

		private List<TreeNode> method_3(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_1)
		{
			foreach (object obj in treeNodeCollection_0)
			{
				TreeNode treeNode = (TreeNode)obj;
				list_1.Add(treeNode);
				list_1 = this.method_3(treeNode.Nodes, list_1);
			}
			return list_1;
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			TypeSettings typeSettings = this.typeSettings_0;
			if (typeSettings != 1 && typeSettings == 2)
			{
				this.panelPassportSettings_0.SaveSettings();
			}
			base.Close();
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			base.Close();
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
			TreeNode treeNode = new TreeNode("Панель паспорта");
			TreeNode treeNode2 = new TreeNode("Изображения");
			TreeNode treeNode3 = new TreeNode("Паспорт", new TreeNode[]
			{
				treeNode,
				treeNode2
			});
			TreeNode treeNode4 = new TreeNode("Общие", new TreeNode[]
			{
				treeNode3
			});
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.tableLayoutPanel_1 = new TableLayoutPanel();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.treeView_0 = new TreeView();
			this.tableLayoutPanel_0.SuspendLayout();
			this.tableLayoutPanel_1.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.16667f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60.83333f));
			this.tableLayoutPanel_0.Controls.Add(this.tableLayoutPanel_1, 1, 1);
			this.tableLayoutPanel_0.Controls.Add(this.treeView_0, 0, 0);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tlpSettings";
			this.tableLayoutPanel_0.RowCount = 2;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 36f));
			this.tableLayoutPanel_0.Size = new Size(495, 443);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.tableLayoutPanel_1.ColumnCount = 4;
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95f));
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103f));
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 103f));
			this.tableLayoutPanel_1.Controls.Add(this.button_0, 3, 0);
			this.tableLayoutPanel_1.Controls.Add(this.button_1, 2, 0);
			this.tableLayoutPanel_1.Dock = DockStyle.Fill;
			this.tableLayoutPanel_1.Location = new Point(196, 410);
			this.tableLayoutPanel_1.Name = "tableLayoutPanel2";
			this.tableLayoutPanel_1.RowCount = 1;
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.Size = new Size(296, 30);
			this.tableLayoutPanel_1.TabIndex = 0;
			this.button_0.Dock = DockStyle.Left;
			this.button_0.Location = new Point(196, 3);
			this.button_0.Name = "button1";
			this.button_0.Size = new Size(83, 24);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "Отмена";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Dock = DockStyle.Fill;
			this.button_1.Location = new Point(93, 3);
			this.button_1.Name = "button2";
			this.button_1.Size = new Size(97, 24);
			this.button_1.TabIndex = 1;
			this.button_1.Text = "Сохранить";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.treeView_0.Dock = DockStyle.Fill;
			this.treeView_0.Location = new Point(3, 3);
			this.treeView_0.Name = "trvSettings";
			treeNode.Name = "PanelPassport";
			treeNode.Text = "Панель паспорта";
			treeNode2.Name = "Images";
			treeNode2.Text = "Изображения";
			treeNode3.Name = "tPassport";
			treeNode3.Text = "Паспорт";
			treeNode4.Name = "General";
			treeNode4.Text = "Общие";
			this.treeView_0.Nodes.AddRange(new TreeNode[]
			{
				treeNode4
			});
			this.treeView_0.Size = new Size(187, 401);
			this.treeView_0.TabIndex = 1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(495, 443);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormSettings";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Настройки";
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		private TypeSettings typeSettings_0;

		private List<TreeNode> list_0;

		private PanelPassportSettings panelPassportSettings_0;

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private TableLayoutPanel tableLayoutPanel_1;

		private Button button_0;

		private Button button_1;

		private TreeView treeView_0;
	}
}
