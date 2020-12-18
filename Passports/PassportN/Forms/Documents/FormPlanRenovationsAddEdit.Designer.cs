using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using Constants;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;

namespace Passport.Forms.Documents
{
	public class FormPlanRenovationsAddEdit : FormBase
	{
		public FormPlanRenovationsAddEdit(int idObjList, int? idDoc = null)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_11();
			this.int_0 = idObjList;
			this.nullable_0 = idDoc;
			this.Text = ((idDoc == null) ? "Новый план ремонтных работ" : "Редактировать план ремонтных работ");
		}

		private void FormPlanRenovationsAddEdit_Load(object sender, EventArgs e)
		{
			this.comboBox_0.SelectedIndex = 1;
			this.dateTimePicker_0.Value = DateTime.Now.Date;
			this.HdemqKhwpga.Value = DateTime.Now.Date;
			this.tabPage_0.Tag = this.int_0;
			this.tabPage_0.Text = (this.textBox_0.Text = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
			{
				this.int_0.ToString()
			}).ToString());
			this.method_3();
			if (this.nullable_0 == null)
			{
				this.method_1();
				return;
			}
			base.SelectSqlData(this.class14_0.tP_DocList, true, "where id = " + this.nullable_0.ToString(), null, false, 0);
			this.method_0();
		}

		private void method_0()
		{
			base.SelectSqlData(this.class14_0.tP_DocPlanRenovations, true, "where idDoc =" + this.nullable_0.ToString(), null, false, 0);
			foreach (object obj in this.class14_0.tP_DocPlanRenovations.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				TabPage tabPage = null;
				foreach (object obj2 in this.tabControl_0.TabPages)
				{
					TabPage tabPage2 = (TabPage)obj2;
					if (Convert.ToInt32(tabPage2.Tag) == Convert.ToInt32(dataRow["idObjList"]))
					{
						tabPage = tabPage2;
						break;
					}
				}
				if (tabPage == null)
				{
					tabPage = this.method_2();
					tabPage.Tag = dataRow["idObjList"];
					DataTable dataTable = new DataTable("vSchm_ObjList");
					dataTable.Columns.Add("name", typeof(string));
					base.SelectSqlData(dataTable, true, "where id = " + dataRow["idObjList"].ToString(), null, false, 0);
					if (dataTable.Rows.Count > 0)
					{
						tabPage.Text = dataTable.Rows[0]["name"].ToString();
					}
					else
					{
						tabPage.Text = "Нет объекта схемы!";
					}
					this.tabControl_0.TabPages.Add(tabPage);
				}
				DateTimePicker dateTimePicker = this.method_7(tabPage);
				if (dateTimePicker != null)
				{
					dateTimePicker.Value = Convert.ToDateTime(dataRow["datePlan"]);
				}
				ComboBox comboBox = this.method_8(tabPage);
				if (comboBox != null)
				{
					comboBox.SelectedIndex = Convert.ToInt32(dataRow["isChange"]);
				}
				DataGridView dataGridView = this.method_9(tabPage);
				if (dataGridView != null && dataRow["PlannedWork"] != null)
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(dataRow["PlannedWork"].ToString());
					if (xmlDocument != null)
					{
						XmlNode xmlNode = xmlDocument.SelectSingleNode("List");
						if (xmlNode != null)
						{
							foreach (object obj3 in xmlNode.SelectNodes("work"))
							{
								XmlNode xmlNode2 = (XmlNode)obj3;
								if (!string.IsNullOrEmpty(xmlNode2.InnerText))
								{
									dataGridView.Rows.Add(new object[]
									{
										xmlNode2.InnerText
									});
								}
							}
						}
					}
				}
			}
		}

		private void method_1()
		{
			DataRow dataRow = this.class14_0.tP_DocList.NewRow();
			dataRow["ParentId"] = -1;
			dataRow["idObjList"] = this.int_0;
			dataRow["dateDoc"] = DateTime.Now.Date;
			dataRow["TypeDoc"] = 1353;
			dataRow["isActive"] = 1;
			dataRow["deleted"] = 0;
			this.class14_0.tP_DocList.Rows.Add(dataRow);
		}

		private TabPage method_2()
		{
			TabPage tabPage = new TabPage();
			Label label = new Label();
			label.AutoSize = true;
			label.Location = new Point(5, 11);
			label.Name = "label4";
			label.Size = new Size(65, 13);
			label.TabIndex = 0;
			label.Text = "Дата работ";
			tabPage.Controls.Add(label);
			DateTimePicker dateTimePicker = new DateTimePicker();
			dateTimePicker.Location = new Point(76, 5);
			dateTimePicker.Name = "dateTimePicker1";
			dateTimePicker.Size = new Size(138, 20);
			dateTimePicker.TabIndex = 1;
			dateTimePicker.Tag = "plan";
			dateTimePicker.Value = DateTime.Now.Date;
			tabPage.Controls.Add(dateTimePicker);
			Label label2 = new Label();
			label2.AutoSize = true;
			label2.Location = new Point(225, 11);
			label2.Name = "label5";
			label2.Size = new Size(58, 13);
			label2.TabIndex = 2;
			label2.Text = "Вид работ";
			tabPage.Controls.Add(label2);
			ComboBox comboBox = new ComboBox();
			comboBox.FormattingEnabled = true;
			comboBox.Items.AddRange(new object[]
			{
				"Ремонт",
				"Замена"
			});
			comboBox.Location = new Point(289, 5);
			comboBox.Name = "comboBox1";
			comboBox.Size = new Size(204, 21);
			comboBox.TabIndex = 3;
			comboBox.SelectedIndex = 1;
			comboBox.Tag = "typeWork";
			tabPage.Controls.Add(comboBox);
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewColumn dataGridViewColumn = new DataGridViewTextBoxColumn();
			dataGridViewColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			dataGridViewColumn.DefaultCellStyle = dataGridViewCellStyle;
			dataGridViewColumn.HeaderText = "Работы";
			dataGridViewColumn.Name = "jobsDgvColumn";
			DataGridView dataGridView = new DataGridView();
			dataGridView.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView.Columns.AddRange(new DataGridViewColumn[]
			{
				dataGridViewColumn
			});
			dataGridView.Location = new Point(0, 31);
			dataGridView.Name = "dgvJobs";
			dataGridView.RowHeadersWidth = 21;
			dataGridView.Size = new Size(580, 120);
			dataGridView.TabIndex = 4;
			dataGridView.Tag = "works";
			tabPage.Controls.Add(dataGridView);
			return tabPage;
		}

		private void method_3()
		{
			string text = "";
			foreach (object obj in Enum.GetValues(typeof(SchmTypeSwGear)))
			{
				SchmTypeSwGear schmTypeSwGear = (SchmTypeSwGear)obj;
				if (string.IsNullOrEmpty(text))
				{
					int num = schmTypeSwGear;
					text = num.ToString();
				}
				else
				{
					string str = text;
					string str2 = ",";
					int num = schmTypeSwGear;
					text = str + str2 + num.ToString();
				}
			}
			DataTable dataTable = new DataTable("vSchm_ObjList");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("name", typeof(string));
			base.SelectSqlData(dataTable, true, string.Format("where idParent = {0} and deleted = 0 and typeCodeId in ({1})", this.int_0, text), null, false, 0);
			foreach (object obj2 in dataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj2;
				TabPage tabPage = this.method_2();
				tabPage.Text = dataRow["name"].ToString();
				tabPage.Tag = dataRow["id"];
				this.tabControl_0.TabPages.Add(tabPage);
			}
			dataTable = new DataTable("tSchm_ObjList");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("name", typeof(string));
			base.SelectSqlData(dataTable, true, string.Format("where idParentAddl = {0} and deleted = 0 and typeCodeId = 556", this.int_0), null, false, 0);
			foreach (object obj3 in dataTable.Rows)
			{
				DataRow dataRow2 = (DataRow)obj3;
				TabPage tabPage2 = this.method_2();
				tabPage2.Text = "Т - " + dataRow2["name"].ToString();
				tabPage2.Tag = dataRow2["id"];
				this.tabControl_0.TabPages.Add(tabPage2);
			}
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void FormPlanRenovationsAddEdit_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK && !this.method_6())
			{
				e.Cancel = true;
				return;
			}
		}

		private bool method_4()
		{
			if (this.nullable_0 == null)
			{
				this.class14_0.tP_DocList.Rows[0].EndEdit();
				this.nullable_0 = new int?(base.InsertSqlDataOneRow(this.class14_0, this.class14_0.tP_DocList));
				return !(this.nullable_0 < 0);
			}
			this.class14_0.tP_DocList.Rows[0].EndEdit();
			return base.UpdateSqlData(this.class14_0.tP_DocList);
		}

		private bool method_5()
		{
			base.SelectSqlData(this.class14_0.tP_DocPlanRenovations, true, "where idDoc =" + this.nullable_0.ToString(), null, false, 0);
			foreach (object obj in this.tabControl_0.TabPages)
			{
				TabPage tabPage = (TabPage)obj;
				DataRow[] array = this.class14_0.tP_DocPlanRenovations.Select("idObjList = " + tabPage.Tag.ToString());
				if (array.Length == 0)
				{
					DataRow dataRow = this.class14_0.tP_DocPlanRenovations.NewRow();
					dataRow["idDoc"] = this.nullable_0;
					dataRow["idObjList"] = tabPage.Tag;
					DateTimePicker dateTimePicker = this.method_7(tabPage);
					if (tabPage != null)
					{
						dataRow["datePlan"] = dateTimePicker.Value;
					}
					else
					{
						dataRow["datePlan"] = DateTime.Now.Date;
					}
					ComboBox comboBox = this.method_8(tabPage);
					if (comboBox != null)
					{
						dataRow["isChange"] = comboBox.SelectedIndex;
					}
					else
					{
						dataRow["ischange"] = false;
					}
					string value = this.method_10(tabPage);
					if (!string.IsNullOrEmpty(value))
					{
						dataRow["PlannedWork"] = value;
					}
					this.class14_0.tP_DocPlanRenovations.Rows.Add(dataRow);
				}
				else
				{
					array[0]["idDoc"] = this.nullable_0;
					array[0]["idObjList"] = tabPage.Tag;
					DateTimePicker dateTimePicker2 = this.method_7(tabPage);
					if (tabPage != null)
					{
						array[0]["datePlan"] = dateTimePicker2.Value;
					}
					else
					{
						array[0]["datePlan"] = DateTime.Now.Date;
					}
					ComboBox comboBox2 = this.method_8(tabPage);
					if (comboBox2 != null)
					{
						array[0]["isChange"] = comboBox2.SelectedIndex;
					}
					else
					{
						array[0]["ischange"] = false;
					}
					string value2 = this.method_10(tabPage);
					if (!string.IsNullOrEmpty(value2))
					{
						array[0]["PlannedWork"] = value2;
					}
					else
					{
						array[0]["PlannedWork"] = DBNull.Value;
					}
					array[0].EndEdit();
				}
			}
			return base.InsertSqlData(this.class14_0.tP_DocPlanRenovations) && base.UpdateSqlData(this.class14_0.tP_DocPlanRenovations);
		}

		private bool method_6()
		{
			return this.method_4() && this.method_5();
		}

		private DateTimePicker method_7(Control control_0)
		{
			if (control_0 is DateTimePicker && control_0.Tag.ToString() == "plan")
			{
				return (DateTimePicker)control_0;
			}
			DateTimePicker dateTimePicker = null;
			foreach (object obj in control_0.Controls)
			{
				Control control_ = (Control)obj;
				dateTimePicker = this.method_7(control_);
				if (dateTimePicker != null)
				{
					break;
				}
			}
			return dateTimePicker;
		}

		private ComboBox method_8(Control control_0)
		{
			if (control_0 is ComboBox && control_0.Tag.ToString() == "typeWork")
			{
				return (ComboBox)control_0;
			}
			ComboBox comboBox = null;
			foreach (object obj in control_0.Controls)
			{
				Control control_ = (Control)obj;
				comboBox = this.method_8(control_);
				if (comboBox != null)
				{
					break;
				}
			}
			return comboBox;
		}

		private DataGridView method_9(Control control_0)
		{
			if (control_0 is DataGridView && control_0.Tag.ToString() == "works")
			{
				return (DataGridView)control_0;
			}
			DataGridView dataGridView = null;
			foreach (object obj in control_0.Controls)
			{
				Control control_ = (Control)obj;
				dataGridView = this.method_9(control_);
				if (dataGridView != null)
				{
					break;
				}
			}
			return dataGridView;
		}

		private string method_10(TabPage tabPage_1)
		{
			DataGridView dataGridView = this.method_9(tabPage_1);
			if (dataGridView == null)
			{
				return null;
			}
			XmlDocument xmlDocument = new XmlDocument();
			XmlNode xmlNode = xmlDocument.CreateElement("List");
			xmlDocument.AppendChild(xmlNode);
			foreach (object obj in ((IEnumerable)dataGridView.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if (dataGridViewRow.Cells[0].Value != null && !string.IsNullOrEmpty(dataGridViewRow.Cells[0].Value.ToString()))
				{
					XmlNode xmlNode2 = xmlDocument.CreateElement("work");
					xmlNode2.InnerText = dataGridViewRow.Cells[0].Value.ToString();
					xmlNode.AppendChild(xmlNode2);
				}
			}
			return xmlDocument.InnerXml;
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
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.label_0 = new Label();
			this.textBox_0 = new TextBox();
			this.tabControl_0 = new TabControl();
			this.tabPage_0 = new TabPage();
			this.panel_0 = new Panel();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.comboBox_0 = new ComboBox();
			this.label_3 = new Label();
			this.HdemqKhwpga = new DateTimePicker();
			this.label_4 = new Label();
			this.label_1 = new Label();
			this.textBox_1 = new TextBox();
			this.class14_0 = new Class14();
			this.label_2 = new Label();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dateTimePicker_0 = new DateTimePicker();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			this.panel_0.SuspendLayout();
			this.dataGridViewExcelFilter_0.BeginInit();
			((ISupportInitialize)this.class14_0).BeginInit();
			base.SuspendLayout();
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 12);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(68, 13);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "Подстанция";
			this.textBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.textBox_0.BackColor = SystemColors.Window;
			this.textBox_0.Location = new Point(86, 9);
			this.textBox_0.Name = "txtSSName";
			this.textBox_0.ReadOnly = true;
			this.textBox_0.Size = new Size(495, 20);
			this.textBox_0.TabIndex = 1;
			this.tabControl_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Location = new Point(0, 61);
			this.tabControl_0.Name = "tabControl1";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(594, 183);
			this.tabControl_0.TabIndex = 2;
			this.tabPage_0.Controls.Add(this.panel_0);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tabPage1";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(586, 157);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "tabPage1";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.panel_0.Controls.Add(this.dataGridViewExcelFilter_0);
			this.panel_0.Controls.Add(this.comboBox_0);
			this.panel_0.Controls.Add(this.label_3);
			this.panel_0.Controls.Add(this.HdemqKhwpga);
			this.panel_0.Controls.Add(this.label_4);
			this.panel_0.Dock = DockStyle.Fill;
			this.panel_0.Location = new Point(3, 3);
			this.panel_0.Name = "panel1";
			this.panel_0.Size = new Size(580, 151);
			this.panel_0.TabIndex = 0;
			this.dataGridViewExcelFilter_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_0
			});
			this.dataGridViewExcelFilter_0.Location = new Point(0, 31);
			this.dataGridViewExcelFilter_0.Name = "dgvJobs";
			this.dataGridViewExcelFilter_0.RowHeadersWidth = 21;
			this.dataGridViewExcelFilter_0.Size = new Size(580, 120);
			this.dataGridViewExcelFilter_0.TabIndex = 4;
			this.dataGridViewExcelFilter_0.Tag = "works";
			this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_0.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewTextBoxColumn_0.HeaderText = "Работы";
			this.dataGridViewTextBoxColumn_0.Name = "jobsDgvColumn";
			this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Items.AddRange(new object[]
			{
				"Ремонт",
				"Замена"
			});
			this.comboBox_0.Location = new Point(289, 5);
			this.comboBox_0.Name = "cmbTypeWork";
			this.comboBox_0.Size = new Size(204, 21);
			this.comboBox_0.TabIndex = 3;
			this.comboBox_0.Tag = "typeWork";
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(225, 11);
			this.label_3.Name = "label5";
			this.label_3.Size = new Size(58, 13);
			this.label_3.TabIndex = 2;
			this.label_3.Text = "Вид работ";
			this.HdemqKhwpga.Location = new Point(76, 5);
			this.HdemqKhwpga.Name = "dtpPlanWork";
			this.HdemqKhwpga.Size = new Size(138, 20);
			this.HdemqKhwpga.TabIndex = 1;
			this.HdemqKhwpga.Tag = "plan";
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(5, 11);
			this.label_4.Name = "label4";
			this.label_4.Size = new Size(65, 13);
			this.label_4.TabIndex = 0;
			this.label_4.Text = "Дата работ";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(12, 38);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(75, 13);
			this.label_1.TabIndex = 3;
			this.label_1.Text = "№ документа";
			this.textBox_1.BackColor = SystemColors.Window;
			this.textBox_1.DataBindings.Add(new Binding("Text", this.class14_0, "tP_DocList.NumberDoc", true));
			this.textBox_1.Location = new Point(86, 35);
			this.textBox_1.Name = "textBox1";
			this.textBox_1.ReadOnly = true;
			this.textBox_1.Size = new Size(85, 20);
			this.textBox_1.TabIndex = 4;
			this.class14_0.DataSetName = "dsDocuments";
			this.class14_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(177, 38);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(90, 13);
			this.label_2.TabIndex = 5;
			this.label_2.Text = "Дата документа";
			this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Location = new Point(372, 250);
			this.button_0.Name = "buttonSaveAndClose";
			this.button_0.Size = new Size(128, 23);
			this.button_0.TabIndex = 7;
			this.button_0.Text = "Сохранить и закрыть";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Location = new Point(506, 250);
			this.button_1.Name = "buttonCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 8;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn_1.HeaderText = "Работы";
			this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn1";
			this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.class14_0, "tP_DocList.DateDoc", true));
			this.dateTimePicker_0.Location = new Point(273, 35);
			this.dateTimePicker_0.Name = "dateTimePicker1";
			this.dateTimePicker_0.Size = new Size(200, 20);
			this.dateTimePicker_0.TabIndex = 9;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(593, 277);
			base.Controls.Add(this.dateTimePicker_0);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.textBox_1);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.tabControl_0);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.label_0);
			base.Name = "FormPlanRenovationsAddEdit";
			this.Text = "FormPlanRenovationsAddEdit";
			base.FormClosing += this.FormPlanRenovationsAddEdit_FormClosing;
			base.Load += this.FormPlanRenovationsAddEdit_Load;
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			this.dataGridViewExcelFilter_0.EndInit();
			((ISupportInitialize)this.class14_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private int int_0;

		private int? nullable_0;

		private IContainer icontainer_0;

		private Label label_0;

		private TextBox textBox_0;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private Label label_1;

		private TextBox textBox_1;

		private Label label_2;

		private Panel panel_0;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private ComboBox comboBox_0;

		private Label label_3;

		private DateTimePicker HdemqKhwpga;

		private Label label_4;

		private Button button_0;

		private Button button_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private Class14 class14_0;

		private DateTimePicker dateTimePicker_0;
	}
}
