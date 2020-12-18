using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DataSql;
using FormLbr;

namespace Passport.Forms
{
	public class FormImageView : FormBase
	{
		[DefaultValue(-1)]
		public int IdParent { get; set; }

		[DefaultValue(-1)]
		public int IdImage { get; set; }

		public FormImageView()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_2();
		}

		public FormImageView(SQLSettings settings, int idParent)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_2();
			this.SqlSettings = settings;
			this.IdParent = idParent;
		}

		public FormImageView(SQLSettings settings, int idParent, int idImage)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_2();
			this.SqlSettings = settings;
			this.IdParent = idParent;
			this.IdImage = idImage;
		}

		private void FormImageView_Load(object sender, EventArgs e)
		{
			if (this.SqlSettings != null)
			{
				this.method_0();
				if (this.IdImage != -1)
				{
					this.bindingSource_0.CurrentChanged -= this.bindingSource_0_CurrentChanged;
					this.bindingSource_0.Position = this.bindingSource_0.Find("Id", this.IdImage);
					this.method_1();
					this.bindingSource_0.CurrentChanged += this.bindingSource_0_CurrentChanged;
				}
			}
		}

		private void method_0()
		{
			DataTable dataTable = new DataTable();
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				new SqlDataAdapter(new SqlCommand(string.Format("SELECT [id] FROM tP_Image WHERE idPasspDoc = {0} AND Deleted = ((0))", this.IdParent), sqlConnection)).Fill(dataTable);
			}
			this.bindingSource_0 = new BindingSource();
			this.bindingSource_0.DataSource = dataTable;
			this.bindingNavigator_0.BindingSource = this.bindingSource_0;
			this.bindingSource_0.CurrentChanged += this.bindingSource_0_CurrentChanged;
		}

		private void bindingSource_0_CurrentChanged(object sender, EventArgs e)
		{
			if (this.bindingSource_0.Current != null && this.bindingSource_0.Current is DataRowView)
			{
				this.method_1();
			}
		}

		private void method_1()
		{
			base.SelectSqlData(this.class107_0, this.class107_0.tP_Image, true, "WHERE id = " + ((DataRowView)this.bindingSource_0.Current)["id"].ToString());
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			FormImageView.opoDA1lhALnMsQUrQ9C(this, disposing);
		}

		private void method_2()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormImageView));
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.button_0 = new Button();
			this.pictureBox_0 = new PictureBox();
			this.class107_0 = new Class107();
			this.bindingNavigator_0 = new BindingNavigator(this.icontainer_0);
			this.toolStripLabel_0 = new ToolStripLabel();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.yrhsDpsRo2 = new ToolStripTextBox();
			this.toolStripSeparator_1 = new ToolStripSeparator();
			this.toolStripButton_2 = new ToolStripButton();
			this.toolStripButton_3 = new ToolStripButton();
			this.toolStripSeparator_2 = new ToolStripSeparator();
			this.toolStripButton_4 = new ToolStripButton();
			this.toolStripButton_5 = new ToolStripButton();
			this.tableLayoutPanel_0.SuspendLayout();
			((ISupportInitialize)this.pictureBox_0).BeginInit();
			((ISupportInitialize)this.class107_0).BeginInit();
			((ISupportInitialize)this.bindingNavigator_0).BeginInit();
			this.bindingNavigator_0.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98f));
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 1, 2);
			this.tableLayoutPanel_0.Controls.Add(this.pictureBox_0, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.bindingNavigator_0, 0, 0);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 3;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 42f));
			this.tableLayoutPanel_0.Size = new Size(683, 505);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.button_0.Dock = DockStyle.Left;
			this.button_0.Location = new Point(588, 471);
			this.button_0.Margin = new Padding(3, 8, 3, 10);
			this.button_0.Name = "button1";
			this.button_0.Size = new Size(75, 24);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "Закрыть";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.pictureBox_0.BackgroundImageLayout = ImageLayout.Zoom;
			this.tableLayoutPanel_0.SetColumnSpan(this.pictureBox_0, 2);
			this.pictureBox_0.DataBindings.Add(new Binding("Image", this.class107_0, "tP_Image.Image", true));
			this.pictureBox_0.Dock = DockStyle.Fill;
			this.pictureBox_0.Location = new Point(3, 28);
			this.pictureBox_0.Name = "pbGeneral";
			this.pictureBox_0.Size = new Size(677, 432);
			this.pictureBox_0.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox_0.TabIndex = 1;
			this.pictureBox_0.TabStop = false;
			this.pictureBox_0.WaitOnLoad = true;
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.bindingNavigator_0.AddNewItem = null;
			this.tableLayoutPanel_0.SetColumnSpan(this.bindingNavigator_0, 2);
			this.bindingNavigator_0.CountItem = this.toolStripLabel_0;
			this.bindingNavigator_0.DeleteItem = null;
			this.bindingNavigator_0.Dock = DockStyle.Fill;
			this.bindingNavigator_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripButton_1,
				this.toolStripSeparator_0,
				this.yrhsDpsRo2,
				this.toolStripLabel_0,
				this.toolStripSeparator_1,
				this.toolStripButton_2,
				this.toolStripButton_3,
				this.toolStripSeparator_2,
				this.toolStripButton_4,
				this.toolStripButton_5
			});
			this.bindingNavigator_0.Location = new Point(0, 0);
			this.bindingNavigator_0.MoveFirstItem = this.toolStripButton_0;
			this.bindingNavigator_0.MoveLastItem = this.toolStripButton_3;
			this.bindingNavigator_0.MoveNextItem = this.toolStripButton_2;
			this.bindingNavigator_0.MovePreviousItem = this.toolStripButton_1;
			this.bindingNavigator_0.Name = "bnGeneral";
			this.bindingNavigator_0.PositionItem = this.yrhsDpsRo2;
			this.bindingNavigator_0.Size = new Size(683, 25);
			this.bindingNavigator_0.TabIndex = 2;
			this.bindingNavigator_0.Text = "bindingNavigator1";
			this.toolStripLabel_0.Name = "bindingNavigatorCountItem";
			this.toolStripLabel_0.Size = new Size(35, 22);
			this.toolStripLabel_0.Text = "of {0}";
			this.toolStripLabel_0.ToolTipText = "Total number of items";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = (Image)componentResourceManager.GetObject("bindingNavigatorMoveFirstItem.Image");
			this.toolStripButton_0.Name = "bindingNavigatorMoveFirstItem";
			this.toolStripButton_0.RightToLeftAutoMirrorImage = true;
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Первое";
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = (Image)componentResourceManager.GetObject("bindingNavigatorMovePreviousItem.Image");
			this.toolStripButton_1.Name = "bindingNavigatorMovePreviousItem";
			this.toolStripButton_1.RightToLeftAutoMirrorImage = true;
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Предыдущее";
			this.toolStripSeparator_0.Name = "bindingNavigatorSeparator";
			this.toolStripSeparator_0.Size = new Size(6, 25);
			this.yrhsDpsRo2.AccessibleName = "Position";
			this.yrhsDpsRo2.AutoSize = false;
			this.yrhsDpsRo2.Name = "bindingNavigatorPositionItem";
			this.yrhsDpsRo2.Size = new Size(50, 23);
			this.yrhsDpsRo2.Text = "0";
			this.yrhsDpsRo2.ToolTipText = "Current position";
			this.toolStripSeparator_1.Name = "bindingNavigatorSeparator1";
			this.toolStripSeparator_1.Size = new Size(6, 25);
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = (Image)componentResourceManager.GetObject("bindingNavigatorMoveNextItem.Image");
			this.toolStripButton_2.Name = "bindingNavigatorMoveNextItem";
			this.toolStripButton_2.RightToLeftAutoMirrorImage = true;
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "Следующее";
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = (Image)componentResourceManager.GetObject("bindingNavigatorMoveLastItem.Image");
			this.toolStripButton_3.Name = "bindingNavigatorMoveLastItem";
			this.toolStripButton_3.RightToLeftAutoMirrorImage = true;
			this.toolStripButton_3.Size = new Size(23, 22);
			this.toolStripButton_3.Text = "Последнее";
			this.toolStripSeparator_2.Name = "bindingNavigatorSeparator2";
			this.toolStripSeparator_2.Size = new Size(6, 25);
			this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_4.Image = (Image)componentResourceManager.GetObject("bindingNavigatorAddNewItem.Image");
			this.toolStripButton_4.Name = "bindingNavigatorAddNewItem";
			this.toolStripButton_4.RightToLeftAutoMirrorImage = true;
			this.toolStripButton_4.Size = new Size(23, 22);
			this.toolStripButton_4.Text = "Add new";
			this.toolStripButton_4.Visible = false;
			this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_5.Image = (Image)componentResourceManager.GetObject("bindingNavigatorDeleteItem.Image");
			this.toolStripButton_5.Name = "bindingNavigatorDeleteItem";
			this.toolStripButton_5.RightToLeftAutoMirrorImage = true;
			this.toolStripButton_5.Size = new Size(23, 22);
			this.toolStripButton_5.Text = "Delete";
			this.toolStripButton_5.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(683, 505);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormImageView";
			this.Text = "Просмотр изображений";
			base.Load += this.FormImageView_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_0.PerformLayout();
			((ISupportInitialize)this.pictureBox_0).EndInit();
			((ISupportInitialize)this.class107_0).EndInit();
			((ISupportInitialize)this.bindingNavigator_0).EndInit();
			this.bindingNavigator_0.ResumeLayout(false);
			this.bindingNavigator_0.PerformLayout();
			base.ResumeLayout(false);
		}

		internal static void opoDA1lhALnMsQUrQ9C(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private int int_1;

		private BindingSource bindingSource_0;

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private Button button_0;

		private PictureBox pictureBox_0;

		private Class107 class107_0;

		private BindingNavigator bindingNavigator_0;

		private ToolStripLabel toolStripLabel_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private ToolStripSeparator toolStripSeparator_0;

		private ToolStripTextBox yrhsDpsRo2;

		private ToolStripSeparator toolStripSeparator_1;

		private ToolStripButton toolStripButton_2;

		private ToolStripButton toolStripButton_3;

		private ToolStripSeparator toolStripSeparator_2;

		private ToolStripButton toolStripButton_4;

		private ToolStripButton toolStripButton_5;
	}
}
