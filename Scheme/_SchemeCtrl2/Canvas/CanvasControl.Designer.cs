using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using Constants;
using DataSql;
using FormLbr;
using FormLbr.Classes;
using netDxf;
using Passport.Classes;
using Passport.Controls;
using Passport.Forms;
using SchemeCtrl2.Calculations;
using SchemeCtrl2.Canvas.Forms;
using SchemeCtrl2.Data;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.DrawTool.FormsObj;
using SchemeCtrl2.Ercloud;
using SchemeCtrl2.Layers;
using SchemeCtrl2.Properties;
using SchemeCtrl2.SnapPoint;
using SchemeCtrl2.WCF;
using Telemetry;
using WeifenLuo.WinFormsUI.Docking;

namespace SchemeCtrl2.Canvas
{
	public class CanvasControl : UserControl, IDisposable
	{
		public int PagesHeigth
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public int PagesWidth
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		public int Pages
		{
			get
			{
				return this.int_0 * this.int_1;
			}
		}

		public WorkerCanvasPrint WorkerPrint { get; set; }

		internal string PrintOrg { get; set; }

		internal string SchmPrintName { get; set; }

		public void Print()
		{
			FormCanvasPrint formCanvasPrint = new FormCanvasPrint();
			formCanvasPrint.Canvas = this;
			formCanvasPrint.ShowDialog();
			formCanvasPrint.Dispose();
			GC.Collect();
		}

		private void method_0()
		{
			this.printDocument.DefaultPageSettings.Margins = new Margins(39, 39, 39, 39);
		}

		public void ShowPageSetupDialog()
		{
			this.pageSetupDialog_0.ShowDialog();
		}

		private void method_1(Graphics graphics_1, string string_7, Font font_0, SolidBrush solidBrush_0, RectangleF rectangleF_2)
		{
			for (;;)
			{
				SizeF sizeF = graphics_1.MeasureString(string_7, font_0);
				if (sizeF.Width < rectangleF_2.Width && sizeF.Height < rectangleF_2.Height)
				{
					break;
				}
				font_0 = new Font(font_0.FontFamily, font_0.Size - 0.5f);
			}
			graphics_1.DrawString(string_7, font_0, solidBrush_0, rectangleF_2);
		}

		private void method_2(Graphics graphics_1, string string_7, Font font_0, SolidBrush solidBrush_0, RectangleF rectangleF_2, bool bool_12)
		{
			for (;;)
			{
				SizeF sizeF = graphics_1.MeasureString(string_7, font_0);
				if (sizeF.Width < rectangleF_2.Width && sizeF.Height < rectangleF_2.Height)
				{
					if (!bool_12)
					{
						break;
					}
					SizeF sizeF2 = graphics_1.MeasureString(string_7, new Font(font_0.FontFamily, font_0.Size + 1f));
					if (sizeF2.Width >= rectangleF_2.Width || sizeF2.Height >= rectangleF_2.Height)
					{
						break;
					}
					font_0 = new Font(font_0.FontFamily, font_0.Size + 1f);
				}
				else
				{
					font_0 = new Font(font_0.FontFamily, font_0.Size - 0.5f);
				}
			}
			if (bool_12)
			{
				SizeF sizeF3 = graphics_1.MeasureString(string_7, font_0);
				rectangleF_2.Y += (rectangleF_2.Height - sizeF3.Height) / 2f;
				rectangleF_2.Height = sizeF3.Height;
			}
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			graphics_1.DrawString(string_7, font_0, solidBrush_0, rectangleF_2, stringFormat);
		}

		private void method_3(Graphics graphics_1, Rectangle rectangle_0, CanvasControl canvasControl_1)
		{
			RectangleF rectangleF = ConvertCanvas.ConvertToUnitNormalized(canvasControl_1, rectangle_0);
			RectangleF unitrect = new RectangleF(rectangleF.X + rectangleF.Width - 18.5f * (float)canvasControl_1.int_3, rectangleF.Y, 18.5f * (float)canvasControl_1.int_3, (float)(4 * canvasControl_1.int_3));
			RectangleF rectangleF2 = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, unitrect);
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_3)), new PointF(rectangleF2.X, rectangleF2.Y), new PointF(rectangleF2.X, rectangleF2.Y + rectangleF2.Height));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_3)), new PointF(rectangleF2.X, rectangleF2.Y), new PointF((float)rectangle_0.Right, rectangleF2.Y));
			graphics_1.DrawString("Имз Лист", new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), new PointF(rectangleF2.X, rectangleF2.Y));
			PointF pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 1.7f * (float)canvasControl_1.int_3), (double)unitrect.Y));
			PointF pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 1.7f * (float)canvasControl_1.int_3), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_3)), pointF, pointF2);
			graphics_1.DrawString("№ документа", new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), pointF2);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 4f * (float)canvasControl_1.int_3), (double)unitrect.Y));
			pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 4f * (float)canvasControl_1.int_3), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_3)), pointF, pointF2);
			graphics_1.DrawString("Подпись", new Font("Microsoft Sans Serif", 8.5f * (float)this.int_3), new SolidBrush(Color.Black), pointF2);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 5.5f * (float)canvasControl_1.int_3), (double)unitrect.Y));
			pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 5.5f * (float)canvasControl_1.int_3), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_3)), pointF, pointF2);
			graphics_1.DrawString("Дата", new Font("Microsoft Sans Serif", 8.5f * (float)this.int_3), new SolidBrush(Color.Black), pointF2);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 6.5f * (float)canvasControl_1.int_3), (double)unitrect.Y));
			pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 6.5f * (float)canvasControl_1.int_3), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_3)), pointF, pointF2);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 13.5f * (float)canvasControl_1.int_3), (double)unitrect.Y));
			pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 13.5f * (float)canvasControl_1.int_3), (double)(unitrect.Y + unitrect.Height + 0.5f * (float)canvasControl_1.int_3)));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_3)), pointF, pointF2);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 15f * (float)canvasControl_1.int_3), (double)(unitrect.Y + 2f * (float)canvasControl_1.int_3)));
			pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 15f * (float)canvasControl_1.int_3), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_3)), pointF, pointF2);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 16.7f * (float)canvasControl_1.int_3), (double)(unitrect.Y + 2f * (float)canvasControl_1.int_3)));
			pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 16.7f * (float)canvasControl_1.int_3), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_3)), pointF, pointF2);
			for (int i = 1; i < 8; i++)
			{
				pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)unitrect.X, (double)(unitrect.Y + (float)i * 0.5f * (float)canvasControl_1.int_3)));
				pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 1.7f * (float)canvasControl_1.int_3), (double)(unitrect.Y + (float)i * 0.5f * (float)canvasControl_1.int_3)));
				RectangleF rectangleF_ = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, new RectangleF(unitrect.X, unitrect.Y + (float)i * 0.5f * (float)canvasControl_1.int_3 - 0.5f * (float)canvasControl_1.int_3, 1.7f * (float)canvasControl_1.int_3, 0.4f * (float)canvasControl_1.int_3));
				RectangleF rectangleF_2 = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, new RectangleF(unitrect.X + 1.7f * (float)canvasControl_1.int_3, unitrect.Y + (float)i * 0.5f * (float)canvasControl_1.int_3 - 0.5f * (float)canvasControl_1.int_3, 2.3f * (float)canvasControl_1.int_3, 0.4f * (float)canvasControl_1.int_3));
				switch (i)
				{
				case 2:
					if (this.WorkerPrint != null)
					{
						if (!string.IsNullOrEmpty(this.WorkerPrint.ChiefDistrict.Title))
						{
							this.method_1(graphics_1, this.WorkerPrint.ChiefDistrict.Title, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), rectangleF_);
						}
						if (!string.IsNullOrEmpty(this.WorkerPrint.ChiefDistrict.FIO))
						{
							this.method_1(graphics_1, this.WorkerPrint.ChiefDistrict.FIO, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), rectangleF_2);
						}
					}
					break;
				case 3:
					if (this.WorkerPrint != null)
					{
						if (!string.IsNullOrEmpty(this.WorkerPrint.Master.Title))
						{
							this.method_1(graphics_1, this.WorkerPrint.Master.Title, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), rectangleF_);
						}
						if (!string.IsNullOrEmpty(this.WorkerPrint.Master.FIO))
						{
							this.method_1(graphics_1, this.WorkerPrint.Master.FIO, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), rectangleF_2);
						}
					}
					break;
				case 4:
					if (this.WorkerPrint != null)
					{
						if (!string.IsNullOrEmpty(this.WorkerPrint.Technician.Title))
						{
							this.method_1(graphics_1, this.WorkerPrint.Technician.Title, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), rectangleF_);
						}
						if (!string.IsNullOrEmpty(this.WorkerPrint.Technician.FIO))
						{
							this.method_1(graphics_1, this.WorkerPrint.Technician.FIO, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), rectangleF_2);
						}
					}
					break;
				case 5:
					if (this.WorkerPrint != null)
					{
						if (!string.IsNullOrEmpty(this.WorkerPrint.ZamChief.Title))
						{
							this.method_1(graphics_1, this.WorkerPrint.ZamChief.Title, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), rectangleF_);
						}
						if (!string.IsNullOrEmpty(this.WorkerPrint.ZamChief.FIO))
						{
							this.method_1(graphics_1, this.WorkerPrint.ZamChief.FIO, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), rectangleF_2);
						}
					}
					break;
				case 6:
					if (this.WorkerPrint != null)
					{
						if (!string.IsNullOrEmpty(this.WorkerPrint.Electrician.Title))
						{
							this.method_1(graphics_1, this.WorkerPrint.Electrician.Title, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), rectangleF_);
						}
						if (!string.IsNullOrEmpty(this.WorkerPrint.Electrician.FIO))
						{
							this.method_1(graphics_1, this.WorkerPrint.Electrician.FIO, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), rectangleF_2);
						}
					}
					break;
				}
				pointF2 = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 6.5f * (float)canvasControl_1.int_3), (double)(unitrect.Y + (float)i * 0.5f * (float)canvasControl_1.int_3)));
				if (i == 4)
				{
					pointF2.X = (float)rectangle_0.Right;
				}
				graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_3)), pointF, pointF2);
			}
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 13.5f * (float)canvasControl_1.int_3), (double)(unitrect.Y + unitrect.Height + 0.5f * (float)canvasControl_1.int_3)));
			pointF2 = new PointF((float)rectangle_0.Right, pointF.Y);
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_3)), pointF, pointF2);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 13.5f * (float)canvasControl_1.int_3), (double)(unitrect.Y + unitrect.Height - 0.5f * (float)canvasControl_1.int_3)));
			pointF2 = new PointF((float)rectangle_0.Right, pointF.Y);
			graphics_1.DrawLine(new Pen(Color.Black, (float)(2 * canvasControl_1.int_3)), pointF, pointF2);
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Center;
			stringFormat.LineAlignment = StringAlignment.Center;
			RectangleF rectangleF3 = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, new RectangleF(unitrect.X + 6.5f * (float)canvasControl_1.int_3, unitrect.Y + (float)(2 * canvasControl_1.int_3), (float)(7 * canvasControl_1.int_3), (float)(2 * canvasControl_1.int_3)));
			if (!string.IsNullOrEmpty(this.SchmPrintName))
			{
				this.method_2(graphics_1, this.SchmPrintName, new Font("Microsoft Sans Serif", 16f * (float)canvasControl_1.int_3, FontStyle.Bold), new SolidBrush(Color.Black), rectangleF3, false);
			}
			rectangleF3 = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, new RectangleF(unitrect.X + 6.5f * (float)canvasControl_1.int_3, unitrect.Y, (float)(7 * canvasControl_1.int_3), (float)(2 * canvasControl_1.int_3)));
			graphics_1.DrawString("Однолинейная схема \nэлектрических соединений_______________", new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), rectangleF3, stringFormat);
			rectangleF3 = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, new RectangleF(unitrect.X + 13.5f * (float)canvasControl_1.int_3, unitrect.Y, (float)(5 * canvasControl_1.int_3), (float)(2 * canvasControl_1.int_3)));
			if (!string.IsNullOrEmpty(this.PrintOrg))
			{
				this.method_2(graphics_1, this.PrintOrg, new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), rectangleF3, true);
			}
			rectangleF3 = ConvertCanvas.ConvertToScreenNormalized(canvasControl_1, new RectangleF(unitrect.X + 13.5f * (float)canvasControl_1.int_3, unitrect.Y + unitrect.Height, (float)(5 * canvasControl_1.int_3), 0.5f * (float)canvasControl_1.int_3));
			graphics_1.DrawString(DateTime.Now.ToString("dd.MM.yyyy"), new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3, FontStyle.Bold), new SolidBrush(Color.Black), rectangleF3, stringFormat);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 13.5f * (float)canvasControl_1.int_3), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawString("Стадия", new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), pointF);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 15f * (float)canvasControl_1.int_3), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawString("Лист", new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), pointF);
			pointF = ConvertCanvas.ConvertToScreen(canvasControl_1, new UnitPoint((double)(unitrect.X + 16.7f * (float)canvasControl_1.int_3), (double)(unitrect.Y + unitrect.Height)));
			graphics_1.DrawString("Листов", new Font("Microsoft Sans Serif", 8.5f * (float)canvasControl_1.int_3), new SolidBrush(Color.Black), pointF);
		}

		internal int KoefResolution
		{
			get
			{
				return this.int_3;
			}
		}

		private void printDocument_BeginPrint(object sender, PrintEventArgs e)
		{
			Func<DrawObjectBase, RectangleF> func = null;
			Func<DrawObjectBase, RectangleF> func2 = null;
			this.int_2 = 0;
			if (sender.GetType() != typeof(PrintDocument))
			{
				e.Cancel = true;
				return;
			}
			this.canvasControl_0 = new CanvasControl();
			this.canvasControl_0.int_3 = 5 / ((this.int_0 > this.int_1) ? this.int_0 : this.int_1);
			PrintDocument printDocument = (PrintDocument)sender;
			Rectangle rectangle = new Rectangle(0, 0, (printDocument.DefaultPageSettings.Bounds.Width - (printDocument.DefaultPageSettings.Margins.Left + printDocument.DefaultPageSettings.Margins.Right)) * this.int_1 * this.canvasControl_0.int_3, (printDocument.DefaultPageSettings.Bounds.Height - (printDocument.DefaultPageSettings.Margins.Bottom + printDocument.DefaultPageSettings.Margins.Top)) * this.int_0 * this.canvasControl_0.int_3);
			this.bitmap_0 = new Bitmap(rectangle.Width, rectangle.Height);
			Graphics graphics = Graphics.FromImage(this.bitmap_0);
			graphics.Clear(Color.White);
			Rectangle rectangle_ = rectangle;
			graphics.DrawRectangle(new Pen(Color.Black, (float)(2 * this.canvasControl_0.int_3)), new Rectangle(rectangle_.X + 2 * this.canvasControl_0.int_3, rectangle_.Y + 2 * this.canvasControl_0.int_3, rectangle_.Width - 2 * this.canvasControl_0.int_3, rectangle_.Height - 2 * this.canvasControl_0.int_3));
			if (this.isPrintFrame)
			{
				this.method_3(graphics, rectangle_, this.canvasControl_0);
			}
			this.canvasControl_0.Location = rectangle_.Location;
			if (this.isPrintFrame)
			{
				int num = (int)ConvertCanvas.ConvertToScreen(this.canvasControl_0, (double)(4.5f * (float)this.canvasControl_0.int_3));
				rectangle_.Height -= num;
				graphics.ExcludeClip(new Rectangle(0, rectangle.Height - num, rectangle.Width, rectangle.Height - (rectangle.Y + rectangle.Height - num)));
			}
			this.canvasControl_0.Settings = this.canvasSettings_0.Clone();
			this.canvasControl_0.Settings.BackFlashingColor = Color.White;
			this.canvasControl_0.Settings.BackgroundColor = Color.White;
			this.canvasControl_0.Size = rectangle_.Size;
			this.canvasControl_0.Graphics = graphics;
			Rectangle clientRectangle = base.ClientRectangle;
			RectangleF rectangleF = ConvertCanvas.ConvertToUnitNormalized(this, clientRectangle);
			switch (this.enum3_0)
			{
			case Enum3.const_0:
				if (this.SelectedCount > 0)
				{
					this.canvasControl_0.SetObjectsInCenterScreen(this.SelectedObjects.ToList<DrawObjectBase>(), true, CanvasControl.SetObjectsInCenterScreenOptions.none);
					this.Graphics = Graphics.FromHwnd(base.Handle);
					IEnumerable<DrawObjectBase> selectedObjects = this.SelectedObjects;
					if (CanvasControl.func_5 == null)
					{
						CanvasControl.func_5 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_7);
					}
					IEnumerable<DrawObjectBase> source = selectedObjects.Where(CanvasControl.func_5);
					if (func2 == null)
					{
						func2 = new Func<DrawObjectBase, RectangleF>(this.method_84);
					}
					IEnumerable<RectangleF> enumerable = source.Select(func2);
					IEnumerable<RectangleF> source2 = enumerable;
					if (CanvasControl.func_6 == null)
					{
						CanvasControl.func_6 = new Func<RectangleF, float>(CanvasControl.smethod_8);
					}
					float num2 = source2.Min(CanvasControl.func_6);
					IEnumerable<RectangleF> source3 = enumerable;
					if (CanvasControl.func_7 == null)
					{
						CanvasControl.func_7 = new Func<RectangleF, float>(CanvasControl.smethod_9);
					}
					float num3 = source3.Min(CanvasControl.func_7);
					IEnumerable<RectangleF> source4 = enumerable;
					if (CanvasControl.func_8 == null)
					{
						CanvasControl.func_8 = new Func<RectangleF, float>(CanvasControl.smethod_10);
					}
					float num4 = source4.Max(CanvasControl.func_8);
					IEnumerable<RectangleF> source5 = enumerable;
					if (CanvasControl.func_9 == null)
					{
						CanvasControl.func_9 = new Func<RectangleF, float>(CanvasControl.smethod_11);
					}
					float num5 = source5.Max(CanvasControl.func_9);
					rectangleF = new RectangleF(num2, num3, num4 - num2, num5 - num3);
					this.canvasControl_0.SetCenter(new UnitPoint((double)(rectangleF.X + rectangleF.Width / 2f), (double)(rectangleF.Y + rectangleF.Height / 2f)));
					this.canvasControl_0.DoInvalidate(true);
				}
				break;
			case Enum3.const_1:
			{
				List<DrawObjectBase> list = new List<DrawObjectBase>();
				foreach (ICanvasLayer canvasLayer in this.Layers)
				{
					DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
					foreach (DrawObjectBase drawObjectBase in drawingLayer.Objects)
					{
						if (drawObjectBase.Visible)
						{
							list.Add(drawObjectBase);
						}
					}
				}
				this.canvasControl_0.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
				List<DrawObjectBase> list2 = new List<DrawObjectBase>();
				foreach (ICanvasLayer canvasLayer2 in this.Layers)
				{
					DrawingLayer drawingLayer2 = (DrawingLayer)canvasLayer2;
					list2.AddRange(drawingLayer2.Objects);
				}
				this.Graphics = Graphics.FromHwnd(base.Handle);
				IEnumerable<DrawObjectBase> source6 = list2;
				if (CanvasControl.func_0 == null)
				{
					CanvasControl.func_0 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_2);
				}
				IEnumerable<DrawObjectBase> source7 = source6.Where(CanvasControl.func_0);
				if (func == null)
				{
					func = new Func<DrawObjectBase, RectangleF>(this.method_83);
				}
				IEnumerable<RectangleF> enumerable2 = source7.Select(func);
				IEnumerable<RectangleF> source8 = enumerable2;
				if (CanvasControl.func_1 == null)
				{
					CanvasControl.func_1 = new Func<RectangleF, float>(CanvasControl.smethod_3);
				}
				float num6 = source8.Min(CanvasControl.func_1);
				IEnumerable<RectangleF> source9 = enumerable2;
				if (CanvasControl.func_2 == null)
				{
					CanvasControl.func_2 = new Func<RectangleF, float>(CanvasControl.smethod_4);
				}
				float num7 = source9.Min(CanvasControl.func_2);
				IEnumerable<RectangleF> source10 = enumerable2;
				if (CanvasControl.func_3 == null)
				{
					CanvasControl.func_3 = new Func<RectangleF, float>(CanvasControl.smethod_5);
				}
				float num8 = source10.Max(CanvasControl.func_3);
				IEnumerable<RectangleF> source11 = enumerable2;
				if (CanvasControl.func_4 == null)
				{
					CanvasControl.func_4 = new Func<RectangleF, float>(CanvasControl.smethod_6);
				}
				float num9 = source11.Max(CanvasControl.func_4);
				rectangleF = new RectangleF(num6, num7, num8 - num6, num9 - num7);
				this.canvasControl_0.SetCenter(new UnitPoint((double)(rectangleF.X + rectangleF.Width / 2f), (double)(rectangleF.Y + rectangleF.Height / 2f)));
				break;
			}
			case Enum3.const_2:
				this.canvasControl_0.SetCenter(new UnitPoint((double)(rectangleF.X + rectangleF.Width / 2f), (double)(rectangleF.Y + rectangleF.Height / 2f)));
				break;
			case Enum3.const_3:
				if (this.canvasFrame_0 != null)
				{
					this.canvasFrame_0.Normalize();
					rectangleF = this.canvasFrame_0.Rectangle;
					this.canvasControl_0.SetCenter(new UnitPoint((double)(rectangleF.X + rectangleF.Width / 2f), (double)(rectangleF.Y + rectangleF.Height / 2f)));
					this.canvasControl_0.DoInvalidate(true);
				}
				break;
			}
			rectangleF.Inflate(new SizeF(1f, 1f));
			rectangleF.Y += 0.2f;
			RectangleF rectangleF2 = ConvertCanvas.ConvertToUnitNormalized(this.canvasControl_0, this.canvasControl_0.ClientRectangle);
			float num10;
			if (rectangleF.Height / rectangleF.Width <= rectangleF2.Height / rectangleF2.Width)
			{
				num10 = 1f * rectangleF.Width / rectangleF2.Width;
			}
			else
			{
				num10 = 1f * rectangleF.Height / rectangleF2.Height;
			}
			this.canvasControl_0.Zoom /= num10;
			PointF pointF = new PointF(rectangleF.X + rectangleF.Width / 2f, rectangleF.Y + rectangleF.Height / 2f);
			this.canvasControl_0.SetCenter(new UnitPoint(pointF));
			this.canvasControl_0.Location = rectangle_.Location;
			this.Graphics = Graphics.FromHwnd(base.Handle);
			this.canvasControl_0.Graphics = graphics;
			RectangleF rectangleF3 = ConvertCanvas.ConvertToScreenNormalized(this.canvasControl_0, rectangleF);
			graphics.ExcludeClip(new Rectangle(0, 0, (int)rectangleF3.X + 10 * this.canvasControl_0.int_3, rectangle.Height));
			graphics.ExcludeClip(new Rectangle(0, 0, rectangle.Width, (int)rectangleF3.Y + 10 * this.canvasControl_0.int_3));
			graphics.ExcludeClip(new Rectangle((int)(rectangleF3.X + rectangleF3.Width - (float)(10 * this.canvasControl_0.int_3)), 0, rectangle.Width - (int)(rectangleF3.X + rectangleF3.Width) + 10 * this.canvasControl_0.int_3, rectangle.Height));
			graphics.ExcludeClip(new Rectangle(0, (int)(rectangleF3.Y + rectangleF3.Height), rectangle.Width, rectangle.Height - (int)(rectangleF3.Y + rectangleF3.Height)));
			eDrawMode eDrawMode = eDrawMode.Print;
			if (this.bool_0)
			{
				eDrawMode |= eDrawMode.Color;
			}
			foreach (ICanvasLayer canvasLayer3 in this.list_0)
			{
				DrawingLayer drawingLayer3 = (DrawingLayer)canvasLayer3;
				foreach (DrawObjectBase drawObjectBase2 in drawingLayer3.Objects)
				{
					switch (this.enum3_0)
					{
					case Enum3.const_0:
						if (drawObjectBase2.Selected)
						{
							drawObjectBase2.Draw(this.canvasControl_0, rectangleF, eDrawMode);
						}
						break;
					case Enum3.const_1:
						drawObjectBase2.Draw(this.canvasControl_0, rectangleF, eDrawMode);
						break;
					case Enum3.const_2:
						if (drawObjectBase2.ObjectInRectangle(this, rectangleF, true))
						{
							drawObjectBase2.Draw(this.canvasControl_0, rectangleF, eDrawMode);
						}
						break;
					case Enum3.const_3:
						if (this.canvasFrame_0 != null && drawObjectBase2.ObjectInRectangle(this, rectangleF, true))
						{
							drawObjectBase2.Draw(this.canvasControl_0, rectangleF, eDrawMode);
						}
						break;
					}
				}
			}
			graphics.Dispose();
		}

		private void printDocument_EndPrint(object sender, PrintEventArgs e)
		{
			this.bitmap_0.Dispose();
			GC.Collect();
		}

		private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.ExcludeClip(new Rectangle(0, 0, e.MarginBounds.X, e.PageBounds.Height));
			graphics.ExcludeClip(new Rectangle(0, 0, e.PageBounds.Width, e.MarginBounds.Location.Y));
			graphics.ExcludeClip(new Rectangle(e.MarginBounds.X + e.MarginBounds.Width, 0, e.PageBounds.Width - (e.MarginBounds.X + e.MarginBounds.Width), e.PageBounds.Height));
			graphics.ExcludeClip(new Rectangle(0, e.MarginBounds.Y + e.MarginBounds.Height, e.PageBounds.Width, e.PageBounds.Height - (e.MarginBounds.Y + e.MarginBounds.Height)));
			int num = this.int_2 / this.int_1;
			int num2 = this.int_2 % this.int_1;
			Point point = new Point(num2 * e.MarginBounds.Width, num * e.MarginBounds.Height);
			Size size = new Size(e.MarginBounds.Width, e.MarginBounds.Height);
			Rectangle destRect = new Rectangle(new Point(e.MarginBounds.X, e.MarginBounds.Y), size);
			Rectangle srcRect = new Rectangle(point.X * this.canvasControl_0.int_3, point.Y * this.canvasControl_0.int_3, size.Width * this.canvasControl_0.int_3, size.Height * this.canvasControl_0.int_3);
			graphics.DrawImage(this.bitmap_0, destRect, srcRect, GraphicsUnit.Pixel);
			this.int_2++;
			e.HasMorePages = (this.int_2 < this.Pages);
		}

		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CanvasControl));
			this.statusStrip = new StatusStrip();
			this.labelMousePosition = new ToolStripStatusLabel();
			this.toolBtnZoom = new ToolStripSplitButton();
			this.toolTxtZoomChanged = new ToolStripTextBox();
			this.toolBtnZoom800 = new ToolStripMenuItem();
			this.toolBtnZoom400 = new ToolStripMenuItem();
			this.toolBtnZoom200 = new ToolStripMenuItem();
			this.toolBtnZoom150 = new ToolStripMenuItem();
			this.toolBtnZoom125 = new ToolStripMenuItem();
			this.toolBtnZoom100 = new ToolStripMenuItem();
			this.toolBtnZoom75 = new ToolStripMenuItem();
			this.toolBtnZoom50 = new ToolStripMenuItem();
			this.toolBtnZoom25 = new ToolStripMenuItem();
			this.labelInfo = new ToolStripStatusLabel();
			this.toolLabelEmpty = new ToolStripStatusLabel();
			this.labelProgressBar = new ToolStripStatusLabel();
			this.toolProgressBarSave = new ToolStripProgressBar();
			this.toolStripStatusLabelConnected = new ToolStripStatusLabel();
			this.dataSetScheme_0 = new DataSetScheme();
			this.printDocument = new PrintDocument();
			this.printDialog = new PrintDialog();
			this.pageSetupDialog_0 = new PageSetupDialog();
			this.printPreviewDialog = new PrintPreviewDialog();
			this.propertyGrid1 = new PropertyGrid();
			this.bigBoldButton = new Button();
			this.buttonCheck = new Button();
			this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
			this.tbPopup = new Label();
			this.contextMenuSelectedObjects = new ContextMenuStrip(this.icontainer_0);
			this.toolMenuItemFilterSelectedObjects = new ToolStripMenuItem();
			this.toolMenuItemAddFilterSelectedObjects = new ToolStripMenuItem();
			this.toolMenuItemDeleteFilterSelectedObjects = new ToolStripMenuItem();
			this.toolStripSeparator4 = new ToolStripSeparator();
			this.toolStripMenuItemBookmark = new ToolStripMenuItem();
			this.toolStripMenuItemRemoveBookmark = new ToolStripMenuItem();
			this.toolStripSeparator9 = new ToolStripSeparator();
			this.toolMenuItemSelectedPowerBullshit = new ToolStripMenuItem();
			this.toolMenuItemSelectedAlign = new ToolStripMenuItem();
			this.toolMenuItemSelectedAlignByTop = new ToolStripMenuItem();
			this.toolMenuItemSelectedAlignByBottom = new ToolStripMenuItem();
			this.toolMenuItemSelectedAlignByRigth = new ToolStripMenuItem();
			this.toolMenuItemSelectedAlignByLeft = new ToolStripMenuItem();
			this.toolMenuItemSelectedAlignByHorCenter = new ToolStripMenuItem();
			this.toolMenuItemSelectedAlignByVertCenter = new ToolStripMenuItem();
			this.toolStripSeparator13 = new ToolStripSeparator();
			this.toolStripMenuItemGroupSelectedObject = new ToolStripMenuItem();
			this.toolStripMenuItemGroupProperty = new ToolStripMenuItem();
			this.toolStripSeparatorGroup = new ToolStripSeparator();
			this.toolMenuItemCenterSElectedObjects = new ToolStripMenuItem();
			this.toolMenuItemCopySelectedObjects = new ToolStripMenuItem();
			this.toolMenuItemCopySelectedObjectsToImage = new ToolStripMenuItem();
			this.toolMenuItemExportSelectedObjectsToDXF = new ToolStripMenuItem();
			this.toolMenuItemPasteSelectedObjects = new ToolStripMenuItem();
			this.toolMenuItemDeleteSelectedObjects = new ToolStripMenuItem();
			this.contextMenuRectnagle = new ContextMenuStrip(this.icontainer_0);
			this.toolMenuItemRectPowerSource = new ToolStripMenuItem();
			this.toolMenuItemRectRecipientsPower = new ToolStripMenuItem();
			this.toolStripSeparator10 = new ToolStripSeparator();
			this.toolMenuItemRectFilter = new ToolStripMenuItem();
			this.toolMenuItemRectFilterAdd = new ToolStripMenuItem();
			this.toolMenuItemRectFilterDel = new ToolStripMenuItem();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.toolMenuItemRectCopy = new ToolStripMenuItem();
			this.toolMenuItemRectPaste = new ToolStripMenuItem();
			this.toolMenuItemRectDel = new ToolStripMenuItem();
			this.toolStripMenuItemRectanglePosition = new ToolStripMenuItem();
			this.toolStripMenuItemReflect = new ToolStripMenuItem();
			this.toolStripMenuItemVReflect = new ToolStripMenuItem();
			this.toolStripMenuItemHReflect = new ToolStripMenuItem();
			this.toolStripMenuItemRotateRectangle = new ToolStripMenuItem();
			this.toolStripMenuItemRotate90 = new ToolStripMenuItem();
			this.toolStripMenuItemRotate180 = new ToolStripMenuItem();
			this.toolStripMenuItemRotate170 = new ToolStripMenuItem();
			this.toolMenuItemRectAlign = new ToolStripMenuItem();
			this.toolStripMenuItemAdjacentSubstation = new ToolStripMenuItem();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.toolMenuItemRectFile = new ToolStripMenuItem();
			this.toolMenuItemRectProperty = new ToolStripMenuItem();
			this.contextMenuShina = new ContextMenuStrip(this.icontainer_0);
			this.toolMenuItemShinaAddChild = new ToolStripMenuItem();
			this.toolMenuItemShinaAddCell = new ToolStripMenuItem();
			this.toolMenuItemShinaBridge = new ToolStripMenuItem();
			this.toolMenuItemShinaSplitter = new ToolStripMenuItem();
			this.toolStripMenuItemAddWhitePoint = new ToolStripMenuItem();
			this.toolMeniItemShinaAddPattern = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn1 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn2 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn3 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn4 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn5 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn6 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn7 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn8 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn9 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbn10 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto1 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto2 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto3 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto4 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto5 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto6 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto7 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto8 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto9 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnAuto10 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve1 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve2 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve3 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve4 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve5 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve6 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve7 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve8 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve9 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnReserve10 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS1 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS2 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS3 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS4 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS5 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS6 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS7 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS8 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS9 = new ToolStripMenuItem();
			this.toolMenuItemShinaAddPatternAbnRPS10 = new ToolStripMenuItem();
			this.toolStripSeparator7 = new ToolStripSeparator();
			this.toolStripMenuItemMeasurement = new ToolStripMenuItem();
			this.toolStripMenuItemShinaAddTelemetryLabel = new ToolStripMenuItem();
			this.toolMenuItemShinaCopy = new ToolStripMenuItem();
			this.toolMenuItemShinaPaste = new ToolStripMenuItem();
			this.toolMenuItemShinaDel = new ToolStripMenuItem();
			this.toolStripSeparatorEditShina = new ToolStripSeparator();
			this.toolStripMenuItemBusMeasurement = new ToolStripMenuItem();
			this.toolMenuItemShinaPowerSource = new ToolStripMenuItem();
			this.toolStripMenuItem2 = new ToolStripMenuItem();
			this.toolStripMenuItem5 = new ToolStripMenuItem();
			this.toolMenuItemShinaRecipientsPower = new ToolStripMenuItem();
			this.toolStripMenuItem3 = new ToolStripMenuItem();
			this.toolStripMenuItem4 = new ToolStripMenuItem();
			this.toolStripMenuItem11 = new ToolStripMenuItem();
			this.toolStripMenuItemAllPower = new ToolStripMenuItem();
			this.toolStripMenuItemAdjacentSubstation2 = new ToolStripMenuItem();
			this.toolStripMenuItemShinaGetOldAbn = new ToolStripMenuItem();
			this.toolStripMenuItemShinaOldAbnCurrentRect = new ToolStripMenuItem();
			this.toolStripMenuItemShinaOldAbnNextRect = new ToolStripMenuItem();
			this.toolStripSeparator3 = new ToolStripSeparator();
			this.toolMenuItemShinaFilter = new ToolStripMenuItem();
			this.toolMenuItemShinaFilterAdd = new ToolStripMenuItem();
			this.toolMenuItemShinaFilterDel = new ToolStripMenuItem();
			this.toolStripSeparator11 = new ToolStripSeparator();
			this.toolMenuItemShinaFile = new ToolStripMenuItem();
			this.toolMenuItemShinaProperty = new ToolStripMenuItem();
			this.contextMenuSwitchTool = new ContextMenuStrip(this.icontainer_0);
			this.toolMenuItemSwitchPassport = new ToolStripMenuItem();
			this.toolMenuItemSwitchOn = new ToolStripMenuItem();
			this.toolMenuItemSwitchFilter = new ToolStripMenuItem();
			this.toolMenuItemSwitchFilterAdd = new ToolStripMenuItem();
			this.toolMenuItemSwitchFilterDel = new ToolStripMenuItem();
			this.toolStripMenuItemOOLDisplayGrLevel = new ToolStripMenuItem();
			this.toolStripMenuItemSwitchAddTelemetry = new ToolStripMenuItem();
			this.toolMenuItemSwitchErcloud = new ToolStripMenuItem();
			this.toolMenuItemSwitchLinkErcloud = new ToolStripMenuItem();
			this.toolMenuItemSwitchShowDataErcloud = new ToolStripMenuItem();
			this.toolStripSeparator12 = new ToolStripSeparator();
			this.toolStripMenuItemCSRollingOut = new ToolStripMenuItem();
			this.toolStripMenuItemCSRepairMode = new ToolStripMenuItem();
			this.toolStripMenuItemCSTestMode = new ToolStripMenuItem();
			this.toolStripMenuItemCSNormalMode = new ToolStripMenuItem();
			this.toolStripSeparatorCS = new ToolStripSeparator();
			this.toolMenuItemStateDel = new ToolStripMenuItem();
			this.toolMenuItemSwitchCopy = new ToolStripMenuItem();
			this.toolMenuItemSwitchDel = new ToolStripMenuItem();
			this.toolStripSeparator5 = new ToolStripSeparator();
			this.ToolStripMenuItemSwitchMeasurement = new ToolStripMenuItem();
			this.toolMenuItemSwitchLogDispatcher = new ToolStripMenuItem();
			this.toolMenuItemSwitchFile = new ToolStripMenuItem();
			this.toolMenuItemSwitchProperty = new ToolStripMenuItem();
			this.contextMenuLineTool = new ContextMenuStrip(this.icontainer_0);
			this.toolMenuItemLineAddChild = new ToolStripMenuItem();
			this.toolMenuItemLineAddBranch = new ToolStripMenuItem();
			this.toolMenuItemLineAddPoint = new ToolStripMenuItem();
			this.toolStripSeparatorLineAddBranchPoint = new ToolStripSeparator();
			this.toolMenuItemLineAddOutsideLineDisconnector = new ToolStripMenuItem();
			this.toolMenuItemLineAddVacuumSwitch = new ToolStripMenuItem();
			this.toolMenuItemLineAddTransformer = new ToolStripMenuItem();
			this.toolMenuItemLineAddVoltageTransformer = new ToolStripMenuItem();
			this.toolStripMenuItemAddAmperageTransformerTool = new ToolStripMenuItem();
			this.toolMenuItemLineAddLoadSwitch = new ToolStripMenuItem();
			this.toolMenuItemLineAddLoadSwitchWaxwork = new ToolStripMenuItem();
			this.toolMenuItemLineAddRPS = new ToolStripMenuItem();
			this.toolMenuItemLineAddLinearDisconnector = new ToolStripMenuItem();
			this.toolMenuItemLineAddLinearDisconnectorWaxwork = new ToolStripMenuItem();
			this.toolMenuItemLineAddLubricantDisconnector = new ToolStripMenuItem();
			this.toolMenuItemLineAddFuseTool = new ToolStripMenuItem();
			this.toolMenuItemLineAddDischargerTool = new ToolStripMenuItem();
			this.toolMenuItemLineAddVoltageLimetedTool = new ToolStripMenuItem();
			this.toolMenuItemLineAddEndTrim = new ToolStripMenuItem();
			this.toolMenuItemLineAddCircuitBreakerTool = new ToolStripMenuItem();
			this.toolMenuItemLineAddGroundingTool = new ToolStripMenuItem();
			this.toolMenuItemLineAddSeparatorTool = new ToolStripMenuItem();
			this.toolStripMenuItemAddMagneticStarterTool = new ToolStripMenuItem();
			this.toolStripMenuItemAddElectricMeter = new ToolStripMenuItem();
			this.toolStripSeparator6 = new ToolStripSeparator();
			this.toolMenuItemAddLineText = new ToolStripMenuItem();
			this.toolMenuItemLineCopy = new ToolStripMenuItem();
			this.toolMenuItemLinePaste = new ToolStripMenuItem();
			this.toolStripMenuItemDevideLine = new ToolStripMenuItem();
			this.toolStripMenuItemDisconnectLine = new ToolStripMenuItem();
			this.toolMenuItemLineDel = new ToolStripMenuItem();
			this.toolMenuItemLineDelObj = new ToolStripMenuItem();
			this.toolMenuItemLineDelPoint = new ToolStripMenuItem();
			this.toolStripSeparatorEditLine = new ToolStripSeparator();
			this.toolMenuItemLineSetStatus = new ToolStripMenuItem();
			this.toolMenuItemLineSetStatusGrounding = new ToolStripMenuItem();
			this.toolMenuItemLineSetStatusBrakeDown = new ToolStripMenuItem();
			this.toolMenuItemLineSetStatusOff = new ToolStripMenuItem();
			this.toolMenuItemLineSetStatusNoPhased = new ToolStripMenuItem();
			this.toolMenuItemLineSetStatusArrow = new ToolStripMenuItem();
			this.toolStripSeparatorSetStatus = new ToolStripSeparator();
			this.toolMenuItemLineTextHere = new ToolStripMenuItem();
			this.toolStripSeparatorLineTextHere = new ToolStripSeparator();
			this.toolMenuItemLineFilter = new ToolStripMenuItem();
			this.toolMenuItemLineFilterAdd = new ToolStripMenuItem();
			this.toolMenuItemLineFilterDel = new ToolStripMenuItem();
			this.toolMenuItemLinePowerSource = new ToolStripSeparator();
			this.toolStripMenuItem1 = new ToolStripMenuItem();
			this.toolStripMenuItem6 = new ToolStripMenuItem();
			this.toolStripMenuItem8 = new ToolStripMenuItem();
			this.toolMenuItemLineRecipientsPower = new ToolStripMenuItem();
			this.toolStripMenuItem7 = new ToolStripMenuItem();
			this.toolStripMenuItem9 = new ToolStripMenuItem();
			this.toolStripMenuItem10 = new ToolStripMenuItem();
			this.toolStripMenuItem12 = new ToolStripMenuItem();
			this.toolStripMenuItem13 = new ToolStripMenuItem();
			this.toolStripMenuItem14 = new ToolStripMenuItem();
			this.toolStripMenuItemLineAddTelemertryLabel = new ToolStripMenuItem();
			this.toolStripSeparator8 = new ToolStripSeparator();
			this.toolMenuItemLinePropertyPoint = new ToolStripMenuItem();
			this.toolStripMenuItemLineAlignBranch = new ToolStripMenuItem();
			this.toolStripMenuItemAlignBranchByTop = new ToolStripMenuItem();
			this.toolStripMenuItemAlignBranchByBottom = new ToolStripMenuItem();
			this.toolStripMenuItemAlignBranchByRigth = new ToolStripMenuItem();
			this.toolStripMenuItemAlignBranchByLeft = new ToolStripMenuItem();
			this.toolMenuItemLinePropertyBranch = new ToolStripMenuItem();
			this.toolStripSeparator14 = new ToolStripSeparator();
			this.toolMenuItemLineRelayProtection = new ToolStripMenuItem();
			this.toolMenuItemLineLogDispatcher = new ToolStripMenuItem();
			this.toolMenuItemLineDeLinkPassport = new ToolStripMenuItem();
			this.toolMenuItemLineLinkPassport = new ToolStripMenuItem();
			this.toolMenuItemLinePassport = new ToolStripMenuItem();
			this.toolMenuItemLineFile = new ToolStripMenuItem();
			this.toolMenuItemLineProperty = new ToolStripMenuItem();
			this.contextMenuCanvas = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItemAddFreeLabel = new ToolStripMenuItem();
			this.toolStripMenuItemAddTelemetryLabel2Level = new ToolStripMenuItem();
			this.toolMenuItemAddNode = new ToolStripMenuItem();
			this.toolMenuCanvasPaste = new ToolStripMenuItem();
			this.imageList_0 = new ImageList(this.icontainer_0);
			this.contextMenuLabelTool = new ContextMenuStrip(this.icontainer_0);
			this.toolMenuItemLabelUpdate = new ToolStripMenuItem();
			this.toolMenuItemLabelDel = new ToolStripMenuItem();
			this.toolMenuItemLabelProperty = new ToolStripMenuItem();
			this.contextMenuStripWhitePoint = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItemRemoveWhitePoint = new ToolStripMenuItem();
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.contextMenuFrame = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuFramePrint = new ToolStripMenuItem();
			this.toolStripMenuFrameCopyToImage = new ToolStripMenuItem();
			this.toolStripMenuFrameExportToImage = new ToolStripMenuItem();
			this.toolStripMenuFrameFitZoom = new ToolStripMenuItem();
			this.textBoxSearch = new TextBox();
			this.button1 = new Button();
			this.contextMenuTextBranchTool = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolMenuItemTextBranchDel = new ToolStripMenuItem();
			this.toolMenuItemTextBranchProperty = new ToolStripMenuItem();
			this.statusStrip.SuspendLayout();
			((ISupportInitialize)this.dataSetScheme_0).BeginInit();
			this.contextMenuSelectedObjects.SuspendLayout();
			this.contextMenuRectnagle.SuspendLayout();
			this.contextMenuShina.SuspendLayout();
			this.contextMenuSwitchTool.SuspendLayout();
			this.contextMenuLineTool.SuspendLayout();
			this.contextMenuCanvas.SuspendLayout();
			this.contextMenuLabelTool.SuspendLayout();
			this.contextMenuStripWhitePoint.SuspendLayout();
			this.contextMenuFrame.SuspendLayout();
			this.contextMenuTextBranchTool.SuspendLayout();
			base.SuspendLayout();
			this.statusStrip.Items.AddRange(new ToolStripItem[]
			{
				this.labelMousePosition,
				this.toolBtnZoom,
				this.labelInfo,
				this.toolLabelEmpty,
				this.labelProgressBar,
				this.toolProgressBarSave,
				this.toolStripStatusLabelConnected
			});
			this.statusStrip.Location = new Point(0, 468);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new Size(754, 26);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip1";
			this.labelMousePosition.AutoSize = false;
			this.labelMousePosition.BorderSides = (ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Right);
			this.labelMousePosition.Image = (Image)componentResourceManager.GetObject("labelMousePosition.Image");
			this.labelMousePosition.Name = "labelMousePosition";
			this.labelMousePosition.Size = new Size(140, 21);
			this.toolBtnZoom.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolTxtZoomChanged,
				this.toolBtnZoom800,
				this.toolBtnZoom400,
				this.toolBtnZoom200,
				this.toolBtnZoom150,
				this.toolBtnZoom125,
				this.toolBtnZoom100,
				this.toolBtnZoom75,
				this.toolBtnZoom50,
				this.toolBtnZoom25
			});
			this.toolBtnZoom.Name = "toolBtnZoom";
			this.toolBtnZoom.Size = new Size(51, 24);
			this.toolBtnZoom.Text = "100%";
			this.toolTxtZoomChanged.Name = "toolTxtZoomChanged";
			this.toolTxtZoomChanged.Size = new Size(100, 23);
			this.toolTxtZoomChanged.KeyDown += this.toolTxtZoomChanged_KeyDown;
			this.toolBtnZoom800.Name = "toolBtnZoom800";
			this.toolBtnZoom800.Size = new Size(160, 22);
			this.toolBtnZoom800.Tag = "800";
			this.toolBtnZoom800.Text = "800%";
			this.toolBtnZoom800.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom400.Name = "toolBtnZoom400";
			this.toolBtnZoom400.Size = new Size(160, 22);
			this.toolBtnZoom400.Tag = "400";
			this.toolBtnZoom400.Text = "400%";
			this.toolBtnZoom400.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom200.Name = "toolBtnZoom200";
			this.toolBtnZoom200.Size = new Size(160, 22);
			this.toolBtnZoom200.Tag = "200";
			this.toolBtnZoom200.Text = "200%";
			this.toolBtnZoom200.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom150.Name = "toolBtnZoom150";
			this.toolBtnZoom150.Size = new Size(160, 22);
			this.toolBtnZoom150.Tag = "150";
			this.toolBtnZoom150.Text = "150%";
			this.toolBtnZoom150.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom125.Name = "toolBtnZoom125";
			this.toolBtnZoom125.Size = new Size(160, 22);
			this.toolBtnZoom125.Tag = "125";
			this.toolBtnZoom125.Text = "125%";
			this.toolBtnZoom125.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom100.Name = "toolBtnZoom100";
			this.toolBtnZoom100.Size = new Size(160, 22);
			this.toolBtnZoom100.Tag = "100";
			this.toolBtnZoom100.Text = "100%";
			this.toolBtnZoom100.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom75.Name = "toolBtnZoom75";
			this.toolBtnZoom75.Size = new Size(160, 22);
			this.toolBtnZoom75.Tag = "75";
			this.toolBtnZoom75.Text = "75%";
			this.toolBtnZoom75.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom50.Name = "toolBtnZoom50";
			this.toolBtnZoom50.Size = new Size(160, 22);
			this.toolBtnZoom50.Tag = "50";
			this.toolBtnZoom50.Text = "50%";
			this.toolBtnZoom50.Click += this.toolBtnZoom25_Click;
			this.toolBtnZoom25.Name = "toolBtnZoom25";
			this.toolBtnZoom25.Size = new Size(160, 22);
			this.toolBtnZoom25.Tag = "25";
			this.toolBtnZoom25.Text = "25%";
			this.toolBtnZoom25.Click += this.toolBtnZoom25_Click;
			this.labelInfo.BorderSides = (ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Right);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new Size(17, 21);
			this.labelInfo.Text = "  ";
			this.toolLabelEmpty.Name = "toolLabelEmpty";
			this.toolLabelEmpty.Size = new Size(531, 21);
			this.toolLabelEmpty.Spring = true;
			this.labelProgressBar.BorderSides = ToolStripStatusLabelBorderSides.Left;
			this.labelProgressBar.Name = "labelProgressBar";
			this.labelProgressBar.Size = new Size(77, 21);
			this.labelProgressBar.Text = "Сохранение";
			this.labelProgressBar.Visible = false;
			this.toolProgressBarSave.Name = "toolProgressBarSave";
			this.toolProgressBarSave.Size = new Size(100, 20);
			this.toolProgressBarSave.Visible = false;
			this.toolStripStatusLabelConnected.Name = "toolStripStatusLabelConnected";
			this.toolStripStatusLabelConnected.Size = new Size(0, 21);
			this.dataSetScheme_0.DataSetName = "DataSetScheme";
			this.dataSetScheme_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.printDocument.DocumentName = "Sheme";
			this.printDocument.BeginPrint += this.printDocument_BeginPrint;
			this.printDocument.EndPrint += this.printDocument_EndPrint;
			this.printDocument.PrintPage += this.printDocument_PrintPage;
			this.printDialog.Document = this.printDocument;
			this.printDialog.UseEXDialog = true;
			this.pageSetupDialog_0.Document = this.printDocument;
			this.pageSetupDialog_0.EnableMetric = true;
			this.printPreviewDialog.AutoScrollMargin = new Size(0, 0);
			this.printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
			this.printPreviewDialog.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.printPreviewDialog.ClientSize = new Size(400, 300);
			this.printPreviewDialog.Document = this.printDocument;
			this.printPreviewDialog.Enabled = true;
			this.printPreviewDialog.Icon = (Icon)componentResourceManager.GetObject("printPreviewDialog.Icon");
			this.printPreviewDialog.Name = "printPreviewDialog";
			this.printPreviewDialog.Visible = false;
			this.propertyGrid1.Location = new Point(0, 32);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new Size(187, 361);
			this.propertyGrid1.TabIndex = 1;
			this.bigBoldButton.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 204);
			this.bigBoldButton.Location = new Point(0, 3);
			this.bigBoldButton.Name = "bigBoldButton";
			this.bigBoldButton.Size = new Size(187, 23);
			this.bigBoldButton.TabIndex = 2;
			this.bigBoldButton.Text = "BIG BOLD BUTTON";
			this.bigBoldButton.TextImageRelation = TextImageRelation.ImageAboveText;
			this.bigBoldButton.Click += this.bigBoldButton_Click;
			this.buttonCheck.Location = new Point(723, 3);
			this.buttonCheck.Name = "buttonCheck";
			this.buttonCheck.Size = new Size(47, 23);
			this.buttonCheck.TabIndex = 3;
			this.buttonCheck.Text = "Check";
			this.buttonCheck.UseVisualStyleBackColor = true;
			this.buttonCheck.Visible = false;
			this.buttonCheck.Click += this.buttonCheck_Click;
			this.timer_0.Interval = 1500;
			this.timer_0.Tick += this.timer_0_Tick;
			this.tbPopup.AutoSize = true;
			this.tbPopup.Location = new Point(648, 8);
			this.tbPopup.Name = "tbPopup";
			this.tbPopup.Size = new Size(35, 13);
			this.tbPopup.TabIndex = 4;
			this.tbPopup.Text = "label1";
			this.tbPopup.Visible = false;
			this.contextMenuSelectedObjects.Items.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemFilterSelectedObjects,
				this.toolStripSeparator4,
				this.toolStripMenuItemBookmark,
				this.toolStripMenuItemRemoveBookmark,
				this.toolStripSeparator9,
				this.toolMenuItemSelectedPowerBullshit,
				this.toolMenuItemSelectedAlign,
				this.toolStripSeparator13,
				this.toolStripMenuItemGroupSelectedObject,
				this.toolStripMenuItemGroupProperty,
				this.toolStripSeparatorGroup,
				this.toolMenuItemCenterSElectedObjects,
				this.toolMenuItemCopySelectedObjects,
				this.toolMenuItemCopySelectedObjectsToImage,
				this.toolMenuItemExportSelectedObjectsToDXF,
				this.toolMenuItemPasteSelectedObjects,
				this.toolMenuItemDeleteSelectedObjects
			});
			this.contextMenuSelectedObjects.Name = "contextMenuSelectedObjects";
			this.contextMenuSelectedObjects.Size = new Size(202, 314);
			this.contextMenuSelectedObjects.Opening += this.contextMenuSelectedObjects_Opening;
			this.toolMenuItemFilterSelectedObjects.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemAddFilterSelectedObjects,
				this.toolMenuItemDeleteFilterSelectedObjects
			});
			this.toolMenuItemFilterSelectedObjects.Name = "toolMenuItemFilterSelectedObjects";
			this.toolMenuItemFilterSelectedObjects.Size = new Size(201, 22);
			this.toolMenuItemFilterSelectedObjects.Text = "Фильтр";
			this.toolMenuItemAddFilterSelectedObjects.Name = "toolMenuItemAddFilterSelectedObjects";
			this.toolMenuItemAddFilterSelectedObjects.Size = new Size(183, 22);
			this.toolMenuItemAddFilterSelectedObjects.Text = "Добавить в фильтр";
			this.toolMenuItemAddFilterSelectedObjects.Click += this.toolMenuItemAddFilterSelectedObjects_Click;
			this.toolMenuItemDeleteFilterSelectedObjects.Name = "toolMenuItemDeleteFilterSelectedObjects";
			this.toolMenuItemDeleteFilterSelectedObjects.Size = new Size(183, 22);
			this.toolMenuItemDeleteFilterSelectedObjects.Text = "Удалить из фильтра";
			this.toolMenuItemDeleteFilterSelectedObjects.Click += this.toolMenuItemDeleteFilterSelectedObjects_Click;
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new Size(198, 6);
			this.toolStripMenuItemBookmark.Name = "toolStripMenuItemBookmark";
			this.toolStripMenuItemBookmark.Size = new Size(201, 22);
			this.toolStripMenuItemBookmark.Text = "Поставить метку";
			this.toolStripMenuItemBookmark.Click += this.toolStripMenuItemBookmark_Click;
			this.toolStripMenuItemRemoveBookmark.Name = "toolStripMenuItemRemoveBookmark";
			this.toolStripMenuItemRemoveBookmark.Size = new Size(201, 22);
			this.toolStripMenuItemRemoveBookmark.Text = "Снять метку";
			this.toolStripMenuItemRemoveBookmark.Click += this.toolStripMenuItemRemoveBookmark_Click;
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new Size(198, 6);
			this.toolMenuItemSelectedPowerBullshit.Name = "toolMenuItemSelectedPowerBullshit";
			this.toolMenuItemSelectedPowerBullshit.Size = new Size(201, 22);
			this.toolMenuItemSelectedPowerBullshit.Text = "Варианты питания";
			this.toolMenuItemSelectedPowerBullshit.Visible = false;
			this.toolMenuItemSelectedPowerBullshit.Click += this.toolMenuItemSelectedPowerBullshit_Click;
			this.toolMenuItemSelectedAlign.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemSelectedAlignByTop,
				this.toolMenuItemSelectedAlignByBottom,
				this.toolMenuItemSelectedAlignByRigth,
				this.toolMenuItemSelectedAlignByLeft,
				this.toolMenuItemSelectedAlignByHorCenter,
				this.toolMenuItemSelectedAlignByVertCenter
			});
			this.toolMenuItemSelectedAlign.Name = "toolMenuItemSelectedAlign";
			this.toolMenuItemSelectedAlign.Size = new Size(201, 22);
			this.toolMenuItemSelectedAlign.Text = "Выравнить";
			this.toolMenuItemSelectedAlignByTop.Name = "toolMenuItemSelectedAlignByTop";
			this.toolMenuItemSelectedAlignByTop.Size = new Size(171, 22);
			this.toolMenuItemSelectedAlignByTop.Tag = "T";
			this.toolMenuItemSelectedAlignByTop.Text = "По верхней точке";
			this.toolMenuItemSelectedAlignByTop.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
			this.toolMenuItemSelectedAlignByBottom.Name = "toolMenuItemSelectedAlignByBottom";
			this.toolMenuItemSelectedAlignByBottom.Size = new Size(171, 22);
			this.toolMenuItemSelectedAlignByBottom.Tag = "B";
			this.toolMenuItemSelectedAlignByBottom.Text = "По нижней точке";
			this.toolMenuItemSelectedAlignByBottom.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
			this.toolMenuItemSelectedAlignByRigth.Name = "toolMenuItemSelectedAlignByRigth";
			this.toolMenuItemSelectedAlignByRigth.Size = new Size(171, 22);
			this.toolMenuItemSelectedAlignByRigth.Tag = "R";
			this.toolMenuItemSelectedAlignByRigth.Text = "По правой точке";
			this.toolMenuItemSelectedAlignByRigth.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
			this.toolMenuItemSelectedAlignByLeft.Name = "toolMenuItemSelectedAlignByLeft";
			this.toolMenuItemSelectedAlignByLeft.Size = new Size(171, 22);
			this.toolMenuItemSelectedAlignByLeft.Tag = "L";
			this.toolMenuItemSelectedAlignByLeft.Text = "По левой точке";
			this.toolMenuItemSelectedAlignByLeft.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
			this.toolMenuItemSelectedAlignByHorCenter.Name = "toolMenuItemSelectedAlignByHorCenter";
			this.toolMenuItemSelectedAlignByHorCenter.Size = new Size(171, 22);
			this.toolMenuItemSelectedAlignByHorCenter.Tag = "H";
			this.toolMenuItemSelectedAlignByHorCenter.Text = "По горизонтали";
			this.toolMenuItemSelectedAlignByHorCenter.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
			this.toolMenuItemSelectedAlignByVertCenter.Name = "toolMenuItemSelectedAlignByVertCenter";
			this.toolMenuItemSelectedAlignByVertCenter.Size = new Size(171, 22);
			this.toolMenuItemSelectedAlignByVertCenter.Tag = "V";
			this.toolMenuItemSelectedAlignByVertCenter.Text = "По вертикали";
			this.toolMenuItemSelectedAlignByVertCenter.Click += this.toolMenuItemSelectedAlignByVertCenter_Click;
			this.toolStripSeparator13.Name = "toolStripSeparator13";
			this.toolStripSeparator13.Size = new Size(198, 6);
			this.toolStripSeparator13.Visible = false;
			this.toolStripMenuItemGroupSelectedObject.Name = "toolStripMenuItemGroupSelectedObject";
			this.toolStripMenuItemGroupSelectedObject.Size = new Size(201, 22);
			this.toolStripMenuItemGroupSelectedObject.Text = "Сгруппировать";
			this.toolStripMenuItemGroupSelectedObject.Click += this.toolStripMenuItemGroupSelectedObject_Click;
			this.toolStripMenuItemGroupProperty.Name = "toolStripMenuItemGroupProperty";
			this.toolStripMenuItemGroupProperty.Size = new Size(201, 22);
			this.toolStripMenuItemGroupProperty.Text = "Свойства группы";
			this.toolStripMenuItemGroupProperty.Click += this.toolStripMenuItemGroupProperty_Click;
			this.toolStripSeparatorGroup.Name = "toolStripSeparatorGroup";
			this.toolStripSeparatorGroup.Size = new Size(198, 6);
			this.toolMenuItemCenterSElectedObjects.Name = "toolMenuItemCenterSElectedObjects";
			this.toolMenuItemCenterSElectedObjects.Size = new Size(201, 22);
			this.toolMenuItemCenterSElectedObjects.Text = "Подогнать под размер";
			this.toolMenuItemCenterSElectedObjects.Click += this.toolMenuItemCenterSElectedObjects_Click;
			this.toolMenuItemCopySelectedObjects.Name = "toolMenuItemCopySelectedObjects";
			this.toolMenuItemCopySelectedObjects.Size = new Size(201, 22);
			this.toolMenuItemCopySelectedObjects.Text = "Копировать";
			this.toolMenuItemCopySelectedObjects.Click += this.toolStripMenuItem_1_Click;
			this.toolMenuItemCopySelectedObjectsToImage.Name = "toolMenuItemCopySelectedObjectsToImage";
			this.toolMenuItemCopySelectedObjectsToImage.Size = new Size(201, 22);
			this.toolMenuItemCopySelectedObjectsToImage.Text = "Копировать в картинку";
			this.toolMenuItemCopySelectedObjectsToImage.Click += this.toolMenuItemCopySelectedObjectsToImage_Click;
			this.toolMenuItemExportSelectedObjectsToDXF.Name = "toolMenuItemExportSelectedObjectsToDXF";
			this.toolMenuItemExportSelectedObjectsToDXF.Size = new Size(201, 22);
			this.toolMenuItemExportSelectedObjectsToDXF.Text = "Экспорт в AutoCAD";
			this.toolMenuItemExportSelectedObjectsToDXF.Click += this.toolMenuItemExportSelectedObjectsToDXF_Click;
			this.toolMenuItemPasteSelectedObjects.Name = "toolMenuItemPasteSelectedObjects";
			this.toolMenuItemPasteSelectedObjects.Size = new Size(201, 22);
			this.toolMenuItemPasteSelectedObjects.Text = "Вставить";
			this.toolMenuItemPasteSelectedObjects.Click += this.toolMenuItemLinePaste_Click;
			this.toolMenuItemDeleteSelectedObjects.Name = "toolMenuItemDeleteSelectedObjects";
			this.toolMenuItemDeleteSelectedObjects.Size = new Size(201, 22);
			this.toolMenuItemDeleteSelectedObjects.Text = "Удалить";
			this.toolMenuItemDeleteSelectedObjects.Click += this.toolMenuItemDeleteSelectedObjects_Click;
			this.contextMenuRectnagle.Items.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemRectPowerSource,
				this.toolMenuItemRectRecipientsPower,
				this.toolStripSeparator10,
				this.toolMenuItemRectFilter,
				this.toolStripSeparator1,
				this.toolMenuItemRectCopy,
				this.toolMenuItemRectPaste,
				this.toolMenuItemRectDel,
				this.toolStripMenuItemRectanglePosition,
				this.toolMenuItemRectAlign,
				this.toolStripMenuItemAdjacentSubstation,
				this.toolStripSeparator2,
				this.toolMenuItemRectFile,
				this.toolMenuItemRectProperty
			});
			this.contextMenuRectnagle.Name = "contextMenuRectnagle";
			this.contextMenuRectnagle.Size = new Size(198, 264);
			this.contextMenuRectnagle.Opening += this.contextMenuRectnagle_Opening;
			this.toolMenuItemRectPowerSource.Name = "toolMenuItemRectPowerSource";
			this.toolMenuItemRectPowerSource.Size = new Size(197, 22);
			this.toolMenuItemRectPowerSource.Text = "Просчитать запитку";
			this.toolMenuItemRectPowerSource.Click += this.toolStripMenuItem8_Click;
			this.toolMenuItemRectRecipientsPower.Name = "toolMenuItemRectRecipientsPower";
			this.toolMenuItemRectRecipientsPower.Size = new Size(197, 22);
			this.toolMenuItemRectRecipientsPower.Text = "Просчитать схему";
			this.toolMenuItemRectRecipientsPower.Click += this.toolStripMenuItem9_Click;
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new Size(194, 6);
			this.toolMenuItemRectFilter.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemRectFilterAdd,
				this.toolMenuItemRectFilterDel
			});
			this.toolMenuItemRectFilter.Name = "toolMenuItemRectFilter";
			this.toolMenuItemRectFilter.Size = new Size(197, 22);
			this.toolMenuItemRectFilter.Text = "Фильтр";
			this.toolMenuItemRectFilterAdd.Name = "toolMenuItemRectFilterAdd";
			this.toolMenuItemRectFilterAdd.Size = new Size(183, 22);
			this.toolMenuItemRectFilterAdd.Text = "Добавить в фильтр";
			this.toolMenuItemRectFilterAdd.Click += this.toolMenuItemLineFilterAdd_Click;
			this.toolMenuItemRectFilterDel.Name = "toolMenuItemRectFilterDel";
			this.toolMenuItemRectFilterDel.Size = new Size(183, 22);
			this.toolMenuItemRectFilterDel.Text = "Удалить из фильтра";
			this.toolMenuItemRectFilterDel.Click += this.toolMenuItemLineFilterDel_Click;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new Size(194, 6);
			this.toolMenuItemRectCopy.Name = "toolMenuItemRectCopy";
			this.toolMenuItemRectCopy.Size = new Size(197, 22);
			this.toolMenuItemRectCopy.Text = "Копировать";
			this.toolMenuItemRectCopy.Click += this.toolStripMenuItem_1_Click;
			this.toolMenuItemRectPaste.Name = "toolMenuItemRectPaste";
			this.toolMenuItemRectPaste.Size = new Size(197, 22);
			this.toolMenuItemRectPaste.Text = "Вставить";
			this.toolMenuItemRectPaste.Click += this.toolMenuItemLinePaste_Click;
			this.toolMenuItemRectDel.Name = "toolMenuItemRectDel";
			this.toolMenuItemRectDel.Size = new Size(197, 22);
			this.toolMenuItemRectDel.Text = "Удалить";
			this.toolMenuItemRectDel.Click += this.toolMenuItemTextBranchDel_Click;
			this.toolStripMenuItemRectanglePosition.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemReflect,
				this.toolStripMenuItemRotateRectangle
			});
			this.toolStripMenuItemRectanglePosition.Name = "toolStripMenuItemRectanglePosition";
			this.toolStripMenuItemRectanglePosition.Size = new Size(197, 22);
			this.toolStripMenuItemRectanglePosition.Text = "Положение";
			this.toolStripMenuItemReflect.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemVReflect,
				this.toolStripMenuItemHReflect
			});
			this.toolStripMenuItemReflect.Name = "toolStripMenuItemReflect";
			this.toolStripMenuItemReflect.Size = new Size(133, 22);
			this.toolStripMenuItemReflect.Text = "Отразить";
			this.toolStripMenuItemVReflect.Name = "toolStripMenuItemVReflect";
			this.toolStripMenuItemVReflect.Size = new Size(163, 22);
			this.toolStripMenuItemVReflect.Tag = "V";
			this.toolStripMenuItemVReflect.Text = "По вертикали";
			this.toolStripMenuItemVReflect.Click += this.toolStripMenuItemHReflect_Click;
			this.toolStripMenuItemHReflect.Name = "toolStripMenuItemHReflect";
			this.toolStripMenuItemHReflect.Size = new Size(163, 22);
			this.toolStripMenuItemHReflect.Tag = "H";
			this.toolStripMenuItemHReflect.Text = "По горизонтали";
			this.toolStripMenuItemHReflect.Click += this.toolStripMenuItemHReflect_Click;
			this.toolStripMenuItemRotateRectangle.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemRotate90,
				this.toolStripMenuItemRotate180,
				this.toolStripMenuItemRotate170
			});
			this.toolStripMenuItemRotateRectangle.Name = "toolStripMenuItemRotateRectangle";
			this.toolStripMenuItemRotateRectangle.Size = new Size(133, 22);
			this.toolStripMenuItemRotateRectangle.Text = "Повернуть";
			this.toolStripMenuItemRotate90.Name = "toolStripMenuItemRotate90";
			this.toolStripMenuItemRotate90.Size = new Size(144, 22);
			this.toolStripMenuItemRotate90.Text = "90 градусов";
			this.toolStripMenuItemRotate180.Name = "toolStripMenuItemRotate180";
			this.toolStripMenuItemRotate180.Size = new Size(144, 22);
			this.toolStripMenuItemRotate180.Text = "180 градусов";
			this.toolStripMenuItemRotate170.Name = "toolStripMenuItemRotate170";
			this.toolStripMenuItemRotate170.Size = new Size(144, 22);
			this.toolStripMenuItemRotate170.Text = "270 градусов";
			this.toolMenuItemRectAlign.Name = "toolMenuItemRectAlign";
			this.toolMenuItemRectAlign.Size = new Size(197, 22);
			this.toolMenuItemRectAlign.Text = "Выровнить объекты";
			this.toolMenuItemRectAlign.Click += this.toolMenuItemRectAlign_Click;
			this.toolStripMenuItemAdjacentSubstation.Name = "toolStripMenuItemAdjacentSubstation";
			this.toolStripMenuItemAdjacentSubstation.Size = new Size(197, 22);
			this.toolStripMenuItemAdjacentSubstation.Text = "Смежные подстанции";
			this.toolStripMenuItemAdjacentSubstation.Click += this.toolStripMenuItemAdjacentSubstation2_Click;
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new Size(194, 6);
			this.toolMenuItemRectFile.Name = "toolMenuItemRectFile";
			this.toolMenuItemRectFile.Size = new Size(197, 22);
			this.toolMenuItemRectFile.Text = "Файлы";
			this.toolMenuItemRectFile.Click += this.toolMenuItemLineFile_Click;
			this.toolMenuItemRectProperty.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
			this.toolMenuItemRectProperty.Name = "toolMenuItemRectProperty";
			this.toolMenuItemRectProperty.Size = new Size(197, 22);
			this.toolMenuItemRectProperty.Text = "Свойства объекта";
			this.toolMenuItemRectProperty.Click += this.toolMenuItemTextBranchProperty_Click;
			this.contextMenuShina.Items.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemShinaAddChild,
				this.toolMenuItemShinaCopy,
				this.toolMenuItemShinaPaste,
				this.toolMenuItemShinaDel,
				this.toolStripSeparatorEditShina,
				this.toolStripMenuItemBusMeasurement,
				this.toolMenuItemShinaPowerSource,
				this.toolMenuItemShinaRecipientsPower,
				this.toolStripMenuItem11,
				this.toolStripMenuItemAllPower,
				this.toolStripMenuItemAdjacentSubstation2,
				this.toolStripMenuItemShinaGetOldAbn,
				this.toolStripSeparator3,
				this.toolMenuItemShinaFilter,
				this.toolStripSeparator11,
				this.toolMenuItemShinaFile,
				this.toolMenuItemShinaProperty
			});
			this.contextMenuShina.Name = "contextMenuShina";
			this.contextMenuShina.Size = new Size(277, 330);
			this.contextMenuShina.Opening += this.contextMenuShina_Opening;
			this.toolMenuItemShinaAddChild.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemShinaAddCell,
				this.toolMenuItemShinaBridge,
				this.toolMenuItemShinaSplitter,
				this.toolStripMenuItemAddWhitePoint,
				this.toolMeniItemShinaAddPattern,
				this.toolStripSeparator7,
				this.toolStripMenuItemMeasurement,
				this.toolStripMenuItemShinaAddTelemetryLabel
			});
			this.toolMenuItemShinaAddChild.Name = "toolMenuItemShinaAddChild";
			this.toolMenuItemShinaAddChild.Size = new Size(276, 22);
			this.toolMenuItemShinaAddChild.Text = "Добавить";
			this.toolMenuItemShinaAddCell.Name = "toolMenuItemShinaAddCell";
			this.toolMenuItemShinaAddCell.Size = new Size(232, 22);
			this.toolMenuItemShinaAddCell.Text = "Ячейку";
			this.toolMenuItemShinaAddCell.Click += this.toolMenuItemShinaAddCell_Click;
			this.toolMenuItemShinaBridge.Name = "toolMenuItemShinaBridge";
			this.toolMenuItemShinaBridge.Size = new Size(232, 22);
			this.toolMenuItemShinaBridge.Text = "Межшинный мост";
			this.toolMenuItemShinaBridge.Visible = false;
			this.toolMenuItemShinaBridge.Click += this.toolMenuItemShinaBridge_Click;
			this.toolMenuItemShinaSplitter.Name = "toolMenuItemShinaSplitter";
			this.toolMenuItemShinaSplitter.Size = new Size(232, 22);
			this.toolMenuItemShinaSplitter.Text = "Разветвитель";
			this.toolMenuItemShinaSplitter.Visible = false;
			this.toolMenuItemShinaSplitter.Click += this.toolMenuItemShinaSplitter_Click;
			this.toolStripMenuItemAddWhitePoint.Name = "toolStripMenuItemAddWhitePoint";
			this.toolStripMenuItemAddWhitePoint.Size = new Size(232, 22);
			this.toolStripMenuItemAddWhitePoint.Text = "ВН на трансформаторе";
			this.toolStripMenuItemAddWhitePoint.Click += this.toolStripMenuItemAddWhitePoint_Click;
			this.toolMeniItemShinaAddPattern.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemShinaAddPatternAbn,
				this.toolMenuItemShinaAddPatternAbnAuto,
				this.toolMenuItemShinaAddPatternAbnReserve,
				this.toolMenuItemShinaAddPatternAbnRPS
			});
			this.toolMeniItemShinaAddPattern.Name = "toolMeniItemShinaAddPattern";
			this.toolMeniItemShinaAddPattern.Size = new Size(232, 22);
			this.toolMeniItemShinaAddPattern.Text = "Шаблон";
			this.toolMenuItemShinaAddPatternAbn.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemShinaAddPatternAbn1,
				this.toolMenuItemShinaAddPatternAbn2,
				this.toolMenuItemShinaAddPatternAbn3,
				this.toolMenuItemShinaAddPatternAbn4,
				this.toolMenuItemShinaAddPatternAbn5,
				this.toolMenuItemShinaAddPatternAbn6,
				this.toolMenuItemShinaAddPatternAbn7,
				this.toolMenuItemShinaAddPatternAbn8,
				this.toolMenuItemShinaAddPatternAbn9,
				this.toolMenuItemShinaAddPatternAbn10
			});
			this.toolMenuItemShinaAddPatternAbn.Name = "toolMenuItemShinaAddPatternAbn";
			this.toolMenuItemShinaAddPatternAbn.Size = new Size(271, 22);
			this.toolMenuItemShinaAddPatternAbn.Text = "Выходная на потребителя(ЛР)";
			this.toolMenuItemShinaAddPatternAbn.Click += this.toolMenuItemShinaAddPatternAbn_Click;
			this.toolMenuItemShinaAddPatternAbn1.Name = "toolMenuItemShinaAddPatternAbn1";
			this.toolMenuItemShinaAddPatternAbn1.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn1.Tag = "1";
			this.toolMenuItemShinaAddPatternAbn1.Text = "1";
			this.toolMenuItemShinaAddPatternAbn1.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn2.Name = "toolMenuItemShinaAddPatternAbn2";
			this.toolMenuItemShinaAddPatternAbn2.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn2.Tag = "2";
			this.toolMenuItemShinaAddPatternAbn2.Text = "2";
			this.toolMenuItemShinaAddPatternAbn2.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn3.Name = "toolMenuItemShinaAddPatternAbn3";
			this.toolMenuItemShinaAddPatternAbn3.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn3.Tag = "3";
			this.toolMenuItemShinaAddPatternAbn3.Text = "3";
			this.toolMenuItemShinaAddPatternAbn3.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn4.Name = "toolMenuItemShinaAddPatternAbn4";
			this.toolMenuItemShinaAddPatternAbn4.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn4.Tag = "4";
			this.toolMenuItemShinaAddPatternAbn4.Text = "4";
			this.toolMenuItemShinaAddPatternAbn4.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn5.Name = "toolMenuItemShinaAddPatternAbn5";
			this.toolMenuItemShinaAddPatternAbn5.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn5.Tag = "5";
			this.toolMenuItemShinaAddPatternAbn5.Text = "5";
			this.toolMenuItemShinaAddPatternAbn5.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn6.Name = "toolMenuItemShinaAddPatternAbn6";
			this.toolMenuItemShinaAddPatternAbn6.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn6.Tag = "6";
			this.toolMenuItemShinaAddPatternAbn6.Text = "6";
			this.toolMenuItemShinaAddPatternAbn6.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn7.Name = "toolMenuItemShinaAddPatternAbn7";
			this.toolMenuItemShinaAddPatternAbn7.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn7.Tag = "7";
			this.toolMenuItemShinaAddPatternAbn7.Text = "7";
			this.toolMenuItemShinaAddPatternAbn7.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn8.Name = "toolMenuItemShinaAddPatternAbn8";
			this.toolMenuItemShinaAddPatternAbn8.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn8.Tag = "8";
			this.toolMenuItemShinaAddPatternAbn8.Text = "8";
			this.toolMenuItemShinaAddPatternAbn8.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn9.Name = "toolMenuItemShinaAddPatternAbn9";
			this.toolMenuItemShinaAddPatternAbn9.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn9.Tag = "9";
			this.toolMenuItemShinaAddPatternAbn9.Text = "9";
			this.toolMenuItemShinaAddPatternAbn9.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbn10.Name = "toolMenuItemShinaAddPatternAbn10";
			this.toolMenuItemShinaAddPatternAbn10.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbn10.Tag = "10";
			this.toolMenuItemShinaAddPatternAbn10.Text = "10";
			this.toolMenuItemShinaAddPatternAbn10.Click += this.toolMenuItemShinaAddPatternAbn10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemShinaAddPatternAbnAuto1,
				this.toolMenuItemShinaAddPatternAbnAuto2,
				this.toolMenuItemShinaAddPatternAbnAuto3,
				this.toolMenuItemShinaAddPatternAbnAuto4,
				this.toolMenuItemShinaAddPatternAbnAuto5,
				this.toolMenuItemShinaAddPatternAbnAuto6,
				this.toolMenuItemShinaAddPatternAbnAuto7,
				this.toolMenuItemShinaAddPatternAbnAuto8,
				this.toolMenuItemShinaAddPatternAbnAuto9,
				this.toolMenuItemShinaAddPatternAbnAuto10
			});
			this.toolMenuItemShinaAddPatternAbnAuto.Name = "toolMenuItemShinaAddPatternAbnAuto";
			this.toolMenuItemShinaAddPatternAbnAuto.Size = new Size(271, 22);
			this.toolMenuItemShinaAddPatternAbnAuto.Text = "Выходная на потребителя (автомат)";
			this.toolMenuItemShinaAddPatternAbnAuto1.Name = "toolMenuItemShinaAddPatternAbnAuto1";
			this.toolMenuItemShinaAddPatternAbnAuto1.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto1.Tag = "1";
			this.toolMenuItemShinaAddPatternAbnAuto1.Text = "1";
			this.toolMenuItemShinaAddPatternAbnAuto1.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto2.Name = "toolMenuItemShinaAddPatternAbnAuto2";
			this.toolMenuItemShinaAddPatternAbnAuto2.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto2.Tag = "2";
			this.toolMenuItemShinaAddPatternAbnAuto2.Text = "2";
			this.toolMenuItemShinaAddPatternAbnAuto2.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto3.Name = "toolMenuItemShinaAddPatternAbnAuto3";
			this.toolMenuItemShinaAddPatternAbnAuto3.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto3.Tag = "3";
			this.toolMenuItemShinaAddPatternAbnAuto3.Text = "3";
			this.toolMenuItemShinaAddPatternAbnAuto3.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto4.Name = "toolMenuItemShinaAddPatternAbnAuto4";
			this.toolMenuItemShinaAddPatternAbnAuto4.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto4.Tag = "4";
			this.toolMenuItemShinaAddPatternAbnAuto4.Text = "4";
			this.toolMenuItemShinaAddPatternAbnAuto4.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto5.Name = "toolMenuItemShinaAddPatternAbnAuto5";
			this.toolMenuItemShinaAddPatternAbnAuto5.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto5.Tag = "5";
			this.toolMenuItemShinaAddPatternAbnAuto5.Text = "5";
			this.toolMenuItemShinaAddPatternAbnAuto5.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto6.Name = "toolMenuItemShinaAddPatternAbnAuto6";
			this.toolMenuItemShinaAddPatternAbnAuto6.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto6.Tag = "6";
			this.toolMenuItemShinaAddPatternAbnAuto6.Text = "6";
			this.toolMenuItemShinaAddPatternAbnAuto6.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto7.Name = "toolMenuItemShinaAddPatternAbnAuto7";
			this.toolMenuItemShinaAddPatternAbnAuto7.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto7.Tag = "7";
			this.toolMenuItemShinaAddPatternAbnAuto7.Text = "7";
			this.toolMenuItemShinaAddPatternAbnAuto7.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto8.Name = "toolMenuItemShinaAddPatternAbnAuto8";
			this.toolMenuItemShinaAddPatternAbnAuto8.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto8.Tag = "8";
			this.toolMenuItemShinaAddPatternAbnAuto8.Text = "8";
			this.toolMenuItemShinaAddPatternAbnAuto8.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto9.Name = "toolMenuItemShinaAddPatternAbnAuto9";
			this.toolMenuItemShinaAddPatternAbnAuto9.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto9.Tag = "9";
			this.toolMenuItemShinaAddPatternAbnAuto9.Text = "9";
			this.toolMenuItemShinaAddPatternAbnAuto9.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnAuto10.Name = "toolMenuItemShinaAddPatternAbnAuto10";
			this.toolMenuItemShinaAddPatternAbnAuto10.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnAuto10.Tag = "10";
			this.toolMenuItemShinaAddPatternAbnAuto10.Text = "10";
			this.toolMenuItemShinaAddPatternAbnAuto10.Click += this.toolMenuItemShinaAddPatternAbnAuto10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemShinaAddPatternAbnReserve1,
				this.toolMenuItemShinaAddPatternAbnReserve2,
				this.toolMenuItemShinaAddPatternAbnReserve3,
				this.toolMenuItemShinaAddPatternAbnReserve4,
				this.toolMenuItemShinaAddPatternAbnReserve5,
				this.toolMenuItemShinaAddPatternAbnReserve6,
				this.toolMenuItemShinaAddPatternAbnReserve7,
				this.toolMenuItemShinaAddPatternAbnReserve8,
				this.toolMenuItemShinaAddPatternAbnReserve9,
				this.toolMenuItemShinaAddPatternAbnReserve10
			});
			this.toolMenuItemShinaAddPatternAbnReserve.Name = "toolMenuItemShinaAddPatternAbnReserve";
			this.toolMenuItemShinaAddPatternAbnReserve.Size = new Size(271, 22);
			this.toolMenuItemShinaAddPatternAbnReserve.Text = "Выходная на потребителя (резерв)";
			this.toolMenuItemShinaAddPatternAbnReserve.Click += this.toolMenuItemShinaAddPatternAbnReserve_Click;
			this.toolMenuItemShinaAddPatternAbnReserve1.Name = "toolMenuItemShinaAddPatternAbnReserve1";
			this.toolMenuItemShinaAddPatternAbnReserve1.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve1.Tag = "1";
			this.toolMenuItemShinaAddPatternAbnReserve1.Text = "1";
			this.toolMenuItemShinaAddPatternAbnReserve1.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve2.Name = "toolMenuItemShinaAddPatternAbnReserve2";
			this.toolMenuItemShinaAddPatternAbnReserve2.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve2.Tag = "2";
			this.toolMenuItemShinaAddPatternAbnReserve2.Text = "2";
			this.toolMenuItemShinaAddPatternAbnReserve2.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve3.Name = "toolMenuItemShinaAddPatternAbnReserve3";
			this.toolMenuItemShinaAddPatternAbnReserve3.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve3.Tag = "3";
			this.toolMenuItemShinaAddPatternAbnReserve3.Text = "3";
			this.toolMenuItemShinaAddPatternAbnReserve3.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve4.Name = "toolMenuItemShinaAddPatternAbnReserve4";
			this.toolMenuItemShinaAddPatternAbnReserve4.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve4.Tag = "4";
			this.toolMenuItemShinaAddPatternAbnReserve4.Text = "4";
			this.toolMenuItemShinaAddPatternAbnReserve4.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve5.Name = "toolMenuItemShinaAddPatternAbnReserve5";
			this.toolMenuItemShinaAddPatternAbnReserve5.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve5.Tag = "5";
			this.toolMenuItemShinaAddPatternAbnReserve5.Text = "5";
			this.toolMenuItemShinaAddPatternAbnReserve5.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve6.Name = "toolMenuItemShinaAddPatternAbnReserve6";
			this.toolMenuItemShinaAddPatternAbnReserve6.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve6.Tag = "6";
			this.toolMenuItemShinaAddPatternAbnReserve6.Text = "6";
			this.toolMenuItemShinaAddPatternAbnReserve6.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve7.Name = "toolMenuItemShinaAddPatternAbnReserve7";
			this.toolMenuItemShinaAddPatternAbnReserve7.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve7.Tag = "7";
			this.toolMenuItemShinaAddPatternAbnReserve7.Text = "7";
			this.toolMenuItemShinaAddPatternAbnReserve7.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve8.Name = "toolMenuItemShinaAddPatternAbnReserve8";
			this.toolMenuItemShinaAddPatternAbnReserve8.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve8.Tag = "8";
			this.toolMenuItemShinaAddPatternAbnReserve8.Text = "8";
			this.toolMenuItemShinaAddPatternAbnReserve8.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve9.Name = "toolMenuItemShinaAddPatternAbnReserve9";
			this.toolMenuItemShinaAddPatternAbnReserve9.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve9.Tag = "9";
			this.toolMenuItemShinaAddPatternAbnReserve9.Text = "9";
			this.toolMenuItemShinaAddPatternAbnReserve9.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnReserve10.Name = "toolMenuItemShinaAddPatternAbnReserve10";
			this.toolMenuItemShinaAddPatternAbnReserve10.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnReserve10.Tag = "10";
			this.toolMenuItemShinaAddPatternAbnReserve10.Text = "10";
			this.toolMenuItemShinaAddPatternAbnReserve10.Click += this.toolMenuItemShinaAddPatternAbnReserve10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemShinaAddPatternAbnRPS1,
				this.toolMenuItemShinaAddPatternAbnRPS2,
				this.toolMenuItemShinaAddPatternAbnRPS3,
				this.toolMenuItemShinaAddPatternAbnRPS4,
				this.toolMenuItemShinaAddPatternAbnRPS5,
				this.toolMenuItemShinaAddPatternAbnRPS6,
				this.toolMenuItemShinaAddPatternAbnRPS7,
				this.toolMenuItemShinaAddPatternAbnRPS8,
				this.toolMenuItemShinaAddPatternAbnRPS9,
				this.toolMenuItemShinaAddPatternAbnRPS10
			});
			this.toolMenuItemShinaAddPatternAbnRPS.Name = "toolMenuItemShinaAddPatternAbnRPS";
			this.toolMenuItemShinaAddPatternAbnRPS.Size = new Size(271, 22);
			this.toolMenuItemShinaAddPatternAbnRPS.Text = "Выходная на потребителя (РПС)";
			this.toolMenuItemShinaAddPatternAbnRPS.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS1.Name = "toolMenuItemShinaAddPatternAbnRPS1";
			this.toolMenuItemShinaAddPatternAbnRPS1.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS1.Tag = "1";
			this.toolMenuItemShinaAddPatternAbnRPS1.Text = "1";
			this.toolMenuItemShinaAddPatternAbnRPS1.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS2.Name = "toolMenuItemShinaAddPatternAbnRPS2";
			this.toolMenuItemShinaAddPatternAbnRPS2.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS2.Tag = "2";
			this.toolMenuItemShinaAddPatternAbnRPS2.Text = "2";
			this.toolMenuItemShinaAddPatternAbnRPS2.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS3.Name = "toolMenuItemShinaAddPatternAbnRPS3";
			this.toolMenuItemShinaAddPatternAbnRPS3.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS3.Tag = "3";
			this.toolMenuItemShinaAddPatternAbnRPS3.Text = "3";
			this.toolMenuItemShinaAddPatternAbnRPS3.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS4.Name = "toolMenuItemShinaAddPatternAbnRPS4";
			this.toolMenuItemShinaAddPatternAbnRPS4.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS4.Tag = "4";
			this.toolMenuItemShinaAddPatternAbnRPS4.Text = "4";
			this.toolMenuItemShinaAddPatternAbnRPS4.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS5.Name = "toolMenuItemShinaAddPatternAbnRPS5";
			this.toolMenuItemShinaAddPatternAbnRPS5.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS5.Tag = "5";
			this.toolMenuItemShinaAddPatternAbnRPS5.Text = "5";
			this.toolMenuItemShinaAddPatternAbnRPS5.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS6.Name = "toolMenuItemShinaAddPatternAbnRPS6";
			this.toolMenuItemShinaAddPatternAbnRPS6.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS6.Tag = "6";
			this.toolMenuItemShinaAddPatternAbnRPS6.Text = "6";
			this.toolMenuItemShinaAddPatternAbnRPS6.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS7.Name = "toolMenuItemShinaAddPatternAbnRPS7";
			this.toolMenuItemShinaAddPatternAbnRPS7.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS7.Tag = "7";
			this.toolMenuItemShinaAddPatternAbnRPS7.Text = "7";
			this.toolMenuItemShinaAddPatternAbnRPS7.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS8.Name = "toolMenuItemShinaAddPatternAbnRPS8";
			this.toolMenuItemShinaAddPatternAbnRPS8.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS8.Tag = "8";
			this.toolMenuItemShinaAddPatternAbnRPS8.Text = "8";
			this.toolMenuItemShinaAddPatternAbnRPS8.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS9.Name = "toolMenuItemShinaAddPatternAbnRPS9";
			this.toolMenuItemShinaAddPatternAbnRPS9.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS9.Tag = "9";
			this.toolMenuItemShinaAddPatternAbnRPS9.Text = "9";
			this.toolMenuItemShinaAddPatternAbnRPS9.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolMenuItemShinaAddPatternAbnRPS10.Name = "toolMenuItemShinaAddPatternAbnRPS10";
			this.toolMenuItemShinaAddPatternAbnRPS10.Size = new Size(86, 22);
			this.toolMenuItemShinaAddPatternAbnRPS10.Tag = "10";
			this.toolMenuItemShinaAddPatternAbnRPS10.Text = "10";
			this.toolMenuItemShinaAddPatternAbnRPS10.Click += this.toolMenuItemShinaAddPatternAbnRPS10_Click;
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new Size(229, 6);
			this.toolStripMenuItemMeasurement.Name = "toolStripMenuItemMeasurement";
			this.toolStripMenuItemMeasurement.Size = new Size(232, 22);
			this.toolStripMenuItemMeasurement.Text = "Вывести данные о замерах";
			this.toolStripMenuItemMeasurement.Click += this.toolStripMenuItemMeasurement_Click;
			this.toolStripMenuItemShinaAddTelemetryLabel.Name = "toolStripMenuItemShinaAddTelemetryLabel";
			this.toolStripMenuItemShinaAddTelemetryLabel.Size = new Size(232, 22);
			this.toolStripMenuItemShinaAddTelemetryLabel.Text = "Вывести данные телеметрии";
			this.toolStripMenuItemShinaAddTelemetryLabel.Click += this.toolStripMenuItemLineAddTelemertryLabel_Click;
			this.toolMenuItemShinaCopy.Name = "toolMenuItemShinaCopy";
			this.toolMenuItemShinaCopy.Size = new Size(276, 22);
			this.toolMenuItemShinaCopy.Text = "Копировать";
			this.toolMenuItemShinaCopy.Click += this.toolStripMenuItem_1_Click;
			this.toolMenuItemShinaPaste.Name = "toolMenuItemShinaPaste";
			this.toolMenuItemShinaPaste.Size = new Size(276, 22);
			this.toolMenuItemShinaPaste.Text = "Вставить";
			this.toolMenuItemShinaPaste.Click += this.toolMenuItemLinePaste_Click;
			this.toolMenuItemShinaDel.Name = "toolMenuItemShinaDel";
			this.toolMenuItemShinaDel.Size = new Size(276, 22);
			this.toolMenuItemShinaDel.Text = "Удалить";
			this.toolMenuItemShinaDel.Click += this.toolMenuItemTextBranchDel_Click;
			this.toolStripSeparatorEditShina.Name = "toolStripSeparatorEditShina";
			this.toolStripSeparatorEditShina.Size = new Size(273, 6);
			this.toolStripMenuItemBusMeasurement.Name = "toolStripMenuItemBusMeasurement";
			this.toolStripMenuItemBusMeasurement.Size = new Size(276, 22);
			this.toolStripMenuItemBusMeasurement.Text = "Замеры";
			this.toolStripMenuItemBusMeasurement.Click += this.toolStripMenuItemBusMeasurement_Click;
			this.toolMenuItemShinaPowerSource.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem2,
				this.toolStripMenuItem5
			});
			this.toolMenuItemShinaPowerSource.Name = "toolMenuItemShinaPowerSource";
			this.toolMenuItemShinaPowerSource.Size = new Size(276, 22);
			this.toolMenuItemShinaPowerSource.Text = "Просчитать запитку";
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new Size(186, 22);
			this.toolStripMenuItem2.Tag = "1";
			this.toolStripMenuItem2.Text = "Выделить";
			this.toolStripMenuItem2.Click += this.toolStripMenuItem8_Click;
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new Size(186, 22);
			this.toolStripMenuItem5.Tag = "2";
			this.toolStripMenuItem5.Text = "Выделить миганием";
			this.toolStripMenuItem5.Click += this.toolStripMenuItem8_Click;
			this.toolMenuItemShinaRecipientsPower.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem3,
				this.toolStripMenuItem4
			});
			this.toolMenuItemShinaRecipientsPower.Name = "toolMenuItemShinaRecipientsPower";
			this.toolMenuItemShinaRecipientsPower.Size = new Size(276, 22);
			this.toolMenuItemShinaRecipientsPower.Text = "Просчитать схему";
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new Size(186, 22);
			this.toolStripMenuItem3.Tag = "1";
			this.toolStripMenuItem3.Text = "Выделить";
			this.toolStripMenuItem3.Click += this.toolStripMenuItem9_Click;
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new Size(186, 22);
			this.toolStripMenuItem4.Tag = "2";
			this.toolStripMenuItem4.Text = "Выделить миганием";
			this.toolStripMenuItem4.Click += this.toolStripMenuItem9_Click;
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new Size(276, 22);
			this.toolStripMenuItem11.Text = "Альтернативные источники питания";
			this.toolStripMenuItem11.Click += this.toolStripMenuItem11_Click;
			this.toolStripMenuItemAllPower.Name = "toolStripMenuItemAllPower";
			this.toolStripMenuItemAllPower.Size = new Size(276, 22);
			this.toolStripMenuItemAllPower.Text = "Все возможные источники питания";
			this.toolStripMenuItemAllPower.Visible = false;
			this.toolStripMenuItemAllPower.Click += this.toolStripMenuItem10_Click;
			this.toolStripMenuItemAdjacentSubstation2.Name = "toolStripMenuItemAdjacentSubstation2";
			this.toolStripMenuItemAdjacentSubstation2.Size = new Size(276, 22);
			this.toolStripMenuItemAdjacentSubstation2.Text = "Смежные подстанции";
			this.toolStripMenuItemAdjacentSubstation2.Click += this.toolStripMenuItemAdjacentSubstation2_Click;
			this.toolStripMenuItemShinaGetOldAbn.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemShinaOldAbnCurrentRect,
				this.toolStripMenuItemShinaOldAbnNextRect
			});
			this.toolStripMenuItemShinaGetOldAbn.Name = "toolStripMenuItemShinaGetOldAbn";
			this.toolStripMenuItemShinaGetOldAbn.Size = new Size(276, 22);
			this.toolStripMenuItemShinaGetOldAbn.Text = "Абоненты";
			this.toolStripMenuItemShinaOldAbnCurrentRect.Name = "toolStripMenuItemShinaOldAbnCurrentRect";
			this.toolStripMenuItemShinaOldAbnCurrentRect.Size = new Size(191, 22);
			this.toolStripMenuItemShinaOldAbnCurrentRect.Text = "Текущей подстанции";
			this.toolStripMenuItemShinaOldAbnCurrentRect.Click += this.toolStripMenuItem14_Click;
			this.toolStripMenuItemShinaOldAbnNextRect.Name = "toolStripMenuItemShinaOldAbnNextRect";
			this.toolStripMenuItemShinaOldAbnNextRect.Size = new Size(191, 22);
			this.toolStripMenuItemShinaOldAbnNextRect.Tag = "1";
			this.toolStripMenuItemShinaOldAbnNextRect.Text = "По цепочке";
			this.toolStripMenuItemShinaOldAbnNextRect.Click += this.toolStripMenuItem14_Click;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new Size(273, 6);
			this.toolMenuItemShinaFilter.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemShinaFilterAdd,
				this.toolMenuItemShinaFilterDel
			});
			this.toolMenuItemShinaFilter.Name = "toolMenuItemShinaFilter";
			this.toolMenuItemShinaFilter.Size = new Size(276, 22);
			this.toolMenuItemShinaFilter.Text = "Фильтр";
			this.toolMenuItemShinaFilterAdd.Name = "toolMenuItemShinaFilterAdd";
			this.toolMenuItemShinaFilterAdd.Size = new Size(183, 22);
			this.toolMenuItemShinaFilterAdd.Text = "Добавить в фильтр";
			this.toolMenuItemShinaFilterAdd.Click += this.toolMenuItemLineFilterAdd_Click;
			this.toolMenuItemShinaFilterDel.Name = "toolMenuItemShinaFilterDel";
			this.toolMenuItemShinaFilterDel.Size = new Size(183, 22);
			this.toolMenuItemShinaFilterDel.Text = "Удалить из фильтра";
			this.toolMenuItemShinaFilterDel.Click += this.toolMenuItemLineFilterDel_Click;
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new Size(273, 6);
			this.toolMenuItemShinaFile.Name = "toolMenuItemShinaFile";
			this.toolMenuItemShinaFile.Size = new Size(276, 22);
			this.toolMenuItemShinaFile.Text = "Файлы";
			this.toolMenuItemShinaFile.Click += this.toolMenuItemLineFile_Click;
			this.toolMenuItemShinaProperty.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
			this.toolMenuItemShinaProperty.Name = "toolMenuItemShinaProperty";
			this.toolMenuItemShinaProperty.Size = new Size(276, 22);
			this.toolMenuItemShinaProperty.Text = "Свойства объекта";
			this.toolMenuItemShinaProperty.Click += this.toolMenuItemTextBranchProperty_Click;
			this.contextMenuSwitchTool.Items.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemSwitchPassport,
				this.toolMenuItemSwitchOn,
				this.toolMenuItemSwitchFilter,
				this.toolStripMenuItemOOLDisplayGrLevel,
				this.toolStripMenuItemSwitchAddTelemetry,
				this.toolMenuItemSwitchErcloud,
				this.toolStripSeparator12,
				this.toolStripMenuItemCSRollingOut,
				this.toolStripMenuItemCSNormalMode,
				this.toolStripSeparatorCS,
				this.toolMenuItemStateDel,
				this.toolMenuItemSwitchCopy,
				this.toolMenuItemSwitchDel,
				this.toolStripSeparator5,
				this.ToolStripMenuItemSwitchMeasurement,
				this.toolMenuItemSwitchLogDispatcher,
				this.toolMenuItemSwitchFile,
				this.toolMenuItemSwitchProperty
			});
			this.contextMenuSwitchTool.Name = "contextMenuSwitchTool";
			this.contextMenuSwitchTool.Size = new Size(242, 352);
			this.contextMenuSwitchTool.Opening += this.contextMenuSwitchTool_Opening;
			this.toolMenuItemSwitchPassport.Name = "toolMenuItemSwitchPassport";
			this.toolMenuItemSwitchPassport.Size = new Size(241, 22);
			this.toolMenuItemSwitchPassport.Text = "Паспорт";
			this.toolMenuItemSwitchPassport.Click += this.toolMenuItemSwitchPassport_Click;
			this.toolMenuItemSwitchOn.Name = "toolMenuItemSwitchOn";
			this.toolMenuItemSwitchOn.Size = new Size(241, 22);
			this.toolMenuItemSwitchOn.Text = "Включить";
			this.toolMenuItemSwitchOn.Click += this.toolMenuItemSwitchOn_Click;
			this.toolMenuItemSwitchFilter.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemSwitchFilterAdd,
				this.toolMenuItemSwitchFilterDel
			});
			this.toolMenuItemSwitchFilter.Name = "toolMenuItemSwitchFilter";
			this.toolMenuItemSwitchFilter.Size = new Size(241, 22);
			this.toolMenuItemSwitchFilter.Text = "Фильтр";
			this.toolMenuItemSwitchFilterAdd.Name = "toolMenuItemSwitchFilterAdd";
			this.toolMenuItemSwitchFilterAdd.Size = new Size(183, 22);
			this.toolMenuItemSwitchFilterAdd.Text = "Добавить в фильтр";
			this.toolMenuItemSwitchFilterAdd.Click += this.toolMenuItemLineFilterAdd_Click;
			this.toolMenuItemSwitchFilterDel.Name = "toolMenuItemSwitchFilterDel";
			this.toolMenuItemSwitchFilterDel.Size = new Size(183, 22);
			this.toolMenuItemSwitchFilterDel.Text = "Удалить из фильтра";
			this.toolMenuItemSwitchFilterDel.Click += this.toolMenuItemLineFilterDel_Click;
			this.toolStripMenuItemOOLDisplayGrLevel.Name = "toolStripMenuItemOOLDisplayGrLevel";
			this.toolStripMenuItemOOLDisplayGrLevel.Size = new Size(241, 22);
			this.toolStripMenuItemOOLDisplayGrLevel.Text = "Отобразить на первом уровне";
			this.toolStripMenuItemOOLDisplayGrLevel.Click += this.toolStripMenuItemOOLDisplayGrLevel_Click;
			this.toolStripMenuItemSwitchAddTelemetry.Name = "toolStripMenuItemSwitchAddTelemetry";
			this.toolStripMenuItemSwitchAddTelemetry.Size = new Size(241, 22);
			this.toolStripMenuItemSwitchAddTelemetry.Text = "Вывести данные телеметрии";
			this.toolStripMenuItemSwitchAddTelemetry.Click += this.toolStripMenuItemLineAddTelemertryLabel_Click;
			this.toolMenuItemSwitchErcloud.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemSwitchLinkErcloud,
				this.toolMenuItemSwitchShowDataErcloud
			});
			this.toolMenuItemSwitchErcloud.Name = "toolMenuItemSwitchErcloud";
			this.toolMenuItemSwitchErcloud.Size = new Size(241, 22);
			this.toolMenuItemSwitchErcloud.Text = "Ercloud";
			this.toolMenuItemSwitchLinkErcloud.Name = "toolMenuItemSwitchLinkErcloud";
			this.toolMenuItemSwitchLinkErcloud.Size = new Size(221, 22);
			this.toolMenuItemSwitchLinkErcloud.Text = "Привязать объект к АСКУЭ";
			this.toolMenuItemSwitchLinkErcloud.Click += this.toolMenuItemSwitchLinkErcloud_Click;
			this.toolMenuItemSwitchShowDataErcloud.Name = "toolMenuItemSwitchShowDataErcloud";
			this.toolMenuItemSwitchShowDataErcloud.Size = new Size(221, 22);
			this.toolMenuItemSwitchShowDataErcloud.Text = "Данные АСКУЭ";
			this.toolMenuItemSwitchShowDataErcloud.Click += this.toolMenuItemSwitchShowDataErcloud_Click;
			this.toolStripSeparator12.Name = "toolStripSeparator12";
			this.toolStripSeparator12.Size = new Size(238, 6);
			this.toolStripMenuItemCSRollingOut.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemCSRepairMode,
				this.toolStripMenuItemCSTestMode
			});
			this.toolStripMenuItemCSRollingOut.Name = "toolStripMenuItemCSRollingOut";
			this.toolStripMenuItemCSRollingOut.Size = new Size(241, 22);
			this.toolStripMenuItemCSRollingOut.Text = "Выкатить";
			this.toolStripMenuItemCSRepairMode.Name = "toolStripMenuItemCSRepairMode";
			this.toolStripMenuItemCSRepairMode.Size = new Size(136, 22);
			this.toolStripMenuItemCSRepairMode.Text = "Ремонт";
			this.toolStripMenuItemCSRepairMode.Click += this.toolStripMenuItemCSRepairMode_Click;
			this.toolStripMenuItemCSTestMode.Name = "toolStripMenuItemCSTestMode";
			this.toolStripMenuItemCSTestMode.Size = new Size(136, 22);
			this.toolStripMenuItemCSTestMode.Text = "Испытания";
			this.toolStripMenuItemCSTestMode.Click += this.toolStripMenuItemCSTestMode_Click;
			this.toolStripMenuItemCSNormalMode.Name = "toolStripMenuItemCSNormalMode";
			this.toolStripMenuItemCSNormalMode.Size = new Size(241, 22);
			this.toolStripMenuItemCSNormalMode.Text = "Рабочий режим";
			this.toolStripMenuItemCSNormalMode.Click += this.toolStripMenuItemCSNormalMode_Click;
			this.toolStripSeparatorCS.Name = "toolStripSeparatorCS";
			this.toolStripSeparatorCS.Size = new Size(238, 6);
			this.toolMenuItemStateDel.Name = "toolMenuItemStateDel";
			this.toolMenuItemStateDel.Size = new Size(241, 22);
			this.toolMenuItemStateDel.Text = "Убрать статус";
			this.toolMenuItemStateDel.Click += this.toolMenuItemStateDel_Click;
			this.toolMenuItemSwitchCopy.Name = "toolMenuItemSwitchCopy";
			this.toolMenuItemSwitchCopy.Size = new Size(241, 22);
			this.toolMenuItemSwitchCopy.Text = "Копировать";
			this.toolMenuItemSwitchCopy.Click += this.toolStripMenuItem_1_Click;
			this.toolMenuItemSwitchDel.Name = "toolMenuItemSwitchDel";
			this.toolMenuItemSwitchDel.Size = new Size(241, 22);
			this.toolMenuItemSwitchDel.Text = "Удалить";
			this.toolMenuItemSwitchDel.Click += this.toolMenuItemTextBranchDel_Click;
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new Size(238, 6);
			this.ToolStripMenuItemSwitchMeasurement.Name = "ToolStripMenuItemSwitchMeasurement";
			this.ToolStripMenuItemSwitchMeasurement.Size = new Size(241, 22);
			this.ToolStripMenuItemSwitchMeasurement.Text = "Замеры";
			this.ToolStripMenuItemSwitchMeasurement.Click += this.ToolStripMenuItemSwitchMeasurement_Click;
			this.toolMenuItemSwitchLogDispatcher.Name = "toolMenuItemSwitchLogDispatcher";
			this.toolMenuItemSwitchLogDispatcher.Size = new Size(241, 22);
			this.toolMenuItemSwitchLogDispatcher.Text = "Отчет диспетчера";
			this.toolMenuItemSwitchLogDispatcher.Click += this.toolMenuItemSwitchLogDispatcher_Click;
			this.toolMenuItemSwitchFile.Name = "toolMenuItemSwitchFile";
			this.toolMenuItemSwitchFile.Size = new Size(241, 22);
			this.toolMenuItemSwitchFile.Text = "Файлы";
			this.toolMenuItemSwitchFile.Click += this.toolMenuItemLineFile_Click;
			this.toolMenuItemSwitchProperty.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
			this.toolMenuItemSwitchProperty.Name = "toolMenuItemSwitchProperty";
			this.toolMenuItemSwitchProperty.Size = new Size(241, 22);
			this.toolMenuItemSwitchProperty.Text = "Свойства объекта";
			this.toolMenuItemSwitchProperty.Click += this.toolMenuItemTextBranchProperty_Click;
			this.contextMenuLineTool.Items.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemLineAddChild,
				this.toolMenuItemLineCopy,
				this.toolMenuItemLinePaste,
				this.toolStripMenuItemDevideLine,
				this.toolStripMenuItemDisconnectLine,
				this.toolMenuItemLineDel,
				this.toolStripSeparatorEditLine,
				this.toolMenuItemLineSetStatus,
				this.toolStripSeparatorSetStatus,
				this.toolMenuItemLineTextHere,
				this.toolStripSeparatorLineTextHere,
				this.toolMenuItemLineFilter,
				this.toolMenuItemLinePowerSource,
				this.toolStripMenuItem1,
				this.toolMenuItemLineRecipientsPower,
				this.toolStripMenuItem10,
				this.toolStripMenuItem12,
				this.toolStripMenuItemLineAddTelemertryLabel,
				this.toolStripSeparator8,
				this.toolMenuItemLinePropertyPoint,
				this.toolStripMenuItemLineAlignBranch,
				this.toolMenuItemLinePropertyBranch,
				this.toolStripSeparator14,
				this.toolMenuItemLineRelayProtection,
				this.toolMenuItemLineLogDispatcher,
				this.toolMenuItemLineDeLinkPassport,
				this.toolMenuItemLineLinkPassport,
				this.toolMenuItemLinePassport,
				this.toolMenuItemLineFile,
				this.toolMenuItemLineProperty
			});
			this.contextMenuLineTool.Name = "contextMenuLineTool";
			this.contextMenuLineTool.Size = new Size(272, 590);
			this.contextMenuLineTool.Closed += this.contextMenuLineTool_Closed;
			this.contextMenuLineTool.Opening += this.contextMenuLineTool_Opening;
			this.toolMenuItemLineAddChild.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemLineAddBranch,
				this.toolMenuItemLineAddPoint,
				this.toolStripSeparatorLineAddBranchPoint,
				this.toolMenuItemLineAddOutsideLineDisconnector,
				this.toolMenuItemLineAddVacuumSwitch,
				this.toolMenuItemLineAddTransformer,
				this.toolMenuItemLineAddVoltageTransformer,
				this.toolStripMenuItemAddAmperageTransformerTool,
				this.toolMenuItemLineAddLoadSwitch,
				this.toolMenuItemLineAddLoadSwitchWaxwork,
				this.toolMenuItemLineAddRPS,
				this.toolMenuItemLineAddLinearDisconnector,
				this.toolMenuItemLineAddLinearDisconnectorWaxwork,
				this.toolMenuItemLineAddLubricantDisconnector,
				this.toolMenuItemLineAddFuseTool,
				this.toolMenuItemLineAddDischargerTool,
				this.toolMenuItemLineAddVoltageLimetedTool,
				this.toolMenuItemLineAddEndTrim,
				this.toolMenuItemLineAddCircuitBreakerTool,
				this.toolMenuItemLineAddGroundingTool,
				this.toolMenuItemLineAddSeparatorTool,
				this.toolStripMenuItemAddMagneticStarterTool,
				this.toolStripMenuItemAddElectricMeter,
				this.toolStripSeparator6,
				this.toolMenuItemAddLineText
			});
			this.toolMenuItemLineAddChild.Name = "toolMenuItemLineAddChild";
			this.toolMenuItemLineAddChild.Size = new Size(271, 22);
			this.toolMenuItemLineAddChild.Text = "Добавить";
			this.toolMenuItemLineAddBranch.Name = "toolMenuItemLineAddBranch";
			this.toolMenuItemLineAddBranch.Size = new Size(276, 22);
			this.toolMenuItemLineAddBranch.Text = "Ветку";
			this.toolMenuItemLineAddBranch.Click += this.toolMenuItemLineAddBranch_Click;
			this.toolMenuItemLineAddPoint.Name = "toolMenuItemLineAddPoint";
			this.toolMenuItemLineAddPoint.Size = new Size(276, 22);
			this.toolMenuItemLineAddPoint.Text = "Узел";
			this.toolMenuItemLineAddPoint.Click += this.toolMenuItemLineAddPoint_Click;
			this.toolStripSeparatorLineAddBranchPoint.Name = "toolStripSeparatorLineAddBranchPoint";
			this.toolStripSeparatorLineAddBranchPoint.Size = new Size(273, 6);
			this.toolMenuItemLineAddOutsideLineDisconnector.Name = "toolMenuItemLineAddOutsideLineDisconnector";
			this.toolMenuItemLineAddOutsideLineDisconnector.Size = new Size(276, 22);
			this.toolMenuItemLineAddOutsideLineDisconnector.Text = "Разъеденитель линейный наружный";
			this.toolMenuItemLineAddOutsideLineDisconnector.Click += this.toolMenuItemLineAddOutsideLineDisconnector_Click;
			this.toolMenuItemLineAddVacuumSwitch.Name = "toolMenuItemLineAddVacuumSwitch";
			this.toolMenuItemLineAddVacuumSwitch.Size = new Size(276, 22);
			this.toolMenuItemLineAddVacuumSwitch.Text = "Вакуумный выключатель";
			this.toolMenuItemLineAddVacuumSwitch.Click += this.toolMenuItemLineAddVacuumSwitch_Click;
			this.toolMenuItemLineAddTransformer.Name = "toolMenuItemLineAddTransformer";
			this.toolMenuItemLineAddTransformer.Size = new Size(276, 22);
			this.toolMenuItemLineAddTransformer.Text = "Трансформатор";
			this.toolMenuItemLineAddTransformer.Click += this.toolMenuItemLineAddTransformer_Click;
			this.toolMenuItemLineAddVoltageTransformer.Name = "toolMenuItemLineAddVoltageTransformer";
			this.toolMenuItemLineAddVoltageTransformer.Size = new Size(276, 22);
			this.toolMenuItemLineAddVoltageTransformer.Text = "Трансформатор напряжения";
			this.toolMenuItemLineAddVoltageTransformer.Click += this.toolMenuItemLineAddVoltageTransformer_Click;
			this.toolStripMenuItemAddAmperageTransformerTool.Name = "toolStripMenuItemAddAmperageTransformerTool";
			this.toolStripMenuItemAddAmperageTransformerTool.Size = new Size(276, 22);
			this.toolStripMenuItemAddAmperageTransformerTool.Text = "Трансформатор тока";
			this.toolStripMenuItemAddAmperageTransformerTool.Click += this.toolStripMenuItemAddAmperageTransformerTool_Click;
			this.toolMenuItemLineAddLoadSwitch.Name = "toolMenuItemLineAddLoadSwitch";
			this.toolMenuItemLineAddLoadSwitch.Size = new Size(276, 22);
			this.toolMenuItemLineAddLoadSwitch.Text = "Выключатель нагрузки";
			this.toolMenuItemLineAddLoadSwitch.Click += this.toolMenuItemLineAddLoadSwitch_Click;
			this.toolMenuItemLineAddLoadSwitchWaxwork.Name = "toolMenuItemLineAddLoadSwitchWaxwork";
			this.toolMenuItemLineAddLoadSwitchWaxwork.Size = new Size(276, 22);
			this.toolMenuItemLineAddLoadSwitchWaxwork.Text = "Выключатель нагрузки";
			this.toolMenuItemLineAddLoadSwitchWaxwork.Click += this.toolMenuItemLineAddLoadSwitchWaxwork_Click;
			this.toolMenuItemLineAddRPS.Name = "toolMenuItemLineAddRPS";
			this.toolMenuItemLineAddRPS.Size = new Size(276, 22);
			this.toolMenuItemLineAddRPS.Text = "РПС";
			this.toolMenuItemLineAddRPS.Click += this.toolMenuItemLineAddRPS_Click;
			this.toolMenuItemLineAddLinearDisconnector.Name = "toolMenuItemLineAddLinearDisconnector";
			this.toolMenuItemLineAddLinearDisconnector.Size = new Size(276, 22);
			this.toolMenuItemLineAddLinearDisconnector.Text = "Линейный разъеденитель";
			this.toolMenuItemLineAddLinearDisconnector.Click += this.toolMenuItemLineAddLinearDisconnector_Click;
			this.toolMenuItemLineAddLinearDisconnectorWaxwork.Name = "toolMenuItemLineAddLinearDisconnectorWaxwork";
			this.toolMenuItemLineAddLinearDisconnectorWaxwork.Size = new Size(276, 22);
			this.toolMenuItemLineAddLinearDisconnectorWaxwork.Text = "Линейный разъеденитель";
			this.toolMenuItemLineAddLinearDisconnectorWaxwork.Visible = false;
			this.toolMenuItemLineAddLinearDisconnectorWaxwork.Click += this.toolMenuItemLineAddLinearDisconnectorWaxwork_Click;
			this.toolMenuItemLineAddLubricantDisconnector.Name = "toolMenuItemLineAddLubricantDisconnector";
			this.toolMenuItemLineAddLubricantDisconnector.Size = new Size(276, 22);
			this.toolMenuItemLineAddLubricantDisconnector.Text = "Маслянный выключатель";
			this.toolMenuItemLineAddLubricantDisconnector.Click += this.toolMenuItemLineAddLubricantDisconnector_Click;
			this.toolMenuItemLineAddFuseTool.Name = "toolMenuItemLineAddFuseTool";
			this.toolMenuItemLineAddFuseTool.Size = new Size(276, 22);
			this.toolMenuItemLineAddFuseTool.Text = "Предохранитель";
			this.toolMenuItemLineAddFuseTool.Click += this.toolMenuItemLineAddFuseTool_Click;
			this.toolMenuItemLineAddDischargerTool.Name = "toolMenuItemLineAddDischargerTool";
			this.toolMenuItemLineAddDischargerTool.Size = new Size(276, 22);
			this.toolMenuItemLineAddDischargerTool.Text = "Разрядник";
			this.toolMenuItemLineAddDischargerTool.Click += this.toolMenuItemLineAddDischargerTool_Click;
			this.toolMenuItemLineAddVoltageLimetedTool.Name = "toolMenuItemLineAddVoltageLimetedTool";
			this.toolMenuItemLineAddVoltageLimetedTool.Size = new Size(276, 22);
			this.toolMenuItemLineAddVoltageLimetedTool.Text = "Ограничитель перенапряжения";
			this.toolMenuItemLineAddVoltageLimetedTool.Click += this.toolMenuItemLineAddVoltageLimetedTool_Click;
			this.toolMenuItemLineAddEndTrim.Name = "toolMenuItemLineAddEndTrim";
			this.toolMenuItemLineAddEndTrim.Size = new Size(276, 22);
			this.toolMenuItemLineAddEndTrim.Text = "Концевая разделка";
			this.toolMenuItemLineAddEndTrim.Click += this.toolMenuItemLineAddEndTrim_Click;
			this.toolMenuItemLineAddCircuitBreakerTool.Name = "toolMenuItemLineAddCircuitBreakerTool";
			this.toolMenuItemLineAddCircuitBreakerTool.Size = new Size(276, 22);
			this.toolMenuItemLineAddCircuitBreakerTool.Text = "Автоматический выключатель";
			this.toolMenuItemLineAddCircuitBreakerTool.Click += this.toolMenuItemLineAddCircuitBreakerTool_Click;
			this.toolMenuItemLineAddGroundingTool.Name = "toolMenuItemLineAddGroundingTool";
			this.toolMenuItemLineAddGroundingTool.Size = new Size(276, 22);
			this.toolMenuItemLineAddGroundingTool.Text = "Заземление";
			this.toolMenuItemLineAddGroundingTool.Click += this.toolMenuItemLineAddGroundingTool_Click;
			this.toolMenuItemLineAddSeparatorTool.ImageAlign = ContentAlignment.MiddleRight;
			this.toolMenuItemLineAddSeparatorTool.Name = "toolMenuItemLineAddSeparatorTool";
			this.toolMenuItemLineAddSeparatorTool.Size = new Size(276, 22);
			this.toolMenuItemLineAddSeparatorTool.Text = "Отделитель";
			this.toolMenuItemLineAddSeparatorTool.Click += this.toolMenuItemLineAddSeparatorTool_Click;
			this.toolStripMenuItemAddMagneticStarterTool.Name = "toolStripMenuItemAddMagneticStarterTool";
			this.toolStripMenuItemAddMagneticStarterTool.Size = new Size(276, 22);
			this.toolStripMenuItemAddMagneticStarterTool.Text = "Магнитный пускатель";
			this.toolStripMenuItemAddMagneticStarterTool.Click += this.toolStripMenuItemAddMagneticStarterTool_Click;
			this.toolStripMenuItemAddElectricMeter.Name = "toolStripMenuItemAddElectricMeter";
			this.toolStripMenuItemAddElectricMeter.Size = new Size(276, 22);
			this.toolStripMenuItemAddElectricMeter.Text = "Счётчик";
			this.toolStripMenuItemAddElectricMeter.Click += this.toolStripMenuItemAddElectricMeter_Click;
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new Size(273, 6);
			this.toolMenuItemAddLineText.Name = "toolMenuItemAddLineText";
			this.toolMenuItemAddLineText.Size = new Size(276, 22);
			this.toolMenuItemAddLineText.Text = "Текст";
			this.toolMenuItemAddLineText.Click += this.toolMenuItemAddLineText_Click;
			this.toolMenuItemLineCopy.Name = "toolMenuItemLineCopy";
			this.toolMenuItemLineCopy.Size = new Size(271, 22);
			this.toolMenuItemLineCopy.Text = "Копировать";
			this.toolMenuItemLineCopy.Click += this.toolStripMenuItem_1_Click;
			this.toolMenuItemLinePaste.Name = "toolMenuItemLinePaste";
			this.toolMenuItemLinePaste.Size = new Size(271, 22);
			this.toolMenuItemLinePaste.Text = "Вставить";
			this.toolMenuItemLinePaste.Click += this.toolMenuItemLinePaste_Click;
			this.toolStripMenuItemDevideLine.Name = "toolStripMenuItemDevideLine";
			this.toolStripMenuItemDevideLine.Size = new Size(271, 22);
			this.toolStripMenuItemDevideLine.Text = "Разделить линию";
			this.toolStripMenuItemDevideLine.Click += this.toolStripMenuItemDevideLine_Click;
			this.toolStripMenuItemDisconnectLine.Name = "toolStripMenuItemDisconnectLine";
			this.toolStripMenuItemDisconnectLine.Size = new Size(271, 22);
			this.toolStripMenuItemDisconnectLine.Text = "Разъеденить линии";
			this.toolStripMenuItemDisconnectLine.Click += this.toolStripMenuItemDisconnectLine_Click;
			this.toolMenuItemLineDel.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemLineDelObj,
				this.toolMenuItemLineDelPoint
			});
			this.toolMenuItemLineDel.Name = "toolMenuItemLineDel";
			this.toolMenuItemLineDel.Size = new Size(271, 22);
			this.toolMenuItemLineDel.Text = "Удалить";
			this.toolMenuItemLineDelObj.Name = "toolMenuItemLineDelObj";
			this.toolMenuItemLineDelObj.Size = new Size(117, 22);
			this.toolMenuItemLineDelObj.Text = "Объект ";
			this.toolMenuItemLineDelObj.Click += this.toolMenuItemTextBranchDel_Click;
			this.toolMenuItemLineDelPoint.Name = "toolMenuItemLineDelPoint";
			this.toolMenuItemLineDelPoint.Size = new Size(117, 22);
			this.toolMenuItemLineDelPoint.Text = "Узел";
			this.toolMenuItemLineDelPoint.Click += this.toolMenuItemLineDelPoint_Click;
			this.toolStripSeparatorEditLine.Name = "toolStripSeparatorEditLine";
			this.toolStripSeparatorEditLine.Size = new Size(268, 6);
			this.toolMenuItemLineSetStatus.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemLineSetStatusGrounding,
				this.toolMenuItemLineSetStatusBrakeDown,
				this.toolMenuItemLineSetStatusOff,
				this.toolMenuItemLineSetStatusNoPhased,
				this.toolMenuItemLineSetStatusArrow
			});
			this.toolMenuItemLineSetStatus.Name = "toolMenuItemLineSetStatus";
			this.toolMenuItemLineSetStatus.Size = new Size(271, 22);
			this.toolMenuItemLineSetStatus.Text = "Установить статус";
			this.toolMenuItemLineSetStatusGrounding.Name = "toolMenuItemLineSetStatusGrounding";
			this.toolMenuItemLineSetStatusGrounding.Size = new Size(174, 22);
			this.toolMenuItemLineSetStatusGrounding.Text = "Заземлено";
			this.toolMenuItemLineSetStatusGrounding.Click += this.toolMenuItemLineSetStatusGrounding_Click;
			this.toolMenuItemLineSetStatusBrakeDown.Name = "toolMenuItemLineSetStatusBrakeDown";
			this.toolMenuItemLineSetStatusBrakeDown.Size = new Size(174, 22);
			this.toolMenuItemLineSetStatusBrakeDown.Text = "Повреждено";
			this.toolMenuItemLineSetStatusBrakeDown.Click += this.toolMenuItemLineSetStatusBrakeDown_Click;
			this.toolMenuItemLineSetStatusOff.Name = "toolMenuItemLineSetStatusOff";
			this.toolMenuItemLineSetStatusOff.Size = new Size(174, 22);
			this.toolMenuItemLineSetStatusOff.Text = "Отсоединено";
			this.toolMenuItemLineSetStatusOff.Click += this.toolMenuItemLineSetStatusOff_Click;
			this.toolMenuItemLineSetStatusNoPhased.Name = "toolMenuItemLineSetStatusNoPhased";
			this.toolMenuItemLineSetStatusNoPhased.Size = new Size(174, 22);
			this.toolMenuItemLineSetStatusNoPhased.Text = "Несфазированно";
			this.toolMenuItemLineSetStatusNoPhased.Click += this.toolMenuItemLineSetStatusNoPhased_Click;
			this.toolMenuItemLineSetStatusArrow.Name = "toolMenuItemLineSetStatusArrow";
			this.toolMenuItemLineSetStatusArrow.Size = new Size(174, 22);
			this.toolMenuItemLineSetStatusArrow.Text = "Перенос нагрузки";
			this.toolMenuItemLineSetStatusArrow.Click += this.toolMenuItemLineSetStatusArrow_Click;
			this.toolStripSeparatorSetStatus.Name = "toolStripSeparatorSetStatus";
			this.toolStripSeparatorSetStatus.Size = new Size(268, 6);
			this.toolMenuItemLineTextHere.Name = "toolMenuItemLineTextHere";
			this.toolMenuItemLineTextHere.Size = new Size(271, 22);
			this.toolMenuItemLineTextHere.Text = "Разместить текст здесь";
			this.toolMenuItemLineTextHere.Click += this.toolMenuItemLineTextHere_Click;
			this.toolStripSeparatorLineTextHere.Name = "toolStripSeparatorLineTextHere";
			this.toolStripSeparatorLineTextHere.Size = new Size(268, 6);
			this.toolMenuItemLineFilter.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemLineFilterAdd,
				this.toolMenuItemLineFilterDel
			});
			this.toolMenuItemLineFilter.Name = "toolMenuItemLineFilter";
			this.toolMenuItemLineFilter.Size = new Size(271, 22);
			this.toolMenuItemLineFilter.Text = "Фильтр";
			this.toolMenuItemLineFilterAdd.Name = "toolMenuItemLineFilterAdd";
			this.toolMenuItemLineFilterAdd.Size = new Size(183, 22);
			this.toolMenuItemLineFilterAdd.Text = "Добавить в фильтр";
			this.toolMenuItemLineFilterAdd.Click += this.toolMenuItemLineFilterAdd_Click;
			this.toolMenuItemLineFilterDel.Name = "toolMenuItemLineFilterDel";
			this.toolMenuItemLineFilterDel.Size = new Size(183, 22);
			this.toolMenuItemLineFilterDel.Text = "Удалить из фильтра";
			this.toolMenuItemLineFilterDel.Click += this.toolMenuItemLineFilterDel_Click;
			this.toolMenuItemLinePowerSource.Name = "toolMenuItemLinePowerSource";
			this.toolMenuItemLinePowerSource.Size = new Size(268, 6);
			this.toolMenuItemLinePowerSource.Click += this.toolStripMenuItem8_Click;
			this.toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem6,
				this.toolStripMenuItem8
			});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new Size(271, 22);
			this.toolStripMenuItem1.Text = "Просчитать запитку";
			this.toolStripMenuItem1.Click += this.toolStripMenuItem8_Click;
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new Size(186, 22);
			this.toolStripMenuItem6.Tag = "1";
			this.toolStripMenuItem6.Text = "Выделить";
			this.toolStripMenuItem6.Click += this.toolStripMenuItem8_Click;
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new Size(186, 22);
			this.toolStripMenuItem8.Tag = "2";
			this.toolStripMenuItem8.Text = "Выделить миганием";
			this.toolStripMenuItem8.Click += this.toolStripMenuItem8_Click;
			this.toolMenuItemLineRecipientsPower.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem7,
				this.toolStripMenuItem9
			});
			this.toolMenuItemLineRecipientsPower.Name = "toolMenuItemLineRecipientsPower";
			this.toolMenuItemLineRecipientsPower.Size = new Size(271, 22);
			this.toolMenuItemLineRecipientsPower.Text = "Просчитать схему";
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new Size(186, 22);
			this.toolStripMenuItem7.Tag = "1";
			this.toolStripMenuItem7.Text = "Выделить";
			this.toolStripMenuItem7.Click += this.toolStripMenuItem9_Click;
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new Size(186, 22);
			this.toolStripMenuItem9.Tag = "2";
			this.toolStripMenuItem9.Text = "Выделить миганием";
			this.toolStripMenuItem9.Click += this.toolStripMenuItem9_Click;
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new Size(271, 22);
			this.toolStripMenuItem10.Text = "Все возможные источники питания";
			this.toolStripMenuItem10.Visible = false;
			this.toolStripMenuItem10.Click += this.toolStripMenuItem10_Click;
			this.toolStripMenuItem12.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem13,
				this.toolStripMenuItem14
			});
			this.toolStripMenuItem12.Name = "toolStripMenuItem12";
			this.toolStripMenuItem12.Size = new Size(271, 22);
			this.toolStripMenuItem12.Text = "Абоненты";
			this.toolStripMenuItem13.Name = "toolStripMenuItem13";
			this.toolStripMenuItem13.Size = new Size(191, 22);
			this.toolStripMenuItem13.Text = "Текущей подстанции";
			this.toolStripMenuItem13.Click += this.toolStripMenuItem14_Click;
			this.toolStripMenuItem14.Name = "toolStripMenuItem14";
			this.toolStripMenuItem14.Size = new Size(191, 22);
			this.toolStripMenuItem14.Tag = "1";
			this.toolStripMenuItem14.Text = "По цепочке";
			this.toolStripMenuItem14.Click += this.toolStripMenuItem14_Click;
			this.toolStripMenuItemLineAddTelemertryLabel.Name = "toolStripMenuItemLineAddTelemertryLabel";
			this.toolStripMenuItemLineAddTelemertryLabel.Size = new Size(271, 22);
			this.toolStripMenuItemLineAddTelemertryLabel.Text = "Вывести данные телеметрии";
			this.toolStripMenuItemLineAddTelemertryLabel.Click += this.toolStripMenuItemLineAddTelemertryLabel_Click;
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new Size(268, 6);
			this.toolMenuItemLinePropertyPoint.Name = "toolMenuItemLinePropertyPoint";
			this.toolMenuItemLinePropertyPoint.Size = new Size(271, 22);
			this.toolMenuItemLinePropertyPoint.Text = "Свойства узла";
			this.toolMenuItemLinePropertyPoint.Click += this.toolMenuItemLinePropertyPoint_Click;
			this.toolStripMenuItemLineAlignBranch.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemAlignBranchByTop,
				this.toolStripMenuItemAlignBranchByBottom,
				this.toolStripMenuItemAlignBranchByRigth,
				this.toolStripMenuItemAlignBranchByLeft
			});
			this.toolStripMenuItemLineAlignBranch.Name = "toolStripMenuItemLineAlignBranch";
			this.toolStripMenuItemLineAlignBranch.Size = new Size(271, 22);
			this.toolStripMenuItemLineAlignBranch.Text = "Выровнить ветку";
			this.toolStripMenuItemAlignBranchByTop.Name = "toolStripMenuItemAlignBranchByTop";
			this.toolStripMenuItemAlignBranchByTop.Size = new Size(171, 22);
			this.toolStripMenuItemAlignBranchByTop.Tag = "T";
			this.toolStripMenuItemAlignBranchByTop.Text = "По верхней точке";
			this.toolStripMenuItemAlignBranchByTop.Click += this.toolStripMenuItemAlignBranchByLeft_Click;
			this.toolStripMenuItemAlignBranchByBottom.Name = "toolStripMenuItemAlignBranchByBottom";
			this.toolStripMenuItemAlignBranchByBottom.Size = new Size(171, 22);
			this.toolStripMenuItemAlignBranchByBottom.Tag = "B";
			this.toolStripMenuItemAlignBranchByBottom.Text = "По нижней точке";
			this.toolStripMenuItemAlignBranchByBottom.Click += this.toolStripMenuItemAlignBranchByLeft_Click;
			this.toolStripMenuItemAlignBranchByRigth.Name = "toolStripMenuItemAlignBranchByRigth";
			this.toolStripMenuItemAlignBranchByRigth.Size = new Size(171, 22);
			this.toolStripMenuItemAlignBranchByRigth.Tag = "R";
			this.toolStripMenuItemAlignBranchByRigth.Text = "По правой точке";
			this.toolStripMenuItemAlignBranchByRigth.Click += this.toolStripMenuItemAlignBranchByLeft_Click;
			this.toolStripMenuItemAlignBranchByLeft.Name = "toolStripMenuItemAlignBranchByLeft";
			this.toolStripMenuItemAlignBranchByLeft.Size = new Size(171, 22);
			this.toolStripMenuItemAlignBranchByLeft.Tag = "L";
			this.toolStripMenuItemAlignBranchByLeft.Text = "По левой точке";
			this.toolStripMenuItemAlignBranchByLeft.Click += this.toolStripMenuItemAlignBranchByLeft_Click;
			this.toolMenuItemLinePropertyBranch.Name = "toolMenuItemLinePropertyBranch";
			this.toolMenuItemLinePropertyBranch.Size = new Size(271, 22);
			this.toolMenuItemLinePropertyBranch.Text = "Свойства ветки";
			this.toolMenuItemLinePropertyBranch.Click += this.toolMenuItemLinePropertyBranch_Click;
			this.toolStripSeparator14.Name = "toolStripSeparator14";
			this.toolStripSeparator14.Size = new Size(268, 6);
			this.toolMenuItemLineRelayProtection.Name = "toolMenuItemLineRelayProtection";
			this.toolMenuItemLineRelayProtection.Size = new Size(271, 22);
			this.toolMenuItemLineRelayProtection.Text = "Уставки РЗА";
			this.toolMenuItemLineRelayProtection.Click += this.toolMenuItemLineRelayProtection_Click;
			this.toolMenuItemLineLogDispatcher.Name = "toolMenuItemLineLogDispatcher";
			this.toolMenuItemLineLogDispatcher.Size = new Size(271, 22);
			this.toolMenuItemLineLogDispatcher.Text = "Отчет диспетчера";
			this.toolMenuItemLineLogDispatcher.Click += this.toolMenuItemLineLogDispatcher_Click;
			this.toolMenuItemLineDeLinkPassport.Name = "toolMenuItemLineDeLinkPassport";
			this.toolMenuItemLineDeLinkPassport.Size = new Size(271, 22);
			this.toolMenuItemLineDeLinkPassport.Text = "Отвязать от паспорта";
			this.toolMenuItemLineDeLinkPassport.Click += this.toolMenuItemLineDeLinkPassport_Click;
			this.toolMenuItemLineLinkPassport.Name = "toolMenuItemLineLinkPassport";
			this.toolMenuItemLineLinkPassport.Size = new Size(271, 22);
			this.toolMenuItemLineLinkPassport.Text = "Привязать к паспорту";
			this.toolMenuItemLineLinkPassport.Click += this.toolMenuItemLineLinkPassport_Click;
			this.toolMenuItemLinePassport.Name = "toolMenuItemLinePassport";
			this.toolMenuItemLinePassport.Size = new Size(271, 22);
			this.toolMenuItemLinePassport.Text = "Паспорт";
			this.toolMenuItemLinePassport.Click += this.toolMenuItemLinePassport_Click;
			this.toolMenuItemLineFile.Name = "toolMenuItemLineFile";
			this.toolMenuItemLineFile.Size = new Size(271, 22);
			this.toolMenuItemLineFile.Text = "Файлы";
			this.toolMenuItemLineFile.Click += this.toolMenuItemLineFile_Click;
			this.toolMenuItemLineProperty.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold);
			this.toolMenuItemLineProperty.Name = "toolMenuItemLineProperty";
			this.toolMenuItemLineProperty.Size = new Size(271, 22);
			this.toolMenuItemLineProperty.Text = "Свойства линии";
			this.toolMenuItemLineProperty.Click += this.toolMenuItemTextBranchProperty_Click;
			this.contextMenuCanvas.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemAddFreeLabel,
				this.toolStripMenuItemAddTelemetryLabel2Level,
				this.toolMenuItemAddNode,
				this.toolMenuCanvasPaste
			});
			this.contextMenuCanvas.Name = "contextMenuCanvas";
			this.contextMenuCanvas.Size = new Size(233, 92);
			this.contextMenuCanvas.Opening += this.contextMenuCanvas_Opening;
			this.toolStripMenuItemAddFreeLabel.Name = "toolStripMenuItemAddFreeLabel";
			this.toolStripMenuItemAddFreeLabel.Size = new Size(232, 22);
			this.toolStripMenuItemAddFreeLabel.Text = "Добавить текст";
			this.toolStripMenuItemAddFreeLabel.Click += this.toolStripMenuItemAddFreeLabel_Click;
			this.toolStripMenuItemAddTelemetryLabel2Level.Name = "toolStripMenuItemAddTelemetryLabel2Level";
			this.toolStripMenuItemAddTelemetryLabel2Level.Size = new Size(232, 22);
			this.toolStripMenuItemAddTelemetryLabel2Level.Text = "Вывести данные телеметрии";
			this.toolStripMenuItemAddTelemetryLabel2Level.Click += this.toolStripMenuItemAddTelemetryLabel2Level_Click;
			this.toolMenuItemAddNode.Name = "toolMenuItemAddNode";
			this.toolMenuItemAddNode.Size = new Size(232, 22);
			this.toolMenuItemAddNode.Text = "Добавить примечание";
			this.toolMenuItemAddNode.Click += this.toolMenuItemAddNode_Click;
			this.toolMenuCanvasPaste.Name = "toolMenuCanvasPaste";
			this.toolMenuCanvasPaste.Size = new Size(232, 22);
			this.toolMenuCanvasPaste.Text = "Вставить";
			this.toolMenuCanvasPaste.Click += this.toolMenuCanvasPaste_Click;
			this.imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListConnected.ImageStream");
			this.imageList_0.TransparentColor = Color.Transparent;
			this.imageList_0.Images.SetKeyName(0, "Connect.png");
			this.imageList_0.Images.SetKeyName(1, "NoConnect.png");
			this.contextMenuLabelTool.Items.AddRange(new ToolStripItem[]
			{
				this.toolMenuItemLabelUpdate,
				this.toolMenuItemLabelDel,
				this.toolMenuItemLabelProperty
			});
			this.contextMenuLabelTool.Name = "contextMenuLabelTool";
			this.contextMenuLabelTool.Size = new Size(178, 70);
			this.contextMenuLabelTool.Opening += this.contextMenuLabelTool_Opening;
			this.toolMenuItemLabelUpdate.Name = "toolMenuItemLabelUpdate";
			this.toolMenuItemLabelUpdate.Size = new Size(177, 22);
			this.toolMenuItemLabelUpdate.Text = "Обновить данные";
			this.toolMenuItemLabelUpdate.Click += this.toolMenuItemLabelUpdate_Click;
			this.toolMenuItemLabelDel.Name = "toolMenuItemLabelDel";
			this.toolMenuItemLabelDel.Size = new Size(177, 22);
			this.toolMenuItemLabelDel.Text = "Удалить";
			this.toolMenuItemLabelDel.Click += this.toolMenuItemLabelDel_Click;
			this.toolMenuItemLabelProperty.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.toolMenuItemLabelProperty.Name = "toolMenuItemLabelProperty";
			this.toolMenuItemLabelProperty.Size = new Size(177, 22);
			this.toolMenuItemLabelProperty.Text = "Свойства объекта";
			this.toolMenuItemLabelProperty.Click += this.toolMenuItemTextBranchProperty_Click;
			this.contextMenuStripWhitePoint.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItemRemoveWhitePoint,
				this.toolStripMenuItem_0
			});
			this.contextMenuStripWhitePoint.Name = "contextMenuStripWhitePoint";
			this.contextMenuStripWhitePoint.Size = new Size(128, 48);
			this.contextMenuStripWhitePoint.Opening += this.contextMenuStripWhitePoint_Opening;
			this.toolStripMenuItemRemoveWhitePoint.Name = "toolStripMenuItemRemoveWhitePoint";
			this.toolStripMenuItemRemoveWhitePoint.Size = new Size(127, 22);
			this.toolStripMenuItemRemoveWhitePoint.Text = "Удалить";
			this.toolStripMenuItemRemoveWhitePoint.Click += this.toolStripMenuItemRemoveWhitePoint_Click;
			this.toolStripMenuItem_0.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.toolStripMenuItem_0.Name = "свойстваToolStripMenuItem";
			this.toolStripMenuItem_0.Size = new Size(127, 22);
			this.toolStripMenuItem_0.Text = "Свойства";
			this.toolStripMenuItem_0.Click += this.toolMenuItemTextBranchProperty_Click;
			this.contextMenuFrame.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuFramePrint,
				this.toolStripMenuFrameCopyToImage,
				this.toolStripMenuFrameExportToImage,
				this.toolStripMenuFrameFitZoom
			});
			this.contextMenuFrame.Name = "contextMenuFrame";
			this.contextMenuFrame.Size = new Size(202, 92);
			this.toolStripMenuFramePrint.Name = "toolStripMenuFramePrint";
			this.toolStripMenuFramePrint.Size = new Size(201, 22);
			this.toolStripMenuFramePrint.Text = "Печать";
			this.toolStripMenuFramePrint.Click += this.toolStripMenuFramePrint_Click;
			this.toolStripMenuFrameCopyToImage.Name = "toolStripMenuFrameCopyToImage";
			this.toolStripMenuFrameCopyToImage.Size = new Size(201, 22);
			this.toolStripMenuFrameCopyToImage.Text = "Копировать в картинку";
			this.toolStripMenuFrameCopyToImage.Click += this.toolStripMenuFrameCopyToImage_Click;
			this.toolStripMenuFrameExportToImage.Name = "toolStripMenuFrameExportToImage";
			this.toolStripMenuFrameExportToImage.Size = new Size(201, 22);
			this.toolStripMenuFrameExportToImage.Text = "Экспорт в картинку";
			this.toolStripMenuFrameExportToImage.Click += this.toolStripMenuFrameExportToImage_Click;
			this.toolStripMenuFrameFitZoom.Name = "toolStripMenuFrameFitZoom";
			this.toolStripMenuFrameFitZoom.Size = new Size(201, 22);
			this.toolStripMenuFrameFitZoom.Text = "Подогнать под рамку";
			this.toolStripMenuFrameFitZoom.Click += this.toolStripMenuFrameFitZoom_Click;
			this.textBoxSearch.Location = new Point(0, 399);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new Size(100, 20);
			this.textBoxSearch.TabIndex = 9;
			this.button1.Location = new Point(112, 397);
			this.button1.Name = "button1";
			this.button1.Size = new Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "search";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += this.button1_Click;
			this.contextMenuTextBranchTool.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_1,
				this.toolMenuItemTextBranchDel,
				this.toolMenuItemTextBranchProperty
			});
			this.contextMenuTextBranchTool.Name = "contextMenuTextBranchTool";
			this.contextMenuTextBranchTool.Size = new Size(167, 70);
			this.contextMenuTextBranchTool.Opening += this.contextMenuTextBranchTool_Opening;
			this.toolStripMenuItem_1.Name = "копироватьToolStripMenuItem";
			this.toolStripMenuItem_1.Size = new Size(166, 22);
			this.toolStripMenuItem_1.Text = "Копировать";
			this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
			this.toolMenuItemTextBranchDel.Name = "toolMenuItemTextBranchDel";
			this.toolMenuItemTextBranchDel.Size = new Size(166, 22);
			this.toolMenuItemTextBranchDel.Text = "Убрать текст";
			this.toolMenuItemTextBranchDel.Click += this.toolMenuItemTextBranchDel_Click;
			this.toolMenuItemTextBranchProperty.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.toolMenuItemTextBranchProperty.Name = "toolMenuItemTextBranchProperty";
			this.toolMenuItemTextBranchProperty.Size = new Size(166, 22);
			this.toolMenuItemTextBranchProperty.Text = "Свойства текста";
			this.toolMenuItemTextBranchProperty.Click += this.toolMenuItemTextBranchProperty_Click;
			this.AllowDrop = true;
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBoxSearch);
			base.Controls.Add(this.tbPopup);
			base.Controls.Add(this.buttonCheck);
			base.Controls.Add(this.bigBoldButton);
			base.Controls.Add(this.propertyGrid1);
			base.Controls.Add(this.statusStrip);
			this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			base.Name = "CanvasControl";
			base.Size = new Size(754, 494);
			base.Load += this.CanvasControl_Load;
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			((ISupportInitialize)this.dataSetScheme_0).EndInit();
			this.contextMenuSelectedObjects.ResumeLayout(false);
			this.contextMenuRectnagle.ResumeLayout(false);
			this.contextMenuShina.ResumeLayout(false);
			this.contextMenuSwitchTool.ResumeLayout(false);
			this.contextMenuLineTool.ResumeLayout(false);
			this.contextMenuCanvas.ResumeLayout(false);
			this.contextMenuLabelTool.ResumeLayout(false);
			this.contextMenuStripWhitePoint.ResumeLayout(false);
			this.contextMenuFrame.ResumeLayout(false);
			this.contextMenuTextBranchTool.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public XmlDocument SaveToXmlDocument()
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml("<canvas></canvas>");
			XmlNode xmlNode = xmlDocument.SelectSingleNode("canvas");
			foreach (ICanvasLayer canvasLayer in this.list_0)
			{
				DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
				drawingLayer.SaveToXML(xmlNode);
			}
			return xmlDocument;
		}

		public void SaveToFile(string fileName)
		{
			XmlDocument xmlDocument = this.SaveToXmlDocument();
			xmlDocument.Save(fileName);
		}

		public void LoadFile(string fileName)
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(fileName);
			this.LoadSchemeFromXML(xmlDocument, false);
		}

		public void SaveCurrentXmlDocument()
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_Schemes, true, "where [Name]='" + this.string_4 + "'");
			if (this.dataSetScheme_0.tSchm_Schemes.Rows.Count == 0)
			{
				DataRow dataRow = this.dataSetScheme_0.tSchm_Schemes.NewRow();
				dataRow["Name"] = this.string_4;
				dataRow["SchmDataXml"] = this.xmlDocument_0.InnerXml;
				this.dataSetScheme_0.tSchm_Schemes.Rows.Add(dataRow);
				sqlDataCommand.InsertSqlDataOneRow(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_Schemes);
				return;
			}
			this.dataSetScheme_0.tSchm_Schemes.Rows[0]["SchmDataXml"] = this.xmlDocument_0.InnerXml;
			this.dataSetScheme_0.tSchm_Schemes.Rows[0].EndEdit();
			sqlDataCommand.UpdateSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_Schemes);
		}

		public void SaveToBase()
		{
			XmlDocument xmlDocument = this.SaveToXmlDocument();
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_Schemes, true, "where [Name]='" + this.string_4 + "'");
			if (this.dataSetScheme_0.tSchm_Schemes.Rows.Count == 0)
			{
				DataRow dataRow = this.dataSetScheme_0.tSchm_Schemes.NewRow();
				dataRow["Name"] = this.string_4;
				dataRow["SchmDataXml"] = xmlDocument.InnerXml;
				this.dataSetScheme_0.tSchm_Schemes.Rows.Add(dataRow);
				sqlDataCommand.InsertSqlDataOneRow(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_Schemes);
				return;
			}
			this.dataSetScheme_0.tSchm_Schemes.Rows[0]["SchmDataXml"] = xmlDocument.InnerXml;
			this.dataSetScheme_0.tSchm_Schemes.Rows[0].EndEdit();
			sqlDataCommand.UpdateSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_Schemes);
		}

		public void LoadScheme()
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			eTypeCanvas typeCanvas = this.TypeCanvas;
			if (typeCanvas != eTypeCanvas.SchemeMain)
			{
				return;
			}
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.vSchm_ObjListXml, false, " where TypeSchema = " + 1 + " and [Deleted] = 0 ");
			this.SendMessage("Объектов в базе: " + this.dataSetScheme_0.vSchm_ObjListXml.Rows.Count.ToString(), eMessageType.Information);
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_Label, true, "where Tag is null");
			this.SendMessage("Надписей в базе: " + this.dataSetScheme_0.tSchm_Label.Rows.Count.ToString(), eMessageType.Information);
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_Relation, true);
			this.SendMessage("Связей в базе: " + this.dataSetScheme_0.tSchm_Relation.Rows.Count.ToString(), eMessageType.Information);
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.vSchm_CabSection, true);
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_ObjList, false, " where [TypeCodeId] = 940 and [Deleted] = 0 ");
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.vP_PassportDataReports, true, "where typecodeid in (538,535,537,536) and [CharName] like 'Принадлежность' and [CharValue] like 'Абонентская'");
			this.method_7();
			this.dataSetScheme_0.vSchm_ObjListXml.Clear();
			this.dataSetScheme_0.tSchm_Label.Clear();
			this.dataSetScheme_0.tSchm_Relation.Clear();
			this.dataSetScheme_0.vSchm_CabSection.Clear();
			this.dataSetScheme_0.tSchm_ObjList.Clear();
			this.dataSetScheme_0.vP_PassportDataReports.Clear();
		}

		public void LoadSchemeAll()
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.vSchm_ObjListXml, false, " where TypeSchema = " + 1 + " and [Deleted] = 0 union all select *  from vSChm_ObjListXml s2 where s2.typeSchema = 2 and s2.id not in (select id from vSchm_ObjListxml where typeSchema = 1) and deleted = 0");
			this.SendMessage("Объектов в базе: " + this.dataSetScheme_0.vSchm_ObjListXml.Rows.Count.ToString(), eMessageType.Information);
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_Relation, true);
			this.SendMessage("Связей в базе: " + this.dataSetScheme_0.tSchm_Relation.Rows.Count.ToString(), eMessageType.Information);
			this.method_7();
			this.dataSetScheme_0.vSchm_ObjListXml.Clear();
			this.dataSetScheme_0.tSchm_Label.Clear();
			this.dataSetScheme_0.tSchm_Relation.Clear();
			this.dataSetScheme_0.vSchm_CabSection.Clear();
			this.dataSetScheme_0.tSchm_ObjList.Clear();
		}

		public void LoadScheme(RectangleTool subStation)
		{
			int idBase = subStation.IdBase;
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_ObjList, false, " where id = " + idBase.ToString());
			if (this.dataSetScheme_0.tSchm_ObjList.Rows.Count == 0)
			{
				return;
			}
			bool flag = false;
			foreach (object obj in Enum.GetValues(typeof(eTypeRectangleTool)))
			{
				eTypeRectangleTool eTypeRectangleTool = (eTypeRectangleTool)obj;
				if ((int)this.dataSetScheme_0.tSchm_ObjList.Rows[0]["TypeCodeId"] == (int)eTypeRectangleTool)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				return;
			}
			this.method_5(idBase);
			this.IdRect = idBase;
			this.method_6();
			using (IEnumerator<DrawObjectBase> enumerator2 = this.icanvasLayer_0.Objects.GetEnumerator())
			{
				Func<DrawObjectBase, bool> func = null;
				CanvasControl.Class7 @class = new CanvasControl.Class7();
				while (enumerator2.MoveNext())
				{
					DrawObjectBase drawObjectBase = enumerator2.Current;
					@class.drawObjectBase_0 = drawObjectBase;
					@class.drawObjectBase_0.GetType();
					typeof(ShinaTool);
					if (@class.drawObjectBase_0.IdBase == subStation.IdBase)
					{
						@class.drawObjectBase_0.Master = subStation;
					}
					if (@class.drawObjectBase_0.LimitedEditing)
					{
						IEnumerable<DrawObjectBase> objects = subStation.Layer.Objects;
						if (func == null)
						{
							func = new Func<DrawObjectBase, bool>(@class.method_0);
						}
						IEnumerable<DrawObjectBase> source = objects.Where(func);
						if (source.Count<DrawObjectBase>() > 0)
						{
							@class.drawObjectBase_0.Master = source.First<DrawObjectBase>();
							if (@class.drawObjectBase_0 is ObjectOnLine && ((ObjectOnLine)@class.drawObjectBase_0.Master).ComplexSwitchgear != null)
							{
								ComplexSwitchgearTool complexSwitchgear = ((ObjectOnLine)@class.drawObjectBase_0.Master).ComplexSwitchgear;
								if (((ObjectOnLine)@class.drawObjectBase_0).ComplexSwitchgear == null)
								{
									((ObjectOnLine)@class.drawObjectBase_0).SetComplexSwitchgear();
								}
								((ObjectOnLine)@class.drawObjectBase_0).ComplexSwitchgear.RollingOutReason = complexSwitchgear.RollingOutReason;
							}
						}
						if (@class.drawObjectBase_0.Master == null)
						{
							@class.drawObjectBase_0.LimitedEditing = false;
						}
					}
				}
			}
		}

		public int IdRect { get; set; }

		private void method_4(int int_10, List<DrawObjectBase> list_9)
		{
			CanvasControl.Class8 @class = new CanvasControl.Class8();
			@class.int_0 = int_10;
			if (this.icanvasLayer_0 != null)
			{
				if (this.TypeCanvas == eTypeCanvas.SchemeMain)
				{
					SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
					DataSetScheme dataSetScheme = new DataSetScheme();
					IEnumerable<DrawObjectBase> enumerable = this.icanvasLayer_0.Objects.Where(new Func<DrawObjectBase, bool>(@class.method_0));
					StringBuilder stringBuilder = new StringBuilder();
					foreach (DrawObjectBase drawObjectBase in enumerable)
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append(", ");
						}
						stringBuilder.Append(drawObjectBase.IdBase);
					}
					string text = "Tag = " + @class.int_0.ToString() + " and deleted = 0";
					if (stringBuilder.Length > 0)
					{
						text = text + " and id not in (" + stringBuilder.ToString() + ")";
					}
					sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.vSchm_ObjListXml, false, " where " + text);
					DataRow[] array = dataSetScheme.vSchm_ObjListXml.Select(string.Concat(new string[]
					{
						" typecodeId in (",
						676.ToString(),
						",",
						675.ToString(),
						",",
						678.ToString(),
						",",
						679.ToString(),
						",",
						547.ToString(),
						",",
						983.ToString(),
						",",
						546.ToString(),
						",",
						548.ToString(),
						")"
					}));
					if (array.Length > 0)
					{
						text = "";
						foreach (DataRow dataRow in array)
						{
							if (text.Length > 0)
							{
								text += ",";
							}
							text += dataRow["id"].ToString();
						}
						sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_Relation, false, " where Edge in (" + text + ")");
					}
					DataRow[] array3 = dataSetScheme.vSchm_ObjListXml.Select(string.Concat(new string[]
					{
						" typecodeId in (",
						536.ToString(),
						",",
						535.ToString(),
						",",
						537.ToString(),
						",",
						538.ToString(),
						",",
						1034.ToString(),
						",",
						1275.ToString(),
						")"
					}));
					foreach (DataRow dataRow2 in array3)
					{
						RectangleTool rectangleTool = new RectangleTool();
						list_9.Add(rectangleTool);
						rectangleTool.IdBase = Convert.ToInt32(dataRow2["id"]);
						rectangleTool.Text = dataRow2["name"].ToString();
						rectangleTool.TypeRectnagleTool = (eTypeRectangleTool)Convert.ToInt32(dataRow2["typecodeId"]);
					}
					array3 = dataSetScheme.vSchm_ObjListXml.Select(string.Concat(new string[]
					{
						" typecodeId in (",
						563.ToString(),
						",",
						540.ToString(),
						",",
						564.ToString(),
						",",
						541.ToString(),
						")"
					}));
					text = "";
					Func<DrawObjectBase, bool> func = null;
					Func<DrawObjectBase, bool> func2 = null;
					CanvasControl.Class9 class2 = new CanvasControl.Class9();
					class2.class8_0 = @class;
					DataRow[] array5 = array3;
					for (int k = 0; k < array5.Length; k++)
					{
						class2.dataRow_0 = array5[k];
						ShinaTool shinaTool = new ShinaTool();
						list_9.Add(shinaTool);
						shinaTool.IdBase = Convert.ToInt32(class2.dataRow_0["id"]);
						shinaTool.Text = class2.dataRow_0["name"].ToString();
						shinaTool.TypeShinaTool = (eTypeShinaTool)Convert.ToInt32(class2.dataRow_0["typecodeId"]);
						DrawObjectBase drawObjectBase2 = shinaTool;
						IEnumerable<DrawObjectBase> source = enumerable;
						if (func == null)
						{
							func = new Func<DrawObjectBase, bool>(class2.method_0);
						}
						drawObjectBase2.Parent = source.First(func);
						if (shinaTool.Parent == null)
						{
							DrawObjectBase drawObjectBase3 = shinaTool;
							if (func2 == null)
							{
								func2 = new Func<DrawObjectBase, bool>(class2.method_1);
							}
							drawObjectBase3.Parent = list_9.First(func2);
						}
						if (text.Length > 0)
						{
							text += ",";
						}
						text += class2.dataRow_0["id"].ToString();
					}
					IEnumerable<DrawObjectBase> source2 = enumerable;
					if (CanvasControl.func_10 == null)
					{
						CanvasControl.func_10 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_12);
					}
					foreach (DrawObjectBase drawObjectBase4 in source2.Where(CanvasControl.func_10))
					{
						if (text.Length > 0)
						{
							text += ",";
						}
						text += drawObjectBase4.IdBase.ToString();
					}
					array3 = dataSetScheme.vSchm_ObjListXml.Select(" idParent in (" + text + ")");
					Func<DrawObjectBase, bool> func3 = null;
					Func<DrawObjectBase, bool> func4 = null;
					CanvasControl.Class10 class3 = new CanvasControl.Class10();
					class3.class8_0 = @class;
					DataRow[] array6 = array3;
					for (int l = 0; l < array6.Length; l++)
					{
						class3.dataRow_0 = array6[l];
						PointShinaTool pointShinaTool = new PointShinaTool();
						list_9.Add(pointShinaTool);
						pointShinaTool.IdBase = Convert.ToInt32(class3.dataRow_0["id"]);
						pointShinaTool.Text = class3.dataRow_0["name"].ToString();
						DrawObjectBase drawObjectBase5 = pointShinaTool;
						IEnumerable<DrawObjectBase> source3 = enumerable;
						if (func3 == null)
						{
							func3 = new Func<DrawObjectBase, bool>(class3.method_0);
						}
						drawObjectBase5.Parent = source3.First(func3);
						if (pointShinaTool.Parent == null)
						{
							DrawObjectBase drawObjectBase6 = pointShinaTool;
							if (func4 == null)
							{
								func4 = new Func<DrawObjectBase, bool>(class3.method_1);
							}
							drawObjectBase6.Parent = list_9.First(func4);
						}
					}
					return;
				}
			}
		}

		private void method_5(int int_10)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_Label, true, "where Tag = " + int_10.ToString());
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.vSchm_ObjListXml, false, string.Concat(new string[]
			{
				" where (id = ",
				int_10.ToString(),
				" or idParent = ",
				int_10.ToString(),
				" or Tag = ",
				int_10.ToString(),
				") and deleted = 0"
			}));
			DataRow[] array = this.dataSetScheme_0.vSchm_ObjListXml.Select(string.Concat(new string[]
			{
				" typecodeId in (",
				676.ToString(),
				",",
				675.ToString(),
				",",
				678.ToString(),
				",",
				679.ToString(),
				")"
			}));
			if (array.Length > 0)
			{
				string text = "";
				foreach (DataRow dataRow in array)
				{
					text = text + dataRow["id"].ToString() + ",";
				}
				text = text.Remove(text.Length - 1);
				sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_Relation, false, " where Edge in (" + text + ")");
				if (this.dataSetScheme_0.tSchm_Relation.Rows.Count > 0)
				{
					string text2 = "";
					foreach (object obj in Enum.GetValues(typeof(TypeSwitch)))
					{
						TypeSwitch typeSwitch = (TypeSwitch)obj;
						string str = text2;
						int num = (int)typeSwitch;
						text2 = str + num.ToString() + ",";
					}
					text2 = text2.Remove(text2.Length - 1);
					text = "";
					string text3 = "";
					foreach (object obj2 in this.dataSetScheme_0.tSchm_Relation.Rows)
					{
						DataRow dataRow2 = (DataRow)obj2;
						text = text + dataRow2["id"].ToString() + ",";
						string text4 = text3;
						text3 = string.Concat(new string[]
						{
							text4,
							dataRow2["SourceObj"].ToString(),
							",",
							dataRow2["DestObj"].ToString(),
							","
						});
					}
					text = text.Remove(text.Length - 1);
					text3 = text3.Remove(text3.Length - 1);
					DataSetScheme dataSetScheme = new DataSetScheme();
					DataRow[] array3 = this.dataSetScheme_0.vSchm_ObjListXml.Select(string.Concat(new string[]
					{
						" typecodeId in (",
						547.ToString(),
						",",
						546.ToString(),
						",",
						548.ToString(),
						")"
					}));
					string text5 = "";
					foreach (DataRow dataRow3 in array3)
					{
						text5 = text5 + dataRow3["id"].ToString() + ",";
					}
					if (text5.Length > 0)
					{
						text5 = text5.Remove(text5.Length - 1);
						sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_Relation, false, " where Edge in (" + text5 + ")");
						text5 = string.Empty;
					}
					string text6 = string.Empty;
					foreach (object obj3 in dataSetScheme.tSchm_Relation.Rows)
					{
						DataRow dataRow4 = (DataRow)obj3;
						this.dataSetScheme_0.tSchm_Relation.ImportRow(dataRow4);
						text5 = text5 + dataRow4["id"].ToString() + ",";
						string text7 = text6;
						text6 = string.Concat(new string[]
						{
							text7,
							dataRow4["SourceObj"].ToString(),
							",",
							dataRow4["DestObj"].ToString(),
							","
						});
					}
					if (text5.Length > 0)
					{
						text5 = text5.Remove(text5.Length - 1);
						text = text + "," + text5;
					}
					sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_Relation, false, string.Concat(new string[]
					{
						" where id not in (",
						text,
						") and (SourceObj in (",
						text3,
						") or DestObj in (",
						text3,
						"))"
					}));
					text += ",";
					text5 = "";
					foreach (object obj4 in dataSetScheme.tSchm_Relation.Rows)
					{
						DataRow dataRow5 = (DataRow)obj4;
						text = text + dataRow5["id"].ToString() + ",";
						string text8 = text6;
						text6 = string.Concat(new string[]
						{
							text8,
							dataRow5["SourceObj"].ToString(),
							",",
							dataRow5["DestObj"].ToString(),
							","
						});
						text5 = text5 + dataRow5["Edge"].ToString() + ",";
						this.dataSetScheme_0.tSchm_Relation.ImportRow(dataRow5);
					}
					text = text.Remove(text.Length - 1);
					if (text6.Length > 0)
					{
						text6 = text6.Remove(text6.Length - 1);
					}
					if (text5.Length > 0)
					{
						text5 = text5.Remove(text5.Length - 1);
						sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.vSchm_ObjListXml, false, " where Id in (" + text5 + ") and Tag is NULL and deleted = 0 ");
						foreach (object obj5 in dataSetScheme.vSchm_ObjListXml.Rows)
						{
							DataRow row = (DataRow)obj5;
							this.dataSetScheme_0.vSchm_ObjListXml.ImportRow(row);
						}
						sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.tSchm_Relation, false, string.Concat(new string[]
						{
							" where Edge in (",
							text5,
							") and id not in(",
							text,
							") "
						}));
						text6 += ",";
						text += ",";
						foreach (object obj6 in dataSetScheme.tSchm_Relation.Rows)
						{
							DataRow dataRow6 = (DataRow)obj6;
							this.dataSetScheme_0.tSchm_Relation.ImportRow(dataRow6);
							text = text + dataRow6["id"].ToString() + ",";
							string text9 = text6;
							text6 = string.Concat(new string[]
							{
								text9,
								dataRow6["SourceObj"].ToString(),
								",",
								dataRow6["DestObj"].ToString(),
								","
							});
						}
						text = text.Remove(text.Length - 1);
						text6 = text6.Remove(text6.Length - 1);
					}
					if (text6 != string.Empty)
					{
						text3 = text3 + "," + text6;
					}
					sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.vSchm_ObjListXml, false, string.Concat(new string[]
					{
						" where idParent in (",
						text,
						") and typecodeId in (",
						text2,
						") and deleted = 0 "
					}));
					for (int k = 0; k < dataSetScheme.vSchm_ObjListXml.Rows.Count; k++)
					{
						DataRow dataRow7 = dataSetScheme.vSchm_ObjListXml.Rows[k];
						if (Convert.ToInt32(dataRow7["TypeSchema"]) == 1 && dataSetScheme.vSchm_ObjListXml.Select(" id  = " + dataRow7["id"].ToString() + " and TypeSchema = " + 2.ToString()).Length > 0)
						{
							dataSetScheme.vSchm_ObjListXml.Rows.Remove(dataRow7);
							k--;
						}
					}
					foreach (object obj7 in dataSetScheme.vSchm_ObjListXml.Rows)
					{
						DataRow row2 = (DataRow)obj7;
						this.dataSetScheme_0.vSchm_ObjListXml.ImportRow(row2);
					}
					sqlDataCommand.SelectSqlData(dataSetScheme, dataSetScheme.vSchm_ObjListXml, false, string.Concat(new object[]
					{
						" where id in (",
						text3,
						") and deleted = 0 and (Tag = ",
						int_10,
						" or Tag is NULL)"
					}));
					foreach (object obj8 in dataSetScheme.vSchm_ObjListXml.Rows)
					{
						DataRow row3 = (DataRow)obj8;
						this.dataSetScheme_0.vSchm_ObjListXml.ImportRow(row3);
					}
				}
			}
		}

		private void method_6()
		{
			Func<DataRow, bool> func = null;
			bool flag = false;
			this.loadedPoints.Clear();
			this.list_0.Clear();
			this.dictionary_0.Clear();
			DrawingLayer drawingLayer = new DrawingLayer("SchemaSecond", "SchemaSecond", Color.White, 0f);
			drawingLayer.Parent = this;
			this.AddLayer(drawingLayer);
			this.ActiveLayer = drawingLayer;
			int[] array = new int[]
			{
				556
			};
			DataTable journalData = PassportData.GetJournalData(this.sqlsettings_0, array);
			array = new int[]
			{
				546
			};
			DataTable journalData2 = PassportData.GetJournalData(this.sqlsettings_0, array);
			new XmlDocument();
			string text = "";
			foreach (object obj in Enum.GetValues(typeof(eTypeRectangleTool)))
			{
				eTypeRectangleTool eTypeRectangleTool = (eTypeRectangleTool)obj;
				text = text + Convert.ToInt32(eTypeRectangleTool).ToString() + ",";
			}
			text = text.Remove(text.Length - 1);
			IEnumerable<DataRow> enumerable = this.dataSetScheme_0.vSchm_ObjListXml.Select(string.Concat(new object[]
			{
				"TypeCodeId in (",
				text,
				") and typeSchema = ",
				(int)this.TypeCanvas
			}));
			RectangleTool rectangleTool;
			if (enumerable.Count<DataRow>() == 0)
			{
				enumerable = this.dataSetScheme_0.vSchm_ObjListXml.Select(string.Concat(new object[]
				{
					"TypeCodeId in (",
					text,
					") and typeSchema = ",
					1
				}));
				rectangleTool = new RectangleTool(enumerable.First<DataRow>(), drawingLayer);
				rectangleTool.Rectangle = new RectangleF(-1000000f, -1000000f, 2000000f, 2000000f);
				rectangleTool.Visible = false;
				flag = true;
				rectangleTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
			}
			else
			{
				IEnumerable<DataRow> source = enumerable;
				if (func == null)
				{
					func = new Func<DataRow, bool>(this.method_85);
				}
				rectangleTool = new RectangleTool(source.Where(func).First<DataRow>(), drawingLayer);
				foreach (DataRow dataRow in enumerable)
				{
					if (Convert.ToInt32(dataRow["Id"]) != this.IdRect)
					{
						RectangleTool rectangleTool2 = new RectangleTool(dataRow, drawingLayer);
						rectangleTool2.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
					}
				}
			}
			rectangleTool.DrawNewObjectEvent += this.drawObjectBase_0_DrawNewObjectEvent;
			UnitPoint right = UnitPoint.Empty;
			text = "";
			foreach (object obj2 in Enum.GetValues(typeof(eTypeShinaTool)))
			{
				eTypeShinaTool eTypeShinaTool = (eTypeShinaTool)obj2;
				text = text + Convert.ToInt32(eTypeShinaTool).ToString() + ",";
			}
			text = text.Remove(text.Length - 1);
			IEnumerable<DataRow> enumerable2 = this.dataSetScheme_0.vSchm_ObjListXml.Select("TypeCodeId in (" + text + ")");
			using (IEnumerator<DataRow> enumerator2 = enumerable2.GetEnumerator())
			{
				Func<DataRow, bool> func2 = null;
				Func<DataRow, bool> func3 = null;
				Func<DrawObjectBase, bool> func4 = null;
				CanvasControl.Class11 @class = new CanvasControl.Class11();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow_ = enumerator2.Current;
					@class.dataRow_0 = dataRow_;
					if (!@class.dataRow_0.IsNull("TypeSchema"))
					{
						if (Convert.ToInt32(@class.dataRow_0["TypeSchema"]) == 1)
						{
							DataRow dataRow2 = null;
							try
							{
								IEnumerable<DataRow> source2 = enumerable2;
								if (func2 == null)
								{
									func2 = new Func<DataRow, bool>(@class.method_0);
								}
								dataRow2 = source2.First(func2);
							}
							catch
							{
							}
							if (dataRow2 == null)
							{
								ShinaTool shinaTool = new ShinaTool(@class.dataRow_0, drawingLayer);
								if (right.IsEmpty)
								{
									right = new UnitPoint(0.0, 0.0) - shinaTool.P1;
								}
								shinaTool.P1 += right;
								shinaTool.P2 += right;
								shinaTool.Parent = rectangleTool;
								shinaTool.LimitedEditing = true;
								drawingLayer.AddObject(shinaTool);
								shinaTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
								DataRow[] array2 = this.dataSetScheme_0.vSchm_ObjListXml.Select(string.Concat(new object[]
								{
									" IdParent = ",
									shinaTool.IdBase.ToString(),
									" and typeCodeId = ",
									111.ToString(),
									" and TypeSchema = ",
									1
								}));
								foreach (DataRow dataRow_2 in array2)
								{
									PointShinaTool pointShinaTool = new PointShinaTool(dataRow_2);
									if (!right.IsEmpty)
									{
										pointShinaTool.Point += right;
									}
									pointShinaTool.Layer = drawingLayer;
									shinaTool.AddPointShinaTool(pointShinaTool);
									this.loadedPoints.Add(pointShinaTool.IdBase, pointShinaTool);
								}
								flag = true;
							}
						}
						else
						{
							try
							{
								IEnumerable<DataRow> source3 = enumerable2;
								if (func3 == null)
								{
									func3 = new Func<DataRow, bool>(@class.method_1);
								}
								source3.First(func3);
							}
							catch
							{
							}
							ShinaTool shinaTool2 = new ShinaTool(@class.dataRow_0, drawingLayer);
							DrawObjectBase drawObjectBase = shinaTool2;
							IEnumerable<DrawObjectBase> objects = drawingLayer.Objects;
							if (func4 == null)
							{
								func4 = new Func<DrawObjectBase, bool>(@class.method_2);
							}
							drawObjectBase.Parent = objects.Where(func4).First<DrawObjectBase>();
							foreach (DrawObjectBase drawobject in shinaTool2.splitters)
							{
								drawingLayer.AddObject(drawobject);
							}
							shinaTool2.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
							DataRow[] array4 = this.dataSetScheme_0.vSchm_ObjListXml.Select(" IdParent = " + shinaTool2.IdBase.ToString() + " and typeCodeId = " + 111.ToString());
							Dictionary<int, DataRow> dictionary = new Dictionary<int, DataRow>();
							foreach (DataRow dataRow3 in array4)
							{
								if (!dictionary.ContainsKey((int)dataRow3["Id"]))
								{
									dictionary.Add((int)dataRow3["Id"], dataRow3);
								}
								else if ((int)dataRow3["TypeSchema"] == (int)this.TypeCanvas)
								{
									dictionary[(int)dataRow3["Id"]] = dataRow3;
								}
							}
							foreach (DataRow dataRow4 in dictionary.Values)
							{
								if ((int)dataRow4["TypeSchema"] == (int)this.TypeCanvas)
								{
									PointShinaTool pointShinaTool2 = new PointShinaTool(dataRow4);
									pointShinaTool2.Layer = drawingLayer;
									shinaTool2.AddPointShinaTool(pointShinaTool2);
									this.loadedPoints.Add(pointShinaTool2.IdBase, pointShinaTool2);
								}
								else
								{
									PointShinaTool pointShinaTool3 = new PointShinaTool(dataRow4);
									if (!right.IsEmpty)
									{
										pointShinaTool3.Point += right;
									}
									pointShinaTool3.Layer = drawingLayer;
									shinaTool2.AddPointShinaTool(pointShinaTool3);
									this.loadedPoints.Add(pointShinaTool3.IdBase, pointShinaTool3);
								}
							}
						}
					}
				}
			}
			text = "";
			foreach (object obj3 in Enum.GetValues(typeof(LineToolType)))
			{
				LineToolType lineToolType = (LineToolType)obj3;
				if (lineToolType == LineToolType.CellLine_10 || lineToolType == LineToolType.CellLine_6 || lineToolType == LineToolType.CellLine_04 || lineToolType == LineToolType.CellLine_023)
				{
					text = text + Convert.ToInt32(lineToolType).ToString() + ",";
				}
			}
			text = text.Remove(text.Length - 1);
			IEnumerable<DataRow> enumerable3 = this.dataSetScheme_0.vSchm_ObjListXml.Select("  TypeCodeId in (" + text + ")");
			using (IEnumerator<DataRow> enumerator2 = enumerable3.GetEnumerator())
			{
				Func<DataRow, bool> func5 = null;
				Func<DrawObjectBase, bool> func6 = null;
				Func<DrawObjectBase, bool> func7 = null;
				CanvasControl.Class12 class2 = new CanvasControl.Class12();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow_3 = enumerator2.Current;
					class2.dataRow_0 = dataRow_3;
					if (!class2.dataRow_0.IsNull("TypeSchema"))
					{
						if (!class2.dataRow_0.IsNull("TypeSchema") && Convert.ToInt32(class2.dataRow_0["TypeSchema"]) == 1)
						{
							DataRow dataRow5 = null;
							try
							{
								IEnumerable<DataRow> source4 = enumerable3;
								if (func5 == null)
								{
									func5 = new Func<DataRow, bool>(class2.method_0);
								}
								dataRow5 = source4.First(func5);
							}
							catch
							{
							}
							if (dataRow5 == null)
							{
								LineCellTool lineCellTool = new LineCellTool(class2.dataRow_0, drawingLayer);
								lineCellTool.LimitedEditing = true;
								if (!right.IsEmpty)
								{
									List<PointTool> pointsList = lineCellTool.GetPointsList();
									foreach (PointTool pointTool in pointsList)
									{
										if (pointTool.GetType() != typeof(PointShinaTool))
										{
											if (pointTool.IdBase > 0)
											{
												DataRow[] array5 = drawingLayer.Parent.dataSetScheme_0.vSchm_ObjListXml.Select(string.Concat(new object[]
												{
													"Id = ",
													pointTool.IdBase,
													" and typeSChema = ",
													((int)drawingLayer.Parent.TypeCanvas).ToString()
												}));
												if (array5.Length == 0)
												{
													pointTool.Point += right;
												}
											}
											else
											{
												pointTool.Point += right;
											}
										}
									}
								}
								foreach (Branch branch in lineCellTool.Branches)
								{
									foreach (DrawObjectBase drawObjectBase2 in branch.ChildObjects)
									{
										if (drawObjectBase2.GetType() == typeof(TransformerTool))
										{
											TransformerTool transformerTool = (TransformerTool)drawObjectBase2;
											DataRow[] array6 = journalData.Select("id = " + transformerTool.IdBase.ToString() + " and IdPassport is not null");
											if (array6.Length > 0)
											{
												transformerTool.passportDataRow = array6[0];
											}
										}
									}
								}
								try
								{
									DrawObjectBase drawObjectBase3 = lineCellTool;
									IEnumerable<DrawObjectBase> objects2 = drawingLayer.Objects;
									if (func6 == null)
									{
										func6 = new Func<DrawObjectBase, bool>(class2.method_1);
									}
									drawObjectBase3.Parent = objects2.Where(func6).First<DrawObjectBase>();
								}
								catch
								{
									continue;
								}
								lineCellTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
								flag = true;
							}
						}
						else if (!class2.dataRow_0.IsNull("TypeSchema"))
						{
							LineCellTool lineCellTool2 = new LineCellTool(class2.dataRow_0, drawingLayer);
							foreach (CouplingRelation couplingRelation in lineCellTool2.CouplingRelations)
							{
								if (couplingRelation.Branches.Count != 0)
								{
									string text2 = string.Empty;
									foreach (TypeSwitch typeSwitch in (TypeSwitch[])Enum.GetValues(typeof(TypeSwitch)))
									{
										if (text2 != string.Empty)
										{
											text2 += ", ";
										}
										string str = text2;
										int num = (int)typeSwitch;
										text2 = str + num.ToString();
									}
									DataRow[] array8 = drawingLayer.Parent.dataSetScheme_0.vSchm_ObjListXml.Select(string.Concat(new object[]
									{
										"IdParent = ",
										couplingRelation.Id,
										" and TypeCodeId in (",
										text2,
										")"
									}));
									Func<DrawObjectBase, bool> func8 = null;
									CanvasControl.Class13 class3 = new CanvasControl.Class13();
									class3.class12_0 = class2;
									DataRow[] array3 = array8;
									for (int i = 0; i < array3.Length; i++)
									{
										class3.dataRow_0 = array3[i];
										IEnumerable<DrawObjectBase> objects3 = drawingLayer.Objects;
										if (func8 == null)
										{
											func8 = new Func<DrawObjectBase, bool>(class3.method_0);
										}
										IEnumerable<DrawObjectBase> source5 = objects3.Where(func8);
										if (source5.Count<DrawObjectBase>() <= 0)
										{
											TypeSwitch type = (TypeSwitch)Convert.ToInt32(class3.dataRow_0["TypeCodeId"]);
											ObjectOnLine objectOnLine = ObjectOnLine.CreateObjectOnLine(type, class3.dataRow_0, couplingRelation.Branches[0]);
											objectOnLine.LimitedEditing = lineCellTool2.LimitedEditing;
											drawingLayer.AddObject(objectOnLine);
										}
									}
								}
							}
							foreach (Branch branch2 in lineCellTool2.Branches)
							{
								foreach (DrawObjectBase drawObjectBase4 in branch2.ChildObjects)
								{
									if (drawObjectBase4.GetType() == typeof(TransformerTool))
									{
										TransformerTool transformerTool2 = (TransformerTool)drawObjectBase4;
										DataRow[] array9 = journalData.Select("id = " + transformerTool2.IdBase.ToString() + " and IdPassport is not null");
										if (array9.Length > 0)
										{
											transformerTool2.passportDataRow = array9[0];
										}
									}
								}
							}
							try
							{
								DrawObjectBase drawObjectBase5 = lineCellTool2;
								IEnumerable<DrawObjectBase> objects4 = drawingLayer.Objects;
								if (func7 == null)
								{
									func7 = new Func<DrawObjectBase, bool>(class2.method_2);
								}
								drawObjectBase5.Parent = objects4.Where(func7).First<DrawObjectBase>();
							}
							catch
							{
								continue;
							}
							lineCellTool2.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
						}
					}
				}
			}
			text = "";
			foreach (object obj4 in Enum.GetValues(typeof(LineToolType)))
			{
				LineToolType lineToolType2 = (LineToolType)obj4;
				if (lineToolType2 == LineToolType.AirLine || lineToolType2 == LineToolType.CabelLine || lineToolType2 == LineToolType.MixedLine)
				{
					text = text + Convert.ToInt32(lineToolType2).ToString() + ",";
				}
			}
			text = text.Remove(text.Length - 1);
			IEnumerable<DataRow> enumerable4 = this.dataSetScheme_0.vSchm_ObjListXml.Select("  TypeCodeId in (" + text + ")");
			using (IEnumerator<DataRow> enumerator2 = enumerable4.GetEnumerator())
			{
				Func<DataRow, bool> func9 = null;
				CanvasControl.Class14 class4 = new CanvasControl.Class14();
				while (enumerator2.MoveNext())
				{
					class4.dataRow_0 = enumerator2.Current;
					if (!class4.dataRow_0.IsNull("TypeSchema") && Convert.ToInt32(class4.dataRow_0["TypeSchema"]) == 1)
					{
						DataRow dataRow6 = null;
						try
						{
							IEnumerable<DataRow> source6 = enumerable3;
							if (func9 == null)
							{
								func9 = new Func<DataRow, bool>(class4.method_0);
							}
							dataRow6 = source6.First(func9);
							goto IL_1C1B;
						}
						catch
						{
							goto IL_1C1B;
						}
						IL_F7B:
						LineTool lineTool = new LineTool();
						lineTool.IdBase = (int)class4.dataRow_0["id"];
						lineTool.Text = class4.dataRow_0["Name"].ToString();
						drawingLayer.AddObject(lineTool);
						DataRow[] array10 = drawingLayer.Parent.dataSetScheme_0.tSchm_Relation.Select("Edge = " + lineTool.IdBase.ToString());
						CouplingRelation couplingRelation2 = null;
						DataRow[] array3 = array10;
						int i = 0;
						while (i < array3.Length)
						{
							DataRow dataRow7 = array3[i];
							if (this.loadedPoints.ContainsKey((int)dataRow7["SourceObj"]))
							{
								goto IL_10AF;
							}
							DataRow[] array11 = drawingLayer.Parent.dataSetScheme_0.vSchm_ObjListXml.Select("Id = " + Convert.ToInt32(dataRow7["SourceObj"]));
							if (array11.Length > 0)
							{
								PointTool pointTool2 = new PointTool();
								pointTool2.IdBase = Convert.ToInt32(array11[0]["id"]);
								pointTool2.Layer = drawingLayer;
								drawingLayer.Parent.loadedPoints.Add(pointTool2.IdBase, pointTool2);
								goto IL_10AF;
							}
							IL_11F7:
							i++;
							continue;
							IL_10AF:
							if (!this.loadedPoints.ContainsKey((int)dataRow7["DestObj"]))
							{
								DataRow[] array12 = drawingLayer.Parent.dataSetScheme_0.vSchm_ObjListXml.Select("Id = " + Convert.ToInt32(dataRow7["DestObj"]));
								if (array12.Length <= 0)
								{
									goto IL_11F7;
								}
								PointTool pointTool3 = new PointTool();
								pointTool3.IdBase = Convert.ToInt32(array12[0]["id"]);
								pointTool3.Layer = drawingLayer;
								drawingLayer.Parent.loadedPoints.Add(pointTool3.IdBase, pointTool3);
							}
							PointTool pointTool4 = this.loadedPoints[(int)dataRow7["SourceObj"]];
							PointTool pointTool5 = this.loadedPoints[(int)dataRow7["DestObj"]];
							bool flag2 = pointTool4.Branches.Count<Branch>() > 0 || pointTool5.Branches.Count<Branch>() > 0;
							CouplingRelation couplingRelation3 = new CouplingRelation(pointTool4, pointTool5);
							if (flag2)
							{
								couplingRelation2 = couplingRelation3;
							}
							couplingRelation3.Id = (int)dataRow7["id"];
							couplingRelation3.Line = lineTool;
							lineTool.CouplingRelations.Add(couplingRelation3);
							goto IL_11F7;
						}
						if (couplingRelation2 != null)
						{
							PointTool pointTool6 = null;
							PointTool pointTool7 = null;
							if (couplingRelation2.Vertex1.Branches.Count<Branch>() > 0)
							{
								pointTool6 = couplingRelation2.Vertex1;
								if (couplingRelation2.Vertex2.Branches.Count<Branch>() > 0)
								{
									pointTool7 = couplingRelation2.Vertex2;
								}
							}
							else if (couplingRelation2.Vertex2.Branches.Count<Branch>() > 0)
							{
								pointTool6 = couplingRelation2.Vertex2;
							}
							if (pointTool6 != null)
							{
								LineTool lineTool2 = (LineTool)pointTool6.Branches.First<Branch>().Parent;
								ShinaTool shinaTool3 = null;
								if (pointTool7 == null)
								{
									pointTool7 = new PointTool();
								}
								foreach (PointTool pointTool8 in lineTool2.Ends)
								{
									if (pointTool8.Parent != null && pointTool8.Parent.GetType() == typeof(ShinaTool))
									{
										shinaTool3 = (ShinaTool)pointTool8.Parent;
									}
								}
								if (shinaTool3 == null)
								{
									pointTool7.Point = new UnitPoint(pointTool6.Point.X, pointTool6.Point.Y + 3.0);
								}
								else if (shinaTool3.P1.X != shinaTool3.P2.X)
								{
									if (shinaTool3.P1.Y < pointTool6.Point.Y)
									{
										pointTool7.Point = new UnitPoint(pointTool6.Point.X, pointTool6.Point.Y + 3.0);
									}
									else
									{
										pointTool7.Point = new UnitPoint(pointTool6.Point.X, pointTool6.Point.Y - 3.0);
									}
								}
								else if (shinaTool3.P1.X < pointTool6.Point.X)
								{
									pointTool7.Point = new UnitPoint(pointTool6.Point.X + 3.0, pointTool6.Point.Y);
								}
								else
								{
									pointTool7.Point = new UnitPoint(pointTool6.Point.X - 3.0, pointTool6.Point.Y);
								}
							}
							Branch branch3 = new Branch(lineTool, pointTool6, pointTool7, BranchType.CabelLine, couplingRelation2);
							lineTool.Branches.Add(branch3);
							branch3.Parent = lineTool;
							lineTool.GetPointsList();
						}
						lineTool.LimitedEditing = true;
						foreach (Branch branch4 in lineTool.Branches)
						{
							foreach (DrawObjectBase drawObjectBase6 in branch4.ChildObjects)
							{
								if (drawObjectBase6.GetType() == typeof(TextBranchTool))
								{
									TextBranchTool textBranchTool = (TextBranchTool)drawObjectBase6;
									IEnumerable<DataRow> enumerable5 = this.dataSetScheme_0.vSchm_CabSection.Select("idObjList = " + lineTool.IdBase);
									if (enumerable5.Count<DataRow>() > 0)
									{
										decimal d = 0m;
										DataRow dataRow8 = null;
										decimal num2 = 0m;
										string text3 = string.Empty;
										SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
										string cmdText = "select top 1 id from tP_Passport where idObjList = " + lineTool.IdBase.ToString();
										SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
										try
										{
											sqlConnection.Open();
											int num3 = (int)sqlCommand.ExecuteScalar();
											if (num3 > -1)
											{
												sqlCommand.CommandText = "select top 1 Value from tP_ObjectChar where idObjChar = 182 and idPassport = " + num3.ToString();
												text3 = sqlCommand.ExecuteScalar().ToString();
											}
											goto IL_1774;
										}
										catch
										{
											goto IL_1774;
										}
										IEnumerator<DataRow> enumerator10;
										try
										{
											IL_15F1:
											while (enumerator10.MoveNext())
											{
												DataRow dataRow9 = enumerator10.Current;
												num2 += Convert.ToDecimal(dataRow9[8]);
												if (dataRow8 == null && Convert.ToDecimal(dataRow9[8]) >= 10m)
												{
													d = Convert.ToDecimal(dataRow9[7]);
													dataRow8 = dataRow9;
												}
												else if (Convert.ToDecimal(dataRow9[7]) < d && Convert.ToDecimal(dataRow9[8]) >= 10m)
												{
													d = Convert.ToDecimal(dataRow9[7]);
													dataRow8 = dataRow9;
												}
											}
										}
										finally
										{
											if (enumerator10 != null)
											{
												enumerator10.Dispose();
											}
										}
										if (dataRow8 != null)
										{
											if (text3 == string.Empty)
											{
												text3 = Math.Round(Convert.ToDecimal(num2), 0).ToString();
											}
											textBranchTool.UpdateSQLFields(dataRow8, text3);
										}
										DataRow[] array13 = journalData2.Select("id = " + lineTool.IdBase.ToString());
										if (array13.Length > 0)
										{
											textBranchTool.passportDataRow = array13[0];
											continue;
										}
										continue;
										IL_1774:
										enumerator10 = enumerable5.GetEnumerator();
										goto IL_15F1;
									}
									if (drawObjectBase6.GetType() == typeof(TransformerTool))
									{
										TransformerTool transformerTool3 = (TransformerTool)drawObjectBase6;
										DataRow[] array14 = journalData.Select("id = " + transformerTool3.IdBase.ToString());
										if (array14.Length > 0)
										{
											transformerTool3.passportDataRow = array14[0];
										}
									}
								}
							}
						}
						lineTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
						flag = true;
						continue;
						IL_1C1B:
						if (dataRow6 == null)
						{
							goto IL_F7B;
						}
					}
					else if (!class4.dataRow_0.IsNull("TypeSchema"))
					{
						LineTool lineTool3 = new LineTool(class4.dataRow_0, drawingLayer);
						foreach (CouplingRelation couplingRelation4 in lineTool3.CouplingRelations)
						{
							if (couplingRelation4.Branches.Count != 0)
							{
								DataRow[] array15 = drawingLayer.Parent.dataSetScheme_0.vSchm_ObjListXml.Select("IdParent = " + couplingRelation4.Id);
								Func<DrawObjectBase, bool> func10 = null;
								CanvasControl.Class15 class5 = new CanvasControl.Class15();
								class5.class14_0 = class4;
								DataRow[] array3 = array15;
								for (int i = 0; i < array3.Length; i++)
								{
									class5.dataRow_0 = array3[i];
									IEnumerable<DrawObjectBase> objects5 = drawingLayer.Objects;
									if (func10 == null)
									{
										func10 = new Func<DrawObjectBase, bool>(class5.method_0);
									}
									IEnumerable<DrawObjectBase> source7 = objects5.Where(func10);
									if (source7.Count<DrawObjectBase>() <= 0)
									{
										TypeSwitch type2 = (TypeSwitch)Convert.ToInt32(class5.dataRow_0["TypeCodeId"]);
										ObjectOnLine objectOnLine2 = ObjectOnLine.CreateObjectOnLine(type2, class5.dataRow_0, couplingRelation4.Branches[0]);
										objectOnLine2.LimitedEditing = lineTool3.LimitedEditing;
										drawingLayer.AddObject(objectOnLine2);
									}
								}
							}
						}
						foreach (Branch branch5 in lineTool3.Branches)
						{
							foreach (DrawObjectBase drawObjectBase7 in branch5.ChildObjects)
							{
								if (drawObjectBase7.GetType() == typeof(TextBranchTool))
								{
									TextBranchTool textBranchTool2 = (TextBranchTool)drawObjectBase7;
									IEnumerable<DataRow> enumerable6 = this.dataSetScheme_0.vSchm_CabSection.Select("idObjList = " + lineTool3.IdBase);
									if (enumerable6.Count<DataRow>() > 0)
									{
										decimal d2 = 0m;
										DataRow dataRow10 = null;
										decimal num4 = 0m;
										string text4 = string.Empty;
										SqlConnection sqlConnection2 = new SqlConnection(this.SqlSettings.GetConnectionString());
										string cmdText2 = "select top 1 id from tP_Passport where idObjList = " + lineTool3.IdBase.ToString();
										SqlCommand sqlCommand2 = new SqlCommand(cmdText2, sqlConnection2);
										try
										{
											sqlConnection2.Open();
											int num5 = (int)sqlCommand2.ExecuteScalar();
											if (num5 > -1)
											{
												sqlCommand2.CommandText = "select top 1 Value from tP_ObjectChar where idObjChar = 182 and idPassport = " + num5.ToString();
												text4 = sqlCommand2.ExecuteScalar().ToString();
											}
											goto IL_1BCB;
										}
										catch
										{
											goto IL_1BCB;
										}
										IEnumerator<DataRow> enumerator10;
										try
										{
											IL_1A48:
											while (enumerator10.MoveNext())
											{
												DataRow dataRow11 = enumerator10.Current;
												num4 += Convert.ToDecimal(dataRow11[8]);
												if (dataRow10 == null && Convert.ToDecimal(dataRow11[8]) >= 10m)
												{
													d2 = Convert.ToDecimal(dataRow11[7]);
													dataRow10 = dataRow11;
												}
												else if (Convert.ToDecimal(dataRow11[7]) < d2 && Convert.ToDecimal(dataRow11[8]) >= 10m)
												{
													d2 = Convert.ToDecimal(dataRow11[7]);
													dataRow10 = dataRow11;
												}
											}
										}
										finally
										{
											if (enumerator10 != null)
											{
												enumerator10.Dispose();
											}
										}
										if (dataRow10 != null)
										{
											if (text4 == string.Empty)
											{
												text4 = Math.Round(Convert.ToDecimal(num4), 0).ToString();
											}
											textBranchTool2.UpdateSQLFields(dataRow10, text4);
										}
										DataRow[] array16 = journalData2.Select("id = " + lineTool3.IdBase.ToString());
										if (array16.Length > 0)
										{
											textBranchTool2.passportDataRow = array16[0];
											continue;
										}
										continue;
										IL_1BCB:
										enumerator10 = enumerable6.GetEnumerator();
										goto IL_1A48;
									}
								}
								else if (drawObjectBase7.GetType() == typeof(TransformerTool))
								{
									TransformerTool transformerTool4 = (TransformerTool)drawObjectBase7;
									DataRow[] array17 = journalData.Select("id = " + transformerTool4.IdBase.ToString());
									if (array17.Length > 0)
									{
										transformerTool4.passportDataRow = array17[0];
									}
								}
							}
						}
						lineTool3.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
					}
				}
			}
			foreach (object obj5 in this.dataSetScheme_0.tSchm_Label.Rows)
			{
				DataRow dataRow12 = (DataRow)obj5;
				if (dataRow12["IdParent"] != DBNull.Value)
				{
					rectangleTool.AddLabelTool(dataRow12);
				}
				else
				{
					LabelTool labelTool = LabelTool.GetLabelTool(dataRow12);
					if (labelTool != null)
					{
						this.AddObject(drawingLayer, labelTool);
					}
				}
			}
			if (!this.Connected)
			{
				if (flag)
				{
					rectangleTool.Save(false, true);
					foreach (DrawObjectBase drawObjectBase8 in drawingLayer.Objects)
					{
						if (drawObjectBase8.GetType() == typeof(LineTool))
						{
							drawObjectBase8.Save(false, true);
						}
					}
				}
				IEnumerable<PointTool> values = this.loadedPoints.Values;
				if (CanvasControl.func_11 == null)
				{
					CanvasControl.func_11 = new Func<PointTool, bool>(CanvasControl.smethod_13);
				}
				foreach (PointTool pointTool9 in values.Where(CanvasControl.func_11))
				{
					NeedToPreserveEnum needToPreserve = pointTool9.NeedToPreserve;
					if (needToPreserve == NeedToPreserveEnum.InsertXML)
					{
						pointTool9.SaveXmlToSql();
					}
				}
			}
		}

		private void method_7()
		{
			if (this.list_4 != null)
			{
				this.list_4.Clear();
			}
			this.SendMessage("Начало очитски памяти", eMessageType.Information);
			this.loadedPoints.Clear();
			this.loadedPoints = new Dictionary<int, PointTool>();
			this.SendMessage("Почистили точки", eMessageType.Information);
			this.list_0.Clear();
			this.SendMessage("Почистили память", eMessageType.Information);
			this.dictionary_0.Clear();
			DrawingLayer drawingLayer = new DrawingLayer("SchemaMain", "SchemaMain", Color.White, 0f);
			drawingLayer.Parent = this;
			this.AddLayer(drawingLayer);
			this.ActiveLayer = drawingLayer;
			foreach (object obj in this.dataSetScheme_0.tSchm_ObjList.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				GroupDrawObjectBase groupDrawObjectBase = new GroupDrawObjectBase();
				groupDrawObjectBase.Id = Convert.ToInt32(dataRow["id"]);
				groupDrawObjectBase.Name = dataRow["Name"].ToString();
				this.dictionary_0.Add(groupDrawObjectBase.Id, groupDrawObjectBase);
			}
			lock (drawingLayer)
			{
				new XmlDocument();
				string text = "";
				foreach (object obj3 in Enum.GetValues(typeof(eTypeRectangleTool)))
				{
					eTypeRectangleTool eTypeRectangleTool = (eTypeRectangleTool)obj3;
					text = text + Convert.ToInt32(eTypeRectangleTool).ToString() + ",";
				}
				text = text.Remove(text.Length - 1);
				IEnumerable<DataRow> enumerable = this.dataSetScheme_0.vSchm_ObjListXml.Select("TypeCodeId in (" + text + ")");
				text = "";
				foreach (object obj4 in Enum.GetValues(typeof(eTypeShinaTool)))
				{
					eTypeShinaTool eTypeShinaTool = (eTypeShinaTool)obj4;
					text = text + Convert.ToInt32(eTypeShinaTool).ToString() + ",";
				}
				text = text.Remove(text.Length - 1);
				IEnumerable<DataRow> enumerable2 = this.dataSetScheme_0.vSchm_ObjListXml.Select(" TypeCodeId in (" + text + ")");
				text = "";
				foreach (object obj5 in Enum.GetValues(typeof(LineToolType)))
				{
					LineToolType lineToolType = (LineToolType)obj5;
					if (lineToolType == LineToolType.CellLine_10 || lineToolType == LineToolType.CellLine_6 || lineToolType == LineToolType.CellLine_04 || lineToolType == LineToolType.CellLine_023)
					{
						text = text + Convert.ToInt32(lineToolType).ToString() + ",";
					}
				}
				text = text.Remove(text.Length - 1);
				IEnumerable<DataRow> enumerable3 = this.dataSetScheme_0.vSchm_ObjListXml.Select("  TypeCodeId in (" + text + ")");
				text = "";
				foreach (object obj6 in Enum.GetValues(typeof(LineToolType)))
				{
					LineToolType lineToolType2 = (LineToolType)obj6;
					if (lineToolType2 != LineToolType.CellLine_10 && lineToolType2 != LineToolType.CellLine_6 && lineToolType2 != LineToolType.CellLine_04 && lineToolType2 != LineToolType.CellLine_023)
					{
						text = text + Convert.ToInt32(lineToolType2).ToString() + ",";
					}
				}
				text = text.Remove(text.Length - 1);
				IEnumerable<DataRow> enumerable4 = this.dataSetScheme_0.vSchm_ObjListXml.Select("TypeCodeId in (" + text + ")");
				int[] array = new int[]
				{
					556
				};
				DataTable journalData = PassportData.GetJournalData(this.sqlsettings_0, array);
				array = new int[]
				{
					546
				};
				DataTable journalData2 = PassportData.GetJournalData(this.sqlsettings_0, array);
				DataTable dataTable = new DataTable();
				SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
				string cmdText = "select obj.id as id, objChar.Value as lineLength from tSchm_ObjList as obj inner join\r\n                                            tP_Passport on obj.id=tP_Passport.idObjList inner join\r\n                                            tP_ObjectChar as objChar on tP_Passport.id=objChar.idPassport and objChar.idObjChar=182";
				SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
				try
				{
					sqlConnection.Open();
					dataTable.Load(sqlCommand.ExecuteReader());
				}
				catch
				{
				}
				Dictionary<int, DrawObjectBase> dictionary = new Dictionary<int, DrawObjectBase>();
				foreach (DataRow dataRow2 in enumerable)
				{
					try
					{
						RectangleTool rectangleTool = new RectangleTool(dataRow2, drawingLayer);
						rectangleTool.IsSubscriber = (this.dataSetScheme_0.vP_PassportDataReports.Select(string.Format("[IdObj] = {0}", rectangleTool.IdBase)).Length != 0);
						dictionary.Add(rectangleTool.IdBase, rectangleTool);
						rectangleTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
						if (dataRow2["idGroup"] != DBNull.Value)
						{
							int key = Convert.ToInt32(dataRow2["idGroup"]);
							if (this.dictionary_0.ContainsKey(key))
							{
								this.dictionary_0[key].Add(rectangleTool);
							}
						}
					}
					catch (Exception ex)
					{
						this.SendMessage(string.Concat(new string[]
						{
							"Не удалось загрузить подстанцию: id = ",
							dataRow2["id"].ToString(),
							" (",
							ex.Message,
							")"
						}), eMessageType.Error);
					}
				}
				this.SendMessage("Загружено подстанций: " + enumerable.Count<DataRow>(), eMessageType.Information);
				foreach (DataRow dataRow3 in enumerable2)
				{
					try
					{
						ShinaTool shinaTool = new ShinaTool(dataRow3, drawingLayer);
						shinaTool.Parent = dictionary[Convert.ToInt32(dataRow3["idParent"])];
						shinaTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
						int idBase = shinaTool.IdBase;
						if (dataRow3["idGroup"] != DBNull.Value)
						{
							int key2 = Convert.ToInt32(dataRow3["idGroup"]);
							if (this.dictionary_0.ContainsKey(key2))
							{
								this.dictionary_0[key2].Add(shinaTool);
							}
						}
						DataRow[] array2 = this.dataSetScheme_0.vSchm_ObjListXml.Select(" IdParent = " + shinaTool.IdBase.ToString() + " and typeCodeId = " + 111.ToString());
						foreach (DataRow dataRow_ in array2)
						{
							PointShinaTool pointShinaTool = new PointShinaTool(dataRow_);
							pointShinaTool.Layer = drawingLayer;
							shinaTool.AddPointShinaTool(pointShinaTool);
							this.loadedPoints.Add(pointShinaTool.IdBase, pointShinaTool);
						}
					}
					catch
					{
						this.SendMessage("Не удалось загрузить шину: id = " + dataRow3["id"].ToString(), eMessageType.Error);
					}
				}
				this.SendMessage("Загружено шин: " + enumerable2.Count<DataRow>(), eMessageType.Information);
				foreach (DataRow dataRow4 in enumerable3)
				{
					try
					{
						LineCellTool lineCellTool = new LineCellTool(dataRow4, drawingLayer);
						if (dictionary.ContainsKey(Convert.ToInt32(dataRow4["IdParent"])))
						{
							lineCellTool.Parent = dictionary[Convert.ToInt32(dataRow4["IdParent"])];
							lineCellTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
							if (dataRow4["idGroup"] != DBNull.Value)
							{
								int key3 = Convert.ToInt32(dataRow4["idGroup"]);
								if (this.dictionary_0.ContainsKey(key3))
								{
									this.dictionary_0[key3].Add(lineCellTool);
								}
							}
							foreach (Branch branch in lineCellTool.Branches)
							{
								foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
								{
									if (drawObjectBase.GetType() == typeof(TransformerTool))
									{
										TransformerTool transformerTool = (TransformerTool)drawObjectBase;
										DataRow[] array4 = journalData.Select("id = " + transformerTool.IdBase.ToString() + " and IdPassport is not null");
										if (array4.Length > 0)
										{
											transformerTool.passportDataRow = array4[0];
										}
									}
								}
							}
						}
					}
					catch
					{
						this.SendMessage("Не удалось загрузить ячейку: id = " + dataRow4["id"].ToString(), eMessageType.Error);
					}
				}
				this.SendMessage("Загружено ячеек: " + enumerable3.Count<DataRow>(), eMessageType.Information);
				foreach (DataRow dataRow5 in enumerable4)
				{
					try
					{
						LineTool lineTool = new LineTool(dataRow5, drawingLayer);
						lineTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
						if (lineTool.Branches.Count == 0)
						{
							lineTool.Remove(false, false);
							this.SendMessage(string.Concat(new string[]
							{
								"Линия ",
								lineTool.ToString(),
								"(id: ",
								lineTool.IdBase.ToString(),
								") вызвала ошибку при загрузке (не загружена ни одна ветка)"
							}), eMessageType.Error);
						}
						else
						{
							if (!lineTool.Validation())
							{
								this.SendMessage(lineTool, lineTool.ErrorString, eMessageType.Error);
							}
							if (dataRow5["idGroup"] != DBNull.Value)
							{
								int key4 = Convert.ToInt32(dataRow5["idGroup"]);
								if (this.dictionary_0.ContainsKey(key4))
								{
									this.dictionary_0[key4].Add(lineTool);
								}
							}
							foreach (Branch branch2 in lineTool.Branches)
							{
								foreach (DrawObjectBase drawObjectBase2 in branch2.ChildObjects)
								{
									if (drawObjectBase2.GetType() == typeof(TextBranchTool))
									{
										int idBase2 = lineTool.IdBase;
										string text2 = string.Empty;
										DataRow[] array5 = dataTable.Select("id=" + lineTool.IdBase.ToString());
										if (array5.Length > 0)
										{
											text2 = array5[0][1].ToString();
										}
										TextBranchTool textBranchTool = (TextBranchTool)drawObjectBase2;
										IEnumerable<DataRow> enumerable5 = this.dataSetScheme_0.vSchm_CabSection.Select("idObjList = " + lineTool.IdBase);
										if (enumerable5.Count<DataRow>() > 0)
										{
											decimal d = 0m;
											DataRow dataRow6 = null;
											decimal num = 0m;
											foreach (DataRow dataRow7 in enumerable5)
											{
												num += Convert.ToDecimal(dataRow7[8]);
												if (dataRow6 == null && Convert.ToDecimal(dataRow7[8]) >= 10m)
												{
													d = Convert.ToDecimal(dataRow7[7]);
													dataRow6 = dataRow7;
												}
												else if (Convert.ToDecimal(dataRow7[7]) < d && Convert.ToDecimal(dataRow7[8]) >= 10m)
												{
													d = Convert.ToDecimal(dataRow7[7]);
													dataRow6 = dataRow7;
												}
											}
											if (dataRow6 != null)
											{
												if (text2 == string.Empty)
												{
													text2 = Math.Round(Convert.ToDecimal(num), 0).ToString();
												}
												textBranchTool.UpdateSQLFields(dataRow6, text2);
											}
											DataRow[] array6 = journalData2.Select("id = " + lineTool.IdBase.ToString());
											if (array6.Length > 0)
											{
												textBranchTool.passportDataRow = array6[0];
											}
										}
									}
									else if (drawObjectBase2.GetType() == typeof(TransformerTool))
									{
										TransformerTool transformerTool2 = (TransformerTool)drawObjectBase2;
										DataRow[] array7 = journalData.Select("id = " + transformerTool2.IdBase.ToString());
										if (array7.Length > 0)
										{
											transformerTool2.passportDataRow = array7[0];
										}
									}
								}
							}
						}
					}
					catch (Exception)
					{
						this.SendMessage("Не удалось загрузить линию: id = " + dataRow5["id"].ToString(), eMessageType.Error);
					}
				}
				this.SendMessage("Загружено линий: " + enumerable4.Count<DataRow>(), eMessageType.Information);
				using (var enumerator = this.dataSetScheme_0.tSchm_Label.Rows.GetEnumerator())
				{
					Func<DrawObjectBase, bool> func = null;
					CanvasControl.Class16 @class = new CanvasControl.Class16();
					while (enumerator.MoveNext())
					{
						object obj7 = enumerator.Current;
						@class.dataRow_0 = (DataRow)obj7;
						if (@class.dataRow_0["IdParent"] != DBNull.Value)
						{
							if (dictionary.ContainsKey(Convert.ToInt32(@class.dataRow_0["idParent"])))
							{
								RectangleTool rectangleTool2 = (RectangleTool)dictionary[Convert.ToInt32(@class.dataRow_0["idParent"])];
								rectangleTool2.AddLabelTool(@class.dataRow_0);
							}
							else
							{
								LabelTool labelTool = LabelTool.GetLabelTool(@class.dataRow_0);
								if (labelTool != null)
								{
									IEnumerable<DrawObjectBase> objects = this.list_0[0].Objects;
									if (func == null)
									{
										func = new Func<DrawObjectBase, bool>(@class.method_0);
									}
									IEnumerable<DrawObjectBase> source = objects.Where(func);
									if (source.Count<DrawObjectBase>() > 0)
									{
										labelTool.Parent = source.First<DrawObjectBase>();
										this.AddObject(drawingLayer, labelTool);
									}
								}
							}
						}
						else
						{
							LabelTool labelTool2 = LabelTool.GetLabelTool(@class.dataRow_0);
							if (labelTool2 != null)
							{
								this.AddObject(drawingLayer, labelTool2);
							}
						}
					}
				}
				if (this.SimulationMode == eSimulationMode.Normal)
				{
					IEnumerable<DrawObjectBase> objects2 = this.icanvasLayer_0.Objects;
					if (CanvasControl.func_12 == null)
					{
						CanvasControl.func_12 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_14);
					}
					foreach (DrawObjectBase drawObjectBase3 in objects2.Where(CanvasControl.func_12))
					{
						((ObjectOnLine)drawObjectBase3).NormalSectionModeOn = true;
					}
				}
				this.OnSimulate();
				this.DoInvalidate(true);
			}
		}

		public void LoadSchemeFromXML(XmlDocument xmlDocument_1, bool useObjectsFromDB)
		{
			this.xmlDocument_0 = xmlDocument_1;
			this.undoRedoManager.SaveChanges = false;
			this.list_0.Clear();
			this.globalPointsList.Clear();
			XmlNode xmlNode = xmlDocument_1.SelectSingleNode("canvas");
			XmlNodeList xmlNodeList = xmlNode.SelectNodes("layer");
			XmlNode xmlNode2 = xmlNode.SelectSingleNode("points");
			Dictionary<int, object> dictionary = new Dictionary<int, object>();
			foreach (object obj in xmlNode2.ChildNodes)
			{
				XmlNode xmlNode3 = (XmlNode)obj;
				int key = Convert.ToInt32(xmlNode3.Attributes[0].Value);
				dictionary[key] = new UnitPoint((double)Convert.ToSingle(xmlNode3.Attributes[1].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode3.Attributes[2].Value, new CultureInfo(1033)));
			}
			foreach (object obj2 in xmlNodeList)
			{
				XmlNode xmlNode4 = (XmlNode)obj2;
				DrawingLayer drawingLayer = new DrawingLayer();
				drawingLayer.Id = xmlNode4.Attributes[0].Value;
				this.list_0.Add(drawingLayer);
				this.icanvasLayer_0 = drawingLayer;
				drawingLayer.Color = Color.White;
				drawingLayer.Parent = this;
				XmlNodeList xmlNodeList2 = xmlNode4.SelectNodes("Group");
				foreach (object obj3 in xmlNodeList2)
				{
					XmlNode xmlNode5 = (XmlNode)obj3;
					RectangleTool rectangleTool = new RectangleTool();
					rectangleTool.Rectangle = new RectangleF(Convert.ToSingle(xmlNode5.Attributes[1].Value, new CultureInfo(1033)), Convert.ToSingle(xmlNode5.Attributes[2].Value, new CultureInfo(1033)), Convert.ToSingle(xmlNode5.Attributes[3].Value, new CultureInfo(1033)), Convert.ToSingle(xmlNode5.Attributes[4].Value, new CultureInfo(1033)));
					rectangleTool.IdBase = Convert.ToInt32(xmlNode5.Attributes[0].Value);
					rectangleTool.Text = xmlNode5.Attributes[5].Value;
					rectangleTool.TextProperty.Visible = Convert.ToBoolean(xmlNode5.Attributes[6].Value);
					rectangleTool.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlNode5.Attributes[7].Value);
					string value = xmlNode5.Attributes[8].Value;
					if (value != "")
					{
						rectangleTool.Color = Color.FromArgb(Convert.ToInt32(value));
					}
					rectangleTool.TypeRectnagleTool = (eTypeRectangleTool)Convert.ToInt32(xmlNode5.Attributes[9].Value);
					rectangleTool.TextProperty.FontVirtical = Convert.ToBoolean(xmlNode5.Attributes[10].Value);
					rectangleTool.Visible = Convert.ToBoolean(xmlNode5.Attributes[11].Value);
					if (useObjectsFromDB)
					{
						if (rectangleTool.IdBase <= 0)
						{
							continue;
						}
						DataRow[] array = this.dataSetScheme_0.tSchm_ObjList.Select("id = " + rectangleTool.IdBase.ToString());
						if (array.Length == 0)
						{
							continue;
						}
						rectangleTool.Text = array[0]["Name"].ToString();
						rectangleTool.TypeRectnagleTool = (eTypeRectangleTool)Convert.ToInt32(array[0]["TypeCodeId"]);
					}
					drawingLayer.AddObject(rectangleTool);
					rectangleTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
					XmlNodeList xmlNodeList3 = xmlNode5.SelectNodes("Shina");
					foreach (object obj4 in xmlNodeList3)
					{
						XmlNode xmlNode6 = (XmlNode)obj4;
						ShinaTool shinaTool = new ShinaTool();
						shinaTool.P1 = new UnitPoint((double)Convert.ToSingle(xmlNode6.Attributes[1].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode6.Attributes[2].Value, new CultureInfo(1033)));
						shinaTool.P2 = new UnitPoint((double)Convert.ToSingle(xmlNode6.Attributes[3].Value, new CultureInfo(1033)), (double)Convert.ToSingle(xmlNode6.Attributes[4].Value, new CultureInfo(1033)));
						shinaTool.IdBase = Convert.ToInt32(xmlNode6.Attributes[0].Value);
						shinaTool.Text = xmlNode6.Attributes[5].Value;
						shinaTool.TextProperty.Visible = Convert.ToBoolean(xmlNode6.Attributes[6].Value);
						shinaTool.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlNode6.Attributes[7].Value);
						string value2 = xmlNode6.Attributes[8].Value;
						if (value2 != "")
						{
							shinaTool.UseSettingColor = false;
							shinaTool.Color = Color.FromArgb(Convert.ToInt32(value2));
						}
						if (xmlNode6.Attributes.Count >= 10)
						{
							shinaTool.TypeShinaTool = (eTypeShinaTool)Convert.ToInt32(xmlNode6.Attributes[9].Value);
						}
						if (xmlNode6.Attributes.Count >= 11)
						{
							shinaTool.TextVoltProperty.Visible = Convert.ToBoolean(xmlNode6.Attributes[10].Value);
						}
						if (xmlNode6.Attributes.Count >= 12)
						{
							shinaTool.TextVoltProperty.Position = (ePositionText)Convert.ToInt32(xmlNode6.Attributes[11].Value);
						}
						shinaTool.Parent = rectangleTool;
						if (useObjectsFromDB)
						{
							if (shinaTool.IdBase <= 0)
							{
								continue;
							}
							DataRow[] array2 = this.dataSetScheme_0.tSchm_ObjList.Select("id = " + shinaTool.IdBase.ToString());
							if (array2.Length == 0)
							{
								continue;
							}
							shinaTool.Text = array2[0]["Name"].ToString();
							shinaTool.TypeShinaTool = (eTypeShinaTool)Convert.ToInt32(array2[0]["TypeCodeId"]);
						}
						drawingLayer.AddObject(shinaTool);
						shinaTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
						XmlNodeList xmlNodeList4 = xmlNode6.SelectNodes("point");
						foreach (object obj5 in xmlNodeList4)
						{
							XmlNode xmlNode7 = (XmlNode)obj5;
							if (xmlNode7.Attributes[0].Value != "")
							{
								int num = Convert.ToInt32(xmlNode7.Attributes[0].Value);
								if (num < dictionary.Count && dictionary[num].GetType() == typeof(UnitPoint))
								{
									dictionary[num] = shinaTool.AddPointShinaTool((UnitPoint)dictionary[num]);
								}
							}
						}
					}
					XmlNodeList xmlNodeList5 = xmlNode5.SelectNodes("Cell");
					foreach (object obj6 in xmlNodeList5)
					{
						XmlNode xmlNode8 = (XmlNode)obj6;
						LineCellTool lineCellTool = new LineCellTool();
						drawingLayer.AddObject(lineCellTool);
						lineCellTool.Parent = rectangleTool;
						lineCellTool.IdBase = Convert.ToInt32(xmlNode8.Attributes[0].Value);
						lineCellTool.Text = xmlNode8.Attributes[1].Value;
						lineCellTool.TextProperty.Visible = Convert.ToBoolean(xmlNode8.Attributes[2].Value);
						lineCellTool.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlNode8.Attributes[3].Value);
						string value3 = xmlNode8.Attributes[4].Value;
						if (value3 != "")
						{
							lineCellTool.UseSettingColor = false;
							lineCellTool.Color = Color.FromName(value3);
						}
						if (useObjectsFromDB)
						{
							if (lineCellTool.IdBase <= 0)
							{
								continue;
							}
							DataRow[] array3 = this.dataSetScheme_0.tSchm_ObjList.Select("id = " + lineCellTool.IdBase.ToString());
							if (array3.Length == 0)
							{
								continue;
							}
							lineCellTool.Text = array3[0]["Name"].ToString();
						}
						lineCellTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
						XmlNodeList xmlNodeList6 = xmlNode8.SelectNodes("Branch");
						foreach (object obj7 in xmlNodeList6)
						{
							XmlNode xmlNode9 = (XmlNode)obj7;
							int key2 = Convert.ToInt32(xmlNode9.Attributes[2].Value);
							if (dictionary[key2].GetType() == typeof(UnitPoint))
							{
								dictionary[key2] = new PointTool((UnitPoint)dictionary[key2]);
							}
							PointTool pointTool_ = (PointTool)dictionary[key2];
							key2 = Convert.ToInt32(xmlNode9.Attributes[3].Value);
							if (dictionary[key2].GetType() == typeof(UnitPoint))
							{
								dictionary[key2] = new PointTool((UnitPoint)dictionary[key2]);
							}
							PointTool dest = (PointTool)dictionary[key2];
							Branch branch = lineCellTool.AddBranch(pointTool_, dest);
							XmlNodeList xmlNodeList7 = xmlNode9.SelectNodes("Switch");
							foreach (object obj8 in xmlNodeList7)
							{
								XmlNode xmlNode10 = (XmlNode)obj8;
								if (useObjectsFromDB)
								{
									DataRow[] array4 = this.dataSetScheme_0.tSchm_ObjList.Select("id = " + Convert.ToInt32(xmlNode10.Attributes[0].Value));
									if (array4.Length == 0)
									{
										continue;
									}
								}
								ObjectOnLine objectOnLine = branch.AddSwitchTool((TypeSwitch)Convert.ToInt32(xmlNode10.Attributes[2].Value), (double)Convert.ToSingle(xmlNode10.Attributes[1].Value, new CultureInfo(1033)));
								objectOnLine.IdBase = Convert.ToInt32(xmlNode10.Attributes[0].Value);
								objectOnLine.On = Convert.ToBoolean(xmlNode10.Attributes[3].Value);
								objectOnLine.Text = xmlNode10.Attributes[4].Value;
								objectOnLine.TextProperty.Visible = Convert.ToBoolean(xmlNode10.Attributes[5].Value);
								objectOnLine.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlNode10.Attributes[6].Value);
								objectOnLine.GorMirror = Convert.ToBoolean(xmlNode10.Attributes[7].Value);
								objectOnLine.VertMirror = Convert.ToBoolean(xmlNode10.Attributes[8].Value);
								drawingLayer.AddObject(objectOnLine);
							}
							XmlNodeList xmlNodeList8 = xmlNode9.SelectNodes("TextBranch");
							foreach (object obj9 in xmlNodeList8)
							{
								XmlNode xmlNode11 = (XmlNode)obj9;
								drawingLayer.AddObject(new TextBranchTool
								{
									Parent = branch,
									Layer = drawingLayer,
									IdBase = Convert.ToInt32(xmlNode11.Attributes[0].Value),
									Text = xmlNode11.Attributes[1].Value,
									Direct = Convert.ToBoolean(xmlNode11.Attributes[2].Value),
									TextProperty = 
									{
										Position = (ePositionText)Convert.ToInt32(xmlNode11.Attributes[3].Value)
									},
									Delta = Convert.ToSingle(xmlNode11.Attributes[4].Value, new CultureInfo(1033))
								});
							}
						}
						if (lineCellTool.TextProperty.Visible)
						{
							string value4 = xmlNode8.Attributes[5].Value;
							if (value4 != "")
							{
								int key3 = Convert.ToInt32(value4);
								if (dictionary[key3].GetType() == typeof(PointTool) || dictionary[key3].GetType().BaseType == typeof(PointTool))
								{
									((PointTool)dictionary[key3]).TextProperty.Visible = true;
									((PointTool)dictionary[key3]).Text = lineCellTool.Text;
									((PointTool)dictionary[key3]).TextProperty.Position = lineCellTool.TextProperty.Position;
									lineCellTool.TextProperty.Visible = true;
								}
							}
						}
					}
				}
				XmlNodeList xmlNodeList9 = xmlNode4.SelectNodes("Line");
				foreach (object obj10 in xmlNodeList9)
				{
					XmlNode xmlNode12 = (XmlNode)obj10;
					LineTool lineTool = new LineTool();
					lineTool.IdBase = Convert.ToInt32(xmlNode12.Attributes[0].Value);
					lineTool.Text = xmlNode12.Attributes[1].Value;
					lineTool.TextProperty.Visible = Convert.ToBoolean(xmlNode12.Attributes[2].Value);
					lineTool.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlNode12.Attributes[3].Value);
					string value5 = xmlNode12.Attributes[4].Value;
					if (value5 != "")
					{
						lineTool.UseSettingColor = false;
						lineTool.Color = Color.FromName(value5);
					}
					if (useObjectsFromDB)
					{
						DataRow[] array5 = this.dataSetScheme_0.tSchm_ObjList.Select("id = " + lineTool.IdBase.ToString());
						if (array5.Length == 0)
						{
							continue;
						}
						lineTool.Text = array5[0]["Name"].ToString();
					}
					drawingLayer.AddObject(lineTool);
					lineTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
					lineTool.DrawNewObjectEvent += this.drawObjectBase_0_DrawNewObjectEvent;
					XmlNodeList xmlNodeList10 = xmlNode12.SelectNodes("Branch");
					foreach (object obj11 in xmlNodeList10)
					{
						XmlNode xmlNode13 = (XmlNode)obj11;
						int key4 = Convert.ToInt32(xmlNode13.Attributes[2].Value);
						if (dictionary[key4].GetType() == typeof(UnitPoint))
						{
							dictionary[key4] = new PointTool((UnitPoint)dictionary[key4]);
						}
						PointTool pointTool_2 = (PointTool)dictionary[key4];
						key4 = Convert.ToInt32(xmlNode13.Attributes[3].Value);
						if (dictionary[key4].GetType() == typeof(UnitPoint))
						{
							dictionary[key4] = new PointTool((UnitPoint)dictionary[key4]);
						}
						PointTool dest2 = (PointTool)dictionary[key4];
						BranchType type = (BranchType)Convert.ToInt32(xmlNode13.Attributes[1].Value);
						Branch branch2 = lineTool.AddBranch(pointTool_2, dest2, type);
						XmlNodeList xmlNodeList11 = xmlNode13.SelectNodes("Switch");
						foreach (object obj12 in xmlNodeList11)
						{
							XmlNode xmlNode14 = (XmlNode)obj12;
							if (useObjectsFromDB)
							{
								DataRow[] array6 = this.dataSetScheme_0.tSchm_ObjList.Select("id = " + Convert.ToInt32(xmlNode14.Attributes[0].Value));
								if (array6.Length == 0)
								{
									continue;
								}
							}
							ObjectOnLine objectOnLine2 = branch2.AddSwitchTool((TypeSwitch)Convert.ToInt32(xmlNode14.Attributes[2].Value), (double)Convert.ToSingle(xmlNode14.Attributes[1].Value, new CultureInfo(1033)));
							objectOnLine2.IdBase = Convert.ToInt32(xmlNode14.Attributes[0].Value);
							objectOnLine2.On = Convert.ToBoolean(xmlNode14.Attributes[3].Value);
							objectOnLine2.Text = xmlNode14.Attributes[4].Value;
							objectOnLine2.TextProperty.Visible = Convert.ToBoolean(xmlNode14.Attributes[5].Value);
							objectOnLine2.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlNode14.Attributes[6].Value);
							objectOnLine2.GorMirror = Convert.ToBoolean(xmlNode14.Attributes[7].Value);
							objectOnLine2.VertMirror = Convert.ToBoolean(xmlNode14.Attributes[8].Value);
							drawingLayer.AddObject(objectOnLine2);
						}
						XmlNodeList xmlNodeList12 = xmlNode13.SelectNodes("TextBranch");
						foreach (object obj13 in xmlNodeList12)
						{
							XmlNode xmlNode15 = (XmlNode)obj13;
							drawingLayer.AddObject(new TextBranchTool
							{
								Parent = branch2,
								Layer = drawingLayer,
								IdBase = Convert.ToInt32(xmlNode15.Attributes[0].Value),
								Text = xmlNode15.Attributes[1].Value,
								Direct = Convert.ToBoolean(xmlNode15.Attributes[2].Value),
								TextProperty = 
								{
									Position = (ePositionText)Convert.ToInt32(xmlNode15.Attributes[3].Value)
								},
								Delta = Convert.ToSingle(xmlNode15.Attributes[4].Value)
							});
						}
					}
				}
			}
			this.undoRedoManager.SaveChanges = true;
			this.DoInvalidate(true);
		}

		private void method_8()
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			eTypeCanvas typeCanvas = this.TypeCanvas;
			if (typeCanvas == eTypeCanvas.SchemeMain)
			{
				sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.vSchm_ObjListXml, false, " where TypeSchema = " + (int)this.TypeCanvas);
			}
			List<int> list = new List<int>();
			List<DrawObjectBase> list2 = new List<DrawObjectBase>();
			List<int> list3 = new List<int>();
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
				{
					list2.Add(drawObjectBase);
					if (drawObjectBase.GetType() == typeof(LineCellTool) || drawObjectBase.GetType() == typeof(LineTool))
					{
						List<PointTool> pointsList = ((LineTool)drawObjectBase).GetPointsList();
						foreach (PointTool pointTool in pointsList)
						{
							if (pointTool.IdBase > 0)
							{
								list3.Add(pointTool.IdBase);
							}
						}
					}
				}
			}
			int num = 0;
			using (IEnumerator enumerator4 = this.dataSetScheme_0.vSchm_ObjListXml.Rows.GetEnumerator())
			{
				Func<DrawObjectBase, bool> func = null;
				CanvasControl.Class17 @class = new CanvasControl.Class17();
				while (enumerator4.MoveNext())
				{
					object obj = enumerator4.Current;
					@class.dataRow_0 = (DataRow)obj;
					if (Convert.ToInt32(@class.dataRow_0["TypeCodeId"]) != 111)
					{
						IEnumerable<DrawObjectBase> source = list2;
						if (func == null)
						{
							func = new Func<DrawObjectBase, bool>(@class.method_0);
						}
						IEnumerable<DrawObjectBase> source2 = source.Where(func);
						if (source2.Count<DrawObjectBase>() == 0)
						{
							list.Add(Convert.ToInt32(@class.dataRow_0["id"]));
						}
					}
					else if (!list3.Contains(Convert.ToInt32(@class.dataRow_0["id"])))
					{
						list.Add(Convert.ToInt32(@class.dataRow_0["id"]));
					}
					num++;
				}
			}
			foreach (int id in list)
			{
				sqlDataCommand.DeleteSqlDataById(this.dataSetScheme_0.tSchm_ObjList, id);
			}
		}

		public void LoadTransferObjects(List<ObjectBaseServer> points, List<ObjectBaseServer> transferObjs, List<ObjectOnLineServer> objsOnLine)
		{
			this.ClearLayers();
			DrawingLayer drawingLayer = new DrawingLayer("SchemaMain", "SchemaMain", Color.White, 0f);
			drawingLayer.Parent = this;
			this.AddLayer(drawingLayer);
			this.ActiveLayer = drawingLayer;
			this.loadedPoints.Clear();
			if (CanvasControl.func_13 == null)
			{
				CanvasControl.func_13 = new Func<ObjectBaseServer, bool>(CanvasControl.smethod_15);
			}
			IEnumerable<ObjectBaseServer> enumerable = transferObjs.Where(CanvasControl.func_13);
			foreach (ObjectBaseServer objectBaseServer in enumerable)
			{
				drawingLayer.AddObject(new RectangleTool
				{
					Rectangle = new RectangleF(objectBaseServer.ListPoints[0].Point.X, objectBaseServer.ListPoints[0].Point.Y, objectBaseServer.ListPoints[1].Point.X - objectBaseServer.ListPoints[0].Point.X, objectBaseServer.ListPoints[1].Point.Y - objectBaseServer.ListPoints[0].Point.Y),
					IdBase = objectBaseServer.Id,
					TypeRectnagleTool = objectBaseServer.TypeRectangle
				});
			}
			if (CanvasControl.func_14 == null)
			{
				CanvasControl.func_14 = new Func<ObjectBaseServer, bool>(CanvasControl.smethod_16);
			}
			IEnumerable<ObjectBaseServer> enumerable2 = transferObjs.Where(CanvasControl.func_14);
			using (IEnumerator<ObjectBaseServer> enumerator = enumerable2.GetEnumerator())
			{
				Func<DrawObjectBase, bool> func = null;
				Func<ObjectBaseServer, bool> func2 = null;
				CanvasControl.Class18 @class = new CanvasControl.Class18();
				while (enumerator.MoveNext())
				{
					ObjectBaseServer objectBaseServer_ = enumerator.Current;
					@class.objectBaseServer_0 = objectBaseServer_;
					ShinaTool shinaTool = new ShinaTool();
					shinaTool.P1 = @class.objectBaseServer_0.ListPoints[0];
					shinaTool.P2 = @class.objectBaseServer_0.ListPoints[1];
					shinaTool.TypeShinaTool = @class.objectBaseServer_0.TypeShina;
					IEnumerable<DrawObjectBase> objects = drawingLayer.Objects;
					if (func == null)
					{
						func = new Func<DrawObjectBase, bool>(@class.method_0);
					}
					IEnumerable<DrawObjectBase> source = objects.Where(func);
					if (source.Count<DrawObjectBase>() > 0)
					{
						shinaTool.Parent = source.First<DrawObjectBase>();
					}
					drawingLayer.AddObject(shinaTool);
					if (func2 == null)
					{
						func2 = new Func<ObjectBaseServer, bool>(@class.method_1);
					}
					IEnumerable<ObjectBaseServer> enumerable3 = points.Where(func2);
					foreach (ObjectBaseServer objectBaseServer2 in enumerable3)
					{
						if (this.loadedPoints.ContainsKey(objectBaseServer2.Id))
						{
							PointTool pointTool = this.loadedPoints[objectBaseServer2.Id];
						}
						else
						{
							PointTool pointTool = shinaTool.AddPointShinaTool(new PointShinaTool
							{
								IdBase = objectBaseServer2.Id,
								Point = objectBaseServer2.ListPoints[0],
								Layer = drawingLayer
							});
							this.loadedPoints.Add(pointTool.IdBase, pointTool);
						}
					}
				}
			}
			foreach (ObjectBaseServer objectBaseServer3 in points)
			{
				if (!this.loadedPoints.ContainsKey(objectBaseServer3.Id))
				{
					PointTool pointTool2 = new PointTool();
					pointTool2.IdBase = objectBaseServer3.Id;
					pointTool2.Point = objectBaseServer3.ListPoints[0];
					pointTool2.Layer = drawingLayer;
					this.loadedPoints.Add(pointTool2.IdBase, pointTool2);
				}
			}
			Dictionary<int, ObjectBaseServer> dictionary = new Dictionary<int, ObjectBaseServer>();
			if (CanvasControl.func_15 == null)
			{
				CanvasControl.func_15 = new Func<ObjectBaseServer, bool>(CanvasControl.smethod_17);
			}
			foreach (ObjectBaseServer objectBaseServer4 in transferObjs.Where(CanvasControl.func_15))
			{
				dictionary.Add(objectBaseServer4.Id, objectBaseServer4);
			}
			if (CanvasControl.func_16 == null)
			{
				CanvasControl.func_16 = new Func<ObjectBaseServer, bool>(CanvasControl.smethod_18);
			}
			IEnumerable<ObjectBaseServer> enumerable4 = transferObjs.Where(CanvasControl.func_16);
			using (IEnumerator<ObjectBaseServer> enumerator = enumerable4.GetEnumerator())
			{
				Func<DrawObjectBase, bool> func3 = null;
				CanvasControl.Class19 class2 = new CanvasControl.Class19();
				while (enumerator.MoveNext())
				{
					ObjectBaseServer objectBaseServer_2 = enumerator.Current;
					class2.objectBaseServer_0 = objectBaseServer_2;
					LineCellTool lineCellTool = new LineCellTool();
					drawingLayer.AddObject(lineCellTool);
					List<PointTool> list = new List<PointTool>();
					foreach (PointServerTool pointServerTool in class2.objectBaseServer_0.ListPointsTool)
					{
						if (this.loadedPoints.ContainsKey(pointServerTool.Id))
						{
							list.Add(this.loadedPoints[pointServerTool.Id]);
						}
						else
						{
							list.Add(new PointTool(pointServerTool.Point)
							{
								IdBase = pointServerTool.Id,
								Layer = drawingLayer
							});
						}
					}
					foreach (RelationServer relationServer in class2.objectBaseServer_0.Relations)
					{
						PointTool vertex = this.loadedPoints[relationServer.SourcePoint];
						PointTool vertex2 = this.loadedPoints[relationServer.DestenationPoint];
						CouplingRelation couplingRelation = new CouplingRelation(vertex, vertex2);
						couplingRelation.Id = relationServer.int_0;
						couplingRelation.Line = lineCellTool;
						lineCellTool.CouplingRelations.Add(couplingRelation);
					}
					using (List<BranchServer>.Enumerator enumerator6 = class2.objectBaseServer_0.Branches.GetEnumerator())
					{
						Func<CouplingRelation, bool> func4 = null;
						CanvasControl.Class20 class3 = new CanvasControl.Class20();
						class3.class19_0 = class2;
						while (enumerator6.MoveNext())
						{
							BranchServer branchServer_ = enumerator6.Current;
							class3.branchServer_0 = branchServer_;
							IEnumerable<CouplingRelation> couplingRelations = lineCellTool.CouplingRelations;
							if (func4 == null)
							{
								func4 = new Func<CouplingRelation, bool>(class3.method_0);
							}
							CouplingRelation couplingRelation2 = couplingRelations.Single(func4);
							PointTool pointTool_ = list[class3.branchServer_0.SourcePoint];
							PointTool dest = list[class3.branchServer_0.DestenationPoint];
							Branch branch = new Branch(lineCellTool, pointTool_, dest, class3.branchServer_0.type, couplingRelation2);
							lineCellTool.Branches.Add(branch);
							branch.Parent = lineCellTool;
							foreach (int key in class3.branchServer_0.childObjects)
							{
								if (dictionary.ContainsKey(key))
								{
									ObjectBaseServer objectBaseServer5 = dictionary[key];
									ObjectOnLine objectOnLine = ObjectOnLine.CreateObjectOnLine(objectBaseServer5.TypeObjectOnLine);
									objectOnLine.IdBase = objectBaseServer5.Id;
									branch.AddSwitchTool(objectOnLine);
									objectOnLine.Delta = (double)objectBaseServer5.Delta;
									objectOnLine.On = objectBaseServer5.On;
									objectOnLine.RecalcAngle();
									objectOnLine.GorMirror = objectBaseServer5.GorMirror;
									objectOnLine.VertMirror = objectBaseServer5.VertMirror;
									drawingLayer.AddObject(objectOnLine);
								}
							}
							if (class3.branchServer_0.States != null)
							{
								foreach (LineStateServer stateNode in class3.branchServer_0.States)
								{
									LineToolState state = new LineToolState(branch, stateNode);
									lineCellTool.AddState(state);
								}
							}
						}
					}
					lineCellTool.GetPointsList();
					IEnumerable<DrawObjectBase> objects2 = drawingLayer.Objects;
					if (func3 == null)
					{
						func3 = new Func<DrawObjectBase, bool>(class2.method_0);
					}
					IEnumerable<DrawObjectBase> source2 = objects2.Where(func3);
					if (source2.Count<DrawObjectBase>() > 0)
					{
						lineCellTool.Parent = source2.First<DrawObjectBase>();
					}
					foreach (PointTool pointTool3 in lineCellTool.Ends)
					{
						if (pointTool3.Parent == null)
						{
							pointTool3.Parent = lineCellTool;
						}
					}
					lineCellTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
				}
			}
			if (CanvasControl.func_17 == null)
			{
				CanvasControl.func_17 = new Func<ObjectBaseServer, bool>(CanvasControl.smethod_19);
			}
			IEnumerable<ObjectBaseServer> enumerable5 = transferObjs.Where(CanvasControl.func_17);
			foreach (ObjectBaseServer objectBaseServer6 in enumerable5)
			{
				LineTool lineTool = new LineTool();
				drawingLayer.AddObject(lineTool);
				List<PointTool> list2 = new List<PointTool>();
				foreach (PointServerTool pointServerTool2 in objectBaseServer6.ListPointsTool)
				{
					if (this.loadedPoints.ContainsKey(pointServerTool2.Id))
					{
						list2.Add(this.loadedPoints[pointServerTool2.Id]);
					}
					else
					{
						list2.Add(new PointTool(pointServerTool2.Point)
						{
							IdBase = pointServerTool2.Id,
							Layer = drawingLayer
						});
					}
				}
				foreach (RelationServer relationServer2 in objectBaseServer6.Relations)
				{
					PointTool vertex3 = this.loadedPoints[relationServer2.SourcePoint];
					PointTool vertex4 = this.loadedPoints[relationServer2.DestenationPoint];
					CouplingRelation couplingRelation3 = new CouplingRelation(vertex3, vertex4);
					couplingRelation3.Id = relationServer2.int_0;
					couplingRelation3.Line = lineTool;
					lineTool.CouplingRelations.Add(couplingRelation3);
				}
				using (List<BranchServer>.Enumerator enumerator6 = objectBaseServer6.Branches.GetEnumerator())
				{
					Func<CouplingRelation, bool> func5 = null;
					CanvasControl.Class21 class4 = new CanvasControl.Class21();
					while (enumerator6.MoveNext())
					{
						BranchServer branchServer_2 = enumerator6.Current;
						class4.branchServer_0 = branchServer_2;
						IEnumerable<CouplingRelation> couplingRelations2 = lineTool.CouplingRelations;
						if (func5 == null)
						{
							func5 = new Func<CouplingRelation, bool>(class4.method_0);
						}
						CouplingRelation couplingRelation4 = couplingRelations2.Single(func5);
						PointTool pointTool_2 = list2[class4.branchServer_0.SourcePoint];
						PointTool dest2 = list2[class4.branchServer_0.DestenationPoint];
						Branch branch2 = new Branch(lineTool, pointTool_2, dest2, class4.branchServer_0.type, couplingRelation4);
						lineTool.Branches.Add(branch2);
						branch2.Parent = lineTool;
						foreach (int key2 in class4.branchServer_0.childObjects)
						{
							if (dictionary.ContainsKey(key2))
							{
								ObjectBaseServer objectBaseServer7 = dictionary[key2];
								ObjectOnLine objectOnLine2 = ObjectOnLine.CreateObjectOnLine(objectBaseServer7.TypeObjectOnLine);
								objectOnLine2.IdBase = objectBaseServer7.Id;
								branch2.AddSwitchTool(objectOnLine2);
								objectOnLine2.Delta = (double)objectBaseServer7.Delta;
								objectOnLine2.On = objectBaseServer7.On;
								objectOnLine2.RecalcAngle();
								objectOnLine2.GorMirror = objectBaseServer7.GorMirror;
								objectOnLine2.VertMirror = objectBaseServer7.VertMirror;
								drawingLayer.AddObject(objectOnLine2);
							}
						}
						if (class4.branchServer_0.States != null)
						{
							foreach (LineStateServer stateNode2 in class4.branchServer_0.States)
							{
								LineToolState state2 = new LineToolState(branch2, stateNode2);
								lineTool.AddState(state2);
							}
						}
					}
				}
				lineTool.GetPointsList();
				lineTool.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
			}
			IEnumerable<DrawObjectBase> objects3 = drawingLayer.Objects;
			if (CanvasControl.func_18 == null)
			{
				CanvasControl.func_18 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_20);
			}
			IEnumerable<DrawObjectBase> enumerable6 = objects3.Where(CanvasControl.func_18);
			foreach (DrawObjectBase drawObjectBase in enumerable6)
			{
				IEnumerable<DrawObjectBase> childObjects = drawObjectBase.ChildObjects;
				if (CanvasControl.func_19 == null)
				{
					CanvasControl.func_19 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_21);
				}
				IEnumerable<DrawObjectBase> enumerable7 = childObjects.Where(CanvasControl.func_19);
				foreach (DrawObjectBase drawObjectBase2 in enumerable7)
				{
					((ShinaTool)drawObjectBase2).OnAmperage = true;
				}
			}
		}

		public OPCClient OpcClient
		{
			get
			{
				return this.opcclient_0;
			}
			set
			{
				if (this.opcclient_0 != null)
				{
					this.opcclient_0.OnSocketEvent -= new DelegateSocketEventMethod(this.method_13);
					this.opcclient_0.OnGetEvent -= new DelegateOPCClientGetEvent(this.method_12);
					this.opcclient_0.OnGetItem -= new DelegateOPCClientGetEvents(this.method_10);
				}
				this.opcclient_0 = value;
				if (this.opcclient_0 != null)
				{
					this.opcclient_0.OnSocketEvent += new DelegateSocketEventMethod(this.method_13);
					this.opcclient_0.OnGetEvent += new DelegateOPCClientGetEvent(this.method_12);
					this.opcclient_0.OnGetItem += new DelegateOPCClientGetEvents(this.method_10);
				}
			}
		}

		private void method_9()
		{
		}

		private void method_10(List<OPCMessage> list_9)
		{
			IEnumerable<DrawObjectBase> enumerable = null;
			IEnumerable<DrawObjectBase> enumerable2 = null;
			if (this.list_0.Count > 0)
			{
				IEnumerable<DrawObjectBase> objects = this.list_0[0].Objects;
				if (CanvasControl.func_20 == null)
				{
					CanvasControl.func_20 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_22);
				}
				enumerable2 = objects.Where(CanvasControl.func_20);
				IEnumerable<DrawObjectBase> objects2 = this.list_0[0].Objects;
				if (CanvasControl.func_21 == null)
				{
					CanvasControl.func_21 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_23);
				}
				enumerable = objects2.Where(CanvasControl.func_21);
				using (List<OPCMessage>.Enumerator enumerator = list_9.GetEnumerator())
				{
					Func<DrawObjectBase, bool> func = null;
					Func<DrawObjectBase, bool> func2 = null;
					CanvasControl.Class22 @class = new CanvasControl.Class22();
					while (enumerator.MoveNext())
					{
						OPCMessage opcmessage_ = enumerator.Current;
						@class.opcmessage_0 = opcmessage_;
						if (@class.opcmessage_0.ObjectId > 0 && this.list_0.Count > 0)
						{
							IEnumerable<DrawObjectBase> source = enumerable;
							if (func == null)
							{
								func = new Func<DrawObjectBase, bool>(@class.method_0);
							}
							IEnumerable<DrawObjectBase> source2 = source.Where(func);
							if (source2.Count<DrawObjectBase>() > 0)
							{
								source2.First<DrawObjectBase>();
							}
							IEnumerable<DrawObjectBase> source3 = enumerable2;
							if (func2 == null)
							{
								func2 = new Func<DrawObjectBase, bool>(@class.method_1);
							}
							IEnumerable<DrawObjectBase> enumerable3 = source3.Where(func2);
							foreach (DrawObjectBase drawObjectBase in enumerable3)
							{
								if (drawObjectBase.GetType() == typeof(TelemetryLabelTool))
								{
									((TelemetryLabelTool)drawObjectBase).OPCMessage = @class.opcmessage_0;
								}
							}
						}
					}
				}
				this.DoInvalidate(true);
			}
		}

		private void method_11(DrawObjectBase drawObjectBase_2, OPCMessage opcmessage_0)
		{
			TelemetryValues telemetryValues = (drawObjectBase_2 != null) ? drawObjectBase_2.TelemetryValues : TelemetryValues.Empty;
			PropertyInfo property = telemetryValues.GetType().GetProperty(opcmessage_0.ParameterName);
			if (property == null)
			{
				return;
			}
			if (property.PropertyType == typeof(float))
			{
				float num = Convert.ToSingle(opcmessage_0.Value, new CultureInfo(1033));
				opcmessage_0.Message = num.ToString();
				if (drawObjectBase_2 != null)
				{
					telemetryValues = drawObjectBase_2.TelemetryValues;
					object obj = telemetryValues;
					property.SetValue(obj, num, null);
					drawObjectBase_2.TelemetryValues = (TelemetryValues)obj;
				}
			}
			int num2;
			if (property.PropertyType == typeof(bool?) && opcmessage_0.ZeroNormalState <= 0 && int.TryParse(opcmessage_0.Value, out num2))
			{
				bool flag = true;
				if (opcmessage_0.ZeroNormalState == 0)
				{
					opcmessage_0.Message = ((num2 != 0) ? opcmessage_0.StateNormName : opcmessage_0.StateAbnormName);
					if (num2 == 0)
					{
						flag = false;
					}
				}
				else
				{
					opcmessage_0.Message = ((num2 == 0) ? opcmessage_0.StateNormName : opcmessage_0.StateAbnormName);
					if (num2 != 0)
					{
						flag = false;
					}
				}
				if (drawObjectBase_2 != null)
				{
					telemetryValues = drawObjectBase_2.TelemetryValues;
					object obj2 = telemetryValues;
					property.SetValue(obj2, flag, null);
					drawObjectBase_2.TelemetryValues = (TelemetryValues)obj2;
				}
			}
		}

		private void method_12(OPCMessage opcmessage_0)
		{
			Func<DrawObjectBase, bool> func = null;
			CanvasControl.Class23 @class = new CanvasControl.Class23();
			@class.opcmessage_0 = opcmessage_0;
			if (@class.opcmessage_0.ObjectId > 0 && this.list_0.Count > 0)
			{
				IEnumerable<DrawObjectBase> objects = this.list_0[0].Objects;
				if (CanvasControl.func_22 == null)
				{
					CanvasControl.func_22 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_24);
				}
				IEnumerable<DrawObjectBase> enumerable = objects.Where(CanvasControl.func_22);
				IEnumerable<DrawObjectBase> source = enumerable;
				if (func == null)
				{
					func = new Func<DrawObjectBase, bool>(@class.method_0);
				}
				IEnumerable<DrawObjectBase> enumerable2 = source.Where(func);
				foreach (DrawObjectBase drawObjectBase in enumerable2)
				{
					if (drawObjectBase.GetType() == typeof(TelemetryLabelTool))
					{
						((TelemetryLabelTool)drawObjectBase).OPCMessage = @class.opcmessage_0;
					}
				}
			}
		}

		private void method_13(SocketEventTypeEnum socketEventTypeEnum_0, object object_0)
		{
			CanvasControl.AsyncAction asyncAction = null;
			CanvasControl.AsyncAction asyncAction2 = null;
			CanvasControl.AsyncAction asyncAction3 = null;
			CanvasControl.AsyncAction asyncAction4 = null;
			switch (socketEventTypeEnum_0)
			{
			case 1:
				if (asyncAction2 == null)
				{
					asyncAction2 = new CanvasControl.AsyncAction(this.method_87);
				}
				this.method_23(asyncAction2);
				return;
			case 2:
			case 3:
			case 4:
			case 5:
			case 6:
			case 8:
				break;
			case 7:
				if (asyncAction4 == null)
				{
					asyncAction4 = new CanvasControl.AsyncAction(this.method_89);
				}
				this.method_23(asyncAction4);
				break;
			case 9:
				if (asyncAction3 == null)
				{
					asyncAction3 = new CanvasControl.AsyncAction(this.method_88);
				}
				this.method_23(asyncAction3);
				return;
			case 10:
				if (asyncAction == null)
				{
					asyncAction = new CanvasControl.AsyncAction(this.method_86);
				}
				this.method_23(asyncAction);
				return;
			default:
				return;
			}
		}

		public void UpdateAllTelemetryLabels()
		{
			if (this.opcclient_0 == null)
			{
				return;
			}
			IEnumerable<DrawObjectBase> objects = this.list_0[0].Objects;
			if (CanvasControl.func_23 == null)
			{
				CanvasControl.func_23 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_25);
			}
			IEnumerable<DrawObjectBase> enumerable = objects.Where(CanvasControl.func_23);
			List<int> list = new List<int>();
			foreach (DrawObjectBase drawObjectBase in enumerable)
			{
				list.Add(((TelemetryLabelTool)drawObjectBase).ObjectTelemetry);
				list.Add(((TelemetryLabelTool)drawObjectBase).TelemetryParameterId);
			}
			this.OpcClient.OPCAsyncSend_GetItem(list.ToArray());
		}

		[Description("Происходит после добавления объекта на канвас")]
		[Category("Objects")]
		public event DrawObjectEventHandler ObjectsAdded
		{
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_0;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_0, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_0;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_0, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Description("Происходит после удаления объекта из канваса")]
		[Category("Objects")]
		public event DrawObjectEventHandler ObjectsRemoved
		{
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_1;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_1, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_1;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_1, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Description("Происходит после измениния размеров объектов")]
		[Category("Objects")]
		public event DrawObjectEventHandler ObjectsResized
		{
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_2;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_2, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_2;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_2, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Category("Objects")]
		[Description("Происходит при клике по объекту")]
		public event DrawObjectEventHandler ObjectClicked
		{
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_3;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_3, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_3;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_3, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Category("Objects")]
		[Description("Происходит после смены выделенного объекта")]
		public event DrawObjectEventHandler SelectedObjectChanged
		{
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_4;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_4, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_4;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_4, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Description("Происходит при движении выделенного объекта")]
		[Category("Objects")]
		public event DrawObjectEventHandler SelectedObjectMoved
		{
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_5;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_5, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_5;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_5, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Category("Objects")]
		[Description("Происходит при редактировании выделенного объекта")]
		public event DrawObjectEventHandler SelectedObjectEdited
		{
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_6;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_6, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_6;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_6, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Category("Objects")]
		[Description("Происходит при завершении рисования объекта")]
		public event DrawObjectEventHandler DrawingCompleted
		{
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_7;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_7, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_7;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_7, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Description("Происходит при показе контестного меню")]
		[Category("Objects")]
		public event ShowContextMenuCanvasEventHandler ShowContextMenuCanvasEvent
		{
			add
			{
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler = this.showContextMenuCanvasEventHandler_0;
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler2;
				do
				{
					showContextMenuCanvasEventHandler2 = showContextMenuCanvasEventHandler;
					ShowContextMenuCanvasEventHandler value2 = (ShowContextMenuCanvasEventHandler)Delegate.Combine(showContextMenuCanvasEventHandler2, value);
					showContextMenuCanvasEventHandler = Interlocked.CompareExchange<ShowContextMenuCanvasEventHandler>(ref this.showContextMenuCanvasEventHandler_0, value2, showContextMenuCanvasEventHandler2);
				}
				while (showContextMenuCanvasEventHandler != showContextMenuCanvasEventHandler2);
			}
			remove
			{
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler = this.showContextMenuCanvasEventHandler_0;
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler2;
				do
				{
					showContextMenuCanvasEventHandler2 = showContextMenuCanvasEventHandler;
					ShowContextMenuCanvasEventHandler value2 = (ShowContextMenuCanvasEventHandler)Delegate.Remove(showContextMenuCanvasEventHandler2, value);
					showContextMenuCanvasEventHandler = Interlocked.CompareExchange<ShowContextMenuCanvasEventHandler>(ref this.showContextMenuCanvasEventHandler_0, value2, showContextMenuCanvasEventHandler2);
				}
				while (showContextMenuCanvasEventHandler != showContextMenuCanvasEventHandler2);
			}
		}

		[Category("Objects")]
		[Description("Происходит при закрытии контестного меню")]
		public event ShowContextMenuCanvasEventHandler HideContextMenuCanvasEvent
		{
			add
			{
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler = this.showContextMenuCanvasEventHandler_1;
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler2;
				do
				{
					showContextMenuCanvasEventHandler2 = showContextMenuCanvasEventHandler;
					ShowContextMenuCanvasEventHandler value2 = (ShowContextMenuCanvasEventHandler)Delegate.Combine(showContextMenuCanvasEventHandler2, value);
					showContextMenuCanvasEventHandler = Interlocked.CompareExchange<ShowContextMenuCanvasEventHandler>(ref this.showContextMenuCanvasEventHandler_1, value2, showContextMenuCanvasEventHandler2);
				}
				while (showContextMenuCanvasEventHandler != showContextMenuCanvasEventHandler2);
			}
			remove
			{
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler = this.showContextMenuCanvasEventHandler_1;
				ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler2;
				do
				{
					showContextMenuCanvasEventHandler2 = showContextMenuCanvasEventHandler;
					ShowContextMenuCanvasEventHandler value2 = (ShowContextMenuCanvasEventHandler)Delegate.Remove(showContextMenuCanvasEventHandler2, value);
					showContextMenuCanvasEventHandler = Interlocked.CompareExchange<ShowContextMenuCanvasEventHandler>(ref this.showContextMenuCanvasEventHandler_1, value2, showContextMenuCanvasEventHandler2);
				}
				while (showContextMenuCanvasEventHandler != showContextMenuCanvasEventHandler2);
			}
		}

		[Description("Происходит после добавления объектов в мерцающие объекты на канвас")]
		[Category("Objects")]
		public event DrawObjectEventHandler FlashObjectsAdded
		{
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_8;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_8, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_8;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_8, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		[Category("Objects")]
		[Description("Происходит после удаления объектов с мерцающих объектов")]
		public event DrawObjectEventHandler FlashObjectsRemoved
		{
			add
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_9;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Combine(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_9, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
			remove
			{
				DrawObjectEventHandler drawObjectEventHandler = this.drawObjectEventHandler_9;
				DrawObjectEventHandler drawObjectEventHandler2;
				do
				{
					drawObjectEventHandler2 = drawObjectEventHandler;
					DrawObjectEventHandler value2 = (DrawObjectEventHandler)Delegate.Remove(drawObjectEventHandler2, value);
					drawObjectEventHandler = Interlocked.CompareExchange<DrawObjectEventHandler>(ref this.drawObjectEventHandler_9, value2, drawObjectEventHandler2);
				}
				while (drawObjectEventHandler != drawObjectEventHandler2);
			}
		}

		public event EventHandler SaveProcessChanged
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		public event CanvasMessageEventHandler CanvasMessage
		{
			add
			{
				CanvasMessageEventHandler canvasMessageEventHandler = this.canvasMessageEventHandler_0;
				CanvasMessageEventHandler canvasMessageEventHandler2;
				do
				{
					canvasMessageEventHandler2 = canvasMessageEventHandler;
					CanvasMessageEventHandler value2 = (CanvasMessageEventHandler)Delegate.Combine(canvasMessageEventHandler2, value);
					canvasMessageEventHandler = Interlocked.CompareExchange<CanvasMessageEventHandler>(ref this.canvasMessageEventHandler_0, value2, canvasMessageEventHandler2);
				}
				while (canvasMessageEventHandler != canvasMessageEventHandler2);
			}
			remove
			{
				CanvasMessageEventHandler canvasMessageEventHandler = this.canvasMessageEventHandler_0;
				CanvasMessageEventHandler canvasMessageEventHandler2;
				do
				{
					canvasMessageEventHandler2 = canvasMessageEventHandler;
					CanvasMessageEventHandler value2 = (CanvasMessageEventHandler)Delegate.Remove(canvasMessageEventHandler2, value);
					canvasMessageEventHandler = Interlocked.CompareExchange<CanvasMessageEventHandler>(ref this.canvasMessageEventHandler_0, value2, canvasMessageEventHandler2);
				}
				while (canvasMessageEventHandler != canvasMessageEventHandler2);
			}
		}

		[Category("Objects")]
		[Description("Происходит при добавлении статуса линии")]
		public event LineToolEventHandler StateAdded
		{
			add
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_0;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Combine(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_0, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
			remove
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_0;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Remove(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_0, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
		}

		[Category("Objects")]
		[Description("Происходит при удалении статуса линии")]
		public event LineToolEventHandler StateRemoved
		{
			add
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_1;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Combine(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_1, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
			remove
			{
				LineToolEventHandler lineToolEventHandler = this.lineToolEventHandler_1;
				LineToolEventHandler lineToolEventHandler2;
				do
				{
					lineToolEventHandler2 = lineToolEventHandler;
					LineToolEventHandler value2 = (LineToolEventHandler)Delegate.Remove(lineToolEventHandler2, value);
					lineToolEventHandler = Interlocked.CompareExchange<LineToolEventHandler>(ref this.lineToolEventHandler_1, value2, lineToolEventHandler2);
				}
				while (lineToolEventHandler != lineToolEventHandler2);
			}
		}

		[Description("Происходит при включении/выключении объекта на линии")]
		[Category("Objects")]
		public event EventHandler ObjectOnLinePropertyOnCanged
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		[Description("Происходит при изменении режима схемы")]
		[Category("Схема")]
		public event EventHandler CanvasModeChanged
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		[Category("Схема")]
		[Description("Происходит при изменении уровня доступа схемы")]
		public event EventHandler CanvasMaxModeChanged
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_3;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_3;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		public eCanvasEditingMode MaxMode
		{
			get
			{
				return this.eCanvasEditingMode_1;
			}
			set
			{
				if (value == this.eCanvasEditingMode_1)
				{
					return;
				}
				this.eCanvasEditingMode_1 = value;
				if (this.Mode > this.eCanvasEditingMode_1)
				{
					this.Mode = this.eCanvasEditingMode_1;
				}
				if (this.eventHandler_3 != null)
				{
					this.eventHandler_3(this, new EventArgs());
				}
			}
		}

		public eCommandType CanvasCommandType
		{
			get
			{
				return this.eCommandType_0;
			}
		}

		public bool LineInformationVisible { get; set; }

		public bool TelemetryLabelVisible { get; set; }

		public bool MeasurementLabelVisible { get; set; }

		public EndpointAddress Endpoint
		{
			get
			{
				return this.endPoint;
			}
			set
			{
				if (this.endPoint != null)
				{
					this.Disconnect();
				}
				this.endPoint = value;
				if (this.endPoint != null)
				{
					this.ConnectToServ();
				}
			}
		}

		private void Disconnect()
		{
			string hostName = Dns.GetHostName();
#pragma warning disable CS0618 // Тип или член устарел
            IPAddress ipaddress = Dns.GetHostByName(hostName).AddressList[0];
#pragma warning restore CS0618 // Тип или член устарел
            this.ProxySingleton.ExitChatSession();
			this.method_16(false);
		}

		private void ConnectToServ()
		{
			try
			{
				string hostName = Dns.GetHostName();
#pragma warning disable CS0618 // Тип или член устарел
                IPAddress ipaddress = Dns.GetHostByName(hostName).AddressList[0];
#pragma warning restore CS0618 // Тип или член устарел
                NetTcpBinding netTcpBinding = new NetTcpBinding(SecurityMode.None);
				netTcpBinding.Security.Mode = SecurityMode.None;
				netTcpBinding.SendTimeout = TimeSpan.FromSeconds(10.0);
				netTcpBinding.ReliableSession.Enabled = true;
				this.ProxySingleton.ProxyEvent -= this.ProxySingleton_ProxyEvent;
				this.ProxySingleton.ProxyCallBackEvent -= this.ProxySingleton_ProxyCallBackEvent;
				this.ProxySingleton.ProxyEvent += this.ProxySingleton_ProxyEvent;
				this.ProxySingleton.Connect(ipaddress.ToString() + Environment.UserName, netTcpBinding, this.endPoint);
				this.ProxySingleton.ProxyCallBackEvent += this.ProxySingleton_ProxyCallBackEvent;
			}
			catch
			{
			}
		}

		private void ProxySingleton_ProxyEvent(object object_0, bool bool_12)
		{
			this.Connected = bool_12;
			if (!this.timer_1.Enabled)
			{
				this.method_16(true);
			}
		}

		private void method_16(bool bool_12)
		{
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new Action<bool>(this.method_90), new object[]
				{
					bool_12
				});
				return;
			}
			this.method_17(bool_12);
		}

		private void method_17(bool bool_12)
		{
			this.timer_1.Enabled = bool_12;
		}

		private void ProxySingleton_ProxyCallBackEvent(object sender, ProxyCallBackEventArgs e)
		{
			switch (e.eventType)
			{
			case SchemeEventType.SwitchOn:
				this.ServerAgent_ObjectOnLineOnChangeEvent(e.idObj, true);
				return;
			case SchemeEventType.SwitchOff:
				this.ServerAgent_ObjectOnLineOnChangeEvent(e.idObj, false);
				return;
			case SchemeEventType.StateAdd:
				this.ServerAgent_LineStateOnChangeEvent(e.idObj, e.idRelation, e.numBranch, e.delta, e.typeState, true, e.idLineState);
				return;
			case SchemeEventType.StateDel:
				this.ServerAgent_LineStateOnChangeEvent(e.idObj, e.idRelation, e.numBranch, e.delta, e.typeState, false, e.idLineState);
				return;
			case SchemeEventType.UserEnter:
			case SchemeEventType.UserLeave:
				break;
			case SchemeEventType.NodeAdd:
				this.ServerAgent_NodeChange(e.idObj, 1, e.text, e.point, e.color);
				return;
			case SchemeEventType.NodeDel:
				this.ServerAgent_NodeChange(e.idObj, 2, e.text, e.point, e.color);
				break;
			case SchemeEventType.NodeChange:
				this.ServerAgent_NodeChange(e.idObj, 3, e.text, e.point, e.color);
				return;
			default:
				return;
			}
		}

		private void ServerAgent_NodeChange(int idBase, int idAction, string text, PointF point, Color color)
		{
			DrawObjectBase drawObjectBase = this.FindObjectById(idBase);
			switch (idAction)
			{
			case 1:
			{
				if (drawObjectBase != null && drawObjectBase is NodeTool)
				{
					return;
				}
				NodeTool nodeTool = new NodeTool();
				nodeTool.IdBase = idBase;
				nodeTool.Text = text;
				nodeTool.Location = new UnitPoint(point);
				if (color != Color.Empty)
				{
					nodeTool.UseSettingColor = false;
					nodeTool.Color = color;
				}
				this.AddObject(this.ActiveLayer, nodeTool);
				this.DoInvalidate(true);
				return;
			}
			case 2:
				if (drawObjectBase is NodeTool)
				{
					this.DeleteObjects(new List<DrawObjectBase>
					{
						drawObjectBase
					}, false);
				}
				this.DoInvalidate(true);
				return;
			case 3:
				if (drawObjectBase is NodeTool)
				{
					((NodeTool)drawObjectBase).Text = text;
					((NodeTool)drawObjectBase).Location = new UnitPoint(point);
					if (color != Color.Empty)
					{
						((NodeTool)drawObjectBase).UseSettingColor = false;
						((NodeTool)drawObjectBase).Color = color;
					}
				}
				this.DoInvalidate(true);
				return;
			default:
				return;
			}
		}

		private void ServerAgent_LineStateOnChangeEvent(int idBase, int idRelation, int numBranch, double delta, int typeState, bool bool_12, int idLineState)
		{
			DrawObjectBase drawObjectBase = this.FindObjectById(idBase);
			if (drawObjectBase != null && drawObjectBase is LineTool)
			{
				Branch branch = ((LineTool)drawObjectBase).FindBranch(idRelation, numBranch);
				if (branch != null)
				{
					if (bool_12)
					{
						LineToolState lineToolState = new LineToolState(branch, delta, (States)typeState);
						((LineTool)drawObjectBase).AddState(lineToolState);
						lineToolState.Mapping.IdBase = idLineState;
					}
					else
					{
						List<LineToolState> list = new List<LineToolState>();
						foreach (DrawObjectBase drawObjectBase2 in branch.ChildObjects)
						{
							if (drawObjectBase2 is ObjectOnLine && ((ObjectOnLine)drawObjectBase2).MappingState)
							{
								list.Add(((ObjectOnLine)drawObjectBase2).State);
							}
						}
						LineToolState lineToolState2 = null;
						double num = 1.0;
						if (idLineState > 0)
						{
							using (List<LineToolState>.Enumerator enumerator2 = list.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									LineToolState lineToolState3 = enumerator2.Current;
									if (lineToolState3.Mapping.IdBase == idLineState)
									{
										lineToolState2 = lineToolState3;
									}
								}
								goto IL_172;
							}
						}
						foreach (LineToolState lineToolState4 in list)
						{
							if (Math.Abs(lineToolState4.Mapping.Delta - delta) < num)
							{
								num = Math.Abs(lineToolState4.Mapping.Delta - delta);
								lineToolState2 = lineToolState4;
							}
						}
						IL_172:
						if (lineToolState2 != null)
						{
							lineToolState2.Remove(false);
						}
					}
				}
				this.DoInvalidate(true);
			}
		}

		private void ServerAgent_ObjectOnLineOnChangeEvent(int int_10, bool bool_12)
		{
			DrawObjectBase drawObjectBase = this.FindObjectById(int_10);
			if (drawObjectBase != null && drawObjectBase is ObjectOnLine)
			{
				((ObjectOnLine)drawObjectBase).On = bool_12;
				this.DoInvalidate(true);
			}
		}

		private void timer_1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (this.Connected)
				{
					this.ProxySingleton.Check();
				}
				else
				{
					this.ConnectToServ();
				}
			}
			catch
			{
				this.Connected = false;
				this.ConnectToServ();
			}
		}

		private void method_21(object sender, EventArgs e)
		{
			MessageBox.Show("Упало соединение\n" + e.ToString());
		}

		public bool Connected
		{
			get
			{
				return this.bool_5;
			}
			set
			{
				this.bool_5 = value;
				if (this.bool_5)
				{
					if (this.imageList_0.Images.Count > 0)
					{
						this.toolStripStatusLabelConnected.Image = this.imageList_0.Images[0];
						return;
					}
				}
				else if (this.imageList_0.Images.Count > 1)
				{
					this.toolStripStatusLabelConnected.Image = this.imageList_0.Images[1];
				}
			}
		}

		public int WorkerCounter
		{
			get
			{
				return this.int_6;
			}
			set
			{
				this.int_6 = value;
				this.eventHandler_0(this.int_6, new EventArgs());
			}
		}

		private void method_22(bool bool_12)
		{
			if (base.InvokeRequired)
			{
				CanvasControl.Delegate0 method = new CanvasControl.Delegate0(this.method_22);
				base.Invoke(method, new object[]
				{
					bool_12
				});
				return;
			}
			this.toolProgressBarSave.Visible = bool_12;
			this.labelProgressBar.Visible = bool_12;
		}

		public bool VisibleSaveProgressBar
		{
			get
			{
				return this.toolProgressBarSave.Visible;
			}
			set
			{
				this.method_22(value);
			}
		}

		public Graphics Graphics
		{
			get
			{
				return this.graphics_0;
			}
			set
			{
				this.graphics_0 = value;
			}
		}

		public ICanvasLayer BackgroundLayer
		{
			get
			{
				return this.backgroundLayer_0;
			}
		}

		public ICanvasLayer GridLayer
		{
			get
			{
				return this.gridLayer_0;
			}
		}

		[XmlArrayItem(typeof(ICanvasLayer))]
		[XmlArray]
		public IEnumerable<ICanvasLayer> Layers
		{
			get
			{
				return this.list_0;
			}
		}

		public ICanvasLayer ActiveLayer
		{
			get
			{
				if (this.icanvasLayer_0 == null && this.list_0.Count > 0)
				{
					this.icanvasLayer_0 = this.list_0[0];
				}
				return this.icanvasLayer_0;
			}
			set
			{
				this.icanvasLayer_0 = value;
			}
		}

		public float Zoom
		{
			get
			{
				return this.float_2;
			}
			set
			{
				this.float_2 = value;
				if (this.float_2 < 0.001f)
				{
					this.float_2 = 0.001f;
				}
				if (this.float_2 > 100f)
				{
					this.float_2 = 100f;
				}
				this.toolBtnZoom.Text = Math.Round((double)(this.float_2 * 100f), 2).ToString() + "%";
			}
		}

		[Browsable(false)]
		[XmlArrayItem(typeof(DrawObjectBase))]
		public IEnumerable<DrawObjectBase> SelectedObjects
		{
			get
			{
				return this.list_1;
			}
		}

		[Browsable(false)]
		[XmlArrayItem(typeof(DrawObjectBase))]
		public IEnumerable<DrawObjectBase> CopiedObjects
		{
			get
			{
				return this.list_7;
			}
		}

		[Browsable(false)]
		[XmlArrayItem(typeof(DrawObjectBase))]
		public IEnumerable<DrawObjectBase> FlashingObjects
		{
			get
			{
				return this.list_3;
			}
		}

		[Browsable(false)]
		public int SelectedCount
		{
			get
			{
				return this.list_1.Count;
			}
		}

		public eMetric CurrentMetric
		{
			get
			{
				return this.eMetric_0;
			}
			set
			{
				this.eMetric_0 = value;
			}
		}

		[Browsable(false)]
		public PointF DeltaPoint
		{
			get
			{
				PointF result = this.pointF_1;
				result.X += this.pointF_2.X;
				result.Y += this.pointF_2.Y;
				return result;
			}
			set
			{
				this.pointF_1 = value;
				this.pointF_2 = new PointF(0f, 0f);
				this.method_62();
			}
		}

		public SQLSettings SqlSettings
		{
			get
			{
				return this.sqlsettings_0;
			}
			set
			{
				this.sqlsettings_0 = value;
				Class96.smethod_1(this.sqlsettings_0);
			}
		}

		public string SchemeName
		{
			get
			{
				return this.string_4;
			}
			set
			{
				this.string_4 = value;
			}
		}

		public bool UseObjectFromDB { get; set; }

		public virtual bool StatusStripVisible
		{
			get
			{
				return this.statusStrip.Visible;
			}
			set
			{
				this.statusStrip.Visible = value;
				this.DoInvalidate(true);
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public CanvasSettings Settings
		{
			get
			{
				return this.canvasSettings_0;
			}
			set
			{
				this.canvasSettings_0 = value;
			}
		}

		public eTypeCanvas TypeCanvas
		{
			get
			{
				return this.eTypeCanvas_0;
			}
			set
			{
				if (this.eTypeCanvas_0 == value)
				{
					return;
				}
				this.eTypeCanvas_0 = value;
				switch (this.eTypeCanvas_0)
				{
				case eTypeCanvas.SchemeMain:
					this.MaxMode = eCanvasEditingMode.Edit;
					return;
				case eTypeCanvas.SchemeSecond:
					this.MaxMode = eCanvasEditingMode.Edit;
					return;
				case eTypeCanvas.SchemaClone:
					this.MaxMode = eCanvasEditingMode.Dispatcher;
					return;
				default:
					return;
				}
			}
		}

		public eSimulationMode SimulationMode
		{
			get
			{
				return this.eSimulationMode_0;
			}
			set
			{
				if (this.eSimulationMode_0 == value)
				{
					return;
				}
				switch (this.eSimulationMode_0)
				{
				case eSimulationMode.Training:
					if (this.icanvasLayer_0 != null)
					{
						this.icanvasLayer_0.Objects.Count<DrawObjectBase>();
					}
					break;
				}
				this.eSimulationMode_0 = value;
				switch (this.eSimulationMode_0)
				{
				case eSimulationMode.Online:
					this.MaxMode = eCanvasEditingMode.Edit;
					if (this.icanvasLayer_0 != null)
					{
						if (this.icanvasLayer_0.Objects.Count<DrawObjectBase>() == 0)
						{
							return;
						}
						this.OffSimulate();
						IEnumerable<DrawObjectBase> objects = this.icanvasLayer_0.Objects;
						if (CanvasControl.func_24 == null)
						{
							CanvasControl.func_24 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_26);
						}
						foreach (DrawObjectBase drawObjectBase in objects.Where(CanvasControl.func_24).Reverse<DrawObjectBase>())
						{
							((ObjectOnLine)drawObjectBase).NormalSectionModeOn = false;
						}
						this.OnSimulate();
						return;
					}
					break;
				case eSimulationMode.Normal:
					this.MaxMode = eCanvasEditingMode.ReadOnly;
					if (this.icanvasLayer_0 != null)
					{
						if (this.icanvasLayer_0.Objects.Count<DrawObjectBase>() == 0)
						{
							return;
						}
						this.OffSimulate();
						IEnumerable<DrawObjectBase> objects2 = this.icanvasLayer_0.Objects;
						if (CanvasControl.func_25 == null)
						{
							CanvasControl.func_25 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_27);
						}
						foreach (DrawObjectBase drawObjectBase2 in objects2.Where(CanvasControl.func_25).Reverse<DrawObjectBase>())
						{
							((ObjectOnLine)drawObjectBase2).NormalSectionModeOn = true;
						}
						this.OnSimulate();
					}
					break;
				case eSimulationMode.Training:
					this.MaxMode = eCanvasEditingMode.Dispatcher;
					return;
				default:
					return;
				}
			}
		}

		public eCanvasEditingMode Mode
		{
			get
			{
				return this.eCanvasEditingMode_0;
			}
			set
			{
				if (this.eCanvasEditingMode_0 != value && value <= this.MaxMode)
				{
					if (value != eCanvasEditingMode.Edit)
					{
						if (this.Monopoly)
						{
							this.method_68();
						}
						this.eCanvasEditingMode_0 = value;
					}
					else if (this.Monopoly)
					{
						if (this.method_67())
						{
							this.eCanvasEditingMode_0 = value;
						}
					}
					else if (this.TypeCanvas != eTypeCanvas.SchemeMain)
					{
						this.eCanvasEditingMode_0 = value;
					}
					else if (!this.method_66())
					{
						this.eCanvasEditingMode_0 = value;
					}
					if (this.eventHandler_2 != null)
					{
						this.eventHandler_2(this, new EventArgs());
					}
					return;
				}
			}
		}

		public bool Monopoly
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				this.bool_2 = value;
			}
		}

		public bool VisibleCanvasSchemeMap
		{
			get
			{
				return this.bool_3;
			}
			set
			{
				if (value && this.control0_0 == null)
				{
					this.method_59();
				}
				if (!value && this.control0_0 != null)
				{
					this.method_60();
				}
				this.bool_3 = value;
			}
		}

		public IEnumerable<LineToolState> States
		{
			get
			{
				return this.list_4;
			}
		}

		public CanvasControl()
		{
			this.timer_1.Interval = 10000;
			this.timer_1.Tick += this.timer_1_Tick;
			CanvasControl.dictionary_1["Rectangle"] = new RectangleTool();
			CanvasControl.dictionary_1["Shina"] = new ShinaTool();
			CanvasControl.dictionary_1["Line"] = new LineTool();
			CanvasControl.dictionary_1["Text"] = new LabelTool();
			this.InitializeComponent();
			this.method_0();
			base.Controls.Add(this.panelPassport_0);
			this.panelPassport_0.Visible = false;
			this.canvasSettings_0 = new CanvasSettings();
			this.backgroundLayer_0 = new BackgroundLayer(this);
			this.gridLayer_0 = new GridLayer(this);
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.pointF_0 = PointF.Empty;
			this.pointF_1 = new PointF(0f, 0f);
			this.pointF_2 = PointF.Empty;
			this.SetCenter(new UnitPoint(0.0, 0.0));
			this.method_40();
			this.SaveProcessChanged += this.CanvasControl_SaveProcessChanged;
			this.CanvasMessage += this.CanvasControl_CanvasMessage;
			this.ShowContextMenuCanvasEvent += this.CanvasControl_ShowContextMenuCanvasEvent;
			this.ObjectClicked += this.CanvasControl_ObjectClicked;
			this.SelectedObjectChanged += this.CanvasControl_SelectedObjectChanged;
			this.SelectedObjectMoved += this.CanvasControl_SelectedObjectMoved;
			this.StateAdded += this.CanvasControl_StateAdded;
			this.StateRemoved += this.CanvasControl_StateRemoved;
			if (base.GetType() == typeof(CanvasControl) && this.bool_3)
			{
				this.method_59();
			}
			this.undoRedoManager = new UndoRedoManager(this);
			this.method_9();
			this.method_65();
		}

		private void CanvasControl_StateRemoved(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
		}

		private void CanvasControl_StateAdded(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
		}

		private void CanvasControl_SelectedObjectMoved(CanvasControl canvasControl_1, DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
		}

		private void CanvasControl_SelectedObjectChanged(CanvasControl canvasControl_1, DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
		}

		private void CanvasControl_ObjectClicked(CanvasControl canvasControl_1, DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
		}

		private void method_23(CanvasControl.AsyncAction asyncAction_0)
		{
			if (!base.InvokeRequired)
			{
				asyncAction_0();
				return;
			}
			base.Invoke(new CanvasControl.DispatcherInvoker(this.method_23), new object[]
			{
				asyncAction_0
			});
		}

		private void CanvasControl_ShowContextMenuCanvasEvent(ContextMenuStrip contextMenuStrip_0, List<object> list_9)
		{
		}

		private void CanvasControl_CanvasMessage(CanvasControl canvasControl_1, CanvasMessageEventArgs canvasMessageEventArgs_0)
		{
		}

		private void CanvasControl_SaveProcessChanged(object sender, EventArgs e)
		{
			if ((int)sender == 0)
			{
				this.VisibleSaveProgressBar = false;
				return;
			}
			this.VisibleSaveProgressBar = true;
			this.toolProgressBarSave.Value = 10;
		}

		public virtual void OnSelectedObjectEdited(DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
			if (this.drawObjectEventHandler_6 != null)
			{
				this.drawObjectEventHandler_6(this, drawObjectsEventArgs_0);
			}
		}

		public virtual void OnDrawingCompleted(DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
			if (this.drawObjectEventHandler_7 != null)
			{
				this.drawObjectEventHandler_7(this, drawObjectsEventArgs_0);
			}
		}

		protected override void OnPaint(PaintEventArgs paintEventArgs_0)
		{
			Rectangle clipRectangle = paintEventArgs_0.ClipRectangle;
			if (this.staticImage == null)
			{
				if (base.ClientRectangle.Width == 0 || base.ClientRectangle.Height == 0)
				{
					return;
				}
				this.staticImage = new Bitmap(base.ClientRectangle.Width, base.ClientRectangle.Height);
				this.staticRepaint = true;
			}
			this.rectangleF_1 = ConvertCanvas.ConvertToUnitNormalized(this, clipRectangle);
			if (this.staticRepaint)
			{
				this.graphics_0 = Graphics.FromImage(this.staticImage);
				this.graphics_0.SmoothingMode = this.Settings.QualityImage;
				this.staticRepaint = false;
				this.BackgroundLayer.Draw(this, this.rectangleF_1);
				if (this.GridLayer.Enabled)
				{
					this.GridLayer.Draw(this, this.rectangleF_1);
				}
				PointF pointF = ConvertCanvas.ConvertToScreen(this, new UnitPoint(0.0, 0.0));
				float num = 10f * this.Zoom;
				this.Graphics.DrawLine(Pens.Blue, pointF.X - num, pointF.Y, pointF.X + num, pointF.Y);
				this.Graphics.DrawLine(Pens.Blue, pointF.X, pointF.Y - num, pointF.X, pointF.Y + num);
				if (base.Enabled)
				{
					for (int i = this.list_0.Count - 1; i >= 0; i--)
					{
						if (this.list_0[i] != this.ActiveLayer && this.list_0[i].Visible)
						{
							this.list_0[i].Draw(this, this.rectangleF_1);
						}
					}
					try
					{
						if (this.ActiveLayer != null)
						{
							this.ActiveLayer.Draw(this, this.rectangleF_1);
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, ex.Source);
					}
				}
			}
			paintEventArgs_0.Graphics.DrawImage(this.staticImage, clipRectangle, clipRectangle, GraphicsUnit.Pixel);
			this.graphics_0 = paintEventArgs_0.Graphics;
			if (this.drawObjectBase_0 != null)
			{
				this.drawObjectBase_0.Draw(this, this.rectangleF_1, eDrawMode.Color);
			}
			if (this.drawObjectBase_1 != null)
			{
				this.drawObjectBase_1.Draw(this, this.rectangleF_1, eDrawMode.Color);
			}
			if (this.isnapPoint_0 != null)
			{
				this.isnapPoint_0.Draw(this);
			}
			foreach (DrawObjectBase drawObjectBase in this.list_3)
			{
				drawObjectBase.Draw(this, this.rectangleF_1, eDrawMode.Color);
			}
			if (this.selectionRectangle_0 != null)
			{
				Rectangle rectangle = this.selectionRectangle_0.ScreenRect();
				if (rectangle != Rectangle.Empty)
				{
					ControlPaint.DrawFocusRectangle(this.graphics_0, rectangle, Color.Black, Color.Transparent);
				}
			}
			if ((this.eCommandType_0 == eCommandType.drawframe || this.eCommandType_0 == eCommandType.frame) && this.canvasFrame_0 != null)
			{
				PointF pointF2 = ConvertCanvas.ConvertToScreen(this, new UnitPoint(this.canvasFrame_0.Rectangle.Location));
				PointF pointF3 = ConvertCanvas.ConvertToScreen(this, new UnitPoint((double)this.canvasFrame_0.Rectangle.Right, (double)this.canvasFrame_0.Rectangle.Bottom));
				float num2 = Math.Min(pointF2.X, pointF3.X);
				float num3 = Math.Min(pointF2.Y, pointF3.Y);
				float num4 = Math.Max(pointF2.X, pointF3.X);
				float num5 = Math.Max(pointF2.Y, pointF3.Y);
				paintEventArgs_0.Graphics.DrawRectangle(new Pen(Brushes.White), num2, num3, num4 - num2, num5 - num3);
				for (int j = 1; j <= this.canvasFrame_0.NodeCount; j++)
				{
					paintEventArgs_0.Graphics.FillRectangle(Brushes.White, this.canvasFrame_0.GetNodeRectangle(this, j));
				}
				SolidBrush solidBrush = new SolidBrush(Color.FromArgb(100, Color.LightGray));
				paintEventArgs_0.Graphics.FillRectangle(solidBrush, new Rectangle(base.ClientRectangle.X, base.ClientRectangle.Y, (int)num2 - base.ClientRectangle.X, base.ClientRectangle.Height));
				paintEventArgs_0.Graphics.FillRectangle(solidBrush, new Rectangle((int)num4, base.ClientRectangle.Y, base.ClientRectangle.Right - (int)num4, base.ClientRectangle.Height));
				paintEventArgs_0.Graphics.FillRectangle(solidBrush, new Rectangle((int)num2, base.ClientRectangle.Y, (int)num4 - (int)num2, (int)num3 - base.ClientRectangle.Y));
				paintEventArgs_0.Graphics.FillRectangle(solidBrush, new Rectangle((int)num2, (int)num5, (int)num4 - (int)num2, base.ClientRectangle.Bottom - (int)num5));
				solidBrush.Dispose();
			}
		}

		protected override void OnMouseDown(MouseEventArgs mouseEventArgs_0)
		{
			if (!base.Enabled)
			{
				return;
			}
			this.panelPassport_0.Visible = false;
			this.unitPoint_2 = ConvertCanvas.ConvertToUnit(this, new PointF((float)mouseEventArgs_0.X, (float)mouseEventArgs_0.Y));
			this.pointF_0 = new PointF((float)mouseEventArgs_0.X, (float)mouseEventArgs_0.Y);
			this.pointF_2 = new PointF(0f, 0f);
			UnitPoint point = ConvertCanvas.ConvertToUnit(this, this.pointF_0);
			if (this.isnapPoint_0 != null)
			{
				point = this.isnapPoint_0.SnapPoint;
			}
			MouseButtons button = mouseEventArgs_0.Button;
			if (button != MouseButtons.Left)
			{
				if (button != MouseButtons.Right)
				{
					if (button == MouseButtons.Middle)
					{
						this.Cursor = this.class95_0.method_2(eCommandType.const_2);
					}
				}
				else
				{
					eCommandType eCommandType = this.eCommandType_0;
					if (eCommandType != eCommandType.select)
					{
						if (eCommandType == eCommandType.draw && this.Mode == eCanvasEditingMode.Edit && this.drawObjectBase_0 != null)
						{
							this.drawObjectBase_0.OnMouseDown(this, point, this.isnapPoint_0, mouseEventArgs_0.Button);
						}
					}
					else if (this.list_1.Count == 1)
					{
						DrawObjectBase drawObjectBase = this.SelectedObjects.First<DrawObjectBase>();
						if (drawObjectBase.PointInObject(point))
						{
							drawObjectBase.OnMouseDown(this, point, null, mouseEventArgs_0.Button);
						}
					}
				}
			}
			else
			{
				switch (this.eCommandType_0)
				{
				case eCommandType.select:
					if (this.control0_0 != null)
					{
						if (Class88.smethod_4(new UnitPoint(this.control0_0.Location), 3f, new UnitPoint((double)mouseEventArgs_0.X, (double)mouseEventArgs_0.Y)))
						{
							this.Cursor = Cursors.SizeNWSE;
							this.control0_0.Cursor = Cursors.SizeNWSE;
							this.eCommandType_0 = eCommandType.select;
							break;
						}
						this.control0_0.Cursor = Cursors.Default;
					}
					foreach (DrawObjectBase drawObjectBase2 in this.SelectedObjects)
					{
						DrawObjectBase drawObjectBase3 = drawObjectBase2;
						int num = drawObjectBase3.HitTest(this, new PointF((float)mouseEventArgs_0.X, (float)mouseEventArgs_0.Y));
						if (num > 0)
						{
							this.eCommandType_0 = eCommandType.resizeObj;
							this.drawObjectBase_1 = drawObjectBase2;
							this.int_5 = num;
							this.ClearSelectedObjects();
							this.SelectObject(drawObjectBase2);
							this.bool_4 = true;
							break;
						}
					}
					if (this.eCommandType_0 == eCommandType.select)
					{
						List<DrawObjectBase> hitObjects = this.GetHitObjects(point);
						if (hitObjects.Count > 0)
						{
							this.eCommandType_0 = eCommandType.move;
							this.unitPoint_1 = point;
							if (this.list_1.Count > 0 && this.SelectedObjects.Contains(hitObjects[0]) && Control.ModifierKeys != Keys.Control)
							{
								if (this.Mode == eCanvasEditingMode.Edit)
								{
									this.Cursor = Cursors.SizeAll;
								}
								this.bool_4 = true;
								return;
							}
							List<DrawObjectBase> list = new List<DrawObjectBase>();
							if (hitObjects.Count > 0)
							{
								list.Add(hitObjects[0]);
								Color color = hitObjects[0].Color;
								this.drawObjectEventHandler_3(this, new DrawObjectsEventArgs(hitObjects[0]));
							}
							this.HandleSelection(list);
							if (this.Mode == eCanvasEditingMode.Edit)
							{
								this.Cursor = Cursors.SizeAll;
							}
							this.bool_4 = true;
						}
					}
					if (this.eCommandType_0 == eCommandType.select)
					{
						this.eCommandType_0 = eCommandType.netSelect;
					}
					this.selectionRectangle_0 = new SelectionRectangle(this.pointF_0);
					break;
				case eCommandType.draw:
					if (this.Mode == eCanvasEditingMode.Edit)
					{
						if (this.drawObjectBase_0 == null)
						{
							this.drawObjectBase_0 = this.CreateObject(this.string_3, point, null);
							if (this.drawObjectBase_0 != null)
							{
								this.ClearSelectedObjects();
								UndoRedoManager.RegistrarOfChanges changes = new UndoRedoManager.RegistrarOfChanges(new List<DrawObjectBase>
								{
									this.drawObjectBase_0
								}, UndoRedoManager.ChangesMode.AddObject);
								this.undoRedoManager.HappenedChange(changes);
								this.AddObject(this.ActiveLayer, this.drawObjectBase_0);
								this.DoInvalidate(true);
							}
						}
						if (this.drawObjectBase_0 != null)
						{
							this.drawObjectBase_0.OnMouseDown(this, point, this.isnapPoint_0, mouseEventArgs_0.Button);
						}
					}
					break;
				case eCommandType.pattern:
					if (this.Mode == eCanvasEditingMode.Edit && this.drawObjectBase_0 == null)
					{
						this.drawObjectBase_0 = this.CreateObject("Rectangle", point, null);
						if (this.drawObjectBase_0 != null)
						{
							this.ClearSelectedObjects();
							this.AddObject(this.ActiveLayer, this.drawObjectBase_0);
							this.DoInvalidate(true);
						}
					}
					break;
				case eCommandType.zoomWindow:
					this.selectionRectangle_0 = new SelectionRectangle(this.pointF_0);
					break;
				case eCommandType.frame:
					if (this.canvasFrame_0 != null)
					{
						this.int_4 = this.canvasFrame_0.HitTest(this, point);
						if (this.int_4 == -1)
						{
							this.CommandDrawFrame();
							this.canvasFrame_0 = new CanvasFrame(point);
						}
						if (this.int_4 == 0)
						{
							this.unitPoint_1 = point;
						}
					}
					break;
				case eCommandType.drawframe:
					this.canvasFrame_0 = new CanvasFrame(point);
					break;
				}
			}
			base.OnMouseDown(mouseEventArgs_0);
		}

		protected override void OnMouseMove(MouseEventArgs mouseEventArgs_0)
		{
			this.eMouseControlState_0 = eMouseControlState.OnControl;
			base.OnMouseMove(mouseEventArgs_0);
			this.unitPoint_2 = ConvertCanvas.ConvertToUnit(this, new PointF((float)mouseEventArgs_0.X, (float)mouseEventArgs_0.Y));
			this.labelMousePosition.Text = string.Format("X={0:F};Y={1:F}", this.unitPoint_2.X, this.unitPoint_2.Y);
			MouseButtons button = mouseEventArgs_0.Button;
			if (button <= MouseButtons.Left)
			{
				if (button != MouseButtons.None)
				{
					if (button == MouseButtons.Left)
					{
						switch (this.eCommandType_0)
						{
						case eCommandType.select:
							if (this.control0_0 != null)
							{
								Point point_ = new Point(mouseEventArgs_0.X, mouseEventArgs_0.Y);
								if (point_.X < 0)
								{
									point_.X = 0;
								}
								if (point_.X > base.Width)
								{
									point_.X = base.Width;
								}
								if (point_.Y < 0)
								{
									point_.Y = 0;
								}
								if (point_.Y > base.Height)
								{
									point_.Y = base.Height;
								}
								this.control0_0.method_103(point_);
							}
							break;
						case eCommandType.netSelect:
							this.selectionRectangle_0.SetMousePoint(this.graphics_0, new PointF((float)mouseEventArgs_0.X, (float)mouseEventArgs_0.Y));
							this.DoInvalidate(false);
							break;
						case eCommandType.const_2:
							this.pointF_2.X = -(this.pointF_0.X - (float)mouseEventArgs_0.X);
							this.pointF_2.Y = -(this.pointF_0.Y - (float)mouseEventArgs_0.Y);
							this.unitPoint_0 = this.CenterPointUnit();
							this.DoInvalidate(true);
							break;
						case eCommandType.move:
							if (this.Mode == eCanvasEditingMode.Edit)
							{
								if (this.bool_4)
								{
									UndoRedoManager.RegistrarOfChanges changes = new UndoRedoManager.RegistrarOfChanges(this.SelectedObjects.ToList<DrawObjectBase>(), this.unitPoint_1, this.unitPoint_2);
									this.undoRedoManager.HappenedChange(changes);
								}
								else
								{
									this.undoRedoManager.ChangeNewValueInLastChange(this.unitPoint_2);
								}
								this.HandleMouseMoveForMove(this.unitPoint_2);
								this.DoInvalidate(true);
							}
							this.bool_4 = false;
							break;
						case eCommandType.draw:
							if (this.Mode == eCanvasEditingMode.Edit && this.drawObjectBase_0 != null)
							{
								this.method_42(this.unitPoint_2);
								if (this.isnapPoint_0 != null)
								{
									this.unitPoint_2 = this.isnapPoint_0.SnapPoint;
								}
								this.graphics_0 = Graphics.FromHwnd(base.Handle);
								this.drawObjectBase_0.OnMouseMove(this, this.unitPoint_2, mouseEventArgs_0.Button);
							}
							break;
						case eCommandType.resizeObj:
							if (this.Mode == eCanvasEditingMode.Edit && this.drawObjectBase_1 != null)
							{
								if (this.bool_4)
								{
									UndoRedoManager.RegistrarOfChanges changes2 = new UndoRedoManager.RegistrarOfChanges(this.drawObjectBase_1, this.int_5, this.unitPoint_2, this.unitPoint_2);
									this.undoRedoManager.HappenedChange(changes2);
								}
								else
								{
									this.undoRedoManager.ChangeNewValueInLastChange(this.unitPoint_2);
								}
								this.method_42(this.unitPoint_2);
								if (this.isnapPoint_0 != null)
								{
									this.unitPoint_2 = this.isnapPoint_0.SnapPoint;
								}
								if (Control.ModifierKeys == Keys.Shift)
								{
									UnitPoint unitPoint = ConvertCanvas.ConvertToUnit(this, this.pointF_0);
									double value = unitPoint.X - this.unitPoint_2.X;
									double value2 = unitPoint.Y - this.unitPoint_2.Y;
									if (Math.Abs(value) > Math.Abs(value2))
									{
										this.unitPoint_2 = new UnitPoint(this.unitPoint_2.X, unitPoint.Y);
									}
									else if (Math.Abs(value) < Math.Abs(value2))
									{
										this.unitPoint_2 = new UnitPoint(unitPoint.X, this.unitPoint_2.Y);
									}
								}
								this.drawObjectBase_1.MoveHandleTo(this.unitPoint_2, this.int_5);
								this.DoInvalidate(true);
							}
							this.bool_4 = false;
							break;
						case eCommandType.pattern:
							if (this.Mode == eCanvasEditingMode.Edit && this.drawObjectBase_0 != null)
							{
								this.method_42(this.unitPoint_2);
								if (this.isnapPoint_0 != null)
								{
									this.unitPoint_2 = this.isnapPoint_0.SnapPoint;
								}
								this.graphics_0 = Graphics.FromHwnd(base.Handle);
								RectangleF unitrect = ConvertCanvas.ConvertToScreenNormalized(this, this.drawObjectBase_0.GetBoundingRect(this, true));
								unitrect.Inflate(2f, 2f);
								this.method_36(new Rectangle((int)unitrect.X, (int)unitrect.Y, (int)unitrect.Width, (int)unitrect.Height));
								this.drawObjectBase_0.MoveHandleTo(this.unitPoint_2, 5);
								this.drawObjectBase_0.Draw(this, unitrect, eDrawMode.Color);
							}
							break;
						case eCommandType.zoomWindow:
							this.selectionRectangle_0.SetMousePoint(this.graphics_0, new PointF((float)mouseEventArgs_0.X, (float)mouseEventArgs_0.Y));
							this.DoInvalidate(false);
							break;
						case eCommandType.frame:
							if (this.int_4 == 0)
							{
								double double_ = this.unitPoint_2.X - this.unitPoint_1.X;
								double double_2 = this.unitPoint_2.Y - this.unitPoint_1.Y;
								UnitPoint offset = new UnitPoint(double_, double_2);
								this.unitPoint_1 = this.unitPoint_2;
								this.canvasFrame_0.Move(offset);
								this.DoInvalidate(true);
							}
							else if (this.int_4 > 0)
							{
								this.canvasFrame_0.MoveHandleTo(this.unitPoint_2, this.int_4);
								this.DoInvalidate(true);
							}
							break;
						case eCommandType.drawframe:
							this.canvasFrame_0.MoveHandleTo(this.unitPoint_2, 5);
							this.DoInvalidate(true);
							break;
						}
					}
				}
				else
				{
					eCommandType eCommandType = this.eCommandType_0;
					if (eCommandType != eCommandType.select)
					{
						if (eCommandType != eCommandType.draw)
						{
							if (eCommandType == eCommandType.frame)
							{
								if (this.canvasFrame_0 != null)
								{
									int handleNumber = this.canvasFrame_0.HitTest(this, this.unitPoint_2);
									switch (handleNumber)
									{
									case -1:
										this.Cursor = Cursors.Arrow;
										break;
									case 0:
										this.Cursor = Cursors.SizeAll;
										break;
									case 1:
									case 2:
									case 3:
									case 4:
									case 5:
									case 6:
									case 7:
									case 8:
										this.Cursor = this.canvasFrame_0.GetHandleCursor(handleNumber);
										break;
									}
								}
							}
						}
						else if (this.Mode == eCanvasEditingMode.Edit)
						{
							this.method_42(this.unitPoint_2);
							if (this.isnapPoint_0 != null)
							{
								this.unitPoint_2 = this.isnapPoint_0.SnapPoint;
							}
							if (this.drawObjectBase_0 != null)
							{
								this.drawObjectBase_0.OnMouseMove(this, this.unitPoint_2, mouseEventArgs_0.Button);
							}
						}
					}
					else
					{
						Cursor cursor = null;
						foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
						{
							DrawObjectBase drawObjectBase2 = drawObjectBase;
							int num = drawObjectBase2.HitTest(this, new PointF((float)mouseEventArgs_0.X, (float)mouseEventArgs_0.Y));
							if (num > 0)
							{
								cursor = drawObjectBase2.GetHandleCursor(num);
								break;
							}
						}
						if (cursor == null)
						{
							this.method_39();
						}
						else
						{
							this.Cursor = cursor;
						}
						if (this.control0_0 != null)
						{
							if (Class88.smethod_4(new UnitPoint(this.control0_0.Location), 3f, new UnitPoint((double)mouseEventArgs_0.X, (double)mouseEventArgs_0.Y)))
							{
								this.Cursor = Cursors.SizeNWSE;
							}
							else
							{
								this.Cursor = cursor;
							}
						}
					}
				}
			}
			else if (button != MouseButtons.Right)
			{
				if (button == MouseButtons.Middle)
				{
					this.pointF_2.X = -(this.pointF_0.X - (float)mouseEventArgs_0.X);
					this.pointF_2.Y = -(this.pointF_0.Y - (float)mouseEventArgs_0.Y);
					this.unitPoint_0 = this.CenterPointUnit();
					this.DoInvalidate(true);
				}
			}
			if (!this.timer_0.Enabled)
			{
				this.timer_0.Start();
			}
			this.point_0 = new Point(mouseEventArgs_0.X, mouseEventArgs_0.Y);
			if (this.point_0 != this.point_1)
			{
				this.panelPassport_0.Visible = false;
				this.tbPopup.Visible = false;
			}
			this.int_8 = 0;
		}

		protected override void OnMouseUp(MouseEventArgs mouseEventArgs_0)
		{
			Func<DrawObjectBase, bool> func = null;
			CanvasControl.Class24 @class = new CanvasControl.Class24();
			base.OnMouseUp(mouseEventArgs_0);
			@class.unitPoint_0 = ConvertCanvas.ConvertToUnit(this, mouseEventArgs_0.Location);
			MouseButtons button = mouseEventArgs_0.Button;
			if (button != MouseButtons.Left)
			{
				if (button != MouseButtons.Right)
				{
					if (button == MouseButtons.Middle)
					{
						this.pointF_1.X = this.pointF_1.X + this.pointF_2.X;
						this.pointF_1.Y = this.pointF_1.Y + this.pointF_2.Y;
						this.pointF_2 = new PointF(0f, 0f);
						this.method_62();
						this.method_39();
					}
				}
				else
				{
					eCommandType eCommandType = this.eCommandType_0;
					if (eCommandType != eCommandType.select)
					{
						if (eCommandType == eCommandType.frame)
						{
							if (this.canvasFrame_0 != null && this.canvasFrame_0.HitTest(this, @class.unitPoint_0) >= 0)
							{
								this.contextMenuFrame.Show(Cursor.Position);
							}
						}
					}
					else
					{
						if (this.list_1.Count == 1)
						{
							DrawObjectBase drawObjectBase = this.SelectedObjects.First<DrawObjectBase>();
							if (drawObjectBase.PointInObject(@class.unitPoint_0))
							{
								List<object> list = new List<object>();
								list.Add(drawObjectBase);
								ContextMenuStrip contextMenuByObject = this.GetContextMenuByObject(drawObjectBase);
								if (contextMenuByObject != null)
								{
									contextMenuByObject.Tag = drawObjectBase;
									this.showContextMenuCanvasEventHandler_0(contextMenuByObject, list);
									contextMenuByObject.Show(Cursor.Position);
									goto IL_947;
								}
								goto IL_947;
							}
						}
						else
						{
							IEnumerable<DrawObjectBase> selectedObjects = this.SelectedObjects;
							if (func == null)
							{
								func = new Func<DrawObjectBase, bool>(@class.method_0);
							}
							IEnumerable<DrawObjectBase> source = selectedObjects.Where(func);
							if (source.Count<DrawObjectBase>() > 0)
							{
								this.contextMenuSelectedObjects.Tag = this.SelectedObjects;
								this.contextMenuSelectedObjects.Show(Cursor.Position);
								goto IL_947;
							}
						}
						this.contextMenuCanvas.Tag = @class.unitPoint_0;
						this.contextMenuCanvas.Show(Cursor.Position);
					}
				}
			}
			else
			{
				switch (this.eCommandType_0)
				{
				case eCommandType.netSelect:
					if (this.selectionRectangle_0 != null)
					{
						List<DrawObjectBase> selected = null;
						RectangleF rectangleF = this.selectionRectangle_0.Selection(this);
						if (rectangleF != RectangleF.Empty)
						{
							this.graphics_0 = Graphics.FromHwnd(base.Handle);
							selected = this.GetHitObjects(this, rectangleF, this.selectionRectangle_0.AnyPoint());
							this.DoInvalidate(true);
						}
						this.HandleSelection(selected);
					}
					this.eCommandType_0 = eCommandType.select;
					this.selectionRectangle_0 = null;
					this.method_39();
					break;
				case eCommandType.const_2:
					this.pointF_1.X = this.pointF_1.X + this.pointF_2.X;
					this.pointF_1.Y = this.pointF_1.Y + this.pointF_2.Y;
					this.pointF_2 = new PointF(0f, 0f);
					this.method_62();
					break;
				case eCommandType.move:
				{
					if (this.Mode == eCanvasEditingMode.Edit && this.pointF_0 != new PointF((float)mouseEventArgs_0.X, (float)mouseEventArgs_0.Y))
					{
						this.method_24();
					}
					IEnumerable<DrawObjectBase> selectedObjects2 = this.SelectedObjects;
					if (CanvasControl.func_26 == null)
					{
						CanvasControl.func_26 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_28);
					}
					foreach (DrawObjectBase drawObjectBase2 in selectedObjects2.Where(CanvasControl.func_26))
					{
						try
						{
							if (this.Connected)
							{
								this.ProxySingleton.NodeChange(drawObjectBase2.IdBase, 3, drawObjectBase2.Text, ((NodeTool)drawObjectBase2).Location.Point, drawObjectBase2.Color);
							}
						}
						catch (Exception ex)
						{
							this.SendMessage(ex.Message, eMessageType.Error);
						}
					}
					this.eCommandType_0 = eCommandType.select;
					this.method_39();
					break;
				}
				case eCommandType.draw:
					if (this.Mode == eCanvasEditingMode.Edit && this.drawObjectBase_0 != null)
					{
						this.drawObjectBase_0.OnMouseUp(this, new UnitPoint((double)mouseEventArgs_0.X, (double)mouseEventArgs_0.Y), null, mouseEventArgs_0.Button);
					}
					break;
				case eCommandType.resizeObj:
					if (this.Mode == eCanvasEditingMode.Edit)
					{
						if (!this.drawObjectBase_1.LimitedEditing && this.drawObjectBase_1 is LineTool && ((LineTool)this.drawObjectBase_1).Ends.Contains(((LineTool)this.drawObjectBase_1).SelectedPoint))
						{
							PointTool pointTool = this.method_44(@class.unitPoint_0);
							if (pointTool != null)
							{
								PointTool pointTool2 = ((LineTool)this.drawObjectBase_1).GetPointsList()[this.int_5 - 1];
								bool flag = false;
								if (!(flag = ((pointTool2.Parent != null && pointTool2.Parent is ShinaTool) || (pointTool.Parent != null && pointTool.Parent is ShinaTool))))
								{
									foreach (Branch branch in pointTool.Branches)
									{
										if (branch.Parent.LimitedEditing)
										{
											flag = true;
											break;
										}
									}
								}
								if (!flag && ((LineTool)this.drawObjectBase_1).Ends.Contains(pointTool2) && !((LineTool)this.drawObjectBase_1).Ends.Contains(pointTool) && pointTool2 != pointTool)
								{
									Branch branch2 = pointTool2[0];
									bool isSourse = pointTool2[0].Source == pointTool2;
									((LineTool)this.drawObjectBase_1).RechangePointInBranch(branch2, pointTool, isSourse);
									((LineTool)this.drawObjectBase_1).AmperageAnalisForNewPoint(pointTool, branch2);
								}
								Class96.smethod_5(this.drawObjectBase_1);
							}
							else if (this.drawObjectBase_1.GetType() == typeof(LineCellTool) && !(((LineTool)this.drawObjectBase_1).SelectedPoint.Parent is ShinaTool))
							{
								ShinaTool shinaTool = null;
								foreach (DrawObjectBase drawObjectBase3 in this.drawObjectBase_1.Parent.ChildObjects)
								{
									if (drawObjectBase3.GetType() == typeof(ShinaTool) && drawObjectBase3.PointInObject(((LineTool)this.drawObjectBase_1).SelectedPoint.Point))
									{
										shinaTool = (ShinaTool)drawObjectBase3;
										break;
									}
								}
								if (shinaTool != null)
								{
									foreach (PointTool pointTool3 in ((LineCellTool)this.drawObjectBase_1).Ends)
									{
										if (pointTool3.Parent != null && pointTool3.Parent == shinaTool)
										{
											shinaTool = null;
											break;
										}
									}
									if (shinaTool != null)
									{
										PointShinaTool newPoint = shinaTool.AddPointShinaTool(((LineTool)this.drawObjectBase_1).SelectedPoint.Point);
										Branch branch3 = null;
										using (IEnumerator<Branch> enumerator5 = ((LineTool)this.drawObjectBase_1).SelectedPoint.Branches.GetEnumerator())
										{
											if (enumerator5.MoveNext())
											{
												Branch branch4 = enumerator5.Current;
												if (branch4.Parent == this.drawObjectBase_1)
												{
													branch3 = branch4;
												}
											}
										}
										if (branch3 != null)
										{
											((LineTool)this.drawObjectBase_1).RechangePointInBranch(branch3, newPoint, branch3.Source == ((LineTool)this.drawObjectBase_1).SelectedPoint);
											Class96.smethod_5(this.drawObjectBase_1);
										}
									}
								}
							}
							else
							{
								Class96.smethod_5(this.drawObjectBase_1);
							}
						}
						else
						{
							this.drawObjectBase_1.Normalize();
							Class96.smethod_5(this.drawObjectBase_1);
						}
						this.OnObjectsResized(new DrawObjectsEventArgs(this.drawObjectBase_1));
					}
					this.eCommandType_0 = eCommandType.select;
					this.drawObjectBase_1 = null;
					break;
				case eCommandType.pattern:
					if (this.Mode == eCanvasEditingMode.Edit)
					{
						this.drawingLayer_0.AddObject(this.drawObjectBase_0);
						((PatternTP)this.drawingLayer_0).ShowFormSettings(this.SqlSettings);
						this.ClearSelectedObjects();
						this.ClearFlashingObjects();
						((DrawingLayer)this.ActiveLayer).RemoveObject(this.drawObjectBase_0);
						if (this.drawingLayer_0.ObjectsCount > 0)
						{
							UndoRedoManager.RegistrarOfChanges changes = new UndoRedoManager.RegistrarOfChanges(this.drawingLayer_0.Objects.ToList<DrawObjectBase>(), UndoRedoManager.ChangesMode.AddObject);
							this.undoRedoManager.HappenedChange(changes);
							DrawObjectBase drawObjectBase4 = null;
							foreach (DrawObjectBase drawObjectBase5 in this.drawingLayer_0.Objects)
							{
								this.AddObject(this.ActiveLayer, drawObjectBase5);
								this.SelectObject(drawObjectBase5);
								if (drawObjectBase5.GetType() == typeof(RectangleTool))
								{
									if (!this.ValidateToUnique(drawObjectBase5))
									{
										drawObjectBase5.CreateUniqueCopyName();
									}
									drawObjectBase4 = drawObjectBase5;
								}
								if (drawObjectBase5.GetType() == typeof(ShinaTool) && drawObjectBase5.Parent != null && ((RectangleTool)drawObjectBase5.Parent).TypeRectnagleTool == eTypeRectangleTool.CP)
								{
									((ShinaTool)drawObjectBase5).OnAmperage = true;
								}
							}
							if (drawObjectBase4 != null)
							{
								Class96.smethod_5(drawObjectBase4);
							}
						}
						this.CommandEscape();
					}
					break;
				case eCommandType.zoomWindow:
					this.method_43(this.selectionRectangle_0.Selection(this), true);
					this.eCommandType_0 = eCommandType.select;
					this.selectionRectangle_0 = null;
					this.method_39();
					break;
				case eCommandType.drawframe:
					this.CommandFrame();
					break;
				}
			}
			IL_947:
			this.isnapPoint_0 = null;
		}

		public ContextMenuStrip GetContextMenuByObject(DrawObjectBase drawObjectBase_2)
		{
			ContextMenuStrip result = null;
			if (drawObjectBase_2.GetType() == typeof(RectangleTool))
			{
				result = this.ContextMenuRectangle;
			}
			if (drawObjectBase_2.GetType() == typeof(ShinaTool) || drawObjectBase_2.GetType() == typeof(SplitterShinaTool))
			{
				result = this.ContextMenuShina;
			}
			if (drawObjectBase_2 is ObjectOnLine)
			{
				result = this.ContextMenuSwitchTool;
			}
			if (drawObjectBase_2.GetType() == typeof(LineTool) || drawObjectBase_2.GetType() == typeof(LineCellTool) || drawObjectBase_2.GetType() == typeof(Class74))
			{
				result = this.ContextMenuLineTool;
			}
			if (drawObjectBase_2 is LabelTool)
			{
				result = this.contextMenuLabelTool;
			}
			if (drawObjectBase_2.GetType() == typeof(PointShinaTool) && ((PointShinaTool)drawObjectBase_2).CouplingRelations.Count == 0)
			{
				result = this.contextMenuStripWhitePoint;
			}
			if (drawObjectBase_2.GetType() == typeof(TextBranchTool))
			{
				result = this.contextMenuTextBranchTool;
			}
			return result;
		}

		private void method_24()
		{
			if (this.Mode == eCanvasEditingMode.Edit)
			{
				BackgroundWorker backgroundWorker = new BackgroundWorker();
				backgroundWorker.DoWork += this.method_25;
				backgroundWorker.RunWorkerCompleted += this.method_26;
				StringBuilder stringBuilder = new StringBuilder();
				List<int> list = new List<int>();
				foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
				{
					stringBuilder.Append(drawObjectBase.GetUpdateScriptXML(true, list));
				}
				if (!string.IsNullOrEmpty(stringBuilder.ToString()))
				{
					this.method_34();
				}
				if (!string.IsNullOrEmpty(stringBuilder.ToString()))
				{
					stringBuilder.Insert(0, "BEGIN TRANSACTION t1; set transaction isolation level SERIALIZABLE;  select id from tSChm_ObjList (UPDLOCK)  select id from tSChm_Xml (UPDLOCK) ");
					stringBuilder.Append(" COMMIT TRANSACTION t1; ");
					this.WorkerCounter++;
					backgroundWorker.RunWorkerAsync(stringBuilder);
				}
			}
		}

		private void method_25(object sender, DoWorkEventArgs e)
		{
			string cmdText = e.Argument.ToString();
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			sqlDataConnect.OpenConnection(this.SqlSettings);
			try
			{
				new SqlCommand(cmdText, sqlDataConnect.Connection)
				{
					CommandTimeout = 0
				}.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
			finally
			{
				sqlDataConnect.CloseConnection();
			}
		}

		private void method_26(object sender, RunWorkerCompletedEventArgs e)
		{
			this.WorkerCounter--;
		}

		protected override void OnMouseWheel(MouseEventArgs mouseEventArgs_0)
		{
			UnitPoint point = ConvertCanvas.ConvertToUnit(this, new PointF((float)mouseEventArgs_0.X, (float)mouseEventArgs_0.Y));
			float num = 120f;
			float num2 = (float)Math.Abs(mouseEventArgs_0.Delta) / num;
			if (mouseEventArgs_0.Delta < 0)
			{
				if (this.Zoom > 0.25f)
				{
					this.Zoom -= 0.25f;
				}
				else
				{
					this.Zoom /= 2f;
				}
				if (this.Zoom < 0.001f)
				{
					this.Zoom = 0.001f;
				}
			}
			else
			{
				if (this.Zoom < 0.25f)
				{
					if (this.Zoom > 0.125f)
					{
						this.Zoom = 0.25f;
					}
					else
					{
						this.Zoom *= 2f;
					}
				}
				else
				{
					this.Zoom += 0.25f;
				}
				if (this.Zoom > 100f)
				{
					this.Zoom = 100f;
				}
			}
			if (point.X < (double)this.rectangleF_0.X)
			{
				point.X = (double)this.rectangleF_0.X;
			}
			if (point.Y < (double)this.rectangleF_0.Y)
			{
				point.Y = (double)this.rectangleF_0.Y;
			}
			if (point.X > (double)this.rectangleF_0.Right)
			{
				point.X = (double)this.rectangleF_0.Right;
			}
			if (point.Y > (double)this.rectangleF_0.Bottom)
			{
				point.Y = (double)this.rectangleF_0.Bottom;
			}
			PointF pointF = ConvertCanvas.ConvertToScreen(this, point);
			this.pointF_1.X = this.pointF_1.X + ((float)mouseEventArgs_0.X - pointF.X);
			this.pointF_1.Y = this.pointF_1.Y + ((float)mouseEventArgs_0.Y - pointF.Y);
			this.DoInvalidate(true);
			this.panelPassport_0.Visible = false;
		}

		protected override void OnMouseDoubleClick(MouseEventArgs mouseEventArgs_0)
		{
			UnitPoint point = ConvertCanvas.ConvertToUnit(this, new PointF((float)mouseEventArgs_0.X, (float)mouseEventArgs_0.Y));
			MouseButtons button = mouseEventArgs_0.Button;
			if (button != MouseButtons.Left)
			{
				if (button == MouseButtons.Middle)
				{
					switch (this.eCommandType_0)
					{
					case eCommandType.select:
					case eCommandType.netSelect:
					case eCommandType.move:
					case eCommandType.resizeObj:
						this.FitToScreen();
						break;
					}
				}
			}
			else
			{
				switch (this.eCommandType_0)
				{
				case eCommandType.select:
				case eCommandType.netSelect:
				case eCommandType.move:
				case eCommandType.resizeObj:
				{
					List<DrawObjectBase> hitObjects = this.GetHitObjects(point);
					if (hitObjects.Count > 0)
					{
						hitObjects[0].OnMouseDoubleClick(this, point, mouseEventArgs_0.Button);
					}
					break;
				}
				}
			}
			this.panelPassport_0.Visible = false;
		}

		protected override void OnMouseHover(EventArgs eventArgs_0)
		{
			this.eMouseControlState_0 = eMouseControlState.OnControl;
			base.OnMouseHover(eventArgs_0);
		}

		protected override void OnMouseLeave(EventArgs eventArgs_0)
		{
			base.OnMouseLeave(eventArgs_0);
			this.eMouseControlState_0 = eMouseControlState.IsLeave;
			this.labelMousePosition.Text = "";
		}

		protected override void OnDragOver(DragEventArgs drgevent)
		{
			DrawObjectBase drawObjectBase = null;
			Point point = base.PointToClient(new Point(drgevent.X, drgevent.Y));
			UnitPoint point2 = ConvertCanvas.ConvertToUnit(this, new PointF((float)point.X, (float)point.Y));
			List<DrawObjectBase> hitObjects = this.GetHitObjects(point2);
			foreach (DrawObjectBase drawObjectBase2 in hitObjects)
			{
				if (drawObjectBase2.GetType() != typeof(LineTool))
				{
					if (drawObjectBase2.GetType() != typeof(LineCellTool))
					{
						continue;
					}
				}
				drawObjectBase = drawObjectBase2;
				break;
			}
			if (drgevent.Data.GetDataPresent(typeof(GroundingTool)) && drawObjectBase != null)
			{
				drgevent.Effect = DragDropEffects.Move;
			}
			else
			{
				drgevent.Effect = DragDropEffects.None;
			}
			base.OnDragOver(drgevent);
		}

		protected override void OnDragDrop(DragEventArgs drgevent)
		{
			DrawObjectBase drawObjectBase = null;
			Point point = base.PointToClient(new Point(drgevent.X, drgevent.Y));
			UnitPoint unitPoint = ConvertCanvas.ConvertToUnit(this, new PointF((float)point.X, (float)point.Y));
			List<DrawObjectBase> hitObjects = this.GetHitObjects(unitPoint);
			foreach (DrawObjectBase drawObjectBase2 in hitObjects)
			{
				if (drawObjectBase2.GetType() != typeof(LineTool))
				{
					if (drawObjectBase2.GetType() != typeof(LineCellTool))
					{
						continue;
					}
				}
				drawObjectBase = ((LineTool)drawObjectBase2).GetHitBranch(unitPoint);
				break;
			}
			if (drgevent.Data.GetDataPresent(typeof(GroundingTool)) && drawObjectBase != null && drawObjectBase.GetType() == typeof(Branch))
			{
				GroundingTool groundingTool = (GroundingTool)drgevent.Data.GetData(typeof(GroundingTool));
				Branch branch = (Branch)drawObjectBase;
				branch.AddSwitchTool(groundingTool, unitPoint);
				groundingTool.Parent = branch;
				((DrawingLayer)this.icanvasLayer_0).AddObject(groundingTool);
			}
			this.DoInvalidate(true);
			base.OnDragDrop(drgevent);
		}

		protected override void OnResize(EventArgs eventArgs_0)
		{
			base.OnResize(eventArgs_0);
			if (this.unitPoint_0 != UnitPoint.Empty && base.Width != 0)
			{
				this.SetCenterScreen(ConvertCanvas.ConvertToScreen(this, this.unitPoint_0), false);
			}
			this.unitPoint_0 = this.CenterPointUnit();
			this.staticImage = null;
			this.DoInvalidate(true);
			if (base.GetType() == typeof(CanvasControl))
			{
				this.method_61();
			}
		}

		protected override bool IsInputKey(Keys keyData)
		{
			switch (keyData)
			{
			case Keys.Left:
			case Keys.Up:
			case Keys.Right:
			case Keys.Down:
				return true;
			default:
				return base.IsInputKey(keyData);
			}
		}

		public void RemoveSelectedObjects()
		{
			if (this.Mode == eCanvasEditingMode.Edit)
			{
				if (this.list_1 != null && MessageBox.Show("Удалить выделенные объекты из базы данных?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
				{
					Func<DrawObjectBase, bool> func = null;
					Func<DrawObjectBase, bool> func2 = null;
					CanvasControl.Class25 @class = new CanvasControl.Class25();
					@class.list_0 = new List<DrawObjectBase>();
					@class.list_1 = new List<DrawObjectBase>();
					@class.list_2 = new List<DrawObjectBase>();
					List<DrawObjectBase> list = new List<DrawObjectBase>();
					@class.list_3 = new List<DrawObjectBase>();
					List<DrawObjectBase> list2 = new List<DrawObjectBase>();
					IEnumerable<DrawObjectBase> source = this.list_1;
					if (CanvasControl.func_27 == null)
					{
						CanvasControl.func_27 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_29);
					}
					foreach (DrawObjectBase drawObjectBase in source.Where(CanvasControl.func_27))
					{
						IEnumerable<DrawObjectBase> childObjects = drawObjectBase.ChildObjects;
						if (CanvasControl.func_28 == null)
						{
							CanvasControl.func_28 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_30);
						}
						IEnumerable<DrawObjectBase> collection = childObjects.Where(CanvasControl.func_28);
						list2.AddRange(collection);
					}
					this.list_1.AddRange(list2);
					List<DrawObjectBase> list3 = @class.list_0;
					IEnumerable<DrawObjectBase> source2 = this.list_1;
					if (CanvasControl.func_29 == null)
					{
						CanvasControl.func_29 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_31);
					}
					list3.AddRange(source2.Where(CanvasControl.func_29));
					list.AddRange(this.list_1.Where(new Func<DrawObjectBase, bool>(@class.method_0)));
					List<DrawObjectBase> list4 = @class.list_3;
					IEnumerable<DrawObjectBase> source3 = list;
					if (CanvasControl.func_30 == null)
					{
						CanvasControl.func_30 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_32);
					}
					list4.AddRange(source3.Where(CanvasControl.func_30));
					list2.Clear();
					list2.AddRange(list);
					list.Clear();
					list.AddRange(list2.Where(new Func<DrawObjectBase, bool>(@class.method_1)));
					string text = string.Empty;
					IEnumerable<DrawObjectBase> source4 = list;
					if (CanvasControl.func_31 == null)
					{
						CanvasControl.func_31 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_33);
					}
					foreach (DrawObjectBase drawObjectBase2 in source4.Where(CanvasControl.func_31))
					{
						if (text != string.Empty)
						{
							text += ", ";
						}
						text += drawObjectBase2.IdBase;
					}
					SqlConnection sqlConnection = new SqlConnection(this.sqlsettings_0.GetConnectionString());
					sqlConnection.Open();
					SqlCommand sqlCommand = new SqlCommand();
					DataTable dataTable = new DataTable();
					sqlCommand.Connection = sqlConnection;
					if (text != string.Empty)
					{
						sqlCommand.CommandText = string.Format("SELECT distinct [idObjList] FROM [tP_Passport] \r\n                                                        where deleted = 0 and isActive = 1 and idObjList in ({0})", text);
						SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
						dataTable.Load(sqlDataReader);
						sqlDataReader.Close();
						using (IEnumerator enumerator3 = dataTable.Rows.GetEnumerator())
						{
							Func<DrawObjectBase, bool> func3 = null;
							CanvasControl.Class26 class2 = new CanvasControl.Class26();
							class2.class25_0 = @class;
							while (enumerator3.MoveNext())
							{
								object obj = enumerator3.Current;
								class2.dataRow_0 = (DataRow)obj;
								List<DrawObjectBase> list5 = @class.list_1;
								IEnumerable<DrawObjectBase> source5 = list;
								if (func3 == null)
								{
									func3 = new Func<DrawObjectBase, bool>(class2.method_0);
								}
								list5.Add(source5.First(func3));
							}
						}
						dataTable.Clear();
						list2.Clear();
						list2.AddRange(list);
						list.Clear();
						List<DrawObjectBase> list6 = list;
						IEnumerable<DrawObjectBase> source6 = list2;
						if (func == null)
						{
							func = new Func<DrawObjectBase, bool>(@class.method_2);
						}
						list6.AddRange(source6.Where(func));
						text = string.Empty;
						IEnumerable<DrawObjectBase> source7 = list;
						if (CanvasControl.func_32 == null)
						{
							CanvasControl.func_32 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_34);
						}
						foreach (DrawObjectBase drawObjectBase3 in source7.Where(CanvasControl.func_32))
						{
							if (text != string.Empty)
							{
								text += ", ";
							}
							text += drawObjectBase3.IdBase;
						}
					}
					if (text != string.Empty)
					{
						sqlCommand.CommandText = string.Format("SELECT  idObjList FROM tJ_Measurement where deleted = 0 and idObjList in ({0})\r\n                                                           union \r\n                                                           SELECT idBus as idObjList from tJ_MeasCable where deleted = 0 and idBus in ({0})\r\n                                                           union \r\n                                                           SELECT idCell as idObjList from tJ_MeasCable where deleted = 0 and idcell in ({0})\r\n                                                           union \r\n                                                           SELECT idBus as idObjList from tJ_MeasAmperageTransf where deleted = 0  and idBus in ({0})\r\n                                                           union \r\n                                                           SELECT idBus as idObjList from tJ_MeasCell where deleted = 0  and idBus in ({0})\r\n                                                           union \r\n                                                           SELECT idCell as idObjList from tJ_MeasCell where deleted = 0  and idcell in ({0})\r\n                                                           union \r\n                                                           SELECT idBus as idObjList from tJ_MeasVoltageTransf where deleted = 0 and idBus in ({0})", text);
						SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
						dataTable.Load(sqlDataReader);
						sqlDataReader.Close();
						using (IEnumerator enumerator5 = dataTable.Rows.GetEnumerator())
						{
							Func<DrawObjectBase, bool> func4 = null;
							CanvasControl.Class27 class3 = new CanvasControl.Class27();
							class3.class25_0 = @class;
							while (enumerator5.MoveNext())
							{
								object obj2 = enumerator5.Current;
								class3.dataRow_0 = (DataRow)obj2;
								List<DrawObjectBase> list7 = @class.list_2;
								IEnumerable<DrawObjectBase> source8 = list;
								if (func4 == null)
								{
									func4 = new Func<DrawObjectBase, bool>(class3.method_0);
								}
								list7.Add(source8.First(func4));
							}
						}
						dataTable.Clear();
						list2.Clear();
						list2.AddRange(list);
						list.Clear();
						List<DrawObjectBase> list8 = list;
						IEnumerable<DrawObjectBase> source9 = list2;
						if (func2 == null)
						{
							func2 = new Func<DrawObjectBase, bool>(@class.method_3);
						}
						list8.AddRange(source9.Where(func2));
					}
					sqlConnection.Close();
					FormCanvasRemoveTransformer formCanvasRemoveTransformer = new FormCanvasRemoveTransformer();
					if (@class.list_3.Count > 0)
					{
						string arg = string.Empty;
						if (this.TypeCanvas == eTypeCanvas.SchemeSecond)
						{
							arg = "первого уровня и будет перезагружен после перезапуска";
						}
						else
						{
							arg = "другого уровня";
						}
						bool flag = false;
						formCanvasRemoveTransformer.All = false;
						formCanvasRemoveTransformer.button_3 = false;
						DialogResult dialogResult = DialogResult.None;
						for (int i = @class.list_3.Count - 1; i >= 0; i--)
						{
							if (!flag)
							{
								formCanvasRemoveTransformer.Caption = string.Format("Удаляемый объект {1} был прогружен с {2}.\n\rПодобных объектов: {0}", i, @class.list_3[i].GetFullName(), arg);
								dialogResult = formCanvasRemoveTransformer.ShowDialog();
								flag = formCanvasRemoveTransformer.All;
							}
							if (dialogResult != DialogResult.Yes)
							{
								@class.list_3.RemoveAt(i);
							}
						}
						list.AddRange(@class.list_3);
					}
					if (@class.list_0.Count > 0)
					{
						formCanvasRemoveTransformer.button_3 = true;
						bool flag2 = false;
						DialogResult dialogResult2 = DialogResult.None;
						Dictionary<DrawObjectBase, DrawObjectBase> dictionary = new Dictionary<DrawObjectBase, DrawObjectBase>();
						for (int j = @class.list_0.Count - 1; j >= 0; j--)
						{
							DrawObjectBase drawObjectBase4 = ((LineTool)@class.list_0[j].Parent.Parent).ParRectangle();
							if (drawObjectBase4 != null)
							{
								if (!flag2)
								{
									formCanvasRemoveTransformer.Caption = string.Format("Среди удаляемых объектов обнаружен трансформатор {1}.\n\rТрансформатор может быть удалён из базы данных или убран со схемы с возможностью востановления.\n\rПодобных объектов: {0}", j, @class.list_0[j].GetFullName());
									dialogResult2 = formCanvasRemoveTransformer.ShowDialog();
									flag2 = formCanvasRemoveTransformer.All;
								}
								if (dialogResult2 != DialogResult.Yes)
								{
									if (dialogResult2 == DialogResult.No)
									{
										dictionary.Add(@class.list_0[j], drawObjectBase4);
									}
									@class.list_0.RemoveAt(j);
								}
							}
						}
						list.AddRange(@class.list_0);
						if (dictionary.Count > 0)
						{
							sqlConnection.Open();
							StringBuilder stringBuilder = new StringBuilder();
							foreach (DrawObjectBase drawObjectBase5 in dictionary.Keys)
							{
								string value = string.Format("UPDATE tSchm_ObjList set [IdParent] = {0} WHERE [ID] = {1}", dictionary[drawObjectBase5].IdBase, drawObjectBase5.IdBase);
								stringBuilder.AppendLine(value);
							}
							sqlCommand.CommandText = stringBuilder.ToString();
							sqlCommand.ExecuteNonQuery();
							sqlConnection.Close();
							this.DeleteObjects(dictionary.Keys, false);
						}
					}
					if (@class.list_1.Count > 0)
					{
						bool flag3 = false;
						formCanvasRemoveTransformer.All = false;
						formCanvasRemoveTransformer.button_3 = false;
						DialogResult dialogResult3 = DialogResult.None;
						for (int k = @class.list_1.Count - 1; k >= 0; k--)
						{
							if (!flag3)
							{
								formCanvasRemoveTransformer.Caption = string.Format("К удаляемому объекту {1} привязан пасспорт.\n\rПасспорт будет удалён.\n\rПодобных объектов: {0}", k, @class.list_1[k].GetFullName());
								dialogResult3 = formCanvasRemoveTransformer.ShowDialog();
								flag3 = formCanvasRemoveTransformer.All;
							}
							if (dialogResult3 != DialogResult.Yes)
							{
								@class.list_1.RemoveAt(k);
							}
						}
						list.AddRange(@class.list_1);
					}
					if (@class.list_2.Count > 0)
					{
						bool flag4 = false;
						formCanvasRemoveTransformer.All = false;
						formCanvasRemoveTransformer.button_3 = false;
						DialogResult dialogResult4 = DialogResult.None;
						for (int l = @class.list_2.Count - 1; l >= 0; l--)
						{
							if (!flag4)
							{
								formCanvasRemoveTransformer.Caption = string.Format("К удаляемому объекту {1} привязаны замеры.\n\rЗамеры будут удалены.\n\rПодобных объектов: {0}", l, @class.list_2[l].GetFullName());
								dialogResult4 = formCanvasRemoveTransformer.ShowDialog();
								flag4 = formCanvasRemoveTransformer.All;
							}
							if (dialogResult4 != DialogResult.Yes)
							{
								@class.list_2.RemoveAt(l);
							}
						}
						list.AddRange(@class.list_2);
					}
					this.DeleteObjects(list, true);
				}
				this.ClearSelectedObjects();
				this.DoInvalidate(true);
				this.method_39();
			}
		}

		protected override void OnKeyDown(KeyEventArgs keyEventArgs_0)
		{
			Keys modifiers = keyEventArgs_0.Modifiers;
			if (modifiers != Keys.None)
			{
				if (modifiers == Keys.Control)
				{
					Keys keyCode = keyEventArgs_0.KeyCode;
					if (keyCode <= Keys.M)
					{
						if (keyCode <= Keys.D0)
						{
							switch (keyCode)
							{
							case Keys.Left:
							case Keys.Up:
							case Keys.Right:
							case Keys.Down:
								this.method_27(keyEventArgs_0);
								return;
							default:
								if (keyCode != Keys.D0)
								{
									return;
								}
								break;
							}
						}
						else
						{
							switch (keyCode)
							{
							case Keys.A:
								this.list_1.Clear();
								foreach (ICanvasLayer canvasLayer in this.list_0)
								{
									foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
									{
										if (drawObjectBase.Visible)
										{
											drawObjectBase.Selected = true;
										}
									}
								}
								this.DoInvalidate(true);
								return;
							case Keys.B:
								return;
							case Keys.C:
								this.CopySelectedObjects();
								return;
							case Keys.D:
								this.ClearSelectedObjects();
								this.DoInvalidate(true);
								return;
							default:
								if (keyCode != Keys.M)
								{
									return;
								}
								this.VisibleCanvasSchemeMap = !this.VisibleCanvasSchemeMap;
								return;
							}
						}
					}
					else if (keyCode <= Keys.V)
					{
						if (keyCode == Keys.P)
						{
							new FormCanvasPrint
							{
								Canvas = this
							}.ShowDialog();
							return;
						}
						if (keyCode != Keys.V)
						{
							return;
						}
						if (this.Mode != eCanvasEditingMode.Edit)
						{
							return;
						}
						if (this.SelectedCount > 0)
						{
							this.PasteInObjects(this.SelectedObjects.ToList<DrawObjectBase>());
							return;
						}
						this.method_41(UnitPoint.Empty);
						return;
					}
					else if (keyCode != Keys.NumPad0)
					{
						switch (keyCode)
						{
						case Keys.Add:
							this.ZoomIn();
							return;
						case Keys.Separator:
							return;
						case Keys.Subtract:
							this.ZoomOut();
							return;
						default:
							if (keyCode != Keys.F12)
							{
								return;
							}
							return;
						}
					}
					this.FitToScreen();
					return;
				}
				if (modifiers != (Keys.Shift | Keys.Control))
				{
					return;
				}
				switch (keyEventArgs_0.KeyCode)
				{
				case Keys.Add:
					this.ZoomInSymbols();
					return;
				case Keys.Separator:
					break;
				case Keys.Subtract:
					this.ZoomOutSymbols();
					return;
				default:
					return;
				}
			}
			else
			{
				Keys keyCode2 = keyEventArgs_0.KeyCode;
				switch (keyCode2)
				{
				case Keys.Left:
				case Keys.Up:
				case Keys.Right:
				case Keys.Down:
					this.method_27(keyEventArgs_0);
					break;
				default:
					if (keyCode2 != Keys.Delete)
					{
						return;
					}
					if (this.Mode == eCanvasEditingMode.Edit)
					{
						this.RemoveSelectedObjects();
						return;
					}
					break;
				}
			}
		}

		protected override void OnKeyUp(KeyEventArgs keyEventArgs_0)
		{
			base.OnKeyUp(keyEventArgs_0);
			Keys modifiers = keyEventArgs_0.Modifiers;
			if (modifiers != Keys.None)
			{
				if (modifiers != Keys.Control)
				{
					return;
				}
				switch (keyEventArgs_0.KeyCode)
				{
				case Keys.Left:
				case Keys.Up:
				case Keys.Right:
				case Keys.Down:
					this.method_24();
					return;
				default:
					return;
				}
			}
			else
			{
				switch (keyEventArgs_0.KeyCode)
				{
				case Keys.Left:
				case Keys.Up:
				case Keys.Right:
				case Keys.Down:
					this.method_24();
					return;
				default:
					return;
				}
			}
		}

		private void method_27(KeyEventArgs keyEventArgs_0)
		{
			int num = 10;
			if (keyEventArgs_0.Modifiers == Keys.Control)
			{
				num = 1;
			}
			if (keyEventArgs_0.Modifiers == Keys.Control || keyEventArgs_0.Modifiers == Keys.None)
			{
				if (this.Mode == eCanvasEditingMode.Edit && this.SelectedCount > 0)
				{
					UnitPoint unitPoint_ = new UnitPoint(0.0, 0.0);
					switch (keyEventArgs_0.KeyCode)
					{
					case Keys.Left:
						unitPoint_ = new UnitPoint(ConvertCanvas.ConvertToUnit(this, -1f), 0.0);
						break;
					case Keys.Up:
						unitPoint_ = new UnitPoint(0.0, ConvertCanvas.ConvertToUnit(this, 1f));
						break;
					case Keys.Right:
						unitPoint_ = new UnitPoint(ConvertCanvas.ConvertToUnit(this, 1f), 0.0);
						break;
					case Keys.Down:
						unitPoint_ = new UnitPoint(0.0, ConvertCanvas.ConvertToUnit(this, -1f));
						break;
					}
					this.method_35(unitPoint_);
					return;
				}
				switch (keyEventArgs_0.KeyCode)
				{
				case Keys.Left:
					this.pointF_1.X = this.pointF_1.X - (float)num;
					break;
				case Keys.Up:
					this.pointF_1.Y = this.pointF_1.Y - (float)num;
					break;
				case Keys.Right:
					this.pointF_1.X = this.pointF_1.X + (float)num;
					break;
				case Keys.Down:
					this.pointF_1.Y = this.pointF_1.Y + (float)num;
					break;
				}
				this.pointF_2 = new PointF(0f, 0f);
				this.unitPoint_0 = this.CenterPointUnit();
				this.DoInvalidate(true);
				this.method_62();
			}
		}

		private void method_28(LineTool lineTool_0)
		{
			this.eCommandType_0 = eCommandType.draw;
			this.drawObjectBase_0 = lineTool_0;
		}

		internal void drawObjectBase_0_DrawNewObjectEvent(DrawObjectBase drawObjectBase_2, DrawObjectBase drawObjectBase_3)
		{
			this.eCommandType_0 = eCommandType.draw;
			this.drawObjectBase_0 = drawObjectBase_3;
			this.drawObjectBase_0.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
			if (drawObjectBase_2 != drawObjectBase_3)
			{
				this.drawObjectBase_0.DrawNewObjectEvent += this.drawObjectBase_0_DrawNewObjectEvent;
			}
		}

		internal void drawObjectBase_0_EndDrawEvent(DrawObjectBase drawObjectBase_2)
		{
			drawObjectBase_2.EndDrawEvent -= this.drawObjectBase_0_EndDrawEvent;
			DrawObjectsEventArgs drawObjectsEventArgs_ = new DrawObjectsEventArgs(drawObjectBase_2);
			this.OnDrawingCompleted(drawObjectsEventArgs_);
			this.drawObjectBase_0 = null;
			this.DoInvalidate(true);
		}

		private void method_29()
		{
			if (base.InvokeRequired)
			{
				CanvasControl.Delegate1 method = new CanvasControl.Delegate1(this.method_29);
				base.Invoke(method);
				return;
			}
			this.Graphics = Graphics.FromHwnd(base.Handle);
		}

		protected virtual void OnObjectsAdded(List<DrawObjectBase> addObjects)
		{
			if (this.drawObjectEventHandler_0 != null)
			{
				this.drawObjectEventHandler_0(this, new DrawObjectsEventArgs(addObjects));
			}
			this.method_29();
			IEnumerable<RectangleF> enumerable = addObjects.Select(new Func<DrawObjectBase, RectangleF>(this.method_91));
			IEnumerable<RectangleF> source = enumerable;
			if (CanvasControl.func_33 == null)
			{
				CanvasControl.func_33 = new Func<RectangleF, float>(CanvasControl.smethod_35);
			}
			float num = source.Min(CanvasControl.func_33);
			IEnumerable<RectangleF> source2 = enumerable;
			if (CanvasControl.func_34 == null)
			{
				CanvasControl.func_34 = new Func<RectangleF, float>(CanvasControl.smethod_36);
			}
			float num2 = source2.Min(CanvasControl.func_34);
			IEnumerable<RectangleF> source3 = enumerable;
			if (CanvasControl.func_35 == null)
			{
				CanvasControl.func_35 = new Func<RectangleF, float>(CanvasControl.smethod_37);
			}
			float num3 = source3.Max(CanvasControl.func_35);
			IEnumerable<RectangleF> source4 = enumerable;
			if (CanvasControl.func_36 == null)
			{
				CanvasControl.func_36 = new Func<RectangleF, float>(CanvasControl.smethod_38);
			}
			float num4 = source4.Max(CanvasControl.func_36);
			RectangleF rectangleF = new RectangleF(num, num2, num3 - num, num4 - num2);
			if (this.rectangleF_0 == RectangleF.Empty)
			{
				this.rectangleF_0 = rectangleF;
			}
			else
			{
				if (this.rectangleF_0.X > rectangleF.X)
				{
					this.rectangleF_0.Width = this.rectangleF_0.Width + (this.rectangleF_0.X - rectangleF.X);
					this.rectangleF_0.X = rectangleF.X;
				}
				if (this.rectangleF_0.Y > rectangleF.Y)
				{
					this.rectangleF_0.Height = this.rectangleF_0.Height + (this.rectangleF_0.Y - rectangleF.Y);
					this.rectangleF_0.Y = rectangleF.Y;
				}
				if (this.rectangleF_0.X + this.rectangleF_0.Width < rectangleF.X + rectangleF.Width)
				{
					this.rectangleF_0.Width = this.rectangleF_0.Width + (rectangleF.X + rectangleF.Width - (this.rectangleF_0.X + this.rectangleF_0.Width));
				}
				if (this.rectangleF_0.Y + this.rectangleF_0.Height < rectangleF.Y + rectangleF.Height)
				{
					this.rectangleF_0.Height = this.rectangleF_0.Height + (rectangleF.Y + rectangleF.Height - (this.rectangleF_0.Y + this.rectangleF_0.Height));
				}
			}
			foreach (DrawObjectBase drawObjectBase in addObjects)
			{
				drawObjectBase.DrawNewObjectEvent += this.drawObjectBase_0_DrawNewObjectEvent;
				if (drawObjectBase.GetType() == typeof(LineTool))
				{
					goto IL_2CF;
				}
				if (drawObjectBase.GetType() == typeof(LineCellTool))
				{
					goto IL_2CF;
				}
				if (drawObjectBase.GetType().BaseType == typeof(ObjectOnLine))
				{
					((ObjectOnLine)drawObjectBase).OnChanged += this.method_33;
				}
				IL_2FF:
				drawObjectBase.ErrorEvent += this.method_30;
				drawObjectBase.SelectedChanged += this.method_45;
				continue;
				IL_2CF:
				((LineTool)drawObjectBase).StateAdded += this.method_32;
				((LineTool)drawObjectBase).StateRemoved += this.method_31;
				goto IL_2FF;
			}
		}

		protected virtual void OnObjectsRemoved(List<DrawObjectBase> removeObjects)
		{
			if (this.drawObjectEventHandler_1 != null)
			{
				this.drawObjectEventHandler_1(this, new DrawObjectsEventArgs(removeObjects));
			}
			foreach (DrawObjectBase drawObjectBase in removeObjects)
			{
				if (drawObjectBase.GetType() == typeof(LineTool))
				{
					goto IL_85;
				}
				if (drawObjectBase.GetType() == typeof(LineCellTool))
				{
					goto IL_85;
				}
				if (drawObjectBase.GetType().BaseType == typeof(ObjectOnLine))
				{
					((ObjectOnLine)drawObjectBase).OnChanged -= this.method_33;
				}
				IL_B3:
				drawObjectBase.ErrorEvent -= this.method_30;
				drawObjectBase.SelectedChanged -= this.method_45;
				continue;
				IL_85:
				((LineTool)drawObjectBase).StateAdded -= this.method_32;
				((LineTool)drawObjectBase).StateRemoved -= this.method_31;
				goto IL_B3;
			}
			this.method_34();
		}

		protected virtual void OnObjectsResized(DrawObjectsEventArgs drawObjectsEventArgs_0)
		{
			if (this.drawObjectEventHandler_2 != null)
			{
				this.drawObjectEventHandler_2(this, drawObjectsEventArgs_0);
			}
			this.method_29();
			IEnumerable<RectangleF> enumerable = drawObjectsEventArgs_0.Objects.Select(new Func<DrawObjectBase, RectangleF>(this.method_92));
			IEnumerable<RectangleF> source = enumerable;
			if (CanvasControl.func_37 == null)
			{
				CanvasControl.func_37 = new Func<RectangleF, float>(CanvasControl.smethod_39);
			}
			float num = source.Min(CanvasControl.func_37);
			IEnumerable<RectangleF> source2 = enumerable;
			if (CanvasControl.func_38 == null)
			{
				CanvasControl.func_38 = new Func<RectangleF, float>(CanvasControl.smethod_40);
			}
			float num2 = source2.Min(CanvasControl.func_38);
			IEnumerable<RectangleF> source3 = enumerable;
			if (CanvasControl.func_39 == null)
			{
				CanvasControl.func_39 = new Func<RectangleF, float>(CanvasControl.smethod_41);
			}
			float num3 = source3.Max(CanvasControl.func_39);
			IEnumerable<RectangleF> source4 = enumerable;
			if (CanvasControl.func_40 == null)
			{
				CanvasControl.func_40 = new Func<RectangleF, float>(CanvasControl.smethod_42);
			}
			float num4 = source4.Max(CanvasControl.func_40);
			RectangleF rectangleF = new RectangleF(num, num2, num3 - num, num4 - num2);
			if (this.rectangleF_0 == RectangleF.Empty)
			{
				this.rectangleF_0 = rectangleF;
				return;
			}
			if (this.rectangleF_0.X > rectangleF.X)
			{
				this.rectangleF_0.Width = this.rectangleF_0.Width + (this.rectangleF_0.X - rectangleF.X);
				this.rectangleF_0.X = rectangleF.X;
			}
			if (this.rectangleF_0.Y > rectangleF.Y)
			{
				this.rectangleF_0.Height = this.rectangleF_0.Height + (this.rectangleF_0.Y - rectangleF.Y);
				this.rectangleF_0.Y = rectangleF.Y;
			}
			if (this.rectangleF_0.X + this.rectangleF_0.Width < rectangleF.X + rectangleF.Width)
			{
				this.rectangleF_0.Width = this.rectangleF_0.Width + (rectangleF.X + rectangleF.Width - (this.rectangleF_0.X + this.rectangleF_0.Width));
			}
			if (this.rectangleF_0.Y + this.rectangleF_0.Height < rectangleF.Y + rectangleF.Height)
			{
				this.rectangleF_0.Height = this.rectangleF_0.Height + (rectangleF.Y + rectangleF.Height - (this.rectangleF_0.Y + this.rectangleF_0.Height));
			}
		}

		internal void method_30(DrawObjectBase drawObjectBase_2)
		{
			this.list_5.Add(drawObjectBase_2);
		}

		internal void method_31(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
			LineToolState state = lineToolEventArgs_0.state;
			this.list_4.Remove(state);
			this.lineToolEventHandler_1(lineTool_0, lineToolEventArgs_0);
		}

		internal void method_32(LineTool lineTool_0, LineToolEventArgs lineToolEventArgs_0)
		{
			LineToolState state = lineToolEventArgs_0.state;
			this.list_4.Add(state);
			this.lineToolEventHandler_0(lineTool_0, lineToolEventArgs_0);
		}

		internal void method_33(object sender, EventArgs e)
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(sender, e);
			}
		}

		private void method_34()
		{
			Func<DrawObjectBase, RectangleF> func = null;
			this.method_29();
			float num = float.NaN;
			float num2 = float.NaN;
			float num3 = float.NaN;
			float num4 = float.NaN;
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				if (canvasLayer.Objects.Count<DrawObjectBase>() != 0)
				{
					IEnumerable<DrawObjectBase> objects = canvasLayer.Objects;
					if (CanvasControl.func_41 == null)
					{
						CanvasControl.func_41 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_43);
					}
					IEnumerable<DrawObjectBase> source = objects.Where(CanvasControl.func_41);
					if (func == null)
					{
						func = new Func<DrawObjectBase, RectangleF>(this.method_93);
					}
					IEnumerable<RectangleF> enumerable = source.Select(func);
					IEnumerable<RectangleF> source2 = enumerable;
					if (CanvasControl.func_42 == null)
					{
						CanvasControl.func_42 = new Func<RectangleF, bool>(CanvasControl.smethod_44);
					}
					IEnumerable<RectangleF> source3 = source2.Where(CanvasControl.func_42);
					if (CanvasControl.func_43 == null)
					{
						CanvasControl.func_43 = new Func<RectangleF, float>(CanvasControl.smethod_45);
					}
					float num5 = source3.Min(CanvasControl.func_43);
					if (float.IsNaN(num) || num > num5)
					{
						num = num5;
					}
					IEnumerable<RectangleF> source4 = enumerable;
					if (CanvasControl.func_44 == null)
					{
						CanvasControl.func_44 = new Func<RectangleF, bool>(CanvasControl.smethod_46);
					}
					IEnumerable<RectangleF> source5 = source4.Where(CanvasControl.func_44);
					if (CanvasControl.func_45 == null)
					{
						CanvasControl.func_45 = new Func<RectangleF, float>(CanvasControl.smethod_47);
					}
					num5 = source5.Min(CanvasControl.func_45);
					if (float.IsNaN(num2) || num2 > num5)
					{
						num2 = num5;
					}
					IEnumerable<RectangleF> source6 = enumerable;
					if (CanvasControl.func_46 == null)
					{
						CanvasControl.func_46 = new Func<RectangleF, bool>(CanvasControl.smethod_48);
					}
					IEnumerable<RectangleF> source7 = source6.Where(CanvasControl.func_46);
					if (CanvasControl.func_47 == null)
					{
						CanvasControl.func_47 = new Func<RectangleF, float>(CanvasControl.smethod_49);
					}
					num5 = source7.Max(CanvasControl.func_47);
					if (float.IsNaN(num3) || num3 < num5)
					{
						num3 = num5;
					}
					IEnumerable<RectangleF> source8 = enumerable;
					if (CanvasControl.func_48 == null)
					{
						CanvasControl.func_48 = new Func<RectangleF, bool>(CanvasControl.smethod_50);
					}
					IEnumerable<RectangleF> source9 = source8.Where(CanvasControl.func_48);
					if (CanvasControl.func_49 == null)
					{
						CanvasControl.func_49 = new Func<RectangleF, float>(CanvasControl.smethod_51);
					}
					num5 = source9.Max(CanvasControl.func_49);
					if (float.IsNaN(num4) || num4 < num5)
					{
						num4 = num5;
					}
				}
			}
			if (float.IsNaN(num))
			{
				num = 0f;
			}
			if (float.IsNaN(num2))
			{
				num2 = 0f;
			}
			if (float.IsNaN(num3))
			{
				num3 = 0f;
			}
			if (float.IsNaN(num4))
			{
				num4 = 0f;
			}
			this.rectangleF_0 = new RectangleF(num, num2, num3 - num, num4 - num2);
		}

		protected void HandleSelection(List<DrawObjectBase> selected)
		{
			bool flag = false;
			flag = true;
			if (Control.ModifierKeys != Keys.Control)
			{
				this.ClearSelectedObjects();
			}
			if (selected != null)
			{
				foreach (DrawObjectBase drawObjectBase in selected)
				{
					if (drawObjectBase.Selected)
					{
						this.DeSelectObject(drawObjectBase);
					}
					else
					{
						this.SelectObject(drawObjectBase);
					}
				}
			}
			if (flag)
			{
				this.DoInvalidate(true);
			}
		}

		private void method_35(UnitPoint unitPoint_3)
		{
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				drawObjectBase.Move(unitPoint_3, true);
			}
			this.DoInvalidate(true);
		}

		public bool HandleMouseMoveForMove(UnitPoint mouseunitpoint)
		{
			double double_ = mouseunitpoint.X - this.unitPoint_1.X;
			double double_2 = mouseunitpoint.Y - this.unitPoint_1.Y;
			if (Control.ModifierKeys == Keys.Shift)
			{
				UnitPoint unitPoint = ConvertCanvas.ConvertToUnit(this, this.pointF_0);
				double value = unitPoint.X - this.unitPoint_1.X;
				double value2 = unitPoint.Y - this.unitPoint_1.Y;
				if (Math.Abs(value) > Math.Abs(value2))
				{
					double_2 = 0.0;
				}
				else if (Math.Abs(value) < Math.Abs(value2))
				{
					double_ = 0.0;
				}
			}
			UnitPoint offset = new UnitPoint(double_, double_2);
			this.unitPoint_1 = mouseunitpoint;
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				drawObjectBase.Move(offset, true);
				DrawObjectsEventArgs drawObjectsEventArgs = new DrawObjectsEventArgs(drawObjectBase);
				drawObjectsEventArgs.Offset = offset;
				drawObjectsEventArgs.ChangesMode = UndoRedoManager.ChangesMode.Move;
				drawObjectsEventArgs.SelectedMove = true;
				this.drawObjectEventHandler_5(this, drawObjectsEventArgs);
			}
			return true;
		}

		internal void method_36(RectangleF rectangleF_2)
		{
			if (this.staticImage == null)
			{
				return;
			}
			Graphics graphics = Graphics.FromHwnd(base.Handle);
			if (rectangleF_2.X < 0f)
			{
				rectangleF_2.X = 0f;
			}
			if (rectangleF_2.X > (float)this.staticImage.Width)
			{
				rectangleF_2.X = 0f;
			}
			if (rectangleF_2.Y < 0f)
			{
				rectangleF_2.Y = 0f;
			}
			if (rectangleF_2.Y > (float)this.staticImage.Height)
			{
				rectangleF_2.Y = 0f;
			}
			if (rectangleF_2.Width > (float)this.staticImage.Width || rectangleF_2.Width < 0f)
			{
				rectangleF_2.Width = (float)this.staticImage.Width;
			}
			if (rectangleF_2.Height > (float)this.staticImage.Height || rectangleF_2.Height < 0f)
			{
				rectangleF_2.Height = (float)this.staticImage.Height;
			}
			graphics.DrawImage(this.staticImage, rectangleF_2, rectangleF_2, GraphicsUnit.Pixel);
			graphics.Dispose();
		}

		private void method_37(ISnapPoint isnapPoint_1)
		{
			if (isnapPoint_1 == null)
			{
				return;
			}
			this.graphics_0 = Graphics.FromHwnd(base.Handle);
			isnapPoint_1.Draw(this);
		}

		private void method_38(DrawObjectBase drawObjectBase_2)
		{
			if (drawObjectBase_2 == null)
			{
				return;
			}
			this.graphics_0 = Graphics.FromHwnd(base.Handle);
			RectangleF unitrect = ConvertCanvas.ConvertToScreenNormalized(this, drawObjectBase_2.GetBoundingRect(this, true));
			drawObjectBase_2.Draw(this, unitrect, eDrawMode.Color);
		}

		public void CommandPan()
		{
			this.eCommandType_0 = eCommandType.const_2;
			this.method_39();
		}

		public void CommandDrawTool(string drawObjectId)
		{
			this.canvasFrame_0 = null;
			this.eCommandType_0 = eCommandType.draw;
			this.string_3 = drawObjectId;
			this.method_39();
		}

		public void CommandEscape()
		{
			this.drawObjectBase_0 = null;
			this.isnapPoint_0 = null;
			this.canvasFrame_0 = null;
			this.eCommandType_0 = eCommandType.select;
			this.DoInvalidate(true);
			this.method_39();
		}

		public void CommandPattern(DrawingLayer pattern)
		{
			this.drawObjectBase_0 = null;
			this.isnapPoint_0 = null;
			this.canvasFrame_0 = null;
			this.eCommandType_0 = eCommandType.pattern;
			this.drawingLayer_0 = pattern;
			this.method_39();
		}

		public void CommandZoomWindow()
		{
			this.drawObjectBase_0 = null;
			this.isnapPoint_0 = null;
			this.eCommandType_0 = eCommandType.zoomWindow;
			this.DoInvalidate(true);
			this.method_39();
		}

		public void CommandDrawFrame()
		{
			this.drawObjectBase_0 = null;
			this.isnapPoint_0 = null;
			this.eCommandType_0 = eCommandType.drawframe;
			this.DoInvalidate(true);
			this.method_39();
		}

		public void CommandFrame()
		{
			this.drawObjectBase_0 = null;
			this.isnapPoint_0 = null;
			this.eCommandType_0 = eCommandType.frame;
			this.DoInvalidate(true);
			this.method_39();
		}

		private void method_39()
		{
			this.Cursor = this.class95_0.method_2(this.eCommandType_0);
		}

		private void method_40()
		{
			new Cursor(Resources.cursor_hand.GetHicon());
			new Cursor(Resources.cursor_drag_hand.GetHicon());
			this.class95_0.method_0(eCommandType.select, Cursors.Arrow);
			this.class95_0.method_0(eCommandType.draw, Cursors.Cross);
			this.class95_0.method_0(eCommandType.pattern, Cursors.Cross);
			this.class95_0.method_0(eCommandType.const_2, Cursors.Hand);
			this.class95_0.method_0(eCommandType.move, Cursors.SizeAll);
			this.class95_0.method_0(eCommandType.resizeObj, Cursors.Cross);
			this.class95_0.method_0(eCommandType.zoomWindow, Cursors.Cross);
			this.class95_0.method_0(eCommandType.drawframe, Cursors.Cross);
			this.method_39();
		}

		public void CopySelectedObjects()
		{
			this.list_7.Clear();
			foreach (DrawObjectBase item in this.SelectedObjects)
			{
				this.list_7.Add(item);
			}
		}

		public void PasteInObjects(List<DrawObjectBase> destinationObjects)
		{
			List<DrawObjectBase> list = CopyPasteCanvasObjects.PasteInObjects(destinationObjects, this.list_7);
			if (list.Count > 0)
			{
				this.ClearSelectedObjects();
				List<DrawObjectBase> list2 = new List<DrawObjectBase>();
				foreach (DrawObjectBase drawObjectBase in list)
				{
					this.AddObject(this.ActiveLayer, drawObjectBase);
					drawObjectBase.CreateUniqueCopyName();
					drawObjectBase.Save(false, true);
					list2.Add(drawObjectBase);
				}
				UndoRedoManager.RegistrarOfChanges changes = new UndoRedoManager.RegistrarOfChanges(list2, UndoRedoManager.ChangesMode.AddObject);
				this.undoRedoManager.HappenedChange(changes);
				this.DoInvalidate(true);
			}
		}

		private void method_41(UnitPoint unitPoint_3)
		{
			List<DrawObjectBase> list = CopyPasteCanvasObjects.PasteSelectedObjects(this.list_7, unitPoint_3);
			if (list.Count > 0)
			{
				this.ClearSelectedObjects();
				List<DrawObjectBase> list2 = new List<DrawObjectBase>();
				foreach (DrawObjectBase drawObjectBase in list)
				{
					this.AddObject(this.ActiveLayer, drawObjectBase);
					drawObjectBase.CreateUniqueCopyName();
					drawObjectBase.Save(false, true);
					list2.Add(drawObjectBase);
				}
				UndoRedoManager.RegistrarOfChanges changes = new UndoRedoManager.RegistrarOfChanges(list2, UndoRedoManager.ChangesMode.AddObject);
				this.undoRedoManager.HappenedChange(changes);
				this.DoInvalidate(true);
			}
		}

		public void SaveTraining(string nameTraining)
		{
			SqlConnection connection = new SqlConnection(SqlDataConnect.GetConnectionString(this.SqlSettings));
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml("<nameTraining Name = " + nameTraining + "></nameTraining>");
			XmlNode xmlNode = xmlDocument.SelectSingleNode("nameTraining");
			IEnumerable<DrawObjectBase> objects = this.icanvasLayer_0.Objects;
			if (CanvasControl.func_50 == null)
			{
				CanvasControl.func_50 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_52);
			}
			foreach (DrawObjectBase drawObjectBase in objects.Where(CanvasControl.func_50))
			{
				XmlElement xmlElement = xmlDocument.CreateElement("sch_switch");
				xmlElement.SetAttribute("id", drawObjectBase.IdBase.ToString());
				xmlElement.SetAttribute("On", ((ObjectOnLine)drawObjectBase).On.ToString());
				xmlNode.AppendChild(xmlElement);
			}
			string text = "select top 1 * from tSchm_TrainingSchema where = Name" + nameTraining;
			SqlCommand sqlCommand = new SqlCommand(text, connection);
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			if (sqlDataReader.Read())
			{
				text = "update tSchm_TrainingSchema set TrainingXml = '" + xmlDocument.InnerXml + "' where id = " + sqlDataReader["id"].ToString();
				sqlDataReader.Close();
				sqlCommand.CommandText = text;
				sqlCommand.ExecuteNonQuery();
				return;
			}
			sqlDataReader.Close();
			text = string.Concat(new string[]
			{
				"insert into tSchm_TrainingSchema (Name , TrainingXml) values ('",
				nameTraining,
				"', '",
				xmlDocument.InnerXml,
				"')"
			});
			sqlCommand.CommandText = text;
			sqlCommand.ExecuteNonQuery();
		}

		public void LoadTraining(string nameTraining)
		{
			SqlConnection connection = new SqlConnection(SqlDataConnect.GetConnectionString(this.SqlSettings));
			string cmdText = "select top 1 * from tSchm_TrainingSchema where = name" + nameTraining;
			SqlCommand sqlCommand = new SqlCommand(cmdText, connection);
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			XmlDocument xmlDocument = new XmlDocument();
			if (sqlDataReader.Read())
			{
				xmlDocument.Load(sqlDataReader["TrainingXml"].ToString());
				XmlNode xmlNode = xmlDocument.SelectSingleNode("nameTraining");
				XmlNodeList xmlNodeList = xmlNode.SelectNodes("sch_switch");
				foreach (object obj in xmlNodeList)
				{
					XmlNode xmlNode2 = (XmlNode)obj;
					try
					{
						CanvasControl.Class28 @class = new CanvasControl.Class28();
						@class.int_0 = Convert.ToInt32(xmlNode2.Attributes["id"].Value);
						DrawObjectBase drawObjectBase = this.icanvasLayer_0.Objects.First(new Func<DrawObjectBase, bool>(@class.method_0));
						((ObjectOnLine)drawObjectBase).On = Convert.ToBoolean(xmlNode2.Attributes["On"].Value);
					}
					catch
					{
					}
				}
			}
		}

		private void method_42(UnitPoint unitPoint_3)
		{
			RectangleF rectangleF_ = Rectangle.Empty;
			ISnapPoint snapPoint = null;
			if (this.bool_1)
			{
				snapPoint = this.SnapPoint(unitPoint_3, null, null);
			}
			if (snapPoint == null && this.bool_1)
			{
				snapPoint = this.GridLayer.SnapPoint(this, unitPoint_3, null);
			}
			if (this.isnapPoint_0 != null && (snapPoint == null || snapPoint.SnapPoint != this.isnapPoint_0.SnapPoint || this.isnapPoint_0.GetType() != snapPoint.GetType()))
			{
				rectangleF_ = ConvertCanvas.ConvertToScreenNormalized(this, this.isnapPoint_0.BoundingRect);
				rectangleF_.Inflate(2f, 2f);
				this.method_36(rectangleF_);
				this.isnapPoint_0 = snapPoint;
			}
			Rectangle rc = new Rectangle((int)rectangleF_.Location.X, (int)rectangleF_.Location.Y, (int)rectangleF_.Width, (int)rectangleF_.Height);
			if (this.eCommandType_0 == eCommandType.move)
			{
				base.Invalidate(rc);
			}
			if (this.isnapPoint_0 == null)
			{
				this.isnapPoint_0 = snapPoint;
			}
			if (this.isnapPoint_0 != null)
			{
				this.method_37(this.isnapPoint_0);
			}
		}

		public void OnSimulate()
		{
			IEnumerable<DrawObjectBase> objects = this.icanvasLayer_0.Objects;
			if (CanvasControl.func_51 == null)
			{
				CanvasControl.func_51 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_53);
			}
			foreach (DrawObjectBase drawObjectBase in objects.Where(CanvasControl.func_51))
			{
				((ShinaTool)drawObjectBase).OnAmperage = true;
			}
		}

		public void OffSimulate()
		{
			IEnumerable<DrawObjectBase> objects = this.icanvasLayer_0.Objects;
			if (CanvasControl.func_52 == null)
			{
				CanvasControl.func_52 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_54);
			}
			foreach (DrawObjectBase drawObjectBase in objects.Where(CanvasControl.func_52))
			{
				((ShinaTool)drawObjectBase).OnAmperage = false;
			}
		}

		public void RefreshSimulate()
		{
			this.OffSimulate();
			this.OnSimulate();
		}

		public void SendMessage(string messageText, eMessageType messageType)
		{
			this.canvasMessageEventHandler_0(this, new CanvasMessageEventArgs(messageText, messageType));
		}

		public void SendMessage(DrawObjectBase messageObject, string messageText, eMessageType messageType)
		{
			this.canvasMessageEventHandler_0(this, new CanvasMessageEventArgs(messageObject, messageText, messageType));
		}

		public void SendMessage(List<DrawObjectBase> messageObjects, string messageText, eMessageType messageType)
		{
			this.canvasMessageEventHandler_0(this, new CanvasMessageEventArgs(messageObjects, messageText, messageType));
		}

		public void SendMessage(List<DrawObjectBase> messageObjects, eMessageType messageType, OPCMessage telemetryMessage)
		{
			this.canvasMessageEventHandler_0(this, new CanvasMessageEventArgs(messageObjects, messageType, telemetryMessage));
		}

		public void SendMessage(DrawObjectBase messageObject, string messageText, DataTable logDispatcher)
		{
			this.canvasMessageEventHandler_0(this, new CanvasMessageEventArgs(messageObject, messageText, eMessageType.LogDispatcher, logDispatcher));
		}

		public ISnapPoint SnapPoint(UnitPoint point, Type[] runningsnaptypes, Type usersnaptype)
		{
			foreach (ICanvasLayer canvasLayer in this.list_0)
			{
				DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
				foreach (DrawObjectBase drawObjectBase in drawingLayer.Objects)
				{
					if (this.drawObjectBase_0 != null && this.drawObjectBase_0 == drawObjectBase)
					{
						break;
					}
					if ((this.drawObjectBase_1 == null || this.drawObjectBase_1 != drawObjectBase) && (this.drawObjectBase_1 == null || !this.drawObjectBase_1.HaveContact(drawObjectBase)) && drawObjectBase.GetType().BaseType != typeof(ObjectOnLine))
					{
						ISnapPoint snapPoint = drawObjectBase.SnapPoint(this, point, null, runningsnaptypes, usersnaptype);
						if (snapPoint != null)
						{
							return snapPoint;
						}
					}
				}
			}
			return null;
		}

		public void DeleteObjects(IEnumerable<DrawObjectBase> objects, bool delSql)
		{
			foreach (ICanvasLayer canvasLayer in this.list_0)
			{
				((DrawingLayer)canvasLayer).DeleteObjects(objects, delSql);
			}
		}

		public float ScreenHeight()
		{
			return (float)(ConvertCanvas.ConvertToUnit(this, (float)base.ClientRectangle.Height) / (double)this.Zoom);
		}

		public void SetCenter(UnitPoint unitPoint)
		{
			PointF screenPoint = ConvertCanvas.ConvertToScreen(this, unitPoint);
			this.SetCenterScreen(screenPoint, false);
		}

		protected void SetCenterScreen(PointF screenPoint, bool setCursor)
		{
			float num = (float)(base.ClientRectangle.Width / 2);
			this.pointF_1.X = this.pointF_1.X + (num - screenPoint.X);
			float num2 = (float)(this.statusStrip.Visible ? ((base.ClientRectangle.Height - this.statusStrip.Height) / 2) : (base.ClientRectangle.Height / 2));
			this.pointF_1.Y = this.pointF_1.Y + (num2 - screenPoint.Y);
			this.unitPoint_0 = this.CenterPointUnit();
			this.method_62();
			if (setCursor)
			{
				Cursor.Position = base.PointToScreen(new Point((int)num, (int)num2));
			}
			base.Invalidate();
		}

		internal void method_43(RectangleF rectangleF_2, bool bool_12)
		{
			if (rectangleF_2.Width <= 0f)
			{
				rectangleF_2.Width = 1f;
			}
			if (rectangleF_2.Height <= 0f)
			{
				rectangleF_2.Height = 1f;
			}
			if (bool_12)
			{
				RectangleF rectangleF = ConvertCanvas.ConvertToUnitNormalized(this, base.ClientRectangle);
				float num;
				if (rectangleF_2.Height / rectangleF_2.Width <= rectangleF.Height / rectangleF.Width)
				{
					num = 1.1f * rectangleF_2.Width / rectangleF.Width;
				}
				else
				{
					num = 1.1f * rectangleF_2.Height / rectangleF.Height;
				}
				this.Zoom /= num;
			}
			PointF pointF = new PointF(rectangleF_2.X + rectangleF_2.Width / 2f, rectangleF_2.Y + rectangleF_2.Height / 2f);
			this.SetCenter(new UnitPoint(pointF));
			this.DoInvalidate(true);
		}

		public bool SetObjectsInCenterScreen(List<int> idObjects, bool adaptZoom, CanvasControl.SetObjectsInCenterScreenOptions backlight)
		{
			Func<DrawObjectBase, bool> func = null;
			CanvasControl.Class29 @class = new CanvasControl.Class29();
			@class.list_0 = idObjects;
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				List<DrawObjectBase> list2 = list;
				IEnumerable<DrawObjectBase> objects = canvasLayer.Objects;
				if (func == null)
				{
					func = new Func<DrawObjectBase, bool>(@class.method_0);
				}
				list2.AddRange(objects.Where(func));
			}
			if (list.Count > 0)
			{
				this.SetObjectsInCenterScreen(list, adaptZoom, backlight);
				return true;
			}
			return false;
		}

		public void SetObjectsInCenterScreen(List<DrawObjectBase> drawObjects, bool adaptZoom, CanvasControl.SetObjectsInCenterScreenOptions option)
		{
			if (drawObjects.Count == 0)
			{
				return;
			}
			this.Graphics = Graphics.FromHwnd(base.Handle);
			if (option != CanvasControl.SetObjectsInCenterScreenOptions.none)
			{
				this.ClearSelectedObjects();
				this.ClearFlashingObjects();
			}
			float num = float.NaN;
			float num2 = float.NaN;
			float num3 = float.NaN;
			float num4 = float.NaN;
			List<RectangleF> list = new List<RectangleF>();
			foreach (DrawObjectBase drawObjectBase in drawObjects)
			{
				switch (option)
				{
				case CanvasControl.SetObjectsInCenterScreenOptions.select:
					this.SelectObject(drawObjectBase);
					break;
				case CanvasControl.SetObjectsInCenterScreenOptions.flashing:
					this.AddFlashObject(drawObjectBase);
					break;
				}
				list.Add(drawObjectBase.GetBoundingRect(this, false));
				if ((drawObjectBase is ShinaTool || drawObjectBase is LineCellTool) && drawObjectBase.Parent != null && drawObjectBase.Parent.Visible)
				{
					list.Add(drawObjectBase.Parent.GetBoundingRect(this, false));
				}
			}
			IEnumerable<RectangleF> source = list;
			if (CanvasControl.func_53 == null)
			{
				CanvasControl.func_53 = new Func<RectangleF, bool>(CanvasControl.smethod_55);
			}
			IEnumerable<RectangleF> source2 = source.Where(CanvasControl.func_53);
			if (CanvasControl.func_54 == null)
			{
				CanvasControl.func_54 = new Func<RectangleF, float>(CanvasControl.smethod_56);
			}
			float num5 = source2.Min(CanvasControl.func_54);
			if (float.IsNaN(num) || num > num5)
			{
				num = num5;
			}
			IEnumerable<RectangleF> source3 = list;
			if (CanvasControl.func_55 == null)
			{
				CanvasControl.func_55 = new Func<RectangleF, bool>(CanvasControl.smethod_57);
			}
			IEnumerable<RectangleF> source4 = source3.Where(CanvasControl.func_55);
			if (CanvasControl.func_56 == null)
			{
				CanvasControl.func_56 = new Func<RectangleF, float>(CanvasControl.smethod_58);
			}
			num5 = source4.Min(CanvasControl.func_56);
			if (float.IsNaN(num2) || num2 > num5)
			{
				num2 = num5;
			}
			IEnumerable<RectangleF> source5 = list;
			if (CanvasControl.func_57 == null)
			{
				CanvasControl.func_57 = new Func<RectangleF, bool>(CanvasControl.smethod_59);
			}
			IEnumerable<RectangleF> source6 = source5.Where(CanvasControl.func_57);
			if (CanvasControl.func_58 == null)
			{
				CanvasControl.func_58 = new Func<RectangleF, float>(CanvasControl.smethod_60);
			}
			num5 = source6.Max(CanvasControl.func_58);
			if (float.IsNaN(num3) || num3 < num5)
			{
				num3 = num5;
			}
			IEnumerable<RectangleF> source7 = list;
			if (CanvasControl.func_59 == null)
			{
				CanvasControl.func_59 = new Func<RectangleF, bool>(CanvasControl.smethod_61);
			}
			IEnumerable<RectangleF> source8 = source7.Where(CanvasControl.func_59);
			if (CanvasControl.func_60 == null)
			{
				CanvasControl.func_60 = new Func<RectangleF, float>(CanvasControl.smethod_62);
			}
			num5 = source8.Max(CanvasControl.func_60);
			if (float.IsNaN(num4) || num4 < num5)
			{
				num4 = num5;
			}
			if (float.IsNaN(num))
			{
				num = 0f;
			}
			if (float.IsNaN(num2))
			{
				num2 = 0f;
			}
			if (float.IsNaN(num3))
			{
				num3 = 0f;
			}
			if (float.IsNaN(num4))
			{
				num4 = 0f;
			}
			RectangleF rectangleF_ = new RectangleF(num, num2, num3 - num, num4 - num2);
			this.method_43(rectangleF_, adaptZoom);
		}

		public void SetObjectsInCenterScreen(DrawObjectBase drawObject, bool adaptZoom, CanvasControl.SetObjectsInCenterScreenOptions backlight)
		{
			this.SetObjectsInCenterScreen(new List<DrawObjectBase>
			{
				drawObject
			}, adaptZoom, backlight);
		}

		internal PointTool method_44(UnitPoint unitPoint_3)
		{
			foreach (ICanvasLayer canvasLayer in this.list_0.Reverse<ICanvasLayer>())
			{
				if (canvasLayer.Visible)
				{
					foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects.Reverse<DrawObjectBase>())
					{
						if (this.drawObjectBase_0 != drawObjectBase && this.drawObjectBase_1 != drawObjectBase && (drawObjectBase.GetType() == typeof(LineCellTool) || drawObjectBase.GetType() == typeof(LineTool)))
						{
							foreach (PointTool pointTool in ((LineTool)drawObjectBase).Ends)
							{
								if (pointTool.PointInObject(unitPoint_3))
								{
									return pointTool;
								}
							}
						}
					}
				}
			}
			return null;
		}

		public UnitPoint CenterPointUnit()
		{
			UnitPoint unitPoint = ConvertCanvas.ConvertToUnit(this, new PointF(0f, 0f));
			UnitPoint unitPoint2 = ConvertCanvas.ConvertToUnit(this, new PointF((float)base.ClientRectangle.Width, (float)base.ClientRectangle.Height));
			return new UnitPoint
			{
				X = (unitPoint.X + unitPoint2.X) / 2.0,
				Y = (unitPoint.Y + unitPoint2.Y) / 2.0
			};
		}

		public void FitToScreen()
		{
			this.method_34();
			Rectangle clientRectangle = base.ClientRectangle;
			if (this.statusStrip.Visible)
			{
				clientRectangle.Height -= this.statusStrip.Height;
			}
			RectangleF rectangleF = ConvertCanvas.ConvertToUnitNormalized(this, clientRectangle);
			float num;
			if (this.rectangleF_0.Height / this.rectangleF_0.Width <= rectangleF.Height / rectangleF.Width)
			{
				num = this.rectangleF_0.Width / rectangleF.Width;
			}
			else
			{
				num = this.rectangleF_0.Height / rectangleF.Height;
			}
			if (num != 0f)
			{
				this.Zoom /= num;
			}
			else
			{
				this.Zoom = 1f;
			}
			PointF pointF = new PointF(this.rectangleF_0.X + this.rectangleF_0.Width / 2f, this.rectangleF_0.Y + this.rectangleF_0.Height / 2f);
			this.SetCenter(new UnitPoint(pointF));
			this.DoInvalidate(true);
		}

		public void DoInvalidate(bool dostatic)
		{
			if (dostatic)
			{
				this.staticRepaint = true;
			}
			base.Invalidate();
		}

		public void DoInvalidate(bool dostatic, RectangleF rect)
		{
			if (dostatic)
			{
				this.staticRepaint = true;
			}
			base.Invalidate(new Rectangle((int)rect.Left, (int)rect.Top, (int)rect.Width, (int)rect.Height));
		}

		public static DrawObjectBase CreateObject(string objecttype)
		{
			if (CanvasControl.dictionary_1.ContainsKey(objecttype))
			{
				return CanvasControl.dictionary_1[objecttype].Clone(false);
			}
			return null;
		}

		public DrawObjectBase CreateObject(string type, UnitPoint point, ISnapPoint snappoint)
		{
			DrawingLayer drawingLayer = this.ActiveLayer as DrawingLayer;
			if (!drawingLayer.Enabled)
			{
				return null;
			}
			DrawObjectBase drawObjectBase = CanvasControl.CreateObject(type);
			if (drawObjectBase != null)
			{
				if (drawObjectBase.GetType() == typeof(ShinaTool) && drawingLayer.Parent != null && drawingLayer.Parent.TypeCanvas == eTypeCanvas.SchemeSecond)
				{
					((ShinaTool)drawObjectBase).TypeShinaTool = eTypeShinaTool.Shina_04;
				}
				drawObjectBase.Layer = drawingLayer;
				drawObjectBase.InitializeFromModel(point, drawingLayer, snappoint);
				drawObjectBase.EndDrawEvent += this.drawObjectBase_0_EndDrawEvent;
			}
			return drawObjectBase;
		}

		public void AddObject(ICanvasLayer layer, DrawObjectBase drawobject)
		{
			((DrawingLayer)layer).AddObject(drawobject);
			if (drawobject.Selected)
			{
				this.SelectObject(drawobject);
			}
		}

		internal void method_45(DrawObjectBase drawObjectBase_2)
		{
			if (!drawObjectBase_2.Selected && this.list_1.Contains(drawObjectBase_2))
			{
				this.list_1.Remove(drawObjectBase_2);
			}
		}

		public List<DrawObjectBase> GetHitObjects(UnitPoint point)
		{
			Func<DrawObjectBase, bool> func = null;
			CanvasControl.Class30 @class = new CanvasControl.Class30();
			@class.unitPoint_0 = point;
			@class.canvasControl_0 = this;
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			this.Graphics = Graphics.FromHwnd(base.Handle);
			foreach (ICanvasLayer canvasLayer in this.list_0.Reverse<ICanvasLayer>())
			{
				if (canvasLayer.Visible)
				{
					IEnumerable<DrawObjectBase> source = canvasLayer.Objects.Reverse<DrawObjectBase>();
					if (func == null)
					{
						func = new Func<DrawObjectBase, bool>(@class.method_0);
					}
					IEnumerable<DrawObjectBase> collection = source.Where(func);
					list.AddRange(collection);
				}
			}
			return list;
		}

		public List<DrawObjectBase> GetHitObjects(CanvasControl canvas, RectangleF selection, bool anyPoint)
		{
			Func<DrawObjectBase, bool> func = null;
			CanvasControl.Class31 @class = new CanvasControl.Class31();
			@class.canvasControl_0 = canvas;
			@class.rectangleF_0 = selection;
			@class.bool_0 = anyPoint;
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (ICanvasLayer canvasLayer in this.list_0)
			{
				if (canvasLayer.Visible)
				{
					IEnumerable<DrawObjectBase> objects = canvasLayer.Objects;
					if (func == null)
					{
						func = new Func<DrawObjectBase, bool>(@class.method_0);
					}
					IEnumerable<DrawObjectBase> collection = objects.Where(func);
					list.AddRange(collection);
				}
			}
			return list;
		}

		public bool IsSelected(DrawObjectBase drawobject)
		{
			return this.list_1.Contains(drawobject);
		}

		public void SelectObject(DrawObjectBase drawobject)
		{
			if (!drawobject.Visible)
			{
				return;
			}
			this.DeSelectObject(drawobject);
			this.list_1.Add(drawobject);
			drawobject.Selected = true;
			this.propertyGrid1.SelectedObject = drawobject;
		}

		public void DeSelectObject(DrawObjectBase drawobject)
		{
			if (this.list_1.Contains(drawobject))
			{
				drawobject.Selected = false;
				this.list_1.Remove(drawobject);
			}
		}

		public void ClearSelectedObjects()
		{
			if (this.bool_6)
			{
				this.ClearFlashingObjects();
				this.bool_6 = false;
			}
			while (this.SelectedCount > 0)
			{
				DrawObjectBase drawObjectBase = this.SelectedObjects.First<DrawObjectBase>();
				drawObjectBase.Selected = false;
				if (drawObjectBase is BranchCollection)
				{
					this.list_1.Remove(drawObjectBase);
				}
				if (this.list_1.Contains(drawObjectBase))
				{
					this.list_1.Remove(drawObjectBase);
				}
			}
			this.list_1.Clear();
			this.propertyGrid1.SelectedObject = null;
		}

		public void AddInHightLightedList(DrawObjectBase drawobject)
		{
			if (!drawobject.Visible)
			{
				return;
			}
			this.list_2.Add(drawobject);
			drawobject.Highlighted = true;
		}

		public void ClearHightLightedList()
		{
			foreach (DrawObjectBase drawObjectBase in this.list_2)
			{
				drawObjectBase.Highlighted = false;
			}
			this.list_2.Clear();
		}

		public void AddLayer(DrawingLayer layer)
		{
			layer.Parent = this;
			this.list_0.Add(layer);
			layer.ObjectsAdded += this.method_47;
			layer.ObjectsRemoved += this.method_46;
			if (this.ActiveLayer == null)
			{
				this.ActiveLayer = layer;
			}
		}

		public void ClearLayers()
		{
			this.list_0.Clear();
		}

		private void method_46(List<DrawObjectBase> list_9)
		{
			this.OnObjectsRemoved(list_9);
		}

		private void method_47(List<DrawObjectBase> list_9)
		{
			this.OnObjectsAdded(list_9);
		}

		public void AddBookMark(List<DrawObjectBase> bookmark)
		{
			foreach (DrawObjectBase drawObjectBase in bookmark)
			{
				drawObjectBase.Bookmark = bookmark;
			}
			this.list_6.Add(bookmark);
		}

		public void ClearBookmarks()
		{
			if (this.list_6.Count == 0)
			{
				return;
			}
			foreach (List<DrawObjectBase> list in this.list_6)
			{
				foreach (DrawObjectBase drawObjectBase in list)
				{
					drawObjectBase.Bookmark = null;
				}
				list.Clear();
			}
			this.list_6.Clear();
			this.int_7 = 0;
		}

		public void NextBookmark()
		{
			if (this.list_6.Count == 0)
			{
				return;
			}
			if (this.int_7 + 1 < this.list_6.Count)
			{
				this.int_7++;
				List<DrawObjectBase> drawObjects = this.list_6[this.int_7];
				this.SetObjectsInCenterScreen(drawObjects, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
				return;
			}
			this.int_7 = 0;
			List<DrawObjectBase> drawObjects2 = this.list_6[this.int_7];
			this.SetObjectsInCenterScreen(drawObjects2, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
		}

		public void PrevBookmark()
		{
			if (this.list_6.Count == 0)
			{
				return;
			}
			if (this.int_7 == 0)
			{
				this.int_7 = this.list_6.Count - 1;
				List<DrawObjectBase> drawObjects = this.list_6[this.int_7];
				this.SetObjectsInCenterScreen(drawObjects, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
				return;
			}
			if (this.int_7 - 1 < this.list_6.Count)
			{
				this.int_7--;
				List<DrawObjectBase> drawObjects2 = this.list_6[this.int_7];
				this.SetObjectsInCenterScreen(drawObjects2, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
				return;
			}
			this.int_7 = this.list_6.Count - 1;
			List<DrawObjectBase> drawObjects3 = this.list_6[this.int_7];
			this.SetObjectsInCenterScreen(drawObjects3, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
		}

		public void CurrentBookmark()
		{
			if (this.list_6.Count == 0)
			{
				return;
			}
			if (this.int_7 < this.list_6.Count)
			{
				List<DrawObjectBase> drawObjects = this.list_6[this.int_7];
				this.SetObjectsInCenterScreen(drawObjects, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
				return;
			}
			this.int_7 = this.list_6.Count - 1;
			List<DrawObjectBase> drawObjects2 = this.list_6[this.int_7];
			this.SetObjectsInCenterScreen(drawObjects2, true, CanvasControl.SetObjectsInCenterScreenOptions.none);
		}

		public bool ValidateToUnique(DrawObjectBase validateObj)
		{
			Func<DrawObjectBase, bool> func = null;
			CanvasControl.Class32 @class = new CanvasControl.Class32();
			@class.drawObjectBase_0 = validateObj;
			if (@class.drawObjectBase_0 is LabelTool)
			{
				return true;
			}
			foreach (ICanvasLayer canvasLayer in this.list_0)
			{
				IEnumerable<DrawObjectBase> objects = canvasLayer.Objects;
				if (func == null)
				{
					func = new Func<DrawObjectBase, bool>(@class.method_0);
				}
				objects.Where(func);
				foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
				{
					if (@class.drawObjectBase_0 != drawObjectBase)
					{
						if (@class.drawObjectBase_0 is ObjectOnLine && @class.drawObjectBase_0.GetType() == drawObjectBase.GetType() && ((Branch)((ObjectOnLine)@class.drawObjectBase_0).Parent).CouplingRelation == ((Branch)((ObjectOnLine)drawObjectBase).Parent).CouplingRelation && @class.drawObjectBase_0.Text == drawObjectBase.Text)
						{
							return false;
						}
						if (@class.drawObjectBase_0.GetType() == drawObjectBase.GetType() && @class.drawObjectBase_0 != null && drawObjectBase != null && @class.drawObjectBase_0.Parent == drawObjectBase.Parent && @class.drawObjectBase_0.Text == drawObjectBase.Text && (@class.drawObjectBase_0.GetType() != typeof(RectangleTool) || ((RectangleTool)@class.drawObjectBase_0).TypeRectnagleTool == ((RectangleTool)drawObjectBase).TypeRectnagleTool) && (@class.drawObjectBase_0.GetType() != typeof(ShinaTool) || ((ShinaTool)@class.drawObjectBase_0).TypeShinaTool == ((ShinaTool)drawObjectBase).TypeShinaTool))
						{
							if (@class.drawObjectBase_0.GetType() == typeof(LineCellTool))
							{
								if (((LineCellTool)@class.drawObjectBase_0).Type != ((LineCellTool)drawObjectBase).Type)
								{
									continue;
								}
							}
							return false;
						}
					}
				}
			}
			return true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (this.textBoxSearch.Text.Trim() == string.Empty)
			{
				return;
			}
			int int_ = 0;
			try
			{
				int_ = Convert.ToInt32(this.textBoxSearch.Text.Trim());
			}
			catch
			{
				return;
			}
			DrawObjectBase drawObjectBase = this.FindObjectById(int_);
			if (drawObjectBase != null)
			{
				this.SetObjectsInCenterScreen(drawObjectBase, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
			}
		}

		private List<LineCellTool> method_48(LineTool lineTool_0, List<LineTool> list_9)
		{
			Func<CouplingRelation, bool> func = null;
			CanvasControl.Class33 @class = new CanvasControl.Class33();
			@class.list_0 = list_9;
			if (@class.list_0 == null)
			{
				@class.list_0 = new List<LineTool>();
			}
			@class.list_0.Add(lineTool_0);
			List<LineCellTool> list = new List<LineCellTool>();
			IEnumerable<PointTool> ends = lineTool_0.Ends;
			if (CanvasControl.func_61 == null)
			{
				CanvasControl.func_61 = new Func<PointTool, bool>(CanvasControl.smethod_63);
			}
			foreach (PointTool pointTool in ends.Where(CanvasControl.func_61))
			{
				IEnumerable<CouplingRelation> couplingRelations = pointTool.CouplingRelations;
				if (func == null)
				{
					func = new Func<CouplingRelation, bool>(@class.method_0);
				}
				foreach (CouplingRelation couplingRelation in couplingRelations.Where(func))
				{
					if (couplingRelation.Line.GetType() == typeof(LineCellTool))
					{
						list.Add((LineCellTool)couplingRelation.Line);
					}
					else
					{
						list.AddRange(this.method_48(couplingRelation.Line, @class.list_0));
					}
				}
			}
			return list;
		}

		private void bigBoldButton_Click(object sender, EventArgs e)
		{
			this.DoInvalidate(true);
		}

		public TreeNodeObj PoweringReportForDrawObject(DrawObjectBase drawObjectBase_2, bool forwardDirection)
		{
			if (drawObjectBase_2 is RectangleTool)
			{
				return this.method_49((RectangleTool)drawObjectBase_2, forwardDirection);
			}
			if (drawObjectBase_2 is ShinaTool)
			{
				return this.method_50((ShinaTool)drawObjectBase_2, forwardDirection);
			}
			if (drawObjectBase_2 is LineTool)
			{
				return this.method_51((LineTool)drawObjectBase_2, forwardDirection);
			}
			return new TreeNodeObj
			{
				Tag = drawObjectBase_2
			};
		}

		private TreeNodeObj method_49(RectangleTool rectangleTool_0, bool bool_12)
		{
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = rectangleTool_0;
			IEnumerable<DrawObjectBase> childObjects = rectangleTool_0.ChildObjects;
			if (CanvasControl.func_62 == null)
			{
				CanvasControl.func_62 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_64);
			}
			foreach (DrawObjectBase drawObjectBase in childObjects.Where(CanvasControl.func_62))
			{
				treeNodeObj.AddNode(this.method_50((ShinaTool)drawObjectBase, bool_12));
			}
			return treeNodeObj;
		}

		private TreeNodeObj method_50(ShinaTool shinaTool_0, bool bool_12)
		{
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = shinaTool_0;
			if (shinaTool_0.Amperage == null)
			{
				return treeNodeObj;
			}
			if (bool_12)
			{
				using (List<Amperage>.Enumerator enumerator = shinaTool_0.Amperage.NextAmperages.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Amperage amperage_ = enumerator.Current;
						this.method_52(amperage_, treeNodeObj);
					}
					return treeNodeObj;
				}
			}
			List<DrawObjectBase> list = this.method_57(shinaTool_0);
			if (list == null)
			{
				return treeNodeObj;
			}
			TreeNodeObj treeNodeObj_ = treeNodeObj;
			foreach (DrawObjectBase drawObjectBase in list)
			{
				TreeNodeObj treeNodeObj2;
				if (drawObjectBase.GetType() == typeof(BranchCollection))
				{
					treeNodeObj2 = this.method_53(treeNodeObj_, ((BranchCollection)drawObjectBase).Parent);
				}
				else
				{
					treeNodeObj2 = this.method_53(treeNodeObj_, drawObjectBase);
				}
				if (treeNodeObj2 != null)
				{
					treeNodeObj_ = treeNodeObj2;
				}
			}
			return treeNodeObj;
		}

		private TreeNodeObj method_51(LineTool lineTool_0, bool bool_12)
		{
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = lineTool_0;
			foreach (Amperage amperage in lineTool_0.Amperages.Values)
			{
				if (bool_12)
				{
					using (List<Amperage>.Enumerator enumerator2 = amperage.NextAmperages.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							Amperage amperage_ = enumerator2.Current;
							this.method_52(amperage_, treeNodeObj);
						}
						continue;
					}
				}
				List<DrawObjectBase> powerSource = amperage.GetPowerSource();
				TreeNodeObj treeNodeObj_ = treeNodeObj;
				foreach (DrawObjectBase drawObjectBase in powerSource)
				{
					TreeNodeObj treeNodeObj2;
					if (drawObjectBase.GetType() == typeof(BranchCollection))
					{
						treeNodeObj2 = this.method_53(treeNodeObj_, ((BranchCollection)drawObjectBase).Parent);
					}
					else
					{
						treeNodeObj2 = this.method_53(treeNodeObj_, drawObjectBase);
					}
					if (treeNodeObj2 != null)
					{
						treeNodeObj_ = treeNodeObj2;
					}
				}
			}
			return treeNodeObj;
		}

		private void method_52(Amperage amperage_0, TreeNodeObj treeNodeObj_0)
		{
			TreeNodeObj treeNodeObj = this.method_53(treeNodeObj_0, amperage_0.Conductor);
			if (treeNodeObj == null)
			{
				return;
			}
			foreach (Amperage amperage_ in amperage_0.NextAmperages)
			{
				this.method_52(amperage_, treeNodeObj);
			}
		}

		private TreeNodeObj method_53(TreeNodeObj treeNodeObj_0, DrawObjectBase drawObjectBase_2)
		{
			DrawObjectBase drawObjectBase;
			if (drawObjectBase_2.GetType() == typeof(Branch))
			{
				drawObjectBase = drawObjectBase_2.Parent;
			}
			else
			{
				drawObjectBase = drawObjectBase_2;
			}
			if (drawObjectBase != treeNodeObj_0.Tag)
			{
				TreeNodeObj treeNodeObj = treeNodeObj_0.AddNode();
				treeNodeObj.Tag = drawObjectBase;
				return treeNodeObj;
			}
			return null;
		}

		private void method_54(StreamWriter streamWriter_0, TreeNode treeNode_0, string string_7)
		{
			if (treeNode_0.Tag.GetType() == typeof(LineCellTool))
			{
				if (((DrawObjectBase)treeNode_0.Parent.Tag).GetType() == typeof(LineTool) && ((LineTool)treeNode_0.Parent.Tag).ParRectangle() == null)
				{
					if (string_7.Length > 0)
					{
						string_7 += ";";
					}
					string_7 = string_7 + ((DrawObjectBase)treeNode_0.Tag).Parent.ToString() + ":" + ((DrawObjectBase)treeNode_0.Tag).ToString();
					streamWriter_0.WriteLine(string_7);
					string_7 = string.Empty;
				}
				if (((DrawObjectBase)treeNode_0.Parent.Tag).GetType() == typeof(ShinaTool))
				{
					bool flag = false;
					foreach (object obj in treeNode_0.Nodes)
					{
						TreeNode treeNode = (TreeNode)obj;
						if (treeNode.Tag.GetType() == typeof(LineTool) && ((LineTool)treeNode.Tag).ParRectangle() == null)
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						string_7 = string_7 + ((DrawObjectBase)treeNode_0.Tag).Parent.ToString() + ":" + ((DrawObjectBase)treeNode_0.Tag).ToString();
					}
				}
			}
			if (treeNode_0.Nodes.Count > 0)
			{
				foreach (object obj2 in treeNode_0.Nodes)
				{
					TreeNode treeNode_ = (TreeNode)obj2;
					this.method_54(streamWriter_0, treeNode_, string_7);
				}
			}
		}

		private TreeNode method_55(TreeView treeView_0, DrawObjectBase drawObjectBase_2)
		{
			DrawObjectBase drawObjectBase;
			if (drawObjectBase_2.GetType() == typeof(Branch))
			{
				drawObjectBase = drawObjectBase_2.Parent;
			}
			else
			{
				drawObjectBase = drawObjectBase_2;
			}
			TreeNode treeNode = treeView_0.Nodes.Add(drawObjectBase.Text);
			treeNode.Tag = drawObjectBase;
			return treeNode;
		}

		private TreeNode method_56(TreeNode treeNode_0, DrawObjectBase drawObjectBase_2)
		{
			DrawObjectBase drawObjectBase;
			if (drawObjectBase_2.GetType() == typeof(Branch))
			{
				drawObjectBase = drawObjectBase_2.Parent;
			}
			else
			{
				drawObjectBase = drawObjectBase_2;
			}
			if (drawObjectBase != treeNode_0.Tag)
			{
				TreeNode treeNode = treeNode_0.Nodes.Add(drawObjectBase.Text);
				treeNode.Tag = drawObjectBase;
				return treeNode;
			}
			return null;
		}

		private List<DrawObjectBase> method_57(ShinaTool shinaTool_0)
		{
			if (shinaTool_0.Amperage != null)
			{
				return shinaTool_0.Amperage.GetPowerSource();
			}
			return null;
		}

		private void method_58(Amperage amperage_0, TreeNode treeNode_0)
		{
			TreeNode treeNode_ = this.method_56(treeNode_0, amperage_0.Conductor);
			foreach (Amperage amperage_ in amperage_0.NextAmperages)
			{
				this.method_58(amperage_, treeNode_);
			}
		}

		public void ForBigBoldButton2()
		{
			new List<TextBranchTool>();
			foreach (ICanvasLayer canvasLayer in this.list_0)
			{
				DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
				foreach (DrawObjectBase drawObjectBase in drawingLayer.Objects.Reverse<DrawObjectBase>())
				{
				}
			}
		}

		public void ForBigBoldButton()
		{
		}

		public void ZoomIn()
		{
			UnitPoint point = this.CenterPointUnit();
			if (this.Zoom < 0.25f)
			{
				if (this.Zoom > 0.125f)
				{
					this.Zoom = 0.25f;
				}
				else
				{
					this.Zoom *= 2f;
				}
			}
			else
			{
				this.Zoom += 0.25f;
			}
			if (point.X < (double)this.rectangleF_0.X)
			{
				point.X = (double)this.rectangleF_0.X;
			}
			if (point.Y < (double)this.rectangleF_0.Y)
			{
				point.Y = (double)this.rectangleF_0.Y;
			}
			if (point.X > (double)this.rectangleF_0.Right)
			{
				point.X = (double)this.rectangleF_0.Right;
			}
			if (point.Y > (double)this.rectangleF_0.Bottom)
			{
				point.Y = (double)this.rectangleF_0.Bottom;
			}
			this.SetCenterScreen(ConvertCanvas.ConvertToScreen(this, point), false);
			this.DoInvalidate(true);
		}

		public void ZoomOut()
		{
			UnitPoint point = this.CenterPointUnit();
			if (this.Zoom > 0.25f)
			{
				this.Zoom -= 0.25f;
			}
			else
			{
				this.Zoom /= 2f;
			}
			if (point.X < (double)this.rectangleF_0.X)
			{
				point.X = (double)this.rectangleF_0.X;
			}
			if (point.Y < (double)this.rectangleF_0.Y)
			{
				point.Y = (double)this.rectangleF_0.Y;
			}
			if (point.X > (double)this.rectangleF_0.Right)
			{
				point.X = (double)this.rectangleF_0.Right;
			}
			if (point.Y > (double)this.rectangleF_0.Bottom)
			{
				point.Y = (double)this.rectangleF_0.Bottom;
			}
			this.SetCenterScreen(ConvertCanvas.ConvertToScreen(this, point), false);
			this.DoInvalidate(true);
		}

		public void SetZoom(float newZoom)
		{
			UnitPoint point = this.CenterPointUnit();
			this.Zoom = Convert.ToSingle(newZoom);
			this.SetCenterScreen(ConvertCanvas.ConvertToScreen(this, point), false);
			this.DoInvalidate(true);
		}

		public void ZoomInSymbols()
		{
			this.Settings.ZoomInFontSize();
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
				foreach (DrawObjectBase drawObjectBase in drawingLayer.Objects)
				{
					if (!drawObjectBase.UseSettingsText)
					{
						drawObjectBase.TextProperty.FontSize += 0.5f;
					}
				}
			}
			this.DoInvalidate(true);
		}

		public void ZoomOutSymbols()
		{
			this.Settings.ZoomOutFontSize();
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
				foreach (DrawObjectBase drawObjectBase in drawingLayer.Objects)
				{
					if (!drawObjectBase.UseSettingsText)
					{
						drawObjectBase.TextProperty.FontSize -= 0.5f;
					}
				}
			}
			this.DoInvalidate(true);
		}

		private void method_59()
		{
			this.control0_0 = new Control0();
			this.control0_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.control0_0.BorderStyle = BorderStyle.Fixed3D;
			this.control0_0.method_96(this);
			this.control0_0.Width = (int)((float)base.Width * this.control0_0.method_99());
			this.control0_0.Height = (int)((float)base.Height * this.control0_0.method_101());
			this.control0_0.Location = new Point(base.Width - this.control0_0.Width, base.Height - this.control0_0.Height - this.statusStrip.Height);
			this.control0_0.method_98(ConvertCanvas.ConvertToUnitNormalized(this, base.ClientRectangle));
			base.Controls.Add(this.control0_0);
		}

		private void method_60()
		{
			if (this.control0_0 != null)
			{
				if (base.Controls.Contains(this.control0_0))
				{
					base.Controls.Remove(this.control0_0);
				}
				this.control0_0 = null;
			}
		}

		private void method_61()
		{
			if (this.control0_0 != null)
			{
				this.control0_0.Width = (int)((float)base.Width * this.control0_0.method_99());
				this.control0_0.Height = (int)((float)base.Height * this.control0_0.method_101());
				this.control0_0.Location = new Point(base.Width - this.control0_0.Width, base.Height - this.control0_0.Height - this.statusStrip.Height);
				this.control0_0.method_98(ConvertCanvas.ConvertToUnitNormalized(this, base.ClientRectangle));
			}
		}

		private void method_62()
		{
			if (this.control0_0 != null)
			{
				this.control0_0.method_98(ConvertCanvas.ConvertToUnitNormalized(this, base.ClientRectangle));
			}
		}

		public void CopyToImage()
		{
			Func<DrawObjectBase, RectangleF> func = null;
			Func<DrawObjectBase, bool> func2 = null;
			CanvasControl.Class34 @class = new CanvasControl.Class34();
			@class.canvasControl_0 = this;
			if (this.SelectedCount <= 0 && this.canvasFrame_0 == null)
			{
				return;
			}
			this.method_29();
			if (this.canvasFrame_0 == null)
			{
				float num = float.NaN;
				float num2 = float.NaN;
				float num3 = float.NaN;
				float num4 = float.NaN;
				IEnumerable<DrawObjectBase> selectedObjects = this.SelectedObjects;
				if (CanvasControl.func_63 == null)
				{
					CanvasControl.func_63 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_65);
				}
				IEnumerable<DrawObjectBase> source = selectedObjects.Where(CanvasControl.func_63);
				if (func == null)
				{
					func = new Func<DrawObjectBase, RectangleF>(this.method_94);
				}
				IEnumerable<RectangleF> enumerable = source.Select(func);
				IEnumerable<RectangleF> source2 = enumerable;
				if (CanvasControl.func_64 == null)
				{
					CanvasControl.func_64 = new Func<RectangleF, bool>(CanvasControl.smethod_66);
				}
				IEnumerable<RectangleF> source3 = source2.Where(CanvasControl.func_64);
				if (CanvasControl.func_65 == null)
				{
					CanvasControl.func_65 = new Func<RectangleF, float>(CanvasControl.smethod_67);
				}
				float num5 = source3.Min(CanvasControl.func_65);
				if (float.IsNaN(num) || num > num5)
				{
					num = num5;
				}
				IEnumerable<RectangleF> source4 = enumerable;
				if (CanvasControl.func_66 == null)
				{
					CanvasControl.func_66 = new Func<RectangleF, bool>(CanvasControl.smethod_68);
				}
				IEnumerable<RectangleF> source5 = source4.Where(CanvasControl.func_66);
				if (CanvasControl.func_67 == null)
				{
					CanvasControl.func_67 = new Func<RectangleF, float>(CanvasControl.smethod_69);
				}
				num5 = source5.Min(CanvasControl.func_67);
				if (float.IsNaN(num2) || num2 > num5)
				{
					num2 = num5;
				}
				IEnumerable<RectangleF> source6 = enumerable;
				if (CanvasControl.func_68 == null)
				{
					CanvasControl.func_68 = new Func<RectangleF, bool>(CanvasControl.smethod_70);
				}
				IEnumerable<RectangleF> source7 = source6.Where(CanvasControl.func_68);
				if (CanvasControl.func_69 == null)
				{
					CanvasControl.func_69 = new Func<RectangleF, float>(CanvasControl.smethod_71);
				}
				num5 = source7.Max(CanvasControl.func_69);
				if (float.IsNaN(num3) || num3 < num5)
				{
					num3 = num5;
				}
				IEnumerable<RectangleF> source8 = enumerable;
				if (CanvasControl.func_70 == null)
				{
					CanvasControl.func_70 = new Func<RectangleF, bool>(CanvasControl.smethod_72);
				}
				IEnumerable<RectangleF> source9 = source8.Where(CanvasControl.func_70);
				if (CanvasControl.func_71 == null)
				{
					CanvasControl.func_71 = new Func<RectangleF, float>(CanvasControl.smethod_73);
				}
				num5 = source9.Max(CanvasControl.func_71);
				if (float.IsNaN(num4) || num4 < num5)
				{
					num4 = num5;
				}
				if (float.IsNaN(num))
				{
					num = 0f;
				}
				if (float.IsNaN(num2))
				{
					num2 = 0f;
				}
				if (float.IsNaN(num3))
				{
					num3 = 0f;
				}
				if (float.IsNaN(num4))
				{
					num4 = 0f;
				}
				@class.rectangleF_0 = new RectangleF(num, num2, num3 - num, num4 - num2);
			}
			else
			{
				this.canvasFrame_0.Normalize();
				@class.rectangleF_0 = this.canvasFrame_0.Rectangle;
			}
			RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(this, @class.rectangleF_0);
			if (this.canvasFrame_0 == null)
			{
				@class.rectangleF_0.Inflate(new SizeF(3f, 3f));
			}
			CanvasControl canvasControl = new CanvasControl();
			canvasControl.Size = new Size((int)rectangleF.Width, Math.Abs((int)rectangleF.Height));
			if (this.canvasFrame_0 == null)
			{
				canvasControl.SetObjectsInCenterScreen(this.SelectedObjects.ToList<DrawObjectBase>(), true, CanvasControl.SetObjectsInCenterScreenOptions.none);
			}
			else
			{
				canvasControl.method_43(@class.rectangleF_0, true);
			}
			canvasControl.SetCenter(new UnitPoint((double)(@class.rectangleF_0.X + @class.rectangleF_0.Width / 2f), (double)(@class.rectangleF_0.Y + @class.rectangleF_0.Height / 2f)));
			canvasControl.DoInvalidate(true);
			Bitmap bitmap = new Bitmap((int)rectangleF.Width, Math.Abs((int)rectangleF.Height));
			canvasControl.Graphics = Graphics.FromImage(bitmap);
			canvasControl.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, (int)rectangleF.Width, (int)rectangleF.Height));
			if (this.canvasFrame_0 != null)
			{
				RectangleF rectangleF2 = ConvertCanvas.ConvertToScreenNormalized(canvasControl, @class.rectangleF_0);
				canvasControl.Graphics.ExcludeClip(new Rectangle(0, 0, (int)rectangleF2.X, canvasControl.Size.Height));
				canvasControl.Graphics.ExcludeClip(new Rectangle(0, 0, canvasControl.Size.Width, (int)rectangleF2.Y));
				canvasControl.Graphics.ExcludeClip(new Rectangle((int)(rectangleF2.X + rectangleF2.Width), 0, canvasControl.Size.Width - (int)(rectangleF2.X + rectangleF2.Width), canvasControl.Size.Height));
				canvasControl.Graphics.ExcludeClip(new Rectangle(0, (int)(rectangleF2.Y + rectangleF2.Height), canvasControl.Size.Width, canvasControl.Size.Height - (int)(rectangleF2.Y + rectangleF2.Height)));
			}
			if (this.canvasFrame_0 == null)
			{
				using (IEnumerator<DrawObjectBase> enumerator = this.SelectedObjects.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DrawObjectBase drawObjectBase = enumerator.Current;
						drawObjectBase.DrawPrint(canvasControl, canvasControl.Graphics, false);
					}
					goto IL_58D;
				}
			}
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
				IEnumerable<DrawObjectBase> objects = drawingLayer.Objects;
				if (func2 == null)
				{
					func2 = new Func<DrawObjectBase, bool>(@class.method_0);
				}
				IEnumerable<DrawObjectBase> enumerable2 = objects.Where(func2);
				foreach (DrawObjectBase drawObjectBase2 in enumerable2)
				{
					drawObjectBase2.Draw(canvasControl, @class.rectangleF_0, eDrawMode.Print);
				}
			}
			IL_58D:
			Clipboard.SetImage(bitmap);
			bitmap.Dispose();
		}

		public void ExportToImage(string fileName)
		{
			this.method_34();
			this.method_43(this.rectangleF_0, true);
			RectangleF rectangleF = ConvertCanvas.ConvertToScreenNormalized(this, this.rectangleF_0);
			rectangleF.Width *= 30f;
			rectangleF.Height *= 30f;
			CanvasControl canvasControl = new CanvasControl();
			canvasControl.Size = new Size((int)rectangleF.Width, Math.Abs((int)rectangleF.Height));
			canvasControl.method_43(this.rectangleF_0, true);
			canvasControl.DoInvalidate(true);
			Bitmap bitmap = new Bitmap((int)rectangleF.Width, Math.Abs((int)rectangleF.Height));
			canvasControl.Graphics = Graphics.FromImage(bitmap);
			canvasControl.BackgroundLayer.Draw(this, this.rectangleF_0);
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
				foreach (DrawObjectBase drawObjectBase in drawingLayer.Objects)
				{
					drawObjectBase.Draw(canvasControl, this.rectangleF_0, eDrawMode.Color);
				}
			}
			bitmap.Save(fileName, ImageFormat.Jpeg);
			bitmap.Dispose();
		}

		public void ExportToImage()
		{
			if (this.canvasFrame_0 != null)
			{
				RectangleF rectangleF = ConvertCanvas.ConvertToScreen(this, this.canvasFrame_0.Rectangle);
				Size oldSizeImage = new Size((int)rectangleF.Width, (int)rectangleF.Height);
				FormExportCanvasToImage formExportCanvasToImage = new FormExportCanvasToImage();
				formExportCanvasToImage.Canvas = this;
				this.canvasFrame_0.Normalize();
				formExportCanvasToImage.RectangleIamge = this.canvasFrame_0.Rectangle;
				formExportCanvasToImage.OldSizeImage = oldSizeImage;
				formExportCanvasToImage.ShowDialog();
			}
		}

		public void ExportToDXF(string fileName)
		{
			DxfDocument dxfDocument = new DxfDocument();
			if (this.SelectedCount <= 0)
			{
				using (IEnumerator<ICanvasLayer> enumerator = this.Layers.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ICanvasLayer canvasLayer = enumerator.Current;
						DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
						foreach (DrawObjectBase drawObjectBase in drawingLayer.Objects.Reverse<DrawObjectBase>())
						{
							this.Graphics = Graphics.FromHwnd(base.Handle);
							drawObjectBase.ExportDXF(this, dxfDocument);
						}
					}
					goto IL_DB;
				}
			}
			foreach (DrawObjectBase drawObjectBase2 in this.SelectedObjects)
			{
				this.Graphics = Graphics.FromHwnd(base.Handle);
				drawObjectBase2.ExportDXF(this, dxfDocument);
			}
			IL_DB:
			dxfDocument.Save(fileName, 1);
		}

		private void buttonCheck_Click(object sender, EventArgs e)
		{
			this.method_8();
		}

		private void method_63(Point point_2)
		{
			List<DrawObjectBase> hitObjects = this.GetHitObjects(ConvertCanvas.ConvertToUnit(this, point_2));
			if (hitObjects.Count > 0 && this.sqlsettings_0 != null)
			{
				if (hitObjects[0].GetType() == typeof(RectangleTool) && hitObjects[0].Selected)
				{
					if (!this.panelPassport_0.Visible)
					{
						this.panelPassport_0.Show(this.sqlsettings_0, hitObjects[0].IdBase, hitObjects[0].ToString() + "(" + hitObjects[0].IdBase.ToString() + ")");
						if (point_2.X + this.panelPassport_0.Width + 20 > base.Width)
						{
							this.panelPassport_0.Left = point_2.X - this.panelPassport_0.Width;
						}
						else
						{
							this.panelPassport_0.Left = point_2.X;
						}
						if (point_2.Y < this.panelPassport_0.Height)
						{
							this.panelPassport_0.Top = point_2.Y;
						}
						else
						{
							this.panelPassport_0.Top = point_2.Y - this.panelPassport_0.Height;
						}
						this.panelPassport_0.PageEndColor = Color.LightGray;
						this.panelPassport_0.PageStartColor = Color.White;
						this.panelPassport_0.Visible = true;
						this.panelPassport_0.BringToFront();
						return;
					}
				}
				else if (!this.tbPopup.Visible)
				{
					if (hitObjects[0].GetType() == typeof(LineTool))
					{
						this.tbPopup.Text = "";
						List<string> destinations = ((LineTool)hitObjects[0]).GetDestinations();
						foreach (string str in destinations)
						{
							Label label = this.tbPopup;
							label.Text = label.Text + str + "\n";
						}
						DrawObjectBase[] array = ((LineTool)hitObjects[0]).GetPowerSource(((LineTool)hitObjects[0]).SelectedBranch).ToArray();
						List<DrawObjectBase> list = new List<DrawObjectBase>();
						for (int i = 0; i < array.Length - 1; i++)
						{
							if (array[i].GetType() == typeof(BranchCollection))
							{
								LineTool lineTool = (LineTool)((BranchCollection)array[i]).Parent;
								if (!list.Contains(lineTool) && lineTool != null && lineTool.GetType() == typeof(LineCellTool) && array[i + 1].GetType() == typeof(ShinaTool) && (((RectangleTool)lineTool.Parent).TypeRectnagleTool == eTypeRectangleTool.RP || ((RectangleTool)lineTool.Parent).TypeRectnagleTool == eTypeRectangleTool.CP))
								{
									Label label2 = this.tbPopup;
									label2.Text += "\n";
									string str2 = string.Concat(new string[]
									{
										lineTool.Parent.ToString(),
										"  /  ",
										array[i + 1].ToString(),
										"  /  ",
										lineTool.ToString()
									});
									Label label3 = this.tbPopup;
									label3.Text += str2;
									list.Add(lineTool);
								}
							}
						}
					}
					else if (hitObjects[0].GetType() == typeof(NodeTool))
					{
						this.tbPopup.Text = hitObjects[0].StripText;
					}
					else
					{
						this.tbPopup.Text = hitObjects[0].StripText;
					}
					if (point_2.X + this.tbPopup.Width + 20 > base.Width)
					{
						this.tbPopup.Left = point_2.X - this.tbPopup.Width - 1;
					}
					else
					{
						this.tbPopup.Left = point_2.X + 1;
					}
					if (point_2.Y < this.tbPopup.Height + 2)
					{
						this.tbPopup.Top = point_2.Y + this.tbPopup.Height + 1;
					}
					else
					{
						this.tbPopup.Top = point_2.Y - this.tbPopup.Height - 1;
					}
					this.tbPopup.Visible = true;
					this.tbPopup.BringToFront();
				}
			}
		}

		private void method_64()
		{
			Control control = this.panelPassport_0;
			this.tbPopup.Visible = false;
			control.Visible = false;
		}

		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.int_8++;
			if (this.int_8 == 1)
			{
				this.point_1 = this.point_0;
			}
			if (this.point_0 == this.point_1 && this.eMouseControlState_0 == eMouseControlState.OnControl && Control.MouseButtons == MouseButtons.None)
			{
				this.method_63(this.point_1);
				if (this.timer_0.Enabled)
				{
					this.timer_0.Stop();
				}
			}
			if (this.int_8 > 1 && this.timer_0.Enabled)
			{
				this.timer_0.Stop();
			}
		}

		private void method_65()
		{
			this.tFlash.Interval = 500;
			this.tFlash.Enabled = false;
			this.tFlash.Tick += this.tFlash_Tick;
		}

		private void tFlash_Tick(object sender, EventArgs e)
		{
			this.ConvertColorFlash = !this.ConvertColorFlash;
			this.DoInvalidate(false);
		}

		public void AddFlashObject(DrawObjectBase drawObjectBase_2)
		{
			if (!this.tFlash.Enabled)
			{
				this.tFlash.Start();
			}
			drawObjectBase_2.Flashing = true;
			if (!this.list_3.Contains(drawObjectBase_2))
			{
				this.list_3.Add(drawObjectBase_2);
				if (this.drawObjectEventHandler_8 != null)
				{
					this.drawObjectEventHandler_8(this, new DrawObjectsEventArgs(drawObjectBase_2));
				}
			}
		}

		public void ClearFlashingObjects()
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in this.list_3)
			{
				drawObjectBase.Flashing = false;
				list.Add(drawObjectBase);
			}
			this.list_3.Clear();
			if (this.drawObjectEventHandler_9 != null)
			{
				this.drawObjectEventHandler_9(this, new DrawObjectsEventArgs(list));
			}
			this.tFlash.Stop();
		}

		private void toolBtnZoom25_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;
			if (toolStripMenuItem.Tag != null)
			{
				UnitPoint point = this.CenterPointUnit();
				this.Zoom = Convert.ToSingle(toolStripMenuItem.Tag) / 100f;
				this.SetCenterScreen(ConvertCanvas.ConvertToScreen(this, point), false);
				this.DoInvalidate(true);
			}
		}

		private void toolTxtZoomChanged_KeyDown(object sender, KeyEventArgs e)
		{
			float value;
			if (e.KeyCode == Keys.Return && float.TryParse(this.toolTxtZoomChanged.Text, out value))
			{
				UnitPoint point = this.CenterPointUnit();
				this.Zoom = Convert.ToSingle(value) / 100f;
				this.SetCenterScreen(ConvertCanvas.ConvertToScreen(this, point), false);
				this.DoInvalidate(true);
				this.toolBtnZoom.HideDropDown();
			}
		}

		public static bool GetAlternativePower(DrawObjectBase drawObjectBase_2, TreeNodeObj currentNode, Dictionary<DrawObjectBase, bool> dictionary_2)
		{
			if (currentNode.Level > 700)
			{
				return false;
			}
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = drawObjectBase_2;
			currentNode.AddNode(treeNodeObj);
			bool flag = false;
			dictionary_2.Add(drawObjectBase_2, false);
			if (drawObjectBase_2.GetType() != typeof(LineTool))
			{
				if (drawObjectBase_2.GetType() != typeof(LineCellTool))
				{
					if (drawObjectBase_2.GetType() != typeof(ShinaTool))
					{
						goto IL_77D;
					}
					if (((ShinaTool)drawObjectBase_2).Amperage != null && ((ShinaTool)drawObjectBase_2).Amperage.Source == drawObjectBase_2)
					{
						flag = true;
						goto IL_77D;
					}
					IEnumerable<DrawObjectBase> childObjects = ((ShinaTool)drawObjectBase_2).ChildObjects;
					if (CanvasControl.func_72 == null)
					{
						CanvasControl.func_72 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_74);
					}
					using (IEnumerator<DrawObjectBase> enumerator = childObjects.Where(CanvasControl.func_72).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							DrawObjectBase drawObjectBase = enumerator.Current;
							PointTool pointTool = (PointTool)drawObjectBase;
							bool flag2 = false;
							foreach (Branch branch in pointTool.Branches)
							{
								if (currentNode.Level == 0 && ((ShinaTool)drawObjectBase_2).Amperage != null)
								{
									foreach (Amperage amperage in ((ShinaTool)drawObjectBase_2).Amperage.Mediators)
									{
										if (branch.Parent == amperage.Conductor)
										{
											flag2 = true;
											break;
										}
									}
									if (flag2)
									{
										break;
									}
								}
								if (dictionary_2.ContainsKey(branch.Parent))
								{
									if (dictionary_2[branch.Parent] && !CanvasControl.smethod_1(branch.Parent, currentNode))
									{
										flag = true;
									}
								}
								else if (CanvasControl.GetAlternativePower(branch.Parent, treeNodeObj, dictionary_2))
								{
									flag = true;
								}
							}
						}
						goto IL_77D;
					}
				}
			}
			PointTool pointTool2 = null;
			Dictionary<PointTool, bool> dictionary = new Dictionary<PointTool, bool>();
			bool flag3 = false;
			foreach (PointTool pointTool3 in ((LineTool)drawObjectBase_2).Ends)
			{
				if (pointTool3.Parent != null && pointTool3.Parent.GetType() == typeof(ShinaTool))
				{
					if (currentNode.Tag == pointTool3.Parent)
					{
						pointTool2 = pointTool3;
					}
					else
					{
						dictionary.Add(pointTool3, false);
					}
				}
				else
				{
					foreach (Branch branch2 in pointTool3.Branches)
					{
						if (branch2.Parent != drawObjectBase_2)
						{
							if (branch2.Parent == currentNode.Tag)
							{
								pointTool2 = pointTool3;
							}
							else
							{
								dictionary.Add(pointTool3, false);
							}
							break;
						}
					}
				}
			}
			if (pointTool2 != null)
			{
				List<PointTool> list = new List<PointTool>();
				list.AddRange(dictionary.Keys);
				foreach (PointTool pointTool4 in list)
				{
					BranchCollection wayOnLineTool = ((LineTool)drawObjectBase_2).GetWayOnLineTool(pointTool2, pointTool4);
					foreach (Branch branch3 in wayOnLineTool.Collection)
					{
						foreach (DrawObjectBase drawObjectBase2 in branch3.ChildObjects)
						{
							if (drawObjectBase2.GetType().BaseType == typeof(ObjectOnLine) && !((ObjectOnLine)drawObjectBase2).On && ((LineTool)drawObjectBase_2).Amperages.ContainsKey(pointTool4))
							{
								dictionary[pointTool4] = true;
								flag3 = true;
							}
							else if (drawObjectBase2.GetType().BaseType == typeof(ObjectOnLine) && !((ObjectOnLine)drawObjectBase2).On && !((LineTool)drawObjectBase_2).Amperages.ContainsKey(pointTool4))
							{
								dictionary.Remove(pointTool4);
							}
						}
					}
				}
			}
			List<PointTool> list2 = new List<PointTool>();
			list2.AddRange(dictionary.Keys);
			foreach (PointTool pointTool5 in list2)
			{
				if (dictionary[pointTool5])
				{
					if (pointTool5.Parent != null && pointTool5.Parent.GetType() == typeof(ShinaTool) && ((ShinaTool)pointTool5.Parent).Amperage != null)
					{
						List<DrawObjectBase> powerSource = ((ShinaTool)pointTool5.Parent).Amperage.GetPowerSource();
						if (powerSource != null && powerSource.Count > 0)
						{
							TreeNodeObj treeNodeObj2 = treeNodeObj;
							foreach (DrawObjectBase drawObjectBase3 in powerSource)
							{
								TreeNodeObj treeNodeObj3 = new TreeNodeObj();
								treeNodeObj3.Tag = drawObjectBase3;
								treeNodeObj2.AddNode(treeNodeObj3);
								treeNodeObj2 = treeNodeObj3;
								dictionary_2[drawObjectBase3] = true;
							}
							flag = true;
						}
						else
						{
							dictionary[pointTool5] = false;
						}
					}
					else
					{
						bool flag4 = false;
						foreach (Branch branch4 in pointTool5.Branches)
						{
							if (branch4.Parent != drawObjectBase_2)
							{
								List<DrawObjectBase> powerSource2 = branch4.Parent.GetPowerSource();
								if (powerSource2 != null && powerSource2.Count > 0)
								{
									TreeNodeObj treeNodeObj4 = treeNodeObj;
									foreach (DrawObjectBase drawObjectBase4 in powerSource2)
									{
										TreeNodeObj treeNodeObj5 = new TreeNodeObj();
										treeNodeObj5.Tag = drawObjectBase4;
										treeNodeObj4.AddNode(treeNodeObj5);
										treeNodeObj4 = treeNodeObj5;
										dictionary_2[drawObjectBase4] = true;
									}
									flag = true;
									if (!flag4)
									{
										flag4 = true;
									}
								}
							}
						}
						dictionary[pointTool5] = flag4;
					}
				}
				else if (!flag3)
				{
					if (pointTool5.Parent != null && pointTool5.Parent.GetType() == typeof(ShinaTool))
					{
						if (dictionary_2.ContainsKey(pointTool5.Parent))
						{
							if (dictionary_2[pointTool5.Parent] && !CanvasControl.smethod_1(pointTool5.Parent, currentNode))
							{
								dictionary[pointTool5] = true;
								flag = true;
							}
							else if (!dictionary_2[pointTool5.Parent] && CanvasControl.smethod_1(pointTool5.Parent, currentNode) && ((LineTool)drawObjectBase_2).Ends.Count<PointTool>() == 2)
							{
								dictionary_2.Remove(drawObjectBase_2);
								break;
							}
						}
						else if (CanvasControl.GetAlternativePower(pointTool5.Parent, treeNodeObj, dictionary_2))
						{
							flag = true;
							dictionary[pointTool5] = true;
						}
					}
					else
					{
						foreach (Branch branch5 in pointTool5.Branches)
						{
							if (branch5.Parent == null || branch5.Parent != drawObjectBase_2)
							{
								if (dictionary_2.ContainsKey(branch5.Parent))
								{
									if (dictionary_2[branch5.Parent] && !CanvasControl.smethod_1(branch5.Parent, currentNode))
									{
										dictionary[pointTool5] = true;
										flag = true;
									}
								}
								else if (CanvasControl.GetAlternativePower(branch5.Parent, treeNodeObj, dictionary_2))
								{
									flag = true;
									dictionary[pointTool5] = true;
								}
							}
						}
					}
				}
			}
			IL_77D:
			if (!flag)
			{
				currentNode.RemoveNode(treeNodeObj);
			}
			if (dictionary_2.ContainsKey(drawObjectBase_2))
			{
				dictionary_2[drawObjectBase_2] = flag;
			}
			return flag;
		}

		public static bool GetAllPower(DrawObjectBase drawObjectBase_2, TreeNodeObj currentNode, Dictionary<DrawObjectBase, bool> dictionary_2)
		{
			if (currentNode.Level > 700)
			{
				return false;
			}
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			treeNodeObj.Tag = drawObjectBase_2;
			currentNode.AddNode(treeNodeObj);
			bool flag = false;
			dictionary_2.Add(drawObjectBase_2, false);
			if (drawObjectBase_2.GetType() != typeof(LineTool))
			{
				if (drawObjectBase_2.GetType() != typeof(LineCellTool))
				{
					if (drawObjectBase_2.GetType() != typeof(ShinaTool))
					{
						goto IL_3A0;
					}
					if (((ShinaTool)drawObjectBase_2).Amperage != null && ((ShinaTool)drawObjectBase_2).Amperage.Source == drawObjectBase_2)
					{
						flag = true;
						goto IL_3A0;
					}
					using (IEnumerator<DrawObjectBase> enumerator = ((ShinaTool)drawObjectBase_2).ChildObjects.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							DrawObjectBase drawObjectBase = enumerator.Current;
							PointTool pointTool = (PointTool)drawObjectBase;
							foreach (Branch branch in pointTool.Branches)
							{
								if (branch.Parent == null || branch.Parent != currentNode.Tag)
								{
									if (dictionary_2.ContainsKey(branch.Parent))
									{
										if (dictionary_2[branch.Parent] && !CanvasControl.smethod_1(branch.Parent, currentNode))
										{
											flag = true;
										}
									}
									else if (CanvasControl.GetAllPower(branch.Parent, treeNodeObj, dictionary_2))
									{
										flag = true;
									}
								}
							}
						}
						goto IL_3A0;
					}
				}
			}
			PointTool pointTool2 = null;
			List<PointTool> list = new List<PointTool>();
			foreach (PointTool pointTool3 in ((LineTool)drawObjectBase_2).Ends)
			{
				if (pointTool3.Parent != null && pointTool3.Parent.GetType() == typeof(ShinaTool))
				{
					if (currentNode.Tag == pointTool3.Parent)
					{
						pointTool2 = pointTool3;
					}
					else if (dictionary_2.ContainsKey(pointTool3.Parent))
					{
						if (dictionary_2[pointTool3.Parent] && !CanvasControl.smethod_1(pointTool3.Parent, currentNode))
						{
							list.Add(pointTool3);
							flag = true;
						}
						else if (!dictionary_2[pointTool3.Parent] && CanvasControl.smethod_1(pointTool3.Parent, currentNode) && ((LineTool)drawObjectBase_2).Ends.Count<PointTool>() == 2)
						{
							dictionary_2.Remove(drawObjectBase_2);
							break;
						}
					}
					else if (CanvasControl.GetAllPower(pointTool3.Parent, treeNodeObj, dictionary_2))
					{
						flag = true;
						list.Add(pointTool3);
					}
				}
				else
				{
					foreach (Branch branch2 in pointTool3.Branches)
					{
						if (branch2.Parent == null || branch2.Parent != drawObjectBase_2)
						{
							if (branch2.Parent == currentNode.Tag)
							{
								pointTool2 = pointTool3;
							}
							else if (dictionary_2.ContainsKey(branch2.Parent))
							{
								if (dictionary_2[branch2.Parent] && !CanvasControl.smethod_1(branch2.Parent, currentNode))
								{
									list.Add(pointTool3);
									flag = true;
								}
							}
							else if (CanvasControl.GetAllPower(branch2.Parent, treeNodeObj, dictionary_2))
							{
								flag = true;
								list.Add(pointTool3);
							}
						}
					}
				}
			}
			if (pointTool2 == null)
			{
				treeNodeObj.Tag = drawObjectBase_2;
			}
			else
			{
				BranchCollection branchCollection = new BranchCollection();
				foreach (PointTool pointTool_ in list)
				{
					BranchCollection wayOnLineTool = ((LineTool)drawObjectBase_2).GetWayOnLineTool(pointTool2, pointTool_);
					branchCollection += wayOnLineTool;
				}
				treeNodeObj.Tag = branchCollection;
			}
			IL_3A0:
			if (!flag)
			{
				currentNode.RemoveNode(treeNodeObj);
			}
			if (dictionary_2.ContainsKey(drawObjectBase_2))
			{
				dictionary_2[drawObjectBase_2] = flag;
			}
			return flag;
		}

		public static List<DrawObjectBase> GetAdjacentSubstation(DrawObjectBase drawObjectBase_2)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			if (drawObjectBase_2.GetType() == typeof(RectangleTool))
			{
				using (IEnumerator<DrawObjectBase> enumerator = drawObjectBase_2.ChildObjects.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						DrawObjectBase drawObjectBase = enumerator.Current;
						if (drawObjectBase is LineCellTool)
						{
							list.AddRange(CanvasControl.smethod_0((LineTool)drawObjectBase, null));
						}
					}
					return list;
				}
			}
			if (drawObjectBase_2.GetType() == typeof(ShinaTool))
			{
				foreach (DrawObjectBase drawObjectBase2 in drawObjectBase_2.ChildObjects)
				{
					if (drawObjectBase2.GetType() == typeof(PointShinaTool) && ((PointShinaTool)drawObjectBase2).CouplingRelations.Count > 0)
					{
						LineTool lineTool = (LineTool)((PointShinaTool)drawObjectBase2).Branches.First<Branch>().Parent;
						bool flag = true;
						foreach (PointTool pointTool in lineTool.Ends)
						{
							if (pointTool.Parent != null)
							{
								if (pointTool.Parent.GetType() == typeof(ShinaTool))
								{
									continue;
								}
							}
							flag = false;
							break;
						}
						if (!flag)
						{
							list.AddRange(CanvasControl.smethod_0(lineTool, null));
						}
					}
				}
			}
			return list;
		}

		private static List<DrawObjectBase> smethod_0(LineTool lineTool_0, PointTool pointTool_0)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (PointTool pointTool in lineTool_0.Ends)
			{
				if (pointTool != pointTool_0)
				{
					if (pointTool.Parent != null && pointTool.Parent != lineTool_0 && pointTool.Parent.Parent != null && pointTool.Parent.Parent.GetType() == typeof(RectangleTool))
					{
						list.Add(pointTool.Parent.Parent);
						list.AddRange(pointTool.Parent.Parent.ChildObjects);
						list.Add(lineTool_0);
					}
					else if (pointTool.Parent == null || pointTool.Parent == lineTool_0)
					{
						foreach (Branch branch in pointTool.Branches)
						{
							if (branch.Parent != lineTool_0)
							{
								list.AddRange(CanvasControl.smethod_0((LineTool)branch.Parent, pointTool));
							}
						}
					}
				}
			}
			return list;
		}

		private static bool smethod_1(DrawObjectBase drawObjectBase_2, TreeNodeObj treeNodeObj_0)
		{
			TreeNodeObj treeNodeObj = treeNodeObj_0;
			while (treeNodeObj.Tag != drawObjectBase_2)
			{
				if (treeNodeObj.Parent == null)
				{
					return false;
				}
				treeNodeObj = treeNodeObj.Parent;
			}
			return true;
		}

		private bool method_66()
		{
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			sqlDataConnect.OpenConnection(this.SqlSettings);
			SqlDataReader sqlDataReader = new SqlCommand("sp_sysgetlockedtable", sqlDataConnect.Connection)
			{
				CommandType = CommandType.StoredProcedure
			}.ExecuteReader();
			while (sqlDataReader.Read())
			{
				if (sqlDataReader["ObjName"].ToString() == this.dataSetScheme_0.tSchm_Lock.TableName)
				{
					MessageBox.Show("Другой пользователь находится в монопольном режиме редактирования.\nПользователь: " + sqlDataReader["LoginName"].ToString().Trim() + "\nХост: " + sqlDataReader["HostName"].ToString().Trim());
					sqlDataConnect.CloseConnection();
					return true;
				}
			}
			sqlDataConnect.CloseConnection();
			return false;
		}

		private bool method_67()
		{
			if (!this.method_66())
			{
				this.dataSetScheme_0.tSchm_Lock.Clear();
				this.dataSetScheme_0.tSchm_Lock.NewRow();
				this.dataSetScheme_0.tSchm_Lock.Rows.Add(new object[0]);
				SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
				sqlDataCommand.InsertSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_Lock);
				this.dataSetScheme_0.tSchm_Lock.Clear();
				SqlDataConnect sqlDataConnect = new SqlDataConnect();
				sqlDataConnect.OpenConnection(this.SqlSettings);
				this.sqlTransaction_0 = sqlDataConnect.Connection.BeginTransaction();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand
				{
					Connection = sqlDataConnect.Connection,
					Transaction = this.sqlTransaction_0,
					CommandText = "SELECT * FROM tSchm_Lock WITH(Serializable)"
				});
				sqlDataAdapter.Fill(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_Lock.TableName);
				MessageBox.Show("Вы вошли в монопольный режим редактирования");
				return true;
			}
			return false;
		}

		private void method_68()
		{
			if (this.sqlTransaction_0 != null)
			{
				try
				{
					this.sqlTransaction_0.Commit();
				}
				catch
				{
				}
			}
		}

		public void SendServAddOrChange(DrawObjectBase drawObjectBase_2, bool chldren)
		{
			if (drawObjectBase_2.GetType().BaseType == typeof(ObjectOnLine))
			{
				ObjectOnLineServer objectOnLineServer = new ObjectOnLineServer();
				objectOnLineServer.Id = drawObjectBase_2.IdBase;
				objectOnLineServer.Delta = Convert.ToSingle(((ObjectOnLine)drawObjectBase_2).Delta);
				objectOnLineServer.On = ((ObjectOnLine)drawObjectBase_2).On;
				objectOnLineServer.GorMirror = ((ObjectOnLine)drawObjectBase_2).GorMirror;
				objectOnLineServer.VertMirror = ((ObjectOnLine)drawObjectBase_2).VertMirror;
				if (drawObjectBase_2.GetType() == typeof(DischargerTool))
				{
					objectOnLineServer.TypeObjectOnLine = TypeSwitch.DischargerTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(FuseTool))
				{
					objectOnLineServer.TypeObjectOnLine = TypeSwitch.FuseTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(GroundingTool))
				{
					objectOnLineServer.TypeObjectOnLine = TypeSwitch.GroundingTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(LinearDisconnectorTool))
				{
					objectOnLineServer.TypeObjectOnLine = TypeSwitch.LinearDisconnectorTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(LoadSwitchTool))
				{
					objectOnLineServer.TypeObjectOnLine = TypeSwitch.LoadSwitchTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(LubricantSwitchTool))
				{
					objectOnLineServer.TypeObjectOnLine = TypeSwitch.LubricantSwitchTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(NotPhasedTool))
				{
					objectOnLineServer.TypeObjectOnLine = TypeSwitch.NotPhasedTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(OffTool))
				{
					objectOnLineServer.TypeObjectOnLine = TypeSwitch.OffTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(OutsideLineDisconnectorTool))
				{
					objectOnLineServer.TypeObjectOnLine = TypeSwitch.OutsideLineDisconnectorTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(TransformerTool))
				{
					objectOnLineServer.TypeObjectOnLine = TypeSwitch.TransformerTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(VacuumSwitchTool))
				{
					objectOnLineServer.TypeObjectOnLine = TypeSwitch.VacuumSwitchTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(VoltageLimiterTool))
				{
					objectOnLineServer.TypeObjectOnLine = TypeSwitch.VoltageLimiterTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(VoltageTransformerTool))
				{
					objectOnLineServer.TypeObjectOnLine = TypeSwitch.VoltageTransformerTool;
					return;
				}
				if (drawObjectBase_2.GetType() == typeof(DamageTool))
				{
					objectOnLineServer.TypeObjectOnLine = TypeSwitch.DamageTool;
					return;
				}
			}
			else
			{
				ObjectBaseServer objectBaseServer = new ObjectBaseServer();
				objectBaseServer.Id = drawObjectBase_2.IdBase;
				if (drawObjectBase_2.Parent != null)
				{
					objectBaseServer.Id = drawObjectBase_2.Parent.IdBase;
				}
				else
				{
					objectBaseServer.Id = -1;
				}
				if (drawObjectBase_2.GetType() != typeof(RectangleTool))
				{
					if (drawObjectBase_2.GetType() != typeof(ShinaTool))
					{
						if (drawObjectBase_2.GetType() == typeof(PointTool))
						{
							objectBaseServer.TypeTransferObject = eTypeTransferObject.Point;
							objectBaseServer.ListPoints.Add(((PointTool)drawObjectBase_2).Point);
							return;
						}
						if (drawObjectBase_2.GetType() == typeof(LineCellTool) || drawObjectBase_2.GetType() == typeof(LineTool))
						{
							if (drawObjectBase_2.GetType() == typeof(LineCellTool))
							{
								objectBaseServer.TypeTransferObject = eTypeTransferObject.Cell;
							}
							else
							{
								objectBaseServer.TypeTransferObject = eTypeTransferObject.Line;
							}
							List<PointTool> pointsList = ((LineTool)drawObjectBase_2).GetPointsList();
							foreach (PointTool pointTool in pointsList)
							{
								PointServerTool pointServerTool = new PointServerTool();
								pointServerTool.Point = pointTool.Point;
								pointServerTool.Id = pointTool.IdBase;
								objectBaseServer.ListPointsTool.Add(pointServerTool);
							}
							foreach (CouplingRelation couplingRelation in ((LineTool)drawObjectBase_2).CouplingRelations)
							{
								RelationServer item = default(RelationServer);
								item.int_0 = couplingRelation.Id;
								item.SourcePoint = couplingRelation.Vertex1.IdBase;
								item.DestenationPoint = couplingRelation.Vertex2.IdBase;
								objectBaseServer.Relations.Add(item);
							}
							foreach (Branch branch in ((LineTool)drawObjectBase_2).Branches)
							{
								BranchServer item2 = default(BranchServer);
								item2.type = branch.Type;
								item2.SourcePoint = pointsList.IndexOf(branch.Source);
								item2.DestenationPoint = pointsList.IndexOf(branch.Destination);
								item2.Relation = branch.CouplingRelation.Id;
								item2.childObjects = new List<int>();
								foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
								{
									if (drawObjectBase.GetType().BaseType == typeof(ObjectOnLine))
									{
										if (!((ObjectOnLine)drawObjectBase).MappingState)
										{
											item2.childObjects.Add(drawObjectBase.IdBase);
										}
										else
										{
											if (item2.States == null)
											{
												item2.States = new List<LineStateServer>();
											}
											LineStateServer item3 = default(LineStateServer);
											item3.type = (int)((ObjectOnLine)drawObjectBase).State.state;
											item3.delta = Convert.ToSingle(((ObjectOnLine)drawObjectBase).Delta);
											item3.VertMirror = ((ObjectOnLine)drawObjectBase).VertMirror;
											item3.GorMirror = ((ObjectOnLine)drawObjectBase).GorMirror;
											item2.States.Add(item3);
										}
									}
								}
								objectBaseServer.Branches.Add(item2);
							}
							return;
						}
						return;
					}
				}
				foreach (DrawObjectBase drawObjectBase2 in drawObjectBase_2.ChildObjects)
				{
					objectBaseServer.ChildrenObjects.Add(drawObjectBase2.IdBase);
				}
				if (drawObjectBase_2.GetType() == typeof(RectangleTool))
				{
					objectBaseServer.ListPoints.Add(new UnitPoint(((RectangleTool)drawObjectBase_2).Rectangle.Location));
					objectBaseServer.ListPoints.Add(new UnitPoint(((RectangleTool)drawObjectBase_2).Rectangle.Location + ((RectangleTool)drawObjectBase_2).Rectangle.Size));
					objectBaseServer.TypeRectangle = ((RectangleTool)drawObjectBase_2).TypeRectnagleTool;
					objectBaseServer.TypeTransferObject = eTypeTransferObject.Rectangle;
					return;
				}
				objectBaseServer.ListPoints.Add(((ShinaTool)drawObjectBase_2).P1);
				objectBaseServer.ListPoints.Add(((ShinaTool)drawObjectBase_2).P2);
				objectBaseServer.TypeTransferObject = eTypeTransferObject.Shina;
				objectBaseServer.TypeShina = ((ShinaTool)drawObjectBase_2).TypeShinaTool;
				return;
			}
		}

		public DrawObjectBase FindObjectById(int int_10)
		{
			Func<DrawObjectBase, bool> func = null;
			CanvasControl.Class35 @class = new CanvasControl.Class35();
			@class.int_0 = int_10;
			DrawObjectBase drawObjectBase = null;
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				try
				{
					IEnumerable<DrawObjectBase> objects = canvasLayer.Objects;
					if (func == null)
					{
						func = new Func<DrawObjectBase, bool>(@class.method_0);
					}
					drawObjectBase = objects.Single(func);
					if (drawObjectBase != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
			return drawObjectBase;
		}

		private List<DrawObjectBase> method_69(DrawObjectBase drawObjectBase_2)
		{
			Func<DrawObjectBase, bool> func = null;
			Func<DrawObjectBase, bool> func2 = null;
			CanvasControl.Class36 @class = new CanvasControl.Class36();
			@class.drawObjectBase_0 = drawObjectBase_2;
			@class.list_0 = new List<DrawObjectBase>();
			if (this.eTypeCanvas_0 != eTypeCanvas.SchemeSecond)
			{
				return @class.list_0;
			}
			if (@class.drawObjectBase_0.LimitedEditing)
			{
				@class.list_0.Add(@class.drawObjectBase_0.Master);
				return @class.list_0;
			}
			RectangleTool rectangleTool = null;
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				DrawingLayer drawingLayer = (DrawingLayer)canvasLayer;
				IEnumerable<DrawObjectBase> objects = drawingLayer.Objects;
				if (CanvasControl.func_73 == null)
				{
					CanvasControl.func_73 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_75);
				}
				using (IEnumerator<DrawObjectBase> enumerator2 = objects.Where(CanvasControl.func_73).GetEnumerator())
				{
					if (enumerator2.MoveNext())
					{
						DrawObjectBase drawObjectBase = enumerator2.Current;
						rectangleTool = (RectangleTool)drawObjectBase;
					}
				}
				if (rectangleTool != null)
				{
					break;
				}
			}
			if (rectangleTool == null || rectangleTool.Master == null)
			{
				return null;
			}
			if (rectangleTool.Master.Layer.Parent.Mode != eCanvasEditingMode.Edit)
			{
				return @class.list_0;
			}
			if (rectangleTool == @class.drawObjectBase_0)
			{
				@class.list_0.Add(@class.drawObjectBase_0.Master);
				return @class.list_0;
			}
			using (IEnumerator<DrawObjectBase> enumerator2 = rectangleTool.Master.ChildObjects.Where(new Func<DrawObjectBase, bool>(@class.method_0)).GetEnumerator())
			{
				if (enumerator2.MoveNext())
				{
					DrawObjectBase item = enumerator2.Current;
					@class.list_0.Add(item);
					return @class.list_0;
				}
			}
			using (IEnumerator<DrawObjectBase> enumerator2 = rectangleTool.Master.Layer.Objects.Where(new Func<DrawObjectBase, bool>(@class.method_1)).GetEnumerator())
			{
				if (enumerator2.MoveNext())
				{
					DrawObjectBase item2 = enumerator2.Current;
					@class.list_0.Add(item2);
					return @class.list_0;
				}
			}
			if (@class.drawObjectBase_0 is ShinaTool)
			{
				if (((ShinaTool)@class.drawObjectBase_0).TypeShinaTool == eTypeShinaTool.Shina_10 || ((ShinaTool)@class.drawObjectBase_0).TypeShinaTool == eTypeShinaTool.Shina_6)
				{
					ShinaTool shinaTool = new ShinaTool();
					shinaTool.IdBase = @class.drawObjectBase_0.IdBase;
					shinaTool.Text = @class.drawObjectBase_0.Text;
					shinaTool.P1 = new UnitPoint((double)((RectangleTool)rectangleTool.Master).Rectangle.X, (double)((RectangleTool)rectangleTool.Master).Rectangle.Y);
					shinaTool.P2 = new UnitPoint((double)(((RectangleTool)rectangleTool.Master).Rectangle.X + 1f), (double)((RectangleTool)rectangleTool.Master).Rectangle.Y);
					shinaTool.Parent = rectangleTool.Master;
					shinaTool.TypeShinaTool = ((ShinaTool)@class.drawObjectBase_0).TypeShinaTool;
					rectangleTool.Master.Layer.AddObject(shinaTool);
					shinaTool.LimitedEditing = true;
					rectangleTool.Master.Layer.Parent.DoInvalidate(true);
					@class.list_0.Add(shinaTool);
				}
				return @class.list_0;
			}
			if (@class.drawObjectBase_0.GetType() == typeof(LineCellTool))
			{
				if (((LineCellTool)@class.drawObjectBase_0).Type == LineToolType.CellLine_10 || ((LineCellTool)@class.drawObjectBase_0).Type == LineToolType.CellLine_6)
				{
					LineCellTool lineCellTool = new LineCellTool();
					lineCellTool.IdBase = @class.drawObjectBase_0.IdBase;
					lineCellTool.Text = @class.drawObjectBase_0.Text;
					lineCellTool.Parent = rectangleTool.Master;
					lineCellTool.LimitedEditing = true;
					List<ShinaTool> list = new List<ShinaTool>();
					List<PointTool> list2 = new List<PointTool>();
					UnitPoint unitPoint = default(UnitPoint);
					foreach (PointTool pointTool in ((LineCellTool)@class.drawObjectBase_0).Ends)
					{
						if (pointTool.Parent != null && pointTool.Parent.GetType() == typeof(ShinaTool))
						{
							List<DrawObjectBase> list3 = this.method_69(pointTool.Parent);
							if (list3.Count != 0)
							{
								ShinaTool shinaTool2 = null;
								IEnumerable<DrawObjectBase> source = list3;
								if (func == null)
								{
									func = new Func<DrawObjectBase, bool>(@class.method_2);
								}
								foreach (DrawObjectBase drawObjectBase2 in source.Where(func))
								{
									@class.list_0.Add(drawObjectBase2);
									if (drawObjectBase2.IdBase == pointTool.Parent.IdBase)
									{
										shinaTool2 = (ShinaTool)drawObjectBase2;
									}
								}
								if (shinaTool2 == null)
								{
									return @class.list_0;
								}
								list.Add((ShinaTool)pointTool.Parent);
								PointShinaTool pointShinaTool = new PointShinaTool();
								pointShinaTool.IdBase = pointTool.IdBase;
								shinaTool2.AddPointShinaTool(pointShinaTool);
								pointShinaTool.Delta = 0.5f;
								list2.Add(pointShinaTool);
								if (unitPoint.X == 0.0 && unitPoint.Y == 0.0)
								{
									unitPoint = new UnitPoint(pointShinaTool.Point.X - pointTool.Point.X, pointShinaTool.Point.Y - pointTool.Point.Y);
								}
								else
								{
									unitPoint = new UnitPoint((unitPoint.X + (pointShinaTool.Point.X - pointTool.Point.X)) / 2.0, (unitPoint.Y + (pointShinaTool.Point.Y - pointTool.Point.Y)) / 2.0);
								}
							}
						}
					}
					if (list2.Count == 0)
					{
						return @class.list_0;
					}
					Dictionary<CouplingRelation, CouplingRelation> dictionary = new Dictionary<CouplingRelation, CouplingRelation>();
					using (List<CouplingRelation>.Enumerator enumerator4 = ((LineTool)@class.drawObjectBase_0).CouplingRelations.GetEnumerator())
					{
						Func<PointTool, bool> func3 = null;
						Func<PointTool, bool> func4 = null;
						CanvasControl.Class37 class2 = new CanvasControl.Class37();
						class2.class36_0 = @class;
						while (enumerator4.MoveNext())
						{
							CouplingRelation couplingRelation_ = enumerator4.Current;
							class2.couplingRelation_0 = couplingRelation_;
							IEnumerable<PointTool> source2 = list2;
							if (func3 == null)
							{
								func3 = new Func<PointTool, bool>(class2.method_0);
							}
							IEnumerable<PointTool> source3 = source2.Where(func3);
							PointTool pointTool2;
							if (source3.Count<PointTool>() > 0)
							{
								pointTool2 = source3.First<PointTool>();
							}
							else
							{
								pointTool2 = new PointTool();
								pointTool2.IdBase = class2.couplingRelation_0.Vertex1.IdBase;
								if (class2.couplingRelation_0.Vertex1.Parent != null && class2.couplingRelation_0.Vertex1.Parent == class2.couplingRelation_0.Line)
								{
									pointTool2.Parent = lineCellTool;
								}
								pointTool2.Point = new UnitPoint(unitPoint.X + class2.couplingRelation_0.Vertex1.Point.X, unitPoint.Y + class2.couplingRelation_0.Vertex1.Point.Y);
								list2.Add(pointTool2);
							}
							IEnumerable<PointTool> source4 = list2;
							if (func4 == null)
							{
								func4 = new Func<PointTool, bool>(class2.method_1);
							}
							source3 = source4.Where(func4);
							PointTool pointTool3;
							if (source3.Count<PointTool>() > 0)
							{
								pointTool3 = source3.First<PointTool>();
							}
							else
							{
								pointTool3 = new PointTool();
								pointTool3.IdBase = class2.couplingRelation_0.Vertex2.IdBase;
								if (class2.couplingRelation_0.Vertex2.Parent != null && class2.couplingRelation_0.Vertex2.Parent == class2.couplingRelation_0.Line)
								{
									pointTool3.Parent = lineCellTool;
								}
								pointTool3.Point = new UnitPoint(unitPoint.X + class2.couplingRelation_0.Vertex2.Point.X, unitPoint.Y + class2.couplingRelation_0.Vertex2.Point.Y);
								list2.Add(pointTool3);
							}
							CouplingRelation couplingRelation = new CouplingRelation(pointTool2, pointTool3);
							couplingRelation.Id = class2.couplingRelation_0.Id;
							lineCellTool.CouplingRelations.Add(couplingRelation);
							dictionary.Add(class2.couplingRelation_0, couplingRelation);
						}
					}
					using (List<Branch>.Enumerator enumerator5 = ((LineTool)@class.drawObjectBase_0).Branches.GetEnumerator())
					{
						Func<PointTool, bool> func5 = null;
						Func<PointTool, bool> func6 = null;
						CanvasControl.Class38 class3 = new CanvasControl.Class38();
						class3.class36_0 = @class;
						while (enumerator5.MoveNext())
						{
							Branch branch_ = enumerator5.Current;
							class3.branch_0 = branch_;
							IEnumerable<PointTool> source5 = list2;
							if (func5 == null)
							{
								func5 = new Func<PointTool, bool>(class3.method_0);
							}
							IEnumerable<PointTool> source6 = source5.Where(func5);
							PointTool pointTool4;
							if (source6.Count<PointTool>() > 0)
							{
								pointTool4 = source6.First<PointTool>();
							}
							else
							{
								pointTool4 = new PointTool();
								if (class3.branch_0.Source.IdBase > 0)
								{
									pointTool4.IdBase = class3.branch_0.Source.IdBase;
								}
								if (class3.branch_0.Source.Parent != null && class3.branch_0.Source.Parent == rectangleTool)
								{
									pointTool4.Parent = rectangleTool.Master;
								}
								pointTool4.Point = new UnitPoint(unitPoint.X + class3.branch_0.Source.Point.X, unitPoint.Y + class3.branch_0.Source.Point.Y);
								list2.Add(pointTool4);
							}
							IEnumerable<PointTool> source7 = list2;
							if (func6 == null)
							{
								func6 = new Func<PointTool, bool>(class3.method_1);
							}
							source6 = source7.Where(func6);
							PointTool pointTool5;
							if (source6.Count<PointTool>() > 0)
							{
								pointTool5 = source6.First<PointTool>();
							}
							else
							{
								pointTool5 = new PointTool();
								if (class3.branch_0.Destination.IdBase > 0)
								{
									pointTool5.IdBase = class3.branch_0.Destination.IdBase;
								}
								if (class3.branch_0.Destination.Parent != null && class3.branch_0.Destination.Parent == rectangleTool)
								{
									pointTool5.Parent = rectangleTool.Master;
								}
								pointTool5.Point = new UnitPoint(unitPoint.X + class3.branch_0.Destination.Point.X, unitPoint.Y + class3.branch_0.Destination.Point.Y);
								list2.Add(pointTool5);
							}
							Branch item3 = new Branch(lineCellTool, pointTool4, pointTool5, class3.branch_0.Type, dictionary[class3.branch_0.CouplingRelation]);
							lineCellTool.Branches.Add(item3);
						}
					}
					rectangleTool.Master.Layer.AddObject(lineCellTool);
					lineCellTool.LimitedEditing = true;
					rectangleTool.Master.Layer.Parent.DoInvalidate(true);
					@class.list_0.Add(lineCellTool);
				}
				return @class.list_0;
			}
			if (@class.drawObjectBase_0.GetType() == typeof(LineTool))
			{
				LineTool lineTool = new LineTool();
				lineTool.IdBase = @class.drawObjectBase_0.IdBase;
				lineTool.Text = @class.drawObjectBase_0.Text;
				lineTool.LimitedEditing = true;
				List<LineCellTool> list4 = new List<LineCellTool>();
				List<PointTool> list5 = new List<PointTool>();
				UnitPoint unitPoint2 = default(UnitPoint);
				using (IEnumerator<PointTool> enumerator3 = ((LineTool)@class.drawObjectBase_0).Ends.GetEnumerator())
				{
					Func<PointTool, bool> func7 = null;
					CanvasControl.Class39 class4 = new CanvasControl.Class39();
					class4.class36_0 = @class;
					while (enumerator3.MoveNext())
					{
						PointTool pointTool_ = enumerator3.Current;
						class4.pointTool_0 = pointTool_;
						if (class4.pointTool_0.Parent != null && ((class4.pointTool_0.Parent.GetType() == typeof(LineCellTool) && ((LineCellTool)class4.pointTool_0.Parent).Type == LineToolType.CellLine_10) || ((LineCellTool)class4.pointTool_0.Parent).Type == LineToolType.CellLine_6))
						{
							List<DrawObjectBase> list6 = this.method_69(class4.pointTool_0.Parent);
							if (list6.Count == 0)
							{
								throw new Exception("Про не смогли отразить ячейку");
							}
							IEnumerable<DrawObjectBase> source8 = list6;
							if (func2 == null)
							{
								func2 = new Func<DrawObjectBase, bool>(@class.method_3);
							}
							foreach (DrawObjectBase drawObjectBase3 in source8.Where(func2))
							{
								@class.list_0.Add(drawObjectBase3);
								if (drawObjectBase3.GetType() == typeof(LineCellTool) && drawObjectBase3.IdBase == class4.pointTool_0.Parent.IdBase)
								{
									list4.Add((LineCellTool)drawObjectBase3);
									IEnumerable<PointTool> ends = ((LineCellTool)drawObjectBase3).Ends;
									if (func7 == null)
									{
										func7 = new Func<PointTool, bool>(class4.method_0);
									}
									using (IEnumerator<PointTool> enumerator6 = ends.Where(func7).GetEnumerator())
									{
										if (enumerator6.MoveNext())
										{
											PointTool pointTool6 = enumerator6.Current;
											list5.Add(pointTool6);
											if (unitPoint2.X == 0.0 && unitPoint2.Y == 0.0)
											{
												unitPoint2 = new UnitPoint(pointTool6.Point.X - class4.pointTool_0.Point.X, pointTool6.Point.Y - class4.pointTool_0.Point.Y);
											}
											else
											{
												unitPoint2 = new UnitPoint((unitPoint2.X + (pointTool6.Point.X - class4.pointTool_0.Point.X)) / 2.0, (unitPoint2.Y + (pointTool6.Point.Y - class4.pointTool_0.Point.Y)) / 2.0);
											}
										}
									}
								}
							}
						}
					}
				}
				if (list5.Count == 0)
				{
					return @class.list_0;
				}
				Dictionary<CouplingRelation, CouplingRelation> dictionary2 = new Dictionary<CouplingRelation, CouplingRelation>();
				using (List<CouplingRelation>.Enumerator enumerator4 = ((LineTool)@class.drawObjectBase_0).CouplingRelations.GetEnumerator())
				{
					Func<PointTool, bool> func8 = null;
					Func<PointTool, bool> func9 = null;
					CanvasControl.Class40 class5 = new CanvasControl.Class40();
					class5.class36_0 = @class;
					while (enumerator4.MoveNext())
					{
						CouplingRelation couplingRelation_2 = enumerator4.Current;
						class5.couplingRelation_0 = couplingRelation_2;
						IEnumerable<PointTool> source9 = list5;
						if (func8 == null)
						{
							func8 = new Func<PointTool, bool>(class5.method_0);
						}
						IEnumerable<PointTool> source10 = source9.Where(func8);
						PointTool pointTool7;
						if (source10.Count<PointTool>() > 0)
						{
							pointTool7 = source10.First<PointTool>();
						}
						else
						{
							pointTool7 = new PointTool();
							pointTool7.IdBase = class5.couplingRelation_0.Vertex1.IdBase;
							if (class5.couplingRelation_0.Vertex1.Parent != null && class5.couplingRelation_0.Vertex1.Parent == rectangleTool)
							{
								pointTool7.Parent = rectangleTool.Master;
							}
							pointTool7.Point = new UnitPoint(unitPoint2.X + class5.couplingRelation_0.Vertex1.Point.X, unitPoint2.Y + class5.couplingRelation_0.Vertex1.Point.Y);
							list5.Add(pointTool7);
						}
						IEnumerable<PointTool> source11 = list5;
						if (func9 == null)
						{
							func9 = new Func<PointTool, bool>(class5.method_1);
						}
						source10 = source11.Where(func9);
						PointTool pointTool8;
						if (source10.Count<PointTool>() > 0)
						{
							pointTool8 = source10.First<PointTool>();
						}
						else
						{
							pointTool8 = new PointTool();
							pointTool8.IdBase = class5.couplingRelation_0.Vertex2.IdBase;
							if (class5.couplingRelation_0.Vertex2.Parent != null && class5.couplingRelation_0.Vertex2.Parent == rectangleTool)
							{
								pointTool8.Parent = rectangleTool.Master;
							}
							pointTool8.Point = new UnitPoint(pointTool7.Point.X, pointTool7.Point.Y);
							list5.Add(pointTool8);
						}
						CouplingRelation couplingRelation2 = new CouplingRelation(pointTool7, pointTool8);
						couplingRelation2.Id = class5.couplingRelation_0.Id;
						lineTool.CouplingRelations.Add(couplingRelation2);
						dictionary2.Add(class5.couplingRelation_0, couplingRelation2);
					}
				}
				using (List<Branch>.Enumerator enumerator5 = ((LineTool)@class.drawObjectBase_0).Branches.GetEnumerator())
				{
					Func<PointTool, bool> func10 = null;
					Func<PointTool, bool> func11 = null;
					CanvasControl.Class41 class6 = new CanvasControl.Class41();
					class6.class36_0 = @class;
					while (enumerator5.MoveNext())
					{
						Branch branch_2 = enumerator5.Current;
						class6.branch_0 = branch_2;
						IEnumerable<PointTool> source12 = list5;
						if (func10 == null)
						{
							func10 = new Func<PointTool, bool>(class6.method_0);
						}
						IEnumerable<PointTool> source13 = source12.Where(func10);
						PointTool pointTool9;
						if (source13.Count<PointTool>() > 0)
						{
							pointTool9 = source13.First<PointTool>();
						}
						else
						{
							pointTool9 = new PointTool();
							if (class6.branch_0.Source.IdBase > 0)
							{
								pointTool9.IdBase = class6.branch_0.Source.IdBase;
							}
							if (class6.branch_0.Source.Parent != null && class6.branch_0.Source.Parent == rectangleTool)
							{
								pointTool9.Parent = rectangleTool.Master;
							}
							pointTool9.Point = new UnitPoint(unitPoint2.X + class6.branch_0.Source.Point.X, unitPoint2.Y + class6.branch_0.Source.Point.Y);
							list5.Add(pointTool9);
						}
						IEnumerable<PointTool> source14 = list5;
						if (func11 == null)
						{
							func11 = new Func<PointTool, bool>(class6.method_1);
						}
						source13 = source14.Where(func11);
						PointTool pointTool10;
						if (source13.Count<PointTool>() > 0)
						{
							pointTool10 = source13.First<PointTool>();
						}
						else
						{
							pointTool10 = new PointTool();
							if (class6.branch_0.Destination.IdBase > 0)
							{
								pointTool10.IdBase = class6.branch_0.Destination.IdBase;
							}
							if (class6.branch_0.Destination.Parent != null && class6.branch_0.Destination.Parent == rectangleTool)
							{
								pointTool10.Parent = rectangleTool.Master;
							}
							pointTool10.Point = new UnitPoint(unitPoint2.X + class6.branch_0.Destination.Point.X, unitPoint2.Y + class6.branch_0.Destination.Point.Y);
							list5.Add(pointTool10);
						}
						Branch item4 = new Branch(lineTool, pointTool9, pointTool10, class6.branch_0.Type, dictionary2[class6.branch_0.CouplingRelation]);
						lineTool.Branches.Add(item4);
					}
				}
				rectangleTool.Master.Layer.AddObject(lineTool);
				lineTool.LimitedEditing = true;
				rectangleTool.Master.Layer.Parent.DoInvalidate(true);
				@class.list_0.Add(lineTool);
				return @class.list_0;
			}
			else
			{
				if (!(@class.drawObjectBase_0 is ObjectOnLine))
				{
					return @class.list_0;
				}
				if (@class.drawObjectBase_0.Parent.Parent == null || @class.drawObjectBase_0.Parent.Parent.LimitedEditing)
				{
					return null;
				}
				LineTool drawObjectBase_3 = (LineTool)@class.drawObjectBase_0.Parent.Parent;
				@class.list_0 = this.method_69(drawObjectBase_3);
				if (@class.list_0.Count == 0)
				{
					return @class.list_0;
				}
				LineTool lineTool2 = (LineTool)@class.list_0.Last<DrawObjectBase>();
				CouplingRelation couplingRelation3 = null;
				foreach (CouplingRelation couplingRelation4 in lineTool2.CouplingRelations)
				{
					if (couplingRelation4.Id == ((Branch)@class.drawObjectBase_0.Parent).CouplingRelation.Id)
					{
						couplingRelation3 = couplingRelation4;
						break;
					}
				}
				if (couplingRelation3 != null && couplingRelation3.Branches.Count != 0)
				{
					ObjectOnLine objectOnLine = ObjectOnLine.CreateObjectOnLine(((ObjectOnLine)@class.drawObjectBase_0).TypeSwitch, couplingRelation3.Branches.First<Branch>());
					objectOnLine.IdBase = @class.drawObjectBase_0.IdBase;
					objectOnLine.Text = @class.drawObjectBase_0.Text;
					objectOnLine.Delta = ((ObjectOnLine)@class.drawObjectBase_0).Delta;
					objectOnLine.On = ((ObjectOnLine)@class.drawObjectBase_0).On;
					objectOnLine.RecalcAngle();
					rectangleTool.Master.Layer.AddObject(objectOnLine);
					objectOnLine.LimitedEditing = true;
					rectangleTool.Master.Layer.Parent.DoInvalidate(true);
					@class.list_0.Add(objectOnLine);
					return @class.list_0;
				}
				return @class.list_0;
			}
			List<DrawObjectBase> result;
			return result;
		}

		private void CanvasControl_Load(object sender, EventArgs e)
		{
			this.bigBoldButton.Visible = false;
			this.propertyGrid1.Visible = false;
			this.textBoxSearch.Visible = false;
			this.button1.Visible = false;
			this.toolStripMenuItemMeasurement.Visible = false;
		}

		public new void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected override void Dispose(bool disposing)
		{
			this.Disconnect();
			this.ProxySingleton.ProxyCallBackEvent -= this.ProxySingleton_ProxyCallBackEvent;
			this.ProxySingleton.ProxyEvent -= this.ProxySingleton_ProxyEvent;
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			if (!this.bool_7)
			{
				if (disposing)
				{
					if (this.graphics_0 != null)
					{
						this.graphics_0.Dispose();
					}
					if (this.dataSetScheme_0 != null)
					{
						this.dataSetScheme_0.Dispose();
					}
					if (this.control0_0 != null)
					{
						this.control0_0.Dispose();
					}
					if (this.timer_1 != null)
					{
						this.timer_1.Dispose();
					}
					if (this.staticImage != null)
					{
						this.staticImage.Dispose();
					}
					if (this.list_1 != null)
					{
						this.list_1.Clear();
					}
					if (this.backgroundLayer_0 != null)
					{
						this.backgroundLayer_0.Dispose();
					}
					if (this.list_4 != null)
					{
						this.list_4.Clear();
					}
					IEnumerable<KeyValuePair<int, PointTool>> source = this.loadedPoints;
					if (CanvasControl.func_74 == null)
					{
						CanvasControl.func_74 = new Func<KeyValuePair<int, PointTool>, int>(CanvasControl.smethod_76);
					}
					IEnumerable<int> source2 = source.Select(CanvasControl.func_74);
					while (source2.Count<int>() > 0)
					{
						this.loadedPoints[source2.First<int>()].Dispose();
						this.loadedPoints.Remove(source2.First<int>());
					}
					if (this.list_0 != null)
					{
						while (this.list_0.Count > 0)
						{
							if (this.list_0[0] is IDisposable)
							{
								((IDisposable)this.list_0[0]).Dispose();
								this.list_0.RemoveAt(0);
							}
							else
							{
								this.list_0[0] = null;
								this.list_0.RemoveAt(0);
							}
						}
					}
				}
				this.bool_7 = true;
			}
			this.method_68();
			base.Dispose(disposing);
		}

		~CanvasControl()
		{
			this.Dispose(false);
		}

		public void ShowFormAbnFromOldSchema(DrawObjectBase drawObjectBase_2, bool nextObj)
		{
			FormAbnFromOldSchema formAbnFromOldSchema = new FormAbnFromOldSchema(drawObjectBase_2, nextObj, this.SqlSettings);
			new Rectangle(new Point(base.Location.X + base.Size.Width / 2 - formAbnFromOldSchema.Size.Width / 2, base.Location.Y + base.Size.Height / 2 - formAbnFromOldSchema.Size.Height / 2), formAbnFromOldSchema.DisplayRectangle.Size);
			if (base.Parent is DockContentBase)
			{
				formAbnFromOldSchema.Show(((DockContentBase)base.Parent).DockPanel);
				return;
			}
			formAbnFromOldSchema.Show();
		}

		public void ShowFormSchmObjFile(DrawObjectBase drawObjectBase_2)
		{
			FormSchmObjFile formSchmObjFile = new FormSchmObjFile(drawObjectBase_2);
			formSchmObjFile.SqlSettings = this.SqlSettings;
			if (base.Parent is DockContentBase)
			{
				formSchmObjFile.Show(((DockContentBase)base.Parent).DockPanel);
				return;
			}
			formSchmObjFile.Show();
		}

		private void method_70(object sender, TreeNodeMouseClickEventArgs e)
		{
			DrawObjectBase drawObject = (DrawObjectBase)e.Node.Tag;
			this.SetObjectsInCenterScreen(drawObject, false, CanvasControl.SetObjectsInCenterScreenOptions.select);
		}

		public void UpdateMeasurementForBus()
		{
			DataTable dataTable = new DataTable();
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
				SqlCommand sqlCommand = new SqlCommand(string.Concat(new object[]
				{
					"SELECT [IdBus],(case when max([Ia]) >= max([Ib]) and max([Ia]) >= max([Ic]) then max([Ia]) else case when max([Ib]) >= max([Ic]) and max([Ib]) >= max([Ia]) then max([Ib]) else case when max([Ic]) >= max([Ia]) and max([Ic]) >= max([Ib]) then max([Ic]) end end end) as I\r\n                                                                                                FROM [tJ_MeasAmperageTransf] as mat\r\n                                                                                                inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n                                                                                                where  mat.deleted = 0 and m.[TypeDoc] = 1192 and  ((year(m.[DateD]) = ",
					this.Settings.MeasurementYear,
					" and month(m.[DateD]) between 1 and 11)or(year(m.[DateD]) = ",
					this.Settings.MeasurementYear,
					"-1 and month(m.[DateD])=12) ) and  mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n                                                                                                group by mat.[IdBus]"
				}));
				sqlCommand.Connection = sqlConnection;
				sqlConnection.Open();
				SqlDataReader reader = sqlCommand.ExecuteReader();
				dataTable.Load(reader);
				sqlConnection.Close();
			}
			catch
			{
			}
			IEnumerable<DrawObjectBase> objects = this.ActiveLayer.Objects;
			if (CanvasControl.func_75 == null)
			{
				CanvasControl.func_75 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_77);
			}
			foreach (DrawObjectBase drawObjectBase in objects.Where(CanvasControl.func_75))
			{
				DataRow[] array = dataTable.Select("IdBus=" + drawObjectBase.Parent.IdBase);
				if (array.Length > 0)
				{
					((MeasurementLabelTool)drawObjectBase).Value = Convert.ToInt32(array[0][1]);
				}
				else
				{
					((MeasurementLabelTool)drawObjectBase).Value = 0;
				}
			}
		}

		private void method_71(int int_10)
		{
			CanvasControl.Class42 @class = new CanvasControl.Class42();
			@class.int_0 = int_10;
			DataTable dataTable = new DataTable();
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
				SqlCommand sqlCommand = new SqlCommand(string.Concat(new object[]
				{
					"SELECT [IdBus],(case when max([Ia]) >= max([Ib]) and max([Ia]) >= max([Ic]) then max([Ia]) else case when max([Ib]) >= max([Ic]) and max([Ib]) >= max([Ia]) then max([Ib]) else case when max([Ic]) >= max([Ia]) and max([Ic]) >= max([Ib]) then max([Ic]) end end end) as I\r\n                                                                                                FROM [tJ_MeasAmperageTransf] as mat\r\n                                                                                                inner join [tJ_Measurement] as m on mat.[idMeasurement] = m.id\r\n                                                                                                where  mat.deleted = 0 and m.[TypeDoc] = 1192 and  mat.[IdBus] = ",
					@class.int_0,
					" and  ((year(m.[DateD]) = ",
					this.Settings.MeasurementYear,
					" and month(m.[DateD]) between 1 and 11)or(year(m.[DateD]) = ",
					this.Settings.MeasurementYear,
					"-1 and month(m.[DateD])=12) ) and  mat.[Ia] is not null and  mat.[Ib] is not null and  mat.[Ic] is not null \r\n                                                                                                group by mat.[IdBus]"
				}));
				sqlCommand.Connection = sqlConnection;
				sqlConnection.Open();
				SqlDataReader reader = sqlCommand.ExecuteReader();
				dataTable.Load(reader);
				sqlConnection.Close();
			}
			catch
			{
			}
			foreach (DrawObjectBase drawObjectBase in this.ActiveLayer.Objects.Where(new Func<DrawObjectBase, bool>(@class.method_0)))
			{
				DataRow[] array = dataTable.Select("IdBus=" + drawObjectBase.Parent.IdBase);
				if (array.Length > 0)
				{
					((MeasurementLabelTool)drawObjectBase).Value = Convert.ToInt32(array[0][1]);
				}
				else
				{
					((MeasurementLabelTool)drawObjectBase).Value = 0;
				}
			}
		}

		private void method_72(object sender, EventArgs e)
		{
		}

		public ContextMenuStrip ContextMenuRectangle
		{
			get
			{
				return this.contextMenuRectnagle;
			}
			set
			{
				this.contextMenuRectnagle = value;
			}
		}

		public ContextMenuStrip ContextMenuShina
		{
			get
			{
				return this.contextMenuShina;
			}
			set
			{
				this.contextMenuShina = value;
			}
		}

		public ContextMenuStrip ContextMenuSwitchTool
		{
			get
			{
				return this.contextMenuSwitchTool;
			}
			set
			{
				this.contextMenuSwitchTool = value;
			}
		}

		public ContextMenuStrip ContextMenuLineTool
		{
			get
			{
				return this.contextMenuLineTool;
			}
			set
			{
				this.contextMenuLineTool = value;
			}
		}

		private void toolStripMenuItem8_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				DrawObjectBase drawObjectBase = (DrawObjectBase)contextMenu.Tag;
				List<DrawObjectBase> powerSource = drawObjectBase.GetPowerSource();
				List<DrawObjectBase> list = new List<DrawObjectBase>();
				foreach (DrawObjectBase drawObjectBase2 in powerSource)
				{
					list.Add(drawObjectBase2);
					if (drawObjectBase2 is ShinaTool)
					{
						list.Add(drawObjectBase2.Parent);
					}
					if (drawObjectBase2 is Branch)
					{
						foreach (DrawObjectBase item in drawObjectBase2.ChildObjects)
						{
							list.Add(item);
						}
					}
				}
				if (Convert.ToInt32(((ToolStripDropDownItem)sender).Tag) == 1)
				{
					this.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
					return;
				}
				if (Convert.ToInt32(((ToolStripDropDownItem)sender).Tag) == 2)
				{
					this.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.flashing);
				}
			}
		}

		private void toolStripMenuItem9_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				DrawObjectBase drawObjectBase = (DrawObjectBase)contextMenu.Tag;
				List<DrawObjectBase> recipientsPower = drawObjectBase.GetRecipientsPower();
				List<DrawObjectBase> list = new List<DrawObjectBase>();
				foreach (DrawObjectBase drawObjectBase2 in recipientsPower)
				{
					list.Add(drawObjectBase2);
					if (drawObjectBase2 is ShinaTool)
					{
						list.Add(drawObjectBase2.Parent);
					}
					if (drawObjectBase2 is LineCellTool || drawObjectBase2 is LineTool)
					{
						foreach (Branch branch in ((LineTool)drawObjectBase2).Branches)
						{
							foreach (DrawObjectBase item in branch.ChildObjects)
							{
								list.Add(item);
							}
						}
					}
				}
				if (Convert.ToInt32(((ToolStripDropDownItem)sender).Tag) == 1)
				{
					this.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
					return;
				}
				if (Convert.ToInt32(((ToolStripDropDownItem)sender).Tag) == 2)
				{
					this.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.flashing);
				}
			}
		}

		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			this.CopySelectedObjects();
		}

		private void toolMenuItemLinePaste_Click(object sender, EventArgs e)
		{
			this.PasteInObjects(this.SelectedObjects.ToList<DrawObjectBase>());
		}

		private void toolMenuItemTextBranchDel_Click(object sender, EventArgs e)
		{
			if (this.Mode == eCanvasEditingMode.Edit)
			{
				this.RemoveSelectedObjects();
			}
		}

		private void toolMenuItemLineFile_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				DrawObjectBase drawObjectBase_ = (DrawObjectBase)contextMenu.Tag;
				this.ShowFormSchmObjFile(drawObjectBase_);
			}
		}

		private void toolMenuItemTextBranchProperty_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				DrawObjectBase drawObjectBase = (DrawObjectBase)contextMenu.Tag;
				if (drawObjectBase.ShowPropertyForm(contextMenu.Location))
				{
					DrawObjectsEventArgs drawObjectsEventArgs_ = new DrawObjectsEventArgs(drawObjectBase);
					this.OnSelectedObjectEdited(drawObjectsEventArgs_);
				}
			}
		}

		private void toolMenuItemLineFilterAdd_Click(object sender, EventArgs e)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase is Branch)
				{
					if (drawObjectBase.Parent != null && !list.Contains(drawObjectBase.Parent))
					{
						list.Add(drawObjectBase.Parent);
					}
				}
				else if (!list.Contains(drawObjectBase))
				{
					list.Add(drawObjectBase);
				}
			}
			new FormCanvasAddDelFilter(list, StateFormCreate.Add)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog();
		}

		private void toolMenuItemLineFilterDel_Click(object sender, EventArgs e)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase is Branch)
				{
					if (drawObjectBase.Parent != null && !list.Contains(drawObjectBase.Parent))
					{
						list.Add(drawObjectBase.Parent);
					}
				}
				else if (!list.Contains(drawObjectBase))
				{
					list.Add(drawObjectBase);
				}
			}
			new FormCanvasAddDelFilter(list, StateFormCreate.Delete)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog();
		}

		private void toolStripMenuItemBookmark_Click(object sender, EventArgs e)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			list.AddRange(this.SelectedObjects);
			foreach (DrawObjectBase drawObjectBase in list)
			{
				if (drawObjectBase.Bookmark != null && this.list_6.Contains(drawObjectBase.Bookmark) && drawObjectBase.Bookmark.Count == 1)
				{
					drawObjectBase.Bookmark.Clear();
					this.list_6.Remove(drawObjectBase.Bookmark);
				}
				drawObjectBase.Bookmark = list;
			}
			this.list_6.Add(list);
			this.DoInvalidate(true);
		}

		private void toolStripMenuItemRemoveBookmark_Click(object sender, EventArgs e)
		{
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase.Bookmark != null && this.list_6.Contains(drawObjectBase.Bookmark))
				{
					drawObjectBase.Bookmark.Clear();
					this.list_6.Remove(drawObjectBase.Bookmark);
					drawObjectBase.Bookmark = null;
				}
			}
			this.DoInvalidate(true);
		}

		private void contextMenuRectnagle_Opening(object sender, CancelEventArgs e)
		{
			this.toolMenuItemRectAlign.Enabled = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemRectDel.Enabled = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemRectPaste.Enabled = (this.Mode == eCanvasEditingMode.Edit && CopyPasteCanvasObjects.IsPasteInObjects(this.SelectedObjects.ToList<DrawObjectBase>(), this.list_7));
		}

		private void toolMenuItemRectAlign_Click(object sender, EventArgs e)
		{
			if (this.ContextMenuRectangle.Tag != null)
			{
				RectangleTool rectangleTool = (RectangleTool)this.ContextMenuRectangle.Tag;
				foreach (DrawObjectBase drawObjectBase in rectangleTool.ChildObjects)
				{
					if (drawObjectBase.Layer != null)
					{
						drawObjectBase.Align();
					}
				}
				rectangleTool.Save(false, true);
			}
		}

		private void toolStripMenuItemAdjacentSubstation2_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag == null)
			{
				return;
			}
			DrawObjectBase drawObjectBase_ = (DrawObjectBase)contextMenu.Tag;
			List<DrawObjectBase> adjacentSubstation = CanvasControl.GetAdjacentSubstation(drawObjectBase_);
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in adjacentSubstation)
			{
				list.Add(drawObjectBase);
				if (drawObjectBase is LineTool || drawObjectBase is LineCellTool)
				{
					foreach (Branch branch in ((LineTool)drawObjectBase).Branches)
					{
						foreach (DrawObjectBase item in branch.ChildObjects)
						{
							list.Add(item);
						}
					}
				}
			}
			this.SetObjectsInCenterScreen(list, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
		}

		private void toolStripMenuItem14_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag == null)
			{
				return;
			}
			DrawObjectBase drawObjectBase_ = (DrawObjectBase)contextMenu.Tag;
			this.ShowFormAbnFromOldSchema(drawObjectBase_, Convert.ToInt32(((ToolStripMenuItem)sender).Tag) == 1);
		}

		private void contextMenuShina_Opening(object sender, CancelEventArgs e)
		{
			this.toolStripMenuItemShinaAddTelemetryLabel.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolStripMenuItemMeasurement.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemShinaDel.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemShinaAddChild.Visible = (this.Mode == eCanvasEditingMode.Edit || this.Mode == eCanvasEditingMode.Dispatcher);
			this.toolMenuItemShinaAddCell.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolStripSeparatorEditShina.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMeniItemShinaAddPattern.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemShinaAddPatternAbnReserve.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemShinaAddPatternAbn.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemShinaAddPatternAbnAuto.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemShinaPaste.Enabled = (this.Mode == eCanvasEditingMode.Edit && CopyPasteCanvasObjects.IsPasteInObjects(this.SelectedObjects.ToList<DrawObjectBase>(), this.list_7));
			if (((ContextMenuStrip)sender).Tag != null)
			{
				ShinaTool shinaTool = (ShinaTool)((ContextMenuStrip)sender).Tag;
				if (shinaTool.TypeShinaTool == eTypeShinaTool.Shina_6 || shinaTool.TypeShinaTool == eTypeShinaTool.Shina_10)
				{
					this.toolMeniItemShinaAddPattern.Visible = false;
				}
			}
		}

		private void toolMenuItemShinaAddCell_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				ShinaTool shinaTool = (ShinaTool)contextMenu.Tag;
				shinaTool.AddCellLineTool();
			}
		}

		private void toolMenuItemShinaBridge_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				ShinaTool shinaTool = (ShinaTool)contextMenu.Tag;
				shinaTool.AddBridgeShinaTool();
			}
		}

		private void toolMenuItemShinaSplitter_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				ShinaTool shinaTool = (ShinaTool)contextMenu.Tag;
				shinaTool.AddSplitterShinaTool();
			}
		}

		private void toolStripMenuItemAddWhitePoint_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				ShinaTool shinaTool = (ShinaTool)contextMenu.Tag;
				shinaTool.AddWhitePoint();
			}
			this.DoInvalidate(true);
		}

		private void toolStripMenuItemBusMeasurement_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ShinaTool shinaTool = (ShinaTool)contextMenu.Tag;
			if (base.Parent != null && base.Parent is DockContentBase)
			{
				Form form = base.FindForm();
				if (form is FormBase)
				{
					ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
					showFormEventArgs.TypeForm = "Documents.Forms.Measurement.FormMeasurement, Documents";
					showFormEventArgs.FormMode = eFormMode.Docking;
					showFormEventArgs.DockPanel = ((DockContentBase)base.Parent).DockPanel;
					showFormEventArgs.Param = new object[1];
					showFormEventArgs.Param[0] = shinaTool.IdBase;
					showFormEventArgs.SQLSettings = this.SqlSettings;
					((FormBase)form).OnShowForm(showFormEventArgs);
				}
			}
		}

		private void toolStripMenuItem10_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag == null)
			{
				return;
			}
			DrawObjectBase drawObjectBase = (DrawObjectBase)contextMenu.Tag;
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			Dictionary<DrawObjectBase, bool> dictionary_ = new Dictionary<DrawObjectBase, bool>();
			treeNodeObj.Tag = drawObjectBase;
			CanvasControl.GetAllPower(drawObjectBase, treeNodeObj, dictionary_);
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			this.method_73(treeNodeObj, list);
			List<DrawObjectBase> list2 = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase2 in list)
			{
				list2.Add(drawObjectBase2);
				if (drawObjectBase2 is ShinaTool)
				{
					list2.Add(drawObjectBase2.Parent);
				}
				if (drawObjectBase2 is Branch)
				{
					foreach (DrawObjectBase item in drawObjectBase2.ChildObjects)
					{
						list2.Add(item);
					}
				}
				if (drawObjectBase2 is BranchCollection)
				{
					foreach (Branch branch in ((BranchCollection)drawObjectBase2).Collection)
					{
						foreach (DrawObjectBase item2 in branch.ChildObjects)
						{
							list2.Add(item2);
						}
					}
				}
			}
			this.SetObjectsInCenterScreen(list2, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
		}

		private void toolStripMenuItem11_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag == null)
			{
				return;
			}
			DrawObjectBase drawObjectBase = (DrawObjectBase)contextMenu.Tag;
			TreeNodeObj treeNodeObj = new TreeNodeObj();
			Dictionary<DrawObjectBase, bool> dictionary_ = new Dictionary<DrawObjectBase, bool>();
			treeNodeObj.Tag = drawObjectBase;
			CanvasControl.GetAlternativePower(drawObjectBase, treeNodeObj, dictionary_);
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			this.method_73(treeNodeObj, list);
			List<DrawObjectBase> list2 = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase2 in list)
			{
				list2.Add(drawObjectBase2);
				if (drawObjectBase2 is ShinaTool)
				{
					list2.Add(drawObjectBase2.Parent);
				}
				if (drawObjectBase2 is Branch)
				{
					foreach (DrawObjectBase item in drawObjectBase2.ChildObjects)
					{
						list2.Add(item);
					}
				}
				if (drawObjectBase2 is BranchCollection)
				{
					foreach (Branch branch in ((BranchCollection)drawObjectBase2).Collection)
					{
						foreach (DrawObjectBase item2 in branch.ChildObjects)
						{
							list2.Add(item2);
						}
					}
				}
				if (drawObjectBase2 is LineTool || drawObjectBase2 is LineCellTool)
				{
					foreach (Branch branch2 in ((LineTool)drawObjectBase2).Branches)
					{
						foreach (DrawObjectBase item3 in branch2.ChildObjects)
						{
							list2.Add(item3);
						}
					}
				}
			}
			this.bool_6 = true;
			this.AddFlashObject(drawObjectBase);
			list2.Remove(drawObjectBase);
			this.SetObjectsInCenterScreen(list2, true, CanvasControl.SetObjectsInCenterScreenOptions.select);
		}

		private void method_73(TreeNodeObj treeNodeObj_0, List<DrawObjectBase> list_9)
		{
			if (treeNodeObj_0.Tag != null)
			{
				list_9.Add((DrawObjectBase)treeNodeObj_0.Tag);
			}
			foreach (TreeNodeObj treeNodeObj_ in treeNodeObj_0.Nodes)
			{
				this.method_73(treeNodeObj_, list_9);
			}
		}

		private void toolStripMenuItemHReflect_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null && contextMenu.Tag.GetType() != typeof(RectangleTool))
			{
				return;
			}
			RectangleTool rectangleTool = (RectangleTool)contextMenu.Tag;
			UnitPoint empty = UnitPoint.Empty;
			UnitPoint empty2 = UnitPoint.Empty;
			string a;
			if ((a = ((ToolStripMenuItem)sender).Tag.ToString()) != null)
			{
				if (!(a == "H"))
				{
					if (a == "V")
					{
						empty = new UnitPoint((double)(rectangleTool.Rectangle.X + rectangleTool.Rectangle.Width / 2f), (double)rectangleTool.Rectangle.Y);
						empty2 = new UnitPoint((double)(rectangleTool.Rectangle.X + rectangleTool.Rectangle.Width / 2f), (double)(rectangleTool.Rectangle.Y + rectangleTool.Rectangle.Height));
					}
				}
				else
				{
					empty = new UnitPoint((double)rectangleTool.Rectangle.X, (double)(rectangleTool.Rectangle.Y + rectangleTool.Rectangle.Height / 2f));
					empty2 = new UnitPoint((double)(rectangleTool.Rectangle.X + rectangleTool.Rectangle.Width), (double)(rectangleTool.Rectangle.Y + rectangleTool.Rectangle.Height / 2f));
				}
			}
			if (empty == UnitPoint.Empty)
			{
				return;
			}
			foreach (DrawObjectBase drawObjectBase in rectangleTool.ChildObjects)
			{
				if (drawObjectBase.GetType() == typeof(ShinaTool))
				{
					((ShinaTool)drawObjectBase).ReflectAboutTheLine(empty, empty2);
				}
			}
		}

		private void toolMenuItemShinaAddPatternAbn_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				ShinaTool shinaTool = (ShinaTool)contextMenu.Tag;
				shinaTool.AddPatternAbn(eTypeAddShinaPatterns.Normal, null);
			}
		}

		private void toolMenuItemShinaAddPatternAbn10_Click(object sender, EventArgs e)
		{
			if (((ToolStripItem)sender).Tag != null)
			{
				int int_ = Convert.ToInt32(((ToolStripItem)sender).Tag);
				ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
				if (contextMenu == null)
				{
					return;
				}
				if (contextMenu.Tag != null)
				{
					ShinaTool shinaTool_ = (ShinaTool)contextMenu.Tag;
					this.method_74(shinaTool_, int_, eTypeAddShinaPatterns.Normal);
				}
			}
		}

		private void toolMenuItemShinaAddPatternAbnAuto10_Click(object sender, EventArgs e)
		{
			if (((ToolStripItem)sender).Tag != null)
			{
				int int_ = Convert.ToInt32(((ToolStripItem)sender).Tag);
				ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
				if (contextMenu == null)
				{
					return;
				}
				if (contextMenu.Tag != null)
				{
					ShinaTool shinaTool_ = (ShinaTool)contextMenu.Tag;
					this.method_74(shinaTool_, int_, eTypeAddShinaPatterns.Auto);
				}
			}
		}

		private void toolMenuItemShinaAddPatternAbnRPS10_Click(object sender, EventArgs e)
		{
			if (((ToolStripItem)sender).Tag != null)
			{
				int int_ = Convert.ToInt32(((ToolStripItem)sender).Tag);
				ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
				if (contextMenu == null)
				{
					return;
				}
				if (contextMenu.Tag != null)
				{
					ShinaTool shinaTool_ = (ShinaTool)contextMenu.Tag;
					this.method_74(shinaTool_, int_, eTypeAddShinaPatterns.RPS);
				}
			}
		}

		private void toolMenuItemShinaAddPatternAbnReserve10_Click(object sender, EventArgs e)
		{
			if (((ToolStripItem)sender).Tag != null)
			{
				int int_ = Convert.ToInt32(((ToolStripItem)sender).Tag);
				ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
				if (contextMenu == null)
				{
					return;
				}
				if (contextMenu.Tag != null)
				{
					ShinaTool shinaTool_ = (ShinaTool)contextMenu.Tag;
					this.method_74(shinaTool_, int_, eTypeAddShinaPatterns.Reserv);
				}
			}
		}

		private void method_74(ShinaTool shinaTool_0, int int_10, eTypeAddShinaPatterns eTypeAddShinaPatterns_0)
		{
			IEnumerable<DrawObjectBase> childObjects = shinaTool_0.ChildObjects;
			if (CanvasControl.func_76 == null)
			{
				CanvasControl.func_76 = new Func<DrawObjectBase, bool>(CanvasControl.smethod_78);
			}
			List<DrawObjectBase> list = childObjects.Where(CanvasControl.func_76).ToList<DrawObjectBase>();
			List<DrawObjectBase> list2 = list;
			if (CanvasControl.comparison_0 == null)
			{
				CanvasControl.comparison_0 = new Comparison<DrawObjectBase>(CanvasControl.smethod_79);
			}
			list2.Sort(CanvasControl.comparison_0);
			int num = 1;
			using (List<DrawObjectBase>.Enumerator enumerator = list.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					DrawObjectBase drawObjectBase = enumerator.Current;
					if (drawObjectBase is PointShinaTool)
					{
						float num2 = (float)((PointShinaTool)drawObjectBase).Point.X;
						((PointShinaTool)drawObjectBase).Delta = (float)num / (float)(int_10 + list.Count + 1);
						num2 -= (float)((PointShinaTool)drawObjectBase).Point.X;
						List<PointTool> list3 = new List<PointTool>();
						List<Branch> list4 = new List<Branch>();
						list3.Add((PointShinaTool)drawObjectBase);
						this.method_76(num2, list4, list3, (PointShinaTool)drawObjectBase);
						foreach (Branch branch in list4)
						{
							if (branch.Parent != null)
							{
								branch.Parent.SaveToSql(false, true);
							}
						}
						num++;
					}
				}
				goto IL_16B;
			}
			IL_14D:
			shinaTool_0.AddPatternAbn(eTypeAddShinaPatterns_0, new float?((float)num / (float)(int_10 + list.Count + 1)));
			num++;
			IL_16B:
			if (num >= int_10 + list.Count + 1)
			{
				this.DoInvalidate(true);
				return;
			}
			goto IL_14D;
		}

		private bool method_75(List<Branch> list_9, List<PointTool> list_10, PointTool pointTool_0)
		{
			foreach (Branch branch in pointTool_0.Branches)
			{
				if (!list_9.Contains(branch))
				{
					if (list_10.Contains(branch.Source))
					{
						if (!list_10.Contains(branch.Destination))
						{
							if (branch.Destination.Parent != null && branch.Destination.Parent is ShinaTool)
							{
								return false;
							}
							list_10.Add(branch.Destination);
							list_9.Add(branch);
							return this.method_75(list_9, list_10, branch.Destination);
						}
					}
					else
					{
						if (branch.Source.Parent != null && branch.Source.Parent is ShinaTool)
						{
							return false;
						}
						list_10.Add(branch.Source);
						list_9.Add(branch);
						return this.method_75(list_9, list_10, branch.Source);
					}
				}
			}
			return true;
		}

		private void method_76(float float_3, List<Branch> list_9, List<PointTool> list_10, PointTool pointTool_0)
		{
			foreach (Branch branch in pointTool_0.Branches)
			{
				if (!list_9.Contains(branch))
				{
					if (!list_10.Contains(branch.Source))
					{
						branch.Source.Point = new UnitPoint(branch.Source.Point.X - (double)float_3, branch.Source.Point.Y);
						list_10.Add(branch.Source);
						list_9.Add(branch);
						this.method_76(float_3, list_9, list_10, branch.Source);
					}
					if (!list_10.Contains(branch.Destination))
					{
						branch.Destination.Point = new UnitPoint(branch.Destination.Point.X - (double)float_3, branch.Destination.Point.Y);
						list_10.Add(branch.Destination);
						list_9.Add(branch);
						this.method_76(float_3, list_9, list_10, branch.Destination);
					}
				}
			}
		}

		private void toolMenuItemShinaAddPatternAbnReserve_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				ShinaTool shinaTool = (ShinaTool)contextMenu.Tag;
				shinaTool.AddPatternAbn(eTypeAddShinaPatterns.Reserv, null);
			}
		}

		private void toolStripMenuItemMeasurement_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			DrawObjectBase drawObjectBase = (DrawObjectBase)contextMenu.Tag;
			MeasurementLabelTool measurementLabelTool = new MeasurementLabelTool();
			measurementLabelTool.Parent = drawObjectBase;
			measurementLabelTool.Location = this.unitPoint_2;
			drawObjectBase.Layer.AddObject(measurementLabelTool);
			PointF pointF = ConvertCanvas.ConvertToScreen(this, measurementLabelTool.Location);
			Point location = base.PointToScreen(new Point((int)pointF.X, (int)pointF.Y));
			if (!measurementLabelTool.ShowPropertyForm(location))
			{
				measurementLabelTool.Remove(false, false);
			}
			this.method_71(drawObjectBase.IdBase);
		}

		private void contextMenuStripWhitePoint_Opening(object sender, CancelEventArgs e)
		{
			if (this.eCanvasEditingMode_0 == eCanvasEditingMode.ReadOnly)
			{
				e.Cancel = true;
			}
		}

		private void toolStripMenuItemRemoveWhitePoint_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				((DrawObjectBase)contextMenu.Tag).Remove(true, true);
			}
		}

		private void contextMenuSwitchTool_Opening(object sender, CancelEventArgs e)
		{
			this.toolMenuItemSwitchDel.Enabled = (this.Mode == eCanvasEditingMode.Edit);
			if (this.contextMenuSwitchTool.Tag != null)
			{
				ObjectOnLine objectOnLine = (ObjectOnLine)this.contextMenuSwitchTool.Tag;
				if (this.contextMenuSwitchTool.Tag.GetType() == typeof(OffTool))
				{
					this.toolMenuItemStateDel.Text = "Убрать отсоединение кабеля";
				}
				if (this.contextMenuSwitchTool.Tag.GetType() == typeof(NotPhasedTool))
				{
					this.toolMenuItemStateDel.Text = "Убрать отметку о несфазировании";
				}
				if (this.contextMenuSwitchTool.Tag.GetType() == typeof(DamageTool))
				{
					this.toolMenuItemStateDel.Text = "Убрать повреждение кабеля";
				}
				if (this.contextMenuSwitchTool.Tag.GetType() == typeof(GroundingTool))
				{
					this.toolMenuItemStateDel.Text = "Убрать заземление";
				}
				if (this.contextMenuSwitchTool.Tag.GetType() == typeof(ArrowTool))
				{
					this.toolMenuItemStateDel.Text = "Убрать перенос нагрузки";
				}
				this.toolMenuItemSwitchPassport.Visible = (objectOnLine is TransformerTool);
				if (!((ObjectOnLine)this.contextMenuSwitchTool.Tag).LimitedEditing && (this.contextMenuSwitchTool.Tag.GetType().GetProperty("On") == null || this.contextMenuSwitchTool.Tag.GetType().GetProperty("On").CanWrite))
				{
					this.toolMenuItemSwitchOn.Text = (((ObjectOnLine)this.contextMenuSwitchTool.Tag).On ? "Отключить" : "Включить");
				}
				else
				{
					this.toolMenuItemSwitchOn.Visible = false;
				}
				this.toolMenuItemSwitchOn.Visible = (!objectOnLine.MappingState && !objectOnLine.Parent.Parent.LimitedEditing);
				this.toolStripSeparator12.Visible = !objectOnLine.MappingState;
				this.toolMenuItemSwitchFilter.Visible = !objectOnLine.MappingState;
				this.toolMenuItemStateDel.Visible = objectOnLine.MappingState;
				this.toolMenuItemSwitchDel.Visible = !objectOnLine.MappingState;
				this.toolStripMenuItemCSRollingOut.Visible = (!objectOnLine.MappingState && !objectOnLine.LimitedEditing && objectOnLine.ComplexSwitchgear != null && objectOnLine.ComplexSwitchgear.RollingOutReason == ComplexSwitchgearTool.eRollingOutReason.None && this.Mode != eCanvasEditingMode.ReadOnly);
				this.toolStripMenuItemCSNormalMode.Visible = (!objectOnLine.MappingState && !objectOnLine.LimitedEditing && objectOnLine.ComplexSwitchgear != null && objectOnLine.ComplexSwitchgear.RollingOutReason != ComplexSwitchgearTool.eRollingOutReason.None && this.Mode != eCanvasEditingMode.ReadOnly);
				this.toolStripSeparatorCS.Visible = (!objectOnLine.MappingState && !objectOnLine.LimitedEditing && objectOnLine.ComplexSwitchgear != null && this.Mode != eCanvasEditingMode.ReadOnly);
				this.toolMenuItemSwitchOn.Enabled = (objectOnLine.ComplexSwitchgear == null || objectOnLine.ComplexSwitchgear.RollingOutReason == ComplexSwitchgearTool.eRollingOutReason.None);
				this.toolStripMenuItemCSRepairMode.Enabled = (this.toolStripMenuItemCSTestMode.Enabled = !objectOnLine.On);
				this.toolStripMenuItemSwitchAddTelemetry.Visible = (!objectOnLine.MappingState && this.Mode == eCanvasEditingMode.Edit);
				this.toolStripMenuItemOOLDisplayGrLevel.Visible = (!objectOnLine.MappingState && !objectOnLine.Parent.Parent.LimitedEditing && this.Mode == eCanvasEditingMode.Edit && this.TypeCanvas == eTypeCanvas.SchemeSecond);
				if (this.Mode == eCanvasEditingMode.ReadOnly)
				{
					this.toolMenuItemSwitchOn.Visible = false;
					this.toolMenuItemStateDel.Visible = false;
				}
			}
		}

		private void toolMenuItemStateDel_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu.Tag != null && contextMenu.Tag is ObjectOnLine)
			{
				LineToolState state = ((ObjectOnLine)contextMenu.Tag).State;
				Branch branch = (Branch)state.Mapping.Parent;
				double delta = state.Mapping.Delta;
				int idBase = state.Mapping.IdBase;
				States state2 = state.state;
				if (state2 == SchemeCtrl2.DrawTool.States.break_down || state2 == SchemeCtrl2.DrawTool.States.const_1)
				{
					SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
					sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tP_CabOperation, true, " where idObjList = " + branch.Parent.IdBase.ToString() + " order by DateDecommissioning desc");
					if (state.Mapping.SearchObjectsOnLine(typeof(OffTool)).Count == 0 && state.Mapping.SearchObjectsOnLine(typeof(DamageTool)).Count == 0 && this.dataSetScheme_0.tP_CabOperation.Rows.Count > 0 && this.dataSetScheme_0.tP_CabOperation.Rows[0]["DateCommissioning"] == DBNull.Value)
					{
						FormDamageToolProperty formDamageToolProperty = new FormDamageToolProperty();
						formDamageToolProperty.SqlSettings = this.sqlsettings_0;
						formDamageToolProperty.BeforRemove = true;
						PointF pointF = ConvertCanvas.ConvertToScreen(this, state.Mapping.CenterPoint);
						formDamageToolProperty.Location = base.PointToScreen(new Point((int)pointF.X, (int)pointF.Y));
						Rectangle workingArea = Screen.GetWorkingArea(formDamageToolProperty.Location);
						if (formDamageToolProperty.Left + formDamageToolProperty.Width > workingArea.Left + workingArea.Width)
						{
							formDamageToolProperty.Left = formDamageToolProperty.Left - formDamageToolProperty.Width - 1;
						}
						if (formDamageToolProperty.Left < workingArea.Left)
						{
							formDamageToolProperty.Left = workingArea.Left;
						}
						if (formDamageToolProperty.Top + formDamageToolProperty.Height > workingArea.Top + workingArea.Height)
						{
							formDamageToolProperty.Top = formDamageToolProperty.Top - formDamageToolProperty.Height - 1;
						}
						if (formDamageToolProperty.Top < workingArea.Top)
						{
							formDamageToolProperty.Top = workingArea.Top;
						}
						if (formDamageToolProperty.ShowDialog() != DialogResult.OK)
						{
							return;
						}
						DateTime dateTime = formDamageToolProperty.DateTime;
						DataSetScheme.Class66 @class = (DataSetScheme.Class66)this.dataSetScheme_0.tP_CabOperation.Rows[0];
						@class.method_5(dateTime);
						sqlDataCommand.UpdateSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tP_CabOperation);
					}
				}
				state.Remove(true);
				((LineTool)branch.Parent).SaveXmlToSql();
				CanvasLog.SaveLogDispatcher(this.SqlSettings, new int?(((LineTool)branch.Parent).IdBase), this.method_81(false, state2), "");
				try
				{
					int num = 0;
					foreach (Branch branch2 in branch.CouplingRelation.Branches)
					{
						if (branch2 == branch)
						{
							break;
						}
						num++;
					}
					string hostName = Dns.GetHostName();
					IPAddress ipaddress = Dns.GetHostByName(hostName).AddressList[0];
					string text = ipaddress.ToString() + Environment.UserName;
					this.ProxySingleton.StateOnLine(branch.Parent.IdBase, branch.CouplingRelation.Id, num, delta, (int)state2, false, text, idBase);
				}
				catch
				{
				}
			}
		}

		private void toolMenuItemSwitchOn_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu.Tag != null && contextMenu.Tag is ObjectOnLine)
			{
				ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
				objectOnLine.On = !objectOnLine.On;
				if (this.SimulationMode == eSimulationMode.Online)
				{
					objectOnLine.SaveToSql(false, false);
					CanvasLog.SaveLogDispatcher(this.SqlSettings, new int?(objectOnLine.IdBase), objectOnLine.On ? "Включен" : "Выключен", "");
					try
					{
						this.ProxySingleton.ObjectOnLineOnChange(objectOnLine.IdBase, objectOnLine.On);
						goto IL_A1;
					}
					catch
					{
						goto IL_A1;
					}
				}
				eSimulationMode simulationMode = this.SimulationMode;
				IL_A1:
				this.DoInvalidate(true);
			}
		}

		private void toolStripMenuItemOOLDisplayGrLevel_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu.Tag != null && contextMenu.Tag is ObjectOnLine)
			{
				DrawObjectBase drawObjectBase_ = (DrawObjectBase)contextMenu.Tag;
				List<DrawObjectBase> list = this.method_69(drawObjectBase_);
				foreach (DrawObjectBase drawObjectBase in list)
				{
					drawObjectBase.SaveToSql(false, false);
				}
			}
		}

		private void toolMenuItemSwitchLogDispatcher_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.vSchm_LogDispatcher, true, string.Concat(new string[]
			{
				" where IdObj = ",
				objectOnLine.IdBase.ToString(),
				" and typeSchema = ",
				((int)this.TypeCanvas).ToString(),
				" order by dateLog desc"
			}));
			object obj = sqlDataCommand.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
			{
				objectOnLine.IdBase.ToString()
			});
			this.SendMessage(objectOnLine, (obj != null) ? obj.ToString() : string.Empty, this.dataSetScheme_0.vSchm_LogDispatcher);
		}

		private void toolMenuItemSwitchPassport_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
			if (base.Parent != null && base.Parent is DockContentBase)
			{
				Form form = base.FindForm();
				if (form is FormBase)
				{
					ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
					showFormEventArgs.TypeForm = "Passport.Forms.FormDockPassport, Passport";
					showFormEventArgs.FormMode = eFormMode.Docking;
					showFormEventArgs.DockPanel = ((DockContentBase)base.Parent).DockPanel;
					showFormEventArgs.Param = new object[2];
					showFormEventArgs.Param[0] = this.SqlSettings;
					showFormEventArgs.Param[1] = objectOnLine.IdBase;
					showFormEventArgs.SQLSettings = this.SqlSettings;
					((FormBase)form).OnShowForm(showFormEventArgs);
					return;
				}
				DockPanel dockPanel = ((DockContentBase)base.Parent).DockPanel;
				FormDockPassport formDockPassport = new FormDockPassport(this.SqlSettings, objectOnLine.IdBase);
				formDockPassport.Show(dockPanel);
			}
		}

		private void ToolStripMenuItemSwitchMeasurement_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
			if (base.Parent != null && base.Parent is DockContentBase)
			{
				Form form = base.FindForm();
				if (form is FormBase)
				{
					ShowFormEventArgs showFormEventArgs = new ShowFormEventArgs();
					showFormEventArgs.TypeForm = "Documents.Forms.Measurement.FormMeasurement, Documents";
					showFormEventArgs.FormMode = eFormMode.Docking;
					showFormEventArgs.DockPanel = ((DockContentBase)base.Parent).DockPanel;
					showFormEventArgs.Param = new object[1];
					showFormEventArgs.Param[0] = objectOnLine.IdBase;
					showFormEventArgs.SQLSettings = this.SqlSettings;
					((FormBase)form).OnShowForm(showFormEventArgs);
				}
			}
		}

		private void toolStripMenuItemCSRepairMode_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
			if (objectOnLine.ComplexSwitchgear == null)
			{
				return;
			}
			objectOnLine.ComplexSwitchgear.RollingOutReason = ComplexSwitchgearTool.eRollingOutReason.Repair;
			objectOnLine.SaveToSql(false, false);
			this.DoInvalidate(true);
		}

		private void toolStripMenuItemCSTestMode_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
			if (objectOnLine.ComplexSwitchgear == null)
			{
				return;
			}
			objectOnLine.ComplexSwitchgear.RollingOutReason = ComplexSwitchgearTool.eRollingOutReason.Test;
			objectOnLine.SaveToSql(false, false);
			this.DoInvalidate(true);
		}

		private void toolStripMenuItemCSNormalMode_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
			if (objectOnLine.ComplexSwitchgear == null)
			{
				return;
			}
			objectOnLine.ComplexSwitchgear.RollingOutReason = ComplexSwitchgearTool.eRollingOutReason.None;
			objectOnLine.SaveToSql(false, false);
			this.DoInvalidate(true);
		}

		private void toolMenuItemSwitchLinkErcloud_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
			new FormSwitchLinkErcloud(objectOnLine)
			{
				SqlSettings = this.sqlsettings_0,
				MdiParent = ((DockContentBase)base.Parent).Parent.FindForm().MdiParent
			}.Show();
		}

		private void toolMenuItemSwitchShowDataErcloud_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			ObjectOnLine objectOnLine = (ObjectOnLine)contextMenu.Tag;
			new FormSwitchShowDataErcloud(objectOnLine)
			{
				SqlSettings = this.sqlsettings_0,
				MdiParent = ((DockContentBase)base.Parent).Parent.FindForm().MdiParent
			}.Show();
		}

		private void contextMenuLineTool_Opening(object sender, CancelEventArgs e)
		{
			this.toolStripMenuItemLineAddTelemertryLabel.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemLineAddChild.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolStripSeparatorEditLine.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolStripSeparator8.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemLineTextHere.Visible = false;
			this.toolStripSeparatorLineTextHere.Visible = false;
			this.toolMenuItemLineRelayProtection.Visible = false;
			this.toolMenuItemLinePaste.Enabled = (this.Mode == eCanvasEditingMode.Edit && CopyPasteCanvasObjects.IsPasteInObjects(this.SelectedObjects.ToList<DrawObjectBase>(), this.list_7));
			this.toolMenuItemLineSetStatusArrow.Visible = false;
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				this.toolMenuItemLineDel.Visible = (this.Mode == eCanvasEditingMode.Edit);
				this.toolMenuItemLinePaste.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddBranch.Visible = !lineTool.LimitedEditing;
				this.toolStripSeparatorLineAddBranchPoint.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddOutsideLineDisconnector.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddVacuumSwitch.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddTransformer.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddVoltageTransformer.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddLoadSwitch.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddLinearDisconnector.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddLinearDisconnectorWaxwork.Visible = lineTool.LimitedEditing;
				this.toolMenuItemLineAddLoadSwitch.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddLoadSwitchWaxwork.Visible = lineTool.LimitedEditing;
				this.toolMenuItemLineAddRPS.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddLubricantDisconnector.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddDischargerTool.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddVoltageLimetedTool.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineAddCircuitBreakerTool.Visible = !lineTool.LimitedEditing;
				this.toolStripSeparator6.Visible = !lineTool.LimitedEditing;
				this.toolStripSeparatorEditLine.Visible = !lineTool.LimitedEditing;
				this.toolMenuItemLineSetStatus.Visible = !lineTool.LimitedEditing;
				this.toolStripSeparatorSetStatus.Visible = !lineTool.LimitedEditing;
				this.toolStripMenuItemAddElectricMeter.Visible = !lineTool.LimitedEditing;
				this.toolStripMenuItemAddMagneticStarterTool.Visible = !lineTool.LimitedEditing;
				bool flag = this.method_77(lineTool.IdBase);
				this.toolMenuItemLineDeLinkPassport.Visible = (this.Mode == eCanvasEditingMode.Edit && !flag);
				this.toolMenuItemLineLinkPassport.Visible = (lineTool.Type == LineToolType.CabelLine && !flag);
				this.toolMenuItemLinePassport.Visible = (lineTool.Type == LineToolType.CabelLine || lineTool.Type == LineToolType.AirLine || lineTool.Type == LineToolType.AirLineProtected);
				if (this.Mode == eCanvasEditingMode.ReadOnly)
				{
					this.toolMenuItemLineSetStatus.Visible = false;
					this.toolStripSeparatorSetStatus.Visible = false;
				}
				if (lineTool.SelectedPoint != null)
				{
					if (lineTool.SelectedPoint.BranchesCount == 2)
					{
						if (lineTool.SelectedPoint.Branches.First<Branch>().Parent == lineTool.SelectedPoint.Branches.Last<Branch>().Parent)
						{
							this.toolStripMenuItemDisconnectLine.Enabled = false;
							this.toolStripMenuItemDevideLine.Enabled = true;
						}
						else
						{
							this.toolStripMenuItemDisconnectLine.Enabled = true;
							this.toolStripMenuItemDevideLine.Enabled = false;
						}
					}
					else
					{
						this.toolStripMenuItemDevideLine.Enabled = false;
						List<LineTool> list = new List<LineTool>();
						this.toolStripMenuItemDisconnectLine.Enabled = true;
						foreach (CouplingRelation couplingRelation in lineTool.SelectedPoint.CouplingRelations)
						{
							if (list.Contains(couplingRelation.Line))
							{
								this.toolStripMenuItemDisconnectLine.Enabled = false;
								break;
							}
							list.Add(couplingRelation.Line);
						}
					}
					this.toolMenuItemLineDelPoint.Enabled = (!lineTool.LimitedEditing || lineTool.SelectedPoint.CouplingRelations.Count == 0);
					this.toolStripMenuItemDevideLine.Visible = (this.Mode == eCanvasEditingMode.Edit && !lineTool.LimitedEditing);
					this.toolStripMenuItemDisconnectLine.Visible = (this.Mode == eCanvasEditingMode.Edit && !lineTool.LimitedEditing);
					this.toolMenuItemLinePropertyPoint.Visible = true;
					this.toolMenuItemLineDelPoint.Enabled = true;
					this.toolMenuItemLineAddPoint.Enabled = false;
					this.toolMenuItemLinePropertyBranch.Visible = false;
					this.toolStripMenuItemLineAlignBranch.Visible = false;
				}
				else
				{
					this.toolStripMenuItemDevideLine.Visible = false;
					this.toolStripMenuItemDisconnectLine.Visible = false;
					this.toolMenuItemLinePropertyPoint.Visible = false;
					this.toolMenuItemLineAddPoint.Enabled = true;
					this.toolMenuItemLineDelPoint.Enabled = false;
					this.toolMenuItemLinePropertyBranch.Visible = (this.Mode == eCanvasEditingMode.Edit);
					this.toolStripMenuItemLineAlignBranch.Visible = (this.Mode == eCanvasEditingMode.Edit);
				}
				this.toolMenuItemLineSetStatusGrounding.Enabled = (lineTool.SelectedBranch != null && !lineTool.SelectedBranch.CheckVoltageInPoint(lineTool.ClickedPoint));
				if (lineTool.GetType() == typeof(LineCellTool) || lineTool.GetType() == typeof(Class74))
				{
					this.toolMenuItemLineRelayProtection.Visible = true;
					if (lineTool.SelectedPoint != null)
					{
						this.toolMenuItemLineTextHere.Visible = (this.Mode == eCanvasEditingMode.Edit);
						this.toolStripSeparatorLineTextHere.Visible = (this.Mode == eCanvasEditingMode.Edit);
					}
					bool flag2 = true;
					foreach (PointTool pointTool in lineTool.Ends)
					{
						if (pointTool.Parent != null)
						{
							if (pointTool.Parent.GetType() == typeof(ShinaTool))
							{
								continue;
							}
						}
						flag2 = false;
						break;
					}
					if (flag2)
					{
						this.toolMenuItemLineSetStatusArrow.Visible = true;
					}
				}
			}
		}

		private bool method_77(int int_10)
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			DataTable dataTable = sqlDataCommand.SelectSqlData("tP_Passport", true, "where IdObjList = " + int_10.ToString() + " and deleted =0 and isactive = 1 ");
			return dataTable.Rows.Count > 0;
		}

		private void toolMenuItemLineAddBranch_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				lineTool.AddBranch();
				new DrawObjectsEventArgs(lineTool);
			}
		}

		private void toolMenuItemLineAddPoint_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				lineTool.AddPointTool();
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(lineTool.GetUpdateScriptXML(true, new List<int>()));
				if (!string.IsNullOrEmpty(stringBuilder.ToString()))
				{
					BackgroundWorker backgroundWorker = new BackgroundWorker();
					backgroundWorker.DoWork += this.method_25;
					backgroundWorker.RunWorkerCompleted += this.method_26;
					stringBuilder.Insert(0, "BEGIN TRANSACTION t2; set transaction isolation level SERIALIZABLE;  select id from tSChm_ObjList (UPDLOCK) select id from tSChm_Xml (UPDLOCK)");
					stringBuilder.Append(" COMMIT TRANSACTION t2; ");
					this.WorkerCounter++;
					backgroundWorker.RunWorkerAsync(stringBuilder);
				}
			}
		}

		private void method_78(object object_0, TypeSwitch typeSwitch_0)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(object_0);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				ObjectOnLine objectOnLine = lineTool.SelectedBranch.AddSwitchTool(typeSwitch_0, lineTool.ClickedPoint);
				lineTool.Layer.AddObject(objectOnLine);
				objectOnLine.EndDraw();
				this.DoInvalidate(true);
			}
		}

		private void toolMenuItemLineAddOutsideLineDisconnector_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.OutsideLineDisconnectorTool);
		}

		private void toolMenuItemLineAddVacuumSwitch_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.VacuumSwitchTool);
		}

		private void method_79(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.DamageTool);
		}

		private void toolMenuItemLineAddTransformer_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.TransformerTool);
		}

		private void toolMenuItemLineAddVoltageTransformer_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.VoltageTransformerTool);
		}

		private void toolStripMenuItemAddAmperageTransformerTool_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.AmperageTransformer);
		}

		private void toolMenuItemLineAddLoadSwitch_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.LoadSwitchTool);
		}

		private void toolMenuItemLineAddLoadSwitchWaxwork_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.LoadSwitchToolWaxwork);
		}

		private void toolMenuItemLineAddLinearDisconnector_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.LinearDisconnectorTool);
		}

		private void toolMenuItemLineAddLinearDisconnectorWaxwork_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.LinearDisconnectorToolWaxwork);
		}

		private void toolMenuItemLineAddSeparatorTool_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.SeparatorTool);
		}

		private void toolMenuItemLineAddRPS_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.RPSTool);
		}

		private void toolMenuItemLineAddLubricantDisconnector_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.LubricantSwitchTool);
		}

		private void toolMenuItemLineAddFuseTool_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.FuseTool);
		}

		private void toolMenuItemLineAddDischargerTool_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.DischargerTool);
		}

		private void toolMenuItemLineAddVoltageLimetedTool_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.VoltageLimiterTool);
		}

		private void toolMenuItemLineAddEndTrim_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.EndTrimTool);
		}

		private void toolMenuItemLineAddGroundingTool_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.GroundingTool);
		}

		private void toolMenuItemLineAddCircuitBreakerTool_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.CircuitBreaker);
		}

		private void toolStripMenuItemAddMagneticStarterTool_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.MagneticStarterTool);
		}

		private void toolStripMenuItemAddElectricMeter_Click(object sender, EventArgs e)
		{
			this.method_78(sender, TypeSwitch.ElectricMeterTool);
		}

		private void toolMenuItemAddLineText_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				TextBranchTool textBranchTool = new TextBranchTool();
				textBranchTool.Text = "Текст";
				textBranchTool.Parent = lineTool.SelectedBranch;
				FormTextBranchProperties formTextBranchProperties = new FormTextBranchProperties(textBranchTool);
				lineTool.Layer.AddObject(textBranchTool);
				if (formTextBranchProperties.ShowDialog() == DialogResult.OK)
				{
					lineTool.SaveXmlToSql();
				}
				else
				{
					textBranchTool.Remove(false, false);
				}
				this.DoInvalidate(true);
			}
		}

		private void toolMenuItemLineDelPoint_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				lineTool.RemovePointTool(lineTool.SelectedPoint);
				this.DoInvalidate(true);
			}
		}

		private void toolMenuItemLinePropertyPoint_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				lineTool.SelectedPoint.ShowPropertyForm(contextMenu.Location);
			}
		}

		private void toolMenuItemLinePropertyBranch_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				lineTool.SelectedBranch.ShowPropertyForm(contextMenu.Location);
			}
		}

		private void method_80(object object_0, States states_0)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(object_0);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				LineToolState lineToolState = new LineToolState(states_0, lineTool.SelectedBranch, lineTool.ClickedPoint);
				if (lineToolState.state == SchemeCtrl2.DrawTool.States.break_down || lineToolState.state == SchemeCtrl2.DrawTool.States.const_1)
				{
					SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
					sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tP_CabOperation, true, " where idObjList = " + lineTool.IdBase.ToString() + " order by DateDecommissioning desc");
					if (lineToolState.Mapping.SearchObjectsOnLine(typeof(OffTool)).Count == 0 && lineToolState.Mapping.SearchObjectsOnLine(typeof(DamageTool)).Count == 0 && (this.dataSetScheme_0.tP_CabOperation.Rows.Count == 0 || this.dataSetScheme_0.tP_CabOperation.Rows[0]["DateCommissioning"] != DBNull.Value))
					{
						FormDamageToolProperty formDamageToolProperty = new FormDamageToolProperty();
						formDamageToolProperty.SqlSettings = this.SqlSettings;
						formDamageToolProperty.BeforRemove = false;
						PointF pointF = ConvertCanvas.ConvertToScreen(this, lineToolState.Mapping.CenterPoint);
						formDamageToolProperty.Location = base.PointToScreen(new Point((int)pointF.X, (int)pointF.Y));
						Rectangle workingArea = Screen.GetWorkingArea(formDamageToolProperty.Location);
						if (formDamageToolProperty.Left + formDamageToolProperty.Width > workingArea.Left + workingArea.Width)
						{
							formDamageToolProperty.Left = formDamageToolProperty.Left - formDamageToolProperty.Width - 1;
						}
						if (formDamageToolProperty.Left < workingArea.Left)
						{
							formDamageToolProperty.Left = workingArea.Left;
						}
						if (formDamageToolProperty.Top + formDamageToolProperty.Height > workingArea.Top + workingArea.Height)
						{
							formDamageToolProperty.Top = formDamageToolProperty.Top - formDamageToolProperty.Height - 1;
						}
						if (formDamageToolProperty.Top < workingArea.Top)
						{
							formDamageToolProperty.Top = workingArea.Top;
						}
						if (formDamageToolProperty.ShowDialog() != DialogResult.OK)
						{
							lineToolState.Remove(false);
							return;
						}
						if (!formDamageToolProperty.DoNotMark)
						{
							int reasonId = formDamageToolProperty.ReasonId;
							DateTime dateTime = formDamageToolProperty.DateTime;
							DataSetScheme.Class66 @class = (DataSetScheme.Class66)this.dataSetScheme_0.tP_CabOperation.NewRow();
							@class.method_1(lineTool.IdBase);
							@class.method_3(dateTime);
							@class.method_7(reasonId);
							@class.method_9(false);
							this.dataSetScheme_0.tP_CabOperation.method_0(@class);
							sqlDataCommand.InsertSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tP_CabOperation);
						}
					}
				}
				lineTool.AddState(lineToolState);
				if (this.SimulationMode == eSimulationMode.Online)
				{
					if (lineToolState.Mapping.GetType() == typeof(ArrowTool))
					{
						lineTool.SaveXmlToSql();
					}
					else if (!lineToolState.Mapping.SaveToSql(false, true))
					{
						lineTool.RemoveState(lineToolState);
						return;
					}
					CanvasLog.SaveLogDispatcher(this.SqlSettings, new int?(lineTool.IdBase), this.method_81(true, states_0), "");
					try
					{
						int num = 0;
						foreach (Branch branch in lineTool.SelectedBranch.CouplingRelation.Branches)
						{
							if (branch == lineTool.SelectedBranch)
							{
								break;
							}
							num++;
						}
						string hostName = Dns.GetHostName();
						IPAddress ipaddress = Dns.GetHostByName(hostName).AddressList[0];
						string text = ipaddress.ToString() + Environment.UserName;
						this.ProxySingleton.StateOnLine(lineTool.IdBase, lineTool.SelectedBranch.CouplingRelation.Id, num, lineToolState.Mapping.Delta, (int)states_0, true, text, lineToolState.Mapping.IdBase);
					}
					catch
					{
					}
				}
			}
		}

		private string method_81(bool bool_12, States states_0)
		{
			string text = bool_12 ? "Добавлен " : "Удален ";
			switch (states_0)
			{
			case SchemeCtrl2.DrawTool.States.grounded:
				text += "статус \"Заземлено\"";
				break;
			case SchemeCtrl2.DrawTool.States.const_1:
				text += "статус \"Отсоединено\"";
				break;
			case SchemeCtrl2.DrawTool.States.break_down:
				text += "статус \"Повреждено\"";
				break;
			case SchemeCtrl2.DrawTool.States.not_phased:
				text += "статус \"Насфазировано\"";
				break;
			case SchemeCtrl2.DrawTool.States.Arrow:
				text += "перенос нагрузки";
				break;
			}
			return text;
		}

		private void toolMenuItemLineSetStatusGrounding_Click(object sender, EventArgs e)
		{
			this.method_80(sender, SchemeCtrl2.DrawTool.States.grounded);
		}

		private void toolMenuItemLineSetStatusBrakeDown_Click(object sender, EventArgs e)
		{
			this.method_80(sender, SchemeCtrl2.DrawTool.States.break_down);
		}

		private void toolMenuItemLineSetStatusOff_Click(object sender, EventArgs e)
		{
			this.method_80(sender, SchemeCtrl2.DrawTool.States.const_1);
		}

		private void toolMenuItemLineSetStatusNoPhased_Click(object sender, EventArgs e)
		{
			this.method_80(sender, SchemeCtrl2.DrawTool.States.not_phased);
		}

		private void toolMenuItemLineSetStatusArrow_Click(object sender, EventArgs e)
		{
			this.method_80(sender, SchemeCtrl2.DrawTool.States.Arrow);
		}

		private void toolMenuItemLineTextHere_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				LineTool lineTool = (LineTool)contextMenu.Tag;
				if (lineTool.TextProperty.Visible)
				{
					foreach (PointTool pointTool in lineTool.GetPointsList())
					{
						pointTool.TextProperty.Visible = false;
					}
					lineTool.SelectedPoint.TextProperty.Visible = true;
					lineTool.SelectedPoint.TextProperty.Position = lineTool.TextProperty.Position;
					lineTool.SelectedPoint.Text = lineTool.Text;
					this.DoInvalidate(true);
					lineTool.SaveToSql(false, true);
				}
			}
		}

		private void toolStripMenuItemAlignBranchByLeft_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			LineTool lineTool = (LineTool)contextMenu.Tag;
			Branch selectedBranch = lineTool.SelectedBranch;
			if (selectedBranch == null)
			{
				return;
			}
			string a;
			if ((a = ((ToolStripMenuItem)sender).Tag.ToString()) != null)
			{
				if (!(a == "T"))
				{
					if (!(a == "B"))
					{
						if (!(a == "R"))
						{
							if (a == "L")
							{
								selectedBranch.AlignBy(Alignment.L);
							}
						}
						else
						{
							selectedBranch.AlignBy(Alignment.R);
						}
					}
					else
					{
						selectedBranch.AlignBy(Alignment.B);
					}
				}
				else
				{
					selectedBranch.AlignBy(Alignment.T);
				}
			}
			this.DoInvalidate(true);
			lineTool.SaveToSql(false, true);
		}

		private void toolStripMenuItemDisconnectLine_Click(object sender, EventArgs e)
		{
			CanvasControl.Class43 @class = new CanvasControl.Class43();
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			@class.lineTool_0 = (LineTool)contextMenu.Tag;
			PointTool selectedPoint = @class.lineTool_0.SelectedPoint;
			if (selectedPoint == null)
			{
				return;
			}
			if (selectedPoint.BranchesCount < 2)
			{
				return;
			}
			List<LineTool> list = new List<LineTool>();
			foreach (CouplingRelation couplingRelation in selectedPoint.CouplingRelations)
			{
				if (list.Contains(couplingRelation.Line))
				{
					return;
				}
				list.Add(couplingRelation.Line);
			}
			PointTool newPoint = new PointTool(selectedPoint.Point, selectedPoint.Layer);
			Branch branch = null;
			using (IEnumerator<Branch> enumerator2 = selectedPoint.Branches.Where(new Func<Branch, bool>(@class.method_0)).GetEnumerator())
			{
				if (enumerator2.MoveNext())
				{
					Branch branch2 = enumerator2.Current;
					branch = branch2;
				}
			}
			if (branch != null)
			{
				@class.lineTool_0.RechangePointInBranch(branch, newPoint, branch.Source == selectedPoint);
				this.DoInvalidate(true);
				Class96.smethod_5(@class.lineTool_0);
				return;
			}
		}

		private void toolStripMenuItemDevideLine_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			LineTool lineTool = (LineTool)contextMenu.Tag;
			PointTool selectedPoint = lineTool.SelectedPoint;
			if (selectedPoint == null)
			{
				return;
			}
			LineTool item = lineTool.DevideLine(selectedPoint);
			Class96.smethod_6(new List<DrawObjectBase>
			{
				item,
				lineTool
			});
		}

		private void toolMenuItemLineRelayProtection_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			LineCellTool lineCellTool = (LineCellTool)contextMenu.Tag;
			int typeRectnagleTool = (int)((RectangleTool)lineCellTool.Parent).TypeRectnagleTool;
			int idBase = lineCellTool.Parent.IdBase;
			int idBase2 = lineCellTool.GetParentShina().IdBase;
			new FormJRelayProtectionAutomationEditBySchmObj(typeRectnagleTool, idBase, idBase2, lineCellTool.IdBase)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog();
		}

		private void toolMenuItemLineLogDispatcher_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			LineTool lineTool = (LineTool)contextMenu.Tag;
			string text = lineTool.IdBase.ToString() + ",";
			foreach (Branch branch in lineTool.Branches)
			{
				foreach (DrawObjectBase drawObjectBase in branch.ChildObjects)
				{
					if (drawObjectBase is ObjectOnLine)
					{
						text = text + drawObjectBase.IdBase.ToString() + ",";
					}
				}
			}
			text = text.Remove(text.Length - 1);
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.vSchm_LogDispatcher, true, string.Concat(new string[]
			{
				" where IdObj in (",
				text,
				") and typeSchema = ",
				((int)this.TypeCanvas).ToString(),
				"  order by dateLog desc"
			}));
			object obj = sqlDataCommand.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
			{
				lineTool.IdBase.ToString()
			});
			this.SendMessage(lineTool, (obj != null) ? obj.ToString() : string.Empty, this.dataSetScheme_0.vSchm_LogDispatcher);
		}

		private void toolMenuItemLineLinkPassport_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			LineTool lineTool = (LineTool)contextMenu.Tag;
			if (new FormLinkLineCable(lineTool)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
				sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.vSchm_CabSection, true);
				decimal num = 0m;
				string text = string.Empty;
				SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString());
				string cmdText = "select top 1 id from tP_Passport where idObjList = " + lineTool.IdBase.ToString();
				SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
				try
				{
					sqlConnection.Open();
					int num2 = (int)sqlCommand.ExecuteScalar();
					if (num2 > -1)
					{
						sqlCommand.CommandText = "select top 1 Value from tP_ObjectChar where idObjChar = 182 and idPassport = " + num2.ToString();
						text = sqlCommand.ExecuteScalar().ToString();
					}
				}
				catch
				{
				}
				if (lineTool.CouplingRelations.Count == 1)
				{
					DataRow dataRow = null;
					IEnumerable<DataRow> enumerable = this.dataSetScheme_0.vSchm_CabSection.Select("idObjList = " + lineTool.IdBase);
					if (enumerable.Count<DataRow>() > 0)
					{
						decimal d = 0m;
						dataRow = null;
						num = 0m;
						foreach (DataRow dataRow2 in enumerable)
						{
							num += Convert.ToDecimal(dataRow2[8]);
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
					}
					if (dataRow != null)
					{
						if (text == string.Empty)
						{
							text = Math.Round(Convert.ToDecimal(num), 0).ToString();
						}
						if (lineTool.Branches.Count == 1)
						{
							TextBranchTool textBranchTool = new TextBranchTool();
							textBranchTool.Parent = lineTool.Branches[0];
							textBranchTool.Text = string.Empty;
							lineTool.Layer.AddObject(textBranchTool);
							textBranchTool.UpdateSQLFields(dataRow, text);
							textBranchTool.Passport = true;
						}
						else
						{
							foreach (PointTool pointTool in lineTool.Ends)
							{
								foreach (Branch branch in pointTool.Branches)
								{
									if (branch.Parent == lineTool)
									{
										TextBranchTool textBranchTool2 = new TextBranchTool();
										textBranchTool2.Parent = branch;
										textBranchTool2.Text = string.Empty;
										if (pointTool == branch.Source)
										{
											textBranchTool2.Delta = 0.3f;
										}
										else if (pointTool == branch.Destination)
										{
											textBranchTool2.Delta = 0.6f;
											textBranchTool2.Direct = true;
										}
										lineTool.Layer.AddObject(textBranchTool2);
										textBranchTool2.UpdateSQLFields(dataRow, text);
										textBranchTool2.Passport = true;
									}
								}
							}
						}
					}
					lineTool.SaveXmlToSql();
					this.DoInvalidate(true);
				}
				MessageBox.Show("Паспорт успешно привязан к кабельной линии.");
			}
		}

		private void toolMenuItemLineDeLinkPassport_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			LineTool lineTool = (LineTool)contextMenu.Tag;
			if (CableLine.UnbindPassport(this.SqlSettings, lineTool.IdBase))
			{
				MessageBox.Show("Паспорт успешно отвязан от кабельной линии.");
			}
		}

		private void toolMenuItemLinePassport_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			LineTool lineTool = (LineTool)contextMenu.Tag;
			if (base.Parent != null && base.Parent is DockContentBase)
			{
				DockPanel dockPanel = ((DockContentBase)base.Parent).DockPanel;
				FormDockPassport formDockPassport = new FormDockPassport(this.SqlSettings, lineTool.IdBase);
				formDockPassport.Show(dockPanel);
			}
		}

		private void toolStripMenuItemLineAddTelemertryLabel_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && contextMenu.Tag == null)
			{
				return;
			}
			DrawObjectBase drawObjectBase = (DrawObjectBase)contextMenu.Tag;
			TelemetryLabelTool telemetryLabelTool = new TelemetryLabelTool();
			telemetryLabelTool.ObjectTelemetry = drawObjectBase.IdBase;
			telemetryLabelTool.Location = this.unitPoint_2;
			drawObjectBase.Layer.AddObject(telemetryLabelTool);
			PointF pointF = ConvertCanvas.ConvertToScreen(this, telemetryLabelTool.Location);
			Point location = base.PointToScreen(new Point((int)pointF.X, (int)pointF.Y));
			if (!telemetryLabelTool.ShowPropertyForm(location))
			{
				telemetryLabelTool.Remove(false, false);
			}
		}

		private void method_82(object sender, EventArgs e)
		{
		}

		private void contextMenuLineTool_Closed(object sender, ToolStripDropDownClosedEventArgs e)
		{
			if (this.showContextMenuCanvasEventHandler_1 != null)
			{
				this.showContextMenuCanvasEventHandler_1(this.contextMenuLineTool, null);
			}
		}

		private void contextMenuSelectedObjects_Opening(object sender, CancelEventArgs e)
		{
			this.toolMenuItemDeleteSelectedObjects.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuItemSelectedAlign.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolStripMenuItemBookmark.Visible = false;
			this.toolStripMenuItemRemoveBookmark.Visible = false;
			this.toolMenuItemPasteSelectedObjects.Enabled = (this.Mode == eCanvasEditingMode.Edit && CopyPasteCanvasObjects.IsPasteInObjects(this.SelectedObjects.ToList<DrawObjectBase>(), this.list_7));
			this.toolStripMenuItemGroupSelectedObject.Visible = false;
			this.toolStripMenuItemGroupProperty.Visible = false;
			this.toolStripSeparatorGroup.Visible = false;
			this.SelectedObjects.Count<DrawObjectBase>();
			int num = 0;
			int num2 = 0;
			List<GroupDrawObjectBase> list = new List<GroupDrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase is ShinaTool)
				{
					if (((RectangleTool)drawObjectBase.Parent).TypeRectnagleTool == eTypeRectangleTool.CP)
					{
						num2++;
					}
					else if (((RectangleTool)drawObjectBase.Parent).TypeRectnagleTool != eTypeRectangleTool.CP)
					{
						num++;
					}
				}
				if (drawObjectBase.Group != null && !list.Contains(drawObjectBase.Group))
				{
					list.Add(drawObjectBase.Group);
				}
				if (drawObjectBase.Bookmark == null)
				{
					this.toolStripMenuItemBookmark.Visible = true;
				}
				if (drawObjectBase.Bookmark != null)
				{
					this.toolStripMenuItemRemoveBookmark.Visible = true;
				}
				if (this.toolStripMenuItemBookmark.Visible && this.toolStripMenuItemRemoveBookmark.Visible)
				{
					break;
				}
			}
			if (this.Mode == eCanvasEditingMode.Edit)
			{
				if (list.Count == 0)
				{
					ToolStripItem toolStripItem = this.toolStripSeparatorGroup;
					this.toolStripMenuItemGroupSelectedObject.Visible = true;
					toolStripItem.Visible = true;
				}
				else if (list.Count == 1)
				{
					ToolStripItem toolStripItem2 = this.toolStripSeparatorGroup;
					this.toolStripMenuItemGroupProperty.Visible = true;
					toolStripItem2.Visible = true;
				}
			}
			this.toolMenuItemSelectedPowerBullshit.Visible = (num == 1 && num2 > 0);
			this.toolStripSeparator13.Visible = this.toolMenuItemSelectedPowerBullshit.Visible;
		}

		private void toolMenuItemCenterSElectedObjects_Click(object sender, EventArgs e)
		{
			this.SetObjectsInCenterScreen(this.SelectedObjects.ToList<DrawObjectBase>(), true, CanvasControl.SetObjectsInCenterScreenOptions.none);
		}

		private void toolMenuItemDeleteSelectedObjects_Click(object sender, EventArgs e)
		{
			if (this.SelectedObjects.Count<DrawObjectBase>() > 0)
			{
				this.RemoveSelectedObjects();
			}
		}

		private void toolMenuItemAddFilterSelectedObjects_Click(object sender, EventArgs e)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase is Branch)
				{
					if (drawObjectBase.Parent != null && !list.Contains(drawObjectBase.Parent))
					{
						list.Add(drawObjectBase.Parent);
					}
				}
				else if (drawObjectBase is BranchCollection)
				{
					if (((BranchCollection)drawObjectBase).Collection.Count<Branch>() > 0)
					{
						Branch branch = ((BranchCollection)drawObjectBase).Collection.First<Branch>();
						if (branch.Parent != null && !list.Contains(branch.Parent))
						{
							list.Add(branch.Parent);
						}
					}
				}
				else if (!list.Contains(drawObjectBase))
				{
					list.Add(drawObjectBase);
				}
			}
			new FormCanvasAddDelFilter(list, StateFormCreate.Add)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog();
		}

		private void toolMenuItemDeleteFilterSelectedObjects_Click(object sender, EventArgs e)
		{
			List<DrawObjectBase> list = new List<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase is Branch)
				{
					if (drawObjectBase.Parent != null && !list.Contains(drawObjectBase.Parent))
					{
						list.Add(drawObjectBase.Parent);
					}
				}
				else if (!list.Contains(drawObjectBase))
				{
					list.Add(drawObjectBase);
				}
			}
			new FormCanvasAddDelFilter(list, StateFormCreate.Delete)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog();
		}

		private void toolMenuItemSelectedPowerBullshit_Click(object sender, EventArgs e)
		{
			if (this.SelectedCount != 3)
			{
				return;
			}
			new List<ShinaTool>();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
			}
		}

		private void toolMenuItemSelectedAlignByVertCenter_Click(object sender, EventArgs e)
		{
			if (this.SelectedObjects.Count<DrawObjectBase>() < 2)
			{
				return;
			}
			UnitPoint empty = UnitPoint.Empty;
			this.method_29();
			DrawObjectBase drawObjectBase = this.SelectedObjects.First<DrawObjectBase>();
			if (drawObjectBase is LineTool)
			{
				return;
			}
			RectangleF boundingRect = drawObjectBase.GetBoundingRect(this, false);
			string a;
			if ((a = ((ToolStripMenuItem)sender).Tag.ToString()) != null)
			{
				if (!(a == "T"))
				{
					if (!(a == "B"))
					{
						if (!(a == "R"))
						{
							if (!(a == "L"))
							{
								if (!(a == "H"))
								{
									if (a == "V")
									{
										empty = new UnitPoint(0.0, (double)(boundingRect.Y + boundingRect.Height / 2f));
									}
								}
								else
								{
									empty = new UnitPoint((double)(boundingRect.X + boundingRect.Width / 2f), 0.0);
								}
							}
							else
							{
								empty = new UnitPoint((double)boundingRect.Left, 0.0);
							}
						}
						else
						{
							empty = new UnitPoint((double)boundingRect.Right, 0.0);
						}
					}
					else
					{
						empty = new UnitPoint(0.0, (double)boundingRect.Top);
					}
				}
				else
				{
					empty = new UnitPoint(0.0, (double)boundingRect.Bottom);
				}
			}
			Type type = drawObjectBase.GetType();
			bool flag = false;
			foreach (DrawObjectBase drawObjectBase2 in this.SelectedObjects)
			{
				if (drawObjectBase2.GetType() != type)
				{
					break;
				}
				if (flag)
				{
					return;
				}
			}
			UnitPoint offset = UnitPoint.Empty;
			foreach (DrawObjectBase drawObjectBase3 in this.SelectedObjects)
			{
				if (drawObjectBase3 != drawObjectBase)
				{
					RectangleF boundingRect2 = drawObjectBase3.GetBoundingRect(this, false);
					string a2;
					if ((a2 = ((ToolStripMenuItem)sender).Tag.ToString()) != null)
					{
						if (!(a2 == "T"))
						{
							if (!(a2 == "B"))
							{
								if (!(a2 == "V"))
								{
									if (!(a2 == "R"))
									{
										if (!(a2 == "L"))
										{
											if (a2 == "H")
											{
												offset = new UnitPoint(empty.X - (double)(boundingRect2.X + boundingRect2.Width / 2f), 0.0);
											}
										}
										else
										{
											offset = new UnitPoint(empty.X - (double)boundingRect2.Left, 0.0);
										}
									}
									else
									{
										offset = new UnitPoint(empty.X - (double)boundingRect2.Right, 0.0);
									}
								}
								else
								{
									offset = new UnitPoint(0.0, empty.Y - (double)(boundingRect2.Y + boundingRect2.Height / 2f));
								}
							}
							else
							{
								offset = new UnitPoint(0.0, empty.Y - (double)boundingRect2.Top);
							}
						}
						else
						{
							offset = new UnitPoint(0.0, empty.Y - (double)boundingRect2.Bottom);
						}
					}
					drawObjectBase3.Move(offset, true);
				}
			}
			this.DoInvalidate(true);
			this.method_24();
		}

		private void toolMenuItemCopySelectedObjectsToImage_Click(object sender, EventArgs e)
		{
			this.CopyToImage();
		}

		private void toolStripMenuItemGroupSelectedObject_Click(object sender, EventArgs e)
		{
			if (this.SelectedObjects.Count<DrawObjectBase>() < 2)
			{
				return;
			}
			GroupDrawObjectBase groupDrawObjectBase = new GroupDrawObjectBase();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase.Group == null)
				{
					groupDrawObjectBase.Add(drawObjectBase);
				}
			}
			GroupPropertyForm groupPropertyForm = new GroupPropertyForm(groupDrawObjectBase);
			if (groupPropertyForm.ShowDialog() == DialogResult.OK)
			{
				this.dictionary_0[groupDrawObjectBase.Id] = groupDrawObjectBase;
			}
		}

		private void toolStripMenuItemGroupProperty_Click(object sender, EventArgs e)
		{
			List<GroupDrawObjectBase> list = new List<GroupDrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in this.SelectedObjects)
			{
				if (drawObjectBase.Group != null && !list.Contains(drawObjectBase.Group))
				{
					list.Add(drawObjectBase.Group);
				}
			}
			if (list.Count == 1)
			{
				GroupPropertyForm groupPropertyForm = new GroupPropertyForm(list[0]);
				groupPropertyForm.ShowDialog();
			}
		}

		private void toolMenuItemExportSelectedObjectsToDXF_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "(*.dxf)|*.dxf";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.ExportToDXF(saveFileDialog.FileName);
				MessageBox.Show("Файл успешно сохранен");
			}
		}

		private void contextMenuCanvas_Opening(object sender, CancelEventArgs e)
		{
			this.toolMenuItemAddNode.Visible = (this.Mode != eCanvasEditingMode.ReadOnly && this.TypeCanvas != eTypeCanvas.SchemeSecond);
			this.toolStripMenuItemAddTelemetryLabel2Level.Visible = (this.Mode == eCanvasEditingMode.Edit && this.TypeCanvas == eTypeCanvas.SchemeSecond);
			this.toolStripMenuItemAddFreeLabel.Visible = (this.Mode == eCanvasEditingMode.Edit);
			this.toolMenuCanvasPaste.Visible = (this.Mode == eCanvasEditingMode.Edit);
			bool cancel;
			if (this.Mode != eCanvasEditingMode.ReadOnly)
			{
				if (this.TypeCanvas != eTypeCanvas.SchemeSecond)
				{
					cancel = false;
					goto IL_8F;
				}
			}
			cancel = (this.Mode != eCanvasEditingMode.Edit);
			IL_8F:
			e.Cancel = cancel;
			if (this.list_7 == null || this.list_7.Count == 0)
			{
				this.toolMenuCanvasPaste.Enabled = false;
			}
		}

		private void toolMenuCanvasPaste_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu != null && contextMenu.Tag != null && contextMenu.Tag is UnitPoint)
			{
				UnitPoint unitPoint_ = (UnitPoint)contextMenu.Tag;
				this.method_41(unitPoint_);
			}
		}

		private void toolMenuItemAddNode_Click(object sender, EventArgs e)
		{
			NodeTool nodeTool = new NodeTool();
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu != null && contextMenu.Tag != null && contextMenu.Tag is UnitPoint)
			{
				UnitPoint location = (UnitPoint)contextMenu.Tag;
				nodeTool.Location = location;
				this.AddObject(this.ActiveLayer, nodeTool);
				if (!nodeTool.ShowPropertyForm(Point.Empty))
				{
					nodeTool.Remove(false, false);
				}
			}
		}

		private void toolStripMenuItemAddFreeLabel_Click(object sender, EventArgs e)
		{
			FreeLabelTool freeLabelTool = new FreeLabelTool();
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu != null && contextMenu.Tag != null && contextMenu.Tag is UnitPoint)
			{
				UnitPoint location = (UnitPoint)contextMenu.Tag;
				freeLabelTool.Location = location;
				this.AddObject(this.ActiveLayer, freeLabelTool);
				if (!freeLabelTool.ShowPropertyForm(Point.Empty))
				{
					freeLabelTool.Remove(false, false);
				}
			}
		}

		private void toolStripMenuItemAddTelemetryLabel2Level_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null && this.Mode != eCanvasEditingMode.Edit && this.TypeCanvas != eTypeCanvas.SchemeSecond && this.IdRect == 0)
			{
				return;
			}
			TelemetryLabelTool telemetryLabelTool = new TelemetryLabelTool();
			telemetryLabelTool.ObjectTelemetry = this.IdRect;
			telemetryLabelTool.Location = (UnitPoint)contextMenu.Tag;
			this.AddObject(this.ActiveLayer, telemetryLabelTool);
			if (!telemetryLabelTool.ShowPropertyForm(Point.Empty))
			{
				telemetryLabelTool.Remove(false, false);
			}
		}

		private void contextMenuLabelTool_Opening(object sender, CancelEventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null)
			{
				if (contextMenu.Tag.GetType() != typeof(AutomaticEntryProvisionTool) && contextMenu.Tag.GetType() != typeof(SpecialLockingTool) && contextMenu.Tag.GetType() != typeof(TelemechanicsTool) && contextMenu.Tag.GetType() != typeof(TelemechanicsProtectionTool))
				{
					if (contextMenu.Tag.GetType() != typeof(ResponsibleAbonentTool))
					{
						if (contextMenu.Tag.GetType() != typeof(TelemetryLabelTool))
						{
							this.toolMenuItemLabelDel.Visible = false;
						}
						if (this.Mode == eCanvasEditingMode.ReadOnly)
						{
							this.toolMenuItemLabelDel.Visible = false;
							goto IL_E5;
						}
						this.toolMenuItemLabelDel.Visible = true;
						goto IL_E5;
					}
				}
				this.toolMenuItemLabelDel.Visible = false;
				IL_E5:
				if (contextMenu.Tag.GetType() != typeof(TelemetryLabelTool) && contextMenu.Tag.GetType() != typeof(MeasurementLabelTool))
				{
					this.toolMenuItemLabelUpdate.Visible = false;
				}
			}
		}

		private void toolMenuItemLabelDel_Click(object sender, EventArgs e)
		{
			if (this.list_1 != null)
			{
				foreach (DrawObjectBase drawObjectBase in this.list_1)
				{
					if (drawObjectBase is NodeTool)
					{
						this.ProxySingleton.NodeChange(drawObjectBase.IdBase, 2, null, PointF.Empty, Color.Empty);
					}
				}
				UndoRedoManager.RegistrarOfChanges changes = new UndoRedoManager.RegistrarOfChanges(this.SelectedObjects.ToList<DrawObjectBase>(), UndoRedoManager.ChangesMode.DeleteObject);
				this.undoRedoManager.HappenedChange(changes);
				this.DeleteObjects(this.SelectedObjects, true);
				this.ClearSelectedObjects();
				this.DoInvalidate(true);
				this.method_39();
			}
		}

		private void toolMenuItemLabelUpdate_Click(object sender, EventArgs e)
		{
			ContextMenuStrip contextMenu = CanvasControl.GetContextMenu(sender);
			if (contextMenu == null)
			{
				return;
			}
			if (contextMenu.Tag != null && contextMenu.Tag.GetType() == typeof(TelemetryLabelTool))
			{
				int[] array = new int[]
				{
					((TelemetryLabelTool)contextMenu.Tag).ObjectTelemetry,
					((TelemetryLabelTool)contextMenu.Tag).TelemetryParameterId
				};
				this.OpcClient.OPCAsyncSend_GetItem(array);
				return;
			}
			if (contextMenu.Tag != null && contextMenu.Tag.GetType() == typeof(MeasurementLabelTool))
			{
				this.method_71(((MeasurementLabelTool)contextMenu.Tag).Parent.IdBase);
			}
		}

		public List<int> ApplyFilter()
		{
			List<int> list = new List<int>();
			FormCanvasFilterApply formCanvasFilterApply = new FormCanvasFilterApply(this.Settings);
			formCanvasFilterApply.SqlSettings = this.SqlSettings;
			if (formCanvasFilterApply.ShowDialog() == DialogResult.OK)
			{
				this.list_8 = formCanvasFilterApply.ListIdFilter;
				string text = "";
				foreach (int num in this.list_8)
				{
					text = text + num.ToString() + ",";
				}
				if (text.Length > 0)
				{
					text = text.Remove(text.Length - 1);
					SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
					sqlDataCommand.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tSchm_ObjFilter, true, "where [idFilter] in (" + text + ")");
					foreach (DataRow dataRow in this.dataSetScheme_0.tSchm_ObjFilter)
					{
						list.Add(Convert.ToInt32(dataRow["idObj"]));
					}
					if (!formCanvasFilterApply.IsOtherWindow)
					{
						foreach (ICanvasLayer canvasLayer in this.Layers)
						{
							((DrawingLayer)canvasLayer).ApplyFilter(list);
						}
						this.DoInvalidate(true);
						list = null;
					}
				}
				return list;
			}
			return null;
		}

		public void ApplyFilter(List<int> listIdObjects)
		{
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				((DrawingLayer)canvasLayer).ApplyFilter(listIdObjects);
			}
			this.DoInvalidate(true);
		}

		public void ClearFilter()
		{
			foreach (ICanvasLayer canvasLayer in this.Layers)
			{
				((DrawingLayer)canvasLayer).ClearFilter();
			}
			this.DoInvalidate(true);
		}

		private void toolStripMenuFramePrint_Click(object sender, EventArgs e)
		{
			this.Print();
		}

		private void toolStripMenuFrameCopyToImage_Click(object sender, EventArgs e)
		{
			this.CopyToImage();
		}

		private void toolStripMenuFrameFitZoom_Click(object sender, EventArgs e)
		{
			if (this.canvasFrame_0 != null)
			{
				this.method_43(this.canvasFrame_0.Rectangle, true);
				this.eCommandType_0 = eCommandType.select;
				this.canvasFrame_0 = null;
				this.method_39();
			}
		}

		private void toolStripMenuFrameExportToImage_Click(object sender, EventArgs e)
		{
			this.ExportToImage();
		}

		public static ContextMenuStrip GetContextMenu(object sender)
		{
			if (sender == null)
			{
				return null;
			}
			if (sender is ContextMenuStrip)
			{
				return sender as ContextMenuStrip;
			}
			ToolStripItem toolStripItem = sender as ToolStripItem;
			while (toolStripItem.OwnerItem != null)
			{
				toolStripItem = toolStripItem.OwnerItem;
			}
			ContextMenuStrip contextMenuStrip = toolStripItem.Owner as ContextMenuStrip;
			if (contextMenuStrip != null)
			{
				return contextMenuStrip;
			}
			return null;
		}

		private void contextMenuTextBranchTool_Opening(object sender, CancelEventArgs e)
		{
			this.toolMenuItemTextBranchDel.Enabled = (this.Mode == eCanvasEditingMode.Edit);
		}

		[CompilerGenerated]
		private static bool smethod_2(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.Visible;
		}

		[CompilerGenerated]
		private RectangleF method_83(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetBoundingRect(this, false);
		}

		[CompilerGenerated]
		private static float smethod_3(RectangleF rectangleF_2)
		{
			return rectangleF_2.X;
		}

		[CompilerGenerated]
		private static float smethod_4(RectangleF rectangleF_2)
		{
			return rectangleF_2.Y;
		}

		[CompilerGenerated]
		private static float smethod_5(RectangleF rectangleF_2)
		{
			return rectangleF_2.Right;
		}

		[CompilerGenerated]
		private static float smethod_6(RectangleF rectangleF_2)
		{
			return rectangleF_2.Bottom;
		}

		[CompilerGenerated]
		private static bool smethod_7(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.Visible;
		}

		[CompilerGenerated]
		private RectangleF method_84(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetBoundingRect(this, false);
		}

		[CompilerGenerated]
		private static float smethod_8(RectangleF rectangleF_2)
		{
			return rectangleF_2.X;
		}

		[CompilerGenerated]
		private static float smethod_9(RectangleF rectangleF_2)
		{
			return rectangleF_2.Y;
		}

		[CompilerGenerated]
		private static float smethod_10(RectangleF rectangleF_2)
		{
			return rectangleF_2.Right;
		}

		[CompilerGenerated]
		private static float smethod_11(RectangleF rectangleF_2)
		{
			return rectangleF_2.Bottom;
		}

		[CompilerGenerated]
		private static bool smethod_12(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetType() == typeof(ShinaTool);
		}

		[CompilerGenerated]
		private bool method_85(DataRow dataRow_0)
		{
			return Convert.ToInt32(dataRow_0["Id"]) == this.IdRect;
		}

		[CompilerGenerated]
		private static bool smethod_13(PointTool pointTool_0)
		{
			return pointTool_0.NeedToPreserve != NeedToPreserveEnum.None;
		}

		[CompilerGenerated]
		private static bool smethod_14(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2 is ObjectOnLine;
		}

		[CompilerGenerated]
		private static bool smethod_15(ObjectBaseServer objectBaseServer_0)
		{
			return objectBaseServer_0.TypeTransferObject == eTypeTransferObject.Rectangle;
		}

		[CompilerGenerated]
		private static bool smethod_16(ObjectBaseServer objectBaseServer_0)
		{
			return objectBaseServer_0.TypeTransferObject == eTypeTransferObject.Shina;
		}

		[CompilerGenerated]
		private static bool smethod_17(ObjectBaseServer objectBaseServer_0)
		{
			return objectBaseServer_0.TypeTransferObject == eTypeTransferObject.ObjectOnLine;
		}

		[CompilerGenerated]
		private static bool smethod_18(ObjectBaseServer objectBaseServer_0)
		{
			return objectBaseServer_0.TypeTransferObject == eTypeTransferObject.Cell;
		}

		[CompilerGenerated]
		private static bool smethod_19(ObjectBaseServer objectBaseServer_0)
		{
			return objectBaseServer_0.TypeTransferObject == eTypeTransferObject.Line;
		}

		[CompilerGenerated]
		private static bool smethod_20(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetType() == typeof(RectangleTool) && ((RectangleTool)drawObjectBase_2).TypeRectnagleTool == eTypeRectangleTool.CP;
		}

		[CompilerGenerated]
		private static bool smethod_21(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetType() == typeof(ShinaTool);
		}

		[CompilerGenerated]
		private static bool smethod_22(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetType() == typeof(TelemetryLabelTool);
		}

		[CompilerGenerated]
		private static bool smethod_23(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2 is ObjectOnLine;
		}

		[CompilerGenerated]
		private static bool smethod_24(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetType() == typeof(TelemetryLabelTool);
		}

		[CompilerGenerated]
		private void method_86()
		{
			this.labelInfo.Text = "Соединение с OPCServer...";
		}

		[CompilerGenerated]
		private void method_87()
		{
			this.labelInfo.Text = "Соединение с OPCServer прошло успешно";
		}

		[CompilerGenerated]
		private void method_88()
		{
			this.labelInfo.Text = "Не удается соединиться с OPCServer...";
		}

		[CompilerGenerated]
		private void method_89()
		{
			this.labelInfo.Text = "Обрыв соединения с OPCServer...";
		}

		[CompilerGenerated]
		private static bool smethod_25(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetType() == typeof(TelemetryLabelTool);
		}

		[CompilerGenerated]
		private void method_90(bool bool_12)
		{
			this.method_17(bool_12);
		}

		[CompilerGenerated]
		private static bool smethod_26(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2 is ObjectOnLine;
		}

		[CompilerGenerated]
		private static bool smethod_27(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2 is ObjectOnLine;
		}

		[CompilerGenerated]
		private static bool smethod_28(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2 is NodeTool;
		}

		[CompilerGenerated]
		private static bool smethod_29(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2 is LineTool;
		}

		[CompilerGenerated]
		private static bool smethod_30(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetType() == typeof(TransformerTool);
		}

		[CompilerGenerated]
		private static bool smethod_31(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetType() == typeof(TransformerTool);
		}

		[CompilerGenerated]
		private static bool smethod_32(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.LimitedEditing;
		}

		[CompilerGenerated]
		private static bool smethod_33(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.IdBase > 0 && !drawObjectBase_2.LimitedEditing;
		}

		[CompilerGenerated]
		private static bool smethod_34(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.IdBase > 0 && !drawObjectBase_2.LimitedEditing;
		}

		[CompilerGenerated]
		private RectangleF method_91(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetBoundingRect(this, false);
		}

		[CompilerGenerated]
		private static float smethod_35(RectangleF rectangleF_2)
		{
			return rectangleF_2.X;
		}

		[CompilerGenerated]
		private static float smethod_36(RectangleF rectangleF_2)
		{
			return rectangleF_2.Y;
		}

		[CompilerGenerated]
		private static float smethod_37(RectangleF rectangleF_2)
		{
			return rectangleF_2.Right;
		}

		[CompilerGenerated]
		private static float smethod_38(RectangleF rectangleF_2)
		{
			return rectangleF_2.Bottom;
		}

		[CompilerGenerated]
		private RectangleF method_92(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetBoundingRect(this, false);
		}

		[CompilerGenerated]
		private static float smethod_39(RectangleF rectangleF_2)
		{
			return rectangleF_2.X;
		}

		[CompilerGenerated]
		private static float smethod_40(RectangleF rectangleF_2)
		{
			return rectangleF_2.Y;
		}

		[CompilerGenerated]
		private static float smethod_41(RectangleF rectangleF_2)
		{
			return rectangleF_2.Right;
		}

		[CompilerGenerated]
		private static float smethod_42(RectangleF rectangleF_2)
		{
			return rectangleF_2.Bottom;
		}

		[CompilerGenerated]
		private static bool smethod_43(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.Visible;
		}

		[CompilerGenerated]
		private RectangleF method_93(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetBoundingRect(this, false);
		}

		[CompilerGenerated]
		private static bool smethod_44(RectangleF rectangleF_2)
		{
			return !float.IsNaN(rectangleF_2.X);
		}

		[CompilerGenerated]
		private static float smethod_45(RectangleF rectangleF_2)
		{
			return rectangleF_2.X;
		}

		[CompilerGenerated]
		private static bool smethod_46(RectangleF rectangleF_2)
		{
			return !float.IsNaN(rectangleF_2.Y);
		}

		[CompilerGenerated]
		private static float smethod_47(RectangleF rectangleF_2)
		{
			return rectangleF_2.Y;
		}

		[CompilerGenerated]
		private static bool smethod_48(RectangleF rectangleF_2)
		{
			return !float.IsNaN(rectangleF_2.Right);
		}

		[CompilerGenerated]
		private static float smethod_49(RectangleF rectangleF_2)
		{
			return rectangleF_2.Right;
		}

		[CompilerGenerated]
		private static bool smethod_50(RectangleF rectangleF_2)
		{
			return !float.IsNaN(rectangleF_2.Bottom);
		}

		[CompilerGenerated]
		private static float smethod_51(RectangleF rectangleF_2)
		{
			return rectangleF_2.Bottom;
		}

		[CompilerGenerated]
		private static bool smethod_52(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2 is ObjectOnLine && drawObjectBase_2.GetType().GetProperty("On").CanWrite;
		}

		[CompilerGenerated]
		private static bool smethod_53(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetType() == typeof(ShinaTool) && drawObjectBase_2.Parent != null && drawObjectBase_2.Parent.GetType() == typeof(RectangleTool) && ((RectangleTool)drawObjectBase_2.Parent).TypeRectnagleTool == eTypeRectangleTool.CP;
		}

		[CompilerGenerated]
		private static bool smethod_54(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetType() == typeof(ShinaTool) && drawObjectBase_2.Parent.GetType() == typeof(RectangleTool) && ((RectangleTool)drawObjectBase_2.Parent).TypeRectnagleTool == eTypeRectangleTool.CP;
		}

		[CompilerGenerated]
		private static bool smethod_55(RectangleF rectangleF_2)
		{
			return !float.IsNaN(rectangleF_2.X);
		}

		[CompilerGenerated]
		private static float smethod_56(RectangleF rectangleF_2)
		{
			return rectangleF_2.X;
		}

		[CompilerGenerated]
		private static bool smethod_57(RectangleF rectangleF_2)
		{
			return !float.IsNaN(rectangleF_2.Y);
		}

		[CompilerGenerated]
		private static float smethod_58(RectangleF rectangleF_2)
		{
			return rectangleF_2.Y;
		}

		[CompilerGenerated]
		private static bool smethod_59(RectangleF rectangleF_2)
		{
			return !float.IsNaN(rectangleF_2.Right);
		}

		[CompilerGenerated]
		private static float smethod_60(RectangleF rectangleF_2)
		{
			return rectangleF_2.Right;
		}

		[CompilerGenerated]
		private static bool smethod_61(RectangleF rectangleF_2)
		{
			return !float.IsNaN(rectangleF_2.Bottom);
		}

		[CompilerGenerated]
		private static float smethod_62(RectangleF rectangleF_2)
		{
			return rectangleF_2.Bottom;
		}

		[CompilerGenerated]
		private static bool smethod_63(PointTool pointTool_0)
		{
			return pointTool_0.CouplingRelations.Count > 1;
		}

		[CompilerGenerated]
		private static bool smethod_64(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetType() == typeof(ShinaTool) && ((ShinaTool)drawObjectBase_2).Amperage != null;
		}

		[CompilerGenerated]
		private static bool smethod_65(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.Visible;
		}

		[CompilerGenerated]
		private RectangleF method_94(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetBoundingRect(this, false);
		}

		[CompilerGenerated]
		private static bool smethod_66(RectangleF rectangleF_2)
		{
			return !float.IsNaN(rectangleF_2.X);
		}

		[CompilerGenerated]
		private static float smethod_67(RectangleF rectangleF_2)
		{
			return rectangleF_2.X;
		}

		[CompilerGenerated]
		private static bool smethod_68(RectangleF rectangleF_2)
		{
			return !float.IsNaN(rectangleF_2.Y);
		}

		[CompilerGenerated]
		private static float smethod_69(RectangleF rectangleF_2)
		{
			return rectangleF_2.Y;
		}

		[CompilerGenerated]
		private static bool smethod_70(RectangleF rectangleF_2)
		{
			return !float.IsNaN(rectangleF_2.Right);
		}

		[CompilerGenerated]
		private static float smethod_71(RectangleF rectangleF_2)
		{
			return rectangleF_2.Right;
		}

		[CompilerGenerated]
		private static bool smethod_72(RectangleF rectangleF_2)
		{
			return !float.IsNaN(rectangleF_2.Bottom);
		}

		[CompilerGenerated]
		private static float smethod_73(RectangleF rectangleF_2)
		{
			return rectangleF_2.Bottom;
		}

		[CompilerGenerated]
		private static bool smethod_74(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2 is PointTool;
		}

		[CompilerGenerated]
		private static bool smethod_75(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2 is RectangleTool;
		}

		[CompilerGenerated]
		private static int smethod_76(KeyValuePair<int, PointTool> keyValuePair_0)
		{
			return keyValuePair_0.Key;
		}

		[CompilerGenerated]
		private static bool smethod_77(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2.GetType() == typeof(MeasurementLabelTool) && drawObjectBase_2.Parent != null && drawObjectBase_2.Parent.GetType() == typeof(ShinaTool);
		}

		[CompilerGenerated]
		private static bool smethod_78(DrawObjectBase drawObjectBase_2)
		{
			return drawObjectBase_2 is PointShinaTool;
		}

		[CompilerGenerated]
		private static int smethod_79(DrawObjectBase drawObjectBase_2, DrawObjectBase drawObjectBase_3)
		{
			return ((PointShinaTool)drawObjectBase_2).Delta.CompareTo(((PointShinaTool)drawObjectBase_3).Delta);
		}

		private const string string_0 = "/Obj";

		public const float ScreenResolution = 96f;

		private const string string_1 = "//MS";

		private const string string_2 = "//SS";

		private const float float_0 = 100f;

		private const float float_1 = 0.001f;

		public bool isPrintFrame = true;

		internal bool bool_0;

		private int int_0 = 1;

		private int int_1 = 1;

		private int int_2;

		private Bitmap bitmap_0;

		internal Enum3 enum3_0 = Enum3.const_2;

		private int int_3 = 1;

		private CanvasControl canvasControl_0;

		private IContainer icontainer_0;

		private StatusStrip statusStrip;

		private ToolStripStatusLabel labelMousePosition;

		public PrintDocument printDocument;

		public PrintPreviewDialog printPreviewDialog;

		internal DataSetScheme dataSetScheme_0;

		private PropertyGrid propertyGrid1;

		private Button bigBoldButton;

		private ToolStripStatusLabel toolLabelEmpty;

		private ToolStripStatusLabel labelProgressBar;

		private ToolStripProgressBar toolProgressBarSave;

		private Button buttonCheck;

		private ToolStripStatusLabel labelInfo;

		private System.Windows.Forms.Timer timer_0;

		private Label tbPopup;

		private ToolStripSplitButton toolBtnZoom;

		private ToolStripMenuItem toolBtnZoom800;

		private ToolStripMenuItem toolBtnZoom400;

		private ToolStripMenuItem toolBtnZoom200;

		private ToolStripMenuItem toolBtnZoom150;

		private ToolStripMenuItem toolBtnZoom125;

		private ToolStripMenuItem toolBtnZoom100;

		private ToolStripMenuItem toolBtnZoom75;

		private ToolStripMenuItem toolBtnZoom50;

		private ToolStripMenuItem toolBtnZoom25;

		private ContextMenuStrip contextMenuSelectedObjects;

		private ToolStripMenuItem toolMenuItemDeleteSelectedObjects;

		private ToolStripMenuItem toolMenuItemFilterSelectedObjects;

		private ToolStripMenuItem toolMenuItemCenterSElectedObjects;

		private ToolStripMenuItem toolMenuItemAddFilterSelectedObjects;

		private ToolStripMenuItem toolMenuItemDeleteFilterSelectedObjects;

		private ContextMenuStrip contextMenuRectnagle;

		private ToolStripMenuItem toolMenuItemRectProperty;

		private ToolStripMenuItem toolMenuItemRectPowerSource;

		private ToolStripMenuItem toolMenuItemRectRecipientsPower;

		private ToolStripSeparator toolStripSeparator1;

		private ToolStripMenuItem toolMenuItemRectAlign;

		private ToolStripMenuItem toolMenuItemRectDel;

		private ToolStripSeparator toolStripSeparator2;

		private ContextMenuStrip contextMenuShina;

		private ToolStripMenuItem toolMenuItemShinaPowerSource;

		private ToolStripMenuItem toolMenuItemShinaRecipientsPower;

		private ToolStripSeparator toolStripSeparator3;

		private ToolStripMenuItem toolMenuItemShinaDel;

		private ToolStripSeparator toolStripSeparatorEditShina;

		private ToolStripMenuItem toolMenuItemShinaProperty;

		private ToolStripMenuItem toolMenuItemShinaAddChild;

		private ToolStripMenuItem toolMenuItemShinaAddCell;

		private ToolStripMenuItem toolMenuItemShinaBridge;

		private ToolStripMenuItem toolMenuItemShinaSplitter;

		private ContextMenuStrip contextMenuSwitchTool;

		private ToolStripMenuItem toolMenuItemSwitchDel;

		private ToolStripSeparator toolStripSeparator5;

		private ToolStripMenuItem toolMenuItemSwitchProperty;

		private ContextMenuStrip contextMenuLineTool;

		private ToolStripMenuItem toolMenuItemLineAddChild;

		private ToolStripMenuItem toolMenuItemLineAddBranch;

		private ToolStripMenuItem toolMenuItemLineAddPoint;

		private ToolStripSeparator toolStripSeparatorLineAddBranchPoint;

		private ToolStripMenuItem toolMenuItemLineDel;

		private ToolStripMenuItem toolMenuItemLineAddOutsideLineDisconnector;

		private ToolStripMenuItem toolMenuItemLineAddVacuumSwitch;

		private ToolStripMenuItem toolMenuItemLineAddTransformer;

		private ToolStripMenuItem toolMenuItemLineAddLoadSwitch;

		private ToolStripMenuItem toolMenuItemLineAddLinearDisconnector;

		private ToolStripMenuItem toolMenuItemLineAddLubricantDisconnector;

		private ToolStripSeparator toolStripSeparator6;

		private ToolStripMenuItem toolMenuItemAddLineText;

		private ToolStripSeparator toolStripSeparatorSetStatus;

		private ToolStripMenuItem toolMenuItemLineRecipientsPower;

		private ToolStripSeparator toolStripSeparator8;

		private ToolStripMenuItem toolMenuItemLinePropertyBranch;

		private ToolStripMenuItem toolMenuItemLineProperty;

		private ToolStripSeparator toolStripSeparatorEditLine;

		private ToolStripMenuItem toolMenuItemLineSetStatus;

		private ToolStripMenuItem toolMenuItemLineSetStatusGrounding;

		private ToolStripMenuItem toolMenuItemLineSetStatusBrakeDown;

		private ToolStripMenuItem toolMenuItemLineSetStatusOff;

		private ToolStripMenuItem toolMenuItemLineSetStatusNoPhased;

		private ToolStripMenuItem toolMenuItemLineDelObj;

		private ToolStripMenuItem toolMenuItemLineDelPoint;

		private ToolStripMenuItem toolMenuItemLineTextHere;

		private ToolStripSeparator toolStripSeparatorLineTextHere;

		private ToolStripSeparator toolStripSeparator10;

		private ToolStripMenuItem toolMenuItemRectFilter;

		private ToolStripMenuItem toolMenuItemRectFilterAdd;

		private ToolStripMenuItem toolMenuItemRectFilterDel;

		private ToolStripMenuItem toolMenuItemShinaFilter;

		private ToolStripMenuItem toolMenuItemShinaFilterAdd;

		private ToolStripMenuItem toolMenuItemShinaFilterDel;

		private ToolStripSeparator toolStripSeparator11;

		private ToolStripMenuItem toolMenuItemSwitchFilter;

		private ToolStripMenuItem toolMenuItemSwitchFilterAdd;

		private ToolStripMenuItem toolMenuItemSwitchFilterDel;

		private ToolStripSeparator toolStripSeparator12;

		private ToolStripMenuItem toolMenuItemLineFilter;

		private ToolStripMenuItem toolMenuItemLineFilterAdd;

		private ToolStripMenuItem toolMenuItemLineFilterDel;

		private ToolStripSeparator toolMenuItemLinePowerSource;

		private ToolStripMenuItem toolMenuItemLinePropertyPoint;

		private ToolStripMenuItem toolMenuItemStateDel;

		private ToolStripMenuItem toolStripMenuItem1;

		private ToolStripMenuItem toolStripMenuItem2;

		private ToolStripMenuItem toolStripMenuItem3;

		private ToolStripMenuItem toolStripMenuItem5;

		private ToolStripMenuItem toolStripMenuItem4;

		private ToolStripMenuItem toolStripMenuItem6;

		private ToolStripMenuItem toolStripMenuItem8;

		private ToolStripMenuItem toolStripMenuItem7;

		private ToolStripMenuItem toolStripMenuItem9;

		private ToolStripMenuItem toolMenuItemSwitchOn;

		private ToolStripTextBox toolTxtZoomChanged;

		private ToolStripMenuItem toolStripMenuItemBookmark;

		private ToolStripMenuItem toolStripMenuItemRemoveBookmark;

		private ToolStripMenuItem toolStripMenuItemAllPower;

		private ToolStripMenuItem toolStripMenuItem10;

		private ToolStripSeparator toolStripSeparator4;

		private ToolStripSeparator toolStripSeparator9;

		private ToolStripMenuItem toolMenuItemSelectedPowerBullshit;

		private ToolStripSeparator toolStripSeparator13;

		private ToolStripMenuItem toolMenuItemCopySelectedObjects;

		private ContextMenuStrip contextMenuCanvas;

		private ToolStripMenuItem toolMenuCanvasPaste;

		private ToolStripMenuItem toolMenuItemRectCopy;

		private ToolStripMenuItem toolMenuItemShinaCopy;

		private ToolStripMenuItem toolMenuItemSwitchCopy;

		private ToolStripMenuItem toolMenuItemLineCopy;

		private ToolStripMenuItem toolMenuItemLinePaste;

		private ToolStripMenuItem toolMenuItemPasteSelectedObjects;

		private ToolStripMenuItem toolMenuItemRectPaste;

		private ToolStripMenuItem toolMenuItemShinaPaste;

		private ToolStripMenuItem toolStripMenuItem11;

		private ToolStripMenuItem toolMenuItemLineAddFuseTool;

		private ToolStripMenuItem toolMenuItemLineAddDischargerTool;

		private ToolStripMenuItem toolMenuItemLineAddVoltageLimetedTool;

		private ToolStripMenuItem toolMenuItemLineAddVoltageTransformer;

		private ToolStripMenuItem toolStripMenuItemAdjacentSubstation;

		private ToolStripStatusLabel toolStripStatusLabelConnected;

		private ImageList imageList_0;

		private ToolStripMenuItem toolMenuItemAddNode;

		private ContextMenuStrip contextMenuLabelTool;

		private ToolStripMenuItem toolMenuItemLabelDel;

		private ToolStripMenuItem toolMenuItemLabelProperty;

		private ToolStripMenuItem toolMenuItemLineSetStatusArrow;

		private ToolStripMenuItem toolStripMenuItemAdjacentSubstation2;

		private ToolStripMenuItem toolStripMenuItemLineAlignBranch;

		private ToolStripMenuItem toolStripMenuItemAlignBranchByTop;

		private ToolStripMenuItem toolStripMenuItemAlignBranchByBottom;

		private ToolStripMenuItem toolStripMenuItemAlignBranchByRigth;

		private ToolStripMenuItem toolStripMenuItemAlignBranchByLeft;

		private ToolStripSeparator toolStripSeparator14;

		private ToolStripMenuItem toolMenuItemSelectedAlign;

		private ToolStripMenuItem toolMenuItemSelectedAlignByTop;

		private ToolStripMenuItem toolMenuItemSelectedAlignByBottom;

		private ToolStripMenuItem toolMenuItemSelectedAlignByRigth;

		private ToolStripMenuItem toolMenuItemSelectedAlignByLeft;

		private ToolStripMenuItem toolMenuItemSelectedAlignByHorCenter;

		private ToolStripMenuItem toolMenuItemSelectedAlignByVertCenter;

		private ToolStripMenuItem toolStripMenuItemAddWhitePoint;

		private ContextMenuStrip contextMenuStripWhitePoint;

		private ToolStripMenuItem toolStripMenuItemRemoveWhitePoint;

		private ToolStripMenuItem toolStripMenuItemRectanglePosition;

		private ToolStripMenuItem toolStripMenuItemReflect;

		private ToolStripMenuItem toolStripMenuItemRotateRectangle;

		private ToolStripMenuItem toolStripMenuItemRotate90;

		private ToolStripMenuItem toolStripMenuItemRotate180;

		private ToolStripMenuItem toolStripMenuItemRotate170;

		private ToolStripMenuItem toolStripMenuItemVReflect;

		private ToolStripMenuItem toolStripMenuItemHReflect;

		private ToolStripMenuItem toolStripMenuItem_0;

		private ToolStripMenuItem toolStripMenuItemDisconnectLine;

		private ToolStripMenuItem toolMenuItemLineAddEndTrim;

		private ToolStripMenuItem toolMenuItemLineAddGroundingTool;

		private ToolStripMenuItem toolMenuItemLineAddCircuitBreakerTool;

		private ToolStripMenuItem toolMeniItemShinaAddPattern;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn1;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn2;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn3;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn4;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn5;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn6;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn7;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn8;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn9;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbn10;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve1;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve2;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve3;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve4;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve5;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve6;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve7;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve8;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve9;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnReserve10;

		private PageSetupDialog pageSetupDialog_0;

		public PrintDialog printDialog;

		private ToolStripMenuItem toolStripMenuItemOOLDisplayGrLevel;

		private ToolStripMenuItem toolStripMenuItemDevideLine;

		private ToolStripMenuItem toolStripMenuItemGroupProperty;

		private ToolStripSeparator toolStripSeparatorGroup;

		private ToolStripMenuItem toolStripMenuItemGroupSelectedObject;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto1;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto2;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto3;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto4;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto5;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto6;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto7;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto8;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto9;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnAuto10;

		private ToolStripMenuItem toolMenuItemLineRelayProtection;

		private ToolStripMenuItem toolMenuItemLineAddRPS;

		private ToolStripMenuItem toolStripMenuItemAddAmperageTransformerTool;

		private ToolStripMenuItem toolMenuItemCopySelectedObjectsToImage;

		private ContextMenuStrip contextMenuFrame;

		private ToolStripMenuItem toolStripMenuFramePrint;

		private ToolStripMenuItem toolStripMenuFrameCopyToImage;

		private ToolStripMenuItem toolStripMenuFrameFitZoom;

		private ToolStripMenuItem toolMenuItemLineLogDispatcher;

		private ToolStripMenuItem toolMenuItemSwitchLogDispatcher;

		private ToolStripMenuItem toolMenuItemExportSelectedObjectsToDXF;

		private ToolStripMenuItem toolStripMenuFrameExportToImage;

		private ToolStripMenuItem toolMenuItemLineLinkPassport;

		private ToolStripMenuItem toolMenuItemLinePassport;

		private ToolStripMenuItem toolMenuItemSwitchPassport;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS1;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS2;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS3;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS4;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS5;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS6;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS7;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS8;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS9;

		private ToolStripMenuItem toolMenuItemShinaAddPatternAbnRPS10;

		private ToolStripMenuItem toolMenuItemLineAddLinearDisconnectorWaxwork;

		private ToolStripMenuItem toolMenuItemLineAddSeparatorTool;

		private ToolStripMenuItem toolStripMenuItemCSNormalMode;

		private ToolStripSeparator toolStripSeparatorCS;

		private ToolStripMenuItem toolStripMenuItemCSRollingOut;

		private ToolStripMenuItem toolStripMenuItemCSRepairMode;

		private ToolStripMenuItem toolStripMenuItemCSTestMode;

		private TextBox textBoxSearch;

		private Button button1;

		private ToolStripMenuItem toolStripMenuItemShinaGetOldAbn;

		private ToolStripMenuItem toolStripMenuItemShinaOldAbnCurrentRect;

		private ToolStripMenuItem toolStripMenuItemShinaOldAbnNextRect;

		private ToolStripMenuItem toolStripMenuItem12;

		private ToolStripMenuItem toolStripMenuItem13;

		private ToolStripMenuItem toolStripMenuItem14;

		private ToolStripMenuItem toolMenuItemRectFile;

		private ToolStripMenuItem toolMenuItemShinaFile;

		private ToolStripMenuItem toolMenuItemSwitchFile;

		private ToolStripMenuItem toolMenuItemLineFile;

		private ToolStripMenuItem toolMenuItemLineDeLinkPassport;

		private ToolStripMenuItem toolStripMenuItemAddFreeLabel;

		private ToolStripMenuItem toolStripMenuItemLineAddTelemertryLabel;

		private ToolStripMenuItem toolMenuItemLabelUpdate;

		private ToolStripMenuItem toolStripMenuItemAddTelemetryLabel2Level;

		private ToolStripMenuItem toolStripMenuItemSwitchAddTelemetry;

		private ToolStripMenuItem toolMenuItemLineAddLoadSwitchWaxwork;

		private ToolStripMenuItem ToolStripMenuItemSwitchMeasurement;

		private ContextMenuStrip contextMenuTextBranchTool;

		private ToolStripMenuItem toolStripMenuItem_1;

		private ToolStripMenuItem toolMenuItemTextBranchDel;

		private ToolStripMenuItem toolMenuItemTextBranchProperty;

		private ToolStripMenuItem toolStripMenuItemMeasurement;

		private ToolStripMenuItem toolStripMenuItemShinaAddTelemetryLabel;

		private ToolStripSeparator toolStripSeparator7;

		private ToolStripMenuItem toolStripMenuItemBusMeasurement;

		private ToolStripMenuItem toolStripMenuItemAddMagneticStarterTool;

		private ToolStripMenuItem toolStripMenuItemAddElectricMeter;

		private ToolStripMenuItem toolMenuItemSwitchErcloud;

		private ToolStripMenuItem toolMenuItemSwitchLinkErcloud;

		private ToolStripMenuItem toolMenuItemSwitchShowDataErcloud;

		public Dictionary<int, PointTool> loadedPoints = new Dictionary<int, PointTool>();

		private DataSetOPCConfig dataSetOPCConfig_0 = new DataSetOPCConfig();

		private OPCClient opcclient_0;

		private DrawObjectEventHandler drawObjectEventHandler_0;

		private DrawObjectEventHandler drawObjectEventHandler_1;

		private DrawObjectEventHandler drawObjectEventHandler_2;

		private DrawObjectEventHandler drawObjectEventHandler_3;

		private DrawObjectEventHandler drawObjectEventHandler_4;

		private DrawObjectEventHandler drawObjectEventHandler_5;

		private DrawObjectEventHandler drawObjectEventHandler_6;

		private DrawObjectEventHandler drawObjectEventHandler_7;

		private ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler_0;

		private ShowContextMenuCanvasEventHandler showContextMenuCanvasEventHandler_1;

		private DrawObjectEventHandler drawObjectEventHandler_8;

		private DrawObjectEventHandler drawObjectEventHandler_9;

		private EventHandler eventHandler_0;

		private CanvasMessageEventHandler canvasMessageEventHandler_0;

		private LineToolEventHandler lineToolEventHandler_0;

		private LineToolEventHandler lineToolEventHandler_1;

		private EventHandler eventHandler_1;

		private EventHandler eventHandler_2;

		private EventHandler eventHandler_3;

		private CanvasFrame canvasFrame_0;

		private int int_4 = -1;

		internal SchemeCtrl2.WCF.Proxy_Singleton ProxySingleton = SchemeCtrl2.WCF.Proxy_Singleton.GetInstance();

		internal Dictionary<int, GroupDrawObjectBase> dictionary_0 = new Dictionary<int, GroupDrawObjectBase>();

		private Graphics graphics_0;

		private BackgroundLayer backgroundLayer_0;

		private GridLayer gridLayer_0;

		private List<ICanvasLayer> list_0 = new List<ICanvasLayer>();

		private ICanvasLayer icanvasLayer_0;

		private float float_2 = 1f;

		private static Dictionary<string, DrawObjectBase> dictionary_1 = new Dictionary<string, DrawObjectBase>();

		private List<DrawObjectBase> list_1 = new List<DrawObjectBase>();

		private List<DrawObjectBase> list_2 = new List<DrawObjectBase>();

		private List<DrawObjectBase> list_3 = new List<DrawObjectBase>();

		private PointF pointF_0;

		private PointF pointF_1;

		private PointF pointF_2;

		private ISnapPoint isnapPoint_0;

		private bool bool_1 = true;

		private DrawObjectBase drawObjectBase_0;

		private UnitPoint unitPoint_0;

		private UnitPoint unitPoint_1;

		private eMetric eMetric_0 = eMetric.const_1;

		internal eCommandType eCommandType_0;

		private string string_3 = string.Empty;

		protected Bitmap staticImage;

		protected bool staticRepaint = true;

		private SelectionRectangle selectionRectangle_0;

		private Class95 class95_0 = new Class95();

		private DrawObjectBase drawObjectBase_1;

		private int int_5;

		private string string_4 = "schema1";

		private SQLSettings sqlsettings_0;

		public List<PointTool> globalPointsList = new List<PointTool>();

		private UnitPoint unitPoint_2;

		private CanvasSettings canvasSettings_0;

		private XmlDocument xmlDocument_0;

		private eTypeCanvas eTypeCanvas_0 = eTypeCanvas.SchemeMain;

		private eSimulationMode eSimulationMode_0 = eSimulationMode.Online;

		private int int_6;

		private eCanvasEditingMode eCanvasEditingMode_0 = eCanvasEditingMode.ReadOnly;

		private bool bool_2 = true;

		private Control0 control0_0;

		private bool bool_3;

		private RectangleF rectangleF_0 = RectangleF.Empty;

		private bool bool_4;

		public UndoRedoManager undoRedoManager;

		private List<LineToolState> list_4 = new List<LineToolState>();

		private List<DrawObjectBase> list_5 = new List<DrawObjectBase>();

		private List<List<DrawObjectBase>> list_6 = new List<List<DrawObjectBase>>();

		private int int_7;

		private List<DrawObjectBase> list_7 = new List<DrawObjectBase>();

		private EndpointAddress endPoint;

		private bool bool_5;

		private bool bool_6;

		private System.Windows.Forms.Timer timer_1 = new System.Windows.Forms.Timer();

		private eCanvasEditingMode eCanvasEditingMode_1 = eCanvasEditingMode.Edit;

		public bool ConvertColorFlash;

		private int int_8;

		private Point point_0;

		private Point point_1;

		private eMouseControlState eMouseControlState_0;

		private RectangleF rectangleF_1;

		private DrawingLayer drawingLayer_0;

		private PanelPassport panelPassport_0 = new PanelPassport();

		public System.Windows.Forms.Timer tFlash = new System.Windows.Forms.Timer();

		private SqlTransaction sqlTransaction_0;

		private bool bool_7;

		private List<int> list_8 = new List<int>();

		[CompilerGenerated]
		private WorkerCanvasPrint workerCanvasPrint_0;

		[CompilerGenerated]
		private string string_5;

		[CompilerGenerated]
		private string string_6;

		[CompilerGenerated]
		private int int_9;

		[CompilerGenerated]
		private bool bool_8;

		[CompilerGenerated]
		private bool bool_9;

		[CompilerGenerated]
		private bool bool_10;

		[CompilerGenerated]
		private bool bool_11;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_0;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_1;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_2;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_3;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_4;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_5;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_6;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_7;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_8;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_9;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_10;

		[CompilerGenerated]
		private static Func<PointTool, bool> func_11;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_12;

		[CompilerGenerated]
		private static Func<ObjectBaseServer, bool> func_13;

		[CompilerGenerated]
		private static Func<ObjectBaseServer, bool> func_14;

		[CompilerGenerated]
		private static Func<ObjectBaseServer, bool> func_15;

		[CompilerGenerated]
		private static Func<ObjectBaseServer, bool> func_16;

		[CompilerGenerated]
		private static Func<ObjectBaseServer, bool> func_17;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_18;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_19;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_20;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_21;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_22;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_23;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_24;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_25;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_26;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_27;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_28;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_29;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_30;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_31;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_32;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_33;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_34;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_35;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_36;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_37;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_38;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_39;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_40;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_41;

		[CompilerGenerated]
		private static Func<RectangleF, bool> func_42;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_43;

		[CompilerGenerated]
		private static Func<RectangleF, bool> func_44;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_45;

		[CompilerGenerated]
		private static Func<RectangleF, bool> func_46;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_47;

		[CompilerGenerated]
		private static Func<RectangleF, bool> func_48;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_49;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_50;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_51;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_52;

		[CompilerGenerated]
		private static Func<RectangleF, bool> func_53;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_54;

		[CompilerGenerated]
		private static Func<RectangleF, bool> func_55;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_56;

		[CompilerGenerated]
		private static Func<RectangleF, bool> func_57;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_58;

		[CompilerGenerated]
		private static Func<RectangleF, bool> func_59;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_60;

		[CompilerGenerated]
		private static Func<PointTool, bool> func_61;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_62;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_63;

		[CompilerGenerated]
		private static Func<RectangleF, bool> func_64;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_65;

		[CompilerGenerated]
		private static Func<RectangleF, bool> func_66;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_67;

		[CompilerGenerated]
		private static Func<RectangleF, bool> func_68;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_69;

		[CompilerGenerated]
		private static Func<RectangleF, bool> func_70;

		[CompilerGenerated]
		private static Func<RectangleF, float> func_71;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_72;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_73;

		[CompilerGenerated]
		private static Func<KeyValuePair<int, PointTool>, int> func_74;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_75;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_76;

		[CompilerGenerated]
		private static Comparison<DrawObjectBase> comparison_0;

		private delegate void Delegate0(bool bool_0);

		public delegate void AsyncAction();

		public delegate void DispatcherInvoker(CanvasControl.AsyncAction asyncAction_0);

		private delegate void Delegate1();

		public enum SetObjectsInCenterScreenOptions
		{
			none,
			select,
			flashing
		}

		[CompilerGenerated]
		private sealed class Class7
		{
			public bool method_0(DrawObjectBase drawObjectBase_1)
			{
				return drawObjectBase_1.IdBase == this.drawObjectBase_0.IdBase;
			}

			public DrawObjectBase drawObjectBase_0;
		}

		[CompilerGenerated]
		private sealed class Class8
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == this.int_0 || (drawObjectBase_0.Parent != null && drawObjectBase_0.Parent.IdBase == this.int_0);
			}

			public int int_0;
		}

		[CompilerGenerated]
		private sealed class Class9
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == Convert.ToInt32(this.dataRow_0["idParent"]);
			}

			public bool method_1(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == Convert.ToInt32(this.dataRow_0["idParent"]);
			}

			public CanvasControl.Class8 class8_0;

			public DataRow dataRow_0;
		}

		[CompilerGenerated]
		private sealed class Class10
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == Convert.ToInt32(this.dataRow_0["idParent"]);
			}

			public bool method_1(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == Convert.ToInt32(this.dataRow_0["idParent"]);
			}

			public CanvasControl.Class8 class8_0;

			public DataRow dataRow_0;
		}

		[CompilerGenerated]
		private sealed class Class11
		{
			public bool method_0(DataRow dataRow_1)
			{
				return Convert.ToInt32(dataRow_1["TypeSchema"]) == 2 && Convert.ToInt32(dataRow_1["Id"]) == Convert.ToInt32(this.dataRow_0["Id"]);
			}

			public bool method_1(DataRow dataRow_1)
			{
				return Convert.ToInt32(dataRow_1["TypeSchema"]) == 1 && Convert.ToInt32(dataRow_1["Id"]) == Convert.ToInt32(this.dataRow_0["Id"]);
			}

			public bool method_2(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == Convert.ToInt32(this.dataRow_0["IdParent"]);
			}

			public DataRow dataRow_0;
		}

		[CompilerGenerated]
		private sealed class Class12
		{
			public bool method_0(DataRow dataRow_1)
			{
				return Convert.ToInt32(dataRow_1["TypeSchema"]) == 2 && Convert.ToInt32(dataRow_1["Id"]) == Convert.ToInt32(this.dataRow_0["Id"]);
			}

			public bool method_1(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == Convert.ToInt32(this.dataRow_0["IdParent"]);
			}

			public bool method_2(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == Convert.ToInt32(this.dataRow_0["IdParent"]);
			}

			public DataRow dataRow_0;
		}

		[CompilerGenerated]
		private sealed class Class13
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == (int)this.dataRow_0["Id"];
			}

			public CanvasControl.Class12 class12_0;

			public DataRow dataRow_0;
		}

		[CompilerGenerated]
		private sealed class Class14
		{
			public bool method_0(DataRow dataRow_1)
			{
				return Convert.ToInt32(dataRow_1["TypeSchema"]) == 2 && Convert.ToInt32(dataRow_1["Id"]) == Convert.ToInt32(this.dataRow_0["Id"]);
			}

			public DataRow dataRow_0;
		}

		[CompilerGenerated]
		private sealed class Class15
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == (int)this.dataRow_0["Id"];
			}

			public CanvasControl.Class14 class14_0;

			public DataRow dataRow_0;
		}

		[CompilerGenerated]
		private sealed class Class16
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == Convert.ToInt32(this.dataRow_0["idParent"]);
			}

			public DataRow dataRow_0;
		}

		[CompilerGenerated]
		private sealed class Class17
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == Convert.ToInt32(this.dataRow_0["id"]);
			}

			public DataRow dataRow_0;
		}

		[CompilerGenerated]
		private sealed class Class18
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == this.objectBaseServer_0.ParentId;
			}

			public bool method_1(ObjectBaseServer objectBaseServer_1)
			{
				return objectBaseServer_1.ParentId == this.objectBaseServer_0.Id;
			}

			public ObjectBaseServer objectBaseServer_0;
		}

		[CompilerGenerated]
		private sealed class Class19
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == this.objectBaseServer_0.ParentId;
			}

			public ObjectBaseServer objectBaseServer_0;
		}

		[CompilerGenerated]
		private sealed class Class20
		{
			public bool method_0(CouplingRelation couplingRelation_0)
			{
				return couplingRelation_0.Id == this.branchServer_0.Relation;
			}

			public CanvasControl.Class19 class19_0;

			public BranchServer branchServer_0;
		}

		[CompilerGenerated]
		private sealed class Class21
		{
			public bool method_0(CouplingRelation couplingRelation_0)
			{
				return couplingRelation_0.Id == this.branchServer_0.Relation;
			}

			public BranchServer branchServer_0;
		}

		[CompilerGenerated]
		private sealed class Class22
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == this.opcmessage_0.ObjectId;
			}

			public bool method_1(DrawObjectBase drawObjectBase_0)
			{
				return ((TelemetryLabelTool)drawObjectBase_0).ObjectTelemetry == this.opcmessage_0.ObjectId && this.opcmessage_0.ParameterId == ((TelemetryLabelTool)drawObjectBase_0).TelemetryParameterId;
			}

			public OPCMessage opcmessage_0;
		}

		[CompilerGenerated]
		private sealed class Class23
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return ((TelemetryLabelTool)drawObjectBase_0).ObjectTelemetry == this.opcmessage_0.ObjectId && this.opcmessage_0.ParameterId == ((TelemetryLabelTool)drawObjectBase_0).TelemetryParameterId;
			}

			public OPCMessage opcmessage_0;
		}

		[CompilerGenerated]
		private sealed class Class24
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.PointInObject(this.unitPoint_0);
			}

			public UnitPoint unitPoint_0;
		}

		[CompilerGenerated]
		private sealed class Class25
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return !this.list_0.Contains(drawObjectBase_0);
			}

			public bool method_1(DrawObjectBase drawObjectBase_0)
			{
				return !this.list_3.Contains(drawObjectBase_0);
			}

			public bool method_2(DrawObjectBase drawObjectBase_0)
			{
				return !this.list_1.Contains(drawObjectBase_0);
			}

			public bool method_3(DrawObjectBase drawObjectBase_0)
			{
				return !this.list_2.Contains(drawObjectBase_0);
			}

			public List<DrawObjectBase> list_0;

			public List<DrawObjectBase> list_1;

			public List<DrawObjectBase> list_2;

			public List<DrawObjectBase> list_3;
		}

		[CompilerGenerated]
		private sealed class Class26
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == (int)this.dataRow_0[0];
			}

			public CanvasControl.Class25 class25_0;

			public DataRow dataRow_0;
		}

		[CompilerGenerated]
		private sealed class Class27
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == (int)this.dataRow_0[0];
			}

			public CanvasControl.Class25 class25_0;

			public DataRow dataRow_0;
		}

		[CompilerGenerated]
		private sealed class Class28
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == this.int_0;
			}

			public int int_0;
		}

		[CompilerGenerated]
		private sealed class Class29
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return this.list_0.Contains(drawObjectBase_0.IdBase);
			}

			public List<int> list_0;
		}

		[CompilerGenerated]
		private sealed class Class30
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0 != this.canvasControl_0.drawObjectBase_0 && drawObjectBase_0.Visible && drawObjectBase_0.PointInObject(this.unitPoint_0);
			}

			public CanvasControl canvasControl_0;

			public UnitPoint unitPoint_0;
		}

		[CompilerGenerated]
		private sealed class Class31
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.ObjectInRectangle(this.canvasControl_0, this.rectangleF_0, this.bool_0);
			}

			public CanvasControl canvasControl_0;

			public RectangleF rectangleF_0;

			public bool bool_0;
		}

		[CompilerGenerated]
		private sealed class Class32
		{
			public bool method_0(DrawObjectBase drawObjectBase_1)
			{
				return drawObjectBase_1.Parent == this.drawObjectBase_0.Parent;
			}

			public DrawObjectBase drawObjectBase_0;
		}

		[CompilerGenerated]
		private sealed class Class33
		{
			public bool method_0(CouplingRelation couplingRelation_0)
			{
				return !this.list_0.Contains(couplingRelation_0.Line);
			}

			public List<LineTool> list_0;
		}

		[CompilerGenerated]
		private sealed class Class34
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0 != null && drawObjectBase_0.ObjectInRectangle(this.canvasControl_0, this.rectangleF_0, true);
			}

			public RectangleF rectangleF_0;

			public CanvasControl canvasControl_0;
		}

		[CompilerGenerated]
		private sealed class Class35
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.IdBase == this.int_0;
			}

			public int int_0;
		}

		[CompilerGenerated]
		private sealed class Class36
		{
			public bool method_0(DrawObjectBase drawObjectBase_1)
			{
				return drawObjectBase_1.IdBase == this.drawObjectBase_0.IdBase;
			}

			public bool method_1(DrawObjectBase drawObjectBase_1)
			{
				return drawObjectBase_1.IdBase == this.drawObjectBase_0.IdBase;
			}

			public bool method_2(DrawObjectBase drawObjectBase_1)
			{
				return !this.list_0.Contains(drawObjectBase_1);
			}

			public bool method_3(DrawObjectBase drawObjectBase_1)
			{
				return !this.list_0.Contains(drawObjectBase_1);
			}

			public List<DrawObjectBase> list_0;

			public DrawObjectBase drawObjectBase_0;
		}

		[CompilerGenerated]
		private sealed class Class37
		{
			public bool method_0(PointTool pointTool_0)
			{
				return pointTool_0.IdBase == this.couplingRelation_0.Vertex1.IdBase;
			}

			public bool method_1(PointTool pointTool_0)
			{
				return pointTool_0.IdBase == this.couplingRelation_0.Vertex2.IdBase;
			}

			public CanvasControl.Class36 class36_0;

			public CouplingRelation couplingRelation_0;
		}

		[CompilerGenerated]
		private sealed class Class38
		{
			public bool method_0(PointTool pointTool_0)
			{
				return pointTool_0.IdBase == this.branch_0.Source.IdBase;
			}

			public bool method_1(PointTool pointTool_0)
			{
				return pointTool_0.IdBase == this.branch_0.Destination.IdBase;
			}

			public CanvasControl.Class36 class36_0;

			public Branch branch_0;
		}

		[CompilerGenerated]
		private sealed class Class39
		{
			public bool method_0(PointTool pointTool_1)
			{
				return pointTool_1.IdBase == this.pointTool_0.IdBase;
			}

			public CanvasControl.Class36 class36_0;

			public PointTool pointTool_0;
		}

		[CompilerGenerated]
		private sealed class Class40
		{
			public bool method_0(PointTool pointTool_0)
			{
				return pointTool_0.IdBase == this.couplingRelation_0.Vertex1.IdBase;
			}

			public bool method_1(PointTool pointTool_0)
			{
				return pointTool_0.IdBase == this.couplingRelation_0.Vertex2.IdBase;
			}

			public CanvasControl.Class36 class36_0;

			public CouplingRelation couplingRelation_0;
		}

		[CompilerGenerated]
		private sealed class Class41
		{
			public bool method_0(PointTool pointTool_0)
			{
				return pointTool_0.IdBase == this.branch_0.Source.IdBase;
			}

			public bool method_1(PointTool pointTool_0)
			{
				return pointTool_0.IdBase == this.branch_0.Destination.IdBase;
			}

			public CanvasControl.Class36 class36_0;

			public Branch branch_0;
		}

		[CompilerGenerated]
		private sealed class Class42
		{
			public bool method_0(DrawObjectBase drawObjectBase_0)
			{
				return drawObjectBase_0.GetType() == typeof(MeasurementLabelTool) && drawObjectBase_0.Parent != null && drawObjectBase_0.Parent.GetType() == typeof(ShinaTool) && drawObjectBase_0.Parent.IdBase == this.int_0;
			}

			public int int_0;
		}

		[CompilerGenerated]
		private sealed class Class43
		{
			public bool method_0(Branch branch_0)
			{
				return branch_0.Parent == this.lineTool_0;
			}

			public LineTool lineTool_0;
		}
	}
}
