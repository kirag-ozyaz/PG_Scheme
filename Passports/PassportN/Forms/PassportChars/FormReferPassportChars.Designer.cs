using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using Passport.Classes;
using Passport.Controls;
using Passport.Properties;
using WinFormsUI.Docking;

namespace Passport.Forms.PassportChars
{
	public class FormReferPassportChars : DockContentBase
	{
		public FormReferPassportChars()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_11();
		}

		public FormReferPassportChars(SQLSettings SqlSettings, TypeCharacteristic type)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_11();
			this.SqlSettings = SqlSettings;
			this.dataGridViewPassport_0.SqlSettings = SqlSettings;
			this.typeCharacteristic_0 = type;
			this.dataGridViewPassport_0.ValueVisible = false;
			this.dataGridViewPassport_0.EnableDragDrop = true;
			this.dataGridViewPassport_0.DragDropComplite = true;
			this.Text = this.method_0(type);
			this.dataGridViewPassport_0.Columns["NameChar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}

		private string method_0(TypeCharacteristic typeCharacteristic_1)
		{
			if (typeCharacteristic_1 == TypeCharacteristic.Passport)
			{
				return "Характеристики оборудования";
			}
			if (typeCharacteristic_1 == TypeCharacteristic.Reference)
			{
				return "Характеристики справочника оборудования";
			}
			return "";
		}

		private string method_1(TypeCharacteristic typeCharacteristic_1)
		{
			if (typeCharacteristic_1 == TypeCharacteristic.Passport)
			{
				return ";EquipChar;Passp;";
			}
			if (typeCharacteristic_1 == TypeCharacteristic.Reference)
			{
				return ";EquipChar;Refer;";
			}
			return "";
		}

		private void FormReferPassportChars_Shown(object sender, EventArgs e)
		{
			this.method_2();
			this.method_3();
			this.toolStripMenuItem_1.Enabled = (this.dataGridView_0.RowCount > 0);
			if (this.dataGridViewPassport_0.Rows.Count == 0)
			{
				this.method_4(false);
				return;
			}
			this.method_4(true);
		}

		private void method_2()
		{
			base.SelectSqlDataTableOther(this.class107_0, this.class107_0.tP_CharListRefer, "tP_CharList", true, "where ParentKey like '" + this.method_1(this.typeCharacteristic_0) + "%' and dbo.CharCount(';', ParentKey) = 4 and Deleted = ((0))");
			this.dataGridView_0.DataSource = this.class107_0.tP_CharListRefer;
		}

		private void method_3()
		{
			DataTable dataSource = base.SelectSqlData("tR_Classifier", true, "WHERE (ParentKey LIKE ';SCM;PS;%' OR ParentKey LIKE ';SCM;BUS;%' OR ParentKey LIKE ';SCM;LINE;%' OR ParentKey = ';SCM;Clutch;' OR ParentKey = ';SCM;INLINE_OBJ;SWITCH;' OR ParentKey LIKE ';SCM;Cell;%' OR ParentKey = ';SCM;INLINE_OBJ;FUSE;' OR ParentKey = ';SCM;SwGear;' OR ParentKey = ';SCM;Pole;' OR ParentKey = ';SCM;INLINE_OBJ;OTHER_OBJ;') AND IsGroup = 0 ORDER BY ParentKey, Name");
			this.pyumnfpDiby.DataSource = dataSource;
			this.pyumnfpDiby.DisplayMember = "Name";
			this.pyumnfpDiby.ValueMember = "Id";
		}

		private void toolStripMenuItem_9_Click(object sender, EventArgs e)
		{
			this.dataGridViewPassport_0.EditCharacteristic();
		}

		private void wbsmnUuFes2_Click(object sender, EventArgs e)
		{
			this.dataGridViewPassport_0.DeleteCharacteristic();
		}

		private void toolStripMenuItem_8_Click(object sender, EventArgs e)
		{
			this.dataGridViewPassport_0.AddCharacteristic();
		}

		private void toolStripMenuItem_7_Click(object sender, EventArgs e)
		{
			this.dataGridViewPassport_0.AddGroupCharacteristic();
		}

		private void dataGridView_0_SelectionChanged(object sender, EventArgs e)
		{
			if (this.dataGridView_0.SelectedRows != null && this.dataGridViewPassport_0.SelectedRows.GetType() != typeof(DataGridViewRow) && this.dataGridView_0.SelectedRows.Count > 0)
			{
				this.dataGridViewPassport_0.Rows.Clear();
				this.dataGridViewPassport_0.AddParameterRows(this.SqlSettings, this.dataGridView_0.SelectedRows[0].Cells["ParentKeyEquipment"].Value.ToString());
				if (this.dataGridViewPassport_0.Rows.Count == 0)
				{
					this.method_4(false);
					return;
				}
				this.method_4(true);
			}
		}

		private void method_4(bool bool_0)
		{
			this.toolStripSplitButton_0.Enabled = bool_0;
			this.toolStripButton_1.Enabled = bool_0;
			this.toolStripButton_0.Enabled = bool_0;
		}

		private void iiYzrdAvhO(object sender, GroupChangeEventArgs e)
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

		private void dataGridViewPassport_0_DragDrop(object sender, DragEventArgs e)
		{
			this.dataGridViewPassport_0.DragDropComplite = true;
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void pyumnfpDiby_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.pyumnfpDiby.SelectedValue != null && this.pyumnfpDiby.SelectedValue.GetType() == typeof(int))
			{
				this.method_5((int)this.pyumnfpDiby.SelectedValue);
			}
		}

