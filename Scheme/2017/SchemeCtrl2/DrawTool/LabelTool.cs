using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using System.Xml;
using DataSql;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool.FormsObj;

namespace SchemeCtrl2.DrawTool
{
	public class LabelTool : DrawObjectBase
	{
		private DrawObjectBase method_7()
		{
			if (this.Parent == null)
			{
				return this.drawObjectBase_2;
			}
			if (this.bool_7 && this.Parent.Parent != null && this.Parent.Parent is RectangleTool)
			{
				return this.Parent.Parent;
			}
			return this.Parent;
		}

		public UnitPoint Location
		{
			get
			{
				return this.unitPoint_0;
			}
			set
			{
				this.unitPoint_0 = value;
			}
		}

		public RectangleF Rectangle
		{
			get
			{
				return this.rectangleF_0;
			}
			set
			{
				this.rectangleF_0 = value;
			}
		}

		public LabelTool()
		{
			Class90.TDroV38zslI2T();
			this.bool_7 = true;
			base..ctor();
		}

		public LabelTool(DataRow r)
		{
			Class90.TDroV38zslI2T();
			this.bool_7 = true;
			base..ctor(r);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml((string)r["XmlCoords"]);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("/Obj");
			this.Location = new UnitPoint((double)Convert.ToSingle(xmlNode.Attributes[0].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode.Attributes[1].Value, new CultureInfo(1033)));
			XmlAttribute xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontName");
			if (xmlAttribute != null)
			{
				base.UseSettingsText = false;
				this.TextProperty.FontName = xmlAttribute.Value;
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontSize");
				if (xmlAttribute != null)
				{
					this.TextProperty.FontSize = Convert.ToSingle(xmlAttribute.Value, new CultureInfo(1033));
				}
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontBold");
				if (xmlAttribute != null)
				{
					this.TextProperty.FontBold = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontItalic");
				if (xmlAttribute != null)
				{
					this.TextProperty.FontItalic = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontUnderline");
				if (xmlAttribute != null)
				{
					this.TextProperty.FontUnderline = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontColor");
				if (xmlAttribute != null)
				{
					base.UseSettingColor = false;
					this.TextProperty.Color = Color.FromArgb(Convert.ToInt32(xmlAttribute.Value));
				}
			}
			else
			{
				base.UseSettingColor = true;
			}
			xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontVirtical");
			if (xmlAttribute != null)
			{
				this.TextProperty.FontVirtical = Convert.ToBoolean(xmlAttribute.Value);
			}
		}

		public static LabelTool GetLabelTool(DataRow r)
		{
			LabelTool result = null;
			Type type = null;
			eTypeLabelTool eTypeLabelTool = (eTypeLabelTool)Convert.ToInt32(r["TypeLabel"]);
			object[] args = new object[]
			{
				r
			};
			switch (eTypeLabelTool)
			{
			case eTypeLabelTool.Node:
				type = typeof(NodeTool);
				break;
			case eTypeLabelTool.FreeLabel:
				type = typeof(FreeLabelTool);
				break;
			case eTypeLabelTool.TelemetryLabel:
				type = typeof(TelemetryLabelTool);
				break;
			case eTypeLabelTool.MeasurementLabel:
				type = typeof(MeasurementLabelTool);
				break;
			}
			try
			{
				result = (LabelTool)Activator.CreateInstance(type, args);
			}
			catch
			{
			}
			return result;
		}

		public override void Move(UnitPoint offset, bool selectedMove)
		{
			if (!selectedMove && this.Selected)
			{
				return;
			}
			this.unitPoint_0.X = this.unitPoint_0.X + (double)((float)offset.X);
			this.unitPoint_0.Y = this.unitPoint_0.Y + (double)((float)offset.Y);
			if (this.method_7() != null && this.method_7().Layer != null && this.method_7().Layer.Parent != null)
			{
				if (this.method_7() is LineTool)
				{
					LineTool lineTool = (LineTool)this.method_7();
					new Dictionary<Branch, UnitPoint>();
					Branch branch = null;
					float num = -1f;
					Branch branch2 = null;
					float num2 = -1f;
					float width = this.rectangleF_0.Width;
					bool flag = false;
					foreach (Branch branch3 in lineTool.Branches)
					{
						UnitPoint unitPoint_ = Class79.smethod_4(branch3.Source.Point, branch3.Destination.Point, this.Location);
						float num3 = Class79.smethod_5(unitPoint_, this.unitPoint_0);
						PointTool pointTool = this.method_9(unitPoint_, branch3);
						bool flag2 = false;
						if (pointTool != null)
						{
							using (IEnumerator<Branch> enumerator2 = pointTool.Branches.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									if (enumerator2.Current.Parent != lineTool)
									{
										flag2 = true;
										break;
									}
								}
								goto IL_1E1;
							}
							IL_168:
							float num4;
							num3 = num4;
							goto IL_16C;
							IL_1E1:
							num4 = Class79.smethod_5(unitPoint_, pointTool.Point);
							if (num4 > num3)
							{
								goto IL_168;
							}
						}
						IL_16C:
						if (num3 < width && (pointTool == null || Class79.smethod_5(unitPoint_, pointTool.Point) < width))
						{
							flag = true;
							break;
						}
						if (pointTool == null || flag2)
						{
							if (num3 < num)
							{
								branch = branch3;
								num = num3;
							}
							if (num == -1f)
							{
								branch = branch3;
								num = num3;
							}
						}
						else
						{
							if (num3 < num2)
							{
								branch2 = branch3;
								num2 = num3;
							}
							if (num2 == -1f)
							{
								branch2 = branch3;
								num2 = num3;
							}
						}
					}
					if (!flag)
					{
						if (branch == null)
						{
							branch = branch2;
							num = num2;
						}
						UnitPoint unitPoint_2 = Class79.smethod_4(branch.Source.Point, branch.Destination.Point, this.Location);
						if (num > width)
						{
							UnitPoint unitPoint = this.method_8(unitPoint_2, this.Location, width / num);
							this.unitPoint_0.X = unitPoint.X;
							this.unitPoint_0.Y = unitPoint.Y;
						}
						PointTool pointTool2 = this.method_9(unitPoint_2, branch);
						if (pointTool2 != null)
						{
							num = Class79.smethod_5(unitPoint_2, pointTool2.Point);
							if (num > width)
							{
								UnitPoint unitPoint2 = this.method_8(pointTool2.Point, this.Location, width / num);
								this.unitPoint_0.X = unitPoint2.X;
								this.unitPoint_0.Y = unitPoint2.Y;
							}
						}
					}
				}
				else
				{
					this.Layer.Parent.Graphics = Graphics.FromHwnd(this.Layer.Parent.Handle);
					RectangleF boundingRect = this.method_7().GetBoundingRect(this.Parent.Layer.Parent, false);
					RectangleF rectangleText = this.GetRectangleText(this.Parent.Layer.Parent);
					if (this.unitPoint_0.X < (double)(boundingRect.X - rectangleText.Width))
					{
						this.unitPoint_0.X = (double)(boundingRect.X - rectangleText.Width);
					}
					if (this.unitPoint_0.Y < (double)(boundingRect.Y - rectangleText.Height))
					{
						this.unitPoint_0.Y = (double)(boundingRect.Y - rectangleText.Height);
					}
					if (this.unitPoint_0.X > (double)boundingRect.Right)
					{
						this.unitPoint_0.X = (double)boundingRect.Right;
					}
					if (this.unitPoint_0.Y > (double)boundingRect.Bottom)
					{
						this.unitPoint_0.Y = (double)boundingRect.Bottom;
					}
				}
			}
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				drawObjectBase.Move(offset, false);
			}
		}

		private UnitPoint method_8(UnitPoint unitPoint_1, UnitPoint unitPoint_2, float float_1)
		{
			UnitPoint result = default(UnitPoint);
			float num = 1f - float_1;
			float num2 = Class79.smethod_5(unitPoint_1, unitPoint_2) * num;
			if (unitPoint_1.X == unitPoint_2.X)
			{
				result = new UnitPoint(unitPoint_1.X, unitPoint_2.Y + (double)num * (unitPoint_1.Y - unitPoint_2.Y));
			}
			if (unitPoint_1.Y == unitPoint_2.Y)
			{
				result = new UnitPoint(unitPoint_2.X + (double)num * (unitPoint_1.X - unitPoint_2.X), unitPoint_1.Y);
			}
			if (unitPoint_1.X != unitPoint_2.X && unitPoint_1.Y != unitPoint_2.Y)
			{
				double num3 = 1.0 / (Math.Sqrt(Math.Pow((unitPoint_1.Y - unitPoint_2.Y) / (unitPoint_1.X - unitPoint_2.X), 2.0) + 1.0) / (double)num2);
				if (unitPoint_1.X < unitPoint_2.X)
				{
					num3 *= -1.0;
				}
				double num4 = 1.0 / (Math.Sqrt(Math.Pow((unitPoint_1.X - unitPoint_2.X) / (unitPoint_1.Y - unitPoint_2.Y), 2.0) + 1.0) / (double)num2);
				if (unitPoint_1.Y < unitPoint_2.Y)
				{
					num4 *= -1.0;
				}
				result = new UnitPoint(unitPoint_2.X + num3, unitPoint_2.Y + num4);
			}
			return result;
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

		public override RectangleF GetBoundingRect(CanvasControl canvas, bool inflate)
		{
			float num = base.ThresholdWidth(canvas, base.Width);
			RectangleF rectangleText = this.GetRectangleText(canvas);
			double num2 = (double)Math.Min(rectangleText.Left, rectangleText.Right);
			double num3 = (double)Math.Min(rectangleText.Top, rectangleText.Bottom);
			double num4 = (double)Math.Abs(rectangleText.Left - rectangleText.Right);
			double num5 = (double)Math.Abs(rectangleText.Top - rectangleText.Bottom);
			RectangleF result = new RectangleF((float)num2, (float)num3, (float)num4, (float)num5);
			if (inflate)
			{
				result.Inflate(num, num);
			}
			return result;
		}

		protected override RectangleF GetRectangleText(CanvasControl canvas)
		{
			Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style);
			SizeF sizeF = canvas.Graphics.MeasureString(this.Text, font);
			SizeF size = new SizeF((float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Width), (float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Height));
			RectangleF result = new RectangleF(this.Location.Point, size);
			font.Dispose();
			return result;
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			if (!this.Visible)
			{
				return;
			}
			if (this.TextProperty.FontSize * canvas.Zoom <= canvas.Settings.FontSizeNoVisible)
			{
				return;
			}
			using (Font font = new Font(this.TextProperty.Font.FontFamily, this.TextProperty.FontSize * canvas.Zoom, this.TextProperty.Font.Style))
			{
				RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(canvas, this.GetRectangleText(canvas));
				GraphicsState gstate = canvas.Graphics.Save();
				if (this.TextProperty.FontVirtical)
				{
					Matrix transform = canvas.Graphics.Transform;
					rectangleF.Y += rectangleF.Height;
					transform.RotateAt(-90f, rectangleF.Location, MatrixOrder.Append);
					canvas.Graphics.Transform = transform;
				}
				using (Pen pen = new Pen(this.TextProperty.Color, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width)))
				{
					if ((drawMode & eDrawMode.Print) == eDrawMode.Print)
					{
						if ((drawMode & eDrawMode.Color) != eDrawMode.Color)
						{
							pen.Color = Color.Black;
						}
					}
					else if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
					{
						if (this.Selected)
						{
							pen.Color = this.SelectedColor;
						}
						if (this.Flashing && canvas.ConvertColorFlash)
						{
							pen.Color = canvas.Settings.BackFlashingColor;
						}
					}
					else
					{
						if (this.Selected)
						{
							pen.Color = Color.Gray;
						}
						if (this.Flashing && canvas.ConvertColorFlash)
						{
							pen.Color = Color.White;
						}
					}
					if (rectangleF.Size.Width > 0f && rectangleF.Size.Height > 0f)
					{
						canvas.Graphics.DrawString(this.Text, font, new SolidBrush(pen.Color), rectangleF.Location);
						canvas.Graphics.DrawRectangle(pen, rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height);
					}
					canvas.Graphics.Restore(gstate);
				}
			}
		}

