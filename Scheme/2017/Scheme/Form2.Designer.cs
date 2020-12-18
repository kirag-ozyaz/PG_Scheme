using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using FormLbr;
using FormLbr.Classes;
using SchemeCtrl2.Ercloud;

internal class Form2 : FormBase
{
	internal Form2()
	{
		Class63.AGd1PxHzk5wxP();
		base..ctor();
		this.method_5();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		this.method_1();
	}

	private bool method_0(bool bool_0)
	{
		if (string.IsNullOrEmpty(this.textBox_4.Text))
		{
			MessageBox.Show("Не введено имя подключения");
			return false;
		}
		if (!char.IsLetter(this.textBox_4.Text[0]))
		{
			MessageBox.Show("В имени подключения первый символ должен быть буквой");
			return false;
		}
		if (string.IsNullOrEmpty(this.textBox_3.Text))
		{
			MessageBox.Show("Не введен адрес сервера");
			return false;
		}
		if (string.IsNullOrEmpty(this.textBox_2.Text))
		{
			MessageBox.Show("Не введен порт подключения");
			return false;
		}
		foreach (object obj in this.listBox_0.Items)
		{
			if ((bool_0 || obj != this.listBox_0.SelectedItem) && obj is ErcloudConnect && ((ErcloudConnect)obj).Name.ToUpper() == this.textBox_4.Text.ToUpper())
			{
				MessageBox.Show("Данное имя подключения уже есть в списке подключений");
				return false;
			}
		}
		return true;
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		if (!this.method_0(true))
		{
			return;
		}
		int num = 1;
		if (this.listBox_0.Items.Count > 0)
		{
			num = (from ErcloudConnect s in this.listBox_0.Items
			select s.Id).Max();
		}
		ErcloudConnect item = new ErcloudConnect(num + 1, this.textBox_4.Text, this.textBox_3.Text, Convert.ToInt32(this.textBox_2.Text), this.textBox_1.Text, this.textBox_0.Text);
		this.listBox_0.Items.Add(item);
		this.method_2();
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		if (this.listBox_0.SelectedItem != null)
		{
			if (!this.method_0(false))
			{
				return;
			}
			int index = this.listBox_0.Items.IndexOf(this.listBox_0.SelectedItem);
			ErcloudConnect value = new ErcloudConnect(((ErcloudConnect)this.listBox_0.SelectedItem).Id, this.textBox_4.Text, this.textBox_3.Text, Convert.ToInt32(this.textBox_2.Text), this.textBox_1.Text, this.textBox_0.Text);
			this.listBox_0.Items[index] = value;
			this.method_2();
		}
	}

	private void qTgKdykitv_Click(object sender, EventArgs e)
	{
		if (this.listBox_0.SelectedItem != null)
		{
			this.listBox_0.Items.RemoveAt(this.listBox_0.Items.IndexOf(this.listBox_0.SelectedItem));
			this.method_2();
		}
	}

