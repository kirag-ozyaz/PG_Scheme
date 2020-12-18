using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DataSql;
using FormLbr;
using Passport.Controls;

namespace Passport.Forms.Cable
{
	public class FormAddSectionInCabSection : FormBase
	{
		public int IdCable
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

		public int IdCabSection
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

		public FormAddSectionInCabSection(SQLSettings settings, int idCabSection, int idCable)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_1();
			this.SqlSettings = settings;
			this.int_1 = idCabSection;
			this.int_0 = idCable;
			this.int_2 = 0;
		}

		private void FormAddSectionInCabSection_Load(object sender, EventArgs e)
		{
			this.panelClutch_0 = new PanelClutch(this.SqlSettings, this.int_0, 0);
			this.panelClutch_0.WithClutches = true;
			this.panelClutch_0.Fill();
			this.panelClutch_1 = new PanelClutch(this.SqlSettings, this.int_0, 0);
			this.panelClutch_1.WithClutches = true;
			this.panelClutch_1.Fill();
			this.panelPassportCabSection_0 = new PanelPassportCabSection(this.SqlSettings, this.int_0);
			this.panelPassportCabSection_0.Fill();
			this.dictionary_0 = new Dictionary<int, Panel>();
			this.dictionary_0.Add(0, this.panelClutch_0);
			this.dictionary_0.Add(1, this.panelClutch_1);
			this.dictionary_0.Add(2, this.panelPassportCabSection_0);
			this.method_0(FormAddSectionInCabSection.Position.First);
			this.int_5 = Class318.smethod_0(this.SqlSettings, base.Name);
		}

		private void method_0(FormAddSectionInCabSection.Position position_0)
		{
			switch (position_0)
			{
			case FormAddSectionInCabSection.Position.First:
				this.int_2 = 0;
				break;
			case FormAddSectionInCabSection.Position.Prev:
				this.int_2--;
				break;
			case FormAddSectionInCabSection.Position.Next:
				this.int_2 = ((this.int_2 == this.dictionary_0.Count - 1) ? this.int_2 : (this.int_2 + 1));
				break;
			case FormAddSectionInCabSection.Position.Last:
				this.int_2 = this.dictionary_0.Count - 1;
				break;
			}
			this.button_2.Enabled = (this.int_2 != 0);
			this.button_1.Text = ((this.int_2 == this.dictionary_0.Count - 1) ? "Готово" : "Далее");
			this.button_1.DialogResult = ((this.int_2 == this.dictionary_0.Count - 1) ? DialogResult.OK : DialogResult.None);
			this.tableLayoutPanel_0.Controls.Add(this.dictionary_0.ElementAt(this.int_2).Value, 0, 1);
			this.tableLayoutPanel_0.SetColumnSpan(this.dictionary_0.ElementAt(this.int_2).Value, 4);
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			if (this.tableLayoutPanel_0.Controls.Contains(this.dictionary_0.ElementAt(this.int_2).Value))
			{
				this.tableLayoutPanel_0.Controls.Remove(this.dictionary_0.ElementAt(this.int_2).Value);
			}
			this.method_0(FormAddSectionInCabSection.Position.Next);
		}

		private void button_2_Click(object sender, EventArgs e)
		{
			if (this.tableLayoutPanel_0.Controls.Contains(this.dictionary_0.ElementAt(this.int_2).Value))
			{
				this.tableLayoutPanel_0.Controls.Remove(this.dictionary_0.ElementAt(this.int_2).Value);
			}
			this.method_0(FormAddSectionInCabSection.Position.Prev);
		}

