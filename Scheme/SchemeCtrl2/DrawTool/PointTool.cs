using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using netDxf;
using netDxf.Entities;
using netDxf.Tables;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool.FormsObj;
using SchemeCtrl2.Layers;
using SchemeCtrl2.SnapPoint;

namespace SchemeCtrl2.DrawTool
{
	public class PointTool : DrawObjectBase
	{
		public event PointToolEventHandle ChangePoint
		{
			[CompilerGenerated]
			add
			{
				PointToolEventHandle pointToolEventHandle = this.pointToolEventHandle_0;
				PointToolEventHandle pointToolEventHandle2;
				do
				{
					pointToolEventHandle2 = pointToolEventHandle;
					PointToolEventHandle value2 = (PointToolEventHandle)Delegate.Combine(pointToolEventHandle2, value);
					pointToolEventHandle = Interlocked.CompareExchange<PointToolEventHandle>(ref this.pointToolEventHandle_0, value2, pointToolEventHandle2);
				}
				while (pointToolEventHandle != pointToolEventHandle2);
			}
			[CompilerGenerated]
			remove
			{
				PointToolEventHandle pointToolEventHandle = this.pointToolEventHandle_0;
				PointToolEventHandle pointToolEventHandle2;
				do
				{
					pointToolEventHandle2 = pointToolEventHandle;
					PointToolEventHandle value2 = (PointToolEventHandle)Delegate.Remove(pointToolEventHandle2, value);
					pointToolEventHandle = Interlocked.CompareExchange<PointToolEventHandle>(ref this.pointToolEventHandle_0, value2, pointToolEventHandle2);
				}
				while (pointToolEventHandle != pointToolEventHandle2);
			}
		}

		public event PointToolEventHandle AddBranchEvent
		{
			[CompilerGenerated]
			add
			{
				PointToolEventHandle pointToolEventHandle = this.pointToolEventHandle_1;
				PointToolEventHandle pointToolEventHandle2;
				do
				{
					pointToolEventHandle2 = pointToolEventHandle;
					PointToolEventHandle value2 = (PointToolEventHandle)Delegate.Combine(pointToolEventHandle2, value);
					pointToolEventHandle = Interlocked.CompareExchange<PointToolEventHandle>(ref this.pointToolEventHandle_1, value2, pointToolEventHandle2);
				}
				while (pointToolEventHandle != pointToolEventHandle2);
			}
			[CompilerGenerated]
			remove
			{
				PointToolEventHandle pointToolEventHandle = this.pointToolEventHandle_1;
				PointToolEventHandle pointToolEventHandle2;
				do
				{
					pointToolEventHandle2 = pointToolEventHandle;
					PointToolEventHandle value2 = (PointToolEventHandle)Delegate.Remove(pointToolEventHandle2, value);
					pointToolEventHandle = Interlocked.CompareExchange<PointToolEventHandle>(ref this.pointToolEventHandle_1, value2, pointToolEventHandle2);
				}
				while (pointToolEventHandle != pointToolEventHandle2);
			}
		}

		public event PointToolEventHandle RemoveBranchEvent
		{
			[CompilerGenerated]
			add
			{
				PointToolEventHandle pointToolEventHandle = this.pointToolEventHandle_2;
				PointToolEventHandle pointToolEventHandle2;
				do
				{
					pointToolEventHandle2 = pointToolEventHandle;
					PointToolEventHandle value2 = (PointToolEventHandle)Delegate.Combine(pointToolEventHandle2, value);
					pointToolEventHandle = Interlocked.CompareExchange<PointToolEventHandle>(ref this.pointToolEventHandle_2, value2, pointToolEventHandle2);
				}
				while (pointToolEventHandle != pointToolEventHandle2);
			}
			[CompilerGenerated]
			remove
			{
				PointToolEventHandle pointToolEventHandle = this.pointToolEventHandle_2;
				PointToolEventHandle pointToolEventHandle2;
				do
				{
					pointToolEventHandle2 = pointToolEventHandle;
					PointToolEventHandle value2 = (PointToolEventHandle)Delegate.Remove(pointToolEventHandle2, value);
					pointToolEventHandle = Interlocked.CompareExchange<PointToolEventHandle>(ref this.pointToolEventHandle_2, value2, pointToolEventHandle2);
				}
				while (pointToolEventHandle != pointToolEventHandle2);
			}
		}

