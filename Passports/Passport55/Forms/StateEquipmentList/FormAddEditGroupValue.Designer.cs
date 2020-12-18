using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;
using Passport.DataSets;

namespace Passport.Forms.StateEquipmentList
{
	public class FormAddEditGroupValue : FormBase
	{
		public int Id { get; set; }

		public int TypeDoc { get; set; }

		public StateFormCreate CreateState
		{
			get
			{
				return this.stateFormCreate_0;
			}
			set
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
		}

		public FormAddEditGroupValue()
		{
			this.method_0();
		}

		public FormAddEditGroupValue(SQLSettings settings, int int_2, StateFormCreate state)
		{
			this.method_0();
			this.SqlSettings = settings;
			this.stateFormCreate_0 = state;
			if (state == 1)
			{
				this.Text = "Редактирование поля";
				base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tR_DocValueList, true, "where id = " + int_2.ToString(), true);
				this.textBox_0.Text = this.dsDocuments_0.tR_DocValueList.Rows[0]["Name"].ToString();
				this.Id = int_2;
			}
			if (state == null)
			{
				this.Text = "Добавление поля";
				this.TypeDoc = int_2;
			}
		}

		public FormAddEditGroupValue(SQLSettings settings, int int_2, int TypeDoc, StateFormCreate state)
		{
			this.method_0();
			this.SqlSettings = settings;
			this.stateFormCreate_0 = state;
			if (state == 1)
			{
				this.Text = "Редактирование поля";
				base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tR_DocValueList, true, "where id = " + int_2.ToString(), true);
				this.textBox_0.Text = this.dsDocuments_0.tR_DocValueList.Rows[0]["Name"].ToString();
				this.Id = int_2;
			}
			if (state == null)
			{
				this.Text = "Добавление поля";
				this.Id = int_2;
				this.TypeDoc = TypeDoc;
			}
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			if (this.stateFormCreate_0 == 1)
			{
				this.dsDocuments_0.tR_DocValueList.Rows[0]["Name"] = this.textBox_0.Text;
				base.UpdateSqlData(this.dsDocuments_0, this.dsDocuments_0.tR_DocValueList);
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
			if (this.stateFormCreate_0 == null)
			{
				dsDocuments.Class155 @class = this.dsDocuments_0.tR_DocValueList.method_5();
				if (this.Id != -1)
				{
					@class.method_1(this.Id);
				}
				@class.method_3(this.TypeDoc);
				@class.Name = this.textBox_0.Text;
				@class.method_5(true);
				@class.method_7(false);
				@class.method_9(this.SqlSettings.SqlUserConnect);
				@class.Date = DateTime.Now;
				this.dsDocuments_0.tR_DocValueList.method_0(@class);
				this.Id = base.InsertSqlDataOneRow(this.dsDocuments_0, this.dsDocuments_0.tR_DocValueList);
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
			base.Dispose(disposing);
		}

		private void method_0()
		{
			this.textBox_0 = new TextBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.dsDocuments_0 = new dsDocuments();
			((ISupportInitialize)this.dsDocuments_0).BeginInit();
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
			this.dsDocuments_0.DataSetName = "dsDocuments";
			this.dsDocuments_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(374, 72);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.textBox_0);
			base.Name = "FormAddEditGroupValue";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "FormAddEditGroupValue";
			((ISupportInitialize)this.dsDocuments_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
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

		private dsDocuments dsDocuments_0;
	}
}
