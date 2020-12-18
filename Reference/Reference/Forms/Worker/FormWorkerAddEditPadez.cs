using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using FormLbr;

namespace Reference.Forms.Worker
{
	public partial class FormWorkerAddEditPadez : FormBase
	{
		public FormWorkerAddEditPadez()
		{
			
			this.int_0 = -1;
			
			this.InitializeComponent();
		}

		public FormWorkerAddEditPadez(int idWorker)
		{
			
			this.int_0 = -1;
			
			this.InitializeComponent();
			this.int_0 = idWorker;
		}

		private void FormWorkerAddEditPadez_Load(object sender, EventArgs e)
		{
			if (this.int_0 != -1)
			{
				base.SelectSqlData(this.class48_0.tR_Worker, true, "where id = " + this.int_0.ToString(), null, false, 0);
				if (this.class48_0.tR_Worker.Rows.Count <= 0)
				{
					this.buttonOK.Enabled = false;
					return;
				}
				DataRow dataRow = this.class48_0.tR_Worker.Rows[0];
				if (dataRow["F"] != DBNull.Value)
				{
					this.i_FTextBox.Text = dataRow["F"].ToString();
				}
				if (dataRow["I"] != DBNull.Value)
				{
					this.i_ITextBox.Text = dataRow["I"].ToString();
				}
				if (dataRow["O"] != DBNull.Value)
				{
					this.i_OTextBox.Text = dataRow["O"].ToString();
				}
				if (dataRow["Padez"] != DBNull.Value)
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml((string)dataRow["Padez"]);
					XmlNode xmlNode = xmlDocument.SelectSingleNode("FIO");
					if (xmlNode != null)
					{
						XmlNode xmlNode2 = xmlNode.SelectSingleNode("genitive");
						if (xmlNode2 != null)
						{
							XmlAttribute xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("F");
							if (xmlAttribute != null)
							{
								this.uYkZaStwm7.Text = xmlAttribute.Value;
							}
							xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("I");
							if (xmlAttribute != null)
							{
								this.r_ITextBox.Text = xmlAttribute.Value;
							}
							xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("O");
							if (xmlAttribute != null)
							{
								this.r_OTextBox.Text = xmlAttribute.Value;
							}
						}
						xmlNode2 = xmlNode.SelectSingleNode("dative");
						if (xmlNode2 != null)
						{
							XmlAttribute xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("F");
							if (xmlAttribute != null)
							{
								this.d_FTextBox.Text = xmlAttribute.Value;
							}
							xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("I");
							if (xmlAttribute != null)
							{
								this.d_ITextBox.Text = xmlAttribute.Value;
							}
							xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("O");
							if (xmlAttribute != null)
							{
								this.d_OTextBox.Text = xmlAttribute.Value;
							}
						}
						xmlNode2 = xmlNode.SelectSingleNode("ablative");
						if (xmlNode2 != null)
						{
							XmlAttribute xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("F");
							if (xmlAttribute != null)
							{
								this.t_FTextBox.Text = xmlAttribute.Value;
							}
							xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("I");
							if (xmlAttribute != null)
							{
								this.t_ITextBox.Text = xmlAttribute.Value;
							}
							xmlAttribute = (XmlAttribute)xmlNode2.Attributes.GetNamedItem("O");
							if (xmlAttribute != null)
							{
								this.t_OTextBox.Text = xmlAttribute.Value;
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
			this.uYkZaStwm7.Text = this.i_FTextBox.Text;
			this.r_ITextBox.Text = this.i_ITextBox.Text;
			this.r_OTextBox.Text = this.i_OTextBox.Text;
			this.d_FTextBox.Text = this.i_FTextBox.Text;
			this.d_ITextBox.Text = this.i_ITextBox.Text;
			this.d_OTextBox.Text = this.i_OTextBox.Text;
			this.t_FTextBox.Text = this.i_FTextBox.Text;
			this.t_ITextBox.Text = this.i_ITextBox.Text;
			this.t_OTextBox.Text = this.i_OTextBox.Text;
		}

		private void FormWorkerAddEditPadez_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK && this.class48_0.tR_Worker.Rows.Count > 0)
			{
				XmlDocument xmlDocument = new XmlDocument();
				XmlNode xmlNode = xmlDocument.CreateElement("FIO");
				xmlDocument.AppendChild(xmlNode);
				XmlNode xmlNode2 = xmlDocument.CreateElement("genitive");
				xmlNode.AppendChild(xmlNode2);
				XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("F");
				xmlAttribute.Value = this.uYkZaStwm7.Text;
				xmlNode2.Attributes.Append(xmlAttribute);
				xmlAttribute = xmlDocument.CreateAttribute("I");
				xmlAttribute.Value = this.r_ITextBox.Text;
				xmlNode2.Attributes.Append(xmlAttribute);
				xmlAttribute = xmlDocument.CreateAttribute("O");
				xmlAttribute.Value = this.r_OTextBox.Text;
				xmlNode2.Attributes.Append(xmlAttribute);
				XmlNode xmlNode3 = xmlDocument.CreateElement("dative");
				xmlNode.AppendChild(xmlNode3);
				xmlAttribute = xmlDocument.CreateAttribute("F");
				xmlAttribute.Value = this.d_FTextBox.Text;
				xmlNode3.Attributes.Append(xmlAttribute);
				xmlAttribute = xmlDocument.CreateAttribute("I");
				xmlAttribute.Value = this.d_ITextBox.Text;
				xmlNode3.Attributes.Append(xmlAttribute);
				xmlAttribute = xmlDocument.CreateAttribute("O");
				xmlAttribute.Value = this.d_OTextBox.Text;
				xmlNode3.Attributes.Append(xmlAttribute);
				XmlNode xmlNode4 = xmlDocument.CreateElement("ablative");
				xmlNode.AppendChild(xmlNode4);
				xmlAttribute = xmlDocument.CreateAttribute("F");
				xmlAttribute.Value = this.t_FTextBox.Text;
				xmlNode4.Attributes.Append(xmlAttribute);
				xmlAttribute = xmlDocument.CreateAttribute("I");
				xmlAttribute.Value = this.t_ITextBox.Text;
				xmlNode4.Attributes.Append(xmlAttribute);
				xmlAttribute = xmlDocument.CreateAttribute("O");
				xmlAttribute.Value = this.t_OTextBox.Text;
				xmlNode4.Attributes.Append(xmlAttribute);
				this.class48_0.tR_Worker.Rows[0]["Padez"] = xmlDocument.InnerXml;
				this.class48_0.tR_Worker.Rows[0].EndEdit();
				base.UpdateSqlData(this.class48_0.tR_Worker);
			}
		}

		private int int_0;
	}
}