		public CouplingRealationsList CouplingRelations
		{
			get
			{
				return this.couplingRealationsList_0;
			}
		}

		public virtual UnitPoint Point
		{
			get
			{
				return this.point;
			}
			set
			{
				PointToolEvetsArgs pointToolEvetsArgs = new PointToolEvetsArgs(this.point, value, null);
				this.point = pointToolEvetsArgs.newPoint;
				this.pointToolEventHandle_0(this, pointToolEvetsArgs);
			}
		}

		public override int NodeCount
		{
			get
			{
				return 0;
			}
		}

		public static string ObjectType
		{
			get
			{
				return "Point";
			}
		}

		public string Id
		{
			get
			{
				if (this.Layer != null && base.Layer.Parent.globalPointsList.Contains(this))
				{
					return this.Layer.Parent.globalPointsList.IndexOf(this).ToString();
				}
				return string.Empty;
			}
		}

		public virtual IEnumerable<Branch> Branches
		{
			get
			{
				return this.src;
			}
		}

		public Branch this[int index]
		{
			get
			{
				if (this.src.Count == 0)
				{
					return null;
				}
				return this.src[index];
			}
			set
			{
				this.src[index] = value;
			}
		}

		public int BranchesCount
		{
			get
			{
				return this.src.Count;
			}
		}

		public override DrawingLayer Layer
		{
			get
			{
				return base.Layer;
			}
			set
			{
				base.Layer = value;
			}
		}

		public override TextFont TextProperty
		{
			get
			{
				if (this.Layer != null && base.UseSettingsText)
				{
					LineTool lineTool = (LineTool)this.method_7();
					if (lineTool != null)
					{
						TextFont textFont = base.TextProperty;
						eTypeShinaTool typeParentShina = lineTool.GetTypeParentShina(new List<LineTool>());
						if (typeParentShina <= eTypeShinaTool.Shina_6)
						{
							if (typeParentShina != eTypeShinaTool.Shina_04)
							{
								if (typeParentShina == eTypeShinaTool.Shina_6)
								{
									textFont = this.Layer.Parent.Settings.TextPropertyCell6;
								}
							}
							else
							{
								textFont = this.Layer.Parent.Settings.TextPropertyCell04;
							}
						}
						else if (typeParentShina != eTypeShinaTool.Shina_023)
						{
							if (typeParentShina == eTypeShinaTool.Shina_10)
							{
								textFont = this.Layer.Parent.Settings.TextPropertyCell10;
							}
						}
						else
						{
							textFont = this.Layer.Parent.Settings.TextPropertyCell023;
						}
						base.TextProperty = new TextFont(textFont.FontName, textFont.FontSize, textFont.FontBold, textFont.FontItalic, textFont.FontUnderline, base.TextProperty.Position, base.TextProperty.FontVirtical, base.TextProperty.Visible, textFont.Color);
						return base.TextProperty;
					}
				}
				return base.TextProperty;
			}
			set
			{
				base.TextProperty = value;
			}
		}

		public TypePointTool TypePoint
		{
			get
			{
				return this.typePointTool_0;
			}
			set
			{
				this.typePointTool_0 = value;
			}
		}

		public PointTool()
		{
			
			this.src = new List<Branch>();
			this.couplingRealationsList_0 = new CouplingRealationsList();
			
			this.Text = "";
			this.Color = Color.Aqua;
			this.point = default(UnitPoint);
			this.ChangePoint += this.PointTool_ChangePoint;
		}

		public PointTool(DataRow r)
		{
			
			this.src = new List<Branch>();
			this.couplingRealationsList_0 = new CouplingRealationsList();
			
			this.Color = Color.Aqua;
			this.point = default(UnitPoint);
			this.ChangePoint += this.PointTool_ChangePoint;
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml((string)r["SchemaXml"]);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("/Obj");
			this.Point = new UnitPoint((double)Convert.ToSingle(xmlNode.Attributes[0].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode.Attributes[1].Value, new CultureInfo(1033)));
			XmlAttribute xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("text");
			if (xmlAttribute != null)
			{
				this.Text = xmlAttribute.Value;
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("textVis");
				if (xmlAttribute != null)
				{
					this.TextProperty.Visible = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("textPos");
				if (xmlAttribute != null)
				{
					this.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlAttribute.Value);
				}
				xmlAttribute = (XmlAttribute)xmlNode.Attributes.GetNamedItem("FontName");
				if (xmlAttribute == null)
				{
					base.UseSettingsText = true;
					return;
				}
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
					this.TextProperty.Color = Color.FromArgb(Convert.ToInt32(xmlAttribute.Value));
					return;
				}
			}
			else
			{
				this.Text = null;
				this.TextProperty.Visible = false;
			}
		}

