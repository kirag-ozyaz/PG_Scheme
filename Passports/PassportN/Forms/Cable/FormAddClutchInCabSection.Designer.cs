using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using FormLbr;
using Passport.Classes;
using Passport.Controls;

namespace Passport.Forms.Cable
{
	public class FormAddClutchInCabSection : FormBase
	{
		public int IdCabSection
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

		public int IdCable
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

		public bool WithClutches
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		public FormAddClutchInCabSection()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_0();
		}

		public FormAddClutchInCabSection(SQLSettings settings, int idCable, int idCabSection, bool withClutches)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_0();
			this.SqlSettings = settings;
			this.int_1 = idCable;
			this.int_0 = idCabSection;
			this.bool_0 = withClutches;
		}

		private void FormAddClutchInCabSection_Load(object sender, EventArgs e)
		{
			this.panelClutch_0.SqlSettings = this.SqlSettings;
			this.panelClutch_0.IdCable = this.int_1;
			this.panelClutch_0.WithClutches = this.bool_0;
			this.panelClutch_0.CreateState = 0;
			this.panelClutch_0.Fill();
			this.int_2 = Class318.smethod_0(this.SqlSettings, base.Name);
		}

		private void FormAddClutchInCabSection_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (!decimal.TryParse(this.textBox_1.Text, out this.decimal_0))
				{
					MessageBox.Show("Некорректный ввод длины первого участка.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					e.Cancel = true;
					this.textBox_1.Focus();
					return;
				}
				if (!decimal.TryParse(this.textBox_0.Text, out this.decimal_1))
				{
					MessageBox.Show("Некорректный ввод длины второго участка.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					e.Cancel = true;
					this.textBox_0.Focus();
					return;
				}
				if (this.panelClutch_0.CreateState != 7)
				{
					if (!this.panelClutch_0.Save())
					{
						e.Cancel = true;
						return;
					}
					int id = this.panelClutch_0.Id;
					if (!Class317.smethod_2(this.SqlSettings, this.int_0, id, this.decimal_0, this.decimal_1))
					{
						MessageBox.Show("Ошибка при делении участка.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				else
				{
					int id2 = this.panelClutch_0.Id;
					if (!Class317.smethod_2(this.SqlSettings, this.int_0, id2, this.decimal_0, this.decimal_1))
					{
						MessageBox.Show("Ошибка при делении участка.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				Class318.smethod_2(this.SqlSettings, this.int_2, 0);
			}
			Class318.smethod_1(this.SqlSettings, this.int_2);
		}

		private void textBox_1_KeyPress(object sender, KeyPressEventArgs e)
		{
			InputCheck.OnlyDigit(sender, e);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.lsdmTyLxgWe != null)
			{
				this.lsdmTyLxgWe.Dispose();
			}
			FormAddClutchInCabSection.F3IPwv9RjBFF1Ar5xK8L(this, disposing);
		}

		private void method_0()
		{
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.panelClutch_0 = new PanelClutch();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.textBox_0 = new TextBox();
			this.textBox_1 = new TextBox();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.tableLayoutPanel_0.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 4;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.46917f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.37534f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.54156f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.61394f));
			this.tableLayoutPanel_0.Controls.Add(this.panelClutch_0, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.label_0, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.label_1, 2, 1);
			this.tableLayoutPanel_0.Controls.Add(this.textBox_0, 3, 1);
			this.tableLayoutPanel_0.Controls.Add(this.textBox_1, 1, 1);
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 3, 3);
			this.tableLayoutPanel_0.Controls.Add(this.button_1, 2, 3);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tlpClutch";
			this.tableLayoutPanel_0.RowCount = 4;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 38f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 10f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 35f));
			this.tableLayoutPanel_0.Size = new Size(371, 434);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.tableLayoutPanel_0.SetColumnSpan(this.panelClutch_0, 4);
			this.panelClutch_0.CreateState = 0;
			this.panelClutch_0.Dock = DockStyle.Fill;
			this.panelClutch_0.Id = 0;
			this.panelClutch_0.IdCable = 0;
			this.panelClutch_0.Location = new Point(3, 3);
			this.panelClutch_0.MinimumSize = new Size(366, 218);
			this.panelClutch_0.Name = "pnlClutch";
			this.panelClutch_0.Size = new Size(366, 345);
			this.panelClutch_0.SqlSettings = null;
			this.panelClutch_0.TabIndex = 0;
			this.panelClutch_0.WithClutches = false;
			this.label_0.AutoSize = true;
			this.label_0.Dock = DockStyle.Right;
			this.label_0.Location = new Point(7, 351);
			this.label_0.Margin = new Padding(3, 0, 3, 5);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(84, 33);
			this.label_0.TabIndex = 1;
			this.label_0.Text = "Длина первого участка";
			this.label_0.TextAlign = ContentAlignment.BottomRight;
			this.label_1.AutoSize = true;
			this.label_1.Dock = DockStyle.Right;
			this.label_1.Location = new Point(181, 351);
			this.label_1.Margin = new Padding(3, 0, 3, 5);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(83, 33);
			this.label_1.TabIndex = 2;
			this.label_1.Text = "Длина второго участка";
			this.label_1.TextAlign = ContentAlignment.BottomRight;
			this.textBox_0.Dock = DockStyle.Left;
			this.textBox_0.Location = new Point(270, 361);
			this.textBox_0.Margin = new Padding(3, 10, 3, 3);
			this.textBox_0.Name = "tbLengthSecond";
			this.textBox_0.Size = new Size(64, 20);
			this.textBox_0.TabIndex = 4;
			this.textBox_1.Dock = DockStyle.Left;
			this.textBox_1.Location = new Point(97, 361);
			this.textBox_1.Margin = new Padding(3, 10, 3, 3);
			this.textBox_1.Name = "tbLengthFirst";
			this.textBox_1.Size = new Size(64, 20);
			this.textBox_1.TabIndex = 3;
			this.textBox_1.KeyPress += this.textBox_1_KeyPress;
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Dock = DockStyle.Left;
			this.button_0.Location = new Point(272, 405);
			this.button_0.Margin = new Padding(5, 6, 3, 6);
			this.button_0.Name = "btnCancel";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 5;
			this.button_0.Text = "Отмена";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_1.DialogResult = DialogResult.OK;
			this.button_1.Dock = DockStyle.Right;
			this.button_1.Location = new Point(174, 405);
			this.button_1.Margin = new Padding(3, 6, 5, 6);
			this.button_1.Name = "btnSave";
			this.button_1.Size = new Size(88, 23);
			this.button_1.TabIndex = 6;
			this.button_1.Text = "Применить";
			this.button_1.UseVisualStyleBackColor = true;
			base.AcceptButton = this.button_1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_0;
			base.ClientSize = new Size(371, 434);
			base.Controls.Add(this.tableLayoutPanel_0);
			this.MinimumSize = new Size(385, 331);
			base.Name = "FormAddClutchInCabSection";
			this.Text = "Деление участка кабеля муфтой";
			base.FormClosing += this.FormAddClutchInCabSection_FormClosing;
			base.Load += this.FormAddClutchInCabSection_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_0.PerformLayout();
			base.ResumeLayout(false);
		}

		internal static void F3IPwv9RjBFF1Ar5xK8L(Form form_0, bool bool_1)
		{
			form_0.Dispose(bool_1);
		}

		private int int_0;

		private int int_1;

		private int int_2;

		private decimal decimal_0;

		private decimal decimal_1;

		private bool bool_0;

		private IContainer lsdmTyLxgWe;

		private TableLayoutPanel tableLayoutPanel_0;

		private PanelClutch panelClutch_0;

		private Label label_0;

		private Label label_1;

		private TextBox textBox_0;

		private TextBox textBox_1;

		private Button button_0;

		private Button button_1;
	}
}
