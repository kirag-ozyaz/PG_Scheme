using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Windows.Forms;
using Constants;
using FormLbr;
using FormLbr.Classes;
using Scheme.Properties;

namespace Scheme.Forms.OPCMessage
{
	public class FormOPCMessageAddEdit : FormBase
	{
		public FormOPCMessageAddEdit(StateFormCreate stateForm, int id)
		{
			Class63.AGd1PxHzk5wxP();
			this.int_0 = -1;
			base..ctor();
			this.method_0();
			this.stateFormCreate_0 = stateForm;
			this.int_0 = id;
			if (stateForm == null)
			{
				this.Text = "Добавление";
				this.pictureBox_0.Image = this.pictureBox_0.ErrorImage;
				return;
			}
			if (stateForm != 1)
			{
				return;
			}
			this.Text = "Редактирование";
		}

		private void FormOPCMessageAddEdit_Load(object sender, EventArgs e)
		{
			StateFormCreate stateFormCreate = this.stateFormCreate_0;
			if (stateFormCreate == null)
			{
				this.Text = "Добавление";
				return;
			}
			if (stateFormCreate != 1)
			{
				return;
			}
			this.Text = "Редактирование";
			base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tOPC_MessageConfig"], true, "where id = " + this.int_0.ToString());
			if (this.dataSet_0.Tables["tOPC_MessageConfig"].Rows.Count > 0)
			{
				if (this.dataSet_0.Tables["tOPC_MessageConfig"].Rows[0]["Icon"] != DBNull.Value)
				{
					MemoryStream stream = new MemoryStream((byte[])this.dataSet_0.Tables["tOPC_MessageConfig"].Rows[0]["Icon"]);
					this.pictureBox_0.Image = Image.FromStream(stream);
				}
				else
				{
					this.pictureBox_0.Image = this.pictureBox_0.ErrorImage;
				}
				if (this.dataSet_0.Tables["tOPC_MessageConfig"].Rows[0]["Audio"] != DBNull.Value)
				{
					this.byte_0 = (byte[])this.dataSet_0.Tables["tOPC_MessageConfig"].Rows[0]["Audio"];
					this.toolStripButton_4.Enabled = true;
				}
			}
		}