		public PointTool(UnitPoint initPoint, float width, Color color)
		{
			
			this.src = new List<Branch>();
			this.couplingRealationsList_0 = new CouplingRealationsList();
			
			this.Text = "";
			this.Color = Color.Aqua;
			this.point = new UnitPoint(initPoint.Point);
			base.Width = width;
			this.Color = color;
			this.Selected = false;
			this.ChangePoint += this.PointTool_ChangePoint;
		}

		public PointTool(UnitPoint initPoint)
		{
			
			this.src = new List<Branch>();
			this.couplingRealationsList_0 = new CouplingRealationsList();
			
			this.Text = "";
			this.Color = Color.Aqua;
			this.point = new UnitPoint(initPoint.Point);
			this.ChangePoint += this.PointTool_ChangePoint;
		}

		public PointTool(UnitPoint initPoint, DrawingLayer layer)
		{
			
			this.src = new List<Branch>();
			this.couplingRealationsList_0 = new CouplingRealationsList();
			
			this.Text = "";
			this.Color = Color.Aqua;
			this.point = new UnitPoint(initPoint.Point);
			this.ChangePoint += this.PointTool_ChangePoint;
			this.Layer = layer;
		}

		public PointTool(DrawingLayer layer)
		{
			
			this.src = new List<Branch>();
			this.couplingRealationsList_0 = new CouplingRealationsList();
			
			this.Text = "";
			this.Color = Color.Aqua;
			this.point = default(UnitPoint);
			this.ChangePoint += this.PointTool_ChangePoint;
			this.Layer = layer;
		}

		protected void PointTool_RemoveBranchEvent(object sender, EventArgs e)
		{
		}

		protected void PointTool_ChangePoint(DrawObjectBase sender, PointToolEvetsArgs e)
		{
		}

		protected void PointTool_AddBranchEvent(object sender, EventArgs e)
		{
		}

		public override void InitializeFromModel(UnitPoint point, DrawingLayer layer, ISnapPoint snap)
		{
			point = new UnitPoint(point.Point);
			base.Width = layer.Width;
			this.Color = layer.Color;
			this.Selected = true;
		}

		public virtual void Copy(PointTool acopy)
		{
			base.Copy(acopy);
			this.point = acopy.point;
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			PointTool pointTool = new PointTool();
			pointTool.Copy(this);
			pointTool.Master = this;
			pointTool.Color = this.Color;
			pointTool.Fill = base.Fill;
			pointTool.IdBase = this.IdBase;
			pointTool.Text = this.Text;
			pointTool.UseSettingColor = base.UseSettingColor;
			pointTool.UseLayerWidth = base.UseLayerWidth;
			pointTool.Width = base.Width;
			return pointTool;
		}

		public override bool PointInObject(UnitPoint uPoint)
		{
			if (this.Layer == null)
			{
				return false;
			}
			CanvasControl parent = this.Layer.Parent;
			float float_ = base.ThresholdWidth(parent, base.Width);
			return Class79.XrgxasnnaZ(this.point, float_, uPoint);
		}

		public override RectangleF GetBoundingRect(CanvasControl canvas, bool inflate)
		{
			float num = base.ThresholdWidth(canvas, base.Width);
			RectangleF result = new RectangleF(this.point.Point, new SizeF(0f, 0f));
			if (inflate)
			{
				result.Inflate(num, num);
			}
			return result;
		}

		public override bool ObjectInRectangle(CanvasControl canvas, RectangleF rect, bool anyPoint)
		{
			RectangleF boundingRect = this.GetBoundingRect(canvas, true);
			return rect.Contains(boundingRect);
		}

