using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Constants;
using DataSql;
using Passport.Classes;

namespace Passport.Forms.PassportChars
{
	public class FormAddEditNaimEquipmentChars : FormPassportBase
	{
		public int Id { get; set; }

		public FormAddEditNaimEquipmentChars(SQLSettings sqlSettings)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_4();
			this.SqlSettings = sqlSettings;
			this.stateFormCreate_0 = 0;
		}

		public FormAddEditNaimEquipmentChars(SQLSettings sqlSettings, int idEquipment)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_4();
			this.SqlSettings = sqlSettings;
			this.stateFormCreate_0 = 1;
			this.Id = idEquipment;
			base.SelectSqlData(this.class107_0, this.class107_0.tP_CharList, true, "WHERE id = " + this.Id.ToString());
			if (this.class107_0.tP_CharList.Rows.Count > 0)
			{
				this.textBox_0.Text = this.class107_0.tP_CharList.Rows[0]["Name"].ToString();
			}
		}

		private bool method_1(string string_0)
		{
			Class107.Class285 @class = this.class107_0.tP_CharList.method_5();
			@class.ParentId = 3;
			@class.ParentKey = this.method_3(";EquipChar;Passp;", string_0);
			@class.Name = string_0;
			@class.ShortName = "";
			@class.Type = 734;
			@class.Format = 735;
			@class.idValueList = 107;
			@class.TableName = "tP_ValueLists";
			@class.TabIndex = 0;
			@class.Comment = "";
			@class.isGroup = true;
			@class.Panel = false;
			@class.Deleted = false;
			@class.ReadOnly = false;
			@class.UseDimention = false;
			this.class107_0.tP_CharList.method_0(@class);
			this.Id = base.InsertSqlDataOneRow(this.class107_0, this.class107_0.tP_CharList);
			return this.Id > 0;
		}

		private bool method_2(int int_1, string string_0)
		{
			if (this.class107_0.tP_CharList.Rows.Count > 0)
			{
				this.class107_0.tP_CharList.Rows[0]["Name"] = this.textBox_0.Text;
			}
			return base.UpdateSqlData(this.class107_0, this.class107_0.tP_CharList);
		}

		private string method_3(string string_0, string string_1)
		{
			string_1 = Regex.Replace(string_1, "[-.?!)(,:]", "");
			string_1 = Transliteration.Front(string_1);
			string[] array = string_1.Split(new char[]
			{
				' '
			}, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				if (!char.IsDigit(Convert.ToChar(text.Substring(0, 1))))
				{
					array[i] = text.Substring(0, 1).ToUpper() + text.Substring(1, text.Length - 1);
				}
			}
			return string_0 + string.Join("", (from s in array
			select s.ToString()).ToArray<string>()) + ";";
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			StateFormCreate stateFormCreate = this.stateFormCreate_0;
			if (stateFormCreate != null)
			{
				if (stateFormCreate != 1)
				{
					return;
				}
				if (this.method_2(this.Id, this.textBox_0.Text))
				{
					base.DialogResult = DialogResult.OK;
					base.Close();
				}
			}
			else if (this.method_1(this.textBox_0.Text))
			{
				base.DialogResult = DialogResult.OK;
				base.Close();
				return;
			}
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_1 != null)
			{
				this.icontainer_1.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_4()
		{
			this.label_0 = new Label();
			this.textBox_0 = new TextBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.class107_0 = new Class107();
			((ISupportInitialize)this.class107_0).BeginInit();
			base.SuspendLayout();
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(10, 16);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(157, 13);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "Наименование оборудования";
			this.textBox_0.Location = new Point(174, 13);
			this.textBox_0.Name = "textBox1";
			this.textBox_0.Size = new Size(191, 20);
			this.textBox_0.TabIndex = 1;
			this.button_0.Location = new Point(174, 48);
			this.button_0.Name = "btnSave";
			this.button_0.Size = new Size(101, 23);
			this.button_0.TabIndex = 2;
			this.button_0.Text = "Сохранить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.Location = new Point(290, 48);
			this.button_1.Name = "btnClose";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 3;
			this.button_1.Text = "Отменить";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(377, 80);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.label_0);
			base.Name = "FormAddEditNaimEquipmentChars";
			this.Text = "Добавление";
			((ISupportInitialize)this.class107_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private StateFormCreate stateFormCreate_0;

		[CompilerGenerated]
		private int int_0;

		private IContainer icontainer_1;

		private Label label_0;

		private TextBox textBox_0;

		private Button button_0;

		private Button button_1;
	}
}
