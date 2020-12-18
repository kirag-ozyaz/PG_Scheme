using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DataSql;
using Passport.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Passport.Controls
{
	public class PanelPassport : Panel
	{
		public Color PageStartColor
		{
			get
			{
				return this.color_0;
			}
			set
			{
				this.color_0 = value;
				this.method_0();
			}
		}

		public Color PageEndColor
		{
			get
			{
				return this.color_1;
			}
			set
			{
				this.color_1 = value;
				this.method_0();
			}
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs_0)
		{
			base.OnPaint(paintEventArgs_0);
		}

		private void method_0()
		{
			LinearGradientBrush brush = new LinearGradientBrush(new Point(0, 0), new Point(0, base.Height), this.PageStartColor, this.PageEndColor);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics.FromImage(bitmap).FillRectangle(brush, new Rectangle(0, 0, base.Width, base.Height));
			this.BackgroundImage = bitmap;
			this.BackgroundImageLayout = ImageLayout.Stretch;
		}

		public PanelPassport()
		{
			this.method_3();
			this.method_0();
		}

		public void Show(SQLSettings settings, int idObjList, string ObjName)
		{
			if (settings == null)
			{
				return;
			}
			this.sqlsettings_0 = settings;
			this.method_1(idObjList, ObjName);
		}

		private void method_1(int int_2, string string_0)
		{
			try
			{
				base.Controls.Clear();
				if (this.sqlsettings_0 != null)
				{
					if (this.sqlsettings_0.Autentification == "WINDOWS")
					{
						this.sqlConnection_0 = new SqlConnection(string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", this.sqlsettings_0.ServerDB, this.sqlsettings_0.DBName));
					}
					else
					{
						this.sqlConnection_0 = new SqlConnection(string.Concat(new string[]
						{
							"Server=",
							this.sqlsettings_0.ServerDB,
							"; dataBase=",
							this.sqlsettings_0.DBName,
							"; uid=",
							this.sqlsettings_0.SqlUserConnect,
							";pwd=",
							this.sqlsettings_0.SqlPasswConnect,
							";Integrated Security=false; Connection TimeOut = 180"
						}));
					}
					this.sqlConnection_0.Open();
					DbDataAdapter dbDataAdapter = new SqlDataAdapter(new SqlCommand(string.Format("select * from vPassportPanelShowData where isActive = 1 and Deleted = 0 and idObjList = {0} and Panel = 1", int_2), this.sqlConnection_0));
					this.dataTable_0 = new DataTable();
					dbDataAdapter.Fill(this.dataTable_0);
					if (this.dataTable_0.Rows.Count > 0)
					{
						int_2 = (int)this.dataTable_0.Rows[0]["idObjList"];
						this.label_0 = new Label[this.dataTable_0.Rows.Count + 1, 2];
						for (int i = 0; i < this.dataTable_0.Rows.Count + 1; i++)
						{
							for (int j = 0; j < 2; j++)
							{
								this.label_0[i, j] = new Label();
							}
						}
						for (int k = 0; k < this.dataTable_0.Rows.Count + 1; k++)
						{
							this.label_0[k, 0].BackColor = Color.Transparent;
							this.label_0[k, 1].BackColor = Color.Transparent;
							if (k > 0)
							{
								this.label_0[k, 0].Text = this.dataTable_0.Rows[k - 1]["Char_Name"].ToString();
								this.label_0[k, 1].Text = this.dataTable_0.Rows[k - 1]["Value"].ToString();
							}
							else
							{
								this.label_0[0, 0].Text = "Наименование";
								this.label_0[0, 1].Text = this.dataTable_0.Rows[0]["PS_Name"].ToString() + " (" + this.dataTable_0.Rows[0]["idObjList"].ToString() + ")";
							}
							this.label_0[k, 0].Size = TextRenderer.MeasureText(this.label_0[k, 0].Text, this.label_0[k, 0].Font);
							this.label_0[k, 1].Size = TextRenderer.MeasureText(this.label_0[k, 1].Text, this.label_0[k, 1].Font);
							this.label_0[k, 0].Location = new Point(12, 13 + k * 23);
							this.int_1 = this.label_0[k, 0].Location.X + this.label_0[k, 0].Width + 20 + this.label_0[k, 1].Width + 12;
							if (this.int_0 < this.int_1)
							{
								this.int_0 = this.int_1;
							}
							base.Controls.AddRange(new Control[]
							{
								this.label_0[k, 0],
								this.label_0[k, 1]
							});
						}
						for (int l = 0; l < this.dataTable_0.Rows.Count + 1; l++)
						{
							this.label_0[l, 1].Location = new Point(this.int_0 - (this.label_0[l, 1].Width + 12), 13 + l * 23);
						}
						base.Width = this.int_0;
						base.Height = (this.dataTable_0.Rows.Count + 2) * 23 + 20;
						this.linkLabel_0.BackColor = Color.Transparent;
						this.linkLabel_0.Text = "Дополнительно";
						this.linkLabel_0.Size = TextRenderer.MeasureText(this.linkLabel_0.Text, this.linkLabel_0.Font);
						this.linkLabel_0.Location = new Point(base.Width - (this.linkLabel_0.Width + 13), base.Height - 26);
						this.linkLabel_0.Click -= this.linkLabel_0_Click;
						this.linkLabel_0.Click += this.linkLabel_0_Click;
						base.Controls.Add(this.linkLabel_0);
						base.Visible = true;
					}
					else
					{
						Label label = new Label();
						label.BackColor = Color.Transparent;
						label.Text = string_0;
						label.Size = TextRenderer.MeasureText(label.Text, label.Font);
						base.Width = label.Width + 2;
						base.Height = label.Height + 2;
						base.Controls.Add(label);
						base.Visible = true;
					}
					this.sqlConnection_0.Close();
				}
			}
			catch (Exception)
			{
			}
		}

		private DockPanel method_2(Control control_0)
		{
			if (control_0.GetType() == typeof(DockPanel))
			{
				return (DockPanel)control_0;
			}
			return this.method_2(control_0.Parent);
		}

		private void linkLabel_0_Click(object sender, EventArgs e)
		{
			base.Visible = false;
			new FormDockPassport(this.sqlsettings_0, (int)this.dataTable_0.Rows[0]["idObjList"]).Show(this.method_2(base.Parent));
		}

		private void PanelPassport_VisibleChanged(object sender, EventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_3()
		{
			base.SuspendLayout();
			base.BorderStyle = BorderStyle.FixedSingle;
			base.Size = new Size(264, 153);
			base.VisibleChanged += this.PanelPassport_VisibleChanged;
			base.ResumeLayout(false);
		}

		private Color color_0;

		private Color color_1;

		private SQLSettings sqlsettings_0;

		private SqlConnection sqlConnection_0;

		private DataTable dataTable_0 = new DataTable();

		private Label[,] label_0;

		private LinkLabel linkLabel_0 = new LinkLabel();

		private int int_0;

		private int int_1;

		private IContainer icontainer_0;
	}
}
