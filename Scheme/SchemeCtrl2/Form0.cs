using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using FormLbr;
using FormLbr.Classes;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Ercloud;
using SchemeCtrl2.Properties;

internal partial class Form0 : FormBase
{
	internal Form0()
	{
		
		
		this.method_12();
	}

	internal Form0(DrawObjectBase drawObjectBase_1)
	{
		
		
		this.method_12();
		this.drawObjectBase_0 = drawObjectBase_1;
		this.textBox_0.Text = drawObjectBase_1.Text;
		this.textBox_1.Text = drawObjectBase_1.IdBase.ToString();
	}

	private void Form0_Load(object sender, EventArgs e)
	{
		this.method_0();
		if (this.drawObjectBase_0 != null && this.drawObjectBase_0.IdBase > 0)
		{
			base.SelectSqlData(this.class22_0.tSchm_Ercloud, true, " where idSchmObj = " + this.drawObjectBase_0.IdBase.ToString(), null, false, 0);
			if (this.class22_0.tSchm_Ercloud.Rows.Count > 0)
			{
				int num = Convert.ToInt32(this.class22_0.tSchm_Ercloud.Rows[0]["idConnect"]);
				foreach (object obj in this.comboBox_0.Items)
				{
					if (((ErcloudConnect)obj).Id == num)
					{
						this.comboBox_0.SelectedItem = obj;
						break;
					}
				}
				int int_ = Convert.ToInt32(this.class22_0.tSchm_Ercloud.Rows[0]["idErcloudObj"]);
				List<TreeNode> list_ = new List<TreeNode>();
				list_ = this.method_9(this.treeView_0.Nodes, list_);
				TreeNode treeNode = this.method_11(list_, this.treeView_0.SelectedNode, int_, (Form0.Enum1)0);
				if (treeNode != null)
				{
					this.treeView_0.SelectedNode = null;
					this.treeView_0.SelectedNode = treeNode;
					this.treeView_0.SelectedNode.Expand();
				}
			}
		}
	}

