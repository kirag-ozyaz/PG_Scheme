using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;
using Passport.DataSets;

namespace Passport.Forms.Documents
{
	public class FormDocBase : FormBase
	{
		public FormDocBase()
		{
			this.method_13();
		}

		internal DataTable method_0()
		{
			new DataTable();
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tAbn, true, "WHERE Id = 434002");
			return this.dsDocuments_0.tAbn.Copy();
		}

		internal DataTable method_1(int int_2)
		{
			new DataTable();
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vP_Worker, true, "WHERE ParentKey LIKE ';GroupWorker;HeadRegion;' AND Code = " + int_2.ToString() + " AND isGroup = 0");
			return this.dsDocuments_0.vP_Worker.Copy();
		}

		internal DataTable method_2()
		{
			new DataTable();
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vP_Worker, true, "WHERE ParentKey in (';GroupWorker;MasterNetRegion;')");
			return this.dsDocuments_0.vP_Worker.Copy();
		}

		internal DataTable method_3()
		{
			new DataTable();
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vP_Worker, true, "WHERE ParentKey LIKE ';GroupWorker;HeadPTS;' AND isGroup = 0");
			return this.dsDocuments_0.vP_Worker.Copy();
		}

		internal DataTable method_4()
		{
			new DataTable();
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vP_Worker, true, "WHERE ParentKey LIKE ';GroupWorker;HeadUch;' AND isGroup = 0");
			return this.dsDocuments_0.vP_Worker.Copy();
		}

		internal DataTable method_5()
		{
			new DataTable();
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vP_Worker, true, "WHERE ParentKey LIKE ';GroupWorker;Manager;' AND isGroup = 0");
			return this.dsDocuments_0.vP_Worker.Copy();
		}

		internal int method_6(string string_0, string string_1)
		{
			int result;
			try
			{
				result = (int)new SqlDataCommand(this.SqlSettings).CallSQLScalarFunction("dbo.fn_GetTypeDoc", new string[]
				{
					string_0,
					string_1
				});
			}
			catch (Exception)
			{
				result = -1;
			}
			return result;
		}

		internal void method_7(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
			{
				e.Handled = true;
				MessageBox.Show("Ввод только чисел!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				((TextBox)sender).Focus();
			}
		}

		internal void method_8(object object_0, KeyPressEventArgs keyPressEventArgs_0, int int_2)
		{
			if (((TextBox)object_0).Text.Length > int_2 && keyPressEventArgs_0.KeyChar != '\b' && keyPressEventArgs_0.KeyChar != '.')
			{
				keyPressEventArgs_0.Handled = true;
				MessageBox.Show("Вы достигли максимального количества символов!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				((TextBox)object_0).Focus();
			}
		}

		internal StateFormCreate FormCreate
		{
			get
			{
				return this.stateFormCreate_0;
			}
			set
			{
				this.stateFormCreate_0 = value;
			}
		}

		internal int IdDocList
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		internal int IdObjList
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		internal void method_9()
		{
			this.sqlConnection_0 = new SqlConnection(string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", this.SqlSettings.ServerDB, this.SqlSettings.DBName));
			this.sqlConnection_0.Open();
			this.Transaction = this.sqlConnection_0.BeginTransaction();
		}

		internal SqlTransaction Transaction { get; set; }

		internal string[] method_10()
		{
			StringBuilder stringBuilder = null;
			SqlCommand sqlCommand = this.sqlConnection_0.CreateCommand();
			sqlCommand.CommandText = "select object_name(resource_associated_entity_id, resource_database_id) from sys.dm_tran_locks dml where resource_type = 'OBJECT';";
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			while (sqlDataReader.Read())
			{
				stringBuilder.Append(sqlDataReader.GetString(0) + ",");
			}
			return stringBuilder.ToString().Substring(0, stringBuilder.Length - 1).Split(new char[]
			{
				','
			});
		}

		internal bool method_11(string string_0)
		{
			SqlCommand sqlCommand = this.sqlConnection_0.CreateCommand();
			sqlCommand.CommandText = "select object_name(resource_associated_entity_id, resource_database_id) from sys.dm_tran_locks dml where resource_type = 'OBJECT';";
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			while (sqlDataReader.Read())
			{
				if (sqlDataReader.GetString(0).Trim() == string_0)
				{
					return true;
				}
			}
			return false;
		}

		public List<string> GetCombinationWordsList(string text, int FirstStringWidth, int NextStringWidth)
		{
			List<string> list_ = text.Split(new char[]
			{
				' '
			}).ToList<string>();
			List<string> list = new List<string>();
			bool flag = false;
			int num = 0;
			while (!flag)
			{
				string item = this.method_12(list_, ref num, (num == 0) ? FirstStringWidth : NextStringWidth, out flag);
				list.Add(item);
			}
			return list;
		}

		private string method_12(List<string> list_0, ref int int_2, int int_3, out bool bool_0)
		{
			bool_0 = false;
			string text = "";
			Font font = new Font("Arial", 9f);
			for (int i = int_2; i < list_0.Count; i++)
			{
				if (TextRenderer.MeasureText(text, font).Width > int_3)
				{
					int_2 = i;
					return text;
				}
				text = text + list_0[i] + " ";
				if (i == list_0.Count - 1)
				{
					bool_0 = true;
				}
			}
			return text;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_13()
		{
			this.dsDocuments_0 = new dsDocuments();
			((ISupportInitialize)this.dsDocuments_0).BeginInit();
			base.SuspendLayout();
			this.dsDocuments_0.DataSetName = "dsDocuments";
			this.dsDocuments_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(284, 262);
			base.Name = "FormDocBase";
			this.Text = "FormDocBase";
			((ISupportInitialize)this.dsDocuments_0).EndInit();
			base.ResumeLayout(false);
		}

		private SqlConnection sqlConnection_0;

		private int int_0;

		private int int_1;

		private StateFormCreate stateFormCreate_0;

		[CompilerGenerated]
		private SqlTransaction sqlTransaction_0;

		private IContainer icontainer_0;

		internal dsDocuments dsDocuments_0;
	}
}
