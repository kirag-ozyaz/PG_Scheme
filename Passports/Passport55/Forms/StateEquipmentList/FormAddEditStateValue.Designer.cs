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
	public class FormAddEditStateValue : FormBase
	{
		public int Id { get; set; }

		public FormAddEditStateValue(SQLSettings settings, int int_3)
		{
			this.method_0();
			this.SqlSettings = settings;
			this.Text = "Редактирование записи";
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tR_DocValueList, true, "where id = " + int_3.ToString(), true);
			this.textBox_0.Text = this.dsDocuments_0.tR_DocValueList.Rows[0]["Name"].ToString();
			this.stateFormCreate_0 = 1;
			this.Id = int_3;
		}

		public FormAddEditStateValue(SQLSettings settings, int ParentId, int TypeDoc)
		{
			this.method_0();
			this.SqlSettings = settings;
			this.Text = "Добавление записи";
			this.stateFormCreate_0 = 0;
			this.int_0 = ParentId;
			this.int_1 = TypeDoc;
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			if (this.stateFormCreate_0 == null)
			{
				dsDocuments.Class155 @class = this.dsDocuments_0.tR_DocValueList.method_5();
				@class.method_1(this.int_0);
				@class.method_3(this.int_1);
				@class.Name = this.textBox_0.Text;
				@class.method_5(false);
				@class.method_7(false);
				@class.method_9(this.SqlSettings.SqlUserConnect);
				@class.Date = DateTime.Now;
				this.dsDocuments_0.tR_DocValueList.method_0(@class);
				this.Id = base.InsertSqlDataOneRow(this.dsDocuments_0, this.dsDocuments_0.tR_DocValueList);
				this.button_0.DialogResult = DialogResult.OK;
				base.Close();
			}
			if (this.stateFormCreate_0 == 1)
			{
				this.dsDocuments_0.tR_DocValueList.Rows[0]["Name"] = this.textBox_0.Text;
				base.UpdateSqlData(this.dsDocuments_0, this.dsDocuments_0.tR_DocValueList);
				this.button_0.DialogResult = DialogResult.OK;
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
			this.dsDocuments_0 = new dsDocuments();
			this.textBox_0 = new TextBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			((ISupportInitialize)this.dsDocuments_0).BeginInit();
			base.SuspendLayout();
			this.dsDocuments_0.DataSetName = "dsDocuments";
			this.dsDocuments_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.textBox_0.Location = new Point(12, 12);
			this.textBox_0.Multiline = true;
			this.textBox_0.Name = "tbValue";
			this.textBox_0.Size = new Size(358, 100);
			this.textBox_0.TabIndex = 0;
			this.button_0.Location = new Point(191, 118);
			this.button_0.Name = "btnSave";
			this.button_0.Size = new Size(86, 23);
			this.button_0.TabIndex = 1;
			this.button_0.Text = "Сохранить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Location = new Point(295, 118);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 2;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(382, 149);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.textBox_0);
			base.Name = "FormAddEditStateValue";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "FormAddEditStateValue";
			((ISupportInitialize)this.dsDocuments_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private StateFormCreate stateFormCreate_0;

		private int int_0;

		private int int_1;

		[CompilerGenerated]
		private int int_2;

		private IContainer icontainer_0;

		private dsDocuments dsDocuments_0;

		private TextBox textBox_0;

		private Button button_0;

		private Button button_1;
	}
}