		public override bool PointInObject(UnitPoint point)
		{
			if (this.Layer == null)
			{
				return false;
			}
			CanvasControl parent = this.Layer.Parent;
			float num = base.ThresholdWidth(parent, base.Width);
			parent.Graphics = Graphics.FromHwnd(parent.Handle);
			this.rectangleF_0 = this.GetRectangleText(parent);
			if (this.TextProperty.FontVirtical)
			{
				this.rectangleF_0.Height = this.rectangleF_0.Height + this.rectangleF_0.Width;
				this.rectangleF_0.Width = this.rectangleF_0.Height - this.rectangleF_0.Width;
				this.rectangleF_0.Height = this.rectangleF_0.Height - this.rectangleF_0.Width;
			}
			UnitPoint left = new UnitPoint((double)this.Rectangle.X, (double)this.Rectangle.Y);
			UnitPoint unitPoint = new UnitPoint((double)(this.Rectangle.X + this.Rectangle.Width), (double)(this.Rectangle.Y + this.Rectangle.Height));
			double num2 = Math.Min(left.X, unitPoint.X) - (double)num;
			double num3 = Math.Max(left.X, unitPoint.X) + (double)num;
			if (point.X < num2 || point.X > num3)
			{
				return false;
			}
			double num4 = Math.Min(left.Y, unitPoint.Y) - (double)num;
			double num5 = Math.Max(left.Y, unitPoint.Y) + (double)num;
			if (point.Y < num4 || point.Y > num5)
			{
				return false;
			}
			if (Class79.XrgxasnnaZ(left, num, point))
			{
				return true;
			}
			if (Class79.XrgxasnnaZ(left + new UnitPoint(unitPoint.X - left.X, 0.0), num, point))
			{
				return true;
			}
			if (Class79.XrgxasnnaZ(left + new UnitPoint(0.0, unitPoint.Y - left.Y), num, point))
			{
				return true;
			}
			if (Class79.XrgxasnnaZ(unitPoint, num, point))
			{
				return true;
			}
			double num6 = Math.Min(left.X, unitPoint.X);
			double num7 = Math.Max(left.X, unitPoint.X);
			double num8 = Math.Min(left.Y, unitPoint.Y);
			double num9 = Math.Max(left.Y, unitPoint.Y);
			return point.X >= num6 - (double)num && point.X <= num7 + (double)num && point.Y >= num8 - (double)num && point.Y <= num9 + (double)num;
		}

