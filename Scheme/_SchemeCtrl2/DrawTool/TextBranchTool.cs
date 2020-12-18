using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using DataSql;
using netDxf;
using netDxf.Entities;
using netDxf.Tables;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.Data;
using SchemeCtrl2.DrawTool.FormsObj;

namespace SchemeCtrl2.DrawTool
{
	public class TextBranchTool : DrawObjectBase
	{
		public override int IdBase
		{
			get
			{
				return -1;
			}
			set
			{
				base.IdBase = value;
			}
		}

		public UnitPoint Location
		{
			get
			{
				if (this.Parent != null)
				{
					return new UnitPoint(this.method_11().Point);
				}
				return new UnitPoint(0.0, 0.0);
			}
		}

		public bool Direct
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		public float Delta
		{
			get
			{
				return this.float_0;
			}
			set
			{
				this.float_0 = value;
			}
		}

		public override Color Color
		{
			get
			{
				if (this.Layer != null && this.Layer.Parent != null && base.UseSettingColor)
				{
					return this.Layer.Parent.Settings.TextBranchColor;
				}
				return base.Color;
			}
			set
			{
				base.Color = value;
			}
		}

		public override TextFont TextProperty
		{
			get
			{
				if (this.Layer != null && base.UseSettingsText)
				{
					TextFont textPropertyTextBranch = this.Layer.Parent.Settings.TextPropertyTextBranch;
					base.TextProperty = new TextFont(textPropertyTextBranch.FontName, textPropertyTextBranch.FontSize, textPropertyTextBranch.FontBold, textPropertyTextBranch.FontItalic, textPropertyTextBranch.FontUnderline, base.TextProperty.Position, base.TextProperty.FontVirtical, base.TextProperty.Visible, textPropertyTextBranch.Color);
					return base.TextProperty;
				}
				return base.TextProperty;
			}
			set
			{
				base.TextProperty = value;
			}
		}

		public eTextBranchType Type
		{
			get
			{
				return this.eTextBranchType_0;
			}
			set
			{
				this.eTextBranchType_0 = value;
			}
		}

		public int CabSectionId { get; set; }

		public bool Passport { get; set; }

		public TextBranchTool()
		{
			this.TextProperty.Position = ePositionText.T;
		}

		private void method_6(object sender, EventArgs e)
		{
			if (this.Layer != null && this.Layer.Parent != null)
			{
				this.Layer.Parent.CopySelectedObjects();
			}
		}

		private void method_7(object sender, EventArgs e)
		{
			CanvasControl canvasControl = null;
			if (this.Layer != null && this.Layer.Parent != null)
			{
				canvasControl = this.Layer.Parent;
			}
			this.Remove(false, true);
			if (canvasControl != null)
			{
				canvasControl.DoInvalidate(true);
			}
		}

		private void method_8(object sender, EventArgs e)
		{
			this.ShowPropertyForm(((ToolStripMenuItem)sender).GetCurrentParent().Location);
		}

		public void UpdateSQLFields()
		{
			this.UpdateSQLFields(this.Layer.Parent.SqlSettings);
		}

