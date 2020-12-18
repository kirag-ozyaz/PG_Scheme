using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Constants;
using DataSql;
using FormLbr;

internal class Form0 : FormBase
{
	internal int Id { get; set; }

	internal Form0(SQLSettings sqlsettings_0, int int_3)
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.method_0();
		this.SqlSettings = sqlsettings_0;
		this.Text = "Редактирование записи";
		base.SelectSqlData(this.xHakjWlEuH.tR_DocValueList, true, "where id = " + int_3.ToString(), null, true, 0);
		this.AlDkVyFrwc.Text = this.xHakjWlEuH.tR_DocValueList.Rows[0]["Name"].ToString();
		this.stateFormCreate_0 = 1;
		this.Id = int_3;
	}

	internal Form0(SQLSettings sqlsettings_0, int int_3, int int_4)
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.method_0();
		this.SqlSettings = sqlsettings_0;
		this.Text = "Добавление записи";
		this.stateFormCreate_0 = 0;
		this.int_0 = int_3;
		this.int_1 = int_4;
	}

	private void DiLkyMyxbE_Click(object sender, EventArgs e)
	{
		if (this.stateFormCreate_0 == null)
		{
			Class14.Class62 @class = this.xHakjWlEuH.tR_DocValueList.method_5();
			@class.ParentId = this.int_0;
			@class.TypeDoc = this.int_1;
			@class.Name = this.AlDkVyFrwc.Text;
			@class.IsGroup = false;
			@class.Deleted = false;
			@class.User = this.SqlSettings.SqlUserConnect;
			@class.Date = DateTime.Now;
			this.xHakjWlEuH.tR_DocValueList.method_0(@class);
			this.Id = base.InsertSqlDataOneRow(this.xHakjWlEuH, this.xHakjWlEuH.tR_DocValueList);
			this.DiLkyMyxbE.DialogResult = DialogResult.OK;
			base.Close();
		}
		if (this.stateFormCreate_0 == 1)
		{
			this.xHakjWlEuH.tR_DocValueList.Rows[0]["Name"] = this.AlDkVyFrwc.Text;
			base.UpdateSqlData(this.xHakjWlEuH, this.xHakjWlEuH.tR_DocValueList);
			this.DiLkyMyxbE.DialogResult = DialogResult.OK;
			base.Close();
		}
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Form0.kAH0sX2ZHyXbRnDnr5e(this, bool_0);
	}

	private void method_0()
	{
		this.xHakjWlEuH = new Class14();
		this.AlDkVyFrwc = new TextBox();
		this.DiLkyMyxbE = new Button();
		this.button_0 = new Button();
		((ISupportInitialize)this.xHakjWlEuH).BeginInit();
		base.SuspendLayout();
		this.xHakjWlEuH.DataSetName = "dsDocuments";
		this.xHakjWlEuH.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.AlDkVyFrwc.Location = new Point(12, 12);
		this.AlDkVyFrwc.Multiline = true;
		this.AlDkVyFrwc.Name = "tbValue";
		this.AlDkVyFrwc.Size = new Size(358, 100);
		this.AlDkVyFrwc.TabIndex = 0;
		this.DiLkyMyxbE.Location = new Point(191, 118);
		this.DiLkyMyxbE.Name = "btnSave";
		this.DiLkyMyxbE.Size = new Size(86, 23);
		this.DiLkyMyxbE.TabIndex = 1;
		this.DiLkyMyxbE.Text = "Сохранить";
		this.DiLkyMyxbE.UseVisualStyleBackColor = true;
		this.DiLkyMyxbE.Click += this.DiLkyMyxbE_Click;
		this.button_0.DialogResult = DialogResult.Cancel;
		this.button_0.Location = new Point(295, 118);
		this.button_0.Name = "btnCancel";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 2;
		this.button_0.Text = "Отмена";
		this.button_0.UseVisualStyleBackColor = true;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(382, 149);
		base.Controls.Add(this.button_0);
		base.Controls.Add(this.DiLkyMyxbE);
		base.Controls.Add(this.AlDkVyFrwc);
		base.Name = "FormAddEditStateValue";
		base.StartPosition = FormStartPosition.CenterScreen;
		this.Text = "FormAddEditStateValue";
		((ISupportInitialize)this.xHakjWlEuH).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	internal static void kAH0sX2ZHyXbRnDnr5e(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private StateFormCreate stateFormCreate_0;

	private int int_0;

	private int int_1;

	[CompilerGenerated]
	private int int_2;

	private IContainer icontainer_0;

	private Class14 xHakjWlEuH;

	private TextBox AlDkVyFrwc;

	private Button DiLkyMyxbE;

	private Button button_0;
}