		public override bool ObjectInRectangle(CanvasControl canvas, RectangleF rect, bool anyPoint)
		{
			RectangleF boundingRect = this.GetBoundingRect(canvas, true);
			if (anyPoint)
			{
				UnitPoint unitPoint = new UnitPoint(boundingRect.Location);
				UnitPoint unitPoint_ = new UnitPoint((double)(boundingRect.X + boundingRect.Width), (double)(boundingRect.Y + boundingRect.Height));
				return Class79.smethod_0(unitPoint, unitPoint_, rect);
			}
			return rect.Contains(boundingRect);
		}

		public override string GetUpdateScriptXML(bool children, List<int> id)
		{
			this.vmethod_4();
			return string.Concat(new string[]
			{
				" update tSChm_Label set [XmlCoords] = ' ",
				this.xmlCoords.InnerXml,
				"' where id = ",
				this.IdBase.ToString(),
				" "
			});
		}

		public override bool DeleteSql()
		{
			if (this.Layer == null)
			{
				return false;
			}
			if (this.Layer.Parent == null)
			{
				return false;
			}
			if (this.Layer.Parent.SqlSettings == null)
			{
				return false;
			}
			if (!this.Layer.Parent.UseObjectFromDB)
			{
				return false;
			}
			if (this.IdBase == 0)
			{
				return false;
			}
			bool result = new SqlDataCommand(this.Layer.Parent.SqlSettings).DeleteSqlDataById(this.Layer.Parent.class22_0.tSchm_Label, this.IdBase);
			this.IdBase = 0;
			return result;
		}