		public void UpdateSQLFields(SQLSettings settings)
		{
			DataSetScheme dataSetScheme = new DataSetScheme();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(settings);
			string text = string.Empty;
			LineTool lineTool = (LineTool)this.Parent.Parent;
			SqlConnection sqlConnection = new SqlConnection(settings.GetConnectionString());
			string cmdText = "select top 1 id from tP_Passport where idObjList = " + lineTool.IdBase.ToString();
			SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
			try
			{
				sqlConnection.Open();
				int num = (int)sqlCommand.ExecuteScalar();
				if (num > -1)
				{
					sqlCommand.CommandText = "select top 1 Value from tP_ObjectChar where idObjChar = 182 and idPassport = " + num.ToString();
					text = sqlCommand.ExecuteScalar().ToString();
				}
			}
			catch
			{
			}
			sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.vSchm_CabSection, true, "where [idObjList] = " + lineTool.IdBase.ToString());
			if (lineTool.CouplingRelations.Count == 1)
			{
				decimal d = 0m;
				decimal num2 = 0m;
				DataRow dataRow = null;
				foreach (object obj in dataSetScheme.vSchm_CabSection.Rows)
				{
					DataRow dataRow2 = (DataRow)obj;
					num2 += Convert.ToDecimal(dataRow2[8]);
					if (dataRow == null && Convert.ToDecimal(dataRow2[8]) >= 10m)
					{
						d = Convert.ToDecimal(dataRow2[7]);
						dataRow = dataRow2;
					}
					else if (Convert.ToDecimal(dataRow2[7]) < d && Convert.ToDecimal(dataRow2[8]) >= 10m)
					{
						d = Convert.ToDecimal(dataRow2[7]);
						dataRow = dataRow2;
					}
				}
				if (dataRow != null)
				{
					if (text == string.Empty)
					{
						text = Math.Round(Convert.ToDecimal(num2), 0).ToString();
					}
					this.UpdateSQLFields(dataRow, text);
					return;
				}
			}
			else
			{
				CouplingRelation couplingRelation = ((Branch)this.Parent).CouplingRelation;
				if (couplingRelation.Vertex1.Tag != null)
				{
					object tag = couplingRelation.Vertex2.Tag;
				}
			}
		}

		public void UpdateSQLFields(DataRow dataRow_0, string length)
		{
			this.string_0 = dataRow_0[4].ToString();
			this.string_1 = Math.Round(Convert.ToDecimal(dataRow_0[5]), 0).ToString();
			this.string_2 = dataRow_0[6].ToString();
			this.string_3 = Math.Round(Convert.ToDecimal(dataRow_0[7]), 0).ToString();
			this.string_4 = length;
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			return new TextBranchTool
			{
				Direct = this.Direct,
				Delta = this.Delta,
				Type = this.Type,
				TextProperty = new TextFont(this.TextProperty.FontName, this.TextProperty.FontSize, this.TextProperty.FontBold, this.TextProperty.FontItalic, this.TextProperty.FontUnderline, this.TextProperty.Position, this.TextProperty.FontVirtical, this.TextProperty.Visible, this.TextProperty.Color),
				Text = this.Text
			};
		}

