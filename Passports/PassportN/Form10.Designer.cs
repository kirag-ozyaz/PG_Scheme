using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FormLbr;
using Passport.Classes;
using Passport.Forms;

internal class Form10 : FormBase
{
	internal int method_0()
	{
		return this.int_0;
	}

	internal void method_1(int int_2)
	{
		this.int_1 = int_2;
	}

	internal Form10()
	{
		Class330.Mus9JxKz1CNxy();
		this.int_0 = -1;
		this.int_1 = -1;
		base..ctor();
		this.method_8();
	}

	protected override void OnLoad(EventArgs eventArgs_0)
	{
		base.OnLoad(eventArgs_0);
		this.method_5();
		this.method_7(-3);
		this.method_6(this.treeView_0.Nodes);
	}

	private void method_2()
	{
		TypeObjListGroup group = TypeObjListGroup.AirLines;
		string arg = string.Join(",", (from i in ObjList.GetGroupValue(TypeObjListGroup.AirLines)
		select i.ToString()).ToArray<string>());
		foreach (object obj in base.SelectSqlData("tR_Classifier", true, string.Format("WHERE Parentkey = '{0}' AND Value IN ({1}) AND isGroup = ((0)) AND Deleted = ((0))", ObjList.GetGroupParentKey(group), arg)).Rows)
		{
			DataRow dataRow = (DataRow)obj;
			TreeNode treeNode = new TreeNode(dataRow["SocrName"].ToString());
			treeNode.Tag = (int)dataRow["id"];
			treeNode.Name = dataRow["id"].ToString();
			this.treeView_0.Nodes.Add(treeNode);
		}
	}

	private void method_3()
	{
		foreach (object obj in this.treeView_0.Nodes)
		{
			TreeNode treeNode = (TreeNode)obj;
			this.treeNode_0 = new TreeNode("0,4 кВ");
			this.treeNode_0.Name = "NodeNN";
			this.treeNode_0.Tag = 0;
			this.treeNode_0.Expand();
			treeNode.Nodes.Add(this.treeNode_0);
			this.treeNode_1 = new TreeNode("6-10 кВ");
			this.treeNode_1.Tag = 0;
			this.treeNode_1.Expand();
			this.treeNode_1.Name = "NodeSN";
			treeNode.Nodes.Add(this.treeNode_1);
		}
	}

	private void method_4(TreeNodeData treeNodeData_0, TreeNode treeNode_2)
	{
		if (!(treeNodeData_0.Voltage == 10m) && !(treeNodeData_0.Voltage == 6m))
		{
			this.treeView_0.Nodes[treeNodeData_0.TypeCodeId.ToString()].Nodes["NodeNN"].Nodes.Add(treeNode_2);
			return;
		}
		this.treeView_0.Nodes[treeNodeData_0.TypeCodeId.ToString()].Nodes["NodeSN"].Nodes.Add(treeNode_2);
	}

