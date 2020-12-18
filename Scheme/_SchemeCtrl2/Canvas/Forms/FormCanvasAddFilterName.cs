using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using FormLbr;
using SchemeCtrl2.Data;

namespace SchemeCtrl2.Canvas.Forms
{
	public partial class FormCanvasAddFilterName : FormBase
	{
		private void method_0()
		{
			this.textBox_0 = new TextBox();
			this.label_0 = new Label();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.dataSetScheme_0 = new DataSetScheme();
			((ISupportInitialize)this.dataSetScheme_0).BeginInit();
			base.SuspendLayout();
			this.textBox_0.Location = new Point(15, 29);
			this.textBox_0.Name = "textBox1";
			this.textBox_0.Size = new Size(292, 20);
			this.textBox_0.TabIndex = 0;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 13);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(75, 13);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "Имя фильтра";
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Location = new Point(15, 55);
			this.button_0.Name = "buttonOK";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 2;
			this.button_0.Text = "ОК";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Location = new Point(232, 55);
			this.button_1.Name = "buttonCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 3;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.dataSetScheme_0.DataSetName = "DataSetScheme";
			this.dataSetScheme_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.AcceptButton = this.button_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_1;
			base.ClientSize = new Size(313, 89);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.textBox_0);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.Name = "FormCanvasAddFilterName";
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Имя фильтра";
			base.FormClosing += this.FormCanvasAddFilterName_FormClosing;
			base.Load += this.FormCanvasAddFilterName_Load;
			((ISupportInitialize)this.dataSetScheme_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public FormCanvasAddFilterName()
		{
			this.method_0();
		}

		private void FormCanvasAddFilterName_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tR_Classifier, true, " where [ParentKey] = ';SCM;FilterName;'  and [IsGroup] = 1 and [deleted] = 0 order by name");
			if (this.dataSetScheme_0.tR_Classifier.Rows.Count > 0)
			{
				this.int_0 = Convert.ToInt32(this.dataSetScheme_0.tR_Classifier.Rows[0]["id"]);
				return;
			}
			MessageBox.Show("В классификаторе нне найдено ParentKey = ;SCM;FilterName;");
			base.Close();
		}

		private void FormCanvasAddFilterName_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (string.IsNullOrEmpty(this.textBox_0.Text))
				{
					MessageBox.Show("Не введено имя фильтра");
					e.Cancel = true;
					return;
				}
				this.dataSetScheme_0.tR_Classifier.Clear();
				DataRow dataRow = this.dataSetScheme_0.tR_Classifier.NewRow();
				dataRow["Name"] = this.textBox_0.Text;
				dataRow["ParentId"] = this.int_0;
				dataRow["ParentKey"] = ";SCM;FilterName;";
				dataRow["IsGroup"] = 0;
				dataRow["Deleted"] = 0;
				this.dataSetScheme_0.tR_Classifier.Rows.Add(dataRow);
				base.InsertSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tR_Classifier);
			}
		}

		private const string string_0 = ";SCM;FilterName;";

		private TextBox textBox_0;

		private Label label_0;

		private Button button_0;

		private Button button_1;

		private DataSetScheme dataSetScheme_0;

		private int int_0;
	}
}
