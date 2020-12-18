using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using DataSql;
using Passport.Controls;
using Passport.DataSets;
using Passport.Properties;
using WeifenLuo.WinFormsUI.Docking;

namespace Passport.Forms
{
	public class FormAddEditValuePassportChars : DockContentBase
	{
		[DefaultValue(-1)]
		public int IdPassport
		{
			get
			{
				return this.int_1;
			}
		}

		public FormAddEditValuePassportChars(SQLSettings SqlSettings, StateFormCreate State, int idObj = -1, int idPassport = -1)
		{
			this.method_1();
			this.numericUpDown_0.DataBindings[0].NullValue = 0;
			this.numericUpDown_0.DataBindings[0].DataSourceNullValue = 0;
			this.SqlSettings = SqlSettings;
			this.int_0 = idObj;
			this.int_1 = idPassport;
			this.int_2 = this.GetCharListParentId(this.int_0);
			this.stateFormCreate_0 = State;
			DateTime now = DateTime.Now;
			new Dictionary<string, string>().Add(this.dsPassport_0.tAbn.TableName, "");
			this.dataGridViewPassport_0.EnableDragDrop = true;
			this.dataGridViewPassport_0.DragDropComplite = true;
			base.SelectSqlData(this.dsPassport_0.tSchm_ObjList, true, "where id = " + idObj.ToString(), false);
			this.dataGridViewPassport_0.DataError += this.dataGridViewPassport_0_DataError;
			if (idPassport == -1)
			{
				this.Text = "Добавление паспорта";
				this.stateFormCreate_0 = 0;
			}
			StateFormCreate stateFormCreate = this.stateFormCreate_0;
			if (stateFormCreate == null)
			{
				this.Text = "Добавление паспорта";
				dsPassport.Class62 @class = this.dsPassport_0.tP_Passport.method_5();
				@class.idObjList = idObj;
				@class.Date = DateTime.Now;
				@class.DateIn = DateTime.Now;
				@class.Deleted = false;
				@class.isActive = true;
				this.dsPassport_0.tP_Passport.method_0(@class);
				this.dataGridViewPassport_0.AddRowAddingParemeter(this.SqlSettings, idObj);
				return;
			}
			if (stateFormCreate != 1)
			{
				return;
			}
			this.Text = "Редактирование паспорта : " + this.method_0(idObj);
			base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_Passport, true, string.Format("where id = '{0}'", idPassport));
			this.dataGridViewPassport_0.AddRowEditingParameter(this.SqlSettings, idPassport, DataGridViewPassport.CreateState.EditValue);
			if (this.dsPassport_0.tP_Passport.Rows.Count > 0)
			{
				this.dateTimePicker_0.Value = DateTime.Parse(this.dsPassport_0.tP_Passport.Rows[0]["Date"].ToString());
			}
			else
			{
				this.dateTimePicker_0.Value = DateTime.Now;
			}
			this.dateTimePicker_0.Enabled = false;
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			StateFormCreate state = 6;
			if ((bool)this.dataGridViewPassport_0.CurrentRow.Cells["isGroupChar"].Value)
			{
				state = 5;
			}
			FormAddEditPassportChar formAddEditPassportChar = new FormAddEditPassportChar(this.SqlSettings, state, (int)this.dataGridViewPassport_0.CurrentRow.Cells["idChar"].Value, this.dataGridViewPassport_0.RowCount + 1);
			formAddEditPassportChar.Parent = Application.OpenForms["MainForm"];
			formAddEditPassportChar.ShowDialog();
			if (formAddEditPassportChar.IsListEdited)
			{
				this.dataGridViewPassport_0.UpdateComboboxData(formAddEditPassportChar.TableName, formAddEditPassportChar.ParentId);
			}
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewPassport_0.CurrentRow != null)
			{
				if ((bool)this.dataGridViewPassport_0.CurrentRow.Cells["isGroupChar"].Value)
				{
					if (MessageBox.Show("Вы действительно хотите удалить группу \"" + this.dataGridViewPassport_0.CurrentRow.Cells["NameChar"].Value.ToString() + "\"?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_CharList, true, string.Format("where id = {0} or ParentId = {0}", (int)this.dataGridViewPassport_0.CurrentRow.Cells["idChar"].Value), true);
						foreach (object obj in this.dsPassport_0.tP_CharList.Rows)
						{
							((dsPassport.Class91)obj).Deleted = true;
						}
						base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_CharList);
						this.dataGridViewPassport_0.UpdateData();
						return;
					}
				}
				else if (MessageBox.Show("Вы действительно хотите удалить характеристику \"" + this.dataGridViewPassport_0.CurrentRow.Cells["NameChar"].Value.ToString() + "\"?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					base.SelectSqlData(this.dsPassport_0, this.dsPassport_0.tP_CharList, true, "where id = " + (int)this.dataGridViewPassport_0.CurrentRow.Cells["idChar"].Value, true);
					this.dsPassport_0.tP_CharList.Rows[0]["Deleted"] = true;
					base.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tP_CharList);
					this.dataGridViewPassport_0.UpdateData();
				}
			}
		}

		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewPassport_0.CurrentRow != null)
			{
				int int_;
				if ((bool)this.dataGridViewPassport_0.CurrentRow.Cells["isGroupChar"].Value)
				{
					int_ = (int)this.dataGridViewPassport_0.CurrentRow.Cells["idChar"].Value;
				}
				else
				{
					int_ = (int)this.dataGridViewPassport_0.CurrentRow.Cells["ParentIdChar"].Value;
				}
				if (new FormAddEditPassportChar(this.SqlSettings, 4, int_, this.dataGridViewPassport_0.RowCount + 1)
				{
					MdiParent = Application.OpenForms["MainForm"]
				}.ShowDialog() == DialogResult.OK)
				{
					this.dataGridViewPassport_0.UpdateData();
				}
			}
		}

		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			new FormAddEditPassportChar(this.SqlSettings, 3, this.int_2, this.dataGridViewPassport_0.RowCount + 1)
			{
				MdiParent = Application.OpenForms["MainForm"]
			}.ShowDialog();
			this.dataGridViewPassport_0.UpdateData();
		}

		protected int GetCharListParentId(int idObject)
		{
			int result = -1;
			try
			{
				result = Convert.ToInt32(base.CallSQLScalarFunction("dbo.fn_GetCharListParentId", new string[]
				{
					idObject.ToString()
				}));
			}
			catch
			{
				throw new Exception("К объекту не подсоеденён шаблон паспорта");
			}
			return result;
		}

		private void dataGridViewPassport_0_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			if (e.Context == DataGridViewDataErrorContexts.PreferredSize)
			{
				e.ThrowException = false;
			}
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.stateFormCreate_0 == null)
				{
					this.dataGridViewPassport_0.SaveInsertedData(this.dateTimePicker_0.Value, Convert.ToInt32(this.dsPassport_0.tP_Passport[0]["Number"]));
				}
				if (this.stateFormCreate_0 == 1)
				{
					this.dataGridViewPassport_0.SaveUpdatedData(this.dateTimePicker_0.Value, this.int_1, Convert.ToInt32(this.dsPassport_0.tP_Passport[0]["Number"]));
				}
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
			catch (Exception)
			{
			}
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void dataGridViewPassport_0_GroupChanging(object sender, GroupChangeEventArgs e)
		{
			if (MessageBox.Show(string.Concat(new string[]
			{
				"Вы действительно хотите переместить \"",
				e.CharName,
				"\" из группы \"",
				e.OldGroupName,
				"\" в группу \"",
				e.NewGroupName,
				"\"?"
			}), "Перемещение строк", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.dataGridViewPassport_0.DragDropComplite = true;
				return;
			}
			this.dataGridViewPassport_0.DragDropComplite = false;
		}

		private void dataGridViewPassport_0_GroupChanged(object sender, GroupChangeEventArgs e)
		{
		}

		private void dataGridViewPassport_0_DragDrop(object sender, DragEventArgs e)
		{
			this.dataGridViewPassport_0.DragDropComplite = true;
		}

		private string method_0(int int_3)
		{
			string result;
			try
			{
				result = base.CallSQLScalarFunction("dbo.fn_P_GetObjListText", new string[]
				{
					int_3.ToString()
				}).ToString();
			}
			catch (Exception)
			{
				result = "";
			}
			return result;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_1()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.tableLayoutPanel_1 = new TableLayoutPanel();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripSplitButton_0 = new ToolStripSplitButton();
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.tableLayoutPanel_2 = new TableLayoutPanel();
			this.label_0 = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.label_1 = new Label();
			this.numericUpDown_0 = new NumericUpDown();
			this.dsPassport_0 = new dsPassport();
			this.dataGridViewPassport_0 = new DataGridViewPassport();
			this.dataGridViewTextBoxColumn_110 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_111 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_112 = new DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn_22 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_113 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_114 = new DataGridViewTextBoxColumn();
			this.label_2 = new Label();
			this.tableLayoutPanel_3 = new TableLayoutPanel();
			this.label_3 = new Label();
			this.textBox_0 = new TextBox();
			this.dataGridViewCheckBoxColumn_20 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_19 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_18 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_17 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_16 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_15 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_14 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_13 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_12 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_11 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_10 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_9 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_8 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_7 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_6 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_5 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_4 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_3 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn_21 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_105 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_106 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_107 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_108 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_109 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_100 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_101 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_102 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_103 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_104 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_95 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_96 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_97 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_98 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_99 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_90 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_91 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_92 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_93 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_94 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_85 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_86 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_87 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_88 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_89 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_80 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_81 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_82 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_83 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_84 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_75 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_76 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_77 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_78 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_79 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_70 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_71 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_72 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_73 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_74 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_65 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_66 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_67 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_68 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_69 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_60 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_61 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_62 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_63 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_64 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_55 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_56 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_57 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_58 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_59 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_53 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_54 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.tableLayoutPanel_0.SuspendLayout();
			this.tableLayoutPanel_1.SuspendLayout();
			this.toolStrip_0.SuspendLayout();
			this.tableLayoutPanel_2.SuspendLayout();
			((ISupportInitialize)this.numericUpDown_0).BeginInit();
			((ISupportInitialize)this.dsPassport_0).BeginInit();
			((ISupportInitialize)this.dataGridViewPassport_0).BeginInit();
			this.tableLayoutPanel_3.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 1;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.Controls.Add(this.tableLayoutPanel_1, 0, 5);
			this.tableLayoutPanel_0.Controls.Add(this.toolStrip_0, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.tableLayoutPanel_2, 0, 3);
			this.tableLayoutPanel_0.Controls.Add(this.dataGridViewPassport_0, 0, 4);
			this.tableLayoutPanel_0.Controls.Add(this.label_2, 0, 2);
			this.tableLayoutPanel_0.Controls.Add(this.tableLayoutPanel_3, 0, 1);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tlpParameter";
			this.tableLayoutPanel_0.RowCount = 6;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 26f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 33f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 30f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 35f));
			this.tableLayoutPanel_0.Size = new Size(395, 545);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.tableLayoutPanel_1.ColumnCount = 3;
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105f));
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98f));
			this.tableLayoutPanel_1.Controls.Add(this.button_0, 1, 0);
			this.tableLayoutPanel_1.Controls.Add(this.button_1, 2, 0);
			this.tableLayoutPanel_1.Dock = DockStyle.Fill;
			this.tableLayoutPanel_1.Location = new Point(3, 513);
			this.tableLayoutPanel_1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_1.RowCount = 1;
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_1.Size = new Size(389, 29);
			this.tableLayoutPanel_1.TabIndex = 0;
			this.button_0.Location = new Point(189, 3);
			this.button_0.Name = "btnSave";
			this.button_0.Size = new Size(99, 23);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "Сохранить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Location = new Point(294, 3);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 1;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripSplitButton_0,
				this.toolStripButton_0,
				this.toolStripButton_1
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "toolStrip1";
			this.toolStrip_0.Size = new Size(395, 25);
			this.toolStrip_0.TabIndex = 2;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripSplitButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_1
			});
			this.toolStripSplitButton_0.Image = Resources.ElementAdd;
			this.toolStripSplitButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripSplitButton_0.Name = "tssbAddParam";
			this.toolStripSplitButton_0.Size = new Size(32, 22);
			this.toolStripSplitButton_0.Text = "Добавить параметр";
			this.toolStripSplitButton_0.ButtonClick += this.toolStripMenuItem_1_Click;
			this.toolStripMenuItem_0.Name = "tssbAddGroup";
			this.toolStripMenuItem_0.Size = new Size(182, 22);
			this.toolStripMenuItem_0.Text = "Добавить группу";
			this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
			this.toolStripMenuItem_1.Name = "tssbAddParameter";
			this.toolStripMenuItem_1.Size = new Size(182, 22);
			this.toolStripMenuItem_1.Text = "Добавить параметр";
			this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.ElementEdit;
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "tssbEdit";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Редактировать параметр";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.ElementDel;
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "tssbDelete";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Удалить параметр";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.tableLayoutPanel_2.ColumnCount = 5;
			this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle());
			this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle());
			this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle());
			this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle());
			this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_2.Controls.Add(this.label_0, 2, 0);
			this.tableLayoutPanel_2.Controls.Add(this.dateTimePicker_0, 3, 0);
			this.tableLayoutPanel_2.Controls.Add(this.label_1, 0, 0);
			this.tableLayoutPanel_2.Controls.Add(this.numericUpDown_0, 1, 0);
			this.tableLayoutPanel_2.Dock = DockStyle.Fill;
			this.tableLayoutPanel_2.Location = new Point(3, 87);
			this.tableLayoutPanel_2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel_2.RowCount = 1;
			this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_2.Size = new Size(389, 24);
			this.tableLayoutPanel_2.TabIndex = 3;
			this.label_0.AutoSize = true;
			this.label_0.Dock = DockStyle.Fill;
			this.label_0.Location = new Point(163, 0);
			this.label_0.Margin = new Padding(10, 0, 3, 0);
			this.label_0.Name = "label2";
			this.label_0.Size = new Size(33, 24);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "Дата";
			this.label_0.TextAlign = ContentAlignment.MiddleRight;
			this.dateTimePicker_0.Dock = DockStyle.Fill;
			this.dateTimePicker_0.Location = new Point(202, 3);
			this.dateTimePicker_0.Name = "dtpDate";
			this.dateTimePicker_0.Size = new Size(143, 20);
			this.dateTimePicker_0.TabIndex = 3;
			this.label_1.AutoSize = true;
			this.label_1.Dock = DockStyle.Fill;
			this.label_1.Location = new Point(3, 0);
			this.label_1.Name = "label1";
			this.label_1.Size = new Size(41, 24);
			this.label_1.TabIndex = 4;
			this.label_1.Text = "Номер";
			this.label_1.TextAlign = ContentAlignment.MiddleLeft;
			this.numericUpDown_0.DataBindings.Add(new Binding("Value", this.dsPassport_0, "tP_Passport.Number", true));
			this.numericUpDown_0.Dock = DockStyle.Fill;
			this.numericUpDown_0.Location = new Point(50, 3);
			NumericUpDown numericUpDown = this.numericUpDown_0;
			int[] array = new int[4];
			array[0] = 100000000;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDown_0.Name = "nUpDwnPassportNum";
			this.numericUpDown_0.Size = new Size(100, 20);
			this.numericUpDown_0.TabIndex = 6;
			this.dsPassport_0.DataSetName = "dsPassport";
			this.dsPassport_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.dataGridViewPassport_0.AllowUserToAddRows = false;
			this.dataGridViewPassport_0.AllowUserToDeleteRows = false;
			this.dataGridViewPassport_0.AllowUserToResizeColumns = false;
			this.dataGridViewPassport_0.AllowUserToResizeRows = false;
			this.dataGridViewPassport_0.BackgroundColor = Color.White;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridViewPassport_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewPassport_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.White;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = Color.White;
			dataGridViewCellStyle2.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.dataGridViewPassport_0.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewPassport_0.Dock = DockStyle.Fill;
			this.dataGridViewPassport_0.DragDropComplite = false;
			this.dataGridViewPassport_0.EditMode = DataGridViewEditMode.EditOnEnter;
			this.dataGridViewPassport_0.Location = new Point(3, 117);
			this.dataGridViewPassport_0.MultiSelect = false;
			this.dataGridViewPassport_0.Name = "DataGridViewPassport1";
			this.dataGridViewPassport_0.RowHeadersVisible = false;
			this.dataGridViewPassport_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewPassport_0.Size = new Size(389, 390);
			this.dataGridViewPassport_0.TabIndex = 4;
			this.dataGridViewPassport_0.GroupChanging += this.dataGridViewPassport_0_GroupChanging;
			this.dataGridViewPassport_0.GroupChanged += this.dataGridViewPassport_0_GroupChanged;
			this.dataGridViewPassport_0.DragDrop += this.dataGridViewPassport_0_DragDrop;
			this.dataGridViewTextBoxColumn_110.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_110.Name = "dataGridViewTextBoxColumn111";
			this.dataGridViewTextBoxColumn_110.ReadOnly = true;
			this.dataGridViewTextBoxColumn_110.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_110.Visible = false;
			this.dataGridViewTextBoxColumn_111.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_111.Name = "dataGridViewTextBoxColumn112";
			this.dataGridViewTextBoxColumn_111.ReadOnly = true;
			this.dataGridViewTextBoxColumn_111.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_111.Visible = false;
			this.dataGridViewTextBoxColumn_112.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_112.Name = "dataGridViewTextBoxColumn113";
			this.dataGridViewTextBoxColumn_112.ReadOnly = true;
			this.dataGridViewTextBoxColumn_112.Visible = false;
			this.dataGridViewCheckBoxColumn_22.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_22.Name = "dataGridViewCheckBoxColumn23";
			this.dataGridViewCheckBoxColumn_22.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_22.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_22.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_22.Visible = false;
			this.dataGridViewTextBoxColumn_113.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_113.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_113.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_113.Name = "dataGridViewTextBoxColumn114";
			this.dataGridViewTextBoxColumn_113.ReadOnly = true;
			this.dataGridViewTextBoxColumn_113.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_113.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_113.Width = 5;
			this.dataGridViewTextBoxColumn_114.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_114.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_114.Name = "dataGridViewTextBoxColumn115";
			this.dataGridViewTextBoxColumn_114.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_114.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.label_2.AutoSize = true;
			this.label_2.Dock = DockStyle.Fill;
			this.label_2.Location = new Point(6, 59);
			this.label_2.Margin = new Padding(6, 0, 3, 0);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(386, 25);
			this.label_2.TabIndex = 5;
			this.label_2.Text = "Паспортные данные:";
			this.label_2.TextAlign = ContentAlignment.MiddleLeft;
			this.tableLayoutPanel_3.ColumnCount = 3;
			this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle());
			this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle());
			this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_3.Controls.Add(this.label_3, 0, 0);
			this.tableLayoutPanel_3.Controls.Add(this.textBox_0, 1, 0);
			this.tableLayoutPanel_3.Dock = DockStyle.Fill;
			this.tableLayoutPanel_3.Location = new Point(3, 29);
			this.tableLayoutPanel_3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel_3.RowCount = 1;
			this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_3.Size = new Size(389, 27);
			this.tableLayoutPanel_3.TabIndex = 6;
			this.label_3.AutoSize = true;
			this.label_3.Dock = DockStyle.Fill;
			this.label_3.Location = new Point(3, 0);
			this.label_3.Name = "label4";
			this.label_3.Size = new Size(83, 27);
			this.label_3.TabIndex = 0;
			this.label_3.Text = "Наименование";
			this.label_3.TextAlign = ContentAlignment.MiddleLeft;
			this.textBox_0.DataBindings.Add(new Binding("Text", this.dsPassport_0, "tSchm_ObjList.Name", true));
			this.textBox_0.Dock = DockStyle.Fill;
			this.textBox_0.Location = new Point(92, 3);
			this.textBox_0.Name = "txtObjName";
			this.textBox_0.ReadOnly = true;
			this.textBox_0.Size = new Size(130, 20);
			this.textBox_0.TabIndex = 1;
			this.dataGridViewCheckBoxColumn_20.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_20.Name = "dataGridViewCheckBoxColumn21";
			this.dataGridViewCheckBoxColumn_20.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_20.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_20.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_20.Visible = false;
			this.dataGridViewCheckBoxColumn_19.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_19.Name = "dataGridViewCheckBoxColumn20";
			this.dataGridViewCheckBoxColumn_19.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_19.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_19.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_19.Visible = false;
			this.dataGridViewCheckBoxColumn_18.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_18.Name = "dataGridViewCheckBoxColumn19";
			this.dataGridViewCheckBoxColumn_18.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_18.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_18.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_18.Visible = false;
			this.dataGridViewCheckBoxColumn_17.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_17.Name = "dataGridViewCheckBoxColumn18";
			this.dataGridViewCheckBoxColumn_17.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_17.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_17.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_17.Visible = false;
			this.dataGridViewCheckBoxColumn_16.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_16.Name = "dataGridViewCheckBoxColumn17";
			this.dataGridViewCheckBoxColumn_16.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_16.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_16.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_16.Visible = false;
			this.dataGridViewCheckBoxColumn_15.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_15.Name = "dataGridViewCheckBoxColumn16";
			this.dataGridViewCheckBoxColumn_15.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_15.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_15.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_15.Visible = false;
			this.dataGridViewCheckBoxColumn_14.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_14.Name = "dataGridViewCheckBoxColumn15";
			this.dataGridViewCheckBoxColumn_14.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_14.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_14.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_14.Visible = false;
			this.dataGridViewCheckBoxColumn_13.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_13.Name = "dataGridViewCheckBoxColumn14";
			this.dataGridViewCheckBoxColumn_13.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_13.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_13.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_13.Visible = false;
			this.dataGridViewCheckBoxColumn_12.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_12.Name = "dataGridViewCheckBoxColumn13";
			this.dataGridViewCheckBoxColumn_12.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_12.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_12.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_12.Visible = false;
			this.dataGridViewCheckBoxColumn_11.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_11.Name = "dataGridViewCheckBoxColumn12";
			this.dataGridViewCheckBoxColumn_11.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_11.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_11.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_11.Visible = false;
			this.dataGridViewCheckBoxColumn_10.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_10.Name = "dataGridViewCheckBoxColumn11";
			this.dataGridViewCheckBoxColumn_10.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_10.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_10.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_10.Visible = false;
			this.dataGridViewCheckBoxColumn_9.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_9.Name = "dataGridViewCheckBoxColumn10";
			this.dataGridViewCheckBoxColumn_9.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_9.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_9.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_9.Visible = false;
			this.dataGridViewCheckBoxColumn_8.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_8.Name = "dataGridViewCheckBoxColumn9";
			this.dataGridViewCheckBoxColumn_8.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_8.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_8.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_8.Visible = false;
			this.dataGridViewCheckBoxColumn_7.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_7.Name = "dataGridViewCheckBoxColumn8";
			this.dataGridViewCheckBoxColumn_7.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_7.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_7.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_7.Visible = false;
			this.dataGridViewCheckBoxColumn_6.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_6.Name = "dataGridViewCheckBoxColumn7";
			this.dataGridViewCheckBoxColumn_6.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_6.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_6.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_6.Visible = false;
			this.dataGridViewCheckBoxColumn_5.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_5.Name = "dataGridViewCheckBoxColumn6";
			this.dataGridViewCheckBoxColumn_5.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_5.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_5.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_5.Visible = false;
			this.dataGridViewCheckBoxColumn_4.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_4.Name = "dataGridViewCheckBoxColumn5";
			this.dataGridViewCheckBoxColumn_4.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_4.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_4.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_4.Visible = false;
			this.dataGridViewCheckBoxColumn_3.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_3.Name = "dataGridViewCheckBoxColumn4";
			this.dataGridViewCheckBoxColumn_3.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_3.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_3.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_3.Visible = false;
			this.dataGridViewCheckBoxColumn_2.HeaderText = "dataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn_2.Name = "dataGridViewCheckBoxColumn3";
			this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_2.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_2.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_2.Visible = false;
			this.dataGridViewCheckBoxColumn_1.HeaderText = "IsGroupChar";
			this.dataGridViewCheckBoxColumn_1.Name = "dataGridViewCheckBoxColumn2";
			this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_1.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_1.Visible = false;
			this.dataGridViewCheckBoxColumn_0.DataPropertyName = "isGroup";
			this.dataGridViewCheckBoxColumn_0.HeaderText = "IsGroupChar";
			this.dataGridViewCheckBoxColumn_0.Name = "dataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_1.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_1.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "TabIndex";
			this.dataGridViewTextBoxColumn_2.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Visible = false;
			this.dataGridViewCheckBoxColumn_21.HeaderText = "isGroupChar";
			this.dataGridViewCheckBoxColumn_21.Name = "dataGridViewCheckBoxColumn22";
			this.dataGridViewCheckBoxColumn_21.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_21.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_21.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_21.Visible = false;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_3.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_3.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_3.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "Value";
			this.dataGridViewTextBoxColumn_4.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_4.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_4.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_105.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_105.Name = "dataGridViewTextBoxColumn106";
			this.dataGridViewTextBoxColumn_105.ReadOnly = true;
			this.dataGridViewTextBoxColumn_105.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_105.Visible = false;
			this.dataGridViewTextBoxColumn_106.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_106.Name = "dataGridViewTextBoxColumn107";
			this.dataGridViewTextBoxColumn_106.ReadOnly = true;
			this.dataGridViewTextBoxColumn_106.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_106.Visible = false;
			this.dataGridViewTextBoxColumn_107.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_107.Name = "dataGridViewTextBoxColumn108";
			this.dataGridViewTextBoxColumn_107.ReadOnly = true;
			this.dataGridViewTextBoxColumn_107.Visible = false;
			this.dataGridViewTextBoxColumn_108.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_108.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_108.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_108.Name = "dataGridViewTextBoxColumn109";
			this.dataGridViewTextBoxColumn_108.ReadOnly = true;
			this.dataGridViewTextBoxColumn_108.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_108.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_109.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_109.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_109.Name = "dataGridViewTextBoxColumn110";
			this.dataGridViewTextBoxColumn_109.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_109.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_100.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_100.Name = "dataGridViewTextBoxColumn101";
			this.dataGridViewTextBoxColumn_100.ReadOnly = true;
			this.dataGridViewTextBoxColumn_100.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_100.Visible = false;
			this.dataGridViewTextBoxColumn_101.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_101.Name = "dataGridViewTextBoxColumn102";
			this.dataGridViewTextBoxColumn_101.ReadOnly = true;
			this.dataGridViewTextBoxColumn_101.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_101.Visible = false;
			this.dataGridViewTextBoxColumn_102.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_102.Name = "dataGridViewTextBoxColumn103";
			this.dataGridViewTextBoxColumn_102.ReadOnly = true;
			this.dataGridViewTextBoxColumn_102.Visible = false;
			this.dataGridViewTextBoxColumn_103.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_103.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_103.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_103.Name = "dataGridViewTextBoxColumn104";
			this.dataGridViewTextBoxColumn_103.ReadOnly = true;
			this.dataGridViewTextBoxColumn_103.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_103.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_104.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_104.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_104.Name = "dataGridViewTextBoxColumn105";
			this.dataGridViewTextBoxColumn_104.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_104.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_95.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_95.Name = "dataGridViewTextBoxColumn96";
			this.dataGridViewTextBoxColumn_95.ReadOnly = true;
			this.dataGridViewTextBoxColumn_95.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_95.Visible = false;
			this.dataGridViewTextBoxColumn_96.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_96.Name = "dataGridViewTextBoxColumn97";
			this.dataGridViewTextBoxColumn_96.ReadOnly = true;
			this.dataGridViewTextBoxColumn_96.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_96.Visible = false;
			this.dataGridViewTextBoxColumn_97.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_97.Name = "dataGridViewTextBoxColumn98";
			this.dataGridViewTextBoxColumn_97.ReadOnly = true;
			this.dataGridViewTextBoxColumn_97.Visible = false;
			this.dataGridViewTextBoxColumn_98.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_98.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_98.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_98.Name = "dataGridViewTextBoxColumn99";
			this.dataGridViewTextBoxColumn_98.ReadOnly = true;
			this.dataGridViewTextBoxColumn_98.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_98.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_99.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_99.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_99.Name = "dataGridViewTextBoxColumn100";
			this.dataGridViewTextBoxColumn_99.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_99.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_90.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_90.Name = "dataGridViewTextBoxColumn91";
			this.dataGridViewTextBoxColumn_90.ReadOnly = true;
			this.dataGridViewTextBoxColumn_90.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_90.Visible = false;
			this.dataGridViewTextBoxColumn_91.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_91.Name = "dataGridViewTextBoxColumn92";
			this.dataGridViewTextBoxColumn_91.ReadOnly = true;
			this.dataGridViewTextBoxColumn_91.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_91.Visible = false;
			this.dataGridViewTextBoxColumn_92.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_92.Name = "dataGridViewTextBoxColumn93";
			this.dataGridViewTextBoxColumn_92.ReadOnly = true;
			this.dataGridViewTextBoxColumn_92.Visible = false;
			this.dataGridViewTextBoxColumn_93.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_93.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_93.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_93.Name = "dataGridViewTextBoxColumn94";
			this.dataGridViewTextBoxColumn_93.ReadOnly = true;
			this.dataGridViewTextBoxColumn_93.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_93.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_94.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_94.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_94.Name = "dataGridViewTextBoxColumn95";
			this.dataGridViewTextBoxColumn_94.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_94.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_85.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_85.Name = "dataGridViewTextBoxColumn86";
			this.dataGridViewTextBoxColumn_85.ReadOnly = true;
			this.dataGridViewTextBoxColumn_85.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_85.Visible = false;
			this.dataGridViewTextBoxColumn_86.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_86.Name = "dataGridViewTextBoxColumn87";
			this.dataGridViewTextBoxColumn_86.ReadOnly = true;
			this.dataGridViewTextBoxColumn_86.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_86.Visible = false;
			this.dataGridViewTextBoxColumn_87.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_87.Name = "dataGridViewTextBoxColumn88";
			this.dataGridViewTextBoxColumn_87.ReadOnly = true;
			this.dataGridViewTextBoxColumn_87.Visible = false;
			this.dataGridViewTextBoxColumn_88.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_88.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_88.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_88.Name = "dataGridViewTextBoxColumn89";
			this.dataGridViewTextBoxColumn_88.ReadOnly = true;
			this.dataGridViewTextBoxColumn_88.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_88.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_89.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_89.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_89.Name = "dataGridViewTextBoxColumn90";
			this.dataGridViewTextBoxColumn_89.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_89.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_80.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_80.Name = "dataGridViewTextBoxColumn81";
			this.dataGridViewTextBoxColumn_80.ReadOnly = true;
			this.dataGridViewTextBoxColumn_80.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_80.Visible = false;
			this.dataGridViewTextBoxColumn_81.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_81.Name = "dataGridViewTextBoxColumn82";
			this.dataGridViewTextBoxColumn_81.ReadOnly = true;
			this.dataGridViewTextBoxColumn_81.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_81.Visible = false;
			this.dataGridViewTextBoxColumn_82.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_82.Name = "dataGridViewTextBoxColumn83";
			this.dataGridViewTextBoxColumn_82.ReadOnly = true;
			this.dataGridViewTextBoxColumn_82.Visible = false;
			this.dataGridViewTextBoxColumn_83.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_83.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_83.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_83.Name = "dataGridViewTextBoxColumn84";
			this.dataGridViewTextBoxColumn_83.ReadOnly = true;
			this.dataGridViewTextBoxColumn_83.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_83.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_84.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_84.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_84.Name = "dataGridViewTextBoxColumn85";
			this.dataGridViewTextBoxColumn_84.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_84.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_75.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_75.Name = "dataGridViewTextBoxColumn76";
			this.dataGridViewTextBoxColumn_75.ReadOnly = true;
			this.dataGridViewTextBoxColumn_75.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_75.Visible = false;
			this.dataGridViewTextBoxColumn_76.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_76.Name = "dataGridViewTextBoxColumn77";
			this.dataGridViewTextBoxColumn_76.ReadOnly = true;
			this.dataGridViewTextBoxColumn_76.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_76.Visible = false;
			this.dataGridViewTextBoxColumn_77.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_77.Name = "dataGridViewTextBoxColumn78";
			this.dataGridViewTextBoxColumn_77.ReadOnly = true;
			this.dataGridViewTextBoxColumn_77.Visible = false;
			this.dataGridViewTextBoxColumn_78.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_78.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_78.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_78.Name = "dataGridViewTextBoxColumn79";
			this.dataGridViewTextBoxColumn_78.ReadOnly = true;
			this.dataGridViewTextBoxColumn_78.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_78.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_79.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_79.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_79.Name = "dataGridViewTextBoxColumn80";
			this.dataGridViewTextBoxColumn_79.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_79.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_70.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_70.Name = "dataGridViewTextBoxColumn71";
			this.dataGridViewTextBoxColumn_70.ReadOnly = true;
			this.dataGridViewTextBoxColumn_70.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_70.Visible = false;
			this.dataGridViewTextBoxColumn_71.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_71.Name = "dataGridViewTextBoxColumn72";
			this.dataGridViewTextBoxColumn_71.ReadOnly = true;
			this.dataGridViewTextBoxColumn_71.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_71.Visible = false;
			this.dataGridViewTextBoxColumn_72.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_72.Name = "dataGridViewTextBoxColumn73";
			this.dataGridViewTextBoxColumn_72.ReadOnly = true;
			this.dataGridViewTextBoxColumn_72.Visible = false;
			this.dataGridViewTextBoxColumn_73.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_73.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_73.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_73.Name = "dataGridViewTextBoxColumn74";
			this.dataGridViewTextBoxColumn_73.ReadOnly = true;
			this.dataGridViewTextBoxColumn_73.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_73.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_74.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_74.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_74.Name = "dataGridViewTextBoxColumn75";
			this.dataGridViewTextBoxColumn_74.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_74.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_65.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_65.Name = "dataGridViewTextBoxColumn66";
			this.dataGridViewTextBoxColumn_65.ReadOnly = true;
			this.dataGridViewTextBoxColumn_65.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_65.Visible = false;
			this.dataGridViewTextBoxColumn_66.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_66.Name = "dataGridViewTextBoxColumn67";
			this.dataGridViewTextBoxColumn_66.ReadOnly = true;
			this.dataGridViewTextBoxColumn_66.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_66.Visible = false;
			this.dataGridViewTextBoxColumn_67.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_67.Name = "dataGridViewTextBoxColumn68";
			this.dataGridViewTextBoxColumn_67.ReadOnly = true;
			this.dataGridViewTextBoxColumn_67.Visible = false;
			this.dataGridViewTextBoxColumn_68.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_68.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_68.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_68.Name = "dataGridViewTextBoxColumn69";
			this.dataGridViewTextBoxColumn_68.ReadOnly = true;
			this.dataGridViewTextBoxColumn_68.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_68.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_69.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_69.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_69.Name = "dataGridViewTextBoxColumn70";
			this.dataGridViewTextBoxColumn_69.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_69.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_60.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_60.Name = "dataGridViewTextBoxColumn61";
			this.dataGridViewTextBoxColumn_60.ReadOnly = true;
			this.dataGridViewTextBoxColumn_60.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_60.Visible = false;
			this.dataGridViewTextBoxColumn_61.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_61.Name = "dataGridViewTextBoxColumn62";
			this.dataGridViewTextBoxColumn_61.ReadOnly = true;
			this.dataGridViewTextBoxColumn_61.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_61.Visible = false;
			this.dataGridViewTextBoxColumn_62.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_62.Name = "dataGridViewTextBoxColumn63";
			this.dataGridViewTextBoxColumn_62.ReadOnly = true;
			this.dataGridViewTextBoxColumn_62.Visible = false;
			this.dataGridViewTextBoxColumn_63.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_63.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_63.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_63.Name = "dataGridViewTextBoxColumn64";
			this.dataGridViewTextBoxColumn_63.ReadOnly = true;
			this.dataGridViewTextBoxColumn_63.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_63.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_64.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_64.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_64.Name = "dataGridViewTextBoxColumn65";
			this.dataGridViewTextBoxColumn_64.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_64.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_55.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_55.Name = "dataGridViewTextBoxColumn56";
			this.dataGridViewTextBoxColumn_55.ReadOnly = true;
			this.dataGridViewTextBoxColumn_55.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_55.Visible = false;
			this.dataGridViewTextBoxColumn_56.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_56.Name = "dataGridViewTextBoxColumn57";
			this.dataGridViewTextBoxColumn_56.ReadOnly = true;
			this.dataGridViewTextBoxColumn_56.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_56.Visible = false;
			this.dataGridViewTextBoxColumn_57.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_57.Name = "dataGridViewTextBoxColumn58";
			this.dataGridViewTextBoxColumn_57.ReadOnly = true;
			this.dataGridViewTextBoxColumn_57.Visible = false;
			this.dataGridViewTextBoxColumn_58.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_58.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_58.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_58.Name = "dataGridViewTextBoxColumn59";
			this.dataGridViewTextBoxColumn_58.ReadOnly = true;
			this.dataGridViewTextBoxColumn_58.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_58.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_59.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_59.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_59.Name = "dataGridViewTextBoxColumn60";
			this.dataGridViewTextBoxColumn_59.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_59.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_50.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_50.Name = "dataGridViewTextBoxColumn51";
			this.dataGridViewTextBoxColumn_50.ReadOnly = true;
			this.dataGridViewTextBoxColumn_50.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_50.Visible = false;
			this.dataGridViewTextBoxColumn_51.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_51.Name = "dataGridViewTextBoxColumn52";
			this.dataGridViewTextBoxColumn_51.ReadOnly = true;
			this.dataGridViewTextBoxColumn_51.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_51.Visible = false;
			this.dataGridViewTextBoxColumn_52.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_52.Name = "dataGridViewTextBoxColumn53";
			this.dataGridViewTextBoxColumn_52.ReadOnly = true;
			this.dataGridViewTextBoxColumn_52.Visible = false;
			this.dataGridViewTextBoxColumn_53.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_53.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_53.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_53.Name = "dataGridViewTextBoxColumn54";
			this.dataGridViewTextBoxColumn_53.ReadOnly = true;
			this.dataGridViewTextBoxColumn_53.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_53.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_54.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_54.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_54.Name = "dataGridViewTextBoxColumn55";
			this.dataGridViewTextBoxColumn_54.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_54.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_45.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_45.Name = "dataGridViewTextBoxColumn46";
			this.dataGridViewTextBoxColumn_45.ReadOnly = true;
			this.dataGridViewTextBoxColumn_45.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_45.Visible = false;
			this.dataGridViewTextBoxColumn_46.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_46.Name = "dataGridViewTextBoxColumn47";
			this.dataGridViewTextBoxColumn_46.ReadOnly = true;
			this.dataGridViewTextBoxColumn_46.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_46.Visible = false;
			this.dataGridViewTextBoxColumn_47.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_47.Name = "dataGridViewTextBoxColumn48";
			this.dataGridViewTextBoxColumn_47.ReadOnly = true;
			this.dataGridViewTextBoxColumn_47.Visible = false;
			this.dataGridViewTextBoxColumn_48.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.dataGridViewTextBoxColumn_48.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_48.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_48.Name = "dataGridViewTextBoxColumn49";
			this.dataGridViewTextBoxColumn_48.ReadOnly = true;
			this.dataGridViewTextBoxColumn_48.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_48.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_49.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_49.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_49.Name = "dataGridViewTextBoxColumn50";
			this.dataGridViewTextBoxColumn_49.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_49.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_40.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_40.Name = "dataGridViewTextBoxColumn41";
			this.dataGridViewTextBoxColumn_40.ReadOnly = true;
			this.dataGridViewTextBoxColumn_40.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_40.Visible = false;
			this.dataGridViewTextBoxColumn_41.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_41.Name = "dataGridViewTextBoxColumn42";
			this.dataGridViewTextBoxColumn_41.ReadOnly = true;
			this.dataGridViewTextBoxColumn_41.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_41.Visible = false;
			this.dataGridViewTextBoxColumn_42.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_42.Name = "dataGridViewTextBoxColumn43";
			this.dataGridViewTextBoxColumn_42.ReadOnly = true;
			this.dataGridViewTextBoxColumn_42.Visible = false;
			this.dataGridViewTextBoxColumn_43.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_43.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_43.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_43.Name = "dataGridViewTextBoxColumn44";
			this.dataGridViewTextBoxColumn_43.ReadOnly = true;
			this.dataGridViewTextBoxColumn_43.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_43.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_44.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_44.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_44.Name = "dataGridViewTextBoxColumn45";
			this.dataGridViewTextBoxColumn_44.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_44.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_35.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_35.Name = "dataGridViewTextBoxColumn36";
			this.dataGridViewTextBoxColumn_35.ReadOnly = true;
			this.dataGridViewTextBoxColumn_35.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_35.Visible = false;
			this.dataGridViewTextBoxColumn_36.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_36.Name = "dataGridViewTextBoxColumn37";
			this.dataGridViewTextBoxColumn_36.ReadOnly = true;
			this.dataGridViewTextBoxColumn_36.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_36.Visible = false;
			this.dataGridViewTextBoxColumn_37.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_37.Name = "dataGridViewTextBoxColumn38";
			this.dataGridViewTextBoxColumn_37.ReadOnly = true;
			this.dataGridViewTextBoxColumn_37.Visible = false;
			this.dataGridViewTextBoxColumn_38.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_38.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_38.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_38.Name = "dataGridViewTextBoxColumn39";
			this.dataGridViewTextBoxColumn_38.ReadOnly = true;
			this.dataGridViewTextBoxColumn_38.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_38.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_39.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_39.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_39.Name = "dataGridViewTextBoxColumn40";
			this.dataGridViewTextBoxColumn_39.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_39.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_30.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_30.Name = "dataGridViewTextBoxColumn31";
			this.dataGridViewTextBoxColumn_30.ReadOnly = true;
			this.dataGridViewTextBoxColumn_30.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_30.Visible = false;
			this.dataGridViewTextBoxColumn_31.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_31.Name = "dataGridViewTextBoxColumn32";
			this.dataGridViewTextBoxColumn_31.ReadOnly = true;
			this.dataGridViewTextBoxColumn_31.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_31.Visible = false;
			this.dataGridViewTextBoxColumn_32.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_32.Name = "dataGridViewTextBoxColumn33";
			this.dataGridViewTextBoxColumn_32.ReadOnly = true;
			this.dataGridViewTextBoxColumn_32.Visible = false;
			this.dataGridViewTextBoxColumn_33.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_33.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_33.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_33.Name = "dataGridViewTextBoxColumn34";
			this.dataGridViewTextBoxColumn_33.ReadOnly = true;
			this.dataGridViewTextBoxColumn_33.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_33.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_34.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_34.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_34.Name = "dataGridViewTextBoxColumn35";
			this.dataGridViewTextBoxColumn_34.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_34.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_25.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_25.Name = "dataGridViewTextBoxColumn26";
			this.dataGridViewTextBoxColumn_25.ReadOnly = true;
			this.dataGridViewTextBoxColumn_25.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_25.Visible = false;
			this.dataGridViewTextBoxColumn_26.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_26.Name = "dataGridViewTextBoxColumn27";
			this.dataGridViewTextBoxColumn_26.ReadOnly = true;
			this.dataGridViewTextBoxColumn_26.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_26.Visible = false;
			this.dataGridViewTextBoxColumn_27.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_27.Name = "dataGridViewTextBoxColumn28";
			this.dataGridViewTextBoxColumn_27.ReadOnly = true;
			this.dataGridViewTextBoxColumn_27.Visible = false;
			this.dataGridViewTextBoxColumn_28.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_28.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_28.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_28.Name = "dataGridViewTextBoxColumn29";
			this.dataGridViewTextBoxColumn_28.ReadOnly = true;
			this.dataGridViewTextBoxColumn_28.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_28.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_29.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_29.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_29.Name = "dataGridViewTextBoxColumn30";
			this.dataGridViewTextBoxColumn_29.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_29.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_20.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_20.Name = "dataGridViewTextBoxColumn21";
			this.dataGridViewTextBoxColumn_20.ReadOnly = true;
			this.dataGridViewTextBoxColumn_20.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_20.Visible = false;
			this.dataGridViewTextBoxColumn_21.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_21.Name = "dataGridViewTextBoxColumn22";
			this.dataGridViewTextBoxColumn_21.ReadOnly = true;
			this.dataGridViewTextBoxColumn_21.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_21.Visible = false;
			this.dataGridViewTextBoxColumn_22.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_22.Name = "dataGridViewTextBoxColumn23";
			this.dataGridViewTextBoxColumn_22.ReadOnly = true;
			this.dataGridViewTextBoxColumn_22.Visible = false;
			this.dataGridViewTextBoxColumn_23.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_23.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_23.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_23.Name = "dataGridViewTextBoxColumn24";
			this.dataGridViewTextBoxColumn_23.ReadOnly = true;
			this.dataGridViewTextBoxColumn_23.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_23.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_24.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_24.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_24.Name = "dataGridViewTextBoxColumn25";
			this.dataGridViewTextBoxColumn_24.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_24.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_15.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_15.Name = "dataGridViewTextBoxColumn16";
			this.dataGridViewTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewTextBoxColumn_15.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_15.Visible = false;
			this.dataGridViewTextBoxColumn_16.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_16.Name = "dataGridViewTextBoxColumn17";
			this.dataGridViewTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewTextBoxColumn_16.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_16.Visible = false;
			this.dataGridViewTextBoxColumn_17.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_17.Name = "dataGridViewTextBoxColumn18";
			this.dataGridViewTextBoxColumn_17.ReadOnly = true;
			this.dataGridViewTextBoxColumn_17.Visible = false;
			this.dataGridViewTextBoxColumn_18.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_18.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_18.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_18.Name = "dataGridViewTextBoxColumn19";
			this.dataGridViewTextBoxColumn_18.ReadOnly = true;
			this.dataGridViewTextBoxColumn_18.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_18.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_19.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_19.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_19.Name = "dataGridViewTextBoxColumn20";
			this.dataGridViewTextBoxColumn_19.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_19.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_10.HeaderText = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_10.Visible = false;
			this.dataGridViewTextBoxColumn_11.HeaderText = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_11.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_11.Visible = false;
			this.dataGridViewTextBoxColumn_12.HeaderText = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_12.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.Visible = false;
			this.dataGridViewTextBoxColumn_13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_13.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_13.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_13.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_13.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_14.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_14.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_14.Name = "dataGridViewTextBoxColumn15";
			this.dataGridViewTextBoxColumn_14.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_14.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_5.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewTextBoxColumn_6.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.dataGridViewTextBoxColumn_7.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.dataGridViewTextBoxColumn_8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_8.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_8.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_8.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_9.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn_9.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_9.SortMode = DataGridViewColumnSortMode.Programmatic;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(395, 545);
			base.Controls.Add(this.tableLayoutPanel_0);
			this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			base.Name = "FormAddEditValuePassportChars";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "FormAddEditParameter";
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_0.PerformLayout();
			this.tableLayoutPanel_1.ResumeLayout(false);
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.tableLayoutPanel_2.ResumeLayout(false);
			this.tableLayoutPanel_2.PerformLayout();
			((ISupportInitialize)this.numericUpDown_0).EndInit();
			((ISupportInitialize)this.dsPassport_0).EndInit();
			((ISupportInitialize)this.dataGridViewPassport_0).EndInit();
			this.tableLayoutPanel_3.ResumeLayout(false);
			this.tableLayoutPanel_3.PerformLayout();
			base.ResumeLayout(false);
		}

		private int int_0;

		private int int_1;

		private StateFormCreate stateFormCreate_0;

		private int int_2;

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private TableLayoutPanel tableLayoutPanel_1;

		private Button button_0;

		private Button button_1;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private ToolStripSplitButton toolStripSplitButton_0;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripMenuItem toolStripMenuItem_1;

		private TableLayoutPanel tableLayoutPanel_2;

		private Label label_0;

		private DateTimePicker dateTimePicker_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private dsPassport dsPassport_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;

		private DataGridViewPassport dataGridViewPassport_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_53;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_54;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_55;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_56;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_57;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_58;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_59;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_60;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_61;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_62;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_63;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_64;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_65;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_66;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_67;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_68;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_69;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_70;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_71;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_72;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_73;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_74;

		private Label label_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_75;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_76;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_77;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_15;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_78;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_79;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_80;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_81;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_82;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_16;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_83;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_84;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_85;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_86;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_87;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_17;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_88;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_89;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_90;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_91;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_92;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_18;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_93;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_94;

		private Label label_2;

		private TableLayoutPanel tableLayoutPanel_3;

		private Label label_3;

		private TextBox textBox_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_95;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_96;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_97;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_19;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_98;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_99;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_100;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_101;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_102;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_20;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_103;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_104;

		private NumericUpDown numericUpDown_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_105;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_106;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_107;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_21;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_108;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_109;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_110;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_111;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_112;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_22;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_113;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_114;
	}
}