	private void textBox_2_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void listBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.listBox_0.SelectedItem is ErcloudConnect)
		{
			ErcloudConnect ercloudConnect = (ErcloudConnect)this.listBox_0.SelectedItem;
			this.textBox_4.Text = ercloudConnect.Name;
			this.textBox_3.Text = ercloudConnect.AddressServer;
			this.textBox_2.Text = ercloudConnect.Port.ToString();
			this.textBox_1.Text = ercloudConnect.User;
			this.textBox_0.Text = ercloudConnect.Password;
		}
	}

	private void method_1()
	{
		base.SelectSqlData(this.dataTable_0, true, " where Module = 'Ercloud'", null, false, 0);
		if (this.dataTable_0.Rows.Count > 0 && this.dataTable_0.Rows[0]["Settings"] != DBNull.Value)
		{
			XmlDocument xmlDocument = new XmlDocument();
			try
			{
				xmlDocument.LoadXml(this.dataTable_0.Rows[0]["Settings"].ToString());
				this.method_4(xmlDocument);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}
	}

	private void method_2()
	{
		if (this.dataTable_0.Rows.Count == 0)
		{
			DataRow dataRow = this.dataTable_0.NewRow();
			dataRow["Module"] = "Ercloud";
			dataRow["Settings"] = this.method_3().InnerXml;
			this.dataTable_0.Rows.Add(dataRow);
			base.InsertSqlDataOneRow(dataRow);
		}
		else
		{
			this.dataTable_0.Rows[0]["Settings"] = this.method_3().InnerXml;
			this.dataTable_0.Rows[0].EndEdit();
			base.UpdateSqlData(this.dataTable_0);
		}
		this.method_1();
	}

	private XmlDocument method_3()
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode xmlNode = xmlDocument.CreateElement("Connections");
		xmlDocument.AppendChild(xmlNode);
		foreach (object obj in this.listBox_0.Items)
		{
			ErcloudConnect ercloudConnect = (ErcloudConnect)obj;
			XmlNode xmlNode2 = xmlDocument.CreateElement("ErcloudConnect");
			XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("Id");
			xmlAttribute.Value = ercloudConnect.Id.ToString();
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Name");
			xmlAttribute.Value = ercloudConnect.Name;
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Address");
			xmlAttribute.Value = ercloudConnect.AddressServer;
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Port");
			xmlAttribute.Value = ercloudConnect.Port.ToString();
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("User");
			xmlAttribute.Value = ercloudConnect.User;
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Password");
			xmlAttribute.Value = Crypt.Encrypt(ercloudConnect.Password, ercloudConnect.Name);
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlNode.AppendChild(xmlNode2);
		}
		return xmlDocument;
	}

	private void method_4(XmlDocument xmlDocument_0)
	{
		try
		{
			XmlNode xmlNode = xmlDocument_0.SelectSingleNode("Connections");
			this.listBox_0.Items.Clear();
			foreach (object obj in xmlNode.SelectNodes("ErcloudConnect"))
			{
				XmlNode xmlNode2 = (XmlNode)obj;
				try
				{
					int id = 1;
					if (xmlNode2.Attributes["Id"] != null)
					{
						id = Convert.ToInt32(xmlNode2.Attributes["Id"].Value);
					}
					else if (this.listBox_0.Items.Count > 0)
					{
						id = (from ErcloudConnect s in this.listBox_0.Items
						select s.Id).Max() + 1;
					}
					ErcloudConnect item = new ErcloudConnect(id, xmlNode2.Attributes["Name"].Value, xmlNode2.Attributes["Address"].Value, Convert.ToInt32(xmlNode2.Attributes["Port"].Value), xmlNode2.Attributes["User"].Value, Crypt.Decrypt(xmlNode2.Attributes["Password"].Value, xmlNode2.Attributes["Name"].Value));
					this.listBox_0.Items.Add(item);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source);
				}
			}
		}
		catch (Exception ex2)
		{
			MessageBox.Show(ex2.Message, ex2.Source);
		}
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Form2.flZjVUOU8RHQJl28RhN(this, bool_0);
	}

	private void method_5()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		this.BbeKmRyXmC = new SplitContainer();
		this.qTgKdykitv = new Button();
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.textBox_0 = new TextBox();
		this.textBox_1 = new TextBox();
		this.label_0 = new Label();
		this.label_1 = new Label();
		this.textBox_2 = new TextBox();
		this.textBox_3 = new TextBox();
		this.label_2 = new Label();
		this.label_3 = new Label();
		this.textBox_4 = new TextBox();
		this.label_4 = new Label();
		this.listBox_0 = new ListBox();
		this.label_5 = new Label();
		this.dataSet_0 = new DataSet();
		this.dataTable_0 = new DataTable();
		this.dataColumn_0 = new DataColumn();
		this.dataColumn_1 = new DataColumn();
		this.dataColumn_2 = new DataColumn();
		this.BbeKmRyXmC.Panel1.SuspendLayout();
		this.BbeKmRyXmC.Panel2.SuspendLayout();
		this.BbeKmRyXmC.SuspendLayout();
		((ISupportInitialize)this.dataSet_0).BeginInit();
		((ISupportInitialize)this.dataTable_0).BeginInit();
		base.SuspendLayout();
		this.BbeKmRyXmC.Dock = DockStyle.Fill;
		this.BbeKmRyXmC.Location = new Point(0, 0);
		this.BbeKmRyXmC.Name = "splitContainer1";
		this.BbeKmRyXmC.Panel1.Controls.Add(this.qTgKdykitv);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.button_0);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.button_1);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.textBox_0);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.textBox_1);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.label_0);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.label_1);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.textBox_2);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.textBox_3);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.label_2);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.label_3);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.textBox_4);
		this.BbeKmRyXmC.Panel1.Controls.Add(this.label_4);
		this.BbeKmRyXmC.Panel2.Controls.Add(this.listBox_0);
		this.BbeKmRyXmC.Panel2.Controls.Add(this.label_5);
		this.BbeKmRyXmC.Size = new Size(848, 411);
		this.BbeKmRyXmC.SplitterDistance = 450;
		this.BbeKmRyXmC.TabIndex = 0;
		this.qTgKdykitv.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.qTgKdykitv.Location = new Point(372, 140);
		this.qTgKdykitv.Name = "buttonRemove";
		this.qTgKdykitv.Size = new Size(75, 23);
		this.qTgKdykitv.TabIndex = 12;
		this.qTgKdykitv.Text = "Удалить";
		this.qTgKdykitv.UseVisualStyleBackColor = true;
		this.qTgKdykitv.Click += this.qTgKdykitv_Click;
		this.button_0.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.button_0.Location = new Point(192, 140);
		this.button_0.Name = "buttonAdd";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 11;
		this.button_0.Text = "Добавить";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_0.Click += this.button_0_Click;
		this.button_1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.button_1.Location = new Point(273, 140);
		this.button_1.Name = "buttonEdit";
		this.button_1.Size = new Size(93, 23);
		this.button_1.TabIndex = 10;
		this.button_1.Text = "Редактировать";
		this.button_1.UseVisualStyleBackColor = true;
		this.button_1.Click += this.button_1_Click;
		this.textBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.textBox_0.Location = new Point(215, 103);
		this.textBox_0.Name = "txtPassword";
		this.textBox_0.PasswordChar = '*';
		this.textBox_0.Size = new Size(232, 20);
		this.textBox_0.TabIndex = 9;
		this.textBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.textBox_1.Location = new Point(11, 103);
		this.textBox_1.Name = "txtLogin";
		this.textBox_1.Size = new Size(196, 20);
		this.textBox_1.TabIndex = 8;
		this.label_0.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(212, 87);
		this.label_0.Name = "label6";
		this.label_0.Size = new Size(45, 13);
		this.label_0.TabIndex = 7;
		this.label_0.Text = "Пароль";
		this.label_1.AutoSize = true;
		this.label_1.Location = new Point(12, 87);
		this.label_1.Name = "label5";
		this.label_1.Size = new Size(38, 13);
		this.label_1.TabIndex = 6;
		this.label_1.Text = "Логин";
		this.textBox_2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.textBox_2.Location = new Point(319, 64);
		this.textBox_2.Name = "txtPort";
		this.textBox_2.Size = new Size(128, 20);
		this.textBox_2.TabIndex = 5;
		this.textBox_2.Text = "8082";
		this.textBox_2.KeyPress += this.textBox_2_KeyPress;
		this.textBox_3.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.textBox_3.Location = new Point(11, 64);
		this.textBox_3.Name = "txtAddress";
		this.textBox_3.Size = new Size(304, 20);
		this.textBox_3.TabIndex = 4;
		this.textBox_3.Text = "95.182.111.130";
		this.label_2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.label_2.AutoSize = true;
		this.label_2.Location = new Point(316, 48);
		this.label_2.Name = "label4";
		this.label_2.Size = new Size(32, 13);
		this.label_2.TabIndex = 3;
		this.label_2.Text = "Порт";
		this.label_3.AutoSize = true;
		this.label_3.Location = new Point(12, 48);
		this.label_3.Name = "label3";
		this.label_3.Size = new Size(83, 13);
		this.label_3.TabIndex = 2;
		this.label_3.Text = "Адрес сервера";
		this.textBox_4.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.textBox_4.Location = new Point(11, 25);
		this.textBox_4.Name = "txtNameConnect";
		this.textBox_4.Size = new Size(436, 20);
		this.textBox_4.TabIndex = 1;
		this.textBox_4.Text = "Ercloud";
		this.label_4.AutoSize = true;
		this.label_4.Location = new Point(12, 9);
		this.label_4.Name = "label2";
		this.label_4.Size = new Size(99, 13);
		this.label_4.TabIndex = 0;
		this.label_4.Text = "Имя подключения";
		this.listBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.listBox_0.FormattingEnabled = true;
		this.listBox_0.Location = new Point(3, 25);
		this.listBox_0.Name = "listBoxConnect";
		this.listBox_0.Size = new Size(391, 381);
		this.listBox_0.TabIndex = 1;
		this.listBox_0.SelectedIndexChanged += this.listBox_0_SelectedIndexChanged;
		this.label_5.AutoSize = true;
		this.label_5.Location = new Point(3, 9);
		this.label_5.Name = "label1";
		this.label_5.Size = new Size(95, 13);
		this.label_5.TabIndex = 0;
		this.label_5.Text = "Список серверов";
		this.dataSet_0.DataSetName = "NewDataSet";
		this.dataSet_0.Tables.AddRange(new DataTable[]
		{
			this.dataTable_0
		});
		this.dataTable_0.Columns.AddRange(new DataColumn[]
		{
			this.dataColumn_0,
			this.dataColumn_1,
			this.dataColumn_2
		});
		this.dataTable_0.Constraints.AddRange(new Constraint[]
		{
			new UniqueConstraint("Constraint1", new string[]
			{
				"id"
			}, true)
		});
		this.dataTable_0.PrimaryKey = new DataColumn[]
		{
			this.dataColumn_0
		};
		this.dataTable_0.TableName = "tSettings";
		this.dataColumn_0.AllowDBNull = false;
		this.dataColumn_0.AutoIncrement = true;
		this.dataColumn_0.ColumnName = "id";
		this.dataColumn_0.DataType = typeof(int);
		this.dataColumn_1.ColumnName = "settings";
		this.dataColumn_2.ColumnName = "module";
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(848, 411);
		base.Controls.Add(this.BbeKmRyXmC);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "FormErcloudSettings";
		this.Text = "Настройки подключения к Ercloud";
		base.TopMost = true;
		base.Load += this.Form2_Load;
		this.BbeKmRyXmC.Panel1.ResumeLayout(false);
		this.BbeKmRyXmC.Panel1.PerformLayout();
		this.BbeKmRyXmC.Panel2.ResumeLayout(false);
		this.BbeKmRyXmC.Panel2.PerformLayout();
		this.BbeKmRyXmC.ResumeLayout(false);
		((ISupportInitialize)this.dataSet_0).EndInit();
		((ISupportInitialize)this.dataTable_0).EndInit();
		base.ResumeLayout(false);
	}

	internal static void flZjVUOU8RHQJl28RhN(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private IContainer icontainer_0;

	private SplitContainer BbeKmRyXmC;

	private Button button_0;

	private Button button_1;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private Label label_0;

	private Label label_1;

	private TextBox textBox_2;

	private TextBox textBox_3;

	private Label label_2;

	private Label label_3;

	private TextBox textBox_4;

	private Label label_4;

	private ListBox listBox_0;

	private Label label_5;

	private Button qTgKdykitv;

	private DataSet dataSet_0;

	private DataTable dataTable_0;

	private DataColumn dataColumn_0;

	private DataColumn dataColumn_1;

	private DataColumn dataColumn_2;
}
