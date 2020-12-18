using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

internal class Class10 : DataGridView
{
	internal Class10()
	{
		
		this.Image = new DataGridViewImageColumn();
		this.Message = new DataGridViewTextBoxColumn();
		this.DateTime = new DataGridViewTextBoxColumn();
		
		this.Image.Name = "Image";
		this.Image.ReadOnly = true;
		this.Image.Width = 20;
		this.Message.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.Message.Name = "Message";
		this.Message.ReadOnly = true;
		this.DateTime.Name = "DateTime";
		this.DateTime.ReadOnly = true;
		this.DateTime.Width = 50;
		base.AllowUserToAddRows = false;
		base.AllowUserToDeleteRows = false;
		base.AllowUserToOrderColumns = true;
		base.AllowUserToResizeColumns = false;
		base.AllowUserToResizeRows = false;
		base.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
		base.BackgroundColor = Color.White;
		base.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		base.ColumnHeadersVisible = false;
		this.DataGridViewColumnCollection_0.AddRange(new DataGridViewColumn[]
		{
			this.Image,
			this.DateTime,
			this.Message
		});
		base.Location = new Point(243, 3);
		base.MultiSelect = false;
		base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		base.Size = new Size(240, 150);
		base.TabIndex = 4;
		base.RowsDefaultCellStyle.WrapMode = DataGridViewTriState.True;
	}

	internal ImageList method_0()
	{
		return this.imageList_0;
	}

	internal void method_1(ImageList imageList_1)
	{
		this.imageList_0 = imageList_1;
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	internal DataGridViewColumnCollection DataGridViewColumnCollection_0
	{
		get
		{
			return base.Columns;
		}
	}

	internal void method_2(string string_0, int int_0, object object_0)
	{
		DataGridViewRow dataGridViewRow = new DataGridViewRow();
		DataGridViewImageCell dataGridViewImageCell = new DataGridViewImageCell();
		DataGridViewTextBoxCell dataGridViewTextBoxCell = new DataGridViewTextBoxCell();
		DataGridViewTextBoxCell dataGridViewTextBoxCell2 = new DataGridViewTextBoxCell();
		dataGridViewRow.Cells.AddRange(new DataGridViewCell[]
		{
			dataGridViewImageCell,
			dataGridViewTextBoxCell2,
			dataGridViewTextBoxCell
		});
		if (this.imageList_0 != null && this.imageList_0.Images.Count > int_0)
		{
			dataGridViewImageCell.Value = this.imageList_0.Images[int_0];
		}
		dataGridViewTextBoxCell2.Value = System.DateTime.Now.ToString("HH:mm:ss");
		dataGridViewTextBoxCell.Value = string_0;
		if (object_0 != null)
		{
			dataGridViewRow.Tag = object_0;
		}
		this.method_3(dataGridViewRow);
	}

	private void method_3(DataGridViewRow dataGridViewRow_0)
	{
		try
		{
			if (base.InvokeRequired)
			{
				try
				{
					Class10.Delegate0 method = new Class10.Delegate0(this.method_3);
					base.Invoke(method, new object[]
					{
						dataGridViewRow_0
					});
					goto IL_3A;
				}
				catch
				{
					goto IL_3A;
				}
			}
			base.Rows.Insert(0, dataGridViewRow_0);
			IL_3A:;
		}
		catch
		{
		}
	}

	internal void method_4()
	{
		base.Rows.Clear();
	}

	private DataGridViewImageColumn Image;

	private DataGridViewTextBoxColumn Message;

	private DataGridViewTextBoxColumn DateTime;

	private ImageList imageList_0;

	private delegate void Delegate0(DataGridViewRow r);
}