		private void method_5(int int_0)
		{
			if ((int)this.pyumnfpDiby.SelectedValue != -1)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.tP_ObjClassParamList, true, "WHERE IdClassifier = " + int_0.ToString() + " AND Deleted = ((0))");
				if (this.class107_0.tP_ObjClassParamList.Rows.Count > 0)
				{
					int num = (int)this.class107_0.tP_ObjClassParamList.Rows[0]["idParamList"];
					using (IEnumerator enumerator = ((IEnumerable)this.dataGridView_0.Rows).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							if ((int)dataGridViewRow.Cells["idEquipment"].Value == num)
							{
								dataGridViewRow.Selected = true;
							}
						}
						return;
					}
				}
				if (this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count > 0)
				{
					this.dataGridView_0.SelectedRows[0].Selected = false;
				}
				MessageBox.Show("С выбранным типом объекта схемы не связан ни один тип характеристик оборудования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			this.dataGridView_0.SelectedRows[0].Selected = false;
		}

		private void method_6(int int_0)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_ObjClassParamList, true, "WHERE IdParamList = " + int_0.ToString() + " AND Deleted = ((0))");
			if (this.class107_0.tP_ObjClassParamList.Rows.Count > 0)
			{
				this.pyumnfpDiby.SelectedValue = this.class107_0.tP_ObjClassParamList.Rows[0]["idClassifier"];
				return;
			}
			this.pyumnfpDiby.SelectedValue = -1;
		}

		private void method_7(int int_0, int int_1)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_ObjClassParamList, true, "WHERE idClassifier = " + int_0.ToString() + " AND Deleted = ((0))");
			if (this.class107_0.tP_ObjClassParamList.Rows.Count > 0)
			{
				((Class107.Class246)this.class107_0.tP_ObjClassParamList.Rows[0]).idParamList = int_1;
				base.UpdateSqlData(this.class107_0, this.class107_0.tP_ObjClassParamList);
				return;
			}
			Class107.Class246 @class = this.class107_0.tP_ObjClassParamList.method_5();
			@class.idClassifier = int_0;
			@class.idParamList = int_1;
			@class.Deleted = false;
			this.class107_0.tP_ObjClassParamList.method_0(@class);
			base.InsertSqlData(this.class107_0, this.class107_0.tP_ObjClassParamList);
		}

		private void method_8(int int_0, int int_1)
		{
			if (MessageBox.Show("Вы действительно хотите удалить привязку оборудования с его характеристиками?", "Удаление привязки", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				base.SelectSqlData(this.class107_0, this.class107_0.tP_ObjClassParamList, true, string.Concat(new string[]
				{
					"WHERE idClassifier = ",
					int_0.ToString(),
					" AND idParamList = ",
					int_1.ToString(),
					" AND Deleted = ((0))"
				}));
				if (this.class107_0.tP_ObjClassParamList.Rows.Count > 0)
				{
					((Class107.Class246)this.class107_0.tP_ObjClassParamList.Rows[0]).Deleted = true;
					base.UpdateSqlData(this.class107_0, this.class107_0.tP_ObjClassParamList);
					this.method_5((int)this.pyumnfpDiby.SelectedValue);
				}
			}
		}

		private void NidzSwHysU(object sender, EventArgs e)
		{
			if (this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count >= 1)
			{
				this.method_7((int)this.pyumnfpDiby.SelectedValue, (int)this.dataGridView_0.SelectedRows[0].Cells["idEquipment"].Value);
				return;
			}
			MessageBox.Show("Выберите наименование характеристик.", "Внимание.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			this.dataGridView_0.Focus();
		}

		private void button_2_Click(object sender, EventArgs e)
		{
			this.method_8((int)this.pyumnfpDiby.SelectedValue, (int)this.dataGridView_0.SelectedRows[0].Cells["idEquipment"].Value);
		}

		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			FormAddEditNaimEquipmentChars formAddEditNaimEquipmentChars = new FormAddEditNaimEquipmentChars(this.SqlSettings);
			if (formAddEditNaimEquipmentChars.ShowDialog() == DialogResult.OK)
			{
				this.method_2();
				if (formAddEditNaimEquipmentChars.Id > 0)
				{
					this.method_9(this.dataGridView_0, "idEquipment", formAddEditNaimEquipmentChars.Id);
				}
			}
		}

		private void method_9(DataGridView dataGridView_1, string string_0, object object_0)
		{
			foreach (object obj in ((IEnumerable)dataGridView_1.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if (dataGridViewRow.Cells[string_0].Value == object_0)
				{
					dataGridViewRow.Selected = true;
					break;
				}
			}
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewPassport_0.Focus() && this.dataGridViewPassport_0.SelectedRows != null && this.dataGridViewPassport_0.SelectedRows.Count > 0)
			{
				this.dataGridViewPassport_0.EditCharacteristic();
			}
		}

		private void method_10(int int_0)
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_CharList, true, "Where id = " + int_0.ToString());
			if (this.class107_0.tP_CharList.Rows.Count > 0)
			{
				this.class107_0.tP_CharList.Rows[0]["Deleted"] = true;
			}
			if (base.UpdateSqlData(this.class107_0, this.class107_0.tP_CharList))
			{
				this.method_2();
			}
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewPassport_0.SelectedRows != null && this.dataGridViewPassport_0.SelectedRows.Count > 0 && this.dataGridViewPassport_0.Focus() && MessageBox.Show(((bool)this.dataGridViewPassport_0.Rows[0].Cells["isGroupChars"].Value) ? ("Вы действительно хотите удалить группу характеристик \"" + this.dataGridView_0.SelectedRows[0].Cells["NameEquipment"].Value.ToString() + "\"?") : ("Вы действительно хотите удалить характеристику \"" + this.dataGridView_0.SelectedRows[0].Cells["NameEquipment"].Value.ToString() + "\"?"), "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.dataGridViewPassport_0.DeleteCharacteristic();
			}
		}

		private void toolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count > 0)
			{
				FormAddEditNaimEquipmentChars formAddEditNaimEquipmentChars = new FormAddEditNaimEquipmentChars(this.SqlSettings, (int)this.dataGridView_0.SelectedRows[0].Cells["idEquipment"].Value);
				if (formAddEditNaimEquipmentChars.ShowDialog() == DialogResult.OK)
				{
					this.method_2();
					if (formAddEditNaimEquipmentChars.Id > 0)
					{
						this.method_9(this.dataGridView_0, "idEquipment", formAddEditNaimEquipmentChars.Id);
					}
				}
			}
		}

		private void toolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			FormAddEditNaimEquipmentChars formAddEditNaimEquipmentChars = new FormAddEditNaimEquipmentChars(this.SqlSettings);
			if (formAddEditNaimEquipmentChars.ShowDialog() == DialogResult.OK)
			{
				this.method_2();
				if (formAddEditNaimEquipmentChars.Id > 0)
				{
					this.method_9(this.dataGridView_0, "idEquipment", formAddEditNaimEquipmentChars.Id);
				}
			}
		}

		private void toolStripMenuItem_5_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы действительно хотите удалить наименование характеристик \"" + this.dataGridView_0.SelectedRows[0].Cells["NameEquipment"].Value.ToString() + "\"?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && this.dataGridView_0.SelectedRows != null && this.dataGridView_0.SelectedRows.Count > 0)
			{
				this.method_10((int)this.dataGridView_0.SelectedRows[0].Cells["idEquipment"].Value);
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_11()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.KdXmnGipGaX = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_3 = new ToolStripMenuItem();
			this.toolStripMenuItem_4 = new ToolStripMenuItem();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripMenuItem_5 = new ToolStripMenuItem();
			this.tableLayoutPanel_1 = new TableLayoutPanel();
			this.button_0 = new Button();
			this.dataGridViewPassport_0 = new DataGridViewPassport();
			this.panel_0 = new Panel();
			this.pyumnfpDiby = new ComboBox();
			this.label_0 = new Label();
			this.button_1 = new Button();
			this.button_2 = new Button();
			this.class107_0 = new Class107();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripSplitButton_0 = new ToolStripSplitButton();
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolStripMenuItem_2 = new ToolStripMenuItem();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.xQimnrAqggC = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_6 = new ToolStripMenuItem();
			this.toolStripMenuItem_7 = new ToolStripMenuItem();
			this.toolStripMenuItem_8 = new ToolStripMenuItem();
			this.toolStripMenuItem_9 = new ToolStripMenuItem();
			this.toolStripSeparator_1 = new ToolStripSeparator();
			this.wbsmnUuFes2 = new ToolStripMenuItem();
			this.tableLayoutPanel_0.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			this.contextMenuStrip_0.SuspendLayout();
			this.tableLayoutPanel_1.SuspendLayout();
			((ISupportInitialize)this.dataGridViewPassport_0).BeginInit();
			this.panel_0.SuspendLayout();
			((ISupportInitialize)this.class107_0).BeginInit();
			this.toolStrip_0.SuspendLayout();
			this.xQimnrAqggC.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 3;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.72052f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.0005f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.27898f));
			this.tableLayoutPanel_0.Controls.Add(this.dataGridView_0, 0, 3);
			this.tableLayoutPanel_0.Controls.Add(this.tableLayoutPanel_1, 2, 4);
			this.tableLayoutPanel_0.Controls.Add(this.dataGridViewPassport_0, 2, 1);
			this.tableLayoutPanel_0.Controls.Add(this.panel_0, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.button_1, 0, 2);
			this.tableLayoutPanel_0.Controls.Add(this.button_2, 1, 2);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 5;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 0f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 59f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 28f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 38f));
			this.tableLayoutPanel_0.Size = new Size(609, 518);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.BackgroundColor = Color.White;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5,
				this.KdXmnGipGaX,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewTextBoxColumn_8,
				this.dataGridViewTextBoxColumn_9,
				this.dataGridViewTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_11,
				this.dataGridViewTextBoxColumn_12
			});
			this.tableLayoutPanel_0.SetColumnSpan(this.dataGridView_0, 2);
			this.dataGridView_0.ContextMenuStrip = this.contextMenuStrip_0;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.White;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = Color.White;
			dataGridViewCellStyle2.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_0.Dock = DockStyle.Fill;
			this.dataGridView_0.Location = new Point(3, 90);
			this.dataGridView_0.MultiSelect = false;
			this.dataGridView_0.Name = "dgvEquipment";
			this.dataGridView_0.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_0.RowHeadersVisible = false;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(241, 387);
			this.dataGridView_0.TabIndex = 0;
			this.dataGridView_0.SelectionChanged += this.dataGridView_0_SelectionChanged;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "idEquipment";
			this.dataGridViewTextBoxColumn_0.Name = "idEquipment";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "ParentId";
			this.dataGridViewTextBoxColumn_1.HeaderText = "ParentIdEquipment";
			this.dataGridViewTextBoxColumn_1.Name = "ParentIdEquipment";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "ParentKey";
			this.dataGridViewTextBoxColumn_2.HeaderText = "ParentKeyEquipment";
			this.dataGridViewTextBoxColumn_2.Name = "ParentKeyEquipment";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_3.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_3.Name = "NameEquipment";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "ShortName";
			this.dataGridViewTextBoxColumn_4.HeaderText = "ShortNameEquipment";
			this.dataGridViewTextBoxColumn_4.Name = "ShortNameEquipment";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "Type";
			this.dataGridViewTextBoxColumn_5.HeaderText = "TypeEquipment";
			this.dataGridViewTextBoxColumn_5.Name = "TypeEquipment";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.KdXmnGipGaX.DataPropertyName = "Format";
			this.KdXmnGipGaX.HeaderText = "FormatEquipment";
			this.KdXmnGipGaX.Name = "FormatEquipment";
			this.KdXmnGipGaX.ReadOnly = true;
			this.KdXmnGipGaX.Visible = false;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "idValueList";
			this.dataGridViewTextBoxColumn_6.HeaderText = "idValueListEquipment";
			this.dataGridViewTextBoxColumn_6.Name = "idValueListEquipment";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "TableName";
			this.dataGridViewTextBoxColumn_7.HeaderText = "TableNameEquipment";
			this.dataGridViewTextBoxColumn_7.Name = "TableNameEquipment";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "TabIndex";
			this.dataGridViewTextBoxColumn_8.HeaderText = "TabIndexEquipment";
			this.dataGridViewTextBoxColumn_8.Name = "TabIndexEquipment";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_9.HeaderText = "CommentEquipment";
			this.dataGridViewTextBoxColumn_9.Name = "CommentEquipment";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.Visible = false;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "isGroup";
			this.dataGridViewTextBoxColumn_10.HeaderText = "isGroupEquipment";
			this.dataGridViewTextBoxColumn_10.Name = "isGroupEquipment";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.Visible = false;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "Panel";
			this.dataGridViewTextBoxColumn_11.HeaderText = "PanelEquipment";
			this.dataGridViewTextBoxColumn_11.Name = "PanelEquipment";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.Visible = false;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "Deleted";
			this.dataGridViewTextBoxColumn_12.HeaderText = "DeletedEquipment";
			this.dataGridViewTextBoxColumn_12.Name = "DeletedEquipment";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.Visible = false;
			this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_3,
				this.toolStripMenuItem_4,
				this.toolStripSeparator_0,
				this.toolStripMenuItem_5
			});
			this.contextMenuStrip_0.Name = "cmsEquipment";
			this.contextMenuStrip_0.Size = new Size(155, 76);
			this.toolStripMenuItem_3.Image = Resources.smethod_24();
			this.toolStripMenuItem_3.Name = "добавитьToolStripMenuItem";
			this.toolStripMenuItem_3.Size = new Size(154, 22);
			this.toolStripMenuItem_3.Text = "Добавить";
			this.toolStripMenuItem_3.Click += this.toolStripMenuItem_3_Click;
			this.toolStripMenuItem_4.Image = Resources.smethod_26();
			this.toolStripMenuItem_4.Name = "редактироватьToolStripMenuItem";
			this.toolStripMenuItem_4.Size = new Size(154, 22);
			this.toolStripMenuItem_4.Text = "Редактировать";
			this.toolStripMenuItem_4.Click += this.toolStripMenuItem_4_Click;
			this.toolStripSeparator_0.Name = "toolStripSeparator1";
			this.toolStripSeparator_0.Size = new Size(151, 6);
			this.toolStripMenuItem_5.Image = Resources.smethod_25();
			this.toolStripMenuItem_5.Name = "удалитьToolStripMenuItem";
			this.toolStripMenuItem_5.Size = new Size(154, 22);
			this.toolStripMenuItem_5.Text = "Удалить";
			this.toolStripMenuItem_5.Click += this.toolStripMenuItem_5_Click;
			this.tableLayoutPanel_1.ColumnCount = 4;
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.18182f));
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.81818f));
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 144f));
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 107f));
			this.tableLayoutPanel_1.Controls.Add(this.button_0, 3, 0);
			this.tableLayoutPanel_1.Dock = DockStyle.Fill;
			this.tableLayoutPanel_1.Location = new Point(250, 483);
			this.tableLayoutPanel_1.Name = "tableLayoutPanel2";
			this.tableLayoutPanel_1.RowCount = 1;
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_1.Size = new Size(356, 32);
			this.tableLayoutPanel_1.TabIndex = 2;
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Dock = DockStyle.Fill;
			this.button_0.Location = new Point(251, 3);
			this.button_0.Margin = new Padding(3, 3, 20, 3);
			this.button_0.Name = "btnClose";
			this.button_0.Size = new Size(85, 26);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "Закрыть";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.dataGridViewPassport_0.AllowUserToAddRows = false;
			this.dataGridViewPassport_0.AllowUserToDeleteRows = false;
			this.dataGridViewPassport_0.AllowUserToResizeColumns = false;
			this.dataGridViewPassport_0.AllowUserToResizeRows = false;
			this.dataGridViewPassport_0.BackgroundColor = Color.White;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = SystemColors.Control;
			dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			this.dataGridViewPassport_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewPassport_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = Color.White;
			dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle5.ForeColor = Color.Black;
			dataGridViewCellStyle5.SelectionBackColor = Color.White;
			dataGridViewCellStyle5.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
			this.dataGridViewPassport_0.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewPassport_0.Dock = DockStyle.Fill;
			this.dataGridViewPassport_0.DragDropComplite = false;
			this.dataGridViewPassport_0.EditMode = DataGridViewEditMode.EditOnEnter;
			this.dataGridViewPassport_0.Location = new Point(250, 3);
			this.dataGridViewPassport_0.MultiSelect = false;
			this.dataGridViewPassport_0.Name = "dgvChars";
			this.dataGridViewPassport_0.RowHeadersVisible = false;
			this.tableLayoutPanel_0.SetRowSpan(this.dataGridViewPassport_0, 3);
			this.dataGridViewPassport_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewPassport_0.Size = new Size(356, 474);
			this.dataGridViewPassport_0.TabIndex = 1;
			this.dataGridViewPassport_0.GroupChanging += this.iiYzrdAvhO;
			this.dataGridViewPassport_0.DragDrop += this.dataGridViewPassport_0_DragDrop;
			this.tableLayoutPanel_0.SetColumnSpan(this.panel_0, 2);
			this.panel_0.Controls.Add(this.pyumnfpDiby);
			this.panel_0.Controls.Add(this.label_0);
			this.panel_0.Dock = DockStyle.Fill;
			this.panel_0.Location = new Point(3, 3);
			this.panel_0.Name = "panel1";
			this.panel_0.Size = new Size(241, 53);
			this.panel_0.TabIndex = 3;
			this.pyumnfpDiby.Dock = DockStyle.Bottom;
			this.pyumnfpDiby.DropDownStyle = ComboBoxStyle.DropDownList;
			this.pyumnfpDiby.FormattingEnabled = true;
			this.pyumnfpDiby.Location = new Point(0, 32);
			this.pyumnfpDiby.Name = "cbObjListType";
			this.pyumnfpDiby.Size = new Size(241, 21);
			this.pyumnfpDiby.TabIndex = 1;
			this.pyumnfpDiby.SelectedValueChanged += this.pyumnfpDiby_SelectedValueChanged;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(3, 13);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(84, 13);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "Объект схемы:";
			this.button_1.Dock = DockStyle.Fill;
			this.button_1.Location = new Point(3, 62);
			this.button_1.Name = "btnSaveBinding";
			this.button_1.Size = new Size(120, 22);
			this.button_1.TabIndex = 4;
			this.button_1.Text = "Привязать";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.NidzSwHysU;
			this.button_2.Dock = DockStyle.Fill;
			this.button_2.Location = new Point(129, 62);
			this.button_2.Name = "btnDelBinding";
			this.button_2.Size = new Size(115, 22);
			this.button_2.TabIndex = 5;
			this.button_2.Text = "Отвязать";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.dataGridViewCheckBoxColumn_0.HeaderText = "isGoupChar";
			this.dataGridViewCheckBoxColumn_0.Name = "isGoupChar";
			this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewCheckBoxColumn_0.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewCheckBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_13.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn_13.Name = "idChar";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_13.Visible = false;
			this.dataGridViewTextBoxColumn_14.HeaderText = "ParentIdChar";
			this.dataGridViewTextBoxColumn_14.Name = "ParentIdChar";
			this.dataGridViewTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewTextBoxColumn_14.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_14.Visible = false;
			this.dataGridViewTextBoxColumn_15.HeaderText = "TabIndexChar";
			this.dataGridViewTextBoxColumn_15.Name = "TabIndexChar";
			this.dataGridViewTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewTextBoxColumn_16.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_16.FillWeight = 150f;
			this.dataGridViewTextBoxColumn_16.HeaderText = "Характеристика";
			this.dataGridViewTextBoxColumn_16.Name = "NameChar";
			this.dataGridViewTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewTextBoxColumn_16.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_16.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.dataGridViewTextBoxColumn_17.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_17.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_17.Name = "ValueChar";
			this.dataGridViewTextBoxColumn_17.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_17.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripSplitButton_0,
				this.toolStripButton_0,
				this.toolStripButton_1
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "toolStrip1";
			this.toolStrip_0.Size = new Size(609, 25);
			this.toolStrip_0.TabIndex = 1;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStrip_0.Visible = false;
			this.toolStripSplitButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_1,
				this.toolStripMenuItem_2
			});
			this.toolStripSplitButton_0.Image = Resources.smethod_24();
			this.toolStripSplitButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripSplitButton_0.Name = "tssbAddParameter";
			this.toolStripSplitButton_0.Size = new Size(32, 22);
			this.toolStripSplitButton_0.Text = "Добавить характеристику";
			this.toolStripMenuItem_0.Name = "tssbNaim";
			this.toolStripMenuItem_0.Size = new Size(292, 22);
			this.toolStripMenuItem_0.Text = "Добавить наименование характеристик";
			this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
			this.toolStripMenuItem_1.Name = "tssbAddGroup";
			this.toolStripMenuItem_1.Size = new Size(292, 22);
			this.toolStripMenuItem_1.Text = "Добавить группу";
			this.toolStripMenuItem_1.ToolTipText = "Добавить группу";
			this.toolStripMenuItem_1.Click += this.toolStripMenuItem_7_Click;
			this.toolStripMenuItem_2.Name = "добавитьХарактериытикуToolStripMenuItem";
			this.toolStripMenuItem_2.Size = new Size(292, 22);
			this.toolStripMenuItem_2.Text = "Добавить характериcтику";
			this.toolStripMenuItem_2.ToolTipText = "Добавить характериcтику";
			this.toolStripMenuItem_2.Click += this.toolStripMenuItem_8_Click;
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.smethod_26();
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "tssbEdit";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Редактировать";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.smethod_25();
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "tssbDelete";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Удалить";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.xQimnrAqggC.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_6,
				this.toolStripMenuItem_9,
				this.toolStripSeparator_1,
				this.wbsmnUuFes2
			});
			this.xQimnrAqggC.Name = "cmsChars";
			this.xQimnrAqggC.Size = new Size(155, 76);
			this.toolStripMenuItem_6.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_7,
				this.toolStripMenuItem_8
			});
			this.toolStripMenuItem_6.Image = Resources.smethod_24();
			this.toolStripMenuItem_6.Name = "AddChars";
			this.toolStripMenuItem_6.Size = new Size(154, 22);
			this.toolStripMenuItem_6.Text = "Добавить";
			this.toolStripMenuItem_7.Name = "tsmiAddCharsCroup";
			this.toolStripMenuItem_7.Size = new Size(161, 22);
			this.toolStripMenuItem_7.Text = "Группу";
			this.toolStripMenuItem_7.Click += this.toolStripMenuItem_7_Click;
			this.toolStripMenuItem_8.Name = "tsmiAddChars";
			this.toolStripMenuItem_8.Size = new Size(161, 22);
			this.toolStripMenuItem_8.Text = "Характеристику";
			this.toolStripMenuItem_8.Click += this.toolStripMenuItem_8_Click;
			this.toolStripMenuItem_9.Image = Resources.smethod_26();
			this.toolStripMenuItem_9.Name = "tsmiEditChars";
			this.toolStripMenuItem_9.Size = new Size(154, 22);
			this.toolStripMenuItem_9.Text = "Редактировать";
			this.toolStripMenuItem_9.Click += this.toolStripMenuItem_9_Click;
			this.toolStripSeparator_1.Name = "toolStripSeparator2";
			this.toolStripSeparator_1.Size = new Size(151, 6);
			this.wbsmnUuFes2.Image = Resources.smethod_25();
			this.wbsmnUuFes2.Name = "tsmiDeleteChars";
			this.wbsmnUuFes2.Size = new Size(154, 22);
			this.wbsmnUuFes2.Text = "Удалить";
			this.wbsmnUuFes2.Click += this.wbsmnUuFes2_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_0;
			base.ClientSize = new Size(609, 518);
			base.Controls.Add(this.toolStrip_0);
			base.Controls.Add(this.tableLayoutPanel_0);
			this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			base.Name = "FormReferPassportChars";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Характеристики паспортов";
			base.Shown += this.FormReferPassportChars_Shown;
			this.tableLayoutPanel_0.ResumeLayout(false);
			((ISupportInitialize)this.dataGridView_0).EndInit();
			this.contextMenuStrip_0.ResumeLayout(false);
			this.tableLayoutPanel_1.ResumeLayout(false);
			((ISupportInitialize)this.dataGridViewPassport_0).EndInit();
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			((ISupportInitialize)this.class107_0).EndInit();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.xQimnrAqggC.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private TypeCharacteristic typeCharacteristic_0;

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private DataGridView dataGridView_0;

		private DataGridViewPassport dataGridViewPassport_0;

		private TableLayoutPanel tableLayoutPanel_1;

		private Button button_0;

		private Class107 class107_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn KdXmnGipGaX;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		private Panel panel_0;

		private ComboBox pyumnfpDiby;

		private Label label_0;

		private ToolStrip toolStrip_0;

		private ToolStripSplitButton toolStripSplitButton_0;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripMenuItem toolStripMenuItem_1;

		private ToolStripMenuItem toolStripMenuItem_2;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private ContextMenuStrip contextMenuStrip_0;

		private ToolStripMenuItem toolStripMenuItem_3;

		private ToolStripMenuItem toolStripMenuItem_4;

		private ToolStripSeparator toolStripSeparator_0;

		private ToolStripMenuItem toolStripMenuItem_5;

		private ContextMenuStrip xQimnrAqggC;

		private ToolStripMenuItem toolStripMenuItem_6;

		private ToolStripMenuItem toolStripMenuItem_7;

		private ToolStripMenuItem toolStripMenuItem_8;

		private ToolStripMenuItem toolStripMenuItem_9;

		private ToolStripSeparator toolStripSeparator_1;

		private ToolStripMenuItem wbsmnUuFes2;

		private Button button_1;

		private Button button_2;
	}
}
