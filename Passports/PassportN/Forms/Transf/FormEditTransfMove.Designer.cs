using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataSql;
using FormLbr;

namespace Passport.Forms.Transf
{
	public class FormEditTransfMove : FormBase
	{
		public int IdObjList
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

		public FormEditTransfMove()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_0();
		}

		public FormEditTransfMove(SQLSettings settings, int id)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_0();
			this.SqlSettings = settings;
			this.IdObjList = id;
		}

		private void FormEditTransfMove_Load(object sender, EventArgs e)
		{
			string text = "WHERE (ParentKey = ';NetworkAreas;' OR ParentKey = ';Passport;ObjLocation;' OR ParentKey = ';Passport;MoveAction;') AND Deleted = ((0)) AND IsGroup = ((0)) AND Name NOT LIKE 'Реестр'";
			base.SelectSqlData(this.class107_0, this.class107_0.tR_Classifier, true, text);
			this.bindingSource_0.ResetBindings(false);
			this.bindingSource_1.ResetBindings(false);
			base.SelectSqlData(this.class107_0, this.class107_0.vP_SubstationByNetRegion, true, "");
			this.bindingSource_2.ResetBindings(false);
			base.SelectSqlData(this.class107_0, this.class107_0.tSchm_Move, true, "WHERE id = " + this.IdObjList.ToString());
			string direction = this.class107_0.tSchm_Move.Rows[0]["Direction"].ToString().ToUpper().Trim();
			EnumerableRowCollection<int> source = from row in this.class107_0.tR_Classifier
			where row.Name.ToUpper().Trim() == direction
			select row.Id;
			if (source.Count<int>() > 0)
			{
				this.comboBox_1.SelectedValue = source.First<int>();
			}
			else
			{
				source = from row in this.class107_0.vP_SubstationByNetRegion
				where row.Name.ToUpper().Trim() == direction || row.FullName.ToUpper().Trim() == direction
				select row.idNetRegion;
				if (source.Count<int>() > 0)
				{
					this.comboBox_1.SelectedValue = source.First<int>();
				}
				EnumerableRowCollection<int> source2 = from row in this.class107_0.vP_SubstationByNetRegion
				where row.Name.ToUpper().Trim() == direction || row.FullName.ToUpper().Trim() == direction
				select row.id;
				if (source2.Count<int>() > 0)
				{
					this.bindingSource_2.Position = this.bindingSource_2.Find("Id", source2.First<int>());
				}
			}
			if (this.comboBox_1.SelectedValue != null)
			{
				this.bindingSource_2.Filter = "idNetRegion = " + this.comboBox_1.SelectedValue.ToString();
			}
			this.bool_0 = true;
		}

		private void comboBox_1_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.comboBox_1.SelectedValue != null && this.bool_0)
			{
				this.bindingSource_2.Filter = "idNetRegion = " + this.comboBox_1.SelectedValue.ToString();
			}
		}

		private void bindingSource_2_CurrentChanged(object sender, EventArgs e)
		{
		}

		private void FormEditTransfMove_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				this.class107_0.tSchm_Move[0]["Direction"] = ((((DataRowView)this.bindingSource_1.Current)["Name"].ToString().IndexOf("Сетевой район") > -1) ? ((DataRowView)this.bindingSource_2.Current)["FullName"].ToString() : ((DataRowView)this.bindingSource_1.Current)["Name"].ToString());
				this.class107_0.tSchm_Move[0].EndEdit();
				if (!base.UpdateSqlData(this.class107_0, this.class107_0.tSchm_Move))
				{
					e.Cancel = true;
					return;
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_0()
		{
			this.icontainer_0 = new Container();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.label_0 = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.class107_0 = new Class107();
			this.label_1 = new Label();
			this.VlMmaiDrghm = new Label();
			this.GatmaPekyZl = new ComboBox();
			this.bindingSource_2 = new BindingSource(this.icontainer_0);
			this.label_2 = new Label();
			this.textBox_0 = new TextBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.label_3 = new Label();
			this.comboBox_0 = new ComboBox();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.comboBox_1 = new ComboBox();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.tableLayoutPanel_0.SuspendLayout();
			((ISupportInitialize)this.class107_0).BeginInit();
			((ISupportInitialize)this.bindingSource_2).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 4;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 57f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30f));
			this.tableLayoutPanel_0.Controls.Add(this.label_0, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.dateTimePicker_0, 1, 1);
			this.tableLayoutPanel_0.Controls.Add(this.label_1, 0, 2);
			this.tableLayoutPanel_0.Controls.Add(this.VlMmaiDrghm, 0, 4);
			this.tableLayoutPanel_0.Controls.Add(this.GatmaPekyZl, 1, 4);
			this.tableLayoutPanel_0.Controls.Add(this.label_2, 0, 5);
			this.tableLayoutPanel_0.Controls.Add(this.textBox_0, 1, 5);
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 1, 6);
			this.tableLayoutPanel_0.Controls.Add(this.button_1, 2, 6);
			this.tableLayoutPanel_0.Controls.Add(this.label_3, 0, 3);
			this.tableLayoutPanel_0.Controls.Add(this.comboBox_0, 1, 2);
			this.tableLayoutPanel_0.Controls.Add(this.comboBox_1, 1, 3);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 7;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 10f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 25f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 41f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_0.Size = new Size(333, 229);
			this.tableLayoutPanel_0.TabIndex = 1;
			this.label_0.AutoSize = true;
			this.label_0.Dock = DockStyle.Fill;
			this.label_0.Location = new Point(3, 10);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(104, 25);
			this.label_0.TabIndex = 8;
			this.label_0.Text = "Дата";
			this.label_0.TextAlign = ContentAlignment.MiddleRight;
			this.tableLayoutPanel_0.SetColumnSpan(this.dateTimePicker_0, 3);
			this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.class107_0, "tSchm_Move.Data", true));
			this.dateTimePicker_0.Dock = DockStyle.Fill;
			this.dateTimePicker_0.Location = new Point(113, 13);
			this.dateTimePicker_0.Name = "dtpDate";
			this.dateTimePicker_0.Size = new Size(217, 20);
			this.dateTimePicker_0.TabIndex = 0;
			this.class107_0.DataSetName = "dsPassport";
			this.class107_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.label_1.AutoSize = true;
			this.label_1.Dock = DockStyle.Fill;
			this.label_1.Location = new Point(3, 35);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(104, 25);
			this.label_1.TabIndex = 9;
			this.label_1.Text = "Действие";
			this.label_1.TextAlign = ContentAlignment.MiddleRight;
			this.VlMmaiDrghm.AutoSize = true;
			this.VlMmaiDrghm.Dock = DockStyle.Fill;
			this.VlMmaiDrghm.Location = new Point(3, 85);
			this.VlMmaiDrghm.Name = "label3";
			this.VlMmaiDrghm.Size = new Size(104, 25);
			this.VlMmaiDrghm.TabIndex = 10;
			this.VlMmaiDrghm.Text = "Подстанция";
			this.VlMmaiDrghm.TextAlign = ContentAlignment.MiddleRight;
			this.tableLayoutPanel_0.SetColumnSpan(this.GatmaPekyZl, 3);
			this.GatmaPekyZl.DataSource = this.bindingSource_2;
			this.GatmaPekyZl.DisplayMember = "FullName";
			this.GatmaPekyZl.Dock = DockStyle.Fill;
			this.GatmaPekyZl.DropDownStyle = ComboBoxStyle.DropDownList;
			this.GatmaPekyZl.FormattingEnabled = true;
			this.GatmaPekyZl.Location = new Point(113, 88);
			this.GatmaPekyZl.Name = "cbSubstation";
			this.GatmaPekyZl.Size = new Size(217, 21);
			this.GatmaPekyZl.TabIndex = 2;
			this.GatmaPekyZl.ValueMember = "id";
			this.bindingSource_2.DataMember = "vP_SubstationByNetRegion";
			this.bindingSource_2.DataSource = this.class107_0;
			this.bindingSource_2.Sort = "SocrName, Name";
			this.bindingSource_2.CurrentChanged += this.bindingSource_2_CurrentChanged;
			this.label_2.AutoSize = true;
			this.label_2.Dock = DockStyle.Fill;
			this.label_2.Location = new Point(3, 110);
			this.label_2.Name = "label6";
			this.label_2.Size = new Size(104, 78);
			this.label_2.TabIndex = 13;
			this.label_2.Text = "Комментарий";
			this.label_2.TextAlign = ContentAlignment.MiddleRight;
			this.tableLayoutPanel_0.SetColumnSpan(this.textBox_0, 3);
			this.textBox_0.DataBindings.Add(new Binding("Text", this.class107_0, "tSchm_Move.Comment", true));
			this.textBox_0.Dock = DockStyle.Fill;
			this.textBox_0.Location = new Point(113, 113);
			this.textBox_0.Multiline = true;
			this.textBox_0.Name = "tbComment";
			this.textBox_0.Size = new Size(217, 72);
			this.textBox_0.TabIndex = 5;
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Dock = DockStyle.Fill;
			this.button_0.Location = new Point(150, 198);
			this.button_0.Margin = new Padding(40, 10, 10, 10);
			this.button_0.Name = "btnAccept";
			this.button_0.Size = new Size(86, 21);
			this.button_0.TabIndex = 6;
			this.button_0.Text = "Применить";
			this.button_0.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_0.SetColumnSpan(this.button_1, 2);
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Dock = DockStyle.Fill;
			this.button_1.Location = new Point(256, 198);
			this.button_1.Margin = new Padding(10);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(67, 21);
			this.button_1.TabIndex = 7;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.label_3.AutoSize = true;
			this.label_3.Dock = DockStyle.Fill;
			this.label_3.Location = new Point(3, 60);
			this.label_3.Name = "label7";
			this.label_3.Size = new Size(104, 25);
			this.label_3.TabIndex = 14;
			this.label_3.Text = "Направление";
			this.label_3.TextAlign = ContentAlignment.MiddleRight;
			this.tableLayoutPanel_0.SetColumnSpan(this.comboBox_0, 3);
			this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.class107_0, "tSchm_Move.Action", true));
			this.comboBox_0.DataSource = this.bindingSource_0;
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(113, 38);
			this.comboBox_0.Name = "cbAction";
			this.comboBox_0.Size = new Size(217, 21);
			this.comboBox_0.TabIndex = 15;
			this.comboBox_0.ValueMember = "Id";
			this.bindingSource_0.DataMember = "tR_Classifier";
			this.bindingSource_0.DataSource = this.class107_0;
			this.bindingSource_0.Filter = "ParentKey  = ';Passport;MoveAction;'";
			this.bindingSource_0.Sort = "Name";
			this.tableLayoutPanel_0.SetColumnSpan(this.comboBox_1, 3);
			this.comboBox_1.DataSource = this.bindingSource_1;
			this.comboBox_1.DisplayMember = "Name";
			this.comboBox_1.DropDownStyle = ComboBoxStyle.DropDownList;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(113, 63);
			this.comboBox_1.Name = "cbDirection";
			this.comboBox_1.Size = new Size(217, 21);
			this.comboBox_1.TabIndex = 1;
			this.comboBox_1.ValueMember = "Id";
			this.comboBox_1.SelectedValueChanged += this.comboBox_1_SelectedValueChanged;
			this.bindingSource_1.DataMember = "tR_Classifier";
			this.bindingSource_1.DataSource = this.class107_0;
			this.bindingSource_1.Filter = "ParentKey = ';NetworkAreas;' OR ParentKey = ';Passport;ObjLocation;'";
			base.AcceptButton = this.button_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_1;
			base.ClientSize = new Size(333, 229);
			base.Controls.Add(this.tableLayoutPanel_0);
			this.MaximumSize = new Size(349, 267);
			this.MinimumSize = new Size(349, 267);
			base.Name = "FormEditTransfMove";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Редактирование";
			base.FormClosing += this.FormEditTransfMove_FormClosing;
			base.Load += this.FormEditTransfMove_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_0.PerformLayout();
			((ISupportInitialize)this.class107_0).EndInit();
			((ISupportInitialize)this.bindingSource_2).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			base.ResumeLayout(false);
		}

		private int int_0;

		private bool bool_0;

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private Label label_0;

		private DateTimePicker dateTimePicker_0;

		private Label label_1;

		private Label VlMmaiDrghm;

		private ComboBox GatmaPekyZl;

		private Label label_2;

		private TextBox textBox_0;

		private Button button_0;

		private Button button_1;

		private Label label_3;

		private ComboBox comboBox_0;

		private ComboBox comboBox_1;

		private Class107 class107_0;

		private BindingSource bindingSource_0;

		private BindingSource bindingSource_1;

		private BindingSource bindingSource_2;
	}
}
