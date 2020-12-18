using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr;
using FormLbr;

namespace Reference.Forms.MapObj
{
	public partial class FormMapObjParamAddEdit : FormBase
	{
		public FormMapObjParamAddEdit(int id, int mapId)
		{
			
			this.int_0 = -1;
			this.int_1 = -1;
			
			this.InitializeComponent();
			this.int_0 = id;
			this.int_1 = mapId;
		}

		private void FormMapObjParamAddEdit_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class20_0, this.class20_0.vMapObj, true, "where idMap = " + this.int_1.ToString());
			base.SelectSqlData(this.class20_0, this.class20_0.tR_Classifier, true, "where parentkey like '%HouseParam%' and deleted = 0 and isgroup = 0");
			this.dateTimePickerEnd.Value = null;
			if (this.int_0 == -1)
			{
				DataRow dataRow = this.class20_0.tMapObjParameter.NewRow();
				dataRow["MapObjId"] = this.int_1;
				dataRow["DateBegin"] = DateTime.Now;
				this.class20_0.tMapObjParameter.Rows.Add(dataRow);
				return;
			}
			base.SelectSqlData(this.class20_0, this.class20_0.tMapObjParameter, true, "where id = " + this.int_0.ToString());
			this.dateTimePickerEnd.Value = this.class20_0.tMapObjParameter.Rows[0]["DateEnd"];
		}

		private void bapZylnPk1_Click(object sender, EventArgs e)
		{
			this.class20_0.tMapObjParameter.Rows[0].EndEdit();
			bool flag;
			if (this.int_0 == -1)
			{
				flag = base.InsertSqlData(this.class20_0, this.class20_0.tMapObjParameter);
			}
			else
			{
				flag = base.UpdateSqlData(this.class20_0, this.class20_0.tMapObjParameter);
			}
			if (flag)
			{
				base.DialogResult = DialogResult.OK;
			}
		}

		private int int_0;

		private int int_1;
	}
}
