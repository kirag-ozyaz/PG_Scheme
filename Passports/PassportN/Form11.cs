using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;

internal class Form11 : FormBase
{
	internal Class12 method_0()
	{
		return this.class12_0;
	}

	internal Form11()
	{
		Class330.Mus9JxKz1CNxy();
		this.class12_0 = new Class12();
		base..ctor();
		this.method_5();
	}

	private void Form11_Load(object sender, EventArgs e)
	{
		this.method_1();
	}

	private void method_1()
	{
		this.treeView_0.BeginUpdate();
		this.treeView_0.Nodes.Clear();
		this.method_2(this.treeView_0);
		this.method_3(this.treeView_0);
		this.treeView_0.EndUpdate();
	}

	private void method_2(TreeView treeView_1)
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

	private void method_3(TreeView treeView_1)
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

	private bool method_4()
	{
		if (this.treeView_0.SelectedNode == null)
		{
			return false;
		}
		if (this.treeView_0.SelectedNode.Level == 1)
		{
			this.class12_0.int_0 = (int)this.treeView_0.SelectedNode.Tag;
			this.class12_0.string_0 = this.treeView_0.SelectedNode.Parent.Text.Trim() + " - " + this.treeView_0.SelectedNode.Name.Trim();
			return true;
		}
		return false;
	}

	private void treeView_0_DoubleClick(object sender, EventArgs e)
	{
		if (!this.method_4())
		{
			return;
		}
		base.DialogResult = DialogResult.OK;
		base.Close();
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Form11.A7Lu3g9PUwIZssYRhp8E(this, bool_0);
	}

	private void method_5()
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
		base.Load += this.Form11_Load;
		base.ResumeLayout(false);
	}

	internal static void A7Lu3g9PUwIZssYRhp8E(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private Class12 class12_0;

	private IContainer icontainer_0;

	private Button button_0;

	private TreeView treeView_0;
}
