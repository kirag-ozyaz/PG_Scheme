using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using FormLbr;
using Passport.DataSets;

namespace Passport
{
	public class FormPassportBase : FormBase
	{
		protected SQLSettings SQLSettings
		{
			get
			{
				return this.SqlSettings;
			}
			set
			{
				this.SqlSettings = value;
			}
		}

		public FormPassportBase()
		{
			this.method_0();
		}

		protected int GetCharListParentId(int idObject)
		{
			return Convert.ToInt32(base.CallSQLScalarFunction("dbo.fn_GetCharListParentId", new string[]
			{
				idObject.ToString()
			}));
		}

		protected bool CheckData(DataGridView dataGridView_0)
		{
			bool result = true;
			for (int i = 0; i < dataGridView_0.RowCount; i++)
			{
				if ((dataGridView_0.Rows[i].Cells["Value"].Value == null || dataGridView_0.Rows[i].Cells["Value"].Value.ToString().Length == 0) && !(bool)dataGridView_0.Rows[i].Cells["isGroup"].Value)
				{
					MessageBox.Show("Параметр \"" + dataGridView_0.Rows[i].Cells["Parameter"].Value.ToString() + "\" отсутствует или введен неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return false;
				}
			}
			return result;
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
			this.dsPassport_0 = new dsPassport();
			((ISupportInitialize)this.dsPassport_0).BeginInit();
			base.SuspendLayout();
			this.dsPassport_0.DataSetName = "dsPassport";
			this.dsPassport_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(284, 262);
			base.Name = "FormPassportBase";
			this.Text = "Form1";
			((ISupportInitialize)this.dsPassport_0).EndInit();
			base.ResumeLayout(false);
		}

		private IContainer icontainer_0;

		internal dsPassport dsPassport_0;
	}
}