	private void method_5()
	{
		TypeObjListGroup group = TypeObjListGroup.AirLines;
		try
		{
			string text = string.Join(",", (from i in ObjList.GetGroupValue(@group)
			select i.ToString()).ToArray<string>());
			string groupParentKey = ObjList.GetGroupParentKey(group);
			List<TreeNodeData> list = new List<TreeNodeData>();
			string text2 = " DESC";
			string text3;
			if (text.Length != 0)
			{
				text3 = string.Format("WHERE ParentKey LIKE '{0}%' AND Value IN ({1}) order by Name {2}", groupParentKey, text, text2);
			}
			else
			{
				text3 = string.Format("WHERE ParentKey LIKE '{0}%' order by Name {1}", groupParentKey, text2);
			}
			this.treeView_0.BeginUpdate();
			this.treeView_0.Nodes.Clear();
			try
			{
				this.method_2();
				this.method_3();
				list = (from rows in base.SelectSqlData("vP_CableLine", true, text3).AsEnumerable()
				select new TreeNodeData(rows.Field("Id"), rows.Field("TypeCodeId"), rows.Field("Name"), rows.Field("Text"), (rows["Voltage"] == DBNull.Value) ? 10m : rows.Field("Voltage"), (rows["IdParentAddl"] != DBNull.Value) ? ((int)rows["IdParentAddl"]) : -1)).ToList<TreeNodeData>();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			foreach (TreeNodeData treeNodeData in list)
			{
				this.method_4(treeNodeData, new TreeNode(treeNodeData.Text)
				{
					Name = treeNodeData.Name,
					Tag = treeNodeData.Id
				});
			}
			this.treeView_0.EndUpdate();
		}
		catch (Exception)
		{
		}
	}

	private void method_6(TreeNodeCollection treeNodeCollection_0)
	{
		foreach (object obj in treeNodeCollection_0)
		{
			TreeNode treeNode = (TreeNode)obj;
			if ((int)treeNode.Tag == this.int_1)
			{
				this.treeView_0.SelectedNode = treeNode;
			}
			this.method_6(treeNode.Nodes);
		}
	}

	private void method_7(int int_2)
	{
		string where = string.Format("WHERE (ol.id in (select [idClutchFirst] from tP_CabSection where idObjList = {0} and deleted = ((0))\r\nunion select idClutchSecond from tP_CabSection where idObjList = {0} and deleted = '0')) OR (ol.IdParent = {0} and ol.Deleted = 0\r\nand ol.TypeCodeId in (SELECT trc.id from tR_Classifier as trc\r\nWHERE trc.ParentKey = ';SCM;Pole;' and trc.IsGroup = 0 and trc.Deleted = 0))", int_2.ToString());
		DataTable equipmentData = PassportData.GetEquipmentData(this.SqlSettings, ObjectBase.GetTypeCodeId(this.SqlSettings, ";SCM;Pole;", 1m), where, false);
		this.bindingSource_0 = new BindingSource();
		this.bindingSource_0.DataSource = equipmentData;
		this.dataGridView_0.DataSource = this.bindingSource_0;
		this.bindingSource_0.CurrentChanged += this.bindingSource_0_CurrentChanged;
	}

	private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
	{
		if (this.bindingSource_0 != null && this.bindingSource_0.Current != null)
		{
			this.int_0 = Convert.ToInt32(((DataRowView)this.bindingSource_0.Current).Row["idObjList"]);
			return;
		}
		this.int_0 = -1;
	}

	private void treeView_0_AfterSelect(object sender, TreeViewEventArgs e)
	{
		this.method_7((int)e.Node.Tag);
	}

	private void dataGridView_0_CellClick(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void dataGridView_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		if (e.RowIndex < 0)
		{
			return;
		}
		this.int_0 = Convert.ToInt32(((DataRowView)this.bindingSource_0.Current).Row["idObjList"]);
		base.DialogResult = DialogResult.OK;
		base.Close();
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Form10.AXZkJ59P1iiAWnZP0E5Z(this, bool_0);
	}

	private void method_8()
	{
		this.splitContainer_0 = new SplitContainer();
		this.splitContainer_1 = new SplitContainer();
		this.treeView_0 = new TreeView();
		this.dataGridView_0 = new DataGridView();
		this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		this.IxlmFiOxpgP = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		this.splitContainer_0.Panel1.SuspendLayout();
		this.splitContainer_0.Panel2.SuspendLayout();
		this.splitContainer_0.SuspendLayout();
		this.splitContainer_1.Panel1.SuspendLayout();
		this.splitContainer_1.Panel2.SuspendLayout();
		this.splitContainer_1.SuspendLayout();
		((ISupportInitialize)this.dataGridView_0).BeginInit();
		base.SuspendLayout();
		this.splitContainer_0.Dock = DockStyle.Fill;
		this.splitContainer_0.FixedPanel = FixedPanel.Panel2;
		this.splitContainer_0.Location = new Point(0, 0);
		this.splitContainer_0.Name = "splitContainer1";
		this.splitContainer_0.Orientation = Orientation.Horizontal;
		this.splitContainer_0.Panel1.Controls.Add(this.splitContainer_1);
		this.splitContainer_0.Panel2.Controls.Add(this.button_0);
		this.splitContainer_0.Panel2.Controls.Add(this.button_1);
		this.splitContainer_0.Size = new Size(961, 313);
		this.splitContainer_0.SplitterDistance = 265;
		this.splitContainer_0.TabIndex = 0;
		this.splitContainer_1.Dock = DockStyle.Fill;
		this.splitContainer_1.Location = new Point(0, 0);
		this.splitContainer_1.Name = "splitContainer2";
		this.splitContainer_1.Panel1.Controls.Add(this.treeView_0);
		this.splitContainer_1.Panel2.Controls.Add(this.dataGridView_0);
		this.splitContainer_1.Size = new Size(961, 265);
		this.splitContainer_1.SplitterDistance = 240;
		this.splitContainer_1.TabIndex = 0;
		this.treeView_0.Dock = DockStyle.Fill;
		this.treeView_0.FullRowSelect = true;
		this.treeView_0.HideSelection = false;
		this.treeView_0.Location = new Point(0, 0);
		this.treeView_0.Name = "tvLines";
		this.treeView_0.Size = new Size(240, 265);
		this.treeView_0.TabIndex = 0;
		this.treeView_0.AfterSelect += this.treeView_0_AfterSelect;
		this.dataGridView_0.AllowUserToAddRows = false;
		this.dataGridView_0.AllowUserToDeleteRows = false;
		this.dataGridView_0.BackgroundColor = Color.White;
		this.dataGridView_0.BorderStyle = BorderStyle.Fixed3D;
		this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_0,
			this.dataGridViewTextBoxColumn_1,
			this.IxlmFiOxpgP,
			this.dataGridViewTextBoxColumn_2
		});
		this.dataGridView_0.Dock = DockStyle.Fill;
		this.dataGridView_0.Location = new Point(0, 0);
		this.dataGridView_0.MultiSelect = false;
		this.dataGridView_0.Name = "dgvPylons";
		this.dataGridView_0.ReadOnly = true;
		this.dataGridView_0.RowHeadersVisible = false;
		this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridView_0.Size = new Size(717, 265);
		this.dataGridView_0.TabIndex = 0;
		this.dataGridView_0.CellClick += this.dataGridView_0_CellClick;
		this.dataGridView_0.CellDoubleClick += this.dataGridView_0_CellDoubleClick;
		this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_0.HeaderText = "idPylon";
		this.dataGridViewTextBoxColumn_0.Name = "idPylon";
		this.dataGridViewTextBoxColumn_0.ReadOnly = true;
		this.dataGridViewTextBoxColumn_0.Visible = false;
		this.dataGridViewTextBoxColumn_1.DataPropertyName = "IdEquipment";
		this.dataGridViewTextBoxColumn_1.HeaderText = "IdEquipment";
		this.dataGridViewTextBoxColumn_1.Name = "IdEquipmentPylon";
		this.dataGridViewTextBoxColumn_1.ReadOnly = true;
		this.dataGridViewTextBoxColumn_1.Visible = false;
		this.IxlmFiOxpgP.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.IxlmFiOxpgP.DataPropertyName = "Name";
		this.IxlmFiOxpgP.HeaderText = "Наименование";
		this.IxlmFiOxpgP.MinimumWidth = 100;
		this.IxlmFiOxpgP.Name = "NamePylon";
		this.IxlmFiOxpgP.ReadOnly = true;
		this.dataGridViewTextBoxColumn_2.DataPropertyName = "idObjList";
		this.dataGridViewTextBoxColumn_2.HeaderText = "idObjListPylon";
		this.dataGridViewTextBoxColumn_2.Name = "idObjListPylon";
		this.dataGridViewTextBoxColumn_2.ReadOnly = true;
		this.dataGridViewTextBoxColumn_2.Visible = false;
		this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_0.DialogResult = DialogResult.OK;
		this.button_0.Location = new Point(793, 9);
		this.button_0.Name = "btnOK";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 0;
		this.button_0.Text = "ОК";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_1.DialogResult = DialogResult.Cancel;
		this.button_1.Location = new Point(874, 9);
		this.button_1.Name = "btnCancel";
		this.button_1.Size = new Size(75, 23);
		this.button_1.TabIndex = 0;
		this.button_1.Text = "Отмена";
		this.button_1.UseVisualStyleBackColor = true;
		this.dataGridViewTextBoxColumn_3.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_3.HeaderText = "idPylon";
		this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn1";
		this.dataGridViewTextBoxColumn_3.ReadOnly = true;
		this.dataGridViewTextBoxColumn_3.Visible = false;
		this.dataGridViewTextBoxColumn_4.DataPropertyName = "IdEquipment";
		this.dataGridViewTextBoxColumn_4.HeaderText = "IdEquipment";
		this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn2";
		this.dataGridViewTextBoxColumn_4.ReadOnly = true;
		this.dataGridViewTextBoxColumn_4.Visible = false;
		this.dataGridViewTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_5.DataPropertyName = "Name";
		this.dataGridViewTextBoxColumn_5.HeaderText = "Наименование";
		this.dataGridViewTextBoxColumn_5.MinimumWidth = 100;
		this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn3";
		this.dataGridViewTextBoxColumn_5.ReadOnly = true;
		this.dataGridViewTextBoxColumn_6.DataPropertyName = "idObjList";
		this.dataGridViewTextBoxColumn_6.HeaderText = "idObjListPylon";
		this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn4";
		this.dataGridViewTextBoxColumn_6.ReadOnly = true;
		this.dataGridViewTextBoxColumn_6.Visible = false;
		base.AcceptButton = this.button_0;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = this.button_1;
		base.ClientSize = new Size(961, 313);
		base.Controls.Add(this.splitContainer_0);
		base.Name = "FormChoosePylone";
		base.StartPosition = FormStartPosition.CenterParent;
		this.Text = "Выбор опоры";
		this.splitContainer_0.Panel1.ResumeLayout(false);
		this.splitContainer_0.Panel2.ResumeLayout(false);
		this.splitContainer_0.ResumeLayout(false);
		this.splitContainer_1.Panel1.ResumeLayout(false);
		this.splitContainer_1.Panel2.ResumeLayout(false);
		this.splitContainer_1.ResumeLayout(false);
		((ISupportInitialize)this.dataGridView_0).EndInit();
		base.ResumeLayout(false);
	}

	internal static void AXZkJ59P1iiAWnZP0E5Z(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private int int_0;

	private int int_1;

	private TreeNode treeNode_0;

	private TreeNode treeNode_1;

	private BindingSource bindingSource_0;

	private IContainer icontainer_0;

	private SplitContainer splitContainer_0;

	private SplitContainer splitContainer_1;

	private TreeView treeView_0;

	private DataGridView dataGridView_0;

	private Button button_0;

	private Button button_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private DataGridViewTextBoxColumn IxlmFiOxpgP;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;
}
