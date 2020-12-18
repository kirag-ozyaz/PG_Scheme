using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;

namespace Passport.Forms.StateEquipmentList
{
	public class FormAddEditGroupValue : FormBase
	{
		internal int Id { get; set; }

		internal int TypeDoc { get; set; }

		internal StateFormCreate method_0()
		{
			return this.stateFormCreate_0;
		}

		internal void method_1(StateFormCreate value)
		{
			if (value == null)
			{
				this.Text = "Добавление поля";
			}
			else
			{
				this.Text = "Редактирование поля";
			}
			this.stateFormCreate_0 = value;
		}

		internal FormAddEditGroupValue()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_2();
		}

		internal FormAddEditGroupValue(SQLSettings settings, int id, StateFormCreate state)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_2();
			this.SqlSettings = settings;
			this.stateFormCreate_0 = state;
			if (state == 1)
			{
				this.Text = "Редактирование поля";
				base.SelectSqlData(this.class14_0.tR_DocValueList, true, "where id = " + id.ToString(), null, true, 0);
				this.textBox_0.Text = this.class14_0.tR_DocValueList.Rows[0]["Name"].ToString();
				this.Id = id;
			}
			if (state == null)
			{
				this.Text = "Добавление поля";
				this.TypeDoc = id;
			}
		}

		internal FormAddEditGroupValue(SQLSettings settings, int id, int TypeDoc, StateFormCreate state)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_2();
			this.SqlSettings = settings;
			this.stateFormCreate_0 = state;
			if (state == 1)
			{
				this.Text = "Редактирование поля";
				base.SelectSqlData(this.class14_0.tR_DocValueList, true, "where id = " + id.ToString(), null, true, 0);
				this.textBox_0.Text = this.class14_0.tR_DocValueList.Rows[0]["Name"].ToString();
				this.Id = id;
			}
			if (state == null)
			{
				this.Text = "Добавление поля";
				this.Id = id;
				this.TypeDoc = TypeDoc;
			}
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			if (this.stateFormCreate_0 == 1)
			{
				this.class14_0.tR_DocValueList.Rows[0]["Name"] = this.textBox_0.Text;
				base.UpdateSqlData(this.class14_0, this.class14_0.tR_DocValueList);
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
			if (this.stateFormCreate_0 == null)
			{
				Class14.Class62 @class = this.class14_0.tR_DocValueList.method_5();
				if (this.Id != -1)
				{
					@class.ParentId = this.Id;
				}
				@class.TypeDoc = this.TypeDoc;
				@class.Name = this.textBox_0.Text;
				@class.IsGroup = true;
				@class.Deleted = false;
				@class.User = this.SqlSettings.SqlUserConnect;
				@class.Date = DateTime.Now;
				this.class14_0.tR_DocValueList.method_0(@class);
				this.Id = base.InsertSqlDataOneRow(this.class14_0, this.class14_0.tR_DocValueList);
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			FormAddEditGroupValue.Wn0bnk2nd0gEL6k3ZuP(this, disposing);
		}

		private void method_2()
		{
			this.textBox_0 = new TextBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.class14_0 = new Class14();
			((ISupportInitialize)this.class14_0).BeginInit();
			base.SuspendLayout();
			this.textBox_0.Location = new Point(12, 12);
			this.textBox_0.Name = "tbName";
			this.textBox_0.Size = new Size(350, 20);
			this.textBox_0.TabIndex = 0;
			this.button_0.Location = new Point(186, 43);
			this.button_0.Name = "btnSave";
			this.button_0.Size = new Size(95, 23);
			this.button_0.TabIndex = 1;
			this.button_0.Text = "Сохранить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Location = new Point(287, 43);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 2;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.class14_0.DataSetName = "dsDocuments";
			this.class14_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(374, 72);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.textBox_0);
			base.Name = "FormAddEditGroupValue";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "FormAddEditGroupValue";
			((ISupportInitialize)this.class14_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		internal static void Wn0bnk2nd0gEL6k3ZuP(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		private StateFormCreate stateFormCreate_0;

		private IContainer icontainer_0;

		private TextBox textBox_0;

		private Button button_0;

		private Button button_1;

		private Class14 class14_0;
	}
}