		private void FormOPCMessageAddEdit_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (string.IsNullOrEmpty(this.textBox_1.Text) || string.IsNullOrEmpty(this.textBox_0.Text))
				{
					MessageBox.Show("Не введены ключи");
					e.Cancel = true;
				}
				StateFormCreate stateFormCreate = this.stateFormCreate_0;
				if (stateFormCreate == null)
				{
					DataRow dataRow = this.dataSet_0.Tables["tOPC_MessageConfig"].NewRow();
					dataRow["KeySource"] = this.textBox_0.Text;
					dataRow["KeyMessage"] = this.textBox_1.Text;
					if (this.pictureBox_0.Image != this.pictureBox_0.ErrorImage)
					{
						MemoryStream memoryStream = new MemoryStream();
						this.pictureBox_0.Image.Save(memoryStream, ImageFormat.Png);
						dataRow["Icon"] = memoryStream.ToArray();
					}
					else
					{
						dataRow["Icon"] = DBNull.Value;
					}
					if (this.byte_0 == null)
					{
						dataRow["Audio"] = DBNull.Value;
					}
					else
					{
						dataRow["Audio"] = this.byte_0;
					}
					this.dataSet_0.Tables["tOPC_MessageConfig"].Rows.Add(dataRow);
					this.dataSet_0.Tables["tOPC_MessageConfig"].Rows[0].EndEdit();
					base.InsertSqlDataOneRow(this.dataSet_0, this.dataSet_0.Tables["tOPC_MessageConfig"]);
					return;
				}
				if (stateFormCreate != 1)
				{
					return;
				}
				this.dataSet_0.Tables["tOPC_MessageConfig"].Rows[0]["KeySource"] = this.textBox_0.Text;
				this.dataSet_0.Tables["tOPC_MessageConfig"].Rows[0]["KeyMessage"] = this.textBox_1.Text;
				if (this.pictureBox_0.Image != this.pictureBox_0.ErrorImage)
				{
					MemoryStream memoryStream2 = new MemoryStream();
					this.pictureBox_0.Image.Save(memoryStream2, ImageFormat.Png);
					this.dataSet_0.Tables["tOPC_MessageConfig"].Rows[0]["Icon"] = memoryStream2.ToArray();
				}
				else
				{
					this.dataSet_0.Tables["tOPC_MessageConfig"].Rows[0]["Icon"] = DBNull.Value;
				}
				if (this.byte_0 == null)
				{
					this.dataSet_0.Tables["tOPC_MessageConfig"].Rows[0]["Audio"] = DBNull.Value;
				}
				else
				{
					this.dataSet_0.Tables["tOPC_MessageConfig"].Rows[0]["Audio"] = this.byte_0;
				}
				this.dataSet_0.Tables["tOPC_MessageConfig"].Rows[0].EndEdit();
				base.UpdateSqlData(this.dataSet_0, this.dataSet_0.Tables["tOPC_MessageConfig"]);
			}
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Multiselect = false;
				openFileDialog.Filter = "Image Files (*.bmp, *.jpg, *.jpeg, *.png, *.gif, *.ico)|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.ico";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.pictureBox_0.Image = Image.FromFile(openFileDialog.FileName);
					MemoryStream memoryStream = new MemoryStream();
					this.pictureBox_0.Image.Save(memoryStream, ImageFormat.Png);
					if (memoryStream.Length > 5000L)
					{
						long num = (long)(5000f / (float)memoryStream.Length * 100f);
						if (num < 1L)
						{
							num = 1L;
						}
						this.pictureBox_0.Image = ImageCompress.GetCompressImage(this.pictureBox_0.Image, num);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			this.pictureBox_0.Image = this.pictureBox_0.ErrorImage;
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Multiselect = false;
				openFileDialog.Filter = "Wav Files (*.wav)|*.wav";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.byte_0 = File.ReadAllBytes(openFileDialog.FileName);
					this.toolStripButton_4.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		private void toolStripButton_3_Click(object sender, EventArgs e)
		{
			this.byte_0 = null;
			this.toolStripButton_4.Enabled = false;
		}

		private void toolStripButton_4_Click(object sender, EventArgs e)
		{
			new SoundPlayer(new MemoryStream(this.byte_0, true)).Play();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			FormOPCMessageAddEdit.MG9d9Wc47xeq29XATyw(this, disposing);
		}

		private void method_0()
		{
			this.dataSet_0 = new DataSet();
			this.dataTable_0 = new DataTable();
			this.dataColumn_0 = new DataColumn();
			this.dataColumn_1 = new DataColumn();
			this.dataColumn_2 = new DataColumn();
			this.dataColumn_3 = new DataColumn();
			this.dataColumn_4 = new DataColumn();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.textBox_0 = new TextBox();
			this.textBox_1 = new TextBox();
			this.label_2 = new Label();
			this.pictureBox_0 = new PictureBox();
			this.label_3 = new Label();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStrip_1 = new ToolStrip();
			this.toolStripButton_2 = new ToolStripButton();
			this.toolStripButton_3 = new ToolStripButton();
			this.toolStripButton_4 = new ToolStripButton();
			((ISupportInitialize)this.dataSet_0).BeginInit();
			((ISupportInitialize)this.dataTable_0).BeginInit();
			((ISupportInitialize)this.pictureBox_0).BeginInit();
			this.toolStrip_0.SuspendLayout();
			this.toolStrip_1.SuspendLayout();
			base.SuspendLayout();
			this.dataSet_0.DataSetName = "NewDataSet";
			this.dataSet_0.Tables.AddRange(new DataTable[]
			{
				this.dataTable_0
			});
			this.dataTable_0.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_0,
				this.dataColumn_1,
				this.dataColumn_2,
				this.dataColumn_3,
				this.dataColumn_4
			});
			this.dataTable_0.Constraints.AddRange(new Constraint[]
			{
				new UniqueConstraint("Constraint1", new string[]
				{
					"Id"
				}, true)
			});
			this.dataTable_0.PrimaryKey = new DataColumn[]
			{
				this.dataColumn_0
			};
			this.dataTable_0.TableName = "tOPC_MessageConfig";
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.AutoIncrement = true;
			this.dataColumn_0.ColumnName = "Id";
			this.dataColumn_0.DataType = typeof(int);
			this.dataColumn_1.AllowDBNull = false;
			this.dataColumn_1.ColumnName = "KeySource";
			this.dataColumn_2.AllowDBNull = false;
			this.dataColumn_2.ColumnName = "KeyMessage";
			this.dataColumn_3.ColumnName = "Icon";
			this.dataColumn_3.DataType = typeof(byte[]);
			this.dataColumn_4.ColumnName = "Audio";
			this.dataColumn_4.DataType = typeof(byte[]);
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Location = new Point(15, 177);
			this.button_0.Name = "buttonOK";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 0;
			this.button_0.Text = "ОК";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Location = new Point(197, 177);
			this.button_1.Name = "buttonCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 1;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(12, 9);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(79, 13);
			this.label_0.TabIndex = 2;
			this.label_0.Text = "Ключ события";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(12, 51);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(93, 13);
			this.label_1.TabIndex = 3;
			this.label_1.Text = "Ключ сообщения";
			this.textBox_0.DataBindings.Add(new Binding("Text", this.dataSet_0, "tOPC_MessageConfig.KeySource", true));
			this.textBox_0.Location = new Point(111, 6);
			this.textBox_0.Name = "txtKeySource";
			this.textBox_0.Size = new Size(161, 20);
			this.textBox_0.TabIndex = 4;
			this.textBox_1.DataBindings.Add(new Binding("Text", this.dataSet_0, "tOPC_MessageConfig.KeyMessage", true));
			this.textBox_1.Location = new Point(111, 48);
			this.textBox_1.Name = "txtKeyMessage";
			this.textBox_1.Size = new Size(161, 20);
			this.textBox_1.TabIndex = 5;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(12, 96);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(45, 13);
			this.label_2.TabIndex = 6;
			this.label_2.Text = "Иконка";
			this.pictureBox_0.Location = new Point(111, 74);
			this.pictureBox_0.Name = "pictureBox";
			this.pictureBox_0.Size = new Size(56, 46);
			this.pictureBox_0.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox_0.TabIndex = 7;
			this.pictureBox_0.TabStop = false;
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(12, 139);
			this.label_3.Name = "label4";
			this.label_3.Size = new Size(37, 13);
			this.label_3.TabIndex = 8;
			this.label_3.Text = "Аудио";
			this.toolStrip_0.Dock = DockStyle.None;
			this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripButton_1
			});
			this.toolStrip_0.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
			this.toolStrip_0.Location = new Point(170, 74);
			this.toolStrip_0.Name = "toolStripIcon";
			this.toolStrip_0.Size = new Size(24, 48);
			this.toolStrip_0.TabIndex = 12;
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.smethod_19();
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "toolBtnOpenIcon";
			this.toolStripButton_0.Size = new Size(22, 20);
			this.toolStripButton_0.Text = "Загрузить иконку";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.smethod_20();
			this.toolStripButton_1.ImageTransparentColor = Color.Transparent;
			this.toolStripButton_1.Name = "toolBtnDelIcon";
			this.toolStripButton_1.Size = new Size(22, 20);
			this.toolStripButton_1.Text = "Удалить иконку";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.toolStrip_1.Dock = DockStyle.None;
			this.toolStrip_1.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_2,
				this.toolStripButton_3,
				this.toolStripButton_4
			});
			this.toolStrip_1.Location = new Point(111, 127);
			this.toolStrip_1.Name = "toolStrip1";
			this.toolStrip_1.Size = new Size(81, 25);
			this.toolStrip_1.TabIndex = 13;
			this.toolStrip_1.Text = "toolStrip1";
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = Resources.smethod_19();
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "toolBtnAddAudio";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "Добавить аудио";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = Resources.smethod_20();
			this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_3.Name = "toolBtnDelAudio";
			this.toolStripButton_3.Size = new Size(23, 22);
			this.toolStripButton_3.Text = "Удалить аудио";
			this.toolStripButton_3.Click += this.toolStripButton_3_Click;
			this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_4.Enabled = false;
			this.toolStripButton_4.Image = Resources.Play;
			this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_4.Name = "toolBtnPlayAudio";
			this.toolStripButton_4.Size = new Size(23, 22);
			this.toolStripButton_4.Text = "Воспроизвести";
			this.toolStripButton_4.Click += this.toolStripButton_4_Click;
			base.AcceptButton = this.button_0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_1;
			base.ClientSize = new Size(281, 216);
			base.Controls.Add(this.toolStrip_1);
			base.Controls.Add(this.label_3);
			base.Controls.Add(this.label_2);
			base.Controls.Add(this.pictureBox_0);
			base.Controls.Add(this.textBox_1);
			base.Controls.Add(this.textBox_0);
			base.Controls.Add(this.label_1);
			base.Controls.Add(this.label_0);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			base.Controls.Add(this.toolStrip_0);
			base.FormBorderStyle = FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormOPCMessageAddEdit";
			this.Text = "FormOPCMessageAddEdit";
			base.FormClosing += this.FormOPCMessageAddEdit_FormClosing;
			base.Load += this.FormOPCMessageAddEdit_Load;
			((ISupportInitialize)this.dataSet_0).EndInit();
			((ISupportInitialize)this.dataTable_0).EndInit();
			((ISupportInitialize)this.pictureBox_0).EndInit();
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.toolStrip_1.ResumeLayout(false);
			this.toolStrip_1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		internal static void MG9d9Wc47xeq29XATyw(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		private StateFormCreate stateFormCreate_0;

		private int int_0;

		private byte[] byte_0;

		private IContainer icontainer_0;

		private DataSet dataSet_0;

		private DataTable dataTable_0;

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		private Button button_0;

		private Button button_1;

		private Label label_0;

		private Label label_1;

		private TextBox textBox_0;

		private TextBox textBox_1;

		private Label label_2;

		private PictureBox pictureBox_0;

		private Label label_3;

		private ToolStrip toolStrip_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private ToolStrip toolStrip_1;

		private ToolStripButton toolStripButton_2;

		private ToolStripButton toolStripButton_3;

		private ToolStripButton toolStripButton_4;
	}
}
