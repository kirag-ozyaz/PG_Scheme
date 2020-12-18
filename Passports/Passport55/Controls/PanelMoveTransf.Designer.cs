using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using Passport.Classes;
using Passport.DataSets;
using Passport.Forms.Transf;
using Passport.Properties;

namespace Passport.Controls
{
	public class PanelMoveTransf : Panel
	{
		public PanelMoveTransf()
		{
			this.method_1();
		}

		public PanelMoveTransf(SQLSettings settings)
		{
			this.method_1();
			this.sqlDataCommand_0 = new SqlDataCommand(settings);
		}

		[Description("Задает или получает объект класса SQLSettings.")]
		[Category("Behavior")]
		[Browsable(false)]
		public SQLSettings SqlSettings
		{
			get
			{
				return this.sqlsettings_0;
			}
			set
			{
				this.sqlsettings_0 = value;
				this.sqlDataCommand_0 = new SqlDataCommand(this.sqlsettings_0);
			}
		}

		[Category("Behavior")]
		[Description("Задает или получает идентификатор перемещения объекта схемы.")]
		[Browsable(false)]
		public int IdMove
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

		[Description("Добавляет перемещение.")]
		public void AddMove(int idObjList, bool allowUserToAddMoveTransf)
		{
			if (new FormTransfMove
			{
				SqlSettings = this.SqlSettings,
				IdObjList = idObjList,
				AllowUserToAddMoveTransf = allowUserToAddMoveTransf
			}.ShowDialog() == DialogResult.OK)
			{
				this.RefreshMove(idObjList);
			}
		}

		[Description("Редактирует перемещение.")]
		public void AddMove(int idObjList)
		{
			if (this.dgvMoveTrans.SelectedRows != null && this.dgvMoveTrans.SelectedRows.Count > 0 && new FormEditTransfMove(this.sqlsettings_0, (int)this.dgvMoveTrans.SelectedRows[0].Cells["IdMove"].Value).ShowDialog() == DialogResult.OK)
			{
				this.method_0(idObjList, (int)this.dgvMoveTrans.SelectedRows[0].Cells["IdMove"].Value);
			}
		}