	private void method_0()
	{
		base.SelectSqlData(this.dataTable_0, true, " where Module = 'Ercloud'", null, false, 0);
		if (this.dataTable_0.Rows.Count > 0 && this.dataTable_0.Rows[0]["Settings"] != DBNull.Value)
		{
			XmlDocument xmlDocument = new XmlDocument();
			try
			{
				xmlDocument.LoadXml(this.dataTable_0.Rows[0]["Settings"].ToString());
				this.method_1(xmlDocument);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}
	}

	private void method_1(XmlDocument xmlDocument_0)
	{
		try
		{
			XmlNode xmlNode = xmlDocument_0.SelectSingleNode("Connections");
			this.comboBox_0.Items.Clear();
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
					else if (this.comboBox_0.Items.Count > 0)
					{
						id = (from ErcloudConnect s in this.comboBox_0.Items
						select s.Id).Max() + 1;
					}
					ErcloudConnect item = new ErcloudConnect(id, xmlNode2.Attributes["Name"].Value, xmlNode2.Attributes["Address"].Value, Convert.ToInt32(xmlNode2.Attributes["Port"].Value), xmlNode2.Attributes["User"].Value, Crypt.Decrypt(xmlNode2.Attributes["Password"].Value, xmlNode2.Attributes["Name"].Value));
					this.comboBox_0.Items.Add(item);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source);
				}
			}
			if (this.comboBox_0.Items.Count > 0)
			{
				this.comboBox_0.SelectedIndex = 0;
			}
		}
		catch (Exception ex2)
		{
			MessageBox.Show(ex2.Message, ex2.Source);
		}
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.comboBox_0.SelectedIndex >= 0)
		{
			this.method_2();
		}
	}

	private void method_2()
	{
		ErcloudConnect ercloudConnect = (ErcloudConnect)this.comboBox_0.SelectedItem;
		XmlDocument xmlDocument_ = this.method_3(ercloudConnect.User, "0", "0", "4", ercloudConnect.Password);
		string string_ = this.method_7(ercloudConnect, xmlDocument_);
		this.method_4(string_);
		xmlDocument_ = this.method_3(ercloudConnect.User, "0", "0", "5", ercloudConnect.Password);
		string_ = this.method_7(ercloudConnect, xmlDocument_);
		this.method_6(string_);
	}

	private XmlDocument method_3(string string_0, string string_1, string string_2, string string_3, string string_4)
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode xmlNode = xmlDocument.CreateElement("document");
		xmlDocument.AppendChild(xmlNode);
		XmlNode xmlNode2 = xmlDocument.CreateElement("idUser");
		xmlNode2.InnerText = string_0;
		xmlNode.AppendChild(xmlNode2);
		xmlNode2 = xmlDocument.CreateElement("idDevice");
		xmlNode2.InnerText = string_1;
		xmlNode.AppendChild(xmlNode2);
		xmlNode2 = xmlDocument.CreateElement("trUniq");
		xmlNode2.InnerText = string_2;
		xmlNode.AppendChild(xmlNode2);
		xmlNode2 = xmlDocument.CreateElement("typeQuery");
		xmlNode2.InnerText = string_3;
		xmlNode.AppendChild(xmlNode2);
		string text = "";
		for (int i = 0; i < xmlNode.ChildNodes.Count; i++)
		{
			if (!string.IsNullOrEmpty(xmlNode.ChildNodes[i].InnerText))
			{
				text += xmlNode.ChildNodes[i].InnerText;
			}
		}
		text = this.method_8(text + string_4);
		xmlNode2 = xmlDocument.CreateElement("magic_word");
		xmlNode2.InnerText = text.ToUpper();
		xmlNode.AppendChild(xmlNode2);
		return xmlDocument;
	}

	private void method_4(string string_0)
	{
		try
		{
			this.treeView_0.Nodes.Clear();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(string_0);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("document");
			if (xmlNode != null)
			{
				List<Class9> list = new List<Class9>();
				foreach (object obj2 in xmlNode.SelectNodes("OBJECT"))
				{
					XmlNode xmlNode2 = (XmlNode)obj2;
					if (xmlNode2.Attributes["UID"] != null)
					{
						Class9 @class = new Class9();
						@class.Id = Convert.ToInt32(xmlNode2.Attributes["UID"].Value);
						@class.Name = xmlNode2.InnerText;
						if (xmlNode2.Attributes["UID_DIR"] != null)
						{
							@class.IdParent = new int?(Convert.ToInt32(xmlNode2.Attributes["UID_DIR"].Value));
						}
						if (!list.Contains(@class))
						{
							list.Add(@class);
						}
					}
				}
				list.Sort((Class9 first, Class9 next) => first.Name.CompareTo(next.Name));
				IEnumerable<Class9> enumerable = from obj in list
				where obj.IdParent == null || obj.IdParent == 0
				select obj;
				if (enumerable.Count<Class9>() > 0)
				{
					using (IEnumerator<Class9> enumerator2 = enumerable.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							Class9 class2 = enumerator2.Current;
							TreeNode treeNode = new TreeNode(class2.Name);
							treeNode.Name = class2.Id.ToString();
							treeNode.Tag = class2;
							this.treeView_0.Nodes.Add(treeNode);
							this.method_5(treeNode, list);
						}
						goto IL_243;
					}
				}
				foreach (Class9 class3 in list)
				{
					TreeNode treeNode2 = new TreeNode(class3.Name);
					treeNode2.Name = class3.Id.ToString();
					treeNode2.Tag = class3;
					this.treeView_0.Nodes.Add(treeNode2);
				}
			}
			IL_243:;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ex.Source);
		}
	}

	private void method_5(TreeNode treeNode_0, List<Class9> list_0)
	{
		if (treeNode_0.Tag != null && treeNode_0.Tag is Class9)
		{
			foreach (Class9 @class in from obj in list_0
			where obj.IdParent == ((Class9)treeNode_0.Tag).Id
			select obj)
			{
				TreeNode treeNode = new TreeNode(@class.Name);
				treeNode.Name = @class.Id.ToString();
				treeNode.Tag = @class;
				treeNode_0.Nodes.Add(treeNode);
				this.method_5(treeNode, list_0);
			}
		}
	}

	private void method_6(string string_0)
	{
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(string_0);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("document");
			if (xmlNode != null)
			{
				List<Class10> list = new List<Class10>();
				foreach (object obj in xmlNode.SelectNodes("PU"))
				{
					XmlNode xmlNode2 = (XmlNode)obj;
					if (xmlNode2.Attributes["UID"] != null)
					{
						Class10 @class = new Class10();
						@class.Id = Convert.ToInt32(xmlNode2.Attributes["UID"].Value);
						@class.Name = xmlNode2.InnerText;
						if (xmlNode2.Attributes["UID_OBJ"] != null)
						{
							@class.IdParent = new int?(Convert.ToInt32(xmlNode2.Attributes["UID_OBJ"].Value));
						}
						if (!list.Contains(@class))
						{
							list.Add(@class);
						}
					}
				}
				list.Sort((Class10 first, Class10 next) => first.Name.CompareTo(next.Name));
				foreach (Class10 class2 in list)
				{
					if (class2.IdParent == null)
					{
						TreeNode treeNode = new TreeNode(class2.Name);
						treeNode.Name = class2.Id.ToString();
						treeNode.Tag = class2;
						treeNode.SelectedImageKey = (treeNode.ImageKey = "counter.ico");
						this.treeView_0.Nodes.Add(treeNode);
					}
					else
					{
						TreeNode[] array = this.treeView_0.Nodes.Find(class2.IdParent.ToString(), true);
						for (int i = 0; i < array.Length; i++)
						{
							if (array[i].Tag != null && array[i].Tag is Class9)
							{
								TreeNode treeNode2 = new TreeNode(class2.Name);
								treeNode2.Name = class2.Id.ToString();
								treeNode2.Tag = class2;
								treeNode2.SelectedImageKey = (treeNode2.ImageKey = "counter.ico");
								array[i].Nodes.Add(treeNode2);
								break;
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ex.Source);
		}
	}

	private string method_7(ErcloudConnect ercloudConnect_0, XmlDocument xmlDocument_0)
	{
		string result;
		try
		{
			byte[] array = new byte[1024];
			IPAddress ipaddress = Dns.GetHostEntry("localhost").AddressList[0];
			IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(ercloudConnect_0.AddressServer), ercloudConnect_0.Port);
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			socket.Connect(remoteEP);
			byte[] bytes = Encoding.GetEncoding("windows-1251").GetBytes(xmlDocument_0.InnerXml);
			socket.Send(bytes);
			string text = "";
			int num;
			do
			{
				num = socket.Receive(array);
				text += Encoding.GetEncoding("windows-1251").GetString(array, 0, num);
			}
			while (text.IndexOf("</documnet>") < 0 && num > 0);
			result = text;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ex.Source);
			result = "";
		}
		return result;
	}

	private string method_8(string string_0)
	{
		byte[] array = MD5.Create().ComputeHash(Encoding.Default.GetBytes(string_0));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		List<TreeNode> list_ = new List<TreeNode>();
		list_ = this.method_9(this.treeView_0.Nodes, list_);
		TreeNode treeNode = this.method_10(list_, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, (Form0.Enum1)0);
		if (treeNode != null)
		{
			this.treeView_0.SelectedNode = null;
			this.treeView_0.SelectedNode = treeNode;
			this.treeView_0.SelectedNode.Expand();
		}
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		List<TreeNode> list_ = new List<TreeNode>();
		list_ = this.method_9(this.treeView_0.Nodes, list_);
		TreeNode treeNode = this.method_10(list_, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, (Form0.Enum1)2);
		if (treeNode != null)
		{
			this.treeView_0.SelectedNode = null;
			this.treeView_0.SelectedNode = treeNode;
			this.treeView_0.SelectedNode.Expand();
		}
	}

	private void toolStripButton_2_Click(object sender, EventArgs e)
	{
		List<TreeNode> list_ = new List<TreeNode>();
		list_ = this.method_9(this.treeView_0.Nodes, list_);
		TreeNode treeNode = this.method_10(list_, this.treeView_0.SelectedNode, this.toolStripTextBox_0.Text, (Form0.Enum1)1);
		if (treeNode != null)
		{
			this.treeView_0.SelectedNode = null;
			this.treeView_0.SelectedNode = treeNode;
			this.treeView_0.SelectedNode.Expand();
		}
	}

	private void toolStripTextBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Return)
		{
			Keys modifiers = e.Modifiers;
			if (modifiers == Keys.None)
			{
				this.toolStripButton_2_Click(sender, e);
				return;
			}
			if (modifiers != Keys.Shift)
			{
				return;
			}
			this.toolStripButton_1_Click(sender, e);
		}
	}

	private List<TreeNode> method_9(TreeNodeCollection treeNodeCollection_0, List<TreeNode> list_0)
	{
		foreach (object obj in treeNodeCollection_0)
		{
			TreeNode treeNode = (TreeNode)obj;
			list_0.Add(treeNode);
			list_0 = this.method_9(treeNode.Nodes, list_0);
		}
		return list_0;
	}

	private TreeNode method_10(List<TreeNode> list_0, TreeNode treeNode_0, string string_0, Form0.Enum1 enum1_0)
	{
		bool flag = enum1_0 == (Form0.Enum1)0;
		if (enum1_0 == (Form0.Enum1)2)
		{
			list_0.Reverse();
		}
		foreach (TreeNode treeNode in list_0)
		{
			if (flag && treeNode.Text.ToUpper().Contains(string_0.ToUpper()))
			{
				return treeNode;
			}
			if (treeNode == treeNode_0)
			{
				flag = true;
			}
		}
		return null;
	}

	private TreeNode method_11(List<TreeNode> list_0, TreeNode treeNode_0, int int_0, Form0.Enum1 enum1_0)
	{
		bool flag = enum1_0 == (Form0.Enum1)0;
		if (enum1_0 == (Form0.Enum1)2)
		{
			list_0.Reverse();
		}
		foreach (TreeNode treeNode in list_0)
		{
			if (flag && treeNode.Tag != null && treeNode.Tag is Class10 && ((Class10)treeNode.Tag).Id == int_0)
			{
				return treeNode;
			}
			if (treeNode == treeNode_0)
			{
				flag = true;
			}
		}
		return null;
	}

	private void treeView_0_AfterSelect(object sender, TreeViewEventArgs e)
	{
		if (this.treeView_0.SelectedNode != null && this.treeView_0.SelectedNode.Tag != null && this.treeView_0.SelectedNode.Tag is Class10)
		{
			this.textBox_2.Text = this.treeView_0.SelectedNode.Text;
			this.nullable_0 = new int?(((Class10)this.treeView_0.SelectedNode.Tag).Id);
			return;
		}
		this.textBox_2.Text = "";
		this.nullable_0 = null;
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		if (this.drawObjectBase_0 == null || this.drawObjectBase_0.IdBase <= 0)
		{
			base.Close();
			return;
		}
		if (this.comboBox_0.SelectedIndex < 0)
		{
			MessageBox.Show("Не выбран сервер для подключения к АСКУЭ");
			return;
		}
		if (this.nullable_0 == null)
		{
			MessageBox.Show("Не выбран прибор учета");
			return;
		}
		base.SelectSqlData(this.class22_0.tSchm_Ercloud, true, " where idSchmObj = " + this.drawObjectBase_0.IdBase.ToString(), null, false, 0);
		if (this.class22_0.tSchm_Ercloud.Rows.Count == 0)
		{
			DataRow dataRow = this.class22_0.tSchm_Ercloud.NewRow();
			dataRow["idSchmObj"] = this.drawObjectBase_0.IdBase;
			dataRow["idErcloudObj"] = this.nullable_0;
			dataRow["idConnect"] = ((ErcloudConnect)this.comboBox_0.SelectedItem).Id;
			this.class22_0.tSchm_Ercloud.Rows.Add(dataRow);
			if (base.InsertSqlData(this.class22_0.tSchm_Ercloud))
			{
				MessageBox.Show("Объект успешно привязан");
			}
		}
		else
		{
			this.class22_0.tSchm_Ercloud.Rows[0]["idSchmObj"] = this.drawObjectBase_0.IdBase;
			this.class22_0.tSchm_Ercloud.Rows[0]["idErcloudObj"] = this.nullable_0;
			this.class22_0.tSchm_Ercloud.Rows[0]["idConnect"] = ((ErcloudConnect)this.comboBox_0.SelectedItem).Id;
			this.class22_0.tSchm_Ercloud.Rows[0].EndEdit();
			if (base.UpdateSqlData(this.class22_0.tSchm_Ercloud))
			{
				MessageBox.Show("Объект успешно привязан");
			}
		}
		base.Close();
	}

	private void method_12()
	{
		this.icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form0));
		this.label_0 = new Label();
		this.textBox_0 = new TextBox();
		this.label_1 = new Label();
		this.textBox_1 = new TextBox();
		this.label_2 = new Label();
		this.comboBox_0 = new ComboBox();
		this.dataSet_0 = new DataSet();
		this.dataTable_0 = new DataTable();
		this.dataColumn_0 = new DataColumn();
		this.dataColumn_1 = new DataColumn();
		this.dataColumn_2 = new DataColumn();
		this.treeView_0 = new TreeView();
		this.imageList_0 = new ImageList(this.icontainer_0);
		this.toolStrip_0 = new ToolStrip();
		this.toolStripButton_0 = new ToolStripButton();
		this.toolStripTextBox_0 = new ToolStripTextBox();
		this.toolStripButton_1 = new ToolStripButton();
		this.toolStripButton_2 = new ToolStripButton();
		this.label_3 = new Label();
		this.textBox_2 = new TextBox();
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.class22_0 = new DataSetScheme();
		((ISupportInitialize)this.dataSet_0).BeginInit();
		((ISupportInitialize)this.dataTable_0).BeginInit();
		this.toolStrip_0.SuspendLayout();
		((ISupportInitialize)this.class22_0).BeginInit();
		base.SuspendLayout();
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(12, 9);
		this.label_0.Name = "label1";
		this.label_0.Size = new Size(74, 13);
		this.label_0.TabIndex = 0;
		this.label_0.Text = "Имя объекта";
		this.textBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.textBox_0.Location = new Point(12, 25);
		this.textBox_0.Name = "txtNameSchmObj";
		this.textBox_0.ReadOnly = true;
		this.textBox_0.Size = new Size(500, 20);
		this.textBox_0.TabIndex = 1;
		this.label_1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.label_1.AutoSize = true;
		this.label_1.Location = new Point(527, 9);
		this.label_1.Name = "label2";
		this.label_1.Size = new Size(61, 13);
		this.label_1.TabIndex = 2;
		this.label_1.Text = "Id объекта";
		this.textBox_1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		this.textBox_1.Location = new Point(530, 25);
		this.textBox_1.Name = "txtIdSchmObj";
		this.textBox_1.ReadOnly = true;
		this.textBox_1.Size = new Size(84, 20);
		this.textBox_1.TabIndex = 3;
		this.label_2.AutoSize = true;
		this.label_2.Location = new Point(12, 48);
		this.label_2.Name = "label3";
		this.label_2.Size = new Size(162, 13);
		this.label_2.TabIndex = 4;
		this.label_2.Text = "Сервер подключения к АСКУЭ";
		this.comboBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.comboBox_0.FormattingEnabled = true;
		this.comboBox_0.Location = new Point(12, 64);
		this.comboBox_0.Name = "cmbServerErcloud";
		this.comboBox_0.Size = new Size(602, 21);
		this.comboBox_0.TabIndex = 5;
		this.comboBox_0.SelectedIndexChanged += this.comboBox_0_SelectedIndexChanged;
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
		this.treeView_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.treeView_0.HideSelection = false;
		this.treeView_0.ImageIndex = 0;
		this.treeView_0.ImageList = this.imageList_0;
		this.treeView_0.Location = new Point(12, 116);
		this.treeView_0.Name = "treeViewCounters";
		this.treeView_0.SelectedImageIndex = 0;
		this.treeView_0.Size = new Size(602, 200);
		this.treeView_0.TabIndex = 7;
		this.treeView_0.AfterSelect += this.treeView_0_AfterSelect;
		this.imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListTree.ImageStream");
		this.imageList_0.TransparentColor = Color.Transparent;
		this.imageList_0.Images.SetKeyName(0, "FolderYellow.ico");
		this.imageList_0.Images.SetKeyName(1, "Counter.ico");
		this.toolStrip_0.Dock = DockStyle.None;
		this.toolStrip_0.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_0,
			this.toolStripTextBox_0,
			this.toolStripButton_1,
			this.toolStripButton_2
		});
		this.toolStrip_0.Location = new Point(12, 88);
		this.toolStrip_0.Name = "toolStrip1";
		this.toolStrip_0.Size = new Size(283, 25);
		this.toolStrip_0.TabIndex = 8;
		this.toolStrip_0.Text = "toolStrip1";
		this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_0.Image = Resources.Find;
		this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_0.Name = "toolBtnFind";
		this.toolStripButton_0.Size = new Size(23, 22);
		this.toolStripButton_0.Text = "toolStripButton1";
		this.toolStripButton_0.Click += this.toolStripButton_0_Click;
		this.toolStripTextBox_0.Name = "txtFind";
		this.toolStripTextBox_0.Size = new Size(200, 25);
		this.toolStripTextBox_0.KeyDown += this.toolStripTextBox_0_KeyDown;
		this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_1.Image = Resources.FindPrev;
		this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_1.Name = "toolBtnFindPrev";
		this.toolStripButton_1.Size = new Size(23, 22);
		this.toolStripButton_1.Text = "toolStripButton2";
		this.toolStripButton_1.Click += this.toolStripButton_1_Click;
		this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_2.Image = Resources.FindNext;
		this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_2.Name = "toolBtnFindNext";
		this.toolStripButton_2.Size = new Size(23, 22);
		this.toolStripButton_2.Text = "toolStripButton3";
		this.toolStripButton_2.Click += this.toolStripButton_2_Click;
		this.label_3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.label_3.AutoSize = true;
		this.label_3.Location = new Point(12, 319);
		this.label_3.Name = "label4";
		this.label_3.Size = new Size(135, 13);
		this.label_3.TabIndex = 9;
		this.label_3.Text = "Выбранный прибор учета";
		this.textBox_2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.textBox_2.BackColor = SystemColors.Window;
		this.textBox_2.Location = new Point(12, 335);
		this.textBox_2.Name = "txtSelectedDevice";
		this.textBox_2.ReadOnly = true;
		this.textBox_2.Size = new Size(602, 20);
		this.textBox_2.TabIndex = 10;
		this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.button_0.Location = new Point(12, 363);
		this.button_0.Name = "buttonApply";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 11;
		this.button_0.Text = "Привязать";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_0.Click += this.button_0_Click;
		this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_1.Location = new Point(539, 363);
		this.button_1.Name = "buttonClose";
		this.button_1.Size = new Size(75, 23);
		this.button_1.TabIndex = 12;
		this.button_1.Text = "Закрыть";
		this.button_1.UseVisualStyleBackColor = true;
		this.button_1.Click += this.button_1_Click;
		this.class22_0.DataSetName = "DataSetScheme";
		this.class22_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(626, 398);
		base.Controls.Add(this.button_1);
		base.Controls.Add(this.button_0);
		base.Controls.Add(this.textBox_2);
		base.Controls.Add(this.label_3);
		base.Controls.Add(this.toolStrip_0);
		base.Controls.Add(this.treeView_0);
		base.Controls.Add(this.comboBox_0);
		base.Controls.Add(this.label_2);
		base.Controls.Add(this.textBox_1);
		base.Controls.Add(this.label_1);
		base.Controls.Add(this.textBox_0);
		base.Controls.Add(this.label_0);
		base.Name = "FormSwitchLinkErcloud";
		this.Text = "Привязка объекта к АСКУЭ";
		base.Load += this.Form0_Load;
		((ISupportInitialize)this.dataSet_0).EndInit();
		((ISupportInitialize)this.dataTable_0).EndInit();
		this.toolStrip_0.ResumeLayout(false);
		this.toolStrip_0.PerformLayout();
		((ISupportInitialize)this.class22_0).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	private DrawObjectBase drawObjectBase_0;

	private int? nullable_0;

	private Label label_0;

	private TextBox textBox_0;

	private Label label_1;

	private TextBox textBox_1;

	private Label label_2;

	private ComboBox comboBox_0;

	private DataSet dataSet_0;

	private DataTable dataTable_0;

	private DataColumn dataColumn_0;

	private DataColumn dataColumn_1;

	private DataColumn dataColumn_2;

	private TreeView treeView_0;

	private ImageList imageList_0;

	private ToolStrip toolStrip_0;

	private ToolStripButton toolStripButton_0;

	private ToolStripTextBox toolStripTextBox_0;

	private ToolStripButton toolStripButton_1;

	private ToolStripButton toolStripButton_2;

	private Label label_3;

	private TextBox textBox_2;

	private Button button_0;

	private Button button_1;

	private DataSetScheme class22_0;

	private enum Enum1
	{

	}
}
