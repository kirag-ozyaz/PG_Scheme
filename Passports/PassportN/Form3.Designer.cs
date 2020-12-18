using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;
using Passport.Classes;
using Passport.Controls;
using Passport.Forms;
using Passport.Properties;

internal class Form3 : FormBase
{
	internal int Id
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

	internal int method_0()
	{
		return this.int_1;
	}

	internal void method_1(int int_4)
	{
		this.int_1 = int_4;
	}

	internal TypeClutch method_2()
	{
		return this.typeClutch_0;
	}

	internal void method_3(TypeClutch typeClutch_1)
	{
		this.typeClutch_0 = typeClutch_1;
	}

	internal Form3()
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.method_7();
	}

	internal Form3(SQLSettings sqlsettings_0, int int_4, StateFormCreate stateFormCreate_1)
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.method_7();
		this.SqlSettings = sqlsettings_0;
		this.stateFormCreate_0 = stateFormCreate_1;
		this.int_3 = this.method_5(int_4);
		if (this.stateFormCreate_0 == null)
		{
			this.int_1 = int_4;
		}
		if (this.stateFormCreate_0 == 1)
		{
			this.int_0 = int_4;
		}
		this.int_2 = Class318.smethod_0(this.SqlSettings, base.Name);
	}

	private void Form3_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (base.DialogResult == DialogResult.OK)
		{
			if (!this.panelClutch_0.Save())
			{
				e.Cancel = true;
				return;
			}
			this.int_0 = this.panelClutch_0.Id;
			Class318.smethod_2(this.SqlSettings, this.int_2, this.stateFormCreate_0);
		}
		Class318.smethod_1(this.SqlSettings, this.int_2);
	}

	private void Form3_Load(object sender, EventArgs e)
	{
		this.Text = this.method_4();
		this.panelClutch_0.SqlSettings = this.SqlSettings;
		this.panelClutch_0.Id = this.int_0;
		this.panelClutch_0.IdCable = this.int_1;
		this.panelClutch_0.CreateState = this.stateFormCreate_0;
		this.panelClutch_0.Fill();
		if (base.Parent is FormDockPassport)
		{
			((FormDockPassport)base.Parent).ChangeTabPageClutches(this.panelClutch_0.ClutchType);
		}
	}

	private string method_4()
	{
		return ((this.stateFormCreate_0 == null) ? "Добавление " : "Редактирование ") + ((this.typeClutch_0 == TypeClutch.Connective) ? "соединительной " : "концевой ") + "муфты" + ((this.stateFormCreate_0 == null) ? "" : (" : " + this.method_6(this.int_0)));
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		StateFormCreate state = 6;
		if ((bool)this.panelClutch_0.DataGridViewPassport1.CurrentRow.Cells["isGroupChar"].Value)
		{
			state = 5;
		}
		FormAddEditPassportChar formAddEditPassportChar = new FormAddEditPassportChar(this.SqlSettings, state, (int)this.panelClutch_0.DataGridViewPassport1.CurrentRow.Cells["idChar"].Value, this.panelClutch_0.DataGridViewPassport1.RowCount + 1);
		formAddEditPassportChar.Parent = Application.OpenForms["MainForm"];
		formAddEditPassportChar.ShowDialog();
		if (formAddEditPassportChar.IsListEdited)
		{
			this.panelClutch_0.DataGridViewPassport1.UpdateComboboxData(formAddEditPassportChar.TableName, formAddEditPassportChar.ParentId);
		}
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		if (this.panelClutch_0.DataGridViewPassport1.CurrentRow != null)
		{
			if ((bool)this.panelClutch_0.DataGridViewPassport1.CurrentRow.Cells["isGroupChar"].Value)
			{
				if (MessageBox.Show("Вы действительно хотите удалить группу \"" + this.panelClutch_0.DataGridViewPassport1.CurrentRow.Cells["NameChar"].Value.ToString() + "\"?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					base.SelectSqlData(this.class107_0.tP_CharList, true, string.Format("where id = {0} or ParentId = {0}", (int)this.panelClutch_0.DataGridViewPassport1.CurrentRow.Cells["idChar"].Value), null, true, 0);
					foreach (object obj in this.class107_0.tP_CharList.Rows)
					{
						((Class107.Class285)obj).Deleted = true;
					}
					base.UpdateSqlData(this.class107_0, this.class107_0.tP_CharList);
					this.panelClutch_0.DataGridViewPassport1.UpdateData();
					return;
				}
			}
			else if (MessageBox.Show("Вы действительно хотите удалить характеристику \"" + this.panelClutch_0.DataGridViewPassport1.CurrentRow.Cells["NameChar"].Value.ToString() + "\"?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				base.SelectSqlData(this.class107_0.tP_CharList, true, "where id = " + (int)this.panelClutch_0.DataGridViewPassport1.CurrentRow.Cells["idChar"].Value, null, true, 0);
				this.class107_0.tP_CharList.Rows[0]["Deleted"] = true;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_CharList);
				this.panelClutch_0.DataGridViewPassport1.UpdateData();
			}
		}
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		if (this.panelClutch_0.DataGridViewPassport1.CurrentRow != null)
		{
			int id;
			if ((bool)this.panelClutch_0.DataGridViewPassport1.CurrentRow.Cells["isGroupChar"].Value)
			{
				id = (int)this.panelClutch_0.DataGridViewPassport1.CurrentRow.Cells["idChar"].Value;
			}
			else
			{
				id = (int)this.panelClutch_0.DataGridViewPassport1.CurrentRow.Cells["ParentIdChar"].Value;
			}
			if (new FormAddEditPassportChar(this.SqlSettings, 4, id, this.panelClutch_0.DataGridViewPassport1.RowCount + 1)
			{
				MdiParent = Application.OpenForms["MainForm"]
			}.ShowDialog() == DialogResult.OK)
			{
				this.panelClutch_0.DataGridViewPassport1.UpdateData();
			}
		}
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		new FormAddEditPassportChar(this.SqlSettings, 3, this.int_3, this.panelClutch_0.DataGridViewPassport1.RowCount + 1)
		{
			MdiParent = Application.OpenForms["MainForm"]
		}.ShowDialog();
		this.panelClutch_0.DataGridViewPassport1.UpdateData();
	}

	protected int method_5(int int_4)
	{
		int result = -1;
		try
		{
			result = Convert.ToInt32(base.CallSQLScalarFunction("dbo.fn_GetCharListParentId", new string[]
			{
				int_4.ToString()
			}));
		}
		catch
		{
			throw new Exception("К объекту не подсоеденён шаблон паспорта");
		}
		return result;
	}

	private string method_6(int int_4)
	{
		string result;
		try
		{
			result = base.CallSQLScalarFunction("dbo.fn_P_GetObjListText", new string[]
			{
				int_4.ToString()
			}).ToString();
		}
		catch (Exception)
		{
			result = "";
		}
		return result;
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(bool_0);
	}

	private void method_7()
	{
		this.class107_0 = new Class107();
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.panelClutch_0 = new PanelClutch();
		this.toolStrip_0 = new ToolStrip();
		this.toolStripDropDownButton_0 = new ToolStripDropDownButton();
		this.toolStripMenuItem_0 = new ToolStripMenuItem();
		this.toolStripMenuItem_1 = new ToolStripMenuItem();
		this.toolStripButton_0 = new ToolStripButton();
		this.toolStripButton_1 = new ToolStripButton();
		((ISupportInitialize)this.class107_0).BeginInit();
		this.toolStrip_0.SuspendLayout();
		base.SuspendLayout();
		this.class107_0.DataSetName = "dsPassport";
		this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_0.DialogResult = DialogResult.OK;
		this.button_0.Location = new Point(161, 461);
		this.button_0.Name = "btnSave";
		this.button_0.Size = new Size(88, 23);
		this.button_0.TabIndex = 2;
		this.button_0.Text = "Сохранить";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_1.DialogResult = DialogResult.Cancel;
		this.button_1.Location = new Point(255, 461);
		this.button_1.Name = "btnCancel";
		this.button_1.Size = new Size(75, 23);
		this.button_1.TabIndex = 3;
		this.button_1.Text = "Отмена";
		this.button_1.UseVisualStyleBackColor = true;
		this.panelClutch_0.CreateState = 0;
		this.panelClutch_0.Dock = DockStyle.Top;
		this.panelClutch_0.Id = 0;
		this.panelClutch_0.IdCable = 0;
		this.panelClutch_0.Location = new Point(0, 25);
		this.panelClutch_0.Name = "pnlClutch";
		this.panelClutch_0.Size = new Size(342, 423);
		this.panelClutch_0.SqlSettings = null;
		this.panelClutch_0.TabIndex = 4;
		this.panelClutch_0.WithClutches = true;
		this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
		this.toolStrip_0.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripDropDownButton_0,
			this.toolStripButton_0,
			this.toolStripButton_1
		});
		this.toolStrip_0.Location = new Point(0, 0);
		this.toolStrip_0.Name = "tsMain";
		this.toolStrip_0.Size = new Size(342, 25);
		this.toolStrip_0.TabIndex = 5;
		this.toolStrip_0.Text = "toolStrip1";
		this.toolStripDropDownButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripDropDownButton_0.DropDownItems.AddRange(new ToolStripItem[]
		{
			this.toolStripMenuItem_0,
			this.toolStripMenuItem_1
		});
		this.toolStripDropDownButton_0.Image = Resources.smethod_24();
		this.toolStripDropDownButton_0.ImageTransparentColor = Color.Magenta;
		this.toolStripDropDownButton_0.Name = "toolStripDropDownButton1";
		this.toolStripDropDownButton_0.Size = new Size(29, 22);
		this.toolStripDropDownButton_0.Text = "Добавить параметр";
		this.toolStripMenuItem_0.Name = "добавитьГруппуToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new Size(182, 22);
		this.toolStripMenuItem_0.Text = "Добавить группу";
		this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
		this.toolStripMenuItem_1.Name = "добавитьПараметрToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new Size(182, 22);
		this.toolStripMenuItem_1.Text = "Добавить параметр";
		this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
		this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_0.Image = Resources.smethod_26();
		this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_0.Name = "toolStripButton1";
		this.toolStripButton_0.Size = new Size(23, 22);
		this.toolStripButton_0.Text = "Редактировать параметр";
		this.toolStripButton_0.Click += this.toolStripButton_0_Click;
		this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_1.Image = Resources.smethod_25();
		this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_1.Name = "toolStripButton2";
		this.toolStripButton_1.Size = new Size(23, 22);
		this.toolStripButton_1.Text = "Удалить параметр";
		this.toolStripButton_1.Click += this.toolStripButton_1_Click;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(342, 496);
		base.Controls.Add(this.panelClutch_0);
		base.Controls.Add(this.toolStrip_0);
		base.Controls.Add(this.button_1);
		base.Controls.Add(this.button_0);
		base.Name = "FormAddEditClutch";
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "FormAddClutch";
		base.FormClosing += this.Form3_FormClosing;
		base.Load += this.Form3_Load;
		((ISupportInitialize)this.class107_0).EndInit();
		this.toolStrip_0.ResumeLayout(false);
		this.toolStrip_0.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private int int_0;

	private int int_1;

	private TypeClutch typeClutch_0;

	private StateFormCreate stateFormCreate_0;

	private int int_2;

	private int int_3;

	private IContainer icontainer_0;

	private Class107 class107_0;

	private Button button_0;

	private Button button_1;

	private PanelClutch panelClutch_0;

	private ToolStrip toolStrip_0;

	private ToolStripDropDownButton toolStripDropDownButton_0;

	private ToolStripButton toolStripButton_0;

	private ToolStripButton toolStripButton_1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;
}
