using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Constants;
using DataSql;

namespace Passport.Controls
{
	public class DataGridViewSectionPassport : DataGridView
	{
		[Description("Задает или получает Настройки подключения к БД")]
		public SQLSettings SqlSettings
		{
			get
			{
				return this.sqlsettings_0;
			}
			set
			{
				this.sqlsettings_0 = value;
				this.AddParameters();
			}
		}

		[Description("Задает или получает идентификатор участка кабеля")]
		public int Id
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

		[Description("Задает или получает идентификатор первой муфты")]
		public int IdClutchFirst
		{
			get
			{
				return this.int_2;
			}
			set
			{
				this.int_2 = value;
			}
		}

		[Description("Задает или получает идентификатор паспорта кабельной линии")]
		public int IdPassport
		{
			get
			{
				return this.UqWmwoZgRvQ;
			}
			set
			{
				this.UqWmwoZgRvQ = value;
			}
		}

		[Description("Задает или получает идентификатор паспорта кабельной линии")]
		public int IdObjList
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

		[Description("Задает или получает идентификатор второй муфты")]
		public int IdClutchSecond
		{
			get
			{
				return this.int_3;
			}
			set
			{
				this.int_3 = value;
			}
		}

		internal DataGridViewSectionPassport()
		{
			Class330.Mus9JxKz1CNxy();
			this.componentResourceManager_0 = new ComponentResourceManager(typeof(DataGridViewPassport));
			base..ctor();
			this.method_2();
		}

		internal DataGridViewSectionPassport(IContainer container)
		{
			Class330.Mus9JxKz1CNxy();
			this.componentResourceManager_0 = new ComponentResourceManager(typeof(DataGridViewPassport));
			base..ctor();
			container.Add(this);
			this.method_2();
		}

		internal DataGridViewSectionPassport(SQLSettings settings, int idPassport, int idClutchFirst, int idClutchSecond)
		{
			Class330.Mus9JxKz1CNxy();
			this.componentResourceManager_0 = new ComponentResourceManager(typeof(DataGridViewPassport));
			base..ctor();
			this.method_2();
			this.sqlsettings_0 = settings;
			this.int_2 = idClutchFirst;
			this.int_3 = idClutchSecond;
			this.AddParameters();
			this.stateFormCreate_0 = 0;
		}

		internal DataGridViewSectionPassport(SQLSettings settings, int idCableSection)
		{
			Class330.Mus9JxKz1CNxy();
			this.componentResourceManager_0 = new ComponentResourceManager(typeof(DataGridViewPassport));
			base..ctor();
			this.method_2();
			this.sqlsettings_0 = settings;
			this.int_0 = idCableSection;
			this.AddParameters();
			this.AddParameterValues();
			this.stateFormCreate_0 = 1;
		}

		public void AddParameters()
		{
			this.idChar = new DataGridViewTextBoxColumn();
			this.idChar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.componentResourceManager_0.ApplyResources(this.idChar, "idChar");
			this.idChar.Name = "idChar";
			this.idChar.HeaderText = "idChar";
			this.idChar.ReadOnly = true;
			this.idChar.Resizable = DataGridViewTriState.True;
			this.idChar.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.idChar.Visible = false;
			this.NameChar = new DataGridViewTextBoxColumn();
			this.NameChar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.NameChar.FillWeight = 150f;
			this.componentResourceManager_0.ApplyResources(this.NameChar, "NameChar");
			this.NameChar.Name = "NameChar";
			this.NameChar.HeaderText = "Характеристика";
			this.NameChar.ReadOnly = true;
			this.NameChar.Resizable = DataGridViewTriState.True;
			this.NameChar.SortMode = DataGridViewColumnSortMode.Programmatic;
			this.ValueChar = new DataGridViewTextBoxColumn();
			this.ValueChar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.componentResourceManager_0.ApplyResources(this.ValueChar, "ValueChar");
			this.ValueChar.Name = "ValueChar";
			this.NameChar.HeaderText = "Значение";
			this.ValueChar.Resizable = DataGridViewTriState.True;
			this.ValueChar.SortMode = DataGridViewColumnSortMode.Programmatic;
			base.Columns.AddRange(new DataGridViewColumn[]
			{
				this.idChar,
				this.NameChar,
				this.ValueChar
			});
			base.Rows.Add(this.pcnmwlNocni(0, "Марка кабеля", this.method_1((DataGridViewSectionPassport.Enum9)0)));
			base.Rows.Add(this.pcnmwlNocni(1, "Напряжение", this.method_1((DataGridViewSectionPassport.Enum9)1)));
			base.Rows.Add(this.pcnmwlNocni(2, "Количество жил", this.method_1((DataGridViewSectionPassport.Enum9)2)));
			base.Rows.Add(this.pcnmwlNocni(3, "Сечение кабеля", this.method_1((DataGridViewSectionPassport.Enum9)3)));
			base.Rows.Add(this.pcnmwlNocni(4, "Длина участка", this.method_1((DataGridViewSectionPassport.Enum9)4)));
			base.Rows.Add(this.pcnmwlNocni(6, "Количество", this.method_1((DataGridViewSectionPassport.Enum9)6)));
			base.Rows.Add(this.pcnmwlNocni(10, "Комментарий", this.method_1((DataGridViewSectionPassport.Enum9)10)));
		}

