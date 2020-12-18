using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;

namespace Passport.Forms.AirLine
{
	public class FormChooseSubstation : FormBase
	{
		public ObjectData Obj
		{
			get
			{
				return this.objectData_0;
			}
		}

		public FormChooseSubstation()
		{
			this.method_4();
		}

		private void FormChooseSubstation_Load(object sender, EventArgs e)
		{
			this.method_0();
		}

		private void method_0()
		{
			this.treeView_0.BeginUpdate();
			this.treeView_0.Nodes.Clear();
			this.method_1(this.treeView_0);
			this.method_2(this.treeView_0);
			this.treeView_0.EndUpdate();
		}

		private void method_1(TreeView treeView_1)
		{
			foreach (object obj in base.SelectSqlData("tR_Classifier", true, "where ParentKey = ';SCM;PS;' and isGroup = '0' and deleted = '0'").Rows)
			{
				DataRow dataRow = (DataRow)obj;
				TreeNode treeNode = new TreeNode(dataRow["SocrName"].ToString());
				treeNode.Name = dataRow["id"].ToString();
				treeNode.Tag = (int)dataRow["id"];
				treeView_1.Nodes.Add(treeNode);
			}
		}

		private void method_2(TreeView treeView_1)
		{
			foreach (object obj in base.SelectSqlData("vP_GetObjListData", true, "where ParentKey = ';SCM;PS;'").Rows)
			{
				DataRow dataRow = (DataRow)obj;
				TreeNode treeNode = new TreeNode(dataRow["socrName"].ToString() + " - " + dataRow["Name"].ToString());
				treeNode.Name = dataRow["Name"].ToString();
				treeNode.Tag = (int)dataRow["id"];
				treeView_1.Nodes[dataRow["typeCodeId"].ToString()].Nodes.Add(treeNode);
			}
		}

		private bool method_3()
		{
			if (this.treeView_0.SelectedNode == null)
			{
				return false;
			}
			if (this.treeView_0.SelectedNode.Level == 1)
			{
				this.objectData_0.int_0 = (int)this.treeView_0.SelectedNode.Tag;
				this.objectData_0.name = this.treeView_0.SelectedNode.Parent.Text.Trim() + " - " + this.treeView_0.SelectedNode.Name.Trim();
				return true;
			}
			return false;
		}

		private void treeView_0_DoubleClick(object sender, EventArgs e)
		{
			if (!this.method_3())
			{
				return;
			}
			base.DialogResult = DialogResult.OK;
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
			this.button_0 = new Button();
			this.treeView_0 = new TreeView();
			base.SuspendLayout();
			this.button_0.Dock = DockStyle.Bottom;
			this.button_0.Location = new Point(0, 296);
			this.button_0.Name = "button1";
			this.button_0.Size = new Size(253, 33);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "Выбрать";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.treeView_0_DoubleClick;
			this.treeView_0.Dock = DockStyle.Fill;
			this.treeView_0.Location = new Point(0, 0);
			this.treeView_0.Name = "trvSubstation";
			this.treeView_0.Size = new Size(253, 296);
			this.treeView_0.TabIndex = 1;
			this.treeView_0.DoubleClick += this.treeView_0_DoubleClick;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(253, 329);
			base.Controls.Add(this.treeView_0);
			base.Controls.Add(this.button_0);
			base.Name = "FormChooseSubstation";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Выбор подстанции";
			base.Load += this.FormChooseSubstation_Load;
			base.ResumeLayout(false);
		}

		private ObjectData objectData_0 = new ObjectData();

		private IContainer icontainer_0;

		private Button button_0;

		private TreeView treeView_0;
	}
}
