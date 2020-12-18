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

internal partial class FormErcloudSettings : FormBase
{
	internal FormErcloudSettings()
	{
		Class68.AGd1PxHzk5wxP();
		base..ctor();
		this.InitializeComponent();
	}

	private void FormErcloudSettings_Load(object sender, EventArgs e)
	{
		this.method_1();
	}

	private bool method_0(bool bool_0)
	{
		if (string.IsNullOrEmpty(this.txtNameConnect.Text))
		{
			MessageBox.Show("Не введено имя подключения");
			return false;
		}
		if (!char.IsLetter(this.txtNameConnect.Text[0]))
		{
			MessageBox.Show("В имени подключения первый символ должен быть буквой");
			return false;
		}
		if (string.IsNullOrEmpty(this.txtAddress.Text))
		{
			MessageBox.Show("Не введен адрес сервера");
			return false;
		}
		if (string.IsNullOrEmpty(this.txtPort.Text))
		{
			MessageBox.Show("Не введен порт подключения");
			return false;
		}
		foreach (object obj in this.listBoxConnect.Items)
		{
			if ((bool_0 || obj != this.listBoxConnect.SelectedItem) && obj is ErcloudConnect && ((ErcloudConnect)obj).Name.ToUpper() == this.txtNameConnect.Text.ToUpper())
			{
				MessageBox.Show("Данное имя подключения уже есть в списке подключений");
				return false;
			}
		}
		return true;
	}

	private void buttonAdd_Click(object sender, EventArgs e)
	{
		if (!this.method_0(true))
		{
			return;
		}
		int num = 1;
		if (this.listBoxConnect.Items.Count > 0)
		{
			num = (from ErcloudConnect s in this.listBoxConnect.Items
			select s.Id).Max();
		}
		ErcloudConnect item = new ErcloudConnect(num + 1, this.txtNameConnect.Text, this.txtAddress.Text, Convert.ToInt32(this.txtPort.Text), this.txtLogin.Text, this.txtPassword.Text);
		this.listBoxConnect.Items.Add(item);
		this.method_2();
	}

	private void buttonEdit_Click(object sender, EventArgs e)
	{
		if (this.listBoxConnect.SelectedItem != null)
		{
			if (!this.method_0(false))
			{
				return;
			}
			int index = this.listBoxConnect.Items.IndexOf(this.listBoxConnect.SelectedItem);
			ErcloudConnect value = new ErcloudConnect(((ErcloudConnect)this.listBoxConnect.SelectedItem).Id, this.txtNameConnect.Text, this.txtAddress.Text, Convert.ToInt32(this.txtPort.Text), this.txtLogin.Text, this.txtPassword.Text);
			this.listBoxConnect.Items[index] = value;
			this.method_2();
		}
	}

	private void qTgKdykitv_Click(object sender, EventArgs e)
	{
		if (this.listBoxConnect.SelectedItem != null)
		{
			this.listBoxConnect.Items.RemoveAt(this.listBoxConnect.Items.IndexOf(this.listBoxConnect.SelectedItem));
			this.method_2();
		}
	}

	private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void listBoxConnect_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.listBoxConnect.SelectedItem is ErcloudConnect)
		{
			ErcloudConnect ercloudConnect = (ErcloudConnect)this.listBoxConnect.SelectedItem;
			this.txtNameConnect.Text = ercloudConnect.Name;
			this.txtAddress.Text = ercloudConnect.AddressServer;
			this.txtPort.Text = ercloudConnect.Port.ToString();
			this.txtLogin.Text = ercloudConnect.User;
			this.txtPassword.Text = ercloudConnect.Password;
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
		foreach (object obj in this.listBoxConnect.Items)
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
			this.listBoxConnect.Items.Clear();
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
					else if (this.listBoxConnect.Items.Count > 0)
					{
						id = (from ErcloudConnect s in this.listBoxConnect.Items
						select s.Id).Max() + 1;
					}
					ErcloudConnect item = new ErcloudConnect(id, xmlNode2.Attributes["Name"].Value, xmlNode2.Attributes["Address"].Value, Convert.ToInt32(xmlNode2.Attributes["Port"].Value), xmlNode2.Attributes["User"].Value, Crypt.Decrypt(xmlNode2.Attributes["Password"].Value, xmlNode2.Attributes["Name"].Value));
					this.listBoxConnect.Items.Add(item);
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
}