		public override void vmethod_3(CanvasControl canvas, DxfDocument document)
		{
			Circle circle = new Circle(new Vector2(this.Point.X, this.Point.Y), 0.08);
			List<HatchBoundaryPath> list = new List<HatchBoundaryPath>
			{
				new HatchBoundaryPath(new List<IEntityObject>
				{
					circle
				})
			};
			Hatch hatch = new Hatch(HatchPattern.Solid, list);
			Color color = this.Color;
			if (this.Parent != null && this.BranchesCount > 0 && (this.Parent.GetType() == typeof(ShinaTool) || this.Parent.GetType() == typeof(SplitterShinaTool)))
			{
				color = ((ShinaTool)this.Parent).GetCurrentColor();
			}
			else if (this.Branches.Count<Branch>() > 0)
			{
				color = this.Branches.First<Branch>().GetCurrentColor();
			}
			hatch.Color = new AciColor(color);
			circle.Color = new AciColor(color);
			document.AddEntity(circle);
			document.AddEntity(hatch);
			double num = 1.5;
			if (this.TextProperty.Visible)
			{
				RectangleF rectangleText = this.GetRectangleText(canvas);
				document.AddEntity(new Text(this.Text, new Vector2((double)rectangleText.X, (double)rectangleText.Y), (double)rectangleText.Height / num)
				{
					Color = new AciColor(this.TextProperty.Color),
					Style = new TextStyle(this.TextProperty.FontName)
				});
			}
		}

		public override void Draw(CanvasControl canvas, RectangleF unitrect, eDrawMode drawMode = eDrawMode.Color)
		{
			if (this.Parent == null && this.Branches.Count<Branch>() == 0 && this.CouplingRelations.Count == 0)
			{
				return;
			}
			if (canvas.Zoom < 0.5f && (drawMode & eDrawMode.Print) != eDrawMode.Print)
			{
				return;
			}
			Color color = this.Color;
			if ((drawMode & eDrawMode.Color) == eDrawMode.Color)
			{
				if (this.Parent != null && this.BranchesCount > 0 && (this.Parent.GetType() == typeof(ShinaTool) || this.Parent.GetType() == typeof(SplitterShinaTool)))
				{
					color = ((ShinaTool)this.Parent).GetCurrentColor();
				}
				else if (this.Branches.Count<Branch>() > 0)
				{
					color = this.Branches.First<Branch>().GetCurrentColor();
				}
			}
			else
			{
				color = Color.Black;
			}
			using (SolidBrush solidBrush = new SolidBrush(color))
			{
				PointF pointF = ConvertCanvas.ConvertToScreen(canvas, this.point);
				canvas.Graphics.FillEllipse(solidBrush, pointF.X - 3f * canvas.Zoom, pointF.Y - 3f * canvas.Zoom, 6f * canvas.Zoom, 6f * canvas.Zoom);
				this.DrawText(canvas, drawMode);
				if (this.Selected && (drawMode & eDrawMode.Print) != eDrawMode.Print)
				{
					base.DrawTracker(canvas);
				}
			}
		}

		public override void DrawPrint(CanvasControl canvas, Graphics g, bool isColor = false)
		{
			if (this.Parent == null && this.Branches.Count<Branch>() == 0 && this.CouplingRelations.Count == 0)
			{
				return;
			}
			using (new Pen(Color.Black, ConvertCanvas.ConvertToScreen(canvas, (double)base.Width)))
			{
				PointF pointF = ConvertCanvas.ConvertToScreen(canvas, this.point);
				SolidBrush solidBrush;
				if (isColor)
				{
					solidBrush = new SolidBrush((this.Color == Color.White) ? Color.Black : this.Color);
				}
				else
				{
					solidBrush = new SolidBrush(Color.Black);
				}
				g.FillEllipse(solidBrush, pointF.X - 3f * canvas.Zoom, pointF.Y - 3f * canvas.Zoom, 6f * canvas.Zoom, 6f * canvas.Zoom);
				this.DrawText(canvas, eDrawMode.Print);
				solidBrush.Dispose();
			}
		}

