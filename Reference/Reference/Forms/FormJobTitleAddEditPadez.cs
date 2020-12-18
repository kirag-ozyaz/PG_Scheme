using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using FormLbr;

namespace Reference.Forms
{
	public partial class FormJobTitleAddEditPadez : FormBase
	{
		public FormJobTitleAddEditPadez()
		{
			
			this.int_0 = -1;
			
			this.InitializeComponent();
		}

		public FormJobTitleAddEditPadez(int idJobTitle)
		{
			
			this.int_0 = -1;
			
			this.InitializeComponent();
			this.int_0 = idJobTitle;
		}

		private void FormJobTitleAddEditPadez_Load(object sender, EventArgs e)
		{
			if (this.int_0 != -1)
			{
				base.SelectSqlData(this.class48_0.tR_JobTitle, true, "where id = " + this.int_0.ToString(), null, false, 0);
				if (this.class48_0.tR_JobTitle.Rows.Count <= 0)
				{
					this.buttonOK.Enabled = false;
					return;
				}
				DataRow dataRow = this.class48_0.tR_JobTitle.Rows[0];
				if (dataRow["Description"] != DBNull.Value)
				{
					this.i_FTextBox.Text = dataRow["Description"].ToString();
				}
				if (dataRow["Padez"] != DBNull.Value)
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml((string)dataRow["Padez"]);
					XmlNode xmlNode = xmlDocument.SelectSingleNode("JobTitle");
					if (xmlNode != null)
					{
						XmlNode xmlNode2 = xmlNode.SelectSingleNode("genitive");
						if (xmlNode2 != null)
						{
							XmlAttribute xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("Description");
							if (xmlAttribute != null)
							{
								this.r_FTextBox.Text = xmlAttribute.Value;
							}
						}
						xmlNode2 = xmlNode.SelectSingleNode("dative");
						if (xmlNode2 != null)
						{
							XmlAttribute xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("Description");
							if (xmlAttribute != null)
							{
								this.d_FTextBox.Text = xmlAttribute.Value;
							}
						}
						xmlNode2 = xmlNode.SelectSingleNode("ablative");
						if (xmlNode2 != null)
						{
							XmlAttribute xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("Description");
							if (xmlAttribute != null)
							{
								this.t_FTextBox.Text = xmlAttribute.Value;
								return;
							}
						}
					}
				}
			}
			else
			{
				this.buttonOK.Enabled = false;
			}
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			this.r_FTextBox.Text = this.i_FTextBox.Text;
			this.d_FTextBox.Text = this.i_FTextBox.Text;
			this.t_FTextBox.Text = this.i_FTextBox.Text;
		}

		private void FormJobTitleAddEditPadez_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK && this.class48_0.tR_JobTitle.Rows.Count > 0)
			{
				XmlDocument xmlDocument = new XmlDocument();
				XmlNode xmlNode = xmlDocument.CreateElement("JobTitle");
				xmlDocument.AppendChild(xmlNode);
				XmlNode xmlNode2 = xmlDocument.CreateElement("genitive");
				xmlNode.AppendChild(xmlNode2);
				XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("Description");
				xmlAttribute.Value = this.r_FTextBox.Text;
				xmlNode2.Attributes.Append(xmlAttribute);
				XmlNode xmlNode3 = xmlDocument.CreateElement("dative");
				xmlNode.AppendChild(xmlNode3);
				xmlAttribute = xmlDocument.CreateAttribute("Description");
				xmlAttribute.Value = this.d_FTextBox.Text;
				xmlNode3.Attributes.Append(xmlAttribute);
				XmlNode xmlNode4 = xmlDocument.CreateElement("ablative");
				xmlNode.AppendChild(xmlNode4);
				xmlAttribute = xmlDocument.CreateAttribute("Description");
				xmlAttribute.Value = this.t_FTextBox.Text;
				xmlNode4.Attributes.Append(xmlAttribute);
				this.class48_0.tR_JobTitle.Rows[0]["Padez"] = xmlDocument.InnerXml;
				this.class48_0.tR_JobTitle.Rows[0].EndEdit();
				base.UpdateSqlData(this.class48_0.tR_JobTitle);
			}
		}

		private int int_0;
	}
}
