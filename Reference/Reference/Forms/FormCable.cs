using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using Reference.Properties;

namespace Reference.Forms
{
	public partial class FormCable : FormBase
	{
		public FormCable()
		{
			
			
			this.InitializeComponent();
		}

		public int Id { get; set; }

		public bool ViewDeleted
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				if (this.bool_0 == value)
				{
					return;
				}
				this.bool_0 = value;
				if (this.bool_0)
				{
					this.bindingSource_0.Filter = "Deleted = true";
					return;
				}
				this.bindingSource_0.Filter = "Deleted = false";
			}
		}

		[DefaultValue(false)]
		public bool ViewButtons { get; set; }

		public void LoadTable()
		{
			base.SelectSqlData(this.class37_0, this.class37_0.tR_Cable, true);
			if (this.ViewDeleted)
			{
				this.bindingSource_0.Filter = "Deleted = true";
				return;
			}
			this.bindingSource_0.Filter = "Deleted = false";
		}

		private void FormCable_Load(object sender, EventArgs e)
		{
			this.tableLayoutPanel1.RowStyles[1] = new RowStyle(SizeType.Absolute, this.ViewButtons ? 43f : 0f);
			if (this.SqlSettings == null)
			{
				throw new Exception("Не указаны настройки sql");
			}
			base.SelectSqlData(this.class37_0, this.class37_0.tR_Classifier, true, "where ParentKey like ';VoltageLevels;%' and IsGroup = 0 and Deleted = 0 order by Value");
			this.LoadTable();
		}

		private void UwHeeysHh3(object sender, EventArgs e)
		{
			this.bindingSource_0.AddNew();
			if (new FormCableAdd
			{
				tRClassifierBindingSource = 
				{
					DataSource = this.bindingSource_1
				},
				tRCableBindingSource = 
				{
					DataSource = this.bindingSource_0,
					Position = this.bindingSource_0.Position
				}
			}.ShowDialog() == DialogResult.OK)
			{
				((DataRowView)this.bindingSource_0.Current)["Deleted"] = false;
				this.bindingSource_0.EndEdit();
				base.InsertSqlData(this.class37_0, this.class37_0.tR_Cable);
				this.class37_0.tR_Cable.AcceptChanges();
				this.class37_0.tR_Cable.Clear();
				this.LoadTable();
				return;
			}
			this.bindingSource_0.CancelEdit();
		}

		private void toolStripButtonEditCable_Click(object sender, EventArgs e)
		{
			if (new FormCableAdd
			{
				tRClassifierBindingSource = 
				{
					DataSource = this.bindingSource_1
				},
				tRCableBindingSource = 
				{
					DataSource = this.bindingSource_0,
					Position = this.bindingSource_0.Position
				}
			}.ShowDialog() == DialogResult.OK)
			{
				this.bindingSource_0.EndEdit();
				base.UpdateSqlData(this.class37_0, this.class37_0.tR_Cable);
				this.class37_0.tR_Cable.AcceptChanges();
				return;
			}
			this.bindingSource_0.CancelEdit();
		}

		private void toolStripButtonRemoveRestore_Click(object sender, EventArgs e)
		{
			((Class37.Class47)((DataRowView)this.bindingSource_0.Current).Row).Deleted = !this.ViewDeleted;
			this.bindingSource_0.EndEdit();
			base.UpdateSqlData(this.class37_0, this.class37_0.tR_Cable);
			this.class37_0.tR_Cable.AcceptChanges();
		}

		private void YwUewLqVne(object sender, EventArgs e)
		{
			this.ViewDeleted = this.toolStripButtonViewDeleted.Checked;
			if (this.ViewDeleted)
			{
				this.toolStripButtonRemoveRestore.Text = "Восстановить";
				this.toolStripButtonRemoveRestore.Image = Resources.smethod_8();
				return;
			}
			this.toolStripButtonRemoveRestore.Text = "Удалить";
			this.toolStripButtonRemoveRestore.Image = Resources.smethod_10();
		}

		private void dataGridViewExcelFilter1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (new FormCableAdd
			{
				tRClassifierBindingSource = 
				{
					DataSource = this.bindingSource_1
				},
				tRCableBindingSource = 
				{
					DataSource = this.bindingSource_0,
					Position = this.bindingSource_0.Position
				},
				tRClassifierBindingSource = 
				{
					DataSource = this.bindingSource_1
				}
			}.ShowDialog() == DialogResult.OK)
			{
				this.bindingSource_0.EndEdit();
				base.UpdateSqlData(this.class37_0, this.class37_0.tR_Cable);
				this.class37_0.tR_Cable.AcceptChanges();
				return;
			}
			this.bindingSource_0.CancelEdit();
		}

		private void dataGridViewExcelFilter1_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
		}

		private void toolStripButtonSearchPrev_Click(object sender, EventArgs e)
		{
			this.dataGridViewExcelFilter1.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolStripTextBoxSearch.Text);
		}

		private void toolStripButtonSearchNext_Click(object sender, EventArgs e)
		{
			this.dataGridViewExcelFilter1.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxSearch.Text);
		}

		private void btnAccept_Click(object sender, EventArgs e)
		{
			if (this.bindingSource_0.Current != null)
			{
				this.Id = (int)((DataRowView)this.bindingSource_0.Current)["Id"];
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		private bool bool_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private bool bool_1;
	}
}