		[Description("Удаляет перемещение.")]
		public void DeleteMove(int idObjList)
		{
			if (this.dgvMoveTrans.SelectedRows != null && this.dgvMoveTrans.SelectedRows.Count > 0 && MessageBox.Show("Вы действительно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.sqlDataCommand_0.SelectSqlData(this.dsPassport_0.tSchm_Move, true, string.Format("where id = {0}", (int)this.dgvMoveTrans.SelectedRows[0].Cells["IdMove"].Value), null, false, 0);
				this.dsPassport_0.tSchm_Move.Rows[0]["Deleted"] = true;
				this.sqlDataCommand_0.UpdateSqlData(this.dsPassport_0, this.dsPassport_0.tSchm_Move);
				this.RefreshMove(idObjList);
			}
		}

		[Description("Обновляет данные.")]
		public void RefreshMove(int idObjList)
		{
			this.tssLoadOld.Visible = (this.tsbLoadOld.Visible = (";SCM;Line;" == this.sqlDataCommand_0.CallSQLScalarFunction("dbo.fn_P_GetTypeObject", new string[]
			{
				idObjList.ToString()
			}) && this.sqlsettings_0.DBName == "ULGES-SQL2"));
			if (this.dgvMoveTrans.SelectedRows != null && this.dgvMoveTrans.SelectedRows.Count > 0)
			{
				int int_ = (int)this.dgvMoveTrans.SelectedRows[0].Cells["idBalance"].Value;
				this.method_0(idObjList, int_);
				return;
			}
			this.dgvMoveTrans.DataSource = PassportData.GetBalanceData(this.SqlSettings, idObjList);
		}

		private void method_0(int int_1, int int_2)
		{
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = PassportData.GetBalanceData(this.SqlSettings, int_1);
			bindingSource.Position = bindingSource.Find("Id", int_2);
			this.dgvMoveTrans.DataSource = bindingSource;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PanelMoveTransf));
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			this.tlpMove = new TableLayoutPanel();
			this.tsMove = new ToolStrip();
			this.tsbAddMove = new ToolStripButton();
			this.tsbEditMove = new ToolStripButton();
			this.tssDeleteMove = new ToolStripSeparator();
			this.tsbDeleteMove = new ToolStripButton();
			this.tssRefreshMove = new ToolStripSeparator();
			this.tsbRefreshMove = new ToolStripButton();
			this.tssLoadOld = new ToolStripSeparator();
			this.tsbLoadOld = new ToolStripButton();
			this.dgvMoveTrans = new DataGridView();
			this.idMove = new DataGridViewTextBoxColumn();
			this.idObjList = new DataGridViewTextBoxColumn();
			this.Deleted = new DataGridViewTextBoxColumn();
			this.DateMove = new DataGridViewTextBoxColumn();
			this.Action = new DataGridViewTextBoxColumn();
			this.Direction = new DataGridViewTextBoxColumn();
			this.Comment = new DataGridViewTextBoxColumn();
			this.dsPassport_0 = new dsPassport();
			this.tlpMove.SuspendLayout();
			this.tsMove.SuspendLayout();
			((ISupportInitialize)this.dgvMoveTrans).BeginInit();
			((ISupportInitialize)this.dsPassport_0).BeginInit();
			base.SuspendLayout();
			this.tlpMove.ColumnCount = 1;
			this.tlpMove.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tlpMove.Controls.Add(this.tsMove, 0, 0);
			this.tlpMove.Controls.Add(this.dgvMoveTrans, 0, 1);
			this.tlpMove.Dock = DockStyle.Fill;
			this.tlpMove.Location = new Point(0, 0);
			this.tlpMove.Name = "tlpMove";
			this.tlpMove.RowCount = 2;
			this.tlpMove.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tlpMove.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tlpMove.Size = new Size(546, 237);
			this.tlpMove.TabIndex = 1;
			this.tsMove.Items.AddRange(new ToolStripItem[]
			{
				this.tsbAddMove,
				this.tsbEditMove,
				this.tssDeleteMove,
				this.tsbDeleteMove,
				this.tssRefreshMove,
				this.tsbRefreshMove,
				this.tssLoadOld,
				this.tsbLoadOld
			});
			this.tsMove.Location = new Point(0, 0);
			this.tsMove.Name = "tsMove";
			this.tsMove.Size = new Size(546, 25);
			this.tsMove.TabIndex = 0;
			this.tsMove.Text = "toolStrip3";
			this.tsbAddMove.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbAddMove.Image = Resources.ElementAdd;
			this.tsbAddMove.ImageTransparentColor = Color.Magenta;
			this.tsbAddMove.Name = "tsbAddMove";
			this.tsbAddMove.Size = new Size(23, 22);
			this.tsbAddMove.Text = "Добавить перемещение";
			this.tsbEditMove.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbEditMove.Image = Resources.ElementEdit;
			this.tsbEditMove.ImageTransparentColor = Color.Magenta;
			this.tsbEditMove.Name = "tsbEditMove";
			this.tsbEditMove.Size = new Size(23, 22);
			this.tsbEditMove.Text = "toolStripButton1";
			this.tssDeleteMove.Name = "tssDeleteMove";
			this.tssDeleteMove.Size = new Size(6, 25);
			this.tsbDeleteMove.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbDeleteMove.Image = Resources.ElementDel;
			this.tsbDeleteMove.ImageTransparentColor = Color.Magenta;
			this.tsbDeleteMove.Name = "tsbDeleteMove";
			this.tsbDeleteMove.Size = new Size(23, 22);
			this.tsbDeleteMove.Text = "Удалить перемещение";
			this.tssRefreshMove.Name = "tssRefreshMove";
			this.tssRefreshMove.Size = new Size(6, 25);
			this.tsbRefreshMove.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbRefreshMove.Image = Resources.refresh_16;
			this.tsbRefreshMove.ImageTransparentColor = Color.Magenta;
			this.tsbRefreshMove.Name = "tsbRefreshMove";
			this.tsbRefreshMove.Size = new Size(23, 22);
			this.tsbRefreshMove.Text = "Обновить";
			this.tssLoadOld.Name = "tssLoadOld";
			this.tssLoadOld.Size = new Size(6, 25);
			this.tsbLoadOld.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsbLoadOld.Image = (Image)componentResourceManager.GetObject("tsbLoadOld.Image");
			this.tsbLoadOld.ImageTransparentColor = Color.Magenta;
			this.tsbLoadOld.Name = "tsbLoadOld";
			this.tsbLoadOld.Size = new Size(151, 22);
			this.tsbLoadOld.Text = "Загрузить из старой базы";
			this.dgvMoveTrans.AllowUserToAddRows = false;
			this.dgvMoveTrans.AllowUserToDeleteRows = false;
			this.dgvMoveTrans.AllowUserToOrderColumns = true;
			this.dgvMoveTrans.AllowUserToResizeRows = false;
			this.dgvMoveTrans.BackgroundColor = Color.White;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dgvMoveTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dgvMoveTrans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMoveTrans.Columns.AddRange(new DataGridViewColumn[]
			{
				this.idMove,
				this.idObjList,
				this.Deleted,
				this.DateMove,
				this.Action,
				this.Direction,
				this.Comment
			});
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.dgvMoveTrans.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvMoveTrans.Dock = DockStyle.Fill;
			this.dgvMoveTrans.Location = new Point(3, 28);
			this.dgvMoveTrans.MultiSelect = false;
			this.dgvMoveTrans.Name = "dgvMoveTrans";
			this.dgvMoveTrans.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.dgvMoveTrans.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvMoveTrans.RowHeadersVisible = false;
			this.dgvMoveTrans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dgvMoveTrans.Size = new Size(540, 206);
			this.dgvMoveTrans.TabIndex = 3;
			this.idMove.DataPropertyName = "id";
			this.idMove.HeaderText = "idMove";
			this.idMove.Name = "idMove";
			this.idMove.ReadOnly = true;
			this.idMove.Visible = false;
			this.idObjList.DataPropertyName = "idObjList";
			this.idObjList.HeaderText = "idObjList";
			this.idObjList.Name = "idObjList";
			this.idObjList.ReadOnly = true;
			this.idObjList.Visible = false;
			this.Deleted.DataPropertyName = "Deleted";
			this.Deleted.HeaderText = "Deleted";
			this.Deleted.Name = "Deleted";
			this.Deleted.ReadOnly = true;
			this.Deleted.Visible = false;
			this.DateMove.DataPropertyName = "Data";
			this.DateMove.HeaderText = "Дата";
			this.DateMove.Name = "DateMove";
			this.DateMove.ReadOnly = true;
			this.Action.DataPropertyName = "Action";
			this.Action.HeaderText = "Действие";
			this.Action.Name = "Action";
			this.Action.ReadOnly = true;
			this.Action.Width = 110;
			this.Direction.DataPropertyName = "Direction";
			this.Direction.HeaderText = "Направление";
			this.Direction.Name = "Direction";
			this.Direction.ReadOnly = true;
			this.Direction.Width = 120;
			this.Comment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.Comment.DataPropertyName = "Comment";
			this.Comment.HeaderText = "Комментарий";
			this.Comment.Name = "Comment";
			this.Comment.ReadOnly = true;
			this.dsPassport_0.DataSetName = "dsPassport";
			this.dsPassport_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			base.Controls.Add(this.tlpMove);
			base.Size = new Size(546, 237);
			this.tlpMove.ResumeLayout(false);
			this.tlpMove.PerformLayout();
			this.tsMove.ResumeLayout(false);
			this.tsMove.PerformLayout();
			((ISupportInitialize)this.dgvMoveTrans).EndInit();
			((ISupportInitialize)this.dsPassport_0).EndInit();
			base.ResumeLayout(false);
		}

		private SQLSettings sqlsettings_0;

		private int int_0;

		private SqlDataCommand sqlDataCommand_0;

		private IContainer icontainer_0;

		private ToolStripButton tsbAddMove;

		private ToolStripButton tsbEditMove;

		private ToolStripSeparator tssDeleteMove;

		private ToolStripButton tsbDeleteMove;

		private ToolStripSeparator tssRefreshMove;

		private ToolStripButton tsbRefreshMove;

		private ToolStripSeparator tssLoadOld;

		private ToolStripButton tsbLoadOld;

		private DataGridViewTextBoxColumn idMove;

		private DataGridViewTextBoxColumn idObjList;

		private DataGridViewTextBoxColumn Deleted;

		private DataGridViewTextBoxColumn DateMove;

		private DataGridViewTextBoxColumn Action;

		private DataGridViewTextBoxColumn Direction;

		private DataGridViewTextBoxColumn Comment;

		private dsPassport dsPassport_0;

		internal ToolStrip tsMove;

		internal DataGridView dgvMoveTrans;

		internal TableLayoutPanel tlpMove;
	}
}