		private void FormAddSectionInCabSection_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (!decimal.TryParse(this.textBox_0.Text, out this.decimal_0))
				{
					MessageBox.Show("Некорректный ввод длины первого участка.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					e.Cancel = true;
					this.textBox_0.Focus();
					return;
				}
				if (!decimal.TryParse(this.textBox_1.Text, out this.CummGsaHaXJ))
				{
					MessageBox.Show("Некорректный ввод длины второго участка.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					e.Cancel = true;
					this.textBox_1.Focus();
					return;
				}
				if (!this.panelClutch_0.CheckData() || !this.panelClutch_1.CheckData() || !this.panelPassportCabSection_0.CheckData())
				{
					e.Cancel = true;
					return;
				}
				if (!this.panelClutch_0.Save())
				{
					e.Cancel = true;
					return;
				}
				this.int_3 = this.panelClutch_0.Id;
				if (!this.panelClutch_1.Save())
				{
					e.Cancel = true;
					return;
				}
				this.int_4 = this.panelClutch_1.Id;
				DataRow dataRow_ = this.panelPassportCabSection_0.ogFmzrxChvd();
				if (!Class317.smethod_3(this.SqlSettings, this.int_1, dataRow_, this.int_3, this.int_4, this.decimal_0, this.CummGsaHaXJ))
				{
					e.Cancel = true;
					return;
				}
				Class318.smethod_2(this.SqlSettings, this.int_5, 0);
			}
			Class318.smethod_1(this.SqlSettings, this.int_5);
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
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.button_2 = new Button();
			this.textBox_1 = new TextBox();
			this.textBox_0 = new TextBox();
			this.label_1 = new Label();
			this.label_0 = new Label();
			this.button_1 = new Button();
			this.button_0 = new Button();
			this.tableLayoutPanel_0.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 4;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.29885f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.67816f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.87356f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.57471f));
			this.tableLayoutPanel_0.Controls.Add(this.button_2, 0, 4);
			this.tableLayoutPanel_0.Controls.Add(this.textBox_1, 3, 2);
			this.tableLayoutPanel_0.Controls.Add(this.textBox_0, 1, 2);
			this.tableLayoutPanel_0.Controls.Add(this.label_1, 2, 2);
			this.tableLayoutPanel_0.Controls.Add(this.label_0, 0, 2);
			this.tableLayoutPanel_0.Controls.Add(this.button_1, 2, 4);
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 3, 4);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 5;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 10f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 38f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 10f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 34f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_0.Size = new Size(348, 511);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.button_2.Dock = DockStyle.Right;
			this.button_2.Location = new Point(3, 483);
			this.button_2.Margin = new Padding(3, 6, 5, 6);
			this.button_2.Name = "btnPrev";
			this.button_2.Size = new Size(87, 22);
			this.button_2.TabIndex = 12;
			this.button_2.Text = "Назад";
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			this.textBox_1.Dock = DockStyle.Left;
			this.textBox_1.Location = new Point(260, 439);
			this.textBox_1.Margin = new Padding(3, 10, 3, 3);
			this.textBox_1.Name = "tbLengthSecond";
			this.textBox_1.Size = new Size(59, 20);
			this.textBox_1.TabIndex = 11;
			this.textBox_0.Dock = DockStyle.Left;
			this.textBox_0.Location = new Point(98, 439);
			this.textBox_0.Margin = new Padding(3, 10, 3, 3);
			this.textBox_0.Name = "tbLengthFirst";
			this.textBox_0.Size = new Size(59, 20);
			this.textBox_0.TabIndex = 10;
			this.label_1.AutoSize = true;
			this.label_1.Dock = DockStyle.Right;
			this.label_1.Location = new Point(171, 429);
			this.label_1.Margin = new Padding(3, 0, 3, 5);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(83, 33);
			this.label_1.TabIndex = 9;
			this.label_1.Text = "Длина второго участка";
			this.label_1.TextAlign = ContentAlignment.BottomRight;
			this.label_0.AutoSize = true;
			this.label_0.Dock = DockStyle.Right;
			this.label_0.Location = new Point(8, 429);
			this.label_0.Margin = new Padding(3, 0, 3, 5);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(84, 33);
			this.label_0.TabIndex = 8;
			this.label_0.Text = "Длина первого участка";
			this.label_0.TextAlign = ContentAlignment.BottomRight;
			this.button_1.Dock = DockStyle.Right;
			this.button_1.Location = new Point(164, 483);
			this.button_1.Margin = new Padding(3, 6, 5, 6);
			this.button_1.Name = "btnSave";
			this.button_1.Size = new Size(88, 22);
			this.button_1.TabIndex = 7;
			this.button_1.Text = "Далее";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Dock = DockStyle.Left;
			this.button_0.Location = new Point(262, 483);
			this.button_0.Margin = new Padding(5, 6, 3, 6);
			this.button_0.Name = "btnCancel";
			this.button_0.Size = new Size(75, 22);
			this.button_0.TabIndex = 6;
			this.button_0.Text = "Отмена";
			this.button_0.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(348, 511);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormAddSectionInCabSection";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Деление участка кабеля";
			base.FormClosing += this.FormAddSectionInCabSection_FormClosing;
			base.Load += this.FormAddSectionInCabSection_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_0.PerformLayout();
			base.ResumeLayout(false);
		}

		private Dictionary<int, Panel> dictionary_0;

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;

		private int int_4;

		private int int_5;

		private PanelClutch panelClutch_0;

		private PanelClutch panelClutch_1;

		private PanelPassportCabSection panelPassportCabSection_0;

		private decimal decimal_0;

		private decimal CummGsaHaXJ;

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private Button button_0;

		private Button button_1;

		private Label label_0;

		private Label label_1;

		private TextBox textBox_0;

		private TextBox textBox_1;

		private Button button_2;

		public enum Position
		{
			First,
			Prev,
			Current,
			Next,
			Last
		}
	}
}
