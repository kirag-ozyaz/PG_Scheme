using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using ControlsLbr;
using FormLbr;
/// <summary>
/// Настройки отправки почты (смс);
/// </summary>
internal partial class FormDamageSettingMail : FormBase
{
	internal FormDamageSettingMail()
	{
		//
		
		this.InitializeComponent();
	}

	private void chkSendMail_CheckedChanged(object sender, EventArgs e)
	{
		this.groupBoxSender.Enabled = (this.groupBoxSMTP.Enabled = (this.dgvTree.Enabled = this.chkSendMail.Checked));
	}

	private void FormDamageSettingMail_Load(object sender, EventArgs e)
	{
		base.SelectSqlData(this.tSettings, true, string.Format("where module = '{0}'", "DamageMail"), null, false, 0);
		if (this.tSettings.Rows.Count > 0)
		{
			this.LoadXmlSettingsMail();
		}
	}

	private void LoadXmlSettingsMail()
	{
		if (this.tSettings.Rows.Count > 0 && this.tSettings.Rows[0]["Settings"] != DBNull.Value)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(this.tSettings.Rows[0]["Settings"].ToString());
			XmlNode xmlNode = xmlDocument.SelectSingleNode("DamageMail");
			if (xmlNode != null)
			{
				XmlAttribute xmlAttribute = xmlNode.Attributes["useMail"];
				if (xmlAttribute != null)
				{
					this.chkSendMail.Checked = Convert.ToBoolean(xmlAttribute.Value);
				}
				XmlNode xmlNode2 = xmlNode.SelectSingleNode("SMTP");
				if (xmlNode2 != null)
				{
					xmlAttribute = xmlNode2.Attributes["Name"];
					if (xmlAttribute != null)
					{
						this.txtSMTPServerPlanned.Text = xmlAttribute.Value;
					}
					xmlAttribute = xmlNode2.Attributes["Port"];
					if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.Value))
					{
						this.txtSMTPServerPortPlanned.Value = Convert.ToInt32(xmlAttribute.Value);
					}
					xmlAttribute = xmlNode2.Attributes["Login"];
					if (xmlAttribute != null)
					{
						this.txtLoginSMTPPlanned.Text = xmlAttribute.Value;
					}
					xmlAttribute = xmlNode2.Attributes["Pwd"];
					if (xmlAttribute != null)
					{
						this.txtPwdSMTPPlanned.Text = xmlAttribute.Value;
					}
				}
				XmlNode xmlNode3 = xmlNode.SelectSingleNode("Sender");
				if (xmlNode3 != null)
				{
					xmlAttribute = xmlNode3.Attributes["Address"];
					if (xmlAttribute != null)
					{
						this.txtSenderAddressPlanned.Text = xmlAttribute.Value;
					}
					xmlAttribute = xmlNode3.Attributes["Name"];
					if (xmlAttribute != null)
					{
						this.txtSenderNamePlanned.Text = xmlAttribute.Value;
					}
				}
			}
			DataTable dtContact = _MailRequest.CreateTableContact(xmlDocument, this.SqlSettings);
			this.AddDataGridContact(dtContact);
		}
	}

	private XmlDocument ChangeXmlSettingsMail()
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode xmlNode = xmlDocument.CreateElement("DamageMail");
		xmlDocument.AppendChild(xmlNode);

        XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("useMail");
		xmlAttribute.Value = this.chkSendMail.Checked.ToString();
		xmlNode.Attributes.Append(xmlAttribute);

        XmlNode xmlNode2 = xmlDocument.CreateElement("SMTP");
		xmlNode.AppendChild(xmlNode2);
		xmlAttribute = xmlDocument.CreateAttribute("Name");
		xmlAttribute.Value = this.txtSMTPServerPlanned.Text;
		xmlNode2.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("Port");
		xmlAttribute.Value = this.txtSMTPServerPortPlanned.Value.ToString();
		xmlNode2.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("Login");
		xmlAttribute.Value = this.txtLoginSMTPPlanned.Text;
		xmlNode2.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("Pwd");
		xmlAttribute.Value = this.txtPwdSMTPPlanned.Text;
		xmlNode2.Attributes.Append(xmlAttribute);

        XmlNode xmlNode3 = xmlDocument.CreateElement("Sender");
		xmlNode.AppendChild(xmlNode3);
		xmlAttribute = xmlDocument.CreateAttribute("Address");
		xmlAttribute.Value = this.txtSenderAddressPlanned.Text;
		xmlNode3.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("Name");
		xmlAttribute.Value = this.txtSenderNamePlanned.Text;
		xmlNode3.Attributes.Append(xmlAttribute);
		XmlNode xmlNode4 = xmlDocument.CreateElement("Recipients");
		xmlNode.AppendChild(xmlNode4);
		foreach (TreeDataGridViewNode treeDataGridViewNode in this.dgvTree.Nodes)
		{
			XmlNode xmlNode5 = xmlDocument.CreateElement("TagName");
			xmlNode4.AppendChild(xmlNode5);
			xmlAttribute = xmlDocument.CreateAttribute("TagName");
			xmlAttribute.Value = treeDataGridViewNode.Cells[0].Value.ToString();
			xmlNode5.Attributes.Append(xmlAttribute);
			foreach (TreeDataGridViewNode treeDataGridViewNode2 in treeDataGridViewNode.Nodes)
			{
				XmlNode xmlNode6 = xmlDocument.CreateElement("Division");
				xmlNode5.AppendChild(xmlNode6);
				xmlAttribute = xmlDocument.CreateAttribute("DivName");
				xmlAttribute.Value = treeDataGridViewNode2.Cells[0].Value.ToString();
				xmlNode6.Attributes.Append(xmlAttribute);
				xmlAttribute = xmlDocument.CreateAttribute("DivId");
				xmlAttribute.Value = treeDataGridViewNode2.Cells[1].Value.ToString();
				xmlNode6.Attributes.Append(xmlAttribute);
				foreach (TreeDataGridViewNode treeDataGridViewNode3 in treeDataGridViewNode2.Nodes)
				{
					XmlNode xmlNode7 = xmlDocument.CreateElement("Contact");
					xmlNode6.AppendChild(xmlNode7);
					xmlAttribute = xmlDocument.CreateAttribute("FIO");
					xmlAttribute.Value = treeDataGridViewNode3.Cells[2].Value.ToString();
					xmlNode7.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute("IdWorker");
					xmlAttribute.Value = treeDataGridViewNode3.Cells[3].Value.ToString();
					xmlNode7.Attributes.Append(xmlAttribute);
					xmlAttribute = xmlDocument.CreateAttribute("Contact");
					xmlAttribute.Value = treeDataGridViewNode3.Cells[4].Value.ToString();
					xmlNode7.Attributes.Append(xmlAttribute);
				}
			}
		}
		return xmlDocument;
	}

	private void buttonSave_Click(object sender, EventArgs e)
	{
		if (this.tSettings.Rows.Count == 0)
		{
			DataRow row = this.tSettings.NewRow();
			this.tSettings.Rows.Add(row);
		}
		this.tSettings.Rows[0]["Settings"] = this.ChangeXmlSettingsMail().InnerXml;
		this.tSettings.Rows[0]["Module"] = "DamageMail";
		this.tSettings.Rows[0].EndEdit();
		if (!base.InsertSqlData(this.tSettings))
		{
			return;
		}
		if (!base.UpdateSqlData(this.tSettings))
		{
			return;
		}
		base.Close();
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private void toolMenuItemTagAdd_Click(object sender, EventArgs e)
	{
		FormTagContactAddEdit form = new FormTagContactAddEdit((FormTagContactAddEdit.eActionRequest)0, (FormTagContactAddEdit.eSelectTypeFieldContact)0, null);
		form.SqlSettings = this.SqlSettings;
		if (form.ShowDialog() == DialogResult.OK)
		{
			this.dgvTree.Nodes.Add(form.TagName);
		}
	}

	private void toolMenuItemDivisionAdd_Click(object sender, EventArgs e)
	{
		if (this.dgvTree.CurrentRow == null)
		{
			MessageBox.Show("Невозможно добавить подразделение. Сначала добавьте тэг.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		TreeDataGridViewNode nodeForRow = this.dgvTree.GetNodeForRow(this.dgvTree.CurrentRow);
		FormTagContactAddEdit form = new FormTagContactAddEdit((FormTagContactAddEdit.eActionRequest)0, (FormTagContactAddEdit.eSelectTypeFieldContact)1, nodeForRow);
		form.SqlSettings = this.SqlSettings;
		if (form.ShowDialog() == DialogResult.OK)
		{
			switch (nodeForRow.Level)
			{
			case 1:
				nodeForRow.Nodes.Add(new object[]
				{
					form.method_0(),
					form.method_1()
				});
				return;
			case 2:
				nodeForRow.Parent.Nodes.Add(new object[]
				{
					form.method_0(),
					form.method_1()
				});
				return;
			case 3:
				nodeForRow.Parent.Parent.Nodes.Add(new object[]
				{
					form.method_0(),
					form.method_1()
				});
				break;
			default:
				return;
			}
		}
	}

	private void toolMenuItemContactAdd_Click(object sender, EventArgs e)
	{
		if (this.dgvTree.CurrentRow == null)
		{
			MessageBox.Show("Невозможно добавить контакт. Сначала добавьте тэг и подразделение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		TreeDataGridViewNode nodeForRow = this.dgvTree.GetNodeForRow(this.dgvTree.CurrentRow);
		if (nodeForRow.Level == 1)
		{
			MessageBox.Show("Невозможно добавить контакт. Выберите подразделение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		FormTagContactAddEdit form = new FormTagContactAddEdit((FormTagContactAddEdit.eActionRequest)0, (FormTagContactAddEdit.eSelectTypeFieldContact)2, nodeForRow);
		form.SqlSettings = this.SqlSettings;
		if (form.ShowDialog() == DialogResult.OK)
		{
			int level = nodeForRow.Level;
			if (level == 2)
			{
				nodeForRow.Nodes.Add(new object[]
				{
					"",
					"",
					form.method_2(),
					form.method_3(),
					form.Contact
				});
				return;
			}
			if (level != 3)
			{
				return;
			}
			nodeForRow.Parent.Nodes.Add(new object[]
			{
				"",
				"",
				form.method_2(),
				form.method_3(),
				form.Contact
			});
		}
	}

	private void toolBtnEdit_Click(object sender, EventArgs e)
	{
		if (this.dgvTree.CurrentRow == null)
		{
			MessageBox.Show("Выберите строку для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return;
		}
		TreeDataGridViewNode nodeForRow = this.dgvTree.GetNodeForRow(this.dgvTree.CurrentRow);
		FormTagContactAddEdit.eSelectTypeFieldContact enum22_ = (FormTagContactAddEdit.eSelectTypeFieldContact)0;
		switch (nodeForRow.Level)
		{
		case 1:
			enum22_ = (FormTagContactAddEdit.eSelectTypeFieldContact)0;
			break;
		case 2:
			enum22_ = (FormTagContactAddEdit.eSelectTypeFieldContact)1;
			break;
		case 3:
			enum22_ = (FormTagContactAddEdit.eSelectTypeFieldContact)2;
			break;
		}
		FormTagContactAddEdit form = new FormTagContactAddEdit((FormTagContactAddEdit.eActionRequest)1, enum22_, nodeForRow);
		form.SqlSettings = this.SqlSettings;
		if (form.ShowDialog() == DialogResult.OK)
		{
			switch (nodeForRow.Level)
			{
			case 1:
				nodeForRow.Cells[0].Value = form.TagName;
				return;
			case 2:
				nodeForRow.Cells[0].Value = form.method_0();
				nodeForRow.Cells[1].Value = form.method_1();
				return;
			case 3:
				nodeForRow.Cells[2].Value = form.method_2();
				nodeForRow.Cells[3].Value = form.method_3();
				nodeForRow.Cells[4].Value = form.Contact;
				break;
			default:
				return;
			}
		}
	}

	private void toolBtnDel_Click(object sender, EventArgs e)
	{
		if (this.dgvTree.CurrentRow != null)
		{
			TreeDataGridViewNode nodeForRow = this.dgvTree.GetNodeForRow(this.dgvTree.CurrentRow);
			if (nodeForRow.Parent == null)
			{
				this.dgvTree.Nodes.Remove(nodeForRow);
				return;
			}
			nodeForRow.Parent.Nodes.Remove(nodeForRow);
		}
	}

	private void AddDataGridContact(DataTable dtContact)
	{
		this.dgvTree.Nodes.Clear();
		string text = "";
		int? num = null;
		TreeDataGridViewNode treeDataGridViewNode = null;
		TreeDataGridViewNode treeDataGridViewNode2 = null;
		foreach (DataRow dataRow in dtContact.Rows)
		{
			if (dataRow["Tag"].ToString() != text)
			{
				text = dataRow["Tag"].ToString();
				treeDataGridViewNode = this.dgvTree.Nodes.Add(text);
				num = null;
				treeDataGridViewNode2 = null;
			}
			if (dataRow["DivId"] != DBNull.Value && Convert.ToInt32(dataRow["divId"]) != num && treeDataGridViewNode != null)
			{
				num = new int?(Convert.ToInt32(Convert.ToInt32(dataRow["divId"])));
				treeDataGridViewNode2 = treeDataGridViewNode.Nodes.Add(new object[]
				{
					dataRow["DivName"].ToString(),
					num
				});
			}
			if (dataRow["idWorker"] != DBNull.Value && treeDataGridViewNode2 != null)
			{
				treeDataGridViewNode2.Nodes.Add(new object[]
				{
					"",
					"",
					dataRow["FIO"].ToString(),
					Convert.ToInt32(dataRow["idWorker"]),
					dataRow["Contact"].ToString()
				});
			}
		}
	}

	
}