		public override bool ShowPropertyForm(Point location)
		{
			bool flag = this.IdBase <= 0;
			if (new FormLabelToolProperties(this, this.Layer.Parent.SqlSettings)
			{
				Location = location
			}.ShowDialog() == DialogResult.OK)
			{
				this.Layer.Parent.DoInvalidate(true);
				if (base.GetType() == typeof(NodeTool) && this.Layer != null && this.Layer.Parent != null && this.Layer.Parent.Connected)
				{
					this.Layer.Parent.proxy_Singleton_0.NodeChange(this.IdBase, flag ? 1 : 3, this.Text, this.Location.Point, base.UseSettingColor ? Color.Empty : this.Color, Class18.smethod_3());
				}
				return true;
			}
			return false;
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			LabelTool labelTool = new LabelTool();
			labelTool.Copy(this);
			return labelTool;
		}

		public override void EndDraw()
		{
			if (new FormLabelToolProperties(this, this.Layer.Parent.SqlSettings).ShowDialog() != DialogResult.OK)
			{
				bool delSql = this.Layer != null && this.Layer.Parent != null && this.Layer.Parent.UseObjectFromDB;
				this.Remove(delSql, true);
			}
		}

		protected override bool SaveToSql()
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.Layer.Parent.SqlSettings);
			Class22 @class = new Class22();
			if (this.IdBase > 0)
			{
				sqlDataCommand.SelectSqlData(@class.tSchm_Label, true, " where id = " + this.IdBase.ToString(), null, false, 0);
				if (@class.tSchm_Label.Rows.Count != 0)
				{
					if (@class.tSchm_Label.Rows[0]["Name"].ToString() != this.Text)
					{
						@class.tSchm_Label.Rows[0]["Name"] = this.Text;
					}
					if ((int)@class.tSchm_Label.Rows[0]["TypeLabel"] != this.GetTypeObject())
					{
						@class.tSchm_Label.Rows[0]["TypeLabel"] = this.GetTypeObject();
					}
					if (this.Parent != null)
					{
						if (@class.tSchm_Label.Rows[0].IsNull("idParent") || (int)@class.tSchm_Label.Rows[0]["idParent"] != this.Parent.IdBase)
						{
							@class.tSchm_Label.Rows[0]["idParent"] = this.Parent.IdBase;
						}
					}
					else
					{
						@class.tSchm_Label.Rows[0]["idParent"] = DBNull.Value;
					}
					if (this.Layer.Parent.IdRect > 0)
					{
						@class.tSchm_Label.Rows[0]["Tag"] = this.Layer.Parent.IdRect;
					}
					this.vmethod_4();
					@class.tSchm_Label.Rows[0]["XmlCoords"] = this.xmlCoords.InnerXml;
					@class.tSchm_Label.Rows[0].EndEdit();
					return sqlDataCommand.UpdateSqlData(@class, @class.tSchm_Label);
				}
				DataRow dataRow = @class.DataTableCollection_0["tSchm_Label"].NewRow();
				dataRow["Name"] = this.Text;
				dataRow["TypeLabel"] = this.GetTypeObject();
				if (this.Parent != null)
				{
					dataRow["idParent"] = this.Parent.IdBase;
				}
				this.vmethod_4();
				dataRow["XmlCoords"] = this.xmlCoords.InnerXml;
				if (this.Layer.Parent.IdRect > 0)
				{
					dataRow["Tag"] = this.Layer.Parent.IdRect;
				}
				@class.DataTableCollection_0["tSchm_Label"].Rows.Add(dataRow);
				this.IdBase = sqlDataCommand.InsertSqlDataOneRow(@class.DataTableCollection_0["tSchm_Label"]);
				if (this.IdBase <= 0)
				{
					return false;
				}
			}
			else
			{
				DataRow dataRow2 = @class.tSchm_Label.NewRow();
				dataRow2["Name"] = this.Text;
				dataRow2["TypeLabel"] = this.GetTypeObject();
				if (this.Parent != null)
				{
					dataRow2["idParent"] = this.Parent.IdBase;
				}
				if (this.Layer.Parent.IdRect > 0)
				{
					dataRow2["Tag"] = this.Layer.Parent.IdRect;
				}
				this.vmethod_4();
				dataRow2["XmlCoords"] = this.xmlCoords.InnerXml;
				@class.tSchm_Label.Rows.Add(dataRow2);
				this.IdBase = sqlDataCommand.InsertSqlDataOneRow(@class.tSchm_Label);
				if (this.IdBase <= 0)
				{
					return false;
				}
			}
			return true;
		}

		protected override void vmethod_4()
		{
			base.vmethod_4();
			((XmlElement)this.currentXmlScheme).SetAttribute("X1", Math.Round(this.Location.X, 4).ToString(new CultureInfo(1033)));
			((XmlElement)this.currentXmlScheme).SetAttribute("Y1", Math.Round(this.Location.Y, 4).ToString(new CultureInfo(1033)));
			if (!base.UseSettingsText)
			{
				((XmlElement)this.currentXmlScheme).SetAttribute("FontName", this.TextProperty.FontName);
				((XmlElement)this.currentXmlScheme).SetAttribute("FontSize", this.TextProperty.FontSize.ToString(new CultureInfo(1033)));
				((XmlElement)this.currentXmlScheme).SetAttribute("FontBold", this.TextProperty.FontBold.ToString());
				((XmlElement)this.currentXmlScheme).SetAttribute("FontItalic", this.TextProperty.FontItalic.ToString());
				((XmlElement)this.currentXmlScheme).SetAttribute("FontUnderline", this.TextProperty.FontUnderline.ToString());
				((XmlElement)this.currentXmlScheme).SetAttribute("FontColor", this.TextProperty.Color.ToArgb().ToString());
			}
			if (this.TextProperty.FontVirtical)
			{
				((XmlElement)this.currentXmlScheme).SetAttribute("FontVirtical", this.TextProperty.FontVirtical.ToString());
			}
		}

		private RectangleF rectangleF_0;

		private UnitPoint unitPoint_0;

		private bool bool_7;

		private DrawObjectBase drawObjectBase_2;
	}
}
