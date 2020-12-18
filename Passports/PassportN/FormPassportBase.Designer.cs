using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using FormLbr;

namespace Passport
{
	public class FormPassportBase : FormBase
	{
		protected SQLSettings SQLSettings_0
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
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_0();
		}

		protected int GetCharListParentId(int idObject)
		{
			return Convert.ToInt32(base.CallSQLScalarFunction("dbo.fn_GetCharListParentId", new string[]
			{
				idObject.ToString()
			}));
		}

		protected bool CheckData(DataGridView dgv)
		{
			bool result = true;
			for (int i = 0; i < dgv.RowCount; i++)
			{
				if ((dgv.Rows[i].Cells["Value"].Value == null || dgv.Rows[i].Cells["Value"].Value.ToString().Length == 0) && !(bool)dgv.Rows[i].Cells["isGroup"].Value)
				{
					MessageBox.Show("Параметр \"" + dgv.Rows[i].Cells["Parameter"].Value.ToString() + "\" отсутствует или введен неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
			FormPassportBase.iwlgZkOmIDHGj8fTE76(this, disposing);
		}

		private void method_0()
		{
			this.class107_0 = new Class107();
			((ISupportInitialize)this.class107_0).BeginInit();
			base.SuspendLayout();
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(284, 262);
			base.Name = "FormPassportBase";
			this.Text = "Form1";
			((ISupportInitialize)this.class107_0).EndInit();
			base.ResumeLayout(false);
		}

		internal static void iwlgZkOmIDHGj8fTE76(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		private IContainer icontainer_0;

		internal Class107 class107_0;
	}
}
