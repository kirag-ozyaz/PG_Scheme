using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using Documents.Properties;
using FormLbr;
using FormLbr.Classes;

namespace Documents.Forms.JournalExcavation
{
	public partial class FormJournalExcavation : FormBase
	{
		public FormJournalExcavation()
		{
			Class611.H9nE6ZDzTF9kb();
			this.int_0 = -1;
			base..ctor();
			this.method_7();
			this.method_0();
			this.toolStripButton_27.Visible = false;
		}

		private void method_0()
		{
			this.dateTimePicker_1.Value = new DateTime(DateTime.Now.Year, 1, 1);
			this.dateTimePicker_0.Value = this.dateTimePicker_1.Value.AddYears(1).AddSeconds(-1.0);
			this.dataTable_0 = new DataTable("vJ_ExcavationFile");
			this.dataTable_0.Columns.Add(new DataColumn("id", typeof(int)));
			this.dataTable_0.Columns.Add(new DataColumn("idExcavation", typeof(int)));
			this.dataTable_0.Columns.Add(new DataColumn("typeFile", typeof(int)));
			this.dataTable_0.Columns.Add(new DataColumn("typefileName", typeof(string)));
			this.dataTable_0.Columns.Add(new DataColumn("FileName", typeof(string)));
		}

		private void FormJournalExcavation_Load(object sender, EventArgs e)
		{
			this.method_2(null);
			this.method_3();
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			this.method_2(null);
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			this.dateTimePicker_1.Value = new DateTime(DateTime.Now.Year, 1, 1);
			this.dateTimePicker_0.Value = this.dateTimePicker_1.Value.AddYears(1).AddSeconds(-1.0);
			this.checkBox_1.Checked = false;
			this.checkBox_0.Checked = true;
			this.method_2(null);
		}

		private string method_1()
		{
			string text = string.Format("where dateBeg <= '{0}' and (maxStatusDate >= '{1}' or maxStatusDate is null)\r\n", this.dateTimePicker_0.Value.Date.ToString("yyyy.MM.dd"), this.dateTimePicker_1.Value.Date.AddDays(1.0).AddSeconds(-1.0).ToString("yyyy.MM.dd HH:mm:ss"));
			if (this.checkBox_1.Checked)
			{
				text += " and (agreed = 1) ";
			}
			if (this.checkBox_0.Checked)
			{
				text += " and (datePay is null) ";
			}
			return text;
		}

