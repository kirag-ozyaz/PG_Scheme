using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using FormLbr;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;

internal class Form3 : FormBase
{
	internal Form3()
	{
		Class90.TDroV38zslI2T();
		this.dataTable_0 = new DataTable();
		this.bool_0 = true;
		base..ctor();
		this.method_0();
	}

	internal Form3(SQLSettings sqlsettings_0, TelemetryLabelTool telemetryLabelTool_1)
	{
		Class90.TDroV38zslI2T();
		this.dataTable_0 = new DataTable();
		this.bool_0 = true;
		base..ctor();
		this.method_0();
		this.SqlSettings = sqlsettings_0;
		this.telemetryLabelTool_0 = telemetryLabelTool_1;
		DrawObjectBase drawObjectBase = this.telemetryLabelTool_0.Layer.Parent.FindObjectById(this.telemetryLabelTool_0.ObjectTelemetry);
		if (drawObjectBase == null)
		{
			return;
		}
		string text = string.Empty;
		if (drawObjectBase.GetType() == typeof(RectangleTool))
		{
			text = "Подстанция";
		}
		else if (drawObjectBase.GetType() == typeof(ShinaTool))
		{
			text = "Секция шин";
		}
		else if (drawObjectBase.GetType() == typeof(LineCellTool))
		{
			text = "Ячейка";
		}
		else if (drawObjectBase.GetType() == typeof(TransformerTool))
		{
			text = "Трансформатор";
		}
		else if (drawObjectBase.GetType() == typeof(ObjectOnLine) && drawObjectBase.GetType().GetProperty("On").CanWrite)
		{
			text = "Коммутационный аппарат";
		}
		this.textBox_0.Text = this.telemetryLabelTool_0.Prefix;
		this.textBox_1.Text = drawObjectBase.GetFullName();
		this.checkBox_0.Checked = this.telemetryLabelTool_0.UseSettingsText;
		this.font_0 = this.telemetryLabelTool_0.TextProperty.Font;
		this.color_0 = this.telemetryLabelTool_0.TextProperty.Color;
		this.panel_0.BackColor = this.color_0;
		this.numericUpDown_0.Value = this.telemetryLabelTool_0.DecimalPlaces;
		if (text == string.Empty)
		{
			return;
		}
		using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
		{
			try
			{
				SqlCommand sqlCommand = new SqlCommand("SELECT [Id]\r\n                                     ,[ObjectDescription]\r\n                                     ,[Description]\r\n                                     ,[Measure]\r\n                               FROM [OPC_Config].[dbo].[Parameters]\r\n                               WHERE ObjectDescription LIKE '" + text + "'", sqlConnection);
				sqlConnection.Open();
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
				this.dataTable_0.Load(sqlDataReader);
				sqlDataReader.Close();
				sqlConnection.Close();
			}
			catch
			{
			}
		}
		if (this.dataTable_0.Rows.Count > 0)
		{
			this.comboBox_0.DataSource = this.dataTable_0;
			this.comboBox_0.ValueMember = "Id";
			this.comboBox_0.DisplayMember = "Description";
			this.comboBox_0.SelectedValue = this.telemetryLabelTool_0.TelemetryParameterId;
		}
		else
		{
			this.comboBox_0.Enabled = false;
		}
		if (this.telemetryLabelTool_0.Layer != null && this.telemetryLabelTool_0.Layer.Parent != null)
		{
			if (this.telemetryLabelTool_0.GetType() == typeof(NodeTool))
			{
				if (this.telemetryLabelTool_0.Layer.Parent.Mode == eCanvasEditingMode.ReadOnly || this.telemetryLabelTool_0.LimitedEditing)
				{
					this.button_1.Enabled = false;
				}
			}
			else if (this.telemetryLabelTool_0.Layer.Parent.Mode != eCanvasEditingMode.Edit && !this.telemetryLabelTool_0.LimitedEditing)
			{
				this.button_1.Enabled = false;
			}
		}
		this.bool_0 = false;
	}