		protected override RectangleF GetRectangleText(CanvasControl canvas)
		{
			RectangleF empty = RectangleF.Empty;
			if (this.TextProperty.Visible)
			{
				Font font = new Font(this.TextProperty.FontName, this.TextProperty.FontSize * canvas.Zoom);
				SizeF sizeF = canvas.Graphics.MeasureString(this.Text, font);
				SizeF size = new SizeF((float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Width), (float)ConvertCanvas.ConvertToUnit(canvas, sizeF.Height));
				empty = new RectangleF(this.point.Point, size);
				switch (this.TextProperty.Position)
				{
				case ePositionText.LT:
					empty.X -= size.Width;
					break;
				case ePositionText.T:
					empty.X -= size.Width / 2f;
					break;
				case ePositionText.R:
					empty.Y -= size.Height / 2f;
					break;
				case ePositionText.RB:
					empty.Y -= size.Height;
					break;
				case ePositionText.B:
					empty.X -= size.Width / 2f;
					empty.Y -= size.Height;
					break;
				case ePositionText.LB:
					empty.X -= size.Width;
					empty.Y -= size.Height;
					break;
				case ePositionText.L:
					empty.X -= size.Width;
					empty.Y -= size.Height / 2f;
					break;
				}
				font.Dispose();
				return empty;
			}
			return empty;
		}

		public override void OnMouseMove(CanvasControl canvas, UnitPoint uPoint, MouseButtons button)
		{
			this.point = uPoint;
		}

		public override ISnapPoint SnapPoint(CanvasControl canvas, UnitPoint point, List<DrawObjectBase> otherobjs, Type[] runningsnaptypes, Type usersnaptype)
		{
			float float_ = base.ThresholdWidth(canvas, base.Width);
			if (Class79.XrgxasnnaZ(this.Point, float_, point))
			{
				return new Class8(canvas, this, this.Point);
			}
			return null;
		}

