using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr;
using FormLbr;

namespace ReferenceMapObj
{
	public partial class FormMapObjParamAddEdit : FormBase
	{
        private int paramId = -1;

        private int mapObjId = -1;

        public FormMapObjParamAddEdit(int id, int mapId)
		{
			this.InitializeComponent();
			this.paramId = id;
			this.mapObjId = mapId;
		}

		private void FormMapObjParamAddEdit_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.dsKladr, this.dsKladr.vMapObj, true, "where idMap = " + this.mapObjId.ToString());
			base.SelectSqlData(this.dsKladr, this.dsKladr.tR_Classifier, true, "where parentkey like '%HouseParam%' and deleted = 0 and isgroup = 0");
			this.dateTimePickerEnd.Value = null;
			if (this.paramId == -1)
			{
				DataRow dataRow = this.dsKladr.tMapObjParameter.NewRow();
				dataRow["MapObjId"] = this.mapObjId;
				dataRow["DateBegin"] = DateTime.Now;
				this.dsKladr.tMapObjParameter.Rows.Add(dataRow);
				return;
			}
			base.SelectSqlData(this.dsKladr, this.dsKladr.tMapObjParameter, true, "where id = " + this.paramId.ToString());
			this.dateTimePickerEnd.Value = this.dsKladr.tMapObjParameter.Rows[0]["DateEnd"];
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.dsKladr.tMapObjParameter.Rows[0].EndEdit();
			bool flag;
			if (this.paramId == -1)
			{
				flag = base.InsertSqlData(this.dsKladr, this.dsKladr.tMapObjParameter);
			}
			else
			{
				flag = base.UpdateSqlData(this.dsKladr, this.dsKladr.tMapObjParameter);
			}
			if (flag)
			{
				base.DialogResult = DialogResult.OK;
			}
		}


	}
}