		public void AddParameterValues()
		{
			new SqlDataCommand(this.sqlsettings_0).SelectSqlData(this.class107_0.tP_CabSection, true, "WHERE id = " + this.int_0.ToString(), null, false, 0);
			if (this.class107_0.tP_CabSection.Rows.Count == 0)
			{
				throw new Exception("DataGridViewSection.AddParameterValues(): Rows not found.");
			}
			Class107.Class253 @class = (Class107.Class253)this.class107_0.tP_CabSection.Rows[0];
			base.Rows[0].Cells["ValueChar"].Value = @class.CableMakeup;
			base.Rows[1].Cells["ValueChar"].Value = @class.Voltage;
			base.Rows[2].Cells["ValueChar"].Value = @class.Wires;
			base.Rows[3].Cells["ValueChar"].Value = @class.CrossSection;
			base.Rows[4].Cells["ValueChar"].Value = @class.Length;
			base.Rows[6].Cells["ValueChar"].Value = @class.Count;
			base.Rows[10].Cells["ValueChar"].Value = @class.Comment;
		}

		private int method_0()
		{
			Class107.Class253 @class = this.class107_0.tP_CabSection.method_5();
			@class.idObjList = this.UqWmwoZgRvQ;
			@class.idClutchFirst = this.int_2;
			@class.idClutchSecond = this.int_3;
			@class.CableMakeup = (int)base.Rows[0].Cells["ValueChar"].Value;
			@class.Voltage = (decimal)base.Rows[1].Cells["ValueChar"].Value;
			@class.Wires = (int)base.Rows[2].Cells["ValueChar"].Value;
			@class.CrossSection = (decimal)base.Rows[3].Cells["ValueChar"].Value;
			@class.Length = (decimal)base.Rows[4].Cells["ValueChar"].Value;
			@class.Count = (int)base.Rows[6].Cells["ValueChar"].Value;
			@class.Comment = base.Rows[10].Cells["ValueChar"].Value.ToString();
			return Class317.smethod_1(this.sqlsettings_0, @class, this.UqWmwoZgRvQ, this.int_2, this.int_3);
		}

		public bool EditCableSection()
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			if (this.class107_0.tP_CabSection.Rows.Count == 0)
			{
				throw new Exception("DataGridViewSection.EditCableSection(): Rows not found.");
			}
			Class107.Class253 @class = (Class107.Class253)this.class107_0.tP_CabSection.Rows[0];
			@class.CableMakeup = (int)base.Rows[0].Cells["ValueChar"].Value;
			@class.Voltage = (decimal)base.Rows[1].Cells["ValueChar"].Value;
			@class.Wires = (int)base.Rows[2].Cells["ValueChar"].Value;
			@class.CrossSection = (decimal)base.Rows[3].Cells["ValueChar"].Value;
			@class.Length = (decimal)base.Rows[4].Cells["ValueChar"].Value;
			@class.Count = (int)base.Rows[6].Cells["ValueChar"].Value;
			@class.Comment = base.Rows[10].Cells["ValueChar"].Value.ToString();
			return sqlDataCommand.UpdateSqlData(this.class107_0, this.class107_0.tP_CabSection);
		}

		private DataGridViewCell method_1(DataGridViewSectionPassport.Enum9 enum9_0)
		{
			if (enum9_0 == (DataGridViewSectionPassport.Enum9)0)
			{
				DataGridViewComboBoxCell dataGridViewComboBoxCell = new DataGridViewComboBoxCell();
				new SqlDataCommand(this.sqlsettings_0).SelectSqlData(this.class107_0.tP_ValueLists, true, "WHERE ParentId = 100 AND isGroup = ((0)) AND Deleted = ((0))", null, false, 0);
				dataGridViewComboBoxCell.DataSource = new BindingSource
				{
					DataSource = this.class107_0.tP_ValueLists,
					Sort = "Name"
				};
				dataGridViewComboBoxCell.DisplayMember = "Name";
				dataGridViewComboBoxCell.ValueMember = "id";
				return dataGridViewComboBoxCell;
			}
			return new DataGridViewTextBoxCell();
		}

		private DataGridViewRow pcnmwlNocni(int int_4, string string_0, DataGridViewCell dataGridViewCell_0)
		{
			DataGridViewRow dataGridViewRow = new DataGridViewRow();
			DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
			dataGridViewTextBoxCell.Value = int_4;
			dataGridViewRow.Cells.Insert(0, dataGridViewTextBoxCell);
			DataGridViewTextBoxCell dataGridViewTextBoxCell2 = new DataGridViewTextBoxCell();
			dataGridViewTextBoxCell2.Value = string_0;
			dataGridViewRow.Cells.Insert(1, dataGridViewTextBoxCell2);
			dataGridViewRow.Cells.Insert(2, dataGridViewCell_0);
			return dataGridViewRow;
		}

		public bool Save()
		{
			StateFormCreate stateFormCreate = this.stateFormCreate_0;
			if (stateFormCreate != null)
			{
				return stateFormCreate == 1 && this.EditCableSection();
			}
			this.Id = this.method_0();
			return true;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_2()
		{
			this.class107_0 = new Class107();
			((ISupportInitialize)this.class107_0).BeginInit();
			((ISupportInitialize)this).BeginInit();
			base.SuspendLayout();
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.EditMode = DataGridViewEditMode.EditOnEnter;
			base.RowHeadersVisible = false;
			((ISupportInitialize)this.class107_0).EndInit();
			((ISupportInitialize)this).EndInit();
			base.ResumeLayout(false);
		}

		private SQLSettings sqlsettings_0;

		private int int_0;

		private int int_1;

		private int UqWmwoZgRvQ;

		private int int_2;

		private int int_3;

		private StateFormCreate stateFormCreate_0;

		private DataGridViewTextBoxColumn idChar;

		private DataGridViewTextBoxColumn NameChar;

		private DataGridViewTextBoxColumn ValueChar;

		private ComponentResourceManager componentResourceManager_0;

		private IContainer icontainer_0;

		private Class107 class107_0;

		[Description("Перечисление характеристик участа кабеля")]
		internal enum Enum9
		{

		}
	}
}