		public override void Move(UnitPoint offset, bool selectedMove)
		{
			if (!selectedMove && this.Selected)
			{
				return;
			}
			this.Point += offset;
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				drawObjectBase.Move(offset, false);
			}
		}

		public override void vmethod_0(XmlNode xmlNode, List<PointTool> pointList)
		{
			XmlElement xmlElement = xmlNode.OwnerDocument.CreateElement("point");
			this.Id == "";
			xmlElement.SetAttribute("ID", this.Id);
			xmlElement.SetAttribute("X", Math.Round(this.Point.X, 4).ToString(new CultureInfo(1033)));
			xmlElement.SetAttribute("Y", Math.Round(this.Point.Y, 4).ToString(new CultureInfo(1033)));
			xmlNode.AppendChild(xmlElement);
		}

		public void AddBranch(Branch branch)
		{
			this.src.Add(branch);
			if (this.pointToolEventHandle_1 != null)
			{
				this.pointToolEventHandle_1(this, new PointToolEvetsArgs(UnitPoint.Empty, UnitPoint.Empty, branch));
			}
		}

		public bool RemoveBranch(Branch branch)
		{
			if (((LineTool)branch.Parent).EndsContains(this) && ((LineTool)branch.Parent).Amperages.ContainsKey(this))
			{
				((LineTool)branch.Parent).Amperages[this].method_4();
			}
			if (this.pointToolEventHandle_2 != null)
			{
				this.pointToolEventHandle_2(this, new PointToolEvetsArgs(UnitPoint.Empty, UnitPoint.Empty, branch));
			}
			return this.src.Remove(branch);
		}

		private DrawObjectBase method_7()
		{
			foreach (DrawObjectBase drawObjectBase in this.Branches)
			{
				if (drawObjectBase.GetType() == typeof(Branch) && drawObjectBase.Parent != null)
				{
					if (drawObjectBase.Parent.GetType() != typeof(LineCellTool))
					{
						if (drawObjectBase.Parent.GetType() != typeof(LineTool))
						{
							continue;
						}
					}
					return drawObjectBase.Parent;
				}
			}
			return null;
		}

		public override string GetUpdateScriptXML(bool children, List<int> id)
		{
			if (this.couplingRealationsList_0.Count > 0)
			{
				if (this.IdBase <= 0)
				{
					base.method_4(false, false);
				}
				this.vmethod_4();
				if (this.Layer == null)
				{
					return "";
				}
				string text = " update tSchm_Xml set [SchemaXml] = ' " + this.xmlCoords.InnerXml + "'";
				RectangleTool rectangleTool = null;
				if (this.Layer.Parent.TypeCanvas == eTypeCanvas.SchemeSecond)
				{
					foreach (DrawObjectBase drawObjectBase in this.Layer.Objects)
					{
						if (drawObjectBase is RectangleTool)
						{
							rectangleTool = (RectangleTool)drawObjectBase;
							break;
						}
					}
				}
				if (rectangleTool != null)
				{
					text = text + ", [Tag] = " + rectangleTool.IdBase.ToString();
				}
				text = string.Concat(new string[]
				{
					text,
					" where Objid = ",
					this.IdBase.ToString(),
					" AND TypeSchema=",
					((int)this.Layer.Parent.TypeCanvas).ToString()
				});
				if (rectangleTool != null)
				{
					text = text + " AND (Tag = " + rectangleTool.IdBase.ToString() + " OR Tag is NULL)";
				}
				if (id.Contains(this.IdBase))
				{
					text = "";
				}
				else
				{
					id.Add(this.IdBase);
				}
				return text;
			}
			else
			{
				if (this.Parent != null)
				{
					return this.Parent.GetUpdateScriptXML(false, id);
				}
				return string.Empty;
			}
		}

		protected override void vmethod_4()
		{
			base.vmethod_4();
			((XmlElement)this.currentXmlScheme).SetAttribute("X", Math.Round(this.Point.X, 4).ToString(new CultureInfo(1033)));
			((XmlElement)this.currentXmlScheme).SetAttribute("Y", Math.Round(this.Point.Y, 4).ToString(new CultureInfo(1033)));
			if (!string.IsNullOrEmpty(this.Text))
			{
				((XmlElement)this.currentXmlScheme).SetAttribute("text", this.Text);
				((XmlElement)this.currentXmlScheme).SetAttribute("textVis", this.TextProperty.Visible.ToString());
				((XmlElement)this.currentXmlScheme).SetAttribute("textPos", ((int)this.TextProperty.Position).ToString());
				if (!base.UseSettingsText)
				{
					((XmlElement)this.currentXmlScheme).SetAttribute("FontName", this.TextProperty.FontName);
					((XmlElement)this.currentXmlScheme).SetAttribute("FontSize", this.TextProperty.FontSize.ToString(new CultureInfo(1033)));
					((XmlElement)this.currentXmlScheme).SetAttribute("FontBold", this.TextProperty.FontBold.ToString());
					((XmlElement)this.currentXmlScheme).SetAttribute("FontItalic", this.TextProperty.FontItalic.ToString());
					((XmlElement)this.currentXmlScheme).SetAttribute("FontUnderline", this.TextProperty.FontUnderline.ToString());
					((XmlElement)this.currentXmlScheme).SetAttribute("FontColor", this.TextProperty.Color.ToArgb().ToString());
				}
			}
		}

		public override int GetTypeObject()
		{
			return 111;
		}

		protected override bool SaveToSql()
		{
			if (this.couplingRealationsList_0.Count == 0)
			{
				return false;
			}
			int idBase = this.IdBase;
			if (base.SaveToSql())
			{
				if (this.IdBase != 0 && this.Parent != null && this.Parent.GetType() != typeof(LineCellTool) && (this.Parent.IdBase > 0 || this.Parent.GetType() == typeof(SplitterShinaTool)))
				{
					this.Parent.SaveXmlToSql();
				}
				return true;
			}
			return false;
		}

		public override bool ShowPropertyForm(Point location)
		{
			bool visible = this.TextProperty.Visible;
			if (new FormPointProperties(this, this.Layer.Parent.SqlSettings)
			{
				Location = location
			}.ShowDialog() == DialogResult.OK)
			{
				this.Layer.Parent.DoInvalidate(true);
				return true;
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			if (!this.disposed && disposing)
			{
				this.couplingRealationsList_0.Clear();
				this.currentXmlScheme = null;
				this.src.Clear();
			}
			base.Dispose(disposing);
		}

		[CompilerGenerated]
		private PointToolEventHandle pointToolEventHandle_0;

		[CompilerGenerated]
		private PointToolEventHandle pointToolEventHandle_1;

		[CompilerGenerated]
		private PointToolEventHandle pointToolEventHandle_2;

		public const int TYPE_POINT = 111;

		protected UnitPoint point;

		protected List<Branch> src;

		private TypePointTool typePointTool_0;

		private CouplingRealationsList couplingRealationsList_0;
	}
}
