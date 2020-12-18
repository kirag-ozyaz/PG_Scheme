using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using FormLbr;

namespace RequestsClient.Forms.JournalRequestForRepair
{
	// Token: 0x02000046 RID: 70
	public partial class FormSettingsSender : FormBase
	{
		// Token: 0x060001BC RID: 444 RVA: 0x00016060 File Offset: 0x00014260
		public FormSettingsSender()
		{
			this.a();
			this.b = new DataTable("tSettings");
			DataColumn dataColumn = new DataColumn("id", typeof(int));
			dataColumn.AutoIncrement = true;
			this.b.Columns.Add(dataColumn);
			this.b.Columns.Add("settings", typeof(string));
			this.b.Columns.Add("module", typeof(string));
			DataColumn[] primaryKey = new DataColumn[]
			{
				dataColumn
			};
			this.b.PrimaryKey = primaryKey;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00016110 File Offset: 0x00014310
		private void q(object A_0, EventArgs A_1)
		{
			base.SelectSqlData(this.b, true, string.Format(" where Module = '{0}'", "FTP05"), false);
			if (this.b.Rows.Count == 0)
			{
				DataRow dataRow = this.b.NewRow();
				dataRow["Settings"] = this.c().InnerXml;
				dataRow["Module"] = "FTP05";
				this.b.Rows.Add(dataRow);
				return;
			}
			this.b();
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00016198 File Offset: 0x00014398
		private void a(object A_0, FormClosingEventArgs A_1)
		{
			if (base.DialogResult == DialogResult.OK || MessageBox.Show("Сохранить внесенные изменения?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (this.b.Rows.Count == 0)
				{
					DataRow dataRow = this.b.NewRow();
					dataRow["Settings"] = this.c().InnerXml;
					dataRow["Module"] = "FTP05";
					this.b.Rows.Add(dataRow);
				}
				this.b.Rows[0]["Settings"] = this.c().InnerXml;
				this.b.Rows[0].EndEdit();
				if (!base.InsertSqlData(this.b))
				{
					A_1.Cancel = true;
					return;
				}
				if (!base.UpdateSqlData(this.b))
				{
					A_1.Cancel = true;
					return;
				}
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00016283 File Offset: 0x00014483
		private void p(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0001628B File Offset: 0x0001448B
		private void o(object A_0, EventArgs A_1)
		{
			base.Close();
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00016294 File Offset: 0x00014494
		private XmlDocument c()
		{
			XmlDocument xmlDocument = new XmlDocument();
			XmlNode xmlNode = xmlDocument.CreateElement("ReqForRepairFTP");
			xmlDocument.AppendChild(xmlNode);
			XmlNode xmlNode2 = xmlDocument.CreateElement("FTP05");
			xmlNode.AppendChild(xmlNode2);
			XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("UseFTP");
			xmlAttribute.Value = this.t.Checked.ToString();
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("FileName");
			xmlAttribute.Value = this.d.Text;
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("PathName");
			xmlAttribute.Value = this.ac.Text;
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("FTPName");
			xmlAttribute.Value = this.f.Text;
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("User");
			xmlAttribute.Value = this.i.Text;
			xmlNode2.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Pwd");
			xmlAttribute.Value = this.m.Text;
			xmlNode2.Attributes.Append(xmlAttribute);
			if (this.n.Checked)
			{
				xmlAttribute = xmlDocument.CreateAttribute("Proxy");
				xmlAttribute.Value = this.o.Text;
				xmlNode2.Attributes.Append(xmlAttribute);
				xmlAttribute = xmlDocument.CreateAttribute("ProxyUser");
				xmlAttribute.Value = this.p.Text;
				xmlNode2.Attributes.Append(xmlAttribute);
				xmlAttribute = xmlDocument.CreateAttribute("ProxyPwd");
				xmlAttribute.Value = this.s.Text;
				xmlNode2.Attributes.Append(xmlAttribute);
			}
			XmlNode xmlNode3 = xmlDocument.CreateElement("Shedule");
			xmlNode2.AppendChild(xmlNode3);
			xmlAttribute = xmlDocument.CreateAttribute("Start");
			xmlAttribute.Value = this.aj.Value.ToString("dd.MM.yyyy HH:mm");
			xmlNode3.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Period");
			if (this.ah.Checked)
			{
				xmlAttribute.Value = (this.an.Value * 60m).ToString();
			}
			if (this.ag.Checked)
			{
				xmlAttribute.Value = (this.am.Value * 24m * 60m).ToString();
			}
			if (this.af.Checked)
			{
				xmlAttribute.Value = (this.al.Value * 24m * 60m * 7m).ToString();
			}
			xmlNode3.Attributes.Append(xmlAttribute);
			XmlNode xmlNode4 = xmlDocument.CreateElement("FTP");
			xmlNode.AppendChild(xmlNode4);
			xmlAttribute = xmlDocument.CreateAttribute("UseFTP");
			xmlAttribute.Value = this.a2.Checked.ToString();
			xmlNode4.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("FileName");
			xmlAttribute.Value = this.a3.Text;
			xmlNode4.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("PathName");
			xmlAttribute.Value = this.a1.Text;
			xmlNode4.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("FTPName");
			xmlAttribute.Value = this.a7.Text;
			xmlNode4.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("User");
			xmlAttribute.Value = this.bd.Text;
			xmlNode4.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Pwd");
			xmlAttribute.Value = this.bg.Text;
			xmlNode4.Attributes.Append(xmlAttribute);
			if (this.be.Checked)
			{
				xmlAttribute = xmlDocument.CreateAttribute("Proxy");
				xmlAttribute.Value = this.bc.Text;
				xmlNode4.Attributes.Append(xmlAttribute);
				xmlAttribute = xmlDocument.CreateAttribute("ProxyUser");
				xmlAttribute.Value = this.ba.Text;
				xmlNode4.Attributes.Append(xmlAttribute);
				xmlAttribute = xmlDocument.CreateAttribute("ProxyPwd");
				xmlAttribute.Value = this.a4.Text;
				xmlNode4.Attributes.Append(xmlAttribute);
			}
			XmlNode xmlNode5 = xmlDocument.CreateElement("Shedule");
			xmlNode4.AppendChild(xmlNode5);
			xmlAttribute = xmlDocument.CreateAttribute("Start");
			xmlAttribute.Value = this.aw.Value.ToString("dd.MM.yyyy HH:mm");
			xmlNode5.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Period");
			if (this.au.Checked)
			{
				xmlAttribute.Value = (this.ar.Value * 60m).ToString();
			}
			if (this.at.Checked)
			{
				xmlAttribute.Value = (this.aq.Value * 24m * 60m).ToString();
			}
			if (this.@as.Checked)
			{
				xmlAttribute.Value = (this.ap.Value * 24m * 60m * 7m).ToString();
			}
			xmlNode5.Attributes.Append(xmlAttribute);
			XmlNode xmlNode6 = xmlDocument.CreateElement("MailPlanned");
			xmlNode.AppendChild(xmlNode6);
			xmlAttribute = xmlDocument.CreateAttribute("useMail");
			xmlAttribute.Value = this.bl.Checked.ToString();
			xmlNode6.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("FileName");
			xmlAttribute.Value = this.bj.Text;
			xmlNode6.Attributes.Append(xmlAttribute);
			XmlNode xmlNode7 = xmlDocument.CreateElement("SMTP");
			xmlNode6.AppendChild(xmlNode7);
			xmlAttribute = xmlDocument.CreateAttribute("Name");
			xmlAttribute.Value = this.bu.Text;
			xmlNode7.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Port");
			xmlAttribute.Value = this.bs.Value.ToString();
			xmlNode7.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Login");
			xmlAttribute.Value = this.bq.Text;
			xmlNode7.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Pwd");
			xmlAttribute.Value = this.bo.Text;
			xmlNode7.Attributes.Append(xmlAttribute);
			XmlNode xmlNode8 = xmlDocument.CreateElement("Sender");
			xmlNode6.AppendChild(xmlNode8);
			xmlAttribute = xmlDocument.CreateAttribute("Address");
			xmlAttribute.Value = this.bz.Text;
			xmlNode8.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Name");
			xmlAttribute.Value = this.bx.Text;
			xmlNode8.Attributes.Append(xmlAttribute);
			XmlNode xmlNode9 = xmlDocument.CreateElement("Recipients");
			xmlNode6.AppendChild(xmlNode9);
			for (int i = 0; i < this.cf.Rows.Count - 1; i++)
			{
				XmlNode xmlNode10 = xmlDocument.CreateElement("Recipient");
				xmlNode9.AppendChild(xmlNode10);
				xmlAttribute = xmlDocument.CreateAttribute("Address");
				xmlAttribute.Value = this.cf.Rows[i].Cells[this.cg.Name].Value.ToString();
				xmlNode10.Attributes.Append(xmlAttribute);
				xmlAttribute = xmlDocument.CreateAttribute("Name");
				xmlAttribute.Value = this.cf.Rows[i].Cells[this.ch.Name].Value.ToString();
				xmlNode10.Attributes.Append(xmlAttribute);
			}
			xmlAttribute = xmlDocument.CreateAttribute("Subject");
			xmlAttribute.Value = this.ce.Text;
			xmlNode6.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Body");
			xmlAttribute.Value = this.cc.Text;
			xmlNode6.Attributes.Append(xmlAttribute);
			XmlNode xmlNode11 = xmlDocument.CreateElement("Shedule");
			xmlNode6.AppendChild(xmlNode11);
			xmlAttribute = xmlDocument.CreateAttribute("Start");
			xmlAttribute.Value = this.b9.Value.ToString("dd.MM.yyyy HH:mm");
			xmlNode11.Attributes.Append(xmlAttribute);
			xmlAttribute = xmlDocument.CreateAttribute("Period");
			if (this.b7.Checked)
			{
				xmlAttribute.Value = (this.b4.Value * 60m).ToString();
			}
			if (this.b6.Checked)
			{
				xmlAttribute.Value = (this.b3.Value * 24m * 60m).ToString();
			}
			if (this.b5.Checked)
			{
				xmlAttribute.Value = (this.b2.Value * 24m * 60m * 7m).ToString();
			}
			xmlNode11.Attributes.Append(xmlAttribute);
			XmlNode xmlNode12 = xmlDocument.CreateElement("PathCURL");
			xmlNode12.InnerText = this.y.Text;
			xmlNode.AppendChild(xmlNode12);
			XmlNode xmlNode13 = xmlDocument.CreateElement("RIC");
			xmlNode.AppendChild(xmlNode13);
			xmlAttribute = xmlDocument.CreateAttribute("SendRIC");
			xmlAttribute.Value = this.cj.Checked.ToString();
			xmlNode13.Attributes.Append(xmlAttribute);
			return xmlDocument;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00016CF0 File Offset: 0x00014EF0
		private void b()
		{
			if (this.b.Rows.Count > 0 && this.b.Rows[0]["Settings"] != DBNull.Value)
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.LoadXml(this.b.Rows[0]["Settings"].ToString());
				XmlNode xmlNode = xmlDocument.SelectSingleNode("ReqForRepairFTP");
				if (xmlNode != null)
				{
					XmlNode xmlNode2 = xmlNode.SelectSingleNode("FTP05");
					if (xmlNode2 != null)
					{
						XmlAttribute xmlAttribute = xmlNode2.Attributes["UseFTP"];
						if (xmlAttribute != null)
						{
							this.t.Checked = Convert.ToBoolean(xmlAttribute.Value);
						}
						else
						{
							this.t.Checked = false;
						}
						xmlAttribute = xmlNode2.Attributes["FileName"];
						if (xmlAttribute != null)
						{
							this.d.Text = xmlAttribute.Value;
						}
						xmlAttribute = xmlNode2.Attributes["PathName"];
						if (xmlAttribute != null)
						{
							this.ac.Text = xmlAttribute.Value;
						}
						xmlAttribute = xmlNode2.Attributes["FTPName"];
						if (xmlAttribute != null)
						{
							this.f.Text = xmlAttribute.Value;
						}
						xmlAttribute = xmlNode2.Attributes["User"];
						if (xmlAttribute != null)
						{
							this.i.Text = xmlAttribute.Value;
						}
						xmlAttribute = xmlNode2.Attributes["Pwd"];
						if (xmlAttribute != null)
						{
							this.m.Text = xmlAttribute.Value;
						}
						xmlAttribute = xmlNode2.Attributes["Proxy"];
						if (xmlAttribute != null)
						{
							this.n.Checked = true;
							this.o.Text = xmlAttribute.Value;
							xmlAttribute = xmlNode2.Attributes["ProxyUser"];
							if (xmlAttribute != null)
							{
								this.p.Text = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["ProxyPwd"];
							if (xmlAttribute != null)
							{
								this.s.Text = xmlAttribute.Value;
							}
						}
						XmlNode xmlNode3 = xmlNode2.SelectSingleNode("Shedule");
						if (xmlNode3 != null)
						{
							xmlAttribute = xmlNode3.Attributes["Start"];
							if (xmlAttribute != null)
							{
								this.aj.Value = Convert.ToDateTime(xmlAttribute.Value);
							}
							xmlAttribute = xmlNode3.Attributes["Period"];
							if (xmlAttribute != null)
							{
								int num = Convert.ToInt32(xmlAttribute.Value);
								if (num == 0)
								{
									this.ah.Checked = true;
									this.an.Value = 0m;
								}
								if (num % 10080 == 0)
								{
									this.af.Checked = true;
									this.al.Value = num / 10080;
								}
								else if (num % 1440 == 0)
								{
									this.ag.Checked = true;
									this.am.Value = num / 1440;
								}
								else
								{
									this.ah.Checked = true;
									this.an.Value = num / 60;
								}
							}
						}
					}
					XmlNode xmlNode4 = xmlNode.SelectSingleNode("FTP");
					if (xmlNode4 != null)
					{
						XmlAttribute xmlAttribute2 = xmlNode4.Attributes["UseFTP"];
						if (xmlAttribute2 != null)
						{
							this.a2.Checked = Convert.ToBoolean(xmlAttribute2.Value);
						}
						else
						{
							this.a2.Checked = false;
						}
						xmlAttribute2 = xmlNode4.Attributes["FileName"];
						if (xmlAttribute2 != null)
						{
							this.a3.Text = xmlAttribute2.Value;
						}
						xmlAttribute2 = xmlNode4.Attributes["PathName"];
						if (xmlAttribute2 != null)
						{
							this.a1.Text = xmlAttribute2.Value;
						}
						xmlAttribute2 = xmlNode4.Attributes["FTPName"];
						if (xmlAttribute2 != null)
						{
							this.a7.Text = xmlAttribute2.Value;
						}
						xmlAttribute2 = xmlNode4.Attributes["User"];
						if (xmlAttribute2 != null)
						{
							this.bd.Text = xmlAttribute2.Value;
						}
						xmlAttribute2 = xmlNode4.Attributes["Pwd"];
						if (xmlAttribute2 != null)
						{
							this.bg.Text = xmlAttribute2.Value;
						}
						xmlAttribute2 = xmlNode4.Attributes["Proxy"];
						if (xmlAttribute2 != null)
						{
							this.be.Checked = true;
							this.bc.Text = xmlAttribute2.Value;
							xmlAttribute2 = xmlNode4.Attributes["ProxyUser"];
							if (xmlAttribute2 != null)
							{
								this.ba.Text = xmlAttribute2.Value;
							}
							xmlAttribute2 = xmlNode4.Attributes["ProxyPwd"];
							if (xmlAttribute2 != null)
							{
								this.a4.Text = xmlAttribute2.Value;
							}
						}
						XmlNode xmlNode5 = xmlNode4.SelectSingleNode("Shedule");
						if (xmlNode5 != null)
						{
							xmlAttribute2 = xmlNode5.Attributes["Start"];
							if (xmlAttribute2 != null)
							{
								this.aw.Value = Convert.ToDateTime(xmlAttribute2.Value);
							}
							xmlAttribute2 = xmlNode5.Attributes["Period"];
							if (xmlAttribute2 != null)
							{
								int num2 = Convert.ToInt32(xmlAttribute2.Value);
								if (num2 == 0)
								{
									this.au.Checked = true;
									this.ar.Value = 0m;
								}
								if (num2 % 10080 == 0)
								{
									this.@as.Checked = true;
									this.ap.Value = num2 / 10080;
								}
								else if (num2 % 1440 == 0)
								{
									this.at.Checked = true;
									this.aq.Value = num2 / 1440;
								}
								else
								{
									this.au.Checked = true;
									this.ar.Value = num2 / 60;
								}
							}
						}
					}
					XmlNode xmlNode6 = xmlNode.SelectSingleNode("MailPlanned");
					if (xmlNode6 != null)
					{
						XmlAttribute xmlAttribute3 = xmlNode6.Attributes["FileName"];
						if (xmlAttribute3 != null)
						{
							this.bj.Text = xmlAttribute3.Value;
						}
						xmlAttribute3 = xmlNode6.Attributes["Subject"];
						if (xmlAttribute3 != null)
						{
							this.ce.Text = xmlAttribute3.Value;
						}
						xmlAttribute3 = xmlNode6.Attributes["Body"];
						if (xmlAttribute3 != null)
						{
							this.cc.Text = xmlAttribute3.Value;
						}
						xmlAttribute3 = xmlNode6.Attributes["useMail"];
						if (xmlAttribute3 != null)
						{
							this.bl.Checked = Convert.ToBoolean(xmlAttribute3.Value);
						}
						else
						{
							this.bl.Checked = false;
						}
						XmlNode xmlNode7 = xmlNode6.SelectSingleNode("SMTP");
						if (xmlNode7 != null)
						{
							xmlAttribute3 = xmlNode7.Attributes["Name"];
							if (xmlAttribute3 != null)
							{
								this.bu.Text = xmlAttribute3.Value;
							}
							xmlAttribute3 = xmlNode7.Attributes["Port"];
							if (xmlAttribute3 != null && !string.IsNullOrEmpty(xmlAttribute3.Value))
							{
								this.bs.Value = Convert.ToInt32(xmlAttribute3.Value);
							}
							xmlAttribute3 = xmlNode7.Attributes["Login"];
							if (xmlAttribute3 != null)
							{
								this.bq.Text = xmlAttribute3.Value;
							}
							xmlAttribute3 = xmlNode7.Attributes["Pwd"];
							if (xmlAttribute3 != null)
							{
								this.bo.Text = xmlAttribute3.Value;
							}
						}
						XmlNode xmlNode8 = xmlNode6.SelectSingleNode("Sender");
						if (xmlNode8 != null)
						{
							xmlAttribute3 = xmlNode8.Attributes["Address"];
							if (xmlAttribute3 != null)
							{
								this.bz.Text = xmlAttribute3.Value;
							}
							xmlAttribute3 = xmlNode8.Attributes["Name"];
							if (xmlAttribute3 != null)
							{
								this.bx.Text = xmlAttribute3.Value;
							}
						}
						this.cf.Rows.Clear();
						XmlNode xmlNode9 = xmlNode6.SelectSingleNode("Recipients");
						if (xmlNode9 != null)
						{
							foreach (object obj in xmlNode9.SelectNodes("Recipient"))
							{
								XmlNode xmlNode10 = (XmlNode)obj;
								string text = "";
								string text2 = "";
								xmlAttribute3 = xmlNode10.Attributes["Address"];
								if (xmlAttribute3 != null)
								{
									text = xmlAttribute3.Value;
								}
								xmlAttribute3 = xmlNode10.Attributes["Name"];
								if (xmlAttribute3 != null)
								{
									text2 = xmlAttribute3.Value;
								}
								this.cf.Rows.Add(new object[]
								{
									text,
									text2
								});
							}
						}
						XmlNode xmlNode11 = xmlNode6.SelectSingleNode("Shedule");
						if (xmlNode11 != null)
						{
							xmlAttribute3 = xmlNode11.Attributes["Start"];
							if (xmlAttribute3 != null)
							{
								this.b9.Value = Convert.ToDateTime(xmlAttribute3.Value);
							}
							xmlAttribute3 = xmlNode11.Attributes["Period"];
							if (xmlAttribute3 != null)
							{
								int num3 = Convert.ToInt32(xmlAttribute3.Value);
								if (num3 == 0)
								{
									this.b7.Checked = true;
									this.b4.Value = 0m;
								}
								if (num3 % 10080 == 0)
								{
									this.b5.Checked = true;
									this.b2.Value = num3 / 10080;
								}
								else if (num3 % 1440 == 0)
								{
									this.b6.Checked = true;
									this.b3.Value = num3 / 1440;
								}
								else
								{
									this.b7.Checked = true;
									this.b4.Value = num3 / 60;
								}
							}
						}
					}
					xmlNode2 = xmlNode.SelectSingleNode("PathCURL");
					if (xmlNode2 != null && !string.IsNullOrEmpty(xmlNode2.InnerText))
					{
						this.y.Text = xmlNode2.InnerText;
					}
					XmlNode xmlNode12 = xmlNode.SelectSingleNode("RIC");
					if (xmlNode12 != null)
					{
						XmlAttribute xmlAttribute4 = xmlNode12.Attributes["SendRIC"];
						if (xmlAttribute4 != null)
						{
							this.cj.Checked = Convert.ToBoolean(xmlAttribute4.Value);
						}
					}
				}
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00017710 File Offset: 0x00015910
		private void n(object A_0, EventArgs A_1)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "exe files (*.exe)|*.exe";
			openFileDialog.Multiselect = false;
			openFileDialog.FileName = this.y.Text;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.y.Text = openFileDialog.FileName;
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00017760 File Offset: 0x00015960
		private void m(object A_0, EventArgs A_1)
		{
			this.m.Enabled = (this.i.Enabled = (this.d.Enabled = (this.f.Enabled = (this.o.Enabled = (this.s.Enabled = (this.p.Enabled = (this.n.Enabled = (this.aa.Enabled = (this.ac.Enabled = (this.ad.Enabled = (this.ae.Enabled = this.t.Checked)))))))))));
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001782C File Offset: 0x00015A2C
		private void l(object A_0, EventArgs A_1)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "php files (*.php)|*.php";
			saveFileDialog.CheckFileExists = false;
			saveFileDialog.CheckPathExists = false;
			saveFileDialog.FileName = this.d.Text;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.d.Text = Path.GetFileName(saveFileDialog.FileName);
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00017888 File Offset: 0x00015A88
		private void k(object A_0, EventArgs A_1)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = false;
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				this.ac.Text = folderBrowserDialog.SelectedPath;
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000178BC File Offset: 0x00015ABC
		private void j(object A_0, EventArgs A_1)
		{
			this.an.Enabled = this.ah.Checked;
			this.am.Enabled = this.ag.Checked;
			this.al.Enabled = this.af.Checked;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0001790C File Offset: 0x00015B0C
		private void i(object A_0, EventArgs A_1)
		{
			this.o.Enabled = (this.s.Enabled = (this.p.Enabled = (this.n.Checked && this.t.Checked)));
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0001795C File Offset: 0x00015B5C
		private void h(object A_0, EventArgs A_1)
		{
			this.bg.Enabled = (this.bd.Enabled = (this.a3.Enabled = (this.a7.Enabled = (this.bc.Enabled = (this.a4.Enabled = (this.ba.Enabled = (this.be.Enabled = (this.az.Enabled = (this.a1.Enabled = (this.ay.Enabled = (this.ao.Enabled = this.a2.Checked)))))))))));
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00017A28 File Offset: 0x00015C28
		private void g(object A_0, EventArgs A_1)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "php files (*.php)|*.php";
			saveFileDialog.CheckFileExists = false;
			saveFileDialog.CheckPathExists = false;
			saveFileDialog.FileName = this.a3.Text;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.a3.Text = Path.GetFileName(saveFileDialog.FileName);
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00017A84 File Offset: 0x00015C84
		private void f(object A_0, EventArgs A_1)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowNewFolderButton = false;
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				this.a1.Text = folderBrowserDialog.SelectedPath;
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00017AB8 File Offset: 0x00015CB8
		private void e(object A_0, EventArgs A_1)
		{
			this.bc.Enabled = (this.a4.Enabled = (this.ba.Enabled = (this.be.Checked && this.a2.Checked)));
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00017B08 File Offset: 0x00015D08
		private void d(object A_0, EventArgs A_1)
		{
			this.ar.Enabled = this.au.Checked;
			this.aq.Enabled = this.at.Checked;
			this.ap.Enabled = this.@as.Checked;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00017B58 File Offset: 0x00015D58
		private void c(object A_0, EventArgs A_1)
		{
			this.bj.Enabled = (this.bi.Enabled = (this.bm.Enabled = (this.bv.Enabled = (this.cf.Enabled = (this.ce.Enabled = (this.cc.Enabled = (this.b1.Enabled = this.bl.Checked)))))));
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00017BE4 File Offset: 0x00015DE4
		private void b(object A_0, EventArgs A_1)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "xls files (*.xls)|*.xls";
			saveFileDialog.CheckFileExists = false;
			saveFileDialog.OverwritePrompt = false;
			saveFileDialog.CheckPathExists = false;
			saveFileDialog.FileName = this.bj.Text;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.bj.Text = saveFileDialog.FileName;
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00017C44 File Offset: 0x00015E44
		private void a(object A_0, EventArgs A_1)
		{
			this.b4.Enabled = this.b7.Checked;
			this.b3.Enabled = this.b6.Checked;
			this.b2.Enabled = this.b5.Checked;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00017CB4 File Offset: 0x00015EB4
		private void a()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormSettingsSender));
			this.d = new TextBox();
			this.e = new Label();
			this.f = new TextBox();
			this.g = new Label();
			this.h = new Label();
			this.i = new TextBox();
			this.j = new Label();
			this.k = new Button();
			this.l = new Button();
			this.m = new MaskedTextBox();
			this.n = new CheckBox();
			this.o = new TextBox();
			this.p = new TextBox();
			this.q = new Label();
			this.r = new Label();
			this.s = new MaskedTextBox();
			this.t = new CheckBox();
			this.u = new TabControl();
			this.v = new TabPage();
			this.ao = new GroupBox();
			this.ap = new NumericUpDown();
			this.aq = new NumericUpDown();
			this.ar = new NumericUpDown();
			this.@as = new RadioButton();
			this.at = new RadioButton();
			this.au = new RadioButton();
			this.av = new Label();
			this.aw = new DateTimePicker();
			this.ax = new Label();
			this.ay = new Button();
			this.az = new Button();
			this.a0 = new Label();
			this.a1 = new TextBox();
			this.a2 = new CheckBox();
			this.a3 = new TextBox();
			this.a4 = new MaskedTextBox();
			this.a5 = new Label();
			this.a6 = new Label();
			this.a7 = new TextBox();
			this.a8 = new Label();
			this.a9 = new Label();
			this.ba = new TextBox();
			this.bb = new Label();
			this.bc = new TextBox();
			this.bd = new TextBox();
			this.be = new CheckBox();
			this.bf = new Label();
			this.bg = new MaskedTextBox();
			this.w = new TabPage();
			this.ae = new GroupBox();
			this.al = new NumericUpDown();
			this.am = new NumericUpDown();
			this.an = new NumericUpDown();
			this.af = new RadioButton();
			this.ag = new RadioButton();
			this.ah = new RadioButton();
			this.ai = new Label();
			this.aj = new DateTimePicker();
			this.ak = new Label();
			this.ad = new Button();
			this.aa = new Button();
			this.ab = new Label();
			this.ac = new TextBox();
			this.bh = new TabPage();
			this.b1 = new GroupBox();
			this.b2 = new NumericUpDown();
			this.b3 = new NumericUpDown();
			this.b4 = new NumericUpDown();
			this.b5 = new RadioButton();
			this.b6 = new RadioButton();
			this.b7 = new RadioButton();
			this.b8 = new Label();
			this.b9 = new DateTimePicker();
			this.ca = new Label();
			this.cb = new Label();
			this.cc = new TextBox();
			this.cd = new Label();
			this.ce = new TextBox();
			this.cf = new DataGridView();
			this.cg = new DataGridViewTextBoxColumn();
			this.ch = new DataGridViewTextBoxColumn();
			this.b0 = new Label();
			this.bv = new GroupBox();
			this.bw = new Label();
			this.bx = new TextBox();
			this.by = new Label();
			this.bz = new TextBox();
			this.bm = new GroupBox();
			this.bn = new Label();
			this.bo = new TextBox();
			this.bp = new Label();
			this.bq = new TextBox();
			this.br = new Label();
			this.bs = new NumericUpDown();
			this.bt = new Label();
			this.bu = new TextBox();
			this.bi = new Button();
			this.bj = new TextBox();
			this.bk = new Label();
			this.bl = new CheckBox();
			this.x = new Label();
			this.y = new TextBox();
			this.z = new Button();
			this.ci = new TabPage();
			this.cj = new CheckBox();
			this.u.SuspendLayout();
			this.v.SuspendLayout();
			this.ao.SuspendLayout();
			((ISupportInitialize)this.ap).BeginInit();
			((ISupportInitialize)this.aq).BeginInit();
			((ISupportInitialize)this.ar).BeginInit();
			this.w.SuspendLayout();
			this.ae.SuspendLayout();
			((ISupportInitialize)this.al).BeginInit();
			((ISupportInitialize)this.am).BeginInit();
			((ISupportInitialize)this.an).BeginInit();
			this.bh.SuspendLayout();
			this.b1.SuspendLayout();
			((ISupportInitialize)this.b2).BeginInit();
			((ISupportInitialize)this.b3).BeginInit();
			((ISupportInitialize)this.b4).BeginInit();
			((ISupportInitialize)this.cf).BeginInit();
			this.bv.SuspendLayout();
			this.bm.SuspendLayout();
			((ISupportInitialize)this.bs).BeginInit();
			this.ci.SuspendLayout();
			base.SuspendLayout();
			this.d.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.d.Location = new Point(90, 39);
			this.d.Name = "txtFTP05_FileName";
			this.d.Size = new Size(358, 20);
			this.d.TabIndex = 0;
			this.d.Text = "\\\\ulges-fs\\software\\Ulges\\Site\\oper_otkl.html";
			this.e.AutoSize = true;
			this.e.Location = new Point(7, 42);
			this.e.Name = "label1";
			this.e.Size = new Size(64, 13);
			this.e.TabIndex = 1;
			this.e.Text = "Имя файла";
			this.f.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.f.Location = new Point(90, 92);
			this.f.Name = "txtFTP05_NameFTP";
			this.f.Size = new Size(389, 20);
			this.f.TabIndex = 2;
			this.f.Text = "ftp://pike.z8.ru/www/site1/public_html/consumer/rabota/oper_otkl.html";
			this.g.AutoSize = true;
			this.g.Location = new Point(7, 95);
			this.g.Name = "label2";
			this.g.Size = new Size(54, 13);
			this.g.TabIndex = 3;
			this.g.Text = "Путь FTP";
			this.h.AutoSize = true;
			this.h.Location = new Point(7, 121);
			this.h.Name = "label3";
			this.h.Size = new Size(61, 13);
			this.h.TabIndex = 4;
			this.h.Text = "Логин FTP";
			this.i.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.i.Location = new Point(90, 118);
			this.i.Name = "txtFTP05_FTPUser";
			this.i.Size = new Size(389, 20);
			this.i.TabIndex = 5;
			this.i.Text = "ulges";
			this.j.AutoSize = true;
			this.j.Location = new Point(7, 147);
			this.j.Name = "label4";
			this.j.Size = new Size(68, 13);
			this.j.TabIndex = 7;
			this.j.Text = "Пароль FTP";
			this.k.DialogResult = DialogResult.OK;
			this.k.Location = new Point(12, 556);
			this.k.Name = "btnOK";
			this.k.Size = new Size(75, 23);
			this.k.TabIndex = 8;
			this.k.Text = "ОК";
			this.k.UseVisualStyleBackColor = true;
			this.k.Click += this.p;
			this.l.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.l.DialogResult = DialogResult.Cancel;
			this.l.Location = new Point(409, 556);
			this.l.Name = "btnClose";
			this.l.Size = new Size(75, 23);
			this.l.TabIndex = 9;
			this.l.Text = "Закрыть";
			this.l.UseVisualStyleBackColor = true;
			this.l.Click += this.o;
			this.m.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.m.Location = new Point(90, 144);
			this.m.Name = "txtFTP05_FTPPwd";
			this.m.PasswordChar = '*';
			this.m.Size = new Size(389, 20);
			this.m.TabIndex = 10;
			this.m.Text = "kil777o";
			this.n.AutoSize = true;
			this.n.Location = new Point(10, 172);
			this.n.Name = "chbFTP05_Proxy";
			this.n.Size = new Size(138, 17);
			this.n.TabIndex = 11;
			this.n.Text = "Использовать прокси";
			this.n.UseVisualStyleBackColor = true;
			this.n.CheckedChanged += this.i;
			this.o.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.o.Enabled = false;
			this.o.Location = new Point(154, 170);
			this.o.Name = "txtFTP05_Proxy";
			this.o.Size = new Size(325, 20);
			this.o.TabIndex = 12;
			this.o.Text = "ulges-proxy:8080";
			this.p.Enabled = false;
			this.p.Location = new Point(132, 196);
			this.p.Name = "txtFTP05_ProxyUser";
			this.p.Size = new Size(139, 20);
			this.p.TabIndex = 13;
			this.q.AutoSize = true;
			this.q.Location = new Point(7, 199);
			this.q.Name = "label5";
			this.q.Size = new Size(119, 13);
			this.q.TabIndex = 14;
			this.q.Text = "Пользователь прокси";
			this.r.AutoSize = true;
			this.r.Location = new Point(277, 199);
			this.r.Name = "label6";
			this.r.Size = new Size(45, 13);
			this.r.TabIndex = 15;
			this.r.Text = "Пароль";
			this.s.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.s.Enabled = false;
			this.s.Location = new Point(328, 196);
			this.s.Name = "txtFTP05_ProxyPwd";
			this.s.PasswordChar = '*';
			this.s.Size = new Size(151, 20);
			this.s.TabIndex = 16;
			this.s.Text = "kil777o";
			this.t.AutoSize = true;
			this.t.Checked = true;
			this.t.CheckState = CheckState.Checked;
			this.t.Location = new Point(10, 16);
			this.t.Name = "chbUseFTP05";
			this.t.Size = new Size(186, 17);
			this.t.TabIndex = 17;
			this.t.Text = "Использовать отправку на FTP";
			this.t.UseVisualStyleBackColor = true;
			this.t.CheckedChanged += this.m;
			this.u.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.u.Controls.Add(this.v);
			this.u.Controls.Add(this.w);
			this.u.Controls.Add(this.bh);
			this.u.Controls.Add(this.ci);
			this.u.Location = new Point(1, 39);
			this.u.Name = "tabControl";
			this.u.SelectedIndex = 0;
			this.u.Size = new Size(498, 511);
			this.u.TabIndex = 18;
			this.v.Controls.Add(this.ao);
			this.v.Controls.Add(this.ay);
			this.v.Controls.Add(this.az);
			this.v.Controls.Add(this.a0);
			this.v.Controls.Add(this.a1);
			this.v.Controls.Add(this.a2);
			this.v.Controls.Add(this.a3);
			this.v.Controls.Add(this.a4);
			this.v.Controls.Add(this.a5);
			this.v.Controls.Add(this.a6);
			this.v.Controls.Add(this.a7);
			this.v.Controls.Add(this.a8);
			this.v.Controls.Add(this.a9);
			this.v.Controls.Add(this.ba);
			this.v.Controls.Add(this.bb);
			this.v.Controls.Add(this.bc);
			this.v.Controls.Add(this.bd);
			this.v.Controls.Add(this.be);
			this.v.Controls.Add(this.bf);
			this.v.Controls.Add(this.bg);
			this.v.Location = new Point(4, 22);
			this.v.Name = "tabPagePlan";
			this.v.Padding = new Padding(3);
			this.v.Size = new Size(490, 485);
			this.v.TabIndex = 0;
			this.v.Text = "Плановые";
			this.v.UseVisualStyleBackColor = true;
			this.ao.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.ao.Controls.Add(this.ap);
			this.ao.Controls.Add(this.aq);
			this.ao.Controls.Add(this.ar);
			this.ao.Controls.Add(this.@as);
			this.ao.Controls.Add(this.at);
			this.ao.Controls.Add(this.au);
			this.ao.Controls.Add(this.av);
			this.ao.Controls.Add(this.aw);
			this.ao.Controls.Add(this.ax);
			this.ao.Location = new Point(12, 217);
			this.ao.Name = "groupBoxSheduleFTP";
			this.ao.Size = new Size(467, 254);
			this.ao.TabIndex = 44;
			this.ao.TabStop = false;
			this.ao.Text = "Расписание";
			this.ap.Enabled = false;
			this.ap.Location = new Point(80, 121);
			this.ap.Name = "numFTP_weeks";
			this.ap.Size = new Size(120, 20);
			this.ap.TabIndex = 11;
			this.aq.Enabled = false;
			this.aq.Location = new Point(80, 98);
			this.aq.Name = "numFTP_days";
			this.aq.Size = new Size(120, 20);
			this.aq.TabIndex = 10;
			this.ar.Location = new Point(80, 75);
			this.ar.Name = "numFTP_hours";
			this.ar.Size = new Size(120, 20);
			this.ar.TabIndex = 8;
			this.@as.AutoSize = true;
			this.@as.Location = new Point(13, 124);
			this.@as.Name = "rbFTP_weeks";
			this.@as.Size = new Size(63, 17);
			this.@as.TabIndex = 5;
			this.@as.Text = "Недели";
			this.@as.UseVisualStyleBackColor = true;
			this.@as.CheckedChanged += this.d;
			this.at.AutoSize = true;
			this.at.Location = new Point(13, 101);
			this.at.Name = "rbFTP_days";
			this.at.Size = new Size(46, 17);
			this.at.TabIndex = 4;
			this.at.Text = "Дни";
			this.at.UseVisualStyleBackColor = true;
			this.at.CheckedChanged += this.d;
			this.au.AutoSize = true;
			this.au.Checked = true;
			this.au.Location = new Point(13, 78);
			this.au.Name = "rbFTP_hours";
			this.au.Size = new Size(53, 17);
			this.au.TabIndex = 3;
			this.au.TabStop = true;
			this.au.Text = "Часы";
			this.au.UseVisualStyleBackColor = true;
			this.au.CheckedChanged += this.d;
			this.av.AutoSize = true;
			this.av.Location = new Point(10, 51);
			this.av.Name = "label11";
			this.av.Size = new Size(104, 13);
			this.av.TabIndex = 2;
			this.av.Text = "Повторять каждые";
			this.aw.Cursor = Cursors.Default;
			this.aw.CustomFormat = "dd.MM.yyyy HH:mm";
			this.aw.Format = DateTimePickerFormat.Custom;
			this.aw.Location = new Point(80, 19);
			this.aw.Name = "dtpFTP_start";
			this.aw.Size = new Size(200, 20);
			this.aw.TabIndex = 1;
			this.ax.AutoSize = true;
			this.ax.Location = new Point(6, 25);
			this.ax.Name = "label12";
			this.ax.Size = new Size(55, 13);
			this.ax.TabIndex = 0;
			this.ax.Text = "Начать с ";
			this.ay.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.ay.Location = new Point(451, 58);
			this.ay.Name = "btnFTP_ChoicePath";
			this.ay.Size = new Size(28, 23);
			this.ay.TabIndex = 43;
			this.ay.Text = "...";
			this.ay.UseVisualStyleBackColor = true;
			this.ay.Click += this.f;
			this.az.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.az.Location = new Point(451, 32);
			this.az.Name = "btnFTP_ChoiceFileName";
			this.az.Size = new Size(28, 23);
			this.az.TabIndex = 42;
			this.az.Text = "...";
			this.az.UseVisualStyleBackColor = true;
			this.az.Click += this.g;
			this.a0.Location = new Point(9, 57);
			this.a0.Name = "label13";
			this.a0.Size = new Size(78, 31);
			this.a0.TabIndex = 41;
			this.a0.Text = "Пусть файла (для службы)";
			this.a1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.a1.Location = new Point(92, 60);
			this.a1.Name = "txtFTP_PathName";
			this.a1.Size = new Size(356, 20);
			this.a1.TabIndex = 40;
			this.a1.Text = "\\\\ulges-fs\\software\\Ulges\\Site\\oper_otkl.html";
			this.a2.AutoSize = true;
			this.a2.Checked = true;
			this.a2.CheckState = CheckState.Checked;
			this.a2.Location = new Point(12, 11);
			this.a2.Name = "chbUseFTP";
			this.a2.Size = new Size(186, 17);
			this.a2.TabIndex = 39;
			this.a2.Text = "Использовать отправку на FTP";
			this.a2.UseVisualStyleBackColor = true;
			this.a2.CheckedChanged += this.h;
			this.a3.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.a3.Location = new Point(92, 34);
			this.a3.Name = "txtFTP_FileName";
			this.a3.Size = new Size(356, 20);
			this.a3.TabIndex = 25;
			this.a3.Text = "\\\\ulges-fs\\software\\Ulges\\Site\\oper_otkl.html";
			this.a4.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.a4.Enabled = false;
			this.a4.Location = new Point(330, 191);
			this.a4.Name = "txtFTP_ProxyPwd";
			this.a4.PasswordChar = '*';
			this.a4.Size = new Size(149, 20);
			this.a4.TabIndex = 38;
			this.a4.Text = "kil777o";
			this.a5.AutoSize = true;
			this.a5.Location = new Point(9, 37);
			this.a5.Name = "label14";
			this.a5.Size = new Size(64, 13);
			this.a5.TabIndex = 26;
			this.a5.Text = "Имя файла";
			this.a6.AutoSize = true;
			this.a6.Location = new Point(279, 194);
			this.a6.Name = "label15";
			this.a6.Size = new Size(45, 13);
			this.a6.TabIndex = 37;
			this.a6.Text = "Пароль";
			this.a7.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.a7.Location = new Point(92, 87);
			this.a7.Name = "txtFTP_NameFTP";
			this.a7.Size = new Size(387, 20);
			this.a7.TabIndex = 27;
			this.a7.Text = "ftp://pike.z8.ru/www/site1/public_html/consumer/rabota/oper_otkl.html";
			this.a8.AutoSize = true;
			this.a8.Location = new Point(9, 194);
			this.a8.Name = "label16";
			this.a8.Size = new Size(119, 13);
			this.a8.TabIndex = 36;
			this.a8.Text = "Пользователь прокси";
			this.a9.AutoSize = true;
			this.a9.Location = new Point(9, 90);
			this.a9.Name = "label17";
			this.a9.Size = new Size(54, 13);
			this.a9.TabIndex = 28;
			this.a9.Text = "Путь FTP";
			this.ba.Enabled = false;
			this.ba.Location = new Point(134, 191);
			this.ba.Name = "txtFTP_ProxyUser";
			this.ba.Size = new Size(139, 20);
			this.ba.TabIndex = 35;
			this.bb.AutoSize = true;
			this.bb.Location = new Point(9, 116);
			this.bb.Name = "label18";
			this.bb.Size = new Size(61, 13);
			this.bb.TabIndex = 29;
			this.bb.Text = "Логин FTP";
			this.bc.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.bc.Enabled = false;
			this.bc.Location = new Point(156, 165);
			this.bc.Name = "txtFTP_Proxy";
			this.bc.Size = new Size(323, 20);
			this.bc.TabIndex = 34;
			this.bc.Text = "ulges-proxy:8080";
			this.bd.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.bd.Location = new Point(92, 113);
			this.bd.Name = "txtFTP_FTPUser";
			this.bd.Size = new Size(387, 20);
			this.bd.TabIndex = 30;
			this.bd.Text = "ulges";
			this.be.AutoSize = true;
			this.be.Location = new Point(12, 167);
			this.be.Name = "chbFTP_Proxy";
			this.be.Size = new Size(138, 17);
			this.be.TabIndex = 33;
			this.be.Text = "Использовать прокси";
			this.be.UseVisualStyleBackColor = true;
			this.be.CheckedChanged += this.e;
			this.bf.AutoSize = true;
			this.bf.Location = new Point(9, 142);
			this.bf.Name = "label19";
			this.bf.Size = new Size(68, 13);
			this.bf.TabIndex = 31;
			this.bf.Text = "Пароль FTP";
			this.bg.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.bg.Location = new Point(92, 139);
			this.bg.Name = "txtFTP_FTPPwd";
			this.bg.PasswordChar = '*';
			this.bg.Size = new Size(387, 20);
			this.bg.TabIndex = 32;
			this.bg.Text = "kil777o";
			this.w.Controls.Add(this.ae);
			this.w.Controls.Add(this.ad);
			this.w.Controls.Add(this.aa);
			this.w.Controls.Add(this.ab);
			this.w.Controls.Add(this.ac);
			this.w.Controls.Add(this.t);
			this.w.Controls.Add(this.d);
			this.w.Controls.Add(this.s);
			this.w.Controls.Add(this.e);
			this.w.Controls.Add(this.r);
			this.w.Controls.Add(this.f);
			this.w.Controls.Add(this.q);
			this.w.Controls.Add(this.g);
			this.w.Controls.Add(this.p);
			this.w.Controls.Add(this.h);
			this.w.Controls.Add(this.o);
			this.w.Controls.Add(this.i);
			this.w.Controls.Add(this.n);
			this.w.Controls.Add(this.j);
			this.w.Controls.Add(this.m);
			this.w.Location = new Point(4, 22);
			this.w.Name = "tabPageCrash";
			this.w.Padding = new Padding(3);
			this.w.Size = new Size(490, 485);
			this.w.TabIndex = 1;
			this.w.Text = "Аварийные";
			this.w.UseVisualStyleBackColor = true;
			this.ae.Controls.Add(this.al);
			this.ae.Controls.Add(this.am);
			this.ae.Controls.Add(this.an);
			this.ae.Controls.Add(this.af);
			this.ae.Controls.Add(this.ag);
			this.ae.Controls.Add(this.ah);
			this.ae.Controls.Add(this.ai);
			this.ae.Controls.Add(this.aj);
			this.ae.Controls.Add(this.ak);
			this.ae.Location = new Point(10, 222);
			this.ae.Name = "groupBoxSheduleFTP05";
			this.ae.Size = new Size(585, 151);
			this.ae.TabIndex = 24;
			this.ae.TabStop = false;
			this.ae.Text = "Расписание";
			this.al.Enabled = false;
			this.al.Location = new Point(80, 121);
			this.al.Name = "numFTP05_weeks";
			this.al.Size = new Size(120, 20);
			this.al.TabIndex = 11;
			this.am.Enabled = false;
			this.am.Location = new Point(80, 98);
			this.am.Name = "numFTP05_days";
			this.am.Size = new Size(120, 20);
			this.am.TabIndex = 10;
			this.an.Location = new Point(80, 75);
			this.an.Name = "numFTP05_hours";
			this.an.Size = new Size(120, 20);
			this.an.TabIndex = 8;
			this.af.AutoSize = true;
			this.af.Location = new Point(13, 124);
			this.af.Name = "rbFTP05_weeks";
			this.af.Size = new Size(63, 17);
			this.af.TabIndex = 5;
			this.af.Text = "Недели";
			this.af.UseVisualStyleBackColor = true;
			this.af.CheckedChanged += this.j;
			this.ag.AutoSize = true;
			this.ag.Location = new Point(13, 101);
			this.ag.Name = "rbFTP05_days";
			this.ag.Size = new Size(46, 17);
			this.ag.TabIndex = 4;
			this.ag.Text = "Дни";
			this.ag.UseVisualStyleBackColor = true;
			this.ag.CheckedChanged += this.j;
			this.ah.AutoSize = true;
			this.ah.Checked = true;
			this.ah.Location = new Point(13, 78);
			this.ah.Name = "rbFTP05_hours";
			this.ah.Size = new Size(53, 17);
			this.ah.TabIndex = 3;
			this.ah.TabStop = true;
			this.ah.Text = "Часы";
			this.ah.UseVisualStyleBackColor = true;
			this.ah.CheckedChanged += this.j;
			this.ai.AutoSize = true;
			this.ai.Location = new Point(10, 51);
			this.ai.Name = "label10";
			this.ai.Size = new Size(104, 13);
			this.ai.TabIndex = 2;
			this.ai.Text = "Повторять каждые";
			this.aj.Cursor = Cursors.Default;
			this.aj.CustomFormat = "dd.MM.yyyy HH:mm";
			this.aj.Format = DateTimePickerFormat.Custom;
			this.aj.Location = new Point(80, 19);
			this.aj.Name = "dtpFTP05_start";
			this.aj.Size = new Size(200, 20);
			this.aj.TabIndex = 1;
			this.ak.AutoSize = true;
			this.ak.Location = new Point(6, 25);
			this.ak.Name = "label9";
			this.ak.Size = new Size(55, 13);
			this.ak.TabIndex = 0;
			this.ak.Text = "Начать с ";
			this.ad.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.ad.Location = new Point(451, 63);
			this.ad.Name = "btnFTP05_ChoicePath";
			this.ad.Size = new Size(28, 23);
			this.ad.TabIndex = 23;
			this.ad.Text = "...";
			this.ad.UseVisualStyleBackColor = true;
			this.ad.Click += this.k;
			this.aa.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.aa.Location = new Point(451, 37);
			this.aa.Name = "btnFTP05_ChoiceFileName";
			this.aa.Size = new Size(28, 23);
			this.aa.TabIndex = 22;
			this.aa.Text = "...";
			this.aa.UseVisualStyleBackColor = true;
			this.aa.Click += this.l;
			this.ab.Location = new Point(7, 62);
			this.ab.Name = "label8";
			this.ab.Size = new Size(78, 31);
			this.ab.TabIndex = 19;
			this.ab.Text = "Пусть файла (для службы)";
			this.ac.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.ac.Location = new Point(90, 65);
			this.ac.Name = "txtFTP05_PathName";
			this.ac.Size = new Size(358, 20);
			this.ac.TabIndex = 18;
			this.ac.Text = "\\\\ulges-fs\\software\\Ulges\\Site\\oper_otkl.html";
			this.bh.Controls.Add(this.b1);
			this.bh.Controls.Add(this.cb);
			this.bh.Controls.Add(this.cc);
			this.bh.Controls.Add(this.cd);
			this.bh.Controls.Add(this.ce);
			this.bh.Controls.Add(this.cf);
			this.bh.Controls.Add(this.b0);
			this.bh.Controls.Add(this.bv);
			this.bh.Controls.Add(this.bm);
			this.bh.Controls.Add(this.bi);
			this.bh.Controls.Add(this.bj);
			this.bh.Controls.Add(this.bk);
			this.bh.Controls.Add(this.bl);
			this.bh.Location = new Point(4, 22);
			this.bh.Name = "tabPagePlannedMail";
			this.bh.Padding = new Padding(3);
			this.bh.Size = new Size(490, 485);
			this.bh.TabIndex = 2;
			this.bh.Text = "Плановые почта";
			this.bh.UseVisualStyleBackColor = true;
			this.b1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.b1.Controls.Add(this.b2);
			this.b1.Controls.Add(this.b3);
			this.b1.Controls.Add(this.b4);
			this.b1.Controls.Add(this.b5);
			this.b1.Controls.Add(this.b6);
			this.b1.Controls.Add(this.b7);
			this.b1.Controls.Add(this.b8);
			this.b1.Controls.Add(this.b9);
			this.b1.Controls.Add(this.ca);
			this.b1.Location = new Point(7, 365);
			this.b1.Name = "groupBoxSheduleMailPlanned";
			this.b1.Size = new Size(472, 117);
			this.b1.TabIndex = 45;
			this.b1.TabStop = false;
			this.b1.Text = "Расписание";
			this.b2.Enabled = false;
			this.b2.Location = new Point(192, 88);
			this.b2.Name = "numMailPlanned_weeks";
			this.b2.Size = new Size(120, 20);
			this.b2.TabIndex = 11;
			this.b3.Enabled = false;
			this.b3.Location = new Point(192, 65);
			this.b3.Name = "numMailPlanned_days";
			this.b3.Size = new Size(120, 20);
			this.b3.TabIndex = 10;
			this.b4.Location = new Point(192, 42);
			this.b4.Name = "numMailPlanned_hours";
			this.b4.Size = new Size(120, 20);
			this.b4.TabIndex = 8;
			this.b5.AutoSize = true;
			this.b5.Location = new Point(125, 91);
			this.b5.Name = "rbMailPlanned_weeks";
			this.b5.Size = new Size(63, 17);
			this.b5.TabIndex = 5;
			this.b5.Text = "Недели";
			this.b5.UseVisualStyleBackColor = true;
			this.b5.CheckedChanged += this.a;
			this.b6.AutoSize = true;
			this.b6.Location = new Point(125, 68);
			this.b6.Name = "rbMailPlanned_days";
			this.b6.Size = new Size(46, 17);
			this.b6.TabIndex = 4;
			this.b6.Text = "Дни";
			this.b6.UseVisualStyleBackColor = true;
			this.b6.CheckedChanged += this.a;
			this.b7.AutoSize = true;
			this.b7.Checked = true;
			this.b7.Location = new Point(125, 45);
			this.b7.Name = "rbMailPlanned_hours";
			this.b7.Size = new Size(53, 17);
			this.b7.TabIndex = 3;
			this.b7.TabStop = true;
			this.b7.Text = "Часы";
			this.b7.UseVisualStyleBackColor = true;
			this.b7.CheckedChanged += this.a;
			this.b8.AutoSize = true;
			this.b8.Location = new Point(6, 42);
			this.b8.Name = "label30";
			this.b8.Size = new Size(104, 13);
			this.b8.TabIndex = 2;
			this.b8.Text = "Повторять каждые";
			this.b9.Cursor = Cursors.Default;
			this.b9.CustomFormat = "dd.MM.yyyy HH:mm";
			this.b9.Format = DateTimePickerFormat.Custom;
			this.b9.Location = new Point(80, 19);
			this.b9.Name = "dtpMailPlanned_start";
			this.b9.Size = new Size(200, 20);
			this.b9.TabIndex = 1;
			this.ca.AutoSize = true;
			this.ca.Location = new Point(6, 25);
			this.ca.Name = "label31";
			this.ca.Size = new Size(55, 13);
			this.ca.TabIndex = 0;
			this.ca.Text = "Начать с ";
			this.cb.AutoSize = true;
			this.cb.Location = new Point(7, 342);
			this.cb.Name = "label29";
			this.cb.Size = new Size(97, 13);
			this.cb.TabIndex = 33;
			this.cb.Text = "Текст сообщения";
			this.cc.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.cc.Location = new Point(107, 339);
			this.cc.Name = "txtBodyPlanned";
			this.cc.Size = new Size(372, 20);
			this.cc.TabIndex = 32;
			this.cd.AutoSize = true;
			this.cd.Location = new Point(7, 316);
			this.cd.Name = "label28";
			this.cd.Size = new Size(94, 13);
			this.cd.TabIndex = 31;
			this.cd.Text = "Тема сообщения";
			this.ce.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.ce.Location = new Point(107, 313);
			this.ce.Name = "txtSubjectPlanned";
			this.ce.Size = new Size(372, 20);
			this.ce.TabIndex = 30;
			this.cf.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.cf.BackgroundColor = SystemColors.Control;
			this.cf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cf.Columns.AddRange(new DataGridViewColumn[]
			{
				this.cg,
				this.ch
			});
			this.cf.Location = new Point(10, 227);
			this.cf.Name = "dgvRecipients";
			this.cf.RowHeadersWidth = 15;
			this.cf.Size = new Size(469, 80);
			this.cf.TabIndex = 29;
			this.cg.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.cg.HeaderText = "Адрес";
			this.cg.Name = "addressRecipientDgvColumn";
			this.ch.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.ch.HeaderText = "Имя";
			this.ch.Name = "nameRecipientDgvColumn";
			this.b0.AutoSize = true;
			this.b0.Location = new Point(16, 211);
			this.b0.Name = "label27";
			this.b0.Size = new Size(66, 13);
			this.b0.TabIndex = 28;
			this.b0.Text = "Получатели";
			this.bv.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.bv.Controls.Add(this.bw);
			this.bv.Controls.Add(this.bx);
			this.bv.Controls.Add(this.by);
			this.bv.Controls.Add(this.bz);
			this.bv.Location = new Point(10, 134);
			this.bv.Name = "groupBoxSender";
			this.bv.Size = new Size(469, 74);
			this.bv.TabIndex = 27;
			this.bv.TabStop = false;
			this.bv.Text = "Отправитель";
			this.bw.AutoSize = true;
			this.bw.Location = new Point(6, 48);
			this.bw.Name = "label26";
			this.bw.Size = new Size(29, 13);
			this.bw.TabIndex = 4;
			this.bw.Text = "Имя";
			this.bx.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.bx.Location = new Point(80, 45);
			this.bx.Name = "txtSenderNamePlanned";
			this.bx.Size = new Size(383, 20);
			this.bx.TabIndex = 3;
			this.by.AutoSize = true;
			this.by.Location = new Point(6, 22);
			this.by.Name = "label25";
			this.by.Size = new Size(38, 13);
			this.by.TabIndex = 2;
			this.by.Text = "Адрес";
			this.bz.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.bz.Location = new Point(80, 19);
			this.bz.Name = "txtSenderAddressPlanned";
			this.bz.Size = new Size(383, 20);
			this.bz.TabIndex = 1;
			this.bm.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.bm.Controls.Add(this.bn);
			this.bm.Controls.Add(this.bo);
			this.bm.Controls.Add(this.bp);
			this.bm.Controls.Add(this.bq);
			this.bm.Controls.Add(this.br);
			this.bm.Controls.Add(this.bs);
			this.bm.Controls.Add(this.bt);
			this.bm.Controls.Add(this.bu);
			this.bm.Location = new Point(10, 55);
			this.bm.Name = "groupBoxSMTP";
			this.bm.Size = new Size(469, 73);
			this.bm.TabIndex = 26;
			this.bm.TabStop = false;
			this.bm.Text = "SMTP-сервер (сервер отправки)";
			this.bn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.bn.AutoSize = true;
			this.bn.Location = new Point(275, 48);
			this.bn.Name = "label24";
			this.bn.Size = new Size(45, 13);
			this.bn.TabIndex = 7;
			this.bn.Text = "Пароль";
			this.bo.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.bo.Location = new Point(326, 45);
			this.bo.Name = "txtPwdSMTPPlanned";
			this.bo.PasswordChar = '*';
			this.bo.Size = new Size(137, 20);
			this.bo.TabIndex = 6;
			this.bp.AutoSize = true;
			this.bp.Location = new Point(6, 48);
			this.bp.Name = "label23";
			this.bp.Size = new Size(38, 13);
			this.bp.TabIndex = 5;
			this.bp.Text = "Логин";
			this.bq.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.bq.Location = new Point(80, 45);
			this.bq.Name = "txtLoginSMTPPlanned";
			this.bq.Size = new Size(189, 20);
			this.bq.TabIndex = 4;
			this.br.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.br.AutoSize = true;
			this.br.Location = new Point(346, 22);
			this.br.Name = "label22";
			this.br.Size = new Size(32, 13);
			this.br.TabIndex = 3;
			this.br.Text = "Порт";
			this.bs.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.bs.Location = new Point(384, 19);
			this.bs.Name = "txtSMTPServerPortPlanned";
			this.bs.Size = new Size(79, 20);
			this.bs.TabIndex = 2;
			this.bt.AutoSize = true;
			this.bt.Location = new Point(6, 22);
			this.bt.Name = "label21";
			this.bt.Size = new Size(74, 13);
			this.bt.TabIndex = 1;
			this.bt.Text = "Имя сервера";
			this.bu.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.bu.Location = new Point(80, 19);
			this.bu.Name = "txtSMTPServerPlanned";
			this.bu.Size = new Size(260, 20);
			this.bu.TabIndex = 0;
			this.bi.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.bi.Location = new Point(451, 27);
			this.bi.Name = "btnChoiseFileMail";
			this.bi.Size = new Size(28, 23);
			this.bi.TabIndex = 25;
			this.bi.Text = "...";
			this.bi.UseVisualStyleBackColor = true;
			this.bi.Click += this.b;
			this.bj.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.bj.Location = new Point(90, 29);
			this.bj.Name = "txtFileNameMailPlanned";
			this.bj.Size = new Size(358, 20);
			this.bj.TabIndex = 23;
			this.bk.AutoSize = true;
			this.bk.Location = new Point(7, 32);
			this.bk.Name = "label20";
			this.bk.Size = new Size(64, 13);
			this.bk.TabIndex = 24;
			this.bk.Text = "Имя файла";
			this.bl.AutoSize = true;
			this.bl.Checked = true;
			this.bl.CheckState = CheckState.Checked;
			this.bl.Location = new Point(10, 6);
			this.bl.Name = "chkUseMailPlanned";
			this.bl.Size = new Size(124, 17);
			this.bl.TabIndex = 0;
			this.bl.Text = "Включить отправку";
			this.bl.UseVisualStyleBackColor = true;
			this.bl.CheckedChanged += this.c;
			this.x.AutoSize = true;
			this.x.Location = new Point(12, 15);
			this.x.Name = "label7";
			this.x.Size = new Size(77, 13);
			this.x.TabIndex = 19;
			this.x.Text = "Путь до cURL";
			this.y.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.y.BackColor = SystemColors.Window;
			this.y.Location = new Point(95, 12);
			this.y.Name = "txtCURL";
			this.y.Size = new Size(358, 20);
			this.y.TabIndex = 20;
			this.y.Text = "\\\\ulges-fs\\software\\Ulges\\EIS\\Plugins\\curl.exe";
			this.z.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.z.Location = new Point(456, 10);
			this.z.Name = "btnChoiceCURL";
			this.z.Size = new Size(28, 23);
			this.z.TabIndex = 21;
			this.z.Text = "...";
			this.z.UseVisualStyleBackColor = true;
			this.z.Click += this.n;
			this.ci.Controls.Add(this.cj);
			this.ci.Location = new Point(4, 22);
			this.ci.Name = "tabPageRIC";
			this.ci.Padding = new Padding(3);
			this.ci.Size = new Size(490, 485);
			this.ci.TabIndex = 3;
			this.ci.Text = "РИЦ";
			this.ci.UseVisualStyleBackColor = true;
			this.cj.AutoSize = true;
			this.cj.Location = new Point(10, 16);
			this.cj.Name = "checkBoxSendRIC";
			this.cj.Size = new Size(162, 17);
			this.cj.TabIndex = 0;
			this.cj.Text = "Отправлять данные в РИЦ";
			this.cj.UseVisualStyleBackColor = true;
			base.AcceptButton = this.k;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.l;
			base.ClientSize = new Size(496, 587);
			base.Controls.Add(this.z);
			base.Controls.Add(this.y);
			base.Controls.Add(this.x);
			base.Controls.Add(this.u);
			base.Controls.Add(this.l);
			base.Controls.Add(this.k);
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new Size(500, 514);
			base.Name = "FormSettingsSender";
			this.Text = "Настройки FTP";
			base.FormClosing += this.a;
			base.Load += this.q;
			this.u.ResumeLayout(false);
			this.v.ResumeLayout(false);
			this.v.PerformLayout();
			this.ao.ResumeLayout(false);
			this.ao.PerformLayout();
			((ISupportInitialize)this.ap).EndInit();
			((ISupportInitialize)this.aq).EndInit();
			((ISupportInitialize)this.ar).EndInit();
			this.w.ResumeLayout(false);
			this.w.PerformLayout();
			this.ae.ResumeLayout(false);
			this.ae.PerformLayout();
			((ISupportInitialize)this.al).EndInit();
			((ISupportInitialize)this.am).EndInit();
			((ISupportInitialize)this.an).EndInit();
			this.bh.ResumeLayout(false);
			this.bh.PerformLayout();
			this.b1.ResumeLayout(false);
			this.b1.PerformLayout();
			((ISupportInitialize)this.b2).EndInit();
			((ISupportInitialize)this.b3).EndInit();
			((ISupportInitialize)this.b4).EndInit();
			((ISupportInitialize)this.cf).EndInit();
			this.bv.ResumeLayout(false);
			this.bv.PerformLayout();
			this.bm.ResumeLayout(false);
			this.bm.PerformLayout();
			((ISupportInitialize)this.bs).EndInit();
			this.ci.ResumeLayout(false);
			this.ci.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000198 RID: 408
		private const string a = "FTP05";

		// Token: 0x04000199 RID: 409
		private DataTable b;

		// Token: 0x0400019B RID: 411
		private TextBox d;

		// Token: 0x0400019C RID: 412
		private Label e;

		// Token: 0x0400019D RID: 413
		private TextBox f;

		// Token: 0x0400019E RID: 414
		private Label g;

		// Token: 0x0400019F RID: 415
		private Label h;

		// Token: 0x040001A0 RID: 416
		private TextBox i;

		// Token: 0x040001A1 RID: 417
		private Label j;

		// Token: 0x040001A2 RID: 418
		private Button k;

		// Token: 0x040001A3 RID: 419
		private Button l;

		// Token: 0x040001A4 RID: 420
		private MaskedTextBox m;

		// Token: 0x040001A5 RID: 421
		private CheckBox n;

		// Token: 0x040001A6 RID: 422
		private TextBox o;

		// Token: 0x040001A7 RID: 423
		private TextBox p;

		// Token: 0x040001A8 RID: 424
		private Label q;

		// Token: 0x040001A9 RID: 425
		private Label r;

		// Token: 0x040001AA RID: 426
		private MaskedTextBox s;

		// Token: 0x040001AB RID: 427
		private CheckBox t;

		// Token: 0x040001AC RID: 428
		private TabControl u;

		// Token: 0x040001AD RID: 429
		private TabPage v;

		// Token: 0x040001AE RID: 430
		private TabPage w;

		// Token: 0x040001AF RID: 431
		private Label x;

		// Token: 0x040001B0 RID: 432
		private TextBox y;

		// Token: 0x040001B1 RID: 433
		private Button z;

		// Token: 0x040001B2 RID: 434
		private Button aa;

		// Token: 0x040001B3 RID: 435
		private Label ab;

		// Token: 0x040001B4 RID: 436
		private TextBox ac;

		// Token: 0x040001B5 RID: 437
		private Button ad;

		// Token: 0x040001B6 RID: 438
		private GroupBox ae;

		// Token: 0x040001B7 RID: 439
		private RadioButton af;

		// Token: 0x040001B8 RID: 440
		private RadioButton ag;

		// Token: 0x040001B9 RID: 441
		private RadioButton ah;

		// Token: 0x040001BA RID: 442
		private Label ai;

		// Token: 0x040001BB RID: 443
		private DateTimePicker aj;

		// Token: 0x040001BC RID: 444
		private Label ak;

		// Token: 0x040001BD RID: 445
		private NumericUpDown al;

		// Token: 0x040001BE RID: 446
		private NumericUpDown am;

		// Token: 0x040001BF RID: 447
		private NumericUpDown an;

		// Token: 0x040001C0 RID: 448
		private GroupBox ao;

		// Token: 0x040001C1 RID: 449
		private NumericUpDown ap;

		// Token: 0x040001C2 RID: 450
		private NumericUpDown aq;

		// Token: 0x040001C3 RID: 451
		private NumericUpDown ar;

		// Token: 0x040001C4 RID: 452
		private RadioButton @as;

		// Token: 0x040001C5 RID: 453
		private RadioButton at;

		// Token: 0x040001C6 RID: 454
		private RadioButton au;

		// Token: 0x040001C7 RID: 455
		private Label av;

		// Token: 0x040001C8 RID: 456
		private DateTimePicker aw;

		// Token: 0x040001C9 RID: 457
		private Label ax;

		// Token: 0x040001CA RID: 458
		private Button ay;

		// Token: 0x040001CB RID: 459
		private Button az;

		// Token: 0x040001CC RID: 460
		private Label a0;

		// Token: 0x040001CD RID: 461
		private TextBox a1;

		// Token: 0x040001CE RID: 462
		private CheckBox a2;

		// Token: 0x040001CF RID: 463
		private TextBox a3;

		// Token: 0x040001D0 RID: 464
		private MaskedTextBox a4;

		// Token: 0x040001D1 RID: 465
		private Label a5;

		// Token: 0x040001D2 RID: 466
		private Label a6;

		// Token: 0x040001D3 RID: 467
		private TextBox a7;

		// Token: 0x040001D4 RID: 468
		private Label a8;

		// Token: 0x040001D5 RID: 469
		private Label a9;

		// Token: 0x040001D6 RID: 470
		private TextBox ba;

		// Token: 0x040001D7 RID: 471
		private Label bb;

		// Token: 0x040001D8 RID: 472
		private TextBox bc;

		// Token: 0x040001D9 RID: 473
		private TextBox bd;

		// Token: 0x040001DA RID: 474
		private CheckBox be;

		// Token: 0x040001DB RID: 475
		private Label bf;

		// Token: 0x040001DC RID: 476
		private MaskedTextBox bg;

		// Token: 0x040001DD RID: 477
		private TabPage bh;

		// Token: 0x040001DE RID: 478
		private Button bi;

		// Token: 0x040001DF RID: 479
		private TextBox bj;

		// Token: 0x040001E0 RID: 480
		private Label bk;

		// Token: 0x040001E1 RID: 481
		private CheckBox bl;

		// Token: 0x040001E2 RID: 482
		private GroupBox bm;

		// Token: 0x040001E3 RID: 483
		private Label bn;

		// Token: 0x040001E4 RID: 484
		private TextBox bo;

		// Token: 0x040001E5 RID: 485
		private Label bp;

		// Token: 0x040001E6 RID: 486
		private TextBox bq;

		// Token: 0x040001E7 RID: 487
		private Label br;

		// Token: 0x040001E8 RID: 488
		private NumericUpDown bs;

		// Token: 0x040001E9 RID: 489
		private Label bt;

		// Token: 0x040001EA RID: 490
		private TextBox bu;

		// Token: 0x040001EB RID: 491
		private GroupBox bv;

		// Token: 0x040001EC RID: 492
		private Label bw;

		// Token: 0x040001ED RID: 493
		private TextBox bx;

		// Token: 0x040001EE RID: 494
		private Label by;

		// Token: 0x040001EF RID: 495
		private TextBox bz;

		// Token: 0x040001F0 RID: 496
		private Label b0;

		// Token: 0x040001F1 RID: 497
		private GroupBox b1;

		// Token: 0x040001F2 RID: 498
		private NumericUpDown b2;

		// Token: 0x040001F3 RID: 499
		private NumericUpDown b3;

		// Token: 0x040001F4 RID: 500
		private NumericUpDown b4;

		// Token: 0x040001F5 RID: 501
		private RadioButton b5;

		// Token: 0x040001F6 RID: 502
		private RadioButton b6;

		// Token: 0x040001F7 RID: 503
		private RadioButton b7;

		// Token: 0x040001F8 RID: 504
		private Label b8;

		// Token: 0x040001F9 RID: 505
		private DateTimePicker b9;

		// Token: 0x040001FA RID: 506
		private Label ca;

		// Token: 0x040001FB RID: 507
		private Label cb;

		// Token: 0x040001FC RID: 508
		private TextBox cc;

		// Token: 0x040001FD RID: 509
		private Label cd;

		// Token: 0x040001FE RID: 510
		private TextBox ce;

		// Token: 0x040001FF RID: 511
		private DataGridView cf;

		// Token: 0x04000200 RID: 512
		private DataGridViewTextBoxColumn cg;

		// Token: 0x04000201 RID: 513
		private DataGridViewTextBoxColumn ch;

		// Token: 0x04000202 RID: 514
		private TabPage ci;

		// Token: 0x04000203 RID: 515
		private CheckBox cj;
	}
}
