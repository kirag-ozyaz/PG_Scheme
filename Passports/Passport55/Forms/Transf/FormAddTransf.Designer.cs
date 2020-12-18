using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DataSql;
using FormLbr;
using Passport.DataSets;

namespace Passport.Forms.Transf
{
	public class FormAddTransf : FormBase
	{
		public int Id { get; set; }

		public int IdParent { get; set; }

		public FormAddTransf()
		{
			this.method_0();
		}

		public FormAddTransf(SQLSettings settings, int idParent)
		{
			this.method_0();
			this.SqlSettings = settings;
			this.IdParent = idParent;
		}

		private void FormAddTransf_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				string text = "Т" + this.numericUpDown_0.Value.ToString();
				if (Class114.smethod_9(this.SqlSettings, text, this.IdParent))
				{
					e.Cancel = true;
					MessageBox.Show("Трансформатор с таким именем уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return;
				}
				dsPassport.Class49 @class = this.dsPassport_0.tSchm_ObjList.method_5();
				@class.IdParent = this.IdParent;
				@class.idParentAddl = this.IdParent;
				@class.TypeCodeId = 556;
				@class.Name = text;
				@class.method_5(false);
				this.dsPassport_0.tSchm_ObjList.method_0(@class);
				this.Id = base.InsertSqlDataOneRow(this.dsPassport_0, this.dsPassport_0.tSchm_ObjList);
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
			this.label_0 = new Label();
			this.numericUpDown_0 = new NumericUpDown();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.dsPassport_0 = new dsPassport();
			((ISupportInitialize)this.numericUpDown_0).BeginInit();
			((ISupportInitialize)this.dsPassport_0).BeginInit();
			base.SuspendLayout();
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 19);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(107, 13);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "№ трансформатора";
			this.numericUpDown_0.Location = new Point(125, 17);
			this.numericUpDown_0.Name = "nudTransNumber";
			this.numericUpDown_0.Size = new Size(159, 20);
			this.numericUpDown_0.TabIndex = 1;
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Location = new Point(94, 55);
			this.button_0.Name = "btnAccept";
			this.button_0.Size = new Size(100, 23);
			this.button_0.TabIndex = 2;
			this.button_0.Text = "Применить";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Location = new Point(209, 55);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 3;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.dsPassport_0.DataSetName = "dsPassport";
			this.dsPassport_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.AcceptButton = this.button_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_1;
			base.ClientSize = new Size(296, 89);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.numericUpDown_0);
			base.Controls.Add(this.label_0);
			base.Name = "FormAddTransf";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Добавление трансформатора";
			base.FormClosing += this.FormAddTransf_FormClosing;
			((ISupportInitialize)this.numericUpDown_0).EndInit();
			((ISupportInitialize)this.dsPassport_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		private IContainer icontainer_0;

		private Label label_0;

		private NumericUpDown numericUpDown_0;

		private Button button_0;

		private Button button_1;

		private dsPassport dsPassport_0;
	}
}