	protected override void OnClosing(CancelEventArgs cancelEventArgs_0)
	{
		base.OnClosing(cancelEventArgs_0);
		if (base.DialogResult == DialogResult.OK)
		{
			this.telemetryLabelTool_0.Prefix = this.textBox_0.Text;
			this.telemetryLabelTool_0.DecimalPlaces = Convert.ToInt32(this.numericUpDown_0.Value);
			if (this.comboBox_0.SelectedValue != null)
			{
				this.telemetryLabelTool_0.TelemetryParameterId = (int)this.comboBox_0.SelectedValue;
			}
			if (this.checkBox_0.Checked)
			{
				this.telemetryLabelTool_0.UseSettingColor = true;
				this.telemetryLabelTool_0.UseSettingsText = true;
			}
			else
			{
				this.telemetryLabelTool_0.UseSettingColor = false;
				this.telemetryLabelTool_0.UseSettingsText = false;
				this.telemetryLabelTool_0.TextProperty.Font = this.font_0;
				this.telemetryLabelTool_0.TextProperty.Color = this.color_0;
				this.telemetryLabelTool_0.Color = this.panel_0.BackColor;
			}
			if (this.telemetryLabelTool_0.Layer.Parent.UseObjectFromDB && !this.telemetryLabelTool_0.SaveToSql(false, false))
			{
				this.telemetryLabelTool_0.Copy(this.telemetryLabelTool_0);
				cancelEventArgs_0.Cancel = true;
				return;
			}
		}
	}

	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		this.button_2.Enabled = !this.checkBox_0.Checked;
		this.panel_0.Enabled = !this.checkBox_0.Checked;
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		this.fontDialog_0.Font = this.telemetryLabelTool_0.TextProperty.Font;
		if (this.fontDialog_0.ShowDialog() == DialogResult.OK)
		{
			this.font_0 = this.fontDialog_0.Font;
		}
	}

	private void panel_0_DoubleClick(object sender, EventArgs e)
	{
		this.colorDialog_0.Color = this.color_0;
		if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
		{
			this.color_0 = this.colorDialog_0.Color;
			this.panel_0.BackColor = this.color_0;
		}
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (!this.bool_0)
		{
			this.textBox_0.Text = this.comboBox_0.Text + ": ";
		}
		if (this.comboBox_0.ValueMember != string.Empty && this.comboBox_0.SelectedValue != null)
		{
			DataRow[] array = this.dataTable_0.Select("Id = " + this.comboBox_0.SelectedValue);
			this.numericUpDown_0.Enabled = (array.Length == 0 || !array[0].IsNull("Measure"));
		}
	}

	protected override void Dispose(bool bool_1)
	{
		if (bool_1 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(bool_1);
	}

	private void method_0()
	{
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.textBox_0 = new TextBox();
		this.label_0 = new Label();
		this.label_1 = new Label();
		this.textBox_1 = new TextBox();
		this.comboBox_0 = new ComboBox();
		this.label_2 = new Label();
		this.groupBox_0 = new GroupBox();
		this.label_3 = new Label();
		this.panel_0 = new Panel();
		this.button_2 = new Button();
		this.checkBox_0 = new CheckBox();
		this.fontDialog_0 = new FontDialog();
		this.colorDialog_0 = new ColorDialog();
		this.numericUpDown_0 = new NumericUpDown();
		this.label_4 = new Label();
		this.groupBox_0.SuspendLayout();
		((ISupportInitialize)this.numericUpDown_0).BeginInit();
		base.SuspendLayout();
		this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_0.DialogResult = DialogResult.Cancel;
		this.button_0.Location = new Point(231, 244);
		this.button_0.Name = "buttonCancel";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 0;
		this.button_0.Text = "Отмена";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_1.DialogResult = DialogResult.OK;
		this.button_1.Location = new Point(150, 244);
		this.button_1.Name = "buttonOK";
		this.button_1.Size = new Size(75, 23);
		this.button_1.TabIndex = 0;
		this.button_1.Text = "OK";
		this.button_1.UseVisualStyleBackColor = true;
		this.textBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.textBox_0.Location = new Point(12, 25);
		this.textBox_0.Name = "textBoxTextLabel";
		this.textBox_0.Size = new Size(294, 20);
		this.textBox_0.TabIndex = 3;
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(12, 9);
		this.label_0.Name = "labelText";
		this.label_0.Size = new Size(53, 13);
		this.label_0.TabIndex = 2;
		this.label_0.Text = "Префикс";
		this.label_1.AutoSize = true;
		this.label_1.Location = new Point(12, 48);
		this.label_1.Name = "label1";
		this.label_1.Size = new Size(110, 13);
		this.label_1.TabIndex = 2;
		this.label_1.Text = "Привязаный объект";
		this.textBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.textBox_1.Location = new Point(12, 64);
		this.textBox_1.Name = "textBoxPrefix";
		this.textBox_1.ReadOnly = true;
		this.textBox_1.Size = new Size(294, 20);
		this.textBox_1.TabIndex = 3;
		this.comboBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.comboBox_0.DropDownStyle = ComboBoxStyle.DropDownList;
		this.comboBox_0.FormattingEnabled = true;
		this.comboBox_0.Location = new Point(12, 103);
		this.comboBox_0.Name = "comboBoxParametr";
		this.comboBox_0.Size = new Size(294, 21);
		this.comboBox_0.TabIndex = 4;
		this.comboBox_0.SelectedIndexChanged += this.comboBox_0_SelectedIndexChanged;
		this.label_2.AutoSize = true;
		this.label_2.Location = new Point(12, 87);
		this.label_2.Name = "label2";
		this.label_2.Size = new Size(144, 13);
		this.label_2.TabIndex = 2;
		this.label_2.Text = "Отслеживаемый параметр";
		this.groupBox_0.Controls.Add(this.label_3);
		this.groupBox_0.Controls.Add(this.panel_0);
		this.groupBox_0.Controls.Add(this.button_2);
		this.groupBox_0.Controls.Add(this.checkBox_0);
		this.groupBox_0.Location = new Point(12, 156);
		this.groupBox_0.Name = "groupBox1";
		this.groupBox_0.Size = new Size(293, 82);
		this.groupBox_0.TabIndex = 5;
		this.groupBox_0.TabStop = false;
		this.label_3.AutoSize = true;
		this.label_3.Location = new Point(148, 47);
		this.label_3.Name = "label3";
		this.label_3.Size = new Size(32, 13);
		this.label_3.TabIndex = 3;
		this.label_3.Text = "Цвет";
		this.panel_0.Location = new Point(186, 42);
		this.panel_0.Name = "panelColor";
		this.panel_0.Size = new Size(66, 23);
		this.panel_0.TabIndex = 2;
		this.panel_0.DoubleClick += this.panel_0_DoubleClick;
		this.button_2.Location = new Point(6, 42);
		this.button_2.Name = "buttonFont";
		this.button_2.Size = new Size(110, 23);
		this.button_2.TabIndex = 1;
		this.button_2.Text = "Шрифт";
		this.button_2.UseVisualStyleBackColor = true;
		this.button_2.Click += this.button_2_Click;
		this.checkBox_0.AutoSize = true;
		this.checkBox_0.Location = new Point(6, 19);
		this.checkBox_0.Name = "checkBoxUseSettingsCanvas";
		this.checkBox_0.Size = new Size(110, 17);
		this.checkBox_0.TabIndex = 0;
		this.checkBox_0.Text = "Свойства схемы";
		this.checkBox_0.UseVisualStyleBackColor = true;
		this.checkBox_0.CheckedChanged += this.checkBox_0_CheckedChanged;
		this.numericUpDown_0.Location = new Point(133, 130);
		NumericUpDown numericUpDown = this.numericUpDown_0;
		int[] array = new int[4];
		array[0] = 6;
		numericUpDown.Maximum = new decimal(array);
		this.numericUpDown_0.Name = "numericUpDownDecimalPlaces";
		this.numericUpDown_0.Size = new Size(172, 20);
		this.numericUpDown_0.TabIndex = 6;
		this.label_4.AutoSize = true;
		this.label_4.Location = new Point(12, 132);
		this.label_4.Name = "label4";
		this.label_4.Size = new Size(115, 13);
		this.label_4.TabIndex = 7;
		this.label_4.Text = "Знаки после запятой";
		base.AcceptButton = this.button_1;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = this.button_0;
		base.ClientSize = new Size(318, 279);
		base.Controls.Add(this.label_4);
		base.Controls.Add(this.numericUpDown_0);
		base.Controls.Add(this.groupBox_0);
		base.Controls.Add(this.comboBox_0);
		base.Controls.Add(this.textBox_1);
		base.Controls.Add(this.textBox_0);
		base.Controls.Add(this.label_2);
		base.Controls.Add(this.label_1);
		base.Controls.Add(this.label_0);
		base.Controls.Add(this.button_1);
		base.Controls.Add(this.button_0);
		base.FormBorderStyle = FormBorderStyle.FixedDialog;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "FormTelemetryLabelPropertiy";
		this.Text = "Свойства отображения данных телеметрии";
		this.groupBox_0.ResumeLayout(false);
		this.groupBox_0.PerformLayout();
		((ISupportInitialize)this.numericUpDown_0).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private TelemetryLabelTool telemetryLabelTool_0;

	private DataTable dataTable_0;

	private Font font_0;

	private Color color_0;

	private bool bool_0;

	private IContainer icontainer_0;

	private Button button_0;

	private Button button_1;

	private TextBox textBox_0;

	private Label label_0;

	private Label label_1;

	private TextBox textBox_1;

	private ComboBox comboBox_0;

	private Label label_2;

	private GroupBox groupBox_0;

	private Label label_3;

	private Panel panel_0;

	private Button button_2;

	private CheckBox checkBox_0;

	private FontDialog fontDialog_0;

	private ColorDialog colorDialog_0;

	private NumericUpDown numericUpDown_0;

	private Label label_4;
}
