using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Constants;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Properties;

namespace SchemeCtrl2.Canvas.Forms
{
	public partial class FormCanvasAddDelFilter : FormBase
	{
		public FormCanvasAddDelFilter()
		{
			
			this.stringBuilder_0 = new StringBuilder();
			
			this.method_1();
		}

		public FormCanvasAddDelFilter(List<DrawObjectBase> listObj, StateFormCreate stateForm)
		{
			
			this.stringBuilder_0 = new StringBuilder();
			
			this.method_1();
			foreach (DrawObjectBase drawObjectBase in listObj)
			{
				this.stringBuilder_0.Append(drawObjectBase.IdBase.ToString() + ",");
			}
			if (this.stringBuilder_0.Length > 0)
			{
				this.stringBuilder_0.Remove(this.stringBuilder_0.Length - 1, 1);
			}
			this.stateFormCreate_0 = stateForm;
			if (stateForm == StateFormCreate.Delete)
			{
				this.Text = "Удаление фильтров";
				this.button_1.Text = "Удалить";
			}
		}

		private void FormCanvasAddDelFilter_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class22_0, this.class22_0.tR_Classifier, true, " where [ParentKey] = ';SCM;FilterName;' and [IsGroup] = 0 and [deleted] = 0 order by name");
			if (this.stringBuilder_0.Length > 0)
			{
				base.SelectSqlData(this.class22_0, this.class22_0.vSchm_ObjList, true, " where id in (" + this.stringBuilder_0.ToString() + ") order by [typecode], [name]");
			}
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			if (new FormCanvasAddFilterName
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class22_0, this.class22_0.tR_Classifier, true, " where [ParentKey] = ';SCM;FilterName;' and [IsGroup] = 0 and [deleted] = 0 order by name");
			}
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			if (this.dataGridView_0.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить выделенные фильтры?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				foreach (object obj in this.dataGridView_0.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					base.DeleteSqlDataById(this.class22_0.tR_Classifier, Convert.ToInt32(dataGridViewRow.Cells["idDgvTxtColumn"].Value));
					this.dataGridView_0.Rows.Remove(dataGridViewRow);
				}
			}
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			foreach (object obj in ((IEnumerable)this.dataGridView_0.Rows))
			{
				((DataGridViewRow)obj).Cells["ColumnCheck"].Value = true;
			}
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			this.toolStrip_0.Enabled = false;
			this.dataGridView_0.Enabled = false;
			this.EijLatowoK.Enabled = false;
			this.checkBox_0.Enabled = false;
			this.button_1.Enabled = false;
			this.button_0.Enabled = false;
			this.label_2.Visible = true;
			this.progressBar_0.Visible = true;
			this.backgroundWorker_0.RunWorkerAsync();
		}

		private List<int> method_0(List<int> list_0)
		{
			List<int> list = new List<int>();
			foreach (int num in list_0)
			{
				bool flag = false;
				base.SelectSqlData(this.class22_0, this.class22_0.tSchm_ObjList, true, " where id = " + num.ToString());
				if (this.class22_0.tSchm_ObjList.Rows.Count > 0)
				{
					using (IEnumerator enumerator2 = Enum.GetValues(typeof(LineToolType)).GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							if ((int)enumerator2.Current == Convert.ToInt32(this.class22_0.tSchm_ObjList.Rows[0]["TypeCodeId"]))
							{
								flag = true;
								break;
							}
						}
					}
				}
				if (flag)
				{
					base.SelectSqlData(this.class22_0, this.class22_0.tSchm_Relation, true, " where [Edge] = " + num.ToString());
					string text = "";
					foreach (object obj in this.class22_0.tSchm_Relation.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						text = text + dataRow["id"].ToString() + ",";
					}
					if (text.Length > 0)
					{
						text = text.Remove(text.Length - 1);
					}
					string text2 = "";
					foreach (object obj2 in Enum.GetValues(typeof(TypeSwitch)))
					{
						text2 = text2 + ((int)obj2).ToString() + ",";
					}
					if (text2.Length > 0)
					{
						text2 = text2.Remove(text2.Length - 1);
					}
					if (text2.Length > 0 && text.Length > 0)
					{
						base.SelectSqlData(this.class22_0, this.class22_0.tSchm_ObjList, true, string.Concat(new string[]
						{
							"where idParent in (",
							text,
							" )  and typeCodeId in (",
							text2,
							")"
						}));
					}
				}
				else
				{
					base.SelectSqlData(this.class22_0, this.class22_0.tSchm_ObjList, true, " where idParent = " + num.ToString());
				}
				foreach (object obj3 in this.class22_0.tSchm_ObjList.Rows)
				{
					DataRow dataRow2 = (DataRow)obj3;
					if (Convert.ToInt32(dataRow2["TypeCodeId"]) != 111)
					{
						list.Add(Convert.ToInt32(dataRow2["id"]));
					}
				}
			}
			if (list.Count == 0)
			{
				return list;
			}
			List<int> list2 = this.method_0(list);
			foreach (int item in list)
			{
				list2.Add(item);
			}
			return list2;
		}

		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			foreach (object obj in ((IEnumerable)this.dataGridView_0.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if (Convert.ToBoolean(dataGridViewRow.Cells["ColumnCheck"].Value))
				{
					list2.Add(Convert.ToInt32(dataGridViewRow.Cells["idDgvTxtColumn"].Value));
				}
			}
			if (list2.Count == 0)
			{
				MessageBox.Show("Не выбраны фильтры");
				return;
			}
			foreach (object obj2 in ((IEnumerable)this.EijLatowoK.Rows))
			{
				DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
				list.Add(Convert.ToInt32(dataGridViewRow2.Cells["idObjDgvTxtColumn"].Value));
			}
			if (this.checkBox_0.Checked)
			{
				List<int> list3 = this.method_0(list);
				int count = list3.Count;
				int num = 0;
				foreach (int item in list3)
				{
					list.Add(item);
					num++;
					this.backgroundWorker_0.ReportProgress((int)((float)num / (float)count * 100f), "Дочерние элементы");
				}
			}
			if (list.Count == 0)
			{
				MessageBox.Show("Не выбраны объекты");
				return;
			}
			if (this.stateFormCreate_0 == StateFormCreate.Add)
			{
				int num2 = list2.Count * list.Count;
				int num3 = 0;
				int num4 = 0;
				foreach (int num5 in list2)
				{
					foreach (int num6 in list)
					{
						DataRow dataRow = this.class22_0.tSchm_ObjFilter.NewRow();
						dataRow["idObj"] = num6;
						dataRow["idFilter"] = num5;
						this.class22_0.tSchm_ObjFilter.Rows.Add(dataRow);
						if (base.InsertSqlData(this.class22_0, this.class22_0.tSchm_ObjFilter))
						{
							num4++;
						}
						this.class22_0.tSchm_ObjFilter.Clear();
						num3++;
						this.backgroundWorker_0.ReportProgress((int)((float)num3 / (float)num2 * 100f), "Добавление в фильтр");
					}
				}
				MessageBox.Show(num4.ToString() + " объект(ов) успешно добавленны в выбранные фильтр(ы)");
				return;
			}
			bool flag = true;
			int num7 = list2.Count * list.Count;
			int num8 = 0;
			foreach (int num9 in list2)
			{
				foreach (int num10 in list)
				{
					if (!base.DeleteSqlDataWhere(this.class22_0.tSchm_ObjFilter, "where idObj = " + num10.ToString() + " and idFilter = " + num9.ToString()))
					{
						flag = false;
					}
					num8++;
					this.backgroundWorker_0.ReportProgress((int)((float)num8 / (float)num7 * 100f), "Удаление из фильтра");
				}
			}
			if (flag)
			{
				MessageBox.Show("Объекты успешно удалены из выбранных фильтр(ы)");
			}
		}

		private void backgroundWorker_0_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.progressBar_0.Value = e.ProgressPercentage;
			this.label_2.Text = e.UserState.ToString();
		}

		private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.toolStrip_0.Enabled = true;
			this.dataGridView_0.Enabled = true;
			this.EijLatowoK.Enabled = true;
			this.checkBox_0.Enabled = true;
			this.button_1.Enabled = true;
			this.button_0.Enabled = true;
			this.label_2.Visible = false;
			this.progressBar_0.Visible = false;
		}

		private void method_1()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.splitContainer_0 = new SplitContainer();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.class22_0 = new DataSetScheme();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripButton_2 = new ToolStripButton();
			this.panel_0 = new Panel();
			this.label_0 = new Label();
			this.EijLatowoK = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.panel_1 = new Panel();
			this.label_1 = new Label();
			this.panel_2 = new Panel();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.checkBox_0 = new CheckBox();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.backgroundWorker_0 = new BackgroundWorker();
			this.progressBar_0 = new ProgressBar();
			this.label_2 = new Label();
			this.splitContainer_0.Panel1.SuspendLayout();
			this.splitContainer_0.Panel2.SuspendLayout();
			this.splitContainer_0.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			((ISupportInitialize)this.class22_0).BeginInit();
			this.toolStrip_0.SuspendLayout();
			this.panel_0.SuspendLayout();
			((ISupportInitialize)this.EijLatowoK).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			this.panel_1.SuspendLayout();
			this.panel_2.SuspendLayout();
			base.SuspendLayout();
			this.splitContainer_0.Dock = DockStyle.Fill;
			this.splitContainer_0.Location = new Point(0, 0);
			this.splitContainer_0.Name = "splitContainer";
			this.splitContainer_0.Panel1.Controls.Add(this.dataGridView_0);
			this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_0);
			this.splitContainer_0.Panel1.Controls.Add(this.panel_0);
			this.splitContainer_0.Panel2.Controls.Add(this.EijLatowoK);
			this.splitContainer_0.Panel2.Controls.Add(this.panel_1);
			this.splitContainer_0.Panel2.Controls.Add(this.panel_2);
			this.splitContainer_0.Size = new Size(725, 378);
			this.splitContainer_0.SplitterDistance = 220;
			this.splitContainer_0.TabIndex = 0;
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.AllowUserToResizeColumns = false;
			this.dataGridView_0.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = Color.FromArgb(224, 224, 224);
			this.dataGridView_0.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_0.AutoGenerateColumns = false;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewCheckBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3
			});
			this.dataGridView_0.DataMember = "tR_Classifier";
			this.dataGridView_0.DataSource = this.class22_0;
			this.dataGridView_0.Dock = DockStyle.Fill;
			this.dataGridView_0.Location = new Point(0, 53);
			this.dataGridView_0.Name = "dgvFilterName";
			this.dataGridView_0.RowHeadersVisible = false;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(220, 325);
			this.dataGridView_0.TabIndex = 0;
			this.dataGridViewCheckBoxColumn_1.HeaderText = "Выбор";
			this.dataGridViewCheckBoxColumn_1.Name = "ColumnCheck";
			this.dataGridViewCheckBoxColumn_1.Width = 45;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn_2.HeaderText = "Id";
			this.dataGridViewTextBoxColumn_2.Name = "idDgvTxtColumn";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_3.HeaderText = "Имя фильтра";
			this.dataGridViewTextBoxColumn_3.Name = "nameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.class22_0.DataSetName = "DataSetScheme";
			this.class22_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripButton_1,
				this.toolStripSeparator_0,
				this.toolStripButton_2
			});
			this.toolStrip_0.Location = new Point(0, 28);
			this.toolStrip_0.Name = "toolStripFilterName";
			this.toolStrip_0.Size = new Size(220, 25);
			this.toolStrip_0.TabIndex = 3;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.ElementAdd;
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "toolStripButtonAddFilterName";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Добавить";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.ElementDel;
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "toolStripButtonDelFilterName";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Удалить";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.toolStripSeparator_0.Name = "toolStripSeparator1";
			this.toolStripSeparator_0.Size = new Size(6, 25);
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = Resources.check_all;
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "toolStripButtonCheckkAllFilterName";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "Выделить все";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.panel_0.Controls.Add(this.label_0);
			this.panel_0.Dock = DockStyle.Top;
			this.panel_0.Location = new Point(0, 0);
			this.panel_0.Name = "panel1";
			this.panel_0.Size = new Size(220, 28);
			this.panel_0.TabIndex = 2;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(6, 8);
			this.label_0.Name = "labelNameFilter";
			this.label_0.Size = new Size(135, 13);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "Наименования фильтров";
			this.EijLatowoK.AllowUserToAddRows = false;
			this.EijLatowoK.AllowUserToDeleteRows = false;
			dataGridViewCellStyle2.BackColor = Color.Silver;
			this.EijLatowoK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
			this.EijLatowoK.AutoGenerateColumns = false;
			this.EijLatowoK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.EijLatowoK.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewFilterTextBoxColumn_0,
				this.dataGridViewFilterTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewCheckBoxColumn_2,
				this.dataGridViewTextBoxColumn_8
			});
			this.EijLatowoK.DataSource = this.bindingSource_0;
			this.EijLatowoK.Dock = DockStyle.Fill;
			this.EijLatowoK.Location = new Point(0, 28);
			this.EijLatowoK.Name = "dgvObjects";
			this.EijLatowoK.ReadOnly = true;
			this.EijLatowoK.RowHeadersWidth = 21;
			this.EijLatowoK.Size = new Size(501, 270);
			this.EijLatowoK.TabIndex = 1;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn_4.HeaderText = "Id";
			this.dataGridViewTextBoxColumn_4.Name = "idObjDgvTxtColumn";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "typecode";
			this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Тип объекта";
			this.dataGridViewFilterTextBoxColumn_0.Name = "typecodeDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_0.Width = 120;
			this.dataGridViewFilterTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "Name";
			this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Имя";
			this.dataGridViewFilterTextBoxColumn_1.Name = "nameDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "TypeCodeId";
			this.dataGridViewTextBoxColumn_5.HeaderText = "TypeCodeId";
			this.dataGridViewTextBoxColumn_5.Name = "typeCodeIdDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "typeCodeSocr";
			this.dataGridViewTextBoxColumn_6.HeaderText = "typeCodeSocr";
			this.dataGridViewTextBoxColumn_6.Name = "typeCodeSocrDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "IdParent";
			this.dataGridViewTextBoxColumn_7.HeaderText = "IdParent";
			this.dataGridViewTextBoxColumn_7.Name = "idParentDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.dataGridViewCheckBoxColumn_2.DataPropertyName = "OnOff";
			this.dataGridViewCheckBoxColumn_2.HeaderText = "OnOff";
			this.dataGridViewCheckBoxColumn_2.Name = "onOffDataGridViewCheckBoxColumn";
			this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "NameP";
			this.dataGridViewTextBoxColumn_8.HeaderText = "NameP";
			this.dataGridViewTextBoxColumn_8.Name = "namePDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			this.bindingSource_0.DataMember = "vSchm_ObjList";
			this.bindingSource_0.DataSource = this.class22_0;
			this.panel_1.Controls.Add(this.label_1);
			this.panel_1.Dock = DockStyle.Top;
			this.panel_1.Location = new Point(0, 0);
			this.panel_1.Name = "panel3";
			this.panel_1.Size = new Size(501, 28);
			this.panel_1.TabIndex = 3;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(14, 8);
			this.label_1.Name = "labelObjects";
			this.label_1.Size = new Size(53, 13);
			this.label_1.TabIndex = 0;
			this.label_1.Text = "Объекты";
			this.panel_2.Controls.Add(this.label_2);
			this.panel_2.Controls.Add(this.progressBar_0);
			this.panel_2.Controls.Add(this.button_0);
			this.panel_2.Controls.Add(this.button_1);
			this.panel_2.Controls.Add(this.checkBox_0);
			this.panel_2.Dock = DockStyle.Bottom;
			this.panel_2.Location = new Point(0, 298);
			this.panel_2.Name = "panel2";
			this.panel_2.Size = new Size(501, 80);
			this.panel_2.TabIndex = 2;
			this.button_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Location = new Point(414, 45);
			this.button_0.Name = "buttonCancel";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 2;
			this.button_0.Text = "Закрыть";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.button_1.Location = new Point(333, 45);
			this.button_1.Name = "buttonAdd";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 1;
			this.button_1.Text = "Добавить";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Location = new Point(17, 15);
			this.checkBox_0.Name = "checkBoxIncludingChildrent";
			this.checkBox_0.Size = new Size(179, 17);
			this.checkBox_0.TabIndex = 0;
			this.checkBox_0.Text = "Включить дочерние элементы";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "Id";
			this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_1.HeaderText = "Имя фильтра";
			this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_0.HeaderText = "Выбор";
			this.dataGridViewCheckBoxColumn_0.Name = "dataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn_0.Width = 45;
			this.backgroundWorker_0.WorkerReportsProgress = true;
			this.backgroundWorker_0.DoWork += this.backgroundWorker_0_DoWork;
			this.backgroundWorker_0.ProgressChanged += this.backgroundWorker_0_ProgressChanged;
			this.backgroundWorker_0.RunWorkerCompleted += this.backgroundWorker_0_RunWorkerCompleted;
			this.progressBar_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.progressBar_0.Location = new Point(139, 45);
			this.progressBar_0.Name = "progressBar";
			this.progressBar_0.Size = new Size(188, 23);
			this.progressBar_0.TabIndex = 4;
			this.progressBar_0.Visible = false;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(14, 50);
			this.label_2.Name = "labelAddDelFilter";
			this.label_2.Size = new Size(119, 13);
			this.label_2.TabIndex = 5;
			this.label_2.Text = "Добавление в фильтр";
			this.label_2.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_0;
			base.ClientSize = new Size(725, 378);
			base.Controls.Add(this.splitContainer_0);
			base.Name = "FormCanvasAddDelFilter";
			this.Text = "Добавление фильтров";
			base.Load += this.FormCanvasAddDelFilter_Load;
			this.splitContainer_0.Panel1.ResumeLayout(false);
			this.splitContainer_0.Panel1.PerformLayout();
			this.splitContainer_0.Panel2.ResumeLayout(false);
			this.splitContainer_0.ResumeLayout(false);
			((ISupportInitialize)this.dataGridView_0).EndInit();
			((ISupportInitialize)this.class22_0).EndInit();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			((ISupportInitialize)this.EijLatowoK).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			this.panel_1.ResumeLayout(false);
			this.panel_1.PerformLayout();
			this.panel_2.ResumeLayout(false);
			this.panel_2.PerformLayout();
			base.ResumeLayout(false);
		}

		internal static void FKABNepN00yRK8MKmrij(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		private StateFormCreate stateFormCreate_0;

		private StringBuilder stringBuilder_0;

		private SplitContainer splitContainer_0;

		private DataGridView dataGridView_0;

		private DataSetScheme class22_0;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private Panel panel_0;

		private Label label_0;

		private ToolStripSeparator toolStripSeparator_0;

		private ToolStripButton toolStripButton_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private Label label_1;

		private DataGridViewExcelFilter EijLatowoK;

		private BindingSource bindingSource_0;

		private Panel panel_1;

		private Panel panel_2;

		private Button button_0;

		private Button button_1;

		private CheckBox checkBox_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private BackgroundWorker backgroundWorker_0;

		private Label label_2;

		private ProgressBar progressBar_0;
	}
}