		private void method_2(int? nullable_0 = null)
		{
			if (nullable_0 == null)
			{
				nullable_0 = new int?(this.int_0);
			}
			string filter = "id = -1";
			this.bindingSource_2.Filter = (this.bindingSource_0.Filter = (this.bindingSource_3.Filter = (this.bindingSource_7.Filter = (this.bindingSource_4.Filter = (this.bindingSource_5.Filter = (this.bindingSource_6.Filter = (this.bindingSource_8.Filter = filter)))))));
			base.SelectSqlData(this.class130_0, this.class130_0.vJ_Excavation, true, this.method_1());
			base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationAddress, true);
			base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationSchmObj, true);
			base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationStatus, true);
			base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationSurface, true);
			this.method_4();
			base.SelectSqlData(this.dataTable_0, true, "order by filename", null, false, 0);
			this.bindingSource_8.DataSource = this.dataTable_0;
			this.method_3();
			if (nullable_0 != null)
			{
				this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_32.Name, nullable_0.ToString(), false);
			}
		}

		private void method_3()
		{
			this.dataGridViewTextBoxColumn_8.Visible = false;
			this.dataGridViewTextBoxColumn_38.Visible = false;
			this.dataGridViewTextBoxColumn_47.Visible = false;
			this.dataGridViewTextBoxColumn_12.Visible = false;
			this.dataGridViewTextBoxColumn_28.Visible = false;
			this.dataGridViewTextBoxColumn_21.Visible = false;
		}

		private void method_4()
		{
			string b = (this.treeView_0.SelectedNode != null) ? this.treeView_0.SelectedNode.Text : "";
			this.treeView_0.Nodes.Clear();
			TreeNode treeNode = new TreeNode("Все типы");
			this.treeView_0.Nodes.Add(treeNode);
			if (treeNode.Text == b)
			{
				this.treeView_0.SelectedNode = treeNode;
			}
			DataTable dataTable = base.SelectSqlData("tR_Classifier", true, " where ParentKey = ';Excavation;TypeFile;' and isGRoup = 0 and deleted = 0 order by value");
			this.toolStripSplitButton_0.DropDownItems.Clear();
			foreach (object obj in dataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				TreeNode treeNode2 = new TreeNode(dataRow["Name"].ToString());
				treeNode2.Tag = dataRow["id"];
				treeNode.Nodes.Add(treeNode2);
				if (treeNode2.Text == b)
				{
					this.treeView_0.SelectedNode = treeNode2;
				}
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(dataRow["Name"].ToString());
				toolStripMenuItem.Tag = dataRow["id"];
				toolStripMenuItem.Click += this.method_6;
				this.toolStripSplitButton_0.DropDownItems.Add(toolStripMenuItem);
			}
			treeNode.ExpandAll();
		}

		private void bindingSource_1_CurrentChanged(object sender, EventArgs e)
		{
			if (this.bindingSource_1.Current != null)
			{
				this.int_0 = Convert.ToInt32(((DataRowView)this.bindingSource_1.Current).Row["id"]);
				this.bindingSource_2.Filter = (this.bindingSource_0.Filter = "idExcavation = " + this.int_0.ToString());
				this.bindingSource_3.Filter = "idExcavation  = " + this.int_0.ToString() + " and idType = " + 1.ToString();
				this.bindingSource_7.Filter = "idExcavation  = " + this.int_0.ToString() + " and idType = " + 2.ToString();
				this.bindingSource_4.Filter = "idExcavation = " + this.int_0.ToString() + " and idType = " + 3.ToString();
				this.bindingSource_5.Filter = "idExcavation = " + this.int_0.ToString() + " and idType = " + 1.ToString();
				this.bindingSource_6.Filter = "idExcavation = " + this.int_0.ToString() + " and idType = " + 2.ToString();
				this.bindingSource_8.Filter = "idExcavation = " + this.int_0.ToString();
				if (this.treeView_0.SelectedNode != null && this.treeView_0.SelectedNode.Tag != null)
				{
					this.bindingSource_8.Filter = "idExcavation = " + this.int_0.ToString() + " and typeFile = " + this.treeView_0.SelectedNode.Tag.ToString();
				}
			}
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			Form59 form = new Form59(-1);
			form.SqlSettings = this.SqlSettings;
			form.MdiParent = base.MdiParent;
			form.Show();
			form.FormClosed -= this.method_5;
			form.FormClosed += this.method_5;
		}

		private void method_5(object sender, FormClosedEventArgs e)
		{
			Form59 form = (Form59)sender;
			if (form.DialogResult == DialogResult.OK)
			{
				this.method_2(new int?(form.int_0));
			}
		}

		private void toolStripButton_3_Click(object sender, EventArgs e)
		{
			Form59 form = new Form59(this.int_0);
			form.SqlSettings = this.SqlSettings;
			form.MdiParent = base.MdiParent;
			form.Show();
			form.FormClosed -= this.method_5;
			form.FormClosed += this.method_5;
		}

		private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.toolStrip_0.Visible && this.toolStrip_0.Enabled && this.toolStripButton_3.Visible && this.toolStripButton_3.Enabled)
			{
				this.toolStripButton_3_Click(sender, e);
			}
		}

		private void toolStripButton_4_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить текущую раскопку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && base.DeleteSqlDataById(this.class130_0.tJ_Excavation, this.int_0))
			{
				this.dataGridViewExcelFilter_0.Rows.Remove(this.dataGridViewExcelFilter_0.CurrentRow);
			}
		}

		private void toolStripButton_8_Click(object sender, EventArgs e)
		{
			new Form64
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		private void toolStripButton_31_Click(object sender, EventArgs e)
		{
			this.method_2(null);
		}

		private void toolStripButton_27_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Удалить все данные перед загрузкой", "Удаление", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
			if (dialogResult == DialogResult.Yes)
			{
				SqlDataConnect sqlDataConnect = new SqlDataConnect();
				sqlDataConnect.OpenConnection(this.SqlSettings);
				new SqlCommand("delete tJ_Excavation", sqlDataConnect.Connection).ExecuteNonQuery();
			}
			if (dialogResult != DialogResult.Cancel)
			{
				SqlDataCommand sqlDataCommand = new SqlDataCommand(new SQLSettings("ulges-sql", "PTS", "WINDOWS", "", ""));
				DataTable dataTable = sqlDataCommand.SelectSqlData("ExWorkList", false, " order by date_begin desc ", null);
				DataTable dataTable2 = sqlDataCommand.SelectSqlData("ExEnums2ExWrkList", false, "", null);
				sqlDataCommand.SelectSqlData("ExEnums", false, "", null);
				DataTable dataTable3 = sqlDataCommand.SelectSqlData("tbl_Streets", false, "", null);
				DataTable dataTable4 = base.SelectSqlData("tr_kladrStreet", false, " where kladrObjId = 24");
				DataTable dataTable5 = base.SelectSqlData("tSchm_ObjList", false, " where typeCodeid = 546 and deleted = 0 order by name");
				foreach (object obj in dataTable.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					DataRow dataRow2 = this.class130_0.tJ_Excavation.NewRow();
					dataRow2["dateBeg"] = dataRow["date_Begin"];
					dataRow2["idContractor"] = 434002;
					switch (Convert.ToInt32(dataRow["excavation_type"]))
					{
					case 1:
						dataRow2["typeWork"] = 1049;
						break;
					case 2:
						dataRow2["typeWork"] = 1050;
						break;
					case 3:
						dataRow2["typeWork"] = 1051;
						break;
					case 4:
						dataRow2["typeWork"] = 1052;
						break;
					case 5:
						dataRow2["typeWork"] = 1053;
						break;
					}
					dataRow2["datebegOrder"] = dataRow["order_date_begin"];
					dataRow2["dateEndOrder"] = dataRow["order_date_end"];
					dataRow2["numpermission"] = dataRow["num_permission"];
					dataRow2["datepermission"] = dataRow["date_permission"];
					dataRow2["dateUnderAsphalt"] = dataRow["date_transfer"];
					dataRow2["dateAsphalt"] = dataRow["date_asphalting"];
					dataRow2["dateEnd"] = dataRow["date_End"];
					if (dataRow["payment_month"] != DBNull.Value)
					{
						dataRow2["DatePay"] = new DateTime(Convert.ToDateTime(dataRow["date_Begin"]).Year, Convert.ToInt32(dataRow["payment_month"]), 1);
					}
					this.class130_0.tJ_Excavation.Rows.Add(dataRow2);
					int num = base.InsertSqlDataOneRow(this.class130_0, this.class130_0.tJ_Excavation);
					this.class130_0.tJ_Excavation.Clear();
					dataRow2 = this.class130_0.tJ_ExcavationStatus.NewRow();
					dataRow2["idExcavation"] = num;
					dataRow2["idType"] = 1;
					switch (Convert.ToInt32(dataRow["order_state"]))
					{
					case 1:
						dataRow2["idStatus"] = 1073;
						break;
					case 2:
						dataRow2["idStatus"] = 1074;
						break;
					case 3:
						dataRow2["idStatus"] = 1076;
						break;
					case 4:
						dataRow2["idStatus"] = 1072;
						break;
					}
					dataRow2["dateChange"] = dataRow["date_begin"];
					this.class130_0.tJ_ExcavationStatus.Rows.Add(dataRow2);
					base.InsertSqlDataOneRow(this.class130_0, this.class130_0.tJ_ExcavationStatus);
					this.class130_0.tJ_ExcavationStatus.Clear();
					dataRow2 = this.class130_0.tJ_ExcavationStatus.NewRow();
					dataRow2["idExcavation"] = num;
					dataRow2["idType"] = 2;
					switch (Convert.ToInt32(dataRow["excavation_state"]))
					{
					case 1:
						dataRow2["idStatus"] = 1099;
						break;
					case 2:
						dataRow2["idStatus"] = 1096;
						break;
					case 3:
						dataRow2["idStatus"] = 1100;
						break;
					case 4:
						dataRow2["idStatus"] = 1097;
						break;
					case 5:
						dataRow2["idStatus"] = 1102;
						break;
					case 6:
						dataRow2["idStatus"] = 1101;
						break;
					case 7:
						dataRow2["idStatus"] = 1103;
						break;
					case 8:
						dataRow2["idStatus"] = 1104;
						break;
					}
					dataRow2["dateChange"] = dataRow["date_begin"];
					this.class130_0.tJ_ExcavationStatus.Rows.Add(dataRow2);
					base.InsertSqlDataOneRow(this.class130_0, this.class130_0.tJ_ExcavationStatus);
					this.class130_0.tJ_ExcavationStatus.Clear();
					dataRow2 = this.class130_0.tJ_ExcavationAddress.NewRow();
					dataRow2["idExcavation"] = num;
					switch (Convert.ToInt32(dataRow["district"]))
					{
					case 1:
						dataRow2["idregion"] = 196;
						break;
					case 2:
						dataRow2["idregion"] = 198;
						break;
					case 3:
						dataRow2["idregion"] = 197;
						break;
					case 4:
						dataRow2["idregion"] = 199;
						break;
					}
					DataRow[] array = dataTable3.Select("codestreet = " + dataRow["address"].ToString());
					if (array.Length == 0)
					{
						goto IL_9B5;
					}
					string text = array[0]["Prefix"].ToString();
					if (text[text.Length - 1] == '.')
					{
						text = text.Remove(text.Length - 1);
					}
					string text2 = array[0]["Name"].ToString();
					if (text == "пр-т")
					{
						text = "пр-кт";
					}
					if (text == "шоссе")
					{
						text = "ш";
					}
					if (text == "площадь")
					{
						text = "пл";
					}
					if (text == "бульвар")
					{
						text = "б-р";
					}
					if (text2 == "К. Маркса")
					{
						text2 = "Карла Маркса";
					}
					if (text2 == "Л. Шевцовой")
					{
						text2 = "Любови Шевцовой";
					}
					if (text2 == "К. Либкнехта")
					{
						text2 = "Карла Либкнехта";
					}
					if (text2 == "Р.Люксембург")
					{
						text2 = "Розы Люксембург";
					}
					if (text2 == "Б. Хитрового")
					{
						text2 = "Б.Хитрово";
					}
					if (text2 == "Вр.Михайлова")
					{
						text2 = "Врача Михайлова";
					}
					if (text2 == "У.Громовой")
					{
						text2 = "Ульяны Громовой";
					}
					if (text2 == "40 лет Победы")
					{
						text2 = "40-летия Победы";
					}
					if (text2 == "50 лет ВЛКСМ")
					{
						text2 = "50-летия ВЛКСМ";
					}
					if (text2 == "Героя Аверьянова")
					{
						text2 = "Героя России Аверьянова";
					}
					if (text2 == "УКСМ" && text == "поселок")
					{
						text = "ул";
					}
					if (text2 == "Степана Разина" && text == "спуск")
					{
						text2 = "Спуск Степана Разина";
						text = "ул";
					}
					if (text == "1 пер")
					{
						text2 += " 1-й";
						text = "пер";
					}
					if (text == "2 пер")
					{
						text2 += " 2-й";
						text = "пер";
					}
					if (text == "3 пер")
					{
						text2 += " 3-й";
						text = "пер";
					}
					if (text2 == "Лазо 2-й")
					{
						text2 = "Сергея Лазо 2-й";
					}
					if (text2 == "Хо Ши Мина" && text == "ул")
					{
						text = "пр-кт";
					}
					DataRow[] array2 = dataTable4.Select(string.Concat(new string[]
					{
						"name = '",
						text2,
						"' and Socr = '",
						text,
						"'"
					}));
					if (array2.Length == 0)
					{
						using (StreamWriter streamWriter = new StreamWriter("excavation.log", true))
						{
							streamWriter.WriteLine(text2 + "  " + text);
							goto IL_9C0;
						}
						goto IL_9B5;
					}
					dataRow2["idStreet"] = array2[0]["id"];
					IL_9C0:
					dataRow2["House"] = dataRow["address_note"];
					this.class130_0.tJ_ExcavationAddress.Rows.Add(dataRow2);
					base.InsertSqlDataOneRow(this.class130_0, this.class130_0.tJ_ExcavationAddress);
					this.class130_0.tJ_ExcavationAddress.Clear();
					dataRow2 = this.class130_0.tJ_ExcavationSchmObj.NewRow();
					dataRow2["idExcavation"] = num;
					DataRow[] array3 = dataTable5.Select("Name = '" + dataRow["cable_name"].ToString() + "'");
					dataRow2["nameKL"] = dataRow["cable_name"];
					if (array3.Length != 0)
					{
						dataRow2["idKL"] = array3[0]["id"];
					}
					this.class130_0.tJ_ExcavationSchmObj.Rows.Add(dataRow2);
					base.InsertSqlDataOneRow(this.class130_0, this.class130_0.tJ_ExcavationSchmObj);
					this.class130_0.tJ_ExcavationSchmObj.Clear();
					foreach (DataRow dataRow3 in dataTable2.Select("ex_id = " + dataRow["id"].ToString() + " and enum_code = 4"))
					{
						dataRow2 = this.class130_0.tJ_ExcavationSurface.NewRow();
						dataRow2["idExcavation"] = num;
						dataRow2["idType"] = 1;
						switch (Convert.ToInt32(dataRow3["enum_num_value"]))
						{
						case 1:
							dataRow2["idSurface"] = 1060;
							break;
						case 2:
							dataRow2["idSurface"] = 1061;
							break;
						case 3:
							dataRow2["idSurface"] = 1062;
							break;
						case 4:
							dataRow2["idSurface"] = 1063;
							break;
						case 5:
							dataRow2["idSurface"] = 1064;
							break;
						case 6:
							dataRow2["idSurface"] = 1065;
							break;
						case 7:
							dataRow2["idSurface"] = 1066;
							break;
						}
						this.class130_0.tJ_ExcavationSurface.Rows.Add(dataRow2);
						base.InsertSqlDataOneRow(this.class130_0, this.class130_0.tJ_ExcavationSurface);
						this.class130_0.tJ_ExcavationSurface.Clear();
					}
					foreach (DataRow dataRow4 in dataTable2.Select("ex_id = " + dataRow["id"].ToString() + " and enum_code = 9"))
					{
						dataRow2 = this.class130_0.tJ_ExcavationSurface.NewRow();
						dataRow2["idExcavation"] = num;
						dataRow2["idType"] = 2;
						dataRow2["Value"] = dataRow4["quantity"];
						switch (Convert.ToInt32(dataRow4["enum_num_value"]))
						{
						case 1:
							dataRow2["idSurface"] = 1060;
							dataRow2["unit"] = "кв.м";
							break;
						case 2:
							dataRow2["idSurface"] = 1061;
							dataRow2["unit"] = "кв.м";
							break;
						case 3:
							dataRow2["idSurface"] = 1063;
							dataRow2["unit"] = "кв.м";
							break;
						case 4:
							dataRow2["idSurface"] = 1066;
							dataRow2["unit"] = "м";
							break;
						case 5:
							dataRow2["idSurface"] = 1062;
							dataRow2["unit"] = "кв.м";
							break;
						case 6:
							dataRow2["idSurface"] = 1064;
							dataRow2["unit"] = "кв.м";
							break;
						case 7:
							dataRow2["idSurface"] = 1066;
							break;
						}
						this.class130_0.tJ_ExcavationSurface.Rows.Add(dataRow2);
						base.InsertSqlDataOneRow(this.class130_0, this.class130_0.tJ_ExcavationSurface);
						this.class130_0.tJ_ExcavationSurface.Clear();
					}
					foreach (DataRow dataRow5 in dataTable2.Select("ex_id = " + dataRow["id"].ToString() + " and enum_code = 7"))
					{
						dataRow2 = this.class130_0.tJ_ExcavationSurface.NewRow();
						dataRow2["idExcavation"] = num;
						dataRow2["comment"] = dataRow5["note"];
						dataRow2["idType"] = 3;
						dataRow2["Value"] = dataRow5["quantity"];
						switch (Convert.ToInt32(dataRow5["enum_num_value"]))
						{
						case 1:
							dataRow2["idSurface"] = 1055;
							dataRow2["unit"] = "тонн";
							break;
						case 2:
							dataRow2["idSurface"] = 1056;
							dataRow2["unit"] = "кг";
							break;
						case 3:
							dataRow2["idSurface"] = 1057;
							dataRow2["unit"] = "тонн";
							break;
						case 4:
							dataRow2["idSurface"] = 1058;
							dataRow2["unit"] = "м";
							break;
						}
						this.class130_0.tJ_ExcavationSurface.Rows.Add(dataRow2);
						base.InsertSqlDataOneRow(this.class130_0, this.class130_0.tJ_ExcavationSurface);
						this.class130_0.tJ_ExcavationSurface.Clear();
					}
					if (dataRow["permission_file_name"] != DBNull.Value)
					{
						string text3 = dataRow["permission_file_name"].ToString();
						dataRow2 = this.class130_0.tJ_ExcavationFile.NewRow();
						dataRow2["idExcavation"] = num;
						dataRow2["typeFile"] = 1106;
						dataRow2["FileName"] = text3;
						if (File.Exists(text3))
						{
							dataRow2["File"] = File.ReadAllBytes(text3);
						}
						this.class130_0.tJ_ExcavationFile.Rows.Add(dataRow2);
						base.InsertSqlDataOneRow(this.class130_0, this.class130_0.tJ_ExcavationFile);
						this.class130_0.tJ_ExcavationFile.Clear();
					}
					if (dataRow["photo_dir"] == DBNull.Value)
					{
						continue;
					}
					string text4 = dataRow["photo_dir"].ToString();
					DirectoryInfo directoryInfo = new DirectoryInfo(text4);
					if (Directory.Exists(text4) && directoryInfo.GetFiles().Count<System.IO.FileInfo>() != 0 && directoryInfo.GetFiles().Count<System.IO.FileInfo>() <= 10)
					{
						foreach (System.IO.FileInfo fileInfo in directoryInfo.GetFiles())
						{
							dataRow2 = this.class130_0.tJ_ExcavationFile.NewRow();
							dataRow2["idExcavation"] = num;
							dataRow2["typeFile"] = 1107;
							dataRow2["FileName"] = fileInfo.FullName;
							dataRow2["File"] = File.ReadAllBytes(fileInfo.FullName);
							this.class130_0.tJ_ExcavationFile.Rows.Add(dataRow2);
							base.InsertSqlDataOneRow(this.class130_0, this.class130_0.tJ_ExcavationFile);
							this.class130_0.tJ_ExcavationFile.Clear();
						}
						continue;
					}
					dataRow2 = this.class130_0.tJ_ExcavationFile.NewRow();
					dataRow2["idExcavation"] = num;
					dataRow2["typeFile"] = 1107;
					dataRow2["FileName"] = text4;
					this.class130_0.tJ_ExcavationFile.Rows.Add(dataRow2);
					base.InsertSqlDataOneRow(this.class130_0, this.class130_0.tJ_ExcavationFile);
					this.class130_0.tJ_ExcavationFile.Clear();
					continue;
					IL_9B5:
					MessageBox.Show("Что то с адресом");
					goto IL_9C0;
				}
				this.method_2(null);
				MessageBox.Show("Ура!!!");
			}
		}

		private void toolStripButton_29_Click(object sender, EventArgs e)
		{
			new Form67(this.int_0)
			{
				MdiParent = base.MdiParent,
				SqlSettings = this.SqlSettings
			}.Show();
		}

		private void toolStripButton_30_Click(object sender, EventArgs e)
		{
			new Form68
			{
				MdiParent = base.MdiParent,
				SqlSettings = this.SqlSettings
			}.Show();
		}

		private void toolStripButton_32_Click(object sender, EventArgs e)
		{
			new Form66
			{
				MdiParent = base.MdiParent,
				SqlSettings = this.SqlSettings
			}.Show();
		}

		private void toolStripButton_5_Click(object sender, EventArgs e)
		{
			int num = this.int_0;
			Form61 form = new Form61(-1, this.int_0);
			form.SqlSettings = this.SqlSettings;
			if (form.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class130_0, this.class130_0.vJ_Excavation, true, this.method_1());
				this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_32.Name, num.ToString(), false);
				base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationAddress, true);
				this.dataGridViewExcelFilter_1.SearchGrid(this.dataGridViewTextBoxColumn_4.Name, form.Id.ToString(), false);
			}
		}

		private void toolStripButton_6_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_1.CurrentRow != null)
			{
				int num = this.int_0;
				Form61 form = new Form61(Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value), this.int_0);
				form.SqlSettings = this.SqlSettings;
				if (form.ShowDialog() == DialogResult.OK)
				{
					base.SelectSqlData(this.class130_0, this.class130_0.vJ_Excavation, true, this.method_1());
					this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_32.Name, num.ToString(), false);
					base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationAddress, true);
					this.dataGridViewExcelFilter_1.SearchGrid(this.dataGridViewTextBoxColumn_4.Name, form.Id.ToString(), false);
				}
			}
		}

		private void toolStripButton_7_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_1.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить текущий адрес?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && base.DeleteSqlDataById(this.class130_0.tJ_ExcavationAddress, Convert.ToInt32(this.dataGridViewExcelFilter_1.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value)))
			{
				this.dataGridViewExcelFilter_1.Rows.Remove(this.dataGridViewExcelFilter_1.CurrentRow);
				int num = this.int_0;
				base.SelectSqlData(this.class130_0, this.class130_0.vJ_Excavation, true, this.method_1());
				this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_32.Name, num.ToString(), false);
			}
		}

		private void dataGridViewExcelFilter_1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.toolStripButton_6.Visible && this.toolStripButton_6.Enabled && this.toolStrip_2.Visible && this.toolStrip_2.Enabled)
			{
				this.toolStripButton_6_Click(sender, e);
			}
		}

		private void toolStripButton_9_Click(object sender, EventArgs e)
		{
			int num = this.int_0;
			Form65 form = new Form65(-1, this.int_0);
			form.SqlSettings = this.SqlSettings;
			if (form.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class130_0, this.class130_0.vJ_Excavation, true, this.method_1());
				this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_32.Name, num.ToString(), false);
				base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationSchmObj, true);
				this.dataGridViewExcelFilter_2.SearchGrid(this.dataGridViewTextBoxColumn_8.Name, form.method_2().ToString(), false);
			}
		}

		private void toolStripButton_10_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_2.CurrentRow != null)
			{
				int num = this.int_0;
				if (new Form65(Convert.ToInt32(this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_8.Name].Value), this.int_0)
				{
					SqlSettings = this.SqlSettings
				}.ShowDialog() == DialogResult.OK)
				{
					base.SelectSqlData(this.class130_0, this.class130_0.vJ_Excavation, true, this.method_1());
					this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_32.Name, num.ToString(), false);
					base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationSchmObj, true);
					this.dataGridViewExcelFilter_2.SearchGrid(this.dataGridViewTextBoxColumn_8.Name, this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_8.Name].Value.ToString(), false);
				}
			}
		}

		private void dataGridViewExcelFilter_2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.toolStripButton_10.Visible && this.toolStripButton_10.Enabled && this.toolStrip_3.Visible && this.toolStrip_3.Enabled)
			{
				this.toolStripButton_10_Click(sender, e);
			}
		}

		private void toolStripButton_11_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_2.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить текущую кабельную линию?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && base.DeleteSqlDataById(this.class130_0.tJ_ExcavationSchmObj, Convert.ToInt32(this.dataGridViewExcelFilter_2.CurrentRow.Cells[this.dataGridViewTextBoxColumn_8.Name].Value)))
			{
				this.dataGridViewExcelFilter_2.Rows.Remove(this.dataGridViewExcelFilter_2.CurrentRow);
				int num = this.int_0;
				base.SelectSqlData(this.class130_0, this.class130_0.vJ_Excavation, true, this.method_1());
				this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_32.Name, num.ToString(), false);
			}
		}

		private void dataGridViewExcelFilter_0_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			this.dataGridViewExcelFilter_0.AutoResizeRow(e.RowIndex);
		}

		private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if (this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_13.Name, e.RowIndex].Value != null && this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_13.Name, e.RowIndex].Value != DBNull.Value)
				{
					e.CellStyle.BackColor = Color.LightSkyBlue;
				}
				if (this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_37.Name, e.RowIndex].Value != null && this.dataGridViewExcelFilter_0[this.dataGridViewTextBoxColumn_37.Name, e.RowIndex].Value != DBNull.Value)
				{
					e.CellStyle.BackColor = Color.LightGreen;
				}
				if (this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_15.Name, e.RowIndex].Value != null && this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_15.Name, e.RowIndex].Value != DBNull.Value)
				{
					e.CellStyle.BackColor = Color.LightGray;
				}
				if (this.dataGridViewExcelFilter_0[this.dataGridViewFilterCheckBoxColumn_0.Name, e.RowIndex].Value != null && this.dataGridViewExcelFilter_0[this.dataGridViewFilterCheckBoxColumn_0.Name, e.RowIndex].Value != DBNull.Value && Convert.ToBoolean(this.dataGridViewExcelFilter_0[this.dataGridViewFilterCheckBoxColumn_0.Name, e.RowIndex].Value))
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic);
				}
			}
		}

		private void toolStripButton_12_Click(object sender, EventArgs e)
		{
			int num = this.int_0;
			Form62 form = new Form62(-1, this.int_0, (Enum18)1);
			form.SqlSettings = this.SqlSettings;
			if (form.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class130_0, this.class130_0.vJ_Excavation, true, this.method_1());
				this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_32.Name, num.ToString(), false);
				base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationStatus, true);
				this.dataGridViewExcelFilter_3.SearchGrid(this.dataGridViewTextBoxColumn_38.Name, form.method_0().ToString(), false);
			}
		}

		private void toolStripButton_13_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_3.CurrentRow != null)
			{
				Form62 form = new Form62(Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_38.Name].Value), this.int_0, (Enum18)1);
				form.SqlSettings = this.SqlSettings;
				if (form.ShowDialog() == DialogResult.OK)
				{
					int num = this.int_0;
					base.SelectSqlData(this.class130_0, this.class130_0.vJ_Excavation, true, this.method_1());
					this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_32.Name, num.ToString(), false);
					base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationStatus, true);
					this.dataGridViewExcelFilter_3.SearchGrid(this.dataGridViewTextBoxColumn_38.Name, form.method_0().ToString(), false);
				}
			}
		}

		private void dataGridViewExcelFilter_3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.toolStripButton_13.Visible && this.toolStripButton_13.Enabled && this.toolStrip_4.Visible && this.toolStrip_4.Enabled)
			{
				this.toolStripButton_13_Click(sender, e);
			}
		}

		private void toolStripButton_14_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_3.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить текущий статус ордера?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && base.DeleteSqlDataById(this.class130_0.tJ_ExcavationStatus, Convert.ToInt32(this.dataGridViewExcelFilter_3.CurrentRow.Cells[this.dataGridViewTextBoxColumn_38.Name].Value)))
			{
				this.dataGridViewExcelFilter_3.Rows.Remove(this.dataGridViewExcelFilter_3.CurrentRow);
				int num = this.int_0;
				base.SelectSqlData(this.class130_0, this.class130_0.vJ_Excavation, true, this.method_1());
				this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_32.Name, num.ToString(), false);
			}
		}

		private void toolStripButton_15_Click(object sender, EventArgs e)
		{
			Form63 form = new Form63(-1, this.int_0, (Enum19)3);
			form.SqlSettings = this.SqlSettings;
			if (form.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationSurface, true);
				this.dataGridViewExcelFilter_4.SearchGrid(this.dataGridViewTextBoxColumn_12.Name, form.method_0().ToString(), false);
			}
		}

		private void toolStripButton_16_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_4.CurrentRow != null)
			{
				Form63 form = new Form63(Convert.ToInt32(this.dataGridViewExcelFilter_4.CurrentRow.Cells[this.dataGridViewTextBoxColumn_12.Name].Value), this.int_0, (Enum19)3);
				form.SqlSettings = this.SqlSettings;
				if (form.ShowDialog() == DialogResult.OK)
				{
					base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationSurface, true);
					this.dataGridViewExcelFilter_4.SearchGrid(this.dataGridViewTextBoxColumn_12.Name, form.method_0().ToString(), false);
				}
			}
		}

		private void dataGridViewExcelFilter_4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.toolStripButton_16.Visible && this.toolStripButton_16.Enabled && this.toolStrip_5.Visible && this.toolStrip_5.Enabled)
			{
				this.toolStripButton_16_Click(sender, e);
			}
		}

		private void toolStripButton_17_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_4.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить текущий материал?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && base.DeleteSqlDataById(this.class130_0.tJ_ExcavationSurface, Convert.ToInt32(this.dataGridViewExcelFilter_4.CurrentRow.Cells[this.dataGridViewTextBoxColumn_12.Name].Value)))
			{
				this.dataGridViewExcelFilter_4.Rows.Remove(this.dataGridViewExcelFilter_4.CurrentRow);
			}
		}

		private void toolStripButton_18_Click(object sender, EventArgs e)
		{
			Form63 form = new Form63(-1, this.int_0, (Enum19)1);
			form.SqlSettings = this.SqlSettings;
			if (form.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationSurface, true);
				this.dataGridViewExcelFilter_5.SearchGrid(this.dataGridViewTextBoxColumn_21.Name, form.method_0().ToString(), false);
			}
		}

		private void toolStripButton_19_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_5.CurrentRow != null)
			{
				Form63 form = new Form63(Convert.ToInt32(this.dataGridViewExcelFilter_5.CurrentRow.Cells[this.dataGridViewTextBoxColumn_21.Name].Value), this.int_0, (Enum19)1);
				form.SqlSettings = this.SqlSettings;
				if (form.ShowDialog() == DialogResult.OK)
				{
					base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationSurface, true);
					this.dataGridViewExcelFilter_5.SearchGrid(this.dataGridViewTextBoxColumn_21.Name, form.method_0().ToString(), false);
				}
			}
		}

		private void dataGridViewExcelFilter_5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.toolStripButton_19.Visible && this.toolStripButton_19.Enabled && this.toolStrip_6.Visible && this.toolStrip_6.Enabled)
			{
				this.toolStripButton_19_Click(sender, e);
			}
		}

		private void toolStripButton_20_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_5.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить текущее повреждение?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && base.DeleteSqlDataById(this.class130_0.tJ_ExcavationSurface, Convert.ToInt32(this.dataGridViewExcelFilter_5.CurrentRow.Cells[this.dataGridViewTextBoxColumn_21.Name].Value)))
			{
				this.dataGridViewExcelFilter_5.Rows.Remove(this.dataGridViewExcelFilter_5.CurrentRow);
			}
		}

		private void toolStripButton_21_Click(object sender, EventArgs e)
		{
			Form63 form = new Form63(-1, this.int_0, (Enum19)2);
			form.SqlSettings = this.SqlSettings;
			if (form.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationSurface, true);
				this.dataGridViewExcelFilter_6.SearchGrid(this.dataGridViewTextBoxColumn_23.Name, form.method_0().ToString(), false);
			}
		}

		private void toolStripButton_22_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_6.CurrentRow != null)
			{
				Form63 form = new Form63(Convert.ToInt32(this.dataGridViewExcelFilter_6.CurrentRow.Cells[this.dataGridViewTextBoxColumn_23.Name].Value), this.int_0, (Enum19)2);
				form.SqlSettings = this.SqlSettings;
				if (form.ShowDialog() == DialogResult.OK)
				{
					base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationSurface, true);
					this.dataGridViewExcelFilter_6.SearchGrid(this.dataGridViewTextBoxColumn_23.Name, form.method_0().ToString(), false);
				}
			}
		}

		private void dataGridViewExcelFilter_6_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.toolStripButton_22.Visible && this.toolStripButton_22.Enabled && this.toolStrip_7.Visible && this.toolStrip_7.Enabled)
			{
				this.toolStripButton_22_Click(sender, e);
			}
		}

		private void toolStripButton_23_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_6.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить текущую площадь восстановления?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && base.DeleteSqlDataById(this.class130_0.tJ_ExcavationSurface, Convert.ToInt32(this.dataGridViewExcelFilter_6.CurrentRow.Cells[this.dataGridViewTextBoxColumn_23.Name].Value)))
			{
				this.dataGridViewExcelFilter_6.Rows.Remove(this.dataGridViewExcelFilter_6.CurrentRow);
			}
		}

		private void toolStripButton_24_Click(object sender, EventArgs e)
		{
			Form62 form = new Form62(-1, this.int_0, (Enum18)2);
			form.SqlSettings = this.SqlSettings;
			if (form.ShowDialog() == DialogResult.OK)
			{
				int num = this.int_0;
				base.SelectSqlData(this.class130_0, this.class130_0.vJ_Excavation, true, this.method_1());
				this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_32.Name, num.ToString(), false);
				base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationStatus, true);
				this.dataGridViewExcelFilter_7.SearchGrid(this.dataGridViewTextBoxColumn_47.Name, form.method_0().ToString(), false);
			}
		}

		private void toolStripButton_25_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_7.CurrentRow != null)
			{
				Form62 form = new Form62(Convert.ToInt32(this.dataGridViewExcelFilter_7.CurrentRow.Cells[this.dataGridViewTextBoxColumn_47.Name].Value), this.int_0, (Enum18)2);
				form.SqlSettings = this.SqlSettings;
				if (form.ShowDialog() == DialogResult.OK)
				{
					int num = this.int_0;
					base.SelectSqlData(this.class130_0, this.class130_0.vJ_Excavation, true, this.method_1());
					this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_32.Name, num.ToString(), false);
					base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationStatus, true);
					this.dataGridViewExcelFilter_7.SearchGrid(this.dataGridViewTextBoxColumn_47.Name, form.method_0().ToString(), false);
				}
			}
		}

		private void dataGridViewExcelFilter_7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.toolStripButton_25.Visible && this.toolStripButton_25.Enabled && this.toolStrip_8.Visible && this.toolStrip_8.Enabled)
			{
				this.toolStripButton_25_Click(sender, e);
			}
		}

		private void toolStripButton_26_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_7.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить текущий статус?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && base.DeleteSqlDataById(this.class130_0.tJ_ExcavationStatus, Convert.ToInt32(this.dataGridViewExcelFilter_7.CurrentRow.Cells[this.dataGridViewTextBoxColumn_47.Name].Value)))
			{
				this.dataGridViewExcelFilter_7.Rows.Remove(this.dataGridViewExcelFilter_7.CurrentRow);
				int num = this.int_0;
				base.SelectSqlData(this.class130_0, this.class130_0.vJ_Excavation, true, this.method_1());
				this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_32.Name, num.ToString(), false);
			}
		}

		private void method_6(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.class130_0.tJ_ExcavationFile.Clear();
				foreach (string text in openFileDialog.FileNames)
				{
					DataRow dataRow = this.class130_0.tJ_ExcavationFile.NewRow();
					dataRow["idExcavation"] = this.int_0;
					dataRow["typeFile"] = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
					dataRow["FileName"] = text;
					dataRow["File"] = File.ReadAllBytes(text);
					this.class130_0.tJ_ExcavationFile.Rows.Add(dataRow);
				}
				base.InsertSqlData(this.class130_0, this.class130_0.tJ_ExcavationFile);
				this.class130_0.tJ_ExcavationFile.Clear();
				base.SelectSqlData(this.dataTable_0, true, "order by filename", null, false, 0);
			}
		}

		private void toolStripButton_28_Click(object sender, EventArgs e)
		{
			foreach (object obj in this.dataGridViewExcelFilter_8.SelectedRows)
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				base.DeleteSqlDataById(this.class130_0.tJ_ExcavationFile, Convert.ToInt32(dataGridViewRow.Cells[this.dataGridViewTextBoxColumn_28.Name].Value));
			}
			base.SelectSqlData(this.dataTable_0, true, "order by filename", null, false, 0);
		}

		private void dataGridViewExcelFilter_8_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
			if (((DataGridView)sender).RowCount > 0 && this.dataGridViewExcelFilter_8[this.dataGridViewTextBoxColumn_31.Name, e.RowIndex].Value != null)
			{
				if (e.ColumnIndex == this.dataGridViewExcelFilter_8.Columns[this.dataGridViewLinkColumn_0.Name].Index)
				{
					if (!string.IsNullOrEmpty(Path.GetFileName(this.dataGridViewExcelFilter_8[this.dataGridViewTextBoxColumn_31.Name, e.RowIndex].Value.ToString())))
					{
						e.Value = Path.GetFileName(this.dataGridViewExcelFilter_8[this.dataGridViewTextBoxColumn_31.Name, e.RowIndex].Value.ToString());
					}
					else
					{
						e.Value = this.dataGridViewExcelFilter_8[this.dataGridViewTextBoxColumn_31.Name, e.RowIndex].Value.ToString();
					}
				}
				if (e.ColumnIndex == this.dataGridViewExcelFilter_8.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index)
				{
					Icon icon = FormLbr.Classes.FileInfo.IconOfFile(this.dataGridViewExcelFilter_8[this.dataGridViewTextBoxColumn_31.Name, e.RowIndex].Value.ToString());
					if (icon != null)
					{
						e.Value = icon.ToBitmap();
					}
				}
			}
		}

		private void dataGridViewExcelFilter_8_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.dataGridViewExcelFilter_8.CurrentRow == null)
			{
				return;
			}
			try
			{
				int num = Convert.ToInt32(this.dataGridViewExcelFilter_8.CurrentRow.Cells[this.dataGridViewTextBoxColumn_28.Name].Value);
				if (e.ColumnIndex == this.dataGridViewExcelFilter_8.Columns[this.dataGridViewLinkColumn_0.Name].Index)
				{
					base.SelectSqlData(this.class130_0, this.class130_0.vJ_ExcavationFile, true, "where id = " + num.ToString());
					string path = this.class130_0.vJ_ExcavationFile.method_2(num)["FileName"].ToString();
					object obj = this.class130_0.vJ_ExcavationFile.method_2(num)["File"];
					if (obj == DBNull.Value)
					{
						Process.Start(Path.GetDirectoryName(path));
					}
					else
					{
						byte[] array = (byte[])obj;
						string text = Path.GetTempFileName();
						text = Path.ChangeExtension(text, Path.GetExtension(path));
						FileStream fileStream = File.Create(text);
						fileStream.Write(array, 0, array.Length);
						fileStream.Close();
						new Process
						{
							StartInfo = 
							{
								FileName = text,
								UseShellExecute = true
							}
						}.Start();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		private void treeView_0_AfterSelect(object sender, TreeViewEventArgs e)
		{
			this.bindingSource_8.Filter = "idExcavation = " + this.int_0.ToString();
			if (this.treeView_0.SelectedNode != null && this.treeView_0.SelectedNode.Tag != null)
			{
				this.bindingSource_8.Filter = "idExcavation = " + this.int_0.ToString() + " and typeFile = " + this.treeView_0.SelectedNode.Tag.ToString();
			}
		}

		private void tabControl_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_3();
		}

		private void method_7()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormJournalExcavation));
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_2 = new ToolStripButton();
			this.toolStripButton_3 = new ToolStripButton();
			this.toolStripButton_4 = new ToolStripButton();
			this.toolStripSeparator_2 = new ToolStripSeparator();
			this.toolStripButton_31 = new ToolStripButton();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripButton_8 = new ToolStripButton();
			this.toolStripButton_27 = new ToolStripButton();
			this.toolStripSeparator_1 = new ToolStripSeparator();
			this.toolStripButton_29 = new ToolStripButton();
			this.toolStripButton_30 = new ToolStripButton();
			this.toolStripButton_32 = new ToolStripButton();
			this.splitContainer_0 = new SplitContainer();
			this.checkBox_0 = new CheckBox();
			this.checkBox_1 = new CheckBox();
			this.dateTimePicker_0 = new DateTimePicker();
			this.label_0 = new Label();
			this.dateTimePicker_1 = new DateTimePicker();
			this.label_1 = new Label();
			this.toolStrip_1 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.splitContainer_1 = new SplitContainer();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_32 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_33 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_34 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_35 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_36 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewTextBoxColumn_37 = new DataGridViewTextBoxColumn();
			this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
			this.dataGridViewFilterCheckBoxColumn_0 = new DataGridViewFilterCheckBoxColumn();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.class130_0 = new Class130();
			this.tabControl_0 = new TabControl();
			this.tabPage_0 = new TabPage();
			this.dataGridViewExcelFilter_1 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.toolStrip_2 = new ToolStrip();
			this.toolStripButton_5 = new ToolStripButton();
			this.toolStripButton_6 = new ToolStripButton();
			this.toolStripButton_7 = new ToolStripButton();
			this.tabPage_3 = new TabPage();
			this.dataGridViewExcelFilter_2 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.bindingSource_2 = new BindingSource(this.icontainer_0);
			this.toolStrip_3 = new ToolStrip();
			this.toolStripButton_9 = new ToolStripButton();
			this.toolStripButton_10 = new ToolStripButton();
			this.toolStripButton_11 = new ToolStripButton();
			this.tabPage_4 = new TabPage();
			this.dataGridViewExcelFilter_3 = new DataGridViewExcelFilter();
			this.bindingSource_3 = new BindingSource(this.icontainer_0);
			this.toolStrip_4 = new ToolStrip();
			this.toolStripButton_12 = new ToolStripButton();
			this.toolStripButton_13 = new ToolStripButton();
			this.toolStripButton_14 = new ToolStripButton();
			this.tabPage_5 = new TabPage();
			this.dataGridViewExcelFilter_7 = new DataGridViewExcelFilter();
			this.bindingSource_7 = new BindingSource(this.icontainer_0);
			this.toolStrip_8 = new ToolStrip();
			this.toolStripButton_24 = new ToolStripButton();
			this.toolStripButton_25 = new ToolStripButton();
			this.toolStripButton_26 = new ToolStripButton();
			this.tabPage_1 = new TabPage();
			this.splitContainer_2 = new SplitContainer();
			this.dataGridViewExcelFilter_5 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
			this.bindingSource_5 = new BindingSource(this.icontainer_0);
			this.toolStrip_6 = new ToolStrip();
			this.toolStripButton_18 = new ToolStripButton();
			this.toolStripButton_19 = new ToolStripButton();
			this.toolStripButton_20 = new ToolStripButton();
			this.dataGridViewExcelFilter_6 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
			this.bindingSource_6 = new BindingSource(this.icontainer_0);
			this.toolStrip_7 = new ToolStrip();
			this.toolStripButton_21 = new ToolStripButton();
			this.toolStripButton_22 = new ToolStripButton();
			this.toolStripButton_23 = new ToolStripButton();
			this.tabPage_2 = new TabPage();
			this.dataGridViewExcelFilter_4 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
			this.bindingSource_4 = new BindingSource(this.icontainer_0);
			this.toolStrip_5 = new ToolStrip();
			this.toolStripButton_15 = new ToolStripButton();
			this.toolStripButton_16 = new ToolStripButton();
			this.toolStripButton_17 = new ToolStripButton();
			this.tabPage_6 = new TabPage();
			this.splitContainer_3 = new SplitContainer();
			this.treeView_0 = new TreeView();
			this.dataGridViewExcelFilter_8 = new DataGridViewExcelFilter();
			this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
			this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
			this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
			this.dataGridViewLinkColumn_0 = new DataGridViewLinkColumn();
			this.bindingSource_8 = new BindingSource(this.icontainer_0);
			this.toolStrip_9 = new ToolStrip();
			this.toolStripSplitButton_0 = new ToolStripSplitButton();
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripButton_28 = new ToolStripButton();
			this.dataGridViewTextBoxColumn_38 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_39 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_40 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_41 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_42 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_43 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_44 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_45 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_46 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_47 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_48 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_49 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_50 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_51 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_52 = new DataGridViewTextBoxColumn();
			this.toolStrip_0.SuspendLayout();
			this.splitContainer_0.Panel1.SuspendLayout();
			this.splitContainer_0.Panel2.SuspendLayout();
			this.splitContainer_0.SuspendLayout();
			this.toolStrip_1.SuspendLayout();
			this.splitContainer_1.Panel1.SuspendLayout();
			this.splitContainer_1.Panel2.SuspendLayout();
			this.splitContainer_1.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_0).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			((ISupportInitialize)this.class130_0).BeginInit();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_1).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			this.toolStrip_2.SuspendLayout();
			this.tabPage_3.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_2).BeginInit();
			((ISupportInitialize)this.bindingSource_2).BeginInit();
			this.toolStrip_3.SuspendLayout();
			this.tabPage_4.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_3).BeginInit();
			((ISupportInitialize)this.bindingSource_3).BeginInit();
			this.toolStrip_4.SuspendLayout();
			this.tabPage_5.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_7).BeginInit();
			((ISupportInitialize)this.bindingSource_7).BeginInit();
			this.toolStrip_8.SuspendLayout();
			this.tabPage_1.SuspendLayout();
			this.splitContainer_2.Panel1.SuspendLayout();
			this.splitContainer_2.Panel2.SuspendLayout();
			this.splitContainer_2.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_5).BeginInit();
			((ISupportInitialize)this.bindingSource_5).BeginInit();
			this.toolStrip_6.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_6).BeginInit();
			((ISupportInitialize)this.bindingSource_6).BeginInit();
			this.toolStrip_7.SuspendLayout();
			this.tabPage_2.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_4).BeginInit();
			((ISupportInitialize)this.bindingSource_4).BeginInit();
			this.toolStrip_5.SuspendLayout();
			this.tabPage_6.SuspendLayout();
			this.splitContainer_3.Panel1.SuspendLayout();
			this.splitContainer_3.Panel2.SuspendLayout();
			this.splitContainer_3.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_8).BeginInit();
			((ISupportInitialize)this.bindingSource_8).BeginInit();
			this.toolStrip_9.SuspendLayout();
			base.SuspendLayout();
			this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_2,
				this.toolStripButton_3,
				this.toolStripButton_4,
				this.toolStripSeparator_2,
				this.toolStripButton_31,
				this.toolStripSeparator_0,
				this.toolStripButton_8,
				this.toolStripButton_27,
				this.toolStripSeparator_1,
				this.toolStripButton_29,
				this.toolStripButton_30,
				this.toolStripButton_32
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "toolStripMain";
			this.toolStrip_0.Size = new Size(1011, 25);
			this.toolStrip_0.TabIndex = 0;
			this.toolStrip_0.Text = "Главаня панель кнопок";
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = Resources.ElementAdd;
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "toolBtnAddExcavation";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "Новая раскопка";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = Resources.ElementEdit;
			this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_3.Name = "toolBtnEditExcavation";
			this.toolStripButton_3.Size = new Size(23, 22);
			this.toolStripButton_3.Text = "Редактировать";
			this.toolStripButton_3.Click += this.toolStripButton_3_Click;
			this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_4.Image = Resources.ElementDel;
			this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_4.Name = "toolBtnDelExcavation";
			this.toolStripButton_4.Size = new Size(23, 22);
			this.toolStripButton_4.Text = "Удалить раскопку";
			this.toolStripButton_4.Click += this.toolStripButton_4_Click;
			this.toolStripSeparator_2.Name = "toolStripSeparator3";
			this.toolStripSeparator_2.Size = new Size(6, 25);
			this.toolStripButton_31.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_31.Image = Resources.refresh_16;
			this.toolStripButton_31.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_31.Name = "toolBtnRefresh";
			this.toolStripButton_31.Size = new Size(23, 22);
			this.toolStripButton_31.Text = "Обновить";
			this.toolStripButton_31.Click += this.toolStripButton_31_Click;
			this.toolStripSeparator_0.Name = "toolStripSeparator1";
			this.toolStripSeparator_0.Size = new Size(6, 25);
			this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_8.Image = Resources.partners;
			this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_8.Name = "toolBtnContractor";
			this.toolStripButton_8.Size = new Size(23, 22);
			this.toolStripButton_8.Text = "Подрядчики";
			this.toolStripButton_8.Click += this.toolStripButton_8_Click;
			this.toolStripButton_27.Alignment = ToolStripItemAlignment.Right;
			this.toolStripButton_27.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_27.Image = Resources.Export;
			this.toolStripButton_27.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_27.Name = "toolBtnImportOldExcavation";
			this.toolStripButton_27.Size = new Size(23, 22);
			this.toolStripButton_27.Text = "програзка из старой базы";
			this.toolStripButton_27.Click += this.toolStripButton_27_Click;
			this.toolStripSeparator_1.Name = "toolStripSeparator2";
			this.toolStripSeparator_1.Size = new Size(6, 25);
			this.toolStripButton_29.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_29.Image = Resources.distributor_report;
			this.toolStripButton_29.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_29.Name = "toolBtnAct";
			this.toolStripButton_29.Size = new Size(23, 22);
			this.toolStripButton_29.Text = "Акт";
			this.toolStripButton_29.Click += this.toolStripButton_29_Click;
			this.toolStripButton_30.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_30.Image = Resources.report;
			this.toolStripButton_30.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_30.Name = "toolBtnReport";
			this.toolStripButton_30.Size = new Size(23, 22);
			this.toolStripButton_30.Text = "Отчет";
			this.toolStripButton_30.Click += this.toolStripButton_30_Click;
			this.toolStripButton_32.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_32.Image = Resources.report_go;
			this.toolStripButton_32.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_32.Name = "toolBtnExport";
			this.toolStripButton_32.Size = new Size(23, 22);
			this.toolStripButton_32.Text = "Экспорт";
			this.toolStripButton_32.Click += this.toolStripButton_32_Click;
			this.splitContainer_0.Dock = DockStyle.Fill;
			this.splitContainer_0.FixedPanel = FixedPanel.Panel1;
			this.splitContainer_0.Location = new Point(0, 25);
			this.splitContainer_0.Name = "splitContainerMain";
			this.splitContainer_0.Panel1.Controls.Add(this.checkBox_0);
			this.splitContainer_0.Panel1.Controls.Add(this.checkBox_1);
			this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_0);
			this.splitContainer_0.Panel1.Controls.Add(this.label_0);
			this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_1);
			this.splitContainer_0.Panel1.Controls.Add(this.label_1);
			this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_1);
			this.splitContainer_0.Panel1MinSize = 158;
			this.splitContainer_0.Panel2.Controls.Add(this.splitContainer_1);
			this.splitContainer_0.Size = new Size(1011, 461);
			this.splitContainer_0.SplitterDistance = 158;
			this.splitContainer_0.TabIndex = 1;
			this.checkBox_0.AutoSize = true;
			this.checkBox_0.Checked = true;
			this.checkBox_0.CheckState = CheckState.Checked;
			this.checkBox_0.Location = new Point(12, 106);
			this.checkBox_0.Name = "checkBoxNoPay";
			this.checkBox_0.Size = new Size(128, 17);
			this.checkBox_0.TabIndex = 6;
			this.checkBox_0.Text = "Скрыть оплаченные";
			this.checkBox_0.UseVisualStyleBackColor = true;
			this.checkBox_1.AutoSize = true;
			this.checkBox_1.Location = new Point(12, 129);
			this.checkBox_1.Name = "checkBoxAgreed";
			this.checkBox_1.Size = new Size(106, 17);
			this.checkBox_1.TabIndex = 5;
			this.checkBox_1.Text = "Согласованные";
			this.checkBox_1.UseVisualStyleBackColor = true;
			this.checkBox_1.Visible = false;
			this.dateTimePicker_0.Location = new Point(12, 80);
			this.dateTimePicker_0.Name = "dateTimePickerEnd";
			this.dateTimePicker_0.Size = new Size(142, 20);
			this.dateTimePicker_0.TabIndex = 4;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 64);
			this.label_0.Name = "label2";
			this.label_0.Size = new Size(89, 13);
			this.label_0.TabIndex = 3;
			this.label_0.Text = "Дата окончания";
			this.dateTimePicker_1.Location = new Point(12, 41);
			this.dateTimePicker_1.Name = "dateTimePickerBeg";
			this.dateTimePicker_1.Size = new Size(142, 20);
			this.dateTimePicker_1.TabIndex = 2;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(12, 25);
			this.label_1.Name = "label1";
			this.label_1.Size = new Size(71, 13);
			this.label_1.TabIndex = 1;
			this.label_1.Text = "Дата начала";
			this.toolStrip_1.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripButton_1
			});
			this.toolStrip_1.Location = new Point(0, 0);
			this.toolStrip_1.Name = "toolStripFilter";
			this.toolStrip_1.Size = new Size(158, 25);
			this.toolStrip_1.TabIndex = 0;
			this.toolStrip_1.Text = "toolStrip1";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.filter;
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "toolBtnApplyFilter";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Применить фильтр";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.filter_delete;
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "toolBtnDelFilter";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Убрать фильтр";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.splitContainer_1.Dock = DockStyle.Fill;
			this.splitContainer_1.Location = new Point(0, 0);
			this.splitContainer_1.Name = "splitContainerGrid";
			this.splitContainer_1.Orientation = Orientation.Horizontal;
			this.splitContainer_1.Panel1.Controls.Add(this.dataGridViewExcelFilter_0);
			this.splitContainer_1.Panel2.Controls.Add(this.tabControl_0);
			this.splitContainer_1.Size = new Size(849, 461);
			this.splitContainer_1.SplitterDistance = 281;
			this.splitContainer_1.TabIndex = 0;
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_32,
				this.dataGridViewFilterTextBoxColumn_0,
				this.dataGridViewFilterTextBoxColumn_1,
				this.dataGridViewFilterTextBoxColumn_2,
				this.dataGridViewFilterTextBoxColumn_3,
				this.dataGridViewFilterTextBoxColumn_4,
				this.dataGridViewFilterTextBoxColumn_5,
				this.dataGridViewFilterTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_33,
				this.dataGridViewFilterTextBoxColumn_7,
				this.dataGridViewTextBoxColumn_34,
				this.dataGridViewTextBoxColumn_35,
				this.dataGridViewFilterTextBoxColumn_8,
				this.dataGridViewFilterTextBoxColumn_9,
				this.dataGridViewFilterTextBoxColumn_10,
				this.dataGridViewFilterTextBoxColumn_11,
				this.dataGridViewFilterTextBoxColumn_12,
				this.dataGridViewFilterTextBoxColumn_13,
				this.dataGridViewTextBoxColumn_36,
				this.dataGridViewFilterTextBoxColumn_14,
				this.dataGridViewTextBoxColumn_37,
				this.dataGridViewFilterTextBoxColumn_15,
				this.dataGridViewFilterCheckBoxColumn_0
			});
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_1;
			this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
			this.dataGridViewExcelFilter_0.MultiSelect = false;
			this.dataGridViewExcelFilter_0.Name = "dgvExcavation";
			this.dataGridViewExcelFilter_0.ReadOnly = true;
			this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_0.Size = new Size(849, 281);
			this.dataGridViewExcelFilter_0.TabIndex = 0;
			this.dataGridViewExcelFilter_0.VirtualMode = true;
			this.dataGridViewExcelFilter_0.CellDoubleClick += this.dataGridViewExcelFilter_0_CellDoubleClick;
			this.dataGridViewExcelFilter_0.CellFormatting += this.dataGridViewExcelFilter_0_CellFormatting;
			this.dataGridViewExcelFilter_0.RowPostPaint += this.dataGridViewExcelFilter_0_RowPostPaint;
			this.dataGridViewTextBoxColumn_32.DataPropertyName = "id";
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_32.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewTextBoxColumn_32.HeaderText = "id";
			this.dataGridViewTextBoxColumn_32.Name = "idExDgvColumn";
			this.dataGridViewTextBoxColumn_32.ReadOnly = true;
			this.dataGridViewTextBoxColumn_32.Visible = false;
			this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "num";
			this.dataGridViewFilterTextBoxColumn_0.HeaderText = "№";
			this.dataGridViewFilterTextBoxColumn_0.Name = "numDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.False;
			this.dataGridViewFilterTextBoxColumn_0.Width = 40;
			this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "datebeg";
			dataGridViewCellStyle2.Format = "d";
			dataGridViewCellStyle2.NullValue = null;
			this.dataGridViewFilterTextBoxColumn_1.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Дата нач.";
			this.dataGridViewFilterTextBoxColumn_1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.False;
			this.dataGridViewFilterTextBoxColumn_1.Width = 80;
			this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "region";
			this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Район";
			this.dataGridViewFilterTextBoxColumn_2.Name = "regionDataGridViewTextBoxColumn1";
			this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "SR";
			this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Сет. район";
			this.dataGridViewFilterTextBoxColumn_3.Name = "srDgvColumn";
			this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_3.Width = 70;
			this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "address";
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_4.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Адрес";
			this.dataGridViewFilterTextBoxColumn_4.Name = "addressDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_4.Width = 170;
			this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "nameKL";
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_5.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Наименование КЛ";
			this.dataGridViewFilterTextBoxColumn_5.Name = "nameKLDgvColumnExcavation";
			this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_5.Width = 150;
			this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "typeWorkscr";
			this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Вид работ";
			this.dataGridViewFilterTextBoxColumn_6.Name = "typeWorkscrDataGridViewTextBoxColumn";
			this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_33.DataPropertyName = "idcontractor";
			this.dataGridViewTextBoxColumn_33.HeaderText = "idcontractor";
			this.dataGridViewTextBoxColumn_33.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_33.ReadOnly = true;
			this.dataGridViewTextBoxColumn_33.Visible = false;
			this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "nameContractor";
			this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Подрядчик";
			this.dataGridViewFilterTextBoxColumn_7.Name = "nameContractorDgvColumn";
			this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_34.DataPropertyName = "typework";
			this.dataGridViewTextBoxColumn_34.HeaderText = "typework";
			this.dataGridViewTextBoxColumn_34.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_34.ReadOnly = true;
			this.dataGridViewTextBoxColumn_34.Visible = false;
			this.dataGridViewTextBoxColumn_35.DataPropertyName = "typeWorkName";
			this.dataGridViewTextBoxColumn_35.HeaderText = "typeWorkName";
			this.dataGridViewTextBoxColumn_35.Name = "typeWorkNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_35.ReadOnly = true;
			this.dataGridViewTextBoxColumn_35.Visible = false;
			this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "dateBegOrder";
			dataGridViewCellStyle5.Format = "d";
			this.dataGridViewFilterTextBoxColumn_8.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Ордер от";
			this.dataGridViewFilterTextBoxColumn_8.Name = "dateBegOrderDgvColumn";
			this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_8.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "dateEndOrder";
			dataGridViewCellStyle6.Format = "d";
			this.dataGridViewFilterTextBoxColumn_9.DefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridViewFilterTextBoxColumn_9.HeaderText = "Ордер до";
			this.dataGridViewFilterTextBoxColumn_9.Name = "dateEndOrderDgvColumn";
			this.dataGridViewFilterTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_9.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "statusOrder";
			this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Статус ордера";
			this.dataGridViewFilterTextBoxColumn_10.Name = "statusOrderDgvColumn";
			this.dataGridViewFilterTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_10.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "StatusWork";
			this.dataGridViewFilterTextBoxColumn_11.HeaderText = "Состояние работ";
			this.dataGridViewFilterTextBoxColumn_11.Name = "StatusWork";
			this.dataGridViewFilterTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_11.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "Permission";
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_12.DefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridViewFilterTextBoxColumn_12.HeaderText = "№ и дата разрешения";
			this.dataGridViewFilterTextBoxColumn_12.Name = "NumPermissionDgvColumn";
			this.dataGridViewFilterTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_12.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "dateUnderAsphalt";
			dataGridViewCellStyle8.Format = "d";
			this.dataGridViewFilterTextBoxColumn_13.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridViewFilterTextBoxColumn_13.HeaderText = "Сдано под асф-ие";
			this.dataGridViewFilterTextBoxColumn_13.Name = "dateUnderAsphaltDgvExcavation";
			this.dataGridViewFilterTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_13.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_36.DataPropertyName = "dateAsphalt";
			dataGridViewCellStyle9.Format = "d";
			this.dataGridViewTextBoxColumn_36.DefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridViewTextBoxColumn_36.HeaderText = "Асф-ие";
			this.dataGridViewTextBoxColumn_36.Name = "dateAsphaltDgvExcavation";
			this.dataGridViewTextBoxColumn_36.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_14.DataPropertyName = "dateEnd";
			dataGridViewCellStyle10.Format = "d";
			this.dataGridViewFilterTextBoxColumn_14.DefaultCellStyle = dataGridViewCellStyle10;
			this.dataGridViewFilterTextBoxColumn_14.HeaderText = "Сдано адм-ии";
			this.dataGridViewFilterTextBoxColumn_14.Name = "dateEndDgvExcavation";
			this.dataGridViewFilterTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_14.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_37.DataPropertyName = "dateEndPlanned";
			this.dataGridViewTextBoxColumn_37.HeaderText = "Плановая дата";
			this.dataGridViewTextBoxColumn_37.Name = "dateEndPlannedDgvExcavation";
			this.dataGridViewTextBoxColumn_37.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "datePay";
			dataGridViewCellStyle11.Format = "d";
			this.dataGridViewFilterTextBoxColumn_15.DefaultCellStyle = dataGridViewCellStyle11;
			this.dataGridViewFilterTextBoxColumn_15.HeaderText = "Перед-но к оплате";
			this.dataGridViewFilterTextBoxColumn_15.Name = "datePayDgvColumn";
			this.dataGridViewFilterTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewFilterTextBoxColumn_15.Resizable = DataGridViewTriState.True;
			this.dataGridViewFilterTextBoxColumn_15.Visible = false;
			this.dataGridViewFilterCheckBoxColumn_0.DataPropertyName = "agreed";
			this.dataGridViewFilterCheckBoxColumn_0.HeaderText = "Согл-но";
			this.dataGridViewFilterCheckBoxColumn_0.Name = "agreedDgvColumn";
			this.dataGridViewFilterCheckBoxColumn_0.ReadOnly = true;
			this.bindingSource_1.DataMember = "vJ_Excavation";
			this.bindingSource_1.DataSource = this.class130_0;
			this.bindingSource_1.CurrentChanged += this.bindingSource_1_CurrentChanged;
			this.class130_0.DataSetName = "DataSetExcavation";
			this.class130_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Controls.Add(this.tabPage_3);
			this.tabControl_0.Controls.Add(this.tabPage_4);
			this.tabControl_0.Controls.Add(this.tabPage_5);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Controls.Add(this.tabPage_2);
			this.tabControl_0.Controls.Add(this.tabPage_6);
			this.tabControl_0.Dock = DockStyle.Fill;
			this.tabControl_0.Location = new Point(0, 0);
			this.tabControl_0.Name = "tabControl";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(849, 176);
			this.tabControl_0.TabIndex = 0;
			this.tabControl_0.SelectedIndexChanged += this.tabControl_0_SelectedIndexChanged;
			this.tabPage_0.Controls.Add(this.dataGridViewExcelFilter_1);
			this.tabPage_0.Controls.Add(this.toolStrip_2);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tabPageAddress";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(841, 150);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Адреса";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7
			});
			this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_0;
			this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_1.Location = new Point(27, 3);
			this.dataGridViewExcelFilter_1.Name = "dgvAddress";
			this.dataGridViewExcelFilter_1.ReadOnly = true;
			this.dataGridViewExcelFilter_1.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_1.Size = new Size(811, 144);
			this.dataGridViewExcelFilter_1.TabIndex = 1;
			this.dataGridViewExcelFilter_1.CellDoubleClick += this.dataGridViewExcelFilter_1_CellDoubleClick;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "region";
			this.dataGridViewTextBoxColumn_0.HeaderText = "Район";
			this.dataGridViewTextBoxColumn_0.Name = "regionDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "street";
			this.dataGridViewTextBoxColumn_1.HeaderText = "Улица";
			this.dataGridViewTextBoxColumn_1.Name = "streetDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "House";
			this.dataGridViewTextBoxColumn_2.HeaderText = "Дом";
			this.dataGridViewTextBoxColumn_2.Name = "houseDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_3.HeaderText = "Примечание";
			this.dataGridViewTextBoxColumn_3.Name = "commentDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_4.HeaderText = "id";
			this.dataGridViewTextBoxColumn_4.Name = "idAddressDgvColumn";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "idExcavation";
			this.dataGridViewTextBoxColumn_5.HeaderText = "idExcavation";
			this.dataGridViewTextBoxColumn_5.Name = "idExcavationDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "idRegion";
			this.dataGridViewTextBoxColumn_6.HeaderText = "idRegion";
			this.dataGridViewTextBoxColumn_6.Name = "idRegionDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "idStreet";
			this.dataGridViewTextBoxColumn_7.HeaderText = "idStreet";
			this.dataGridViewTextBoxColumn_7.Name = "idStreetDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.bindingSource_0.DataMember = "vJ_ExcavationAddress";
			this.bindingSource_0.DataSource = this.class130_0;
			this.toolStrip_2.Dock = DockStyle.Left;
			this.toolStrip_2.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_2.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_5,
				this.toolStripButton_6,
				this.toolStripButton_7
			});
			this.toolStrip_2.Location = new Point(3, 3);
			this.toolStrip_2.Name = "toolStripAddress";
			this.toolStrip_2.Size = new Size(24, 144);
			this.toolStrip_2.TabIndex = 0;
			this.toolStrip_2.Text = "Панель кнопок для адреса";
			this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_5.Image = Resources.ElementAdd;
			this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_5.Name = "tollBtnAddAddress";
			this.toolStripButton_5.Size = new Size(21, 20);
			this.toolStripButton_5.Text = "Добавить адрес";
			this.toolStripButton_5.Click += this.toolStripButton_5_Click;
			this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_6.Image = Resources.ElementEdit;
			this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_6.Name = "toolBtnEditAddress";
			this.toolStripButton_6.Size = new Size(21, 20);
			this.toolStripButton_6.Text = "Редактировать адрес";
			this.toolStripButton_6.Click += this.toolStripButton_6_Click;
			this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_7.Image = Resources.ElementDel;
			this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_7.Name = "toolBtnDelAddress";
			this.toolStripButton_7.Size = new Size(21, 20);
			this.toolStripButton_7.Text = "Удалить адрес";
			this.toolStripButton_7.Click += this.toolStripButton_7_Click;
			this.tabPage_3.Controls.Add(this.dataGridViewExcelFilter_2);
			this.tabPage_3.Controls.Add(this.toolStrip_3);
			this.tabPage_3.Location = new Point(4, 22);
			this.tabPage_3.Name = "tabPageSchmObjects";
			this.tabPage_3.Padding = new Padding(3);
			this.tabPage_3.Size = new Size(841, 150);
			this.tabPage_3.TabIndex = 3;
			this.tabPage_3.Text = "Каб. линии";
			this.tabPage_3.UseVisualStyleBackColor = true;
			this.dataGridViewExcelFilter_2.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_2.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_2.AllowUserToResizeColumns = false;
			this.dataGridViewExcelFilter_2.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_2.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_2.ColumnHeadersVisible = false;
			this.dataGridViewExcelFilter_2.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_8,
				this.dataGridViewTextBoxColumn_9,
				this.dataGridViewTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_11
			});
			this.dataGridViewExcelFilter_2.DataSource = this.bindingSource_2;
			this.dataGridViewExcelFilter_2.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_2.Location = new Point(27, 3);
			this.dataGridViewExcelFilter_2.MultiSelect = false;
			this.dataGridViewExcelFilter_2.Name = "dgvKL";
			this.dataGridViewExcelFilter_2.ReadOnly = true;
			this.dataGridViewExcelFilter_2.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_2.Size = new Size(811, 144);
			this.dataGridViewExcelFilter_2.TabIndex = 2;
			this.dataGridViewExcelFilter_2.CellDoubleClick += this.dataGridViewExcelFilter_2_CellDoubleClick;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_8.HeaderText = "id";
			this.dataGridViewTextBoxColumn_8.Name = "idKLDgvColumn";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "idExcavation";
			this.dataGridViewTextBoxColumn_9.HeaderText = "idExcavation";
			this.dataGridViewTextBoxColumn_9.Name = "idExcavationKLDgvColumn";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.Visible = false;
			this.dataGridViewTextBoxColumn_10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "name";
			this.dataGridViewTextBoxColumn_10.HeaderText = "Имя кабельной линии";
			this.dataGridViewTextBoxColumn_10.Name = "nameKLDgvColumn";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "idKL";
			this.dataGridViewTextBoxColumn_11.HeaderText = "idKL";
			this.dataGridViewTextBoxColumn_11.Name = "idSchmObjDgvColumn";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.Visible = false;
			this.bindingSource_2.DataMember = "vJ_ExcavationSchmObj";
			this.bindingSource_2.DataSource = this.class130_0;
			this.toolStrip_3.Dock = DockStyle.Left;
			this.toolStrip_3.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_3.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_9,
				this.toolStripButton_10,
				this.toolStripButton_11
			});
			this.toolStrip_3.Location = new Point(3, 3);
			this.toolStrip_3.Name = "toolStripKL";
			this.toolStrip_3.Size = new Size(24, 144);
			this.toolStrip_3.TabIndex = 1;
			this.toolStrip_3.Text = "Панель кнопок для адреса";
			this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_9.Image = Resources.ElementAdd;
			this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_9.Name = "toolBtnAddKL";
			this.toolStripButton_9.Size = new Size(21, 20);
			this.toolStripButton_9.Text = "Добавить кабельную линию";
			this.toolStripButton_9.Click += this.toolStripButton_9_Click;
			this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_10.Image = Resources.ElementEdit;
			this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_10.Name = "toolBtnEditKL";
			this.toolStripButton_10.Size = new Size(21, 20);
			this.toolStripButton_10.Text = "Редактировать кабельную линию";
			this.toolStripButton_10.Click += this.toolStripButton_10_Click;
			this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_11.Image = Resources.ElementDel;
			this.toolStripButton_11.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_11.Name = "toolBtnRemoveKL";
			this.toolStripButton_11.Size = new Size(21, 20);
			this.toolStripButton_11.Text = "Удалить кабельную линию";
			this.toolStripButton_11.Click += this.toolStripButton_11_Click;
			this.tabPage_4.Controls.Add(this.dataGridViewExcelFilter_3);
			this.tabPage_4.Controls.Add(this.toolStrip_4);
			this.tabPage_4.Location = new Point(4, 22);
			this.tabPage_4.Name = "tabPageStatusOrder";
			this.tabPage_4.Size = new Size(841, 150);
			this.tabPage_4.TabIndex = 4;
			this.tabPage_4.Text = "Статус ордера";
			this.tabPage_4.UseVisualStyleBackColor = true;
			this.dataGridViewExcelFilter_3.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_3.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_3.AllowUserToResizeColumns = false;
			this.dataGridViewExcelFilter_3.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_3.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_3.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_38,
				this.dataGridViewTextBoxColumn_39,
				this.dataGridViewTextBoxColumn_40,
				this.dataGridViewTextBoxColumn_41,
				this.dataGridViewTextBoxColumn_42,
				this.dataGridViewTextBoxColumn_43,
				this.dataGridViewTextBoxColumn_44,
				this.dataGridViewTextBoxColumn_45,
				this.dataGridViewTextBoxColumn_46
			});
			this.dataGridViewExcelFilter_3.DataSource = this.bindingSource_3;
			this.dataGridViewExcelFilter_3.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_3.Location = new Point(24, 0);
			this.dataGridViewExcelFilter_3.MultiSelect = false;
			this.dataGridViewExcelFilter_3.Name = "dgvStatusOrder";
			this.dataGridViewExcelFilter_3.ReadOnly = true;
			this.dataGridViewExcelFilter_3.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_3.Size = new Size(817, 150);
			this.dataGridViewExcelFilter_3.TabIndex = 3;
			this.dataGridViewExcelFilter_3.CellDoubleClick += this.dataGridViewExcelFilter_3_CellDoubleClick;
			this.bindingSource_3.DataMember = "vJ_ExcavationStatus";
			this.bindingSource_3.DataSource = this.class130_0;
			this.toolStrip_4.Dock = DockStyle.Left;
			this.toolStrip_4.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_4.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_12,
				this.toolStripButton_13,
				this.toolStripButton_14
			});
			this.toolStrip_4.Location = new Point(0, 0);
			this.toolStrip_4.Name = "toolStripStatusOrder";
			this.toolStrip_4.Size = new Size(24, 150);
			this.toolStrip_4.TabIndex = 2;
			this.toolStrip_4.Text = "Панель кнопок для адреса";
			this.toolStripButton_12.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_12.Image = Resources.ElementAdd;
			this.toolStripButton_12.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_12.Name = "toolBtnAddStatusOrder";
			this.toolStripButton_12.Size = new Size(21, 20);
			this.toolStripButton_12.Text = "Новый статус";
			this.toolStripButton_12.Click += this.toolStripButton_12_Click;
			this.toolStripButton_13.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_13.Image = Resources.ElementEdit;
			this.toolStripButton_13.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_13.Name = "toolBtneditStatusOrder";
			this.toolStripButton_13.Size = new Size(21, 20);
			this.toolStripButton_13.Text = "Редактировать статус";
			this.toolStripButton_13.Click += this.toolStripButton_13_Click;
			this.toolStripButton_14.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_14.Image = Resources.ElementDel;
			this.toolStripButton_14.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_14.Name = "toolBtnDelStatusOrder";
			this.toolStripButton_14.Size = new Size(21, 20);
			this.toolStripButton_14.Text = "Удалить статус";
			this.toolStripButton_14.Click += this.toolStripButton_14_Click;
			this.tabPage_5.Controls.Add(this.dataGridViewExcelFilter_7);
			this.tabPage_5.Controls.Add(this.toolStrip_8);
			this.tabPage_5.Location = new Point(4, 22);
			this.tabPage_5.Name = "tabPageStatusWork";
			this.tabPage_5.Size = new Size(841, 150);
			this.tabPage_5.TabIndex = 5;
			this.tabPage_5.Text = "Состояние работ";
			this.tabPage_5.UseVisualStyleBackColor = true;
			this.dataGridViewExcelFilter_7.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_7.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_7.AllowUserToResizeColumns = false;
			this.dataGridViewExcelFilter_7.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_7.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_7.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_47,
				this.dataGridViewTextBoxColumn_48,
				this.dataGridViewTextBoxColumn_49,
				this.dataGridViewTextBoxColumn_50,
				this.dataGridViewTextBoxColumn_51,
				this.dataGridViewTextBoxColumn_52
			});
			this.dataGridViewExcelFilter_7.DataSource = this.bindingSource_7;
			this.dataGridViewExcelFilter_7.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_7.Location = new Point(24, 0);
			this.dataGridViewExcelFilter_7.MultiSelect = false;
			this.dataGridViewExcelFilter_7.Name = "dgvStatusWork";
			this.dataGridViewExcelFilter_7.ReadOnly = true;
			this.dataGridViewExcelFilter_7.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_7.Size = new Size(817, 150);
			this.dataGridViewExcelFilter_7.TabIndex = 4;
			this.dataGridViewExcelFilter_7.CellDoubleClick += this.dataGridViewExcelFilter_7_CellDoubleClick;
			this.bindingSource_7.DataMember = "vJ_ExcavationStatus";
			this.bindingSource_7.DataSource = this.class130_0;
			this.toolStrip_8.Dock = DockStyle.Left;
			this.toolStrip_8.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_8.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_24,
				this.toolStripButton_25,
				this.toolStripButton_26
			});
			this.toolStrip_8.Location = new Point(0, 0);
			this.toolStrip_8.Name = "toolStripStatusWork";
			this.toolStrip_8.Size = new Size(24, 150);
			this.toolStrip_8.TabIndex = 3;
			this.toolStrip_8.Text = "Панель кнопок для адреса";
			this.toolStripButton_24.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_24.Image = Resources.ElementAdd;
			this.toolStripButton_24.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_24.Name = "toolBtnAddStatusWork";
			this.toolStripButton_24.Size = new Size(21, 20);
			this.toolStripButton_24.Text = "Новое состояние";
			this.toolStripButton_24.Click += this.toolStripButton_24_Click;
			this.toolStripButton_25.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_25.Image = Resources.ElementEdit;
			this.toolStripButton_25.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_25.Name = "toolBtnEditStatusWork";
			this.toolStripButton_25.Size = new Size(21, 20);
			this.toolStripButton_25.Text = "Редактировать состояние";
			this.toolStripButton_25.Click += this.toolStripButton_25_Click;
			this.toolStripButton_26.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_26.Image = Resources.ElementDel;
			this.toolStripButton_26.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_26.Name = "toolBtnDelStatusWork";
			this.toolStripButton_26.Size = new Size(21, 20);
			this.toolStripButton_26.Text = "Удалить состояние";
			this.toolStripButton_26.Click += this.toolStripButton_26_Click;
			this.tabPage_1.Controls.Add(this.splitContainer_2);
			this.tabPage_1.Location = new Point(4, 22);
			this.tabPage_1.Name = "tabPageSurface";
			this.tabPage_1.Padding = new Padding(3);
			this.tabPage_1.Size = new Size(841, 150);
			this.tabPage_1.TabIndex = 1;
			this.tabPage_1.Text = "Поверхность";
			this.tabPage_1.UseVisualStyleBackColor = true;
			this.splitContainer_2.Dock = DockStyle.Fill;
			this.splitContainer_2.Location = new Point(3, 3);
			this.splitContainer_2.Name = "splitContainerSurface";
			this.splitContainer_2.Panel1.Controls.Add(this.dataGridViewExcelFilter_5);
			this.splitContainer_2.Panel1.Controls.Add(this.toolStrip_6);
			this.splitContainer_2.Panel2.Controls.Add(this.dataGridViewExcelFilter_6);
			this.splitContainer_2.Panel2.Controls.Add(this.toolStrip_7);
			this.splitContainer_2.Size = new Size(835, 144);
			this.splitContainer_2.SplitterDistance = 278;
			this.splitContainer_2.TabIndex = 0;
			this.dataGridViewExcelFilter_5.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_5.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_5.AllowUserToResizeColumns = false;
			this.dataGridViewExcelFilter_5.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_5.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_5.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_21,
				this.dataGridViewTextBoxColumn_22
			});
			this.dataGridViewExcelFilter_5.DataSource = this.bindingSource_5;
			this.dataGridViewExcelFilter_5.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_5.Location = new Point(24, 0);
			this.dataGridViewExcelFilter_5.MultiSelect = false;
			this.dataGridViewExcelFilter_5.Name = "dgvDamage";
			this.dataGridViewExcelFilter_5.ReadOnly = true;
			this.dataGridViewExcelFilter_5.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_5.Size = new Size(254, 144);
			this.dataGridViewExcelFilter_5.TabIndex = 5;
			this.dataGridViewExcelFilter_5.CellDoubleClick += this.dataGridViewExcelFilter_5_CellDoubleClick;
			this.dataGridViewTextBoxColumn_21.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_21.HeaderText = "id";
			this.dataGridViewTextBoxColumn_21.Name = "idDamageDgvColumn";
			this.dataGridViewTextBoxColumn_21.ReadOnly = true;
			this.dataGridViewTextBoxColumn_21.Visible = false;
			this.dataGridViewTextBoxColumn_22.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_22.DataPropertyName = "surName";
			this.dataGridViewTextBoxColumn_22.HeaderText = "Повреждено";
			this.dataGridViewTextBoxColumn_22.Name = "surNameDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_22.ReadOnly = true;
			this.bindingSource_5.DataMember = "vJ_ExcavationSurface";
			this.bindingSource_5.DataSource = this.class130_0;
			this.toolStrip_6.Dock = DockStyle.Left;
			this.toolStrip_6.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_6.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_18,
				this.toolStripButton_19,
				this.toolStripButton_20
			});
			this.toolStrip_6.Location = new Point(0, 0);
			this.toolStrip_6.Name = "toolStripDamage";
			this.toolStrip_6.Size = new Size(24, 144);
			this.toolStrip_6.TabIndex = 4;
			this.toolStrip_6.Text = "Панель кнопок для адреса";
			this.toolStripButton_18.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_18.Image = Resources.ElementAdd;
			this.toolStripButton_18.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_18.Name = "toolBtnAddDamage";
			this.toolStripButton_18.Size = new Size(21, 20);
			this.toolStripButton_18.Text = "Добавить поверхность";
			this.toolStripButton_18.Click += this.toolStripButton_18_Click;
			this.toolStripButton_19.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_19.Image = Resources.ElementEdit;
			this.toolStripButton_19.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_19.Name = "toolBtnEditDamage";
			this.toolStripButton_19.Size = new Size(21, 20);
			this.toolStripButton_19.Text = "Редактировать поверхность";
			this.toolStripButton_19.Click += this.toolStripButton_19_Click;
			this.toolStripButton_20.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_20.Image = Resources.ElementDel;
			this.toolStripButton_20.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_20.Name = "toolBtnDelDamage";
			this.toolStripButton_20.Size = new Size(21, 20);
			this.toolStripButton_20.Text = "Удалить поверхность";
			this.toolStripButton_20.Click += this.toolStripButton_20_Click;
			this.dataGridViewExcelFilter_6.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_6.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_6.AllowUserToResizeColumns = false;
			this.dataGridViewExcelFilter_6.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_6.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_6.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_23,
				this.dataGridViewTextBoxColumn_24,
				this.dataGridViewTextBoxColumn_25,
				this.dataGridViewTextBoxColumn_26,
				this.dataGridViewTextBoxColumn_27
			});
			this.dataGridViewExcelFilter_6.DataSource = this.bindingSource_6;
			this.dataGridViewExcelFilter_6.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_6.Location = new Point(24, 0);
			this.dataGridViewExcelFilter_6.MultiSelect = false;
			this.dataGridViewExcelFilter_6.Name = "dgvRecovery";
			this.dataGridViewExcelFilter_6.ReadOnly = true;
			this.dataGridViewExcelFilter_6.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_6.Size = new Size(529, 144);
			this.dataGridViewExcelFilter_6.TabIndex = 6;
			this.dataGridViewExcelFilter_6.CellDoubleClick += this.dataGridViewExcelFilter_6_CellDoubleClick;
			this.dataGridViewTextBoxColumn_23.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_23.HeaderText = "id";
			this.dataGridViewTextBoxColumn_23.Name = "idrecoveryDgvColumn";
			this.dataGridViewTextBoxColumn_23.ReadOnly = true;
			this.dataGridViewTextBoxColumn_23.Visible = false;
			this.dataGridViewTextBoxColumn_24.DataPropertyName = "surName";
			this.dataGridViewTextBoxColumn_24.HeaderText = "Восстановлено";
			this.dataGridViewTextBoxColumn_24.Name = "surNameDataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_24.ReadOnly = true;
			this.dataGridViewTextBoxColumn_24.Width = 200;
			this.dataGridViewTextBoxColumn_25.DataPropertyName = "Value";
			this.dataGridViewTextBoxColumn_25.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_25.Name = "valueDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_25.ReadOnly = true;
			this.dataGridViewTextBoxColumn_25.Width = 60;
			this.dataGridViewTextBoxColumn_26.DataPropertyName = "unit";
			this.dataGridViewTextBoxColumn_26.HeaderText = "";
			this.dataGridViewTextBoxColumn_26.Name = "unitDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_26.ReadOnly = true;
			this.dataGridViewTextBoxColumn_26.Width = 60;
			this.dataGridViewTextBoxColumn_27.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_27.DataPropertyName = "comment";
			this.dataGridViewTextBoxColumn_27.HeaderText = "Примечание";
			this.dataGridViewTextBoxColumn_27.Name = "commentDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_27.ReadOnly = true;
			this.bindingSource_6.DataMember = "vJ_ExcavationSurface";
			this.bindingSource_6.DataSource = this.class130_0;
			this.toolStrip_7.Dock = DockStyle.Left;
			this.toolStrip_7.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_7.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_21,
				this.toolStripButton_22,
				this.toolStripButton_23
			});
			this.toolStrip_7.Location = new Point(0, 0);
			this.toolStrip_7.Name = "toolStripRecovery";
			this.toolStrip_7.Size = new Size(24, 144);
			this.toolStrip_7.TabIndex = 5;
			this.toolStrip_7.Text = "Панель кнопок для адреса";
			this.toolStripButton_21.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_21.Image = Resources.ElementAdd;
			this.toolStripButton_21.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_21.Name = "toolBtnAddRecovery";
			this.toolStripButton_21.Size = new Size(21, 20);
			this.toolStripButton_21.Text = "Добавить восстановление";
			this.toolStripButton_21.Click += this.toolStripButton_21_Click;
			this.toolStripButton_22.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_22.Image = Resources.ElementEdit;
			this.toolStripButton_22.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_22.Name = "toolBtnEditRecovery";
			this.toolStripButton_22.Size = new Size(21, 20);
			this.toolStripButton_22.Text = "Редактировать восстановление";
			this.toolStripButton_22.Click += this.toolStripButton_22_Click;
			this.toolStripButton_23.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_23.Image = Resources.ElementDel;
			this.toolStripButton_23.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_23.Name = "toolBtnDelRecovery";
			this.toolStripButton_23.Size = new Size(21, 20);
			this.toolStripButton_23.Text = "Удалить восстановление";
			this.toolStripButton_23.Click += this.toolStripButton_23_Click;
			this.tabPage_2.Controls.Add(this.dataGridViewExcelFilter_4);
			this.tabPage_2.Controls.Add(this.toolStrip_5);
			this.tabPage_2.Location = new Point(4, 22);
			this.tabPage_2.Name = "tabPageMaterial";
			this.tabPage_2.Padding = new Padding(3);
			this.tabPage_2.Size = new Size(841, 150);
			this.tabPage_2.TabIndex = 2;
			this.tabPage_2.Text = "Материалы";
			this.tabPage_2.UseVisualStyleBackColor = true;
			this.dataGridViewExcelFilter_4.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_4.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_4.AllowUserToResizeColumns = false;
			this.dataGridViewExcelFilter_4.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_4.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_4.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_12,
				this.dataGridViewTextBoxColumn_13,
				this.dataGridViewTextBoxColumn_14,
				this.dataGridViewTextBoxColumn_15,
				this.dataGridViewTextBoxColumn_16,
				this.dataGridViewTextBoxColumn_17,
				this.dataGridViewTextBoxColumn_18,
				this.dataGridViewTextBoxColumn_19,
				this.dataGridViewTextBoxColumn_20
			});
			this.dataGridViewExcelFilter_4.DataSource = this.bindingSource_4;
			this.dataGridViewExcelFilter_4.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_4.Location = new Point(27, 3);
			this.dataGridViewExcelFilter_4.MultiSelect = false;
			this.dataGridViewExcelFilter_4.Name = "dgvMaterial";
			this.dataGridViewExcelFilter_4.ReadOnly = true;
			this.dataGridViewExcelFilter_4.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_4.Size = new Size(811, 144);
			this.dataGridViewExcelFilter_4.TabIndex = 4;
			this.dataGridViewExcelFilter_4.CellDoubleClick += this.dataGridViewExcelFilter_4_CellDoubleClick;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_12.HeaderText = "id";
			this.dataGridViewTextBoxColumn_12.Name = "idSurfaceMaterialDgvColumn";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.Visible = false;
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "idExcavation";
			this.dataGridViewTextBoxColumn_13.HeaderText = "idExcavation";
			this.dataGridViewTextBoxColumn_13.Name = "idExcavationDataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.Visible = false;
			this.dataGridViewTextBoxColumn_14.DataPropertyName = "idType";
			this.dataGridViewTextBoxColumn_14.HeaderText = "idType";
			this.dataGridViewTextBoxColumn_14.Name = "idTypeDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewTextBoxColumn_14.Visible = false;
			this.dataGridViewTextBoxColumn_15.DataPropertyName = "idSurface";
			this.dataGridViewTextBoxColumn_15.HeaderText = "idSurface";
			this.dataGridViewTextBoxColumn_15.Name = "idSurfaceDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewTextBoxColumn_15.Visible = false;
			this.dataGridViewTextBoxColumn_16.DataPropertyName = "surName";
			this.dataGridViewTextBoxColumn_16.HeaderText = "Материал";
			this.dataGridViewTextBoxColumn_16.Name = "surNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewTextBoxColumn_16.Width = 200;
			this.dataGridViewTextBoxColumn_17.DataPropertyName = "Value";
			this.dataGridViewTextBoxColumn_17.HeaderText = "Значение";
			this.dataGridViewTextBoxColumn_17.Name = "valueDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_17.ReadOnly = true;
			this.dataGridViewTextBoxColumn_17.Width = 60;
			this.dataGridViewTextBoxColumn_18.DataPropertyName = "unit";
			this.dataGridViewTextBoxColumn_18.HeaderText = "";
			this.dataGridViewTextBoxColumn_18.Name = "unitDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_18.ReadOnly = true;
			this.dataGridViewTextBoxColumn_19.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_19.DataPropertyName = "comment";
			this.dataGridViewTextBoxColumn_19.HeaderText = "Примечание";
			this.dataGridViewTextBoxColumn_19.Name = "commentDataGridViewImageColumn";
			this.dataGridViewTextBoxColumn_19.ReadOnly = true;
			this.dataGridViewTextBoxColumn_19.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_19.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.dataGridViewTextBoxColumn_20.DataPropertyName = "surSocrName";
			this.dataGridViewTextBoxColumn_20.HeaderText = "surSocrName";
			this.dataGridViewTextBoxColumn_20.Name = "surSocrNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_20.ReadOnly = true;
			this.dataGridViewTextBoxColumn_20.Visible = false;
			this.bindingSource_4.DataMember = "vJ_ExcavationSurface";
			this.bindingSource_4.DataSource = this.class130_0;
			this.toolStrip_5.Dock = DockStyle.Left;
			this.toolStrip_5.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_5.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_15,
				this.toolStripButton_16,
				this.toolStripButton_17
			});
			this.toolStrip_5.Location = new Point(3, 3);
			this.toolStrip_5.Name = "toolStripMaterial";
			this.toolStrip_5.Size = new Size(24, 144);
			this.toolStrip_5.TabIndex = 3;
			this.toolStrip_5.Text = "Панель кнопок для адреса";
			this.toolStripButton_15.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_15.Image = Resources.ElementAdd;
			this.toolStripButton_15.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_15.Name = "toolBtnAddMaterial";
			this.toolStripButton_15.Size = new Size(21, 20);
			this.toolStripButton_15.Text = "Добавить материал";
			this.toolStripButton_15.Click += this.toolStripButton_15_Click;
			this.toolStripButton_16.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_16.Image = Resources.ElementEdit;
			this.toolStripButton_16.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_16.Name = "toolBtnEditMaterial";
			this.toolStripButton_16.Size = new Size(21, 20);
			this.toolStripButton_16.Text = "Редактировать материал";
			this.toolStripButton_16.Click += this.toolStripButton_16_Click;
			this.toolStripButton_17.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_17.Image = Resources.ElementDel;
			this.toolStripButton_17.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_17.Name = "toolBtnDelMaterial";
			this.toolStripButton_17.Size = new Size(21, 20);
			this.toolStripButton_17.Text = "Удалить материал";
			this.toolStripButton_17.Click += this.toolStripButton_17_Click;
			this.tabPage_6.Controls.Add(this.splitContainer_3);
			this.tabPage_6.Location = new Point(4, 22);
			this.tabPage_6.Name = "tabPageFile";
			this.tabPage_6.Padding = new Padding(3);
			this.tabPage_6.Size = new Size(841, 150);
			this.tabPage_6.TabIndex = 6;
			this.tabPage_6.Text = "Файлы";
			this.tabPage_6.UseVisualStyleBackColor = true;
			this.splitContainer_3.Dock = DockStyle.Fill;
			this.splitContainer_3.Location = new Point(3, 3);
			this.splitContainer_3.Name = "splitContainer1";
			this.splitContainer_3.Panel1.Controls.Add(this.treeView_0);
			this.splitContainer_3.Panel2.Controls.Add(this.dataGridViewExcelFilter_8);
			this.splitContainer_3.Panel2.Controls.Add(this.toolStrip_9);
			this.splitContainer_3.Size = new Size(835, 144);
			this.splitContainer_3.SplitterDistance = 122;
			this.splitContainer_3.TabIndex = 0;
			this.treeView_0.Dock = DockStyle.Fill;
			this.treeView_0.HideSelection = false;
			this.treeView_0.Location = new Point(0, 0);
			this.treeView_0.Name = "treeViewFile";
			this.treeView_0.Size = new Size(122, 144);
			this.treeView_0.TabIndex = 0;
			this.treeView_0.AfterSelect += this.treeView_0_AfterSelect;
			this.dataGridViewExcelFilter_8.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_8.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_8.AllowUserToResizeColumns = false;
			this.dataGridViewExcelFilter_8.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_8.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_8.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_28,
				this.dataGridViewImageColumnNotNull_0,
				this.dataGridViewTextBoxColumn_29,
				this.dataGridViewTextBoxColumn_30,
				this.dataGridViewTextBoxColumn_31,
				this.dataGridViewLinkColumn_0
			});
			this.dataGridViewExcelFilter_8.DataSource = this.bindingSource_8;
			this.dataGridViewExcelFilter_8.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_8.Location = new Point(33, 0);
			this.dataGridViewExcelFilter_8.Name = "dgvFile";
			this.dataGridViewExcelFilter_8.ReadOnly = true;
			this.dataGridViewExcelFilter_8.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_8.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewExcelFilter_8.Size = new Size(676, 144);
			this.dataGridViewExcelFilter_8.TabIndex = 5;
			this.dataGridViewExcelFilter_8.VirtualMode = true;
			this.dataGridViewExcelFilter_8.CellContentClick += this.dataGridViewExcelFilter_8_CellContentClick;
			this.dataGridViewExcelFilter_8.CellValueNeeded += this.dataGridViewExcelFilter_8_CellValueNeeded;
			this.dataGridViewTextBoxColumn_28.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_28.HeaderText = "id";
			this.dataGridViewTextBoxColumn_28.Name = "idFileDgvColumn";
			this.dataGridViewTextBoxColumn_28.ReadOnly = true;
			this.dataGridViewTextBoxColumn_28.Visible = false;
			dataGridViewCellStyle12.NullValue = null;
			this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridViewImageColumnNotNull_0.HeaderText = "";
			this.dataGridViewImageColumnNotNull_0.ImageLayout = DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumnNotNull_0.Name = "imageDgvColumn";
			this.dataGridViewImageColumnNotNull_0.ReadOnly = true;
			this.dataGridViewImageColumnNotNull_0.Width = 30;
			this.dataGridViewTextBoxColumn_29.DataPropertyName = "typeFile";
			this.dataGridViewTextBoxColumn_29.HeaderText = "typeFile";
			this.dataGridViewTextBoxColumn_29.Name = "typeFileDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_29.ReadOnly = true;
			this.dataGridViewTextBoxColumn_29.Visible = false;
			this.dataGridViewTextBoxColumn_30.DataPropertyName = "typeFileName";
			this.dataGridViewTextBoxColumn_30.HeaderText = "Тип";
			this.dataGridViewTextBoxColumn_30.Name = "typeFileNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_30.ReadOnly = true;
			this.dataGridViewTextBoxColumn_31.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_31.DataPropertyName = "FileName";
			this.dataGridViewTextBoxColumn_31.HeaderText = "Файл";
			this.dataGridViewTextBoxColumn_31.Name = "fileNamedgvColumn";
			this.dataGridViewTextBoxColumn_31.ReadOnly = true;
			this.dataGridViewTextBoxColumn_31.Visible = false;
			this.dataGridViewLinkColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewLinkColumn_0.HeaderText = "Файл";
			this.dataGridViewLinkColumn_0.Name = "shortFileNameDgvColumn";
			this.dataGridViewLinkColumn_0.ReadOnly = true;
			this.dataGridViewLinkColumn_0.Resizable = DataGridViewTriState.True;
			this.bindingSource_8.DataMember = "vJ_ExcavationFile";
			this.bindingSource_8.DataSource = this.class130_0;
			this.toolStrip_9.Dock = DockStyle.Left;
			this.toolStrip_9.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_9.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripSplitButton_0,
				this.toolStripButton_28
			});
			this.toolStrip_9.Location = new Point(0, 0);
			this.toolStrip_9.Name = "toolStripFile";
			this.toolStrip_9.Size = new Size(33, 144);
			this.toolStrip_9.TabIndex = 4;
			this.toolStrip_9.Text = "Панель кнопок для адреса";
			this.toolStripSplitButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton_0.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0
			});
			this.toolStripSplitButton_0.Image = Resources.ElementAdd;
			this.toolStripSplitButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripSplitButton_0.Name = "toolBtnAddFile";
			this.toolStripSplitButton_0.Size = new Size(30, 20);
			this.toolStripSplitButton_0.Text = "Добавить файл";
			this.toolStripMenuItem_0.Name = "gggToolStripMenuItem";
			this.toolStripMenuItem_0.Size = new Size(95, 22);
			this.toolStripMenuItem_0.Text = "ggg";
			this.toolStripButton_28.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_28.Image = Resources.ElementDel;
			this.toolStripButton_28.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_28.Name = "toolBtnDelFile";
			this.toolStripButton_28.Size = new Size(30, 20);
			this.toolStripButton_28.Text = "Удалить выбранные файлы";
			this.toolStripButton_28.Click += this.toolStripButton_28_Click;
			this.dataGridViewTextBoxColumn_38.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_38.HeaderText = "id";
			this.dataGridViewTextBoxColumn_38.Name = "idStatusOrderDgvColumn";
			this.dataGridViewTextBoxColumn_38.ReadOnly = true;
			this.dataGridViewTextBoxColumn_38.Visible = false;
			this.dataGridViewTextBoxColumn_39.DataPropertyName = "idExcavation";
			this.dataGridViewTextBoxColumn_39.HeaderText = "idExcavation";
			this.dataGridViewTextBoxColumn_39.Name = "idExcavationDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_39.ReadOnly = true;
			this.dataGridViewTextBoxColumn_39.Visible = false;
			this.dataGridViewTextBoxColumn_40.DataPropertyName = "idType";
			this.dataGridViewTextBoxColumn_40.HeaderText = "idType";
			this.dataGridViewTextBoxColumn_40.Name = "idTypeDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_40.ReadOnly = true;
			this.dataGridViewTextBoxColumn_40.Visible = false;
			this.dataGridViewTextBoxColumn_41.DataPropertyName = "idStatus";
			this.dataGridViewTextBoxColumn_41.HeaderText = "idStatus";
			this.dataGridViewTextBoxColumn_41.Name = "idStatusDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_41.ReadOnly = true;
			this.dataGridViewTextBoxColumn_41.Visible = false;
			this.dataGridViewTextBoxColumn_42.DataPropertyName = "statusname";
			this.dataGridViewTextBoxColumn_42.HeaderText = "Статус";
			this.dataGridViewTextBoxColumn_42.Name = "statusnameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_42.ReadOnly = true;
			this.dataGridViewTextBoxColumn_42.Width = 150;
			this.dataGridViewTextBoxColumn_43.DataPropertyName = "dateChange";
			dataGridViewCellStyle13.Format = "d";
			dataGridViewCellStyle13.NullValue = null;
			this.dataGridViewTextBoxColumn_43.DefaultCellStyle = dataGridViewCellStyle13;
			this.dataGridViewTextBoxColumn_43.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_43.Name = "dateChangeDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_43.ReadOnly = true;
			this.dataGridViewTextBoxColumn_44.DataPropertyName = "dateElongation";
			dataGridViewCellStyle14.Format = "d";
			this.dataGridViewTextBoxColumn_44.DefaultCellStyle = dataGridViewCellStyle14;
			this.dataGridViewTextBoxColumn_44.HeaderText = "Продлен до";
			this.dataGridViewTextBoxColumn_44.Name = "dateElongationDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_44.ReadOnly = true;
			this.dataGridViewTextBoxColumn_45.DataPropertyName = "statusvalue";
			this.dataGridViewTextBoxColumn_45.HeaderText = "statusvalue";
			this.dataGridViewTextBoxColumn_45.Name = "statusvalueDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_45.ReadOnly = true;
			this.dataGridViewTextBoxColumn_45.Visible = false;
			this.dataGridViewTextBoxColumn_46.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_46.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_46.HeaderText = "Описание";
			this.dataGridViewTextBoxColumn_46.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn_46.Name = "CommentDgvStatusOrder";
			this.dataGridViewTextBoxColumn_46.ReadOnly = true;
			this.dataGridViewTextBoxColumn_47.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_47.HeaderText = "id";
			this.dataGridViewTextBoxColumn_47.Name = "idStatusWorkDgvColumn";
			this.dataGridViewTextBoxColumn_47.ReadOnly = true;
			this.dataGridViewTextBoxColumn_47.Visible = false;
			this.dataGridViewTextBoxColumn_48.DataPropertyName = "statusname";
			this.dataGridViewTextBoxColumn_48.HeaderText = "Состояние";
			this.dataGridViewTextBoxColumn_48.Name = "statusnameDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_48.ReadOnly = true;
			this.dataGridViewTextBoxColumn_48.Width = 200;
			this.dataGridViewTextBoxColumn_49.DataPropertyName = "dateChange";
			dataGridViewCellStyle15.Format = "g";
			dataGridViewCellStyle15.NullValue = null;
			this.dataGridViewTextBoxColumn_49.DefaultCellStyle = dataGridViewCellStyle15;
			this.dataGridViewTextBoxColumn_49.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_49.Name = "dateChangeDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_49.ReadOnly = true;
			this.dataGridViewTextBoxColumn_50.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_50.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_50.HeaderText = "Описание";
			this.dataGridViewTextBoxColumn_50.MinimumWidth = 50;
			this.dataGridViewTextBoxColumn_50.Name = "CommentDgvStatusWork";
			this.dataGridViewTextBoxColumn_50.ReadOnly = true;
			this.dataGridViewTextBoxColumn_51.DataPropertyName = "dateElongation";
			this.dataGridViewTextBoxColumn_51.HeaderText = "dateElongation";
			this.dataGridViewTextBoxColumn_51.Name = "dateElongationDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_51.ReadOnly = true;
			this.dataGridViewTextBoxColumn_51.Visible = false;
			this.dataGridViewTextBoxColumn_52.DataPropertyName = "statusvalue";
			this.dataGridViewTextBoxColumn_52.HeaderText = "statusvalue";
			this.dataGridViewTextBoxColumn_52.Name = "statusvalueDataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_52.ReadOnly = true;
			this.dataGridViewTextBoxColumn_52.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(1011, 486);
			base.Controls.Add(this.splitContainer_0);
			base.Controls.Add(this.toolStrip_0);
