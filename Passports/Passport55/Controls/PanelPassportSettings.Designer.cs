using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DataSql;

namespace Passport.Controls
{
	public class PanelPassportSettings : Panel
	{
		public PanelPassportSettings()
		{
			this.InitializeComponent();
		}

		public PanelPassportSettings(SQLSettings SqlSettings)
		{
			this.InitializeComponent();
			this.sqlsettings_0 = SqlSettings;
			if (SqlSettings.Autentification == "WINDOWS")
			{
				this.sqlConnection_0 = new SqlConnection(string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", SqlSettings.ServerDB, SqlSettings.DBName));
			}
			else
			{
				this.sqlConnection_0 = new SqlConnection(string.Concat(new string[]
				{
					"Server=",
					SqlSettings.ServerDB,
					"; dataBase=",
					SqlSettings.DBName,
					"; uid=",
					SqlSettings.SqlUserConnect,
					";pwd=",
					SqlSettings.SqlPasswConnect,
					";Integrated Security=false; Connection TimeOut = 180"
				}));
			}
			this.method_0();
			this.float_0 = (float)(base.Height / this.chlbChar.Height);
			this.float_1 = (float)(base.Width / this.chlbChar.Width);
		}

		private void method_0()
		{
			if (this.sqlConnection_0.State != ConnectionState.Open)
			{
				this.sqlConnection_0.Open();
			}
			this.string_0 = "select ParentKey, Name from tP_CharList where ParentId = 1 and isGroup = 1 order by Name";
			this.sqlCommand_0 = new SqlCommand(this.string_0, this.sqlConnection_0);
			this.sqlDataAdapter_0 = new SqlDataAdapter(this.sqlCommand_0);
			this.dataTable_0 = new DataTable();
			this.sqlDataAdapter_0.Fill(this.dataTable_0);
			this.cbTypeEquipment.DataSource = this.dataTable_0;
			this.cbTypeEquipment.DisplayMember = "Name";
			this.cbTypeEquipment.ValueMember = "ParentKey";
			if (this.sqlConnection_0.State != ConnectionState.Closed)
			{
				this.sqlConnection_0.Close();
			}
			if (this.cbTypeEquipment.Items.Count > 0)
			{
				this.method_1(this.cbTypeEquipment.SelectedValue.ToString());
			}
		}

		private void method_1(string string_2)
		{
			if (this.sqlConnection_0.State != ConnectionState.Open)
			{
				this.sqlConnection_0.Open();
			}
			this.string_1 = "select id, Panel, Name from tP_CharList where ParentKey like '" + string_2 + "%' and isGroup = 0 order by TabIndex";
			this.sqlCommand_1 = new SqlCommand(this.string_1, this.sqlConnection_0);
			this.sqlDataAdapter_1 = new SqlDataAdapter(this.sqlCommand_1);
			this.dataTable_1 = new DataTable();
			this.sqlDataAdapter_1.Fill(this.dataTable_1);
			this.dataTable_1.PrimaryKey = new DataColumn[]
			{
				this.dataTable_1.Columns["id"]
			};
			this.chlbChar.DataSource = this.dataTable_1;
			if (this.sqlConnection_0.State != ConnectionState.Closed)
			{
				this.sqlConnection_0.Close();
			}
		}

		public void SaveSettings()
		{
			this.method_2(this.sqlConnection_0, this.sqlDataAdapter_1, this.dataTable_1);
			this.method_0();
		}

		private void method_2(SqlConnection sqlConnection_1, SqlDataAdapter sqlDataAdapter_2, DataTable dataTable_2)
		{
			if (sqlConnection_1.State != ConnectionState.Open)
			{
				sqlConnection_1.Open();
			}
			SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter_2);
			sqlDataAdapter_2.UpdateCommand = sqlCommandBuilder.GetUpdateCommand();
			sqlDataAdapter_2.Update(dataTable_2);
			if (sqlConnection_1.State != ConnectionState.Closed)
			{
				sqlConnection_1.Close();
			}
		}

		private void chlbChar_Leave(object sender, EventArgs e)
		{
			this.OnValidated(e);
		}

		private void PanelPassportSettings_Resize(object sender, EventArgs e)
		{
			this.chlbChar.Height = Convert.ToInt32((float)base.Height / this.float_1) - 75;
			this.chlbChar.Width = Convert.ToInt32((float)base.Width / this.float_0) - 17;
		}

