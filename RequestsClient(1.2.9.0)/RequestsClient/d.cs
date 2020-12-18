using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr;
using DataSql;
using FormLbr;

// Token: 0x02000009 RID: 9
internal partial class d : FormBase
{
	// Token: 0x06000032 RID: 50 RVA: 0x00003CED File Offset: 0x00001EED
	public override SQLSettings get_SqlSettings()
	{
		return base.SqlSettings;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00003CF5 File Offset: 0x00001EF5
	public override void set_SqlSettings(SQLSettings value)
	{
		base.SqlSettings = value;
		if (value != null)
		{
			this.d.SqlSettings = value;
		}
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00003D0D File Offset: 0x00001F0D
	internal d()
	{
		this.b();
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00003D26 File Offset: 0x00001F26
	private void h(object A_0, EventArgs A_1)
	{
		if (((ComboBox)A_0).SelectedIndex == ((ComboBox)A_0).Items.Count - 1)
		{
			this.c.Enabled = true;
			return;
		}
		this.c.Enabled = false;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00003D60 File Offset: 0x00001F60
	private void g(object A_0, EventArgs A_1)
	{
		this.c();
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00003D68 File Offset: 0x00001F68
	private void f(object A_0, EventArgs A_1)
	{
		this.c();
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00003D70 File Offset: 0x00001F70
	private void e(object A_0, EventArgs A_1)
	{
		this.c();
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003D78 File Offset: 0x00001F78
	private void d(object A_0, EventArgs A_1)
	{
		this.c();
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00003D80 File Offset: 0x00001F80
	private void c()
	{
		this.c.Items.Clear();
		if (this.d.SelectedStreet.SelectedIndex >= 0)
		{
			DataSet dataSet = new DataSet();
			DataTable dataTable = new DataTable("tMapObj");
			dataSet.Tables.Add(dataTable);
			base.SelectSqlData(dataSet, dataTable, true, " left join tAbnObj obj on tMapObj.idMap = obj.idMap  left join tAbn abn on abn.id = obj.idabn  where not abn.id is null and tMapObj.Street = " + this.d.SelectedStreet.SelectedValue.ToString() + " order by house, houseprefix", true);
			foreach (object obj in dataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				this.c.Items.Add(new e(dataRow["House"].ToString() + dataRow["HousePrefix"].ToString(), Convert.ToInt32(dataRow["IdMap"])));
			}
		}
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00003E94 File Offset: 0x00002094
	private void c(object A_0, EventArgs A_1)
	{
		base.DialogResult = DialogResult.Cancel;
		base.Close();
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00003EA4 File Offset: 0x000020A4
	private void b(object A_0, EventArgs A_1)
	{
		if (this.d.SelectedStreet.SelectedIndex < 0)
		{
			MessageBox.Show("Не выбрана улица");
			return;
		}
		if (this.d.SelectedHouseType.SelectedIndex < 0 || (this.d.SelectedHouseType.SelectedItem.ToString() == "Отдельные дома" && this.c.SelectedItems.Count == 0))
		{
			MessageBox.Show("Не выбраны дома");
			return;
		}
		this.a.Columns.Clear();
		this.a.Columns.Add("idKladrObj", typeof(int));
		this.a.Columns.Add("idstreet", typeof(int));
		this.a.Columns.Add("house", typeof(string));
		this.a.Rows.Clear();
		int num;
		if (this.d.SelectedCity.SelectedIndex < 0)
		{
			num = Convert.ToInt32(this.d.SelectedRaionObl.SelectedValue);
		}
		else
		{
			num = Convert.ToInt32(this.d.SelectedCity.SelectedValue);
		}
		int num2 = Convert.ToInt32(this.d.SelectedStreet.SelectedValue);
		if (Convert.ToInt32(this.d.SelectedHouseType.SelectedValue) == 0)
		{
			using (IEnumerator enumerator = this.c.SelectedItems.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					e e = (e)obj;
					this.a.Rows.Add(new object[]
					{
						num,
						num2,
						e.Name
					});
				}
				goto IL_248;
			}
		}
		foreach (object obj2 in this.c.Items)
		{
			e e2 = (e)obj2;
			this.a.Rows.Add(new object[]
			{
				num,
				num2,
				e2.Name
			});
		}
		IL_248:
		base.DialogResult = DialogResult.OK;
		base.Close();
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00004144 File Offset: 0x00002344
	private void b()
	{
		this.c = new ListBox();
		this.d = new KladrStreetControl();
		this.e = new Button();
		this.f = new Button();
		base.SuspendLayout();
		this.c.Enabled = false;
		this.c.FormattingEnabled = true;
		this.c.Location = new Point(181, 1);
		this.c.Name = "listBoxHouse";
		this.c.SelectionMode = SelectionMode.MultiSimple;
		this.c.Size = new Size(82, 199);
		this.c.TabIndex = 4;
		this.d.Location = new Point(1, 1);
		this.d.Margin = new Padding(4, 5, 4, 5);
		this.d.Name = "kladrStreetControl";
		this.d.Size = new Size(173, 208);
		this.d.SqlSettings = null;
		this.d.TabIndex = 3;
		this.d.VisibleCmbTypeHouse = true;
		this.d.ChangeOblSelect += this.d;
		this.d.ChangeRaionOblSelect += this.f;
		this.d.ChangePunktsSelect += this.e;
		this.d.ChangeStreetSelect += this.g;
		this.d.ChangeTypeHouseSelect += this.h;
		this.e.Location = new Point(12, 217);
		this.e.Name = "buttonOK";
		this.e.Size = new Size(75, 23);
		this.e.TabIndex = 5;
		this.e.Text = "ОК";
		this.e.UseVisualStyleBackColor = true;
		this.e.Click += this.b;
		this.f.Location = new Point(188, 217);
		this.f.Name = "buttonCancel";
		this.f.Size = new Size(75, 23);
		this.f.TabIndex = 6;
		this.f.Text = "Отмена";
		this.f.UseVisualStyleBackColor = true;
		this.f.Click += this.c;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(267, 249);
		base.Controls.Add(this.f);
		base.Controls.Add(this.e);
		base.Controls.Add(this.c);
		base.Controls.Add(this.d);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormRequestForRepairAddAddress";
		this.Text = "Добавление адреса";
		base.ResumeLayout(false);
	}

	// Token: 0x04000029 RID: 41
	public DataTable a = new DataTable();

	// Token: 0x0400002B RID: 43
	private ListBox c;

	// Token: 0x0400002C RID: 44
	private KladrStreetControl d;

	// Token: 0x0400002D RID: 45
	private Button e;

	// Token: 0x0400002E RID: 46
	private Button f;
}