//			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormJournalExcavation";
			this.Text = "Журнал раскопок";
			base.Load += this.FormJournalExcavation_Load;
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.splitContainer_0.Panel1.ResumeLayout(false);
			this.splitContainer_0.Panel1.PerformLayout();
			this.splitContainer_0.Panel2.ResumeLayout(false);
			this.splitContainer_0.ResumeLayout(false);
			this.toolStrip_1.ResumeLayout(false);
			this.toolStrip_1.PerformLayout();
			this.splitContainer_1.Panel1.ResumeLayout(false);
			this.splitContainer_1.Panel2.ResumeLayout(false);
			this.splitContainer_1.ResumeLayout(false);
			((ISupportInitialize)this.dataGridViewExcelFilter_0).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			((ISupportInitialize)this.class130_0).EndInit();
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.tabPage_0.PerformLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_1).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			this.toolStrip_2.ResumeLayout(false);
			this.toolStrip_2.PerformLayout();
			this.tabPage_3.ResumeLayout(false);
			this.tabPage_3.PerformLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_2).EndInit();
			((ISupportInitialize)this.bindingSource_2).EndInit();
			this.toolStrip_3.ResumeLayout(false);
			this.toolStrip_3.PerformLayout();
			this.tabPage_4.ResumeLayout(false);
			this.tabPage_4.PerformLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_3).EndInit();
			((ISupportInitialize)this.bindingSource_3).EndInit();
			this.toolStrip_4.ResumeLayout(false);
			this.toolStrip_4.PerformLayout();
			this.tabPage_5.ResumeLayout(false);
			this.tabPage_5.PerformLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_7).EndInit();
			((ISupportInitialize)this.bindingSource_7).EndInit();
			this.toolStrip_8.ResumeLayout(false);
			this.toolStrip_8.PerformLayout();
			this.tabPage_1.ResumeLayout(false);
			this.splitContainer_2.Panel1.ResumeLayout(false);
			this.splitContainer_2.Panel1.PerformLayout();
			this.splitContainer_2.Panel2.ResumeLayout(false);
			this.splitContainer_2.Panel2.PerformLayout();
			this.splitContainer_2.ResumeLayout(false);
			((ISupportInitialize)this.dataGridViewExcelFilter_5).EndInit();
			((ISupportInitialize)this.bindingSource_5).EndInit();
			this.toolStrip_6.ResumeLayout(false);
			this.toolStrip_6.PerformLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_6).EndInit();
			((ISupportInitialize)this.bindingSource_6).EndInit();
			this.toolStrip_7.ResumeLayout(false);
			this.toolStrip_7.PerformLayout();
			this.tabPage_2.ResumeLayout(false);
			this.tabPage_2.PerformLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_4).EndInit();
			((ISupportInitialize)this.bindingSource_4).EndInit();
			this.toolStrip_5.ResumeLayout(false);
			this.toolStrip_5.PerformLayout();
			this.tabPage_6.ResumeLayout(false);
			this.splitContainer_3.Panel1.ResumeLayout(false);
			this.splitContainer_3.Panel2.ResumeLayout(false);
			this.splitContainer_3.Panel2.PerformLayout();
			this.splitContainer_3.ResumeLayout(false);
			((ISupportInitialize)this.dataGridViewExcelFilter_8).EndInit();
			((ISupportInitialize)this.bindingSource_8).EndInit();
			this.toolStrip_9.ResumeLayout(false);
			this.toolStrip_9.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		internal static void eGtIqk0lloIgVey3djuX(FormBase form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		private int int_0;

		private DataTable dataTable_0;

		private ToolStrip toolStrip_0;

		private SplitContainer splitContainer_0;

		private SplitContainer splitContainer_1;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private TabPage tabPage_1;

		private TabPage tabPage_2;

		private DateTimePicker dateTimePicker_0;

		private Label label_0;

		private DateTimePicker dateTimePicker_1;

		private Label label_1;

		private ToolStrip toolStrip_1;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private ToolStripButton toolStripButton_2;

		private ToolStripButton toolStripButton_3;

		private ToolStripButton toolStripButton_4;

		private ToolStrip toolStrip_2;

		private ToolStripButton toolStripButton_5;

		private ToolStripButton toolStripButton_6;

		private ToolStripButton toolStripButton_7;

		private DataGridViewExcelFilter dataGridViewExcelFilter_1;

		private BindingSource bindingSource_0;

		private Class130 class130_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private ToolStripSeparator toolStripSeparator_0;

		private ToolStripButton toolStripButton_8;

		private BindingSource bindingSource_1;

		private TabPage tabPage_3;

		private ToolStrip toolStrip_3;

		private ToolStripButton toolStripButton_9;

		private ToolStripButton toolStripButton_10;

		private ToolStripButton toolStripButton_11;

		private DataGridViewExcelFilter dataGridViewExcelFilter_2;

		private BindingSource bindingSource_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private TabPage tabPage_4;

		private DataGridViewExcelFilter dataGridViewExcelFilter_3;

		private ToolStrip toolStrip_4;

		private ToolStripButton toolStripButton_12;

		private ToolStripButton toolStripButton_13;

		private ToolStripButton toolStripButton_14;

		private BindingSource bindingSource_3;

		private DataGridViewExcelFilter dataGridViewExcelFilter_4;

		private ToolStrip toolStrip_5;

		private ToolStripButton toolStripButton_15;

		private ToolStripButton toolStripButton_16;

		private ToolStripButton toolStripButton_17;

		private BindingSource bindingSource_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

		private SplitContainer splitContainer_2;

		private ToolStrip toolStrip_6;

		private ToolStripButton toolStripButton_18;

		private ToolStripButton toolStripButton_19;

		private ToolStripButton toolStripButton_20;

		private DataGridViewExcelFilter dataGridViewExcelFilter_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

		private BindingSource bindingSource_5;

		private DataGridViewExcelFilter dataGridViewExcelFilter_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

		private BindingSource bindingSource_6;

		private ToolStrip toolStrip_7;

		private ToolStripButton toolStripButton_21;

		private ToolStripButton toolStripButton_22;

		private ToolStripButton toolStripButton_23;

		private TabPage tabPage_5;

		private DataGridViewExcelFilter dataGridViewExcelFilter_7;

		private BindingSource bindingSource_7;

		private ToolStrip toolStrip_8;

		private ToolStripButton toolStripButton_24;

		private ToolStripButton toolStripButton_25;

		private ToolStripButton toolStripButton_26;

		private ToolStripButton toolStripButton_27;

		private TabPage tabPage_6;

		private SplitContainer splitContainer_3;

		private TreeView treeView_0;

		private DataGridViewExcelFilter dataGridViewExcelFilter_8;

		private ToolStrip toolStrip_9;

		private ToolStripButton toolStripButton_28;

		private BindingSource bindingSource_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

		private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;

		private DataGridViewLinkColumn dataGridViewLinkColumn_0;

		private ToolStripSplitButton toolStripSplitButton_0;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripSeparator toolStripSeparator_1;

		private ToolStripButton toolStripButton_29;

		private ToolStripButton toolStripButton_30;

		private ToolStripSeparator toolStripSeparator_2;

		private ToolStripButton toolStripButton_31;

		private ToolStripButton toolStripButton_32;

		private CheckBox checkBox_0;

		private CheckBox checkBox_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_32;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_33;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_34;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_35;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_11;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_12;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_36;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_37;

		private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_15;

		private DataGridViewFilterCheckBoxColumn dataGridViewFilterCheckBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_38;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_39;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_40;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_41;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_42;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_43;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_44;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_45;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_46;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_47;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_48;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_49;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_50;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_51;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_52;
	}
}