		private void cbTypeEquipment_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_1(this.cbTypeEquipment.SelectedValue.ToString());
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			this.gbSettings = new GroupBox();
			this.chlbChar = new DataGridView();
			this.Panel = new DataGridViewCheckBoxColumn();
			this.lbTypeEquipment = new Label();
			this.cbTypeEquipment = new ComboBox();
			this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			this.idChar = new DataGridViewTextBoxColumn();
			this.NameChar = new DataGridViewTextBoxColumn();
			this.gbSettings.SuspendLayout();
			((ISupportInitialize)this.chlbChar).BeginInit();
			base.SuspendLayout();
			this.gbSettings.Controls.Add(this.chlbChar);
			this.gbSettings.Controls.Add(this.lbTypeEquipment);
			this.gbSettings.Controls.Add(this.cbTypeEquipment);
			this.gbSettings.Dock = DockStyle.Fill;
			this.gbSettings.Location = new Point(0, 0);
			this.gbSettings.Name = "gbSettings";
			this.gbSettings.Size = new Size(296, 401);
			this.gbSettings.TabIndex = 0;
			this.gbSettings.TabStop = false;
			this.gbSettings.Text = "Параметры отображаемые во всплывающей панели паспорта";
			this.chlbChar.AllowUserToAddRows = false;
			this.chlbChar.AllowUserToDeleteRows = false;
			this.chlbChar.AllowUserToOrderColumns = true;
			this.chlbChar.AllowUserToResizeColumns = false;
			this.chlbChar.AllowUserToResizeRows = false;
			this.chlbChar.BackgroundColor = Color.White;
			this.chlbChar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.chlbChar.ColumnHeadersVisible = false;
			this.chlbChar.Columns.AddRange(new DataGridViewColumn[]
			{
				this.idChar,
				this.Panel,
				this.NameChar
			});
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = Color.White;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = Color.Black;
			dataGridViewCellStyle.SelectionBackColor = Color.White;
			dataGridViewCellStyle.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.False;
			this.chlbChar.DefaultCellStyle = dataGridViewCellStyle;
			this.chlbChar.Location = new Point(6, 72);
			this.chlbChar.Name = "chlbChar";
			this.chlbChar.Size = new Size(276, 319);
			this.chlbChar.TabIndex = 0;
			this.chlbChar.Leave += this.chlbChar_Leave;
			this.Panel.DataPropertyName = "Panel";
			this.Panel.HeaderText = "Panel";
			this.Panel.Name = "Panel";
			this.Panel.Width = 40;
			this.lbTypeEquipment.AutoSize = true;
			this.lbTypeEquipment.Location = new Point(15, 42);
			this.lbTypeEquipment.Name = "lbTypeEquipment";
			this.lbTypeEquipment.Size = new Size(100, 13);
			this.lbTypeEquipment.TabIndex = 0;
			this.lbTypeEquipment.Text = "Тип оборудования";
			this.cbTypeEquipment.FormattingEnabled = true;
			this.cbTypeEquipment.Location = new Point(121, 39);
			this.cbTypeEquipment.Name = "cbTypeEquipment";
			this.cbTypeEquipment.Size = new Size(150, 21);
			this.cbTypeEquipment.TabIndex = 0;
			this.cbTypeEquipment.SelectedIndexChanged += this.cbTypeEquipment_SelectedIndexChanged;
			this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn1.HeaderText = "idChar";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Visible = false;
			this.dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.idChar.DataPropertyName = "id";
			this.idChar.HeaderText = "idChar";
			this.idChar.Name = "idChar";
			this.idChar.Visible = false;
			this.NameChar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.NameChar.DataPropertyName = "Name";
			this.NameChar.HeaderText = "Name";
			this.NameChar.Name = "NameChar";
			this.NameChar.ReadOnly = true;
			base.Controls.Add(this.gbSettings);
			this.Dock = DockStyle.Fill;
			base.Location = new Point(196, 3);
			base.Name = "panel1";
			base.Size = new Size(296, 401);
			base.TabIndex = 2;
			base.Resize += this.PanelPassportSettings_Resize;
			this.gbSettings.ResumeLayout(false);
			this.gbSettings.PerformLayout();
			((ISupportInitialize)this.chlbChar).EndInit();
			base.ResumeLayout(false);
		}

		private SQLSettings sqlsettings_0;

		private SqlConnection sqlConnection_0;

		private SqlCommand sqlCommand_0;

		private SqlDataAdapter sqlDataAdapter_0;

		private SqlCommand sqlCommand_1;

		private SqlDataAdapter sqlDataAdapter_1;

		private DataTable dataTable_0;

		private DataTable dataTable_1;

		private string string_0;

		private string string_1;

		private float float_0;

		private float float_1;

		private IContainer icontainer_0;

		private GroupBox gbSettings;

		private DataGridView chlbChar;

		private Label lbTypeEquipment;

		private ComboBox cbTypeEquipment;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

		private DataGridViewTextBoxColumn idChar;

		private DataGridViewCheckBoxColumn Panel;

		private DataGridViewTextBoxColumn NameChar;
	}
}