		public override void ExportDXF(CanvasControl canvas, DxfDocument document)
		{
			double num = 1.5;
			if (this.Visible)
			{
				Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style);
				SizeF sizeF = canvas.Graphics.MeasureString(this.Text[0].ToString(), font);
				this.sizeF_0 = new SizeF((float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Width), (float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Height));
				string text = (this.Text.IndexOf('\n') < 0) ? this.Text : this.Text.Substring(0, this.Text.IndexOf('\n'));
				Text text2 = new Text(text, new Vector2(this.Location.X, this.Location.Y), (double)this.sizeF_0.Height / num);
				text2.Color = new AciColor(this.Color);
				text2.Style = new TextStyle(this.TextProperty.FontName);
				float num2 = this.method_10();
				float num3 = this.bool_0 ? num2 : (num2 - 180f);
				text2.Rotation = (double)num3;
				document.AddEntity(text2);
			}
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			if (!this.Visible)
			{
				return;
			}
			if (this.Parent != null && this.Parent.GetType() == typeof(Branch))
			{
				if (base.UseSettingsText && this.TextProperty.FontSize * canvas.Zoom <= canvas.Settings.FontSizeNoVisible)
				{
					return;
				}
				using (Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style))
				{
					if ((double)font.Size >= 0.1)
					{
						SizeF sizeF = canvas.Graphics.MeasureString(this.Text, font);
						this.sizeF_0 = new SizeF((float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Width), (float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Height));
						if (this.sizeF_0.Width > 0f && this.sizeF_0.Height > 0f)
						{
							float num = this.method_10();
							using (SolidBrush solidBrush = new SolidBrush(this.Color))
							{
								if ((drawMode & eDrawMode.Print) == eDrawMode.Print)
								{
									if ((drawMode & eDrawMode.Color) != eDrawMode.Color)
									{
										solidBrush.Color = Color.Black;
									}
									else if (canvas.Settings.BackgroundColor.ToArgb() == this.Color.ToArgb() && this.Color.ToArgb() == Color.White.ToArgb())
									{
										solidBrush.Color = Color.Black;
									}
								}
								else if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
								{
									if (this.Selected)
									{
										solidBrush.Color = this.SelectedColor;
									}
								}
								else if (this.Selected)
								{
									solidBrush.Color = Color.Gray;
								}
								PointF point = ConvertCanvas.ConvertToScreen(canvas, this.Location);
								GraphicsState gstate = canvas.Graphics.Save();
								Matrix transform = canvas.Graphics.Transform;
								float angle = this.bool_0 ? (-num) : (-num + 180f);
								transform.RotateAt(angle, point, MatrixOrder.Append);
								canvas.Graphics.Transform = transform;
								canvas.Graphics.DrawString(this.Text, font, solidBrush, point);
								canvas.Graphics.Restore(gstate);
							}
							if (this.Selected && (drawMode & eDrawMode.Print) != eDrawMode.Print)
							{
								this.method_12();
								PointF[] points = ConvertCanvas.ConvertToScreen(canvas, this.unitPoint_0);
								canvas.Graphics.DrawPolygon(new Pen(Color.LightGreen), points);
							}
						}
					}
				}
			}
		}

		public override void DrawPrint(CanvasControl canvas, Graphics graphics_0, bool isColor = false)
		{
			if (this.Parent != null && this.Parent.GetType() == typeof(Branch))
			{
				if (!this.Visible)
				{
					return;
				}
				Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style);
				SizeF sizeF = canvas.Graphics.MeasureString(this.Text, font);
				this.sizeF_0 = new SizeF((float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Width), (float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Height));
				float num = this.method_10();
				SolidBrush brush;
				if (isColor)
				{
					brush = new SolidBrush((this.Color == Color.White) ? Color.Black : this.Color);
				}
				else
				{
					brush = new SolidBrush(Color.Black);
				}
				PointF point = ConvertCanvas.ConvertToScreen(canvas, this.Location);
				GraphicsState gstate = graphics_0.Save();
				Matrix transform = graphics_0.Transform;
				float angle = this.bool_0 ? (-num) : (-num + 180f);
				transform.RotateAt(angle, point, MatrixOrder.Append);
				graphics_0.Transform = transform;
				graphics_0.DrawString(this.Text, font, brush, point);
				graphics_0.Restore(gstate);
				font.Dispose();
			}
		}

		public override bool ObjectInRectangle(CanvasControl canvas, RectangleF rect, bool anyPoint)
		{
			if (this.Parent != null && this.Parent.GetType() == typeof(Branch))
			{
				this.method_12();
				ConvertCanvas.ConvertToScreen(canvas, this.unitPoint_0);
				return Class88.smethod_1(this.unitPoint_0, rect);
			}
			return false;
		}

		public override RectangleF GetBoundingRect(CanvasControl canvas, bool inflate)
		{
			if (this.Parent != null && this.Parent.GetType() == typeof(Branch))
			{
				this.method_12();
				IEnumerable<UnitPoint> source = this.unitPoint_0;
				if (TextBranchTool.func_0 == null)
				{
					TextBranchTool.func_0 = new Func<UnitPoint, double>(TextBranchTool.smethod_0);
				}
				double num = source.Min(TextBranchTool.func_0);
				IEnumerable<UnitPoint> source2 = this.unitPoint_0;
				if (TextBranchTool.func_1 == null)
				{
					TextBranchTool.func_1 = new Func<UnitPoint, double>(TextBranchTool.smethod_1);
				}
				double num2 = source2.Min(TextBranchTool.func_1);
				IEnumerable<UnitPoint> source3 = this.unitPoint_0;
				if (TextBranchTool.func_2 == null)
				{
					TextBranchTool.func_2 = new Func<UnitPoint, double>(TextBranchTool.smethod_2);
				}
				double num3 = source3.Max(TextBranchTool.func_2);
				IEnumerable<UnitPoint> source4 = this.unitPoint_0;
				if (TextBranchTool.func_3 == null)
				{
					TextBranchTool.func_3 = new Func<UnitPoint, double>(TextBranchTool.smethod_3);
				}
				double num4 = source4.Max(TextBranchTool.func_3);
				RectangleF result = new RectangleF((float)num, (float)num2, (float)num3 - (float)num, (float)num4 - (float)num2);
				if (inflate)
				{
					float num5 = base.ThresholdWidth(canvas, base.Width);
					result.Inflate(num5, num5);
				}
				return result;
			}
			return RectangleF.Empty;
		}

		public override bool PointInObject(UnitPoint point)
		{
			if (this.Layer == null)
			{
				return false;
			}
			CanvasControl parent = this.Layer.Parent;
			if (this.Parent != null && this.Parent.GetType() == typeof(Branch))
			{
				parent.Graphics = Graphics.FromHwnd(parent.Handle);
				Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * parent.Zoom, this.TextProperty.Font.Style);
				SizeF sizeF = parent.Graphics.MeasureString(this.Text, font);
				font.Dispose();
				this.sizeF_0 = new SizeF((float)ConvertCanvas.ConvertToUnit(parent, sizeF.Width), (float)ConvertCanvas.ConvertToUnit(parent, sizeF.Height));
				this.method_12();
				return Class88.smethod_9(point, this.unitPoint_0);
			}
			return false;
		}

		public override bool Visible
		{
			get
			{
				if (this.Passport)
				{
					return this.Layer.Parent.LineInformationVisible && this.Text != string.Empty && base.Visible;
				}
				return base.Visible;
			}
			set
			{
				base.Visible = value;
			}
		}

		public override string Text
		{
			get
			{
				if (this.Passport)
				{
					string text = string.Empty;
					if (this.Layer != null)
					{
						if (this.Layer.Parent.Settings.VisibleCableMakeup && this.string_0 != string.Empty)
						{
							if (text.Length > 0)
							{
								text += "; ";
							}
							text += this.string_0;
						}
						if (this.Layer.Parent.Settings.VisibleCableVoltage && this.string_1 != string.Empty)
						{
							if (text.Length > 0)
							{
								text += "; ";
							}
							text += this.string_1;
						}
						if (this.Layer.Parent.Settings.VisibleCableWires && this.string_2 != string.Empty)
						{
							if (text.Length > 0)
							{
								text += "; ";
							}
							text += this.string_2;
						}
						if (this.Layer.Parent.Settings.VisibleCableCrossSection && this.string_3 != string.Empty)
						{
							if (text.Length > 0)
							{
								text += "; ";
							}
							text += this.string_3;
						}
						if (this.Layer.Parent.Settings.VisibleCableLength && this.string_4 != string.Empty)
						{
							if (text.Length > 0)
							{
								text += "; ";
							}
							text += this.string_4;
						}
						if (this.passportDataRow != null)
						{
							foreach (PropertyFromBaseElement propertyFromBaseElement in this.Layer.Parent.Settings.LinePassportProperty)
							{
								if (Convert.ToBoolean(propertyFromBaseElement.Value))
								{
									text = text + "; " + this.passportDataRow[propertyFromBaseElement.Name];
								}
							}
						}
					}
					return text;
				}
				return base.Text;
			}
			set
			{
				base.Text = value;
			}
		}

		public override string GetUpdateScriptXML(bool children, List<int> list_1)
		{
			return this.Parent.Parent.GetUpdateScriptXML(children, list_1);
		}

		protected override bool SaveToSql()
		{
			return true;
		}

		public override bool SaveToSql(bool isbackground, bool children)
		{
			if (this.Parent != null && this.Parent.Parent != null)
			{
				this.Parent.Parent.SaveXmlToSql();
			}
			return true;
		}

		public override void SaveToXML(XmlNode xmlNode, List<PointTool> pointList)
		{
			XmlDocument ownerDocument = xmlNode.OwnerDocument;
			XmlElement xmlElement = ownerDocument.CreateElement("TextBranch");
			xmlElement.SetAttribute("ID", this.IdBase.ToString());
			xmlElement.SetAttribute("Text", this.Text);
			xmlElement.SetAttribute("Direct", this.Direct.ToString());
			xmlElement.SetAttribute("TextPos", ((int)this.TextProperty.Position).ToString());
			xmlElement.SetAttribute("TextBranchPos", this.Delta.ToString());
			xmlNode.AppendChild(xmlElement);
		}

		public override void Move(UnitPoint offset, bool selectedMove)
		{
			if (!this.Parent.Selected)
			{
				UnitPoint unitPoint = new UnitPoint(((Branch)this.Parent).Source.Point.X + (((Branch)this.Parent).Destination.Point.X - ((Branch)this.Parent).Source.Point.X) * (double)this.float_0, ((Branch)this.Parent).Source.Point.Y + (((Branch)this.Parent).Destination.Point.Y - ((Branch)this.Parent).Source.Point.Y) * (double)this.float_0);
				UnitPoint unitPoint_ = new UnitPoint(unitPoint.X + offset.X, unitPoint.Y + offset.Y);
				UnitPoint unitPoint2 = Class88.smethod_5(((Branch)this.Parent).Source.Point, ((Branch)this.Parent).Destination.Point, unitPoint_);
				PointTool pointTool = this.method_9(unitPoint2, (Branch)this.Parent);
				if (pointTool != null)
				{
					Dictionary<Branch, UnitPoint> dictionary = new Dictionary<Branch, UnitPoint>();
					foreach (Branch branch in pointTool.Branches)
					{
						if (branch != this.Parent && branch.Parent != null && branch.Parent == this.Parent.Parent && (branch.CouplingRelation == ((Branch)this.Parent).CouplingRelation || !this.Parent.Parent.LimitedEditing))
						{
							UnitPoint unitPoint3 = Class88.smethod_5(branch.Source.Point, branch.Destination.Point, unitPoint_);
							if (this.method_9(unitPoint3, branch) == null)
							{
								dictionary.Add(branch, unitPoint3);
							}
						}
					}
					if (dictionary.Count < 1)
					{
						unitPoint2 = pointTool.Point;
					}
					else if (dictionary.Count == 1)
					{
						Branch branch2 = dictionary.Keys.First<Branch>();
						UnitPoint unitPoint4 = dictionary[branch2];
						this.ChangeBranch(branch2);
						unitPoint2 = unitPoint4;
					}
					else
					{
						Branch branch3 = dictionary.Keys.First<Branch>();
						UnitPoint unitPoint5 = dictionary[branch3];
						foreach (Branch branch4 in dictionary.Keys)
						{
							double num = Math.Abs(unitPoint_.X - unitPoint5.X);
							double num2 = Math.Abs(unitPoint_.Y - unitPoint5.Y);
							double num3 = Math.Abs(unitPoint_.X - dictionary[branch4].X);
							double num4 = Math.Abs(unitPoint_.Y - dictionary[branch4].Y);
							if (num + num2 > num3 + num4)
							{
								branch3 = branch4;
								unitPoint5 = dictionary[branch4];
							}
							this.ChangeBranch(branch3);
							unitPoint2 = unitPoint5;
						}
					}
				}
				unitPoint = unitPoint2;
				this.float_0 = (float)Math.Sqrt(Math.Pow(((Branch)this.Parent).Source.Point.X - unitPoint.X, 2.0) + Math.Pow(((Branch)this.Parent).Source.Point.Y - unitPoint.Y, 2.0)) / (float)Math.Sqrt(Math.Pow(((Branch)this.Parent).Source.Point.X - ((Branch)this.Parent).Destination.Point.X, 2.0) + Math.Pow(((Branch)this.Parent).Source.Point.Y - ((Branch)this.Parent).Destination.Point.Y, 2.0));
			}
		}

		private PointTool method_9(UnitPoint unitPoint_1, Branch branch_0)
		{
			PointTool pointTool = (branch_0.Source.Point.X >= branch_0.Destination.Point.X) ? branch_0.Source : branch_0.Destination;
			PointTool pointTool2 = (branch_0.Source.Point.X < branch_0.Destination.Point.X) ? branch_0.Source : branch_0.Destination;
			PointTool pointTool3 = (branch_0.Source.Point.Y >= branch_0.Destination.Point.Y) ? branch_0.Source : branch_0.Destination;
			PointTool pointTool4 = (branch_0.Source.Point.Y < branch_0.Destination.Point.Y) ? branch_0.Source : branch_0.Destination;
			if (unitPoint_1.X > pointTool.Point.X)
			{
				return pointTool;
			}
			if (unitPoint_1.X < pointTool2.Point.X)
			{
				return pointTool2;
			}
			if (unitPoint_1.Y > pointTool3.Point.Y)
			{
				return pointTool3;
			}
			if (unitPoint_1.Y < pointTool4.Point.Y)
			{
				return pointTool4;
			}
			return null;
		}

		public void ChangeBranch(Branch branch)
		{
			Branch branch2 = (Branch)this.Parent;
			this.Parent = branch;
		}

		public override void Remove(bool delSql, bool parentNULL)
		{
			LineTool lineTool = null;
			if (this.Parent != null && this.Parent.Parent != null && (this.Parent.Parent is LineTool || this.Parent.Parent is LineCellTool))
			{
				lineTool = (LineTool)this.Parent.Parent;
			}
			base.Remove(delSql, parentNULL);
			if (lineTool != null)
			{
				lineTool.SaveXmlToSql();
			}
		}

		public override bool ShowPropertyForm(Point location)
		{
			FormTextBranchProperties formTextBranchProperties = new FormTextBranchProperties(this);
			if (formTextBranchProperties.ShowDialog() == DialogResult.OK)
			{
				this.Layer.Parent.DoInvalidate(true);
				return true;
			}
			return false;
		}

		private float method_10()
		{
			if (this.Parent == null || this.Parent.GetType() != typeof(Branch))
			{
				return float.NaN;
			}
			Branch branch = (Branch)this.Parent;
			if (branch.Source.Point.X == branch.Destination.Point.X)
			{
				return -90f;
			}
			if (branch.Source.Point.Y == branch.Destination.Point.Y)
			{
				return 0f;
			}
			float num = (float)(branch.Source.Point.Y - branch.Destination.Point.Y);
			float num2 = (float)(branch.Source.Point.X - branch.Destination.Point.X);
			float num3 = (float)Math.Atan2((double)num, (double)num2);
			return num3 * 180f / 3.14159274f;
		}

		private UnitPoint method_11()
		{
			if (this.Parent == null)
			{
				return UnitPoint.Empty;
			}
			UnitPoint unitPoint = new UnitPoint(((Branch)this.Parent).Destination.Point.Point);
			UnitPoint unitPoint2 = new UnitPoint(((Branch)this.Parent).Source.Point.Point);
			UnitPoint result = unitPoint2;
			float num = this.method_10();
			if (this.TextProperty.Position == ePositionText.T)
			{
				if (this.bool_0)
				{
					if (num >= -90f && num <= 90f)
					{
						result.X = result.X + (unitPoint.X - unitPoint2.X) * (double)this.float_0 - (double)this.sizeF_0.Height * Math.Sin((double)(num / 180f) * 3.1415926535897931) - (double)(this.sizeF_0.Width / 2f) * Math.Cos((double)(num / 180f) * 3.1415926535897931);
						result.Y = result.Y + (unitPoint.Y - unitPoint2.Y) * (double)this.float_0 + (double)this.sizeF_0.Height * Math.Cos((double)(num / 180f) * 3.1415926535897931) - (double)(this.sizeF_0.Width / 2f) * Math.Sin((double)(num / 180f) * 3.1415926535897931);
					}
					else
					{
						result.X = result.X + (unitPoint.X - unitPoint2.X) * (double)this.float_0 - (double)(this.sizeF_0.Width / 2f) * Math.Cos((double)(num / 180f) * 3.1415926535897931);
						result.Y = result.Y + (unitPoint.Y - unitPoint2.Y) * (double)this.float_0 - (double)(this.sizeF_0.Width / 2f) * Math.Sin((double)(num / 180f) * 3.1415926535897931);
					}
				}
				else if (num <= 90f && num >= -90f)
				{
					result.X = result.X + (unitPoint.X - unitPoint2.X) * (double)this.float_0 + (double)(this.sizeF_0.Width / 2f) * Math.Cos((double)(num / 180f) * 3.1415926535897931);
					result.Y = result.Y + (unitPoint.Y - unitPoint2.Y) * (double)this.float_0 + (double)(this.sizeF_0.Width / 2f) * Math.Sin((double)(num / 180f) * 3.1415926535897931);
				}
				else
				{
					result.X = result.X + (unitPoint.X - unitPoint2.X) * (double)this.float_0 + (double)this.sizeF_0.Height * Math.Sin((double)(num / 180f) * 3.1415926535897931) + (double)(this.sizeF_0.Width / 2f) * Math.Cos((double)(num / 180f) * 3.1415926535897931);
					result.Y = result.Y + (unitPoint.Y - unitPoint2.Y) * (double)this.float_0 - (double)this.sizeF_0.Height * Math.Cos((double)(num / 180f) * 3.1415926535897931) + (double)(this.sizeF_0.Width / 2f) * Math.Sin((double)(num / 180f) * 3.1415926535897931);
				}
				return result;
			}
			if (this.bool_0)
			{
				if (num >= -90f && num <= 90f)
				{
					result.X = result.X + (unitPoint.X - unitPoint2.X) * (double)this.float_0 - (double)(this.sizeF_0.Width / 2f) * Math.Cos((double)(num / 180f) * 3.1415926535897931);
					result.Y = result.Y + (unitPoint.Y - unitPoint2.Y) * (double)this.float_0 - (double)(this.sizeF_0.Width / 2f) * Math.Sin((double)(num / 180f) * 3.1415926535897931);
				}
				else
				{
					result.X = result.X + (unitPoint.X - unitPoint2.X) * (double)this.float_0 - (double)(this.sizeF_0.Width / 2f) * Math.Cos((double)(num / 180f) * 3.1415926535897931) - (double)this.sizeF_0.Height * Math.Sin((double)(num / 180f) * 3.1415926535897931);
					result.Y = result.Y + (unitPoint.Y - unitPoint2.Y) * (double)this.float_0 - (double)(this.sizeF_0.Width / 2f) * Math.Sin((double)(num / 180f) * 3.1415926535897931) + (double)this.sizeF_0.Height * Math.Cos((double)(num / 180f) * 3.1415926535897931);
				}
			}
			else if (num <= 90f && num >= -90f)
			{
				result.X = result.X + (unitPoint.X - unitPoint2.X) * (double)this.float_0 + (double)(this.sizeF_0.Width / 2f) * Math.Cos((double)(num / 180f) * 3.1415926535897931) + (double)this.sizeF_0.Height * Math.Sin((double)(num / 180f) * 3.1415926535897931);
				result.Y = result.Y + (unitPoint.Y - unitPoint2.Y) * (double)this.float_0 + (double)(this.sizeF_0.Width / 2f) * Math.Sin((double)(num / 180f) * 3.1415926535897931) - (double)this.sizeF_0.Height * Math.Cos((double)(num / 180f) * 3.1415926535897931);
			}
			else
			{
				result.X = result.X + (unitPoint.X - unitPoint2.X) * (double)this.float_0 - (double)this.sizeF_0.Height * Math.Sin((double)(num / 180f) * 3.1415926535897931) + (double)(this.sizeF_0.Width / 2f) * Math.Cos((double)(num / 180f) * 3.1415926535897931) + (double)this.sizeF_0.Height * Math.Sin((double)(num / 180f) * 3.1415926535897931);
				result.Y = result.Y + (unitPoint.Y - unitPoint2.Y) * (double)this.float_0 + (double)this.sizeF_0.Height * Math.Cos((double)(num / 180f) * 3.1415926535897931) + (double)(this.sizeF_0.Width / 2f) * Math.Sin((double)(num / 180f) * 3.1415926535897931) - (double)this.sizeF_0.Height * Math.Cos((double)(num / 180f) * 3.1415926535897931);
			}
			return result;
		}

		private void method_12()
		{
			UnitPoint unitPoint = this.method_11();
			float num = this.method_10();
			num = (this.bool_0 ? num : (num - 180f));
			PointF[] points = new PointF[]
			{
				unitPoint.Point,
				new PointF((float)unitPoint.X + this.sizeF_0.Width, (float)unitPoint.Y),
				new PointF((float)unitPoint.X + this.sizeF_0.Width, (float)unitPoint.Y - this.sizeF_0.Height),
				new PointF((float)unitPoint.X, (float)unitPoint.Y - this.sizeF_0.Height)
			};
			Matrix matrix = new Matrix();
			matrix.RotateAt(num, unitPoint.Point, MatrixOrder.Append);
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.AddPolygon(points);
			graphicsPath.Transform(matrix);
			int num2 = 0;
			foreach (PointF pointF_ in graphicsPath.PathPoints)
			{
				this.unitPoint_0[num2] = new UnitPoint(pointF_);
				num2++;
				if (num2 > 4)
				{
					return;
				}
			}
		}

		[CompilerGenerated]
		private static double smethod_0(UnitPoint unitPoint_1)
		{
			return unitPoint_1.X;
		}

		[CompilerGenerated]
		private static double smethod_1(UnitPoint unitPoint_1)
		{
			return unitPoint_1.Y;
		}

		[CompilerGenerated]
		private static double smethod_2(UnitPoint unitPoint_1)
		{
			return unitPoint_1.X;
		}

		[CompilerGenerated]
		private static double smethod_3(UnitPoint unitPoint_1)
		{
			return unitPoint_1.Y;
		}

		private UnitPoint[] unitPoint_0 = new UnitPoint[4];

		private bool bool_0 = true;

		private SizeF sizeF_0 = SizeF.Empty;

		private float float_0 = 0.5f;

		private eTextBranchType eTextBranchType_0;

		private string string_0 = string.Empty;

		private string string_1 = string.Empty;

		private string string_2 = string.Empty;

		private string string_3 = string.Empty;

		private string string_4 = string.Empty;

		public DataRow passportDataRow;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private bool bool_1;

		[CompilerGenerated]
		private static Func<UnitPoint, double> func_0;

		[CompilerGenerated]
		private static Func<UnitPoint, double> func_1;

		[CompilerGenerated]
		private static Func<UnitPoint, double> func_2;

		[CompilerGenerated]
		private static Func<UnitPoint, double> func_3;
	}
}
