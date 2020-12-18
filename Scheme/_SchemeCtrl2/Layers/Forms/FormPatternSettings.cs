using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DataSql;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.Layers.Forms
{
	public partial class FormPatternSettings : Form
	{
		public FormPatternSettings(PatternTP layer, SQLSettings sqlSet)
		{
			this.InitializeComponent();
			this.canvasPattern.UseObjectFromDB = false;
			this.sqlsettings_0 = sqlSet;
			this.patternTP_0 = layer;
			this.canvasPattern.ClearLayers();
			this.canvasPattern.AddLayer(this.patternTP_0);
			this.canvasPattern.SetObjectsInCenterScreen(this.patternTP_0.Objects.ToList<DrawObjectBase>(), true, CanvasControl.SetObjectsInCenterScreenOptions.select);
		}

		private void FormPatternSettings_Load(object sender, EventArgs e)
		{
			this.method_0();
			IEnumerable<DrawObjectBase> objects = this.canvasPattern.Layers.First<ICanvasLayer>().Objects;
			if (FormPatternSettings.func_0 == null)
			{
				FormPatternSettings.func_0 = new Func<DrawObjectBase, bool>(FormPatternSettings.smethod_0);
			}
			RectangleTool rectangleTool = (RectangleTool)objects.Single(FormPatternSettings.func_0);
			if (rectangleTool == null)
			{
				throw new Exception("Pattern Error");
			}
			this.method_1(rectangleTool);
			this.method_2(rectangleTool.Rectangle);
		}

		private void FormPatternSettings_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.Cancel)
			{
				this.patternTP_0.Clear(false);
			}
			DialogResult dialogResult = base.DialogResult;
		}

		private void method_0()
		{
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			sqlDataCommand.SelectSqlData(this.dataSet_0, "tr_classifier", true, " where (parentKey  = ';SCM;PS;' or parentKey like ';SCM;BUS;%'  or parentKey = ';SCM;INLINE_OBJ;SWITCH;' ) and isgroup = 0 and deleted = 0");
			this.cmbTypeSubstation.SelectedValue = 538;
			this.cmbTypeShins.SelectedValue = 564;
		}

		private void method_1(RectangleTool rectangleTool_0)
		{
			rectangleTool_0.Selected = false;
			rectangleTool_0.Normalize();
			this.radioButtonLT.Tag = ePositionText.LT;
			this.radioButtonT.Tag = ePositionText.T;
			this.radioButtonRT.Tag = ePositionText.RT;
			this.radioButtonR.Tag = ePositionText.R;
			this.radioButtonRB.Tag = ePositionText.RB;
			this.radioButtonB.Tag = ePositionText.B;
			this.radioButtonLB.Tag = ePositionText.LB;
			this.radioButtonL.Tag = ePositionText.L;
			this.cmbTypeSubstation.SelectedValue = (int)rectangleTool_0.TypeRectnagleTool;
			this.txtNameSubstation.Text = rectangleTool_0.Text;
			if (rectangleTool_0.TextProperty.Visible)
			{
				switch (rectangleTool_0.TextProperty.Position)
				{
				case ePositionText.LT:
					this.radioButtonLT.Checked = true;
					break;
				case ePositionText.T:
					this.radioButtonT.Checked = true;
					break;
				case ePositionText.RT:
					this.radioButtonRT.Checked = true;
					break;
				case ePositionText.R:
					this.radioButtonR.Checked = true;
					break;
				case ePositionText.RB:
					this.radioButtonRB.Checked = true;
					break;
				case ePositionText.B:
					this.radioButtonB.Checked = true;
					break;
				case ePositionText.LB:
					this.radioButtonLB.Checked = true;
					break;
				case ePositionText.L:
					this.radioButtonL.Checked = true;
					break;
				}
			}
			else
			{
				this.radioButtonNotVisible.Checked = true;
			}
			if (rectangleTool_0.TextProperty.FontVirtical)
			{
				this.radioButtonVertical.Checked = true;
			}
		}

		private void cmbTypeSubstation_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.canvasPattern.Layers.Count<ICanvasLayer>() == 0)
			{
				return;
			}
			if (this.cmbTypeSubstation.SelectedValue == null)
			{
				return;
			}
			IEnumerable<DrawObjectBase> objects = this.canvasPattern.Layers.First<ICanvasLayer>().Objects;
			if (FormPatternSettings.func_1 == null)
			{
				FormPatternSettings.func_1 = new Func<DrawObjectBase, bool>(FormPatternSettings.smethod_1);
			}
			DrawObjectBase drawObjectBase = objects.Single(FormPatternSettings.func_1);
			((RectangleTool)drawObjectBase).TypeRectnagleTool = (eTypeRectangleTool)this.cmbTypeSubstation.SelectedValue;
			this.canvasPattern.DoInvalidate(true);
		}

		private void txtNameSubstation_TextChanged(object sender, EventArgs e)
		{
			IEnumerable<DrawObjectBase> objects = this.canvasPattern.Layers.First<ICanvasLayer>().Objects;
			if (FormPatternSettings.func_2 == null)
			{
				FormPatternSettings.func_2 = new Func<DrawObjectBase, bool>(FormPatternSettings.smethod_2);
			}
			DrawObjectBase drawObjectBase = objects.Single(FormPatternSettings.func_2);
			drawObjectBase.Text = this.txtNameSubstation.Text;
			this.canvasPattern.DoInvalidate(true);
		}

		private void radioButtonRT_CheckedChanged(object sender, EventArgs e)
		{
			IEnumerable<DrawObjectBase> objects = this.canvasPattern.Layers.First<ICanvasLayer>().Objects;
			if (FormPatternSettings.func_3 == null)
			{
				FormPatternSettings.func_3 = new Func<DrawObjectBase, bool>(FormPatternSettings.smethod_3);
			}
			DrawObjectBase drawObjectBase = objects.Single(FormPatternSettings.func_3);
			drawObjectBase.TextProperty.Visible = true;
			drawObjectBase.TextProperty.Position = (ePositionText)((RadioButton)sender).Tag;
			this.canvasPattern.DoInvalidate(true);
		}

		private void radioButtonNotVisible_CheckedChanged(object sender, EventArgs e)
		{
			IEnumerable<DrawObjectBase> objects = this.canvasPattern.Layers.First<ICanvasLayer>().Objects;
			if (FormPatternSettings.func_4 == null)
			{
				FormPatternSettings.func_4 = new Func<DrawObjectBase, bool>(FormPatternSettings.smethod_4);
			}
			DrawObjectBase drawObjectBase = objects.Single(FormPatternSettings.func_4);
			drawObjectBase.TextProperty.Visible = false;
			this.canvasPattern.DoInvalidate(true);
		}

		private void radioButtonGorizontal_CheckedChanged(object sender, EventArgs e)
		{
			IEnumerable<DrawObjectBase> objects = this.canvasPattern.Layers.First<ICanvasLayer>().Objects;
			if (FormPatternSettings.func_5 == null)
			{
				FormPatternSettings.func_5 = new Func<DrawObjectBase, bool>(FormPatternSettings.smethod_5);
			}
			DrawObjectBase drawObjectBase = objects.Single(FormPatternSettings.func_5);
			if (this.radioButtonGorizontal.Checked)
			{
				drawObjectBase.TextProperty.FontVirtical = false;
			}
			else
			{
				drawObjectBase.TextProperty.FontVirtical = true;
			}
			this.canvasPattern.DoInvalidate(true);
		}

		private void numericUpDownCountShins_ValueChanged(object sender, EventArgs e)
		{
			this.groupBoxOrientCells.Enabled = (this.numericUpDownCountShins.Value <= 3m);
			this.method_3((int)this.numericUpDownCountShins.Value, this.radioButtonVericalShins.Checked);
			this.method_4((int)this.numericUpDownCountCells.Value);
			this.canvasPattern.DoInvalidate(true);
		}

		private void radioButtonGorizontalShins_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioButtonGorizontalShins.Checked)
			{
				this.radioButtonCellsTop.Text = "Сверху";
				this.radioButtonCellsBottom.Text = "Снизу";
			}
			else
			{
				this.radioButtonCellsTop.Text = "Справа";
				this.radioButtonCellsBottom.Text = "Слева";
			}
			this.method_3((int)this.numericUpDownCountShins.Value, this.radioButtonVericalShins.Checked);
			this.method_4((int)this.numericUpDownCountCells.Value);
			this.canvasPattern.DoInvalidate(true);
		}

		private void numericUpDownDistanceShins_ValueChanged(object sender, EventArgs e)
		{
			this.method_3((int)this.numericUpDownCountShins.Value, this.radioButtonVericalShins.Checked);
			this.method_4((int)this.numericUpDownCountCells.Value);
			this.canvasPattern.DoInvalidate(true);
		}

		private void cmbTypeShins_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach (ICanvasLayer canvasLayer in this.canvasPattern.Layers)
			{
				foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
				{
					if (drawObjectBase.GetType() == typeof(ShinaTool))
					{
						((ShinaTool)drawObjectBase).TypeShinaTool = (eTypeShinaTool)((int)this.cmbTypeShins.SelectedValue);
					}
				}
			}
		}

		private void checkBoxVisibleTextShins_CheckedChanged(object sender, EventArgs e)
		{
			foreach (ICanvasLayer canvasLayer in this.canvasPattern.Layers)
			{
				foreach (DrawObjectBase drawObjectBase in canvasLayer.Objects)
				{
					if (drawObjectBase.GetType() == typeof(ShinaTool))
					{
						((ShinaTool)drawObjectBase).TextProperty.Visible = this.checkBoxVisibleTextShins.Checked;
						if (this.radioButtonGorizontalShins.Checked)
						{
							drawObjectBase.TextProperty.Position = ePositionText.L;
						}
						else
						{
							drawObjectBase.TextProperty.Position = ePositionText.T;
						}
					}
				}
			}
			this.canvasPattern.DoInvalidate(true);
		}

		private void method_2(RectangleF rectangleF_0)
		{
			float num = this.radioButtonGorizontalShins.Checked ? rectangleF_0.Width : rectangleF_0.Height;
			if (num < 1f)
			{
				this.float_0 = 0.1f;
				if (num < 0.3f)
				{
					this.float_0 = 0f;
				}
			}
			decimal value = (this.numericUpDownCountShins.Value > 3m) ? Math.Ceiling(this.numericUpDownCountShins.Value / 2m) : ((this.numericUpDownCountShins.Value == 0m) ? 1m : this.numericUpDownCountShins.Value);
			this.numericUpDownDistanceShins.Maximum = (decimal)((num - 2f * this.float_0) / (float)value) - 0.1m;
		}

		private void method_3(int countShins, bool vertical)
		{
			DrawingLayer drawingLayer = (DrawingLayer)this.canvasPattern.Layers.First<ICanvasLayer>();
			IEnumerable<DrawObjectBase> objects = drawingLayer.Objects;
			if (FormPatternSettings.func_6 == null)
			{
				FormPatternSettings.func_6 = new Func<DrawObjectBase, bool>(FormPatternSettings.smethod_6);
			}
			List<DrawObjectBase> list = objects.Where(FormPatternSettings.func_6).ToList<DrawObjectBase>();
			while (list.Count > 0)
			{
				list[0].Remove(false, true);
				list.Remove(list[0]);
			}
			IEnumerable<DrawObjectBase> objects2 = this.canvasPattern.Layers.First<ICanvasLayer>().Objects;
			if (FormPatternSettings.func_7 == null)
			{
				FormPatternSettings.func_7 = new Func<DrawObjectBase, bool>(FormPatternSettings.smethod_7);
			}
			RectangleTool rectangleTool = (RectangleTool)objects2.Single(FormPatternSettings.func_7);
			this.method_2(rectangleTool.Rectangle);
			if (countShins == 0)
			{
				return;
			}
			int num = 1;
			float num2 = (float)this.numericUpDownDistanceShins.Value;
			if (vertical)
			{
				if (countShins <= 3)
				{
					float num3 = rectangleTool.Rectangle.X + rectangleTool.Rectangle.Width / 2f;
					float num4 = rectangleTool.Rectangle.Y + this.float_0;
					float num5 = (rectangleTool.Rectangle.Height - 2f * this.float_0 + num2) / (float)countShins - num2;
					for (int i = 0; i < countShins; i++)
					{
						ShinaTool shinaTool = new ShinaTool();
						shinaTool.Text = num++.ToString();
						shinaTool.TypeShinaTool = (eTypeShinaTool)((int)this.cmbTypeShins.SelectedValue);
						shinaTool.Parent = rectangleTool;
						shinaTool.TextProperty.Visible = this.checkBoxVisibleTextShins.Checked;
						shinaTool.TextProperty.Position = ePositionText.T;
						shinaTool.P1 = new UnitPoint((double)num3, (double)(num4 + (num5 + num2) * (float)i));
						shinaTool.P2 = new UnitPoint((double)num3, (double)(num4 + (num5 + num2) * (float)i + num5));
						this.canvasPattern.AddObject(drawingLayer, shinaTool);
					}
					return;
				}
				int num6 = countShins / 2;
				int num7 = countShins - countShins / 2;
				float num8 = rectangleTool.Rectangle.X + rectangleTool.Rectangle.Width / 3f;
				float num9 = rectangleTool.Rectangle.Y + this.float_0;
				float num10 = (rectangleTool.Rectangle.Height - 2f * this.float_0 + num2) / (float)num6 - num2;
				for (int j = 0; j < num6; j++)
				{
					ShinaTool shinaTool2 = new ShinaTool();
					shinaTool2.Text = num++.ToString();
					shinaTool2.TypeShinaTool = (eTypeShinaTool)((int)this.cmbTypeShins.SelectedValue);
					shinaTool2.Parent = rectangleTool;
					shinaTool2.TextProperty.Visible = this.checkBoxVisibleTextShins.Checked;
					shinaTool2.TextProperty.Position = ePositionText.T;
					shinaTool2.P1 = new UnitPoint((double)num8, (double)(num9 + (num10 + num2) * (float)j));
					shinaTool2.P2 = new UnitPoint((double)num8, (double)(num9 + (num10 + num2) * (float)j + num10));
					this.canvasPattern.AddObject(drawingLayer, shinaTool2);
				}
				num8 = rectangleTool.Rectangle.X + 2f * (rectangleTool.Rectangle.Width / 3f);
				num10 = (rectangleTool.Rectangle.Height - 2f * this.float_0 + num2) / (float)num7 - num2;
				for (int k = 0; k < num7; k++)
				{
					ShinaTool shinaTool3 = new ShinaTool();
					shinaTool3.Text = num++.ToString();
					shinaTool3.TypeShinaTool = (eTypeShinaTool)((int)this.cmbTypeShins.SelectedValue);
					shinaTool3.Parent = rectangleTool;
					shinaTool3.TextProperty.Visible = this.checkBoxVisibleTextShins.Checked;
					shinaTool3.TextProperty.Position = ePositionText.T;
					shinaTool3.P1 = new UnitPoint((double)num8, (double)(num9 + (num10 + num2) * (float)k));
					shinaTool3.P2 = new UnitPoint((double)num8, (double)(num9 + (num10 + num2) * (float)k + num10));
					this.canvasPattern.AddObject(drawingLayer, shinaTool3);
				}
				return;
			}
			else
			{
				if (countShins <= 3)
				{
					float num11 = rectangleTool.Rectangle.X + this.float_0;
					float num12 = rectangleTool.Rectangle.Y + rectangleTool.Rectangle.Height / 2f;
					float num13 = (rectangleTool.Rectangle.Width - 2f * this.float_0 + num2) / (float)countShins - num2;
					for (int l = 0; l < countShins; l++)
					{
						ShinaTool shinaTool4 = new ShinaTool();
						shinaTool4.Text = num++.ToString();
						shinaTool4.TypeShinaTool = (eTypeShinaTool)((int)this.cmbTypeShins.SelectedValue);
						shinaTool4.Parent = rectangleTool;
						shinaTool4.TextProperty.Visible = this.checkBoxVisibleTextShins.Checked;
						shinaTool4.TextProperty.Position = ePositionText.L;
						shinaTool4.P1 = new UnitPoint((double)(num11 + (num13 + num2) * (float)l), (double)num12);
						shinaTool4.P2 = new UnitPoint((double)(num11 + (num13 + num2) * (float)l + num13), (double)num12);
						this.canvasPattern.AddObject(drawingLayer, shinaTool4);
					}
					return;
				}
				int num14 = countShins / 2;
				int num15 = countShins - countShins / 2;
				float num16 = rectangleTool.Rectangle.X + this.float_0;
				float num17 = rectangleTool.Rectangle.Y + rectangleTool.Rectangle.Height / 3f;
				float num18 = (rectangleTool.Rectangle.Width - 2f * this.float_0 + num2) / (float)num14 - num2;
				for (int m = 0; m < num14; m++)
				{
					ShinaTool shinaTool5 = new ShinaTool();
					shinaTool5.Text = num++.ToString();
					shinaTool5.TypeShinaTool = (eTypeShinaTool)((int)this.cmbTypeShins.SelectedValue);
					shinaTool5.Parent = rectangleTool;
					shinaTool5.TextProperty.Visible = this.checkBoxVisibleTextShins.Checked;
					shinaTool5.TextProperty.Position = ePositionText.L;
					shinaTool5.P1 = new UnitPoint((double)(num16 + (num18 + num2) * (float)m), (double)num17);
					shinaTool5.P2 = new UnitPoint((double)(num16 + (num18 + num2) * (float)m + num18), (double)num17);
					this.canvasPattern.AddObject(drawingLayer, shinaTool5);
				}
				num17 = rectangleTool.Rectangle.Y + 2f * (rectangleTool.Rectangle.Height / 3f);
				num18 = (rectangleTool.Rectangle.Width - 2f * this.float_0 + num2) / (float)num15 - num2;
				for (int n = 0; n < num15; n++)
				{
					ShinaTool shinaTool6 = new ShinaTool();
					shinaTool6.Text = num++.ToString();
					shinaTool6.TypeShinaTool = (eTypeShinaTool)((int)this.cmbTypeShins.SelectedValue);
					shinaTool6.Parent = rectangleTool;
					shinaTool6.TextProperty.Visible = this.checkBoxVisibleTextShins.Checked;
					shinaTool6.TextProperty.Position = ePositionText.L;
					shinaTool6.P1 = new UnitPoint((double)(num16 + (num18 + num2) * (float)n), (double)num17);
					shinaTool6.P2 = new UnitPoint((double)(num16 + (num18 + num2) * (float)n + num18), (double)num17);
					this.canvasPattern.AddObject(drawingLayer, shinaTool6);
				}
				return;
			}
		}

		private void canvasPattern_Resize(object sender, EventArgs e)
		{
			if (this.canvasPattern.Layers.Count<ICanvasLayer>() > 0 && this.canvasPattern.Layers.First<ICanvasLayer>().ObjectsCount > 0)
			{
				this.canvasPattern.SetObjectsInCenterScreen(this.canvasPattern.Layers.First<ICanvasLayer>().Objects.ToList<DrawObjectBase>(), true, CanvasControl.SetObjectsInCenterScreenOptions.select);
				this.canvasPattern.ClearSelectedObjects();
			}
		}

		private void numericUpDownCountCells_ValueChanged(object sender, EventArgs e)
		{
			this.method_4((int)this.numericUpDownCountCells.Value);
			this.canvasPattern.DoInvalidate(true);
		}

		private void radioButtonCellsTop_CheckedChanged(object sender, EventArgs e)
		{
			this.method_4((int)this.numericUpDownCountCells.Value);
			this.canvasPattern.DoInvalidate(true);
		}

		private void method_4(int int_0)
		{
			DrawingLayer drawingLayer = (DrawingLayer)this.canvasPattern.Layers.First<ICanvasLayer>();
			IEnumerable<DrawObjectBase> objects = drawingLayer.Objects;
			if (FormPatternSettings.func_8 == null)
			{
				FormPatternSettings.func_8 = new Func<DrawObjectBase, bool>(FormPatternSettings.smethod_8);
			}
			List<DrawObjectBase> list = objects.Where(FormPatternSettings.func_8).ToList<DrawObjectBase>();
			while (list.Count > 0)
			{
				list[0].Remove(false, true);
				list.Remove(list[0]);
			}
			if (int_0 == 0)
			{
				return;
			}
			IEnumerable<DrawObjectBase> objects2 = this.canvasPattern.Layers.First<ICanvasLayer>().Objects;
			if (FormPatternSettings.func_9 == null)
			{
				FormPatternSettings.func_9 = new Func<DrawObjectBase, bool>(FormPatternSettings.smethod_9);
			}
			RectangleTool rectangleTool = (RectangleTool)objects2.Single(FormPatternSettings.func_9);
			int num = 1;
			IEnumerable<DrawObjectBase> objects3 = drawingLayer.Objects;
			if (FormPatternSettings.func_10 == null)
			{
				FormPatternSettings.func_10 = new Func<DrawObjectBase, bool>(FormPatternSettings.smethod_10);
			}
			List<DrawObjectBase> list2 = objects3.Where(FormPatternSettings.func_10).ToList<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in list2)
			{
				ShinaTool shinaTool = (ShinaTool)drawObjectBase;
				bool flag = shinaTool.P1.Y == shinaTool.P2.Y;
				bool flag2 = (double)rectangleTool.Rectangle.Bottom - shinaTool.P1.Y <= shinaTool.P1.Y - (double)rectangleTool.Rectangle.Top;
				bool flag3 = (double)rectangleTool.Rectangle.Right - shinaTool.P1.X <= shinaTool.P1.X - (double)rectangleTool.Rectangle.Left;
				this.method_5(shinaTool, int_0);
				foreach (DrawObjectBase drawObjectBase2 in shinaTool.ChildObjects)
				{
					if (drawObjectBase2.GetType() == typeof(PointShinaTool))
					{
						PointShinaTool pointShinaTool = (PointShinaTool)drawObjectBase2;
						LineCellTool lineCellTool = new LineCellTool();
						lineCellTool.Parent = rectangleTool;
						lineCellTool.Text = num++.ToString();
						if (list2.Count <= 3)
						{
							if (this.radioButtonCellsTop.Checked)
							{
								if (flag)
								{
									lineCellTool.AddBranch(pointShinaTool, new PointTool(new UnitPoint(pointShinaTool.Point.X, (double)rectangleTool.Rectangle.Bottom)));
								}
								else
								{
									lineCellTool.AddBranch(pointShinaTool, new PointTool(new UnitPoint((double)rectangleTool.Rectangle.Right, pointShinaTool.Point.Y)));
								}
							}
							else if (flag)
							{
								lineCellTool.AddBranch(pointShinaTool, new PointTool(new UnitPoint(pointShinaTool.Point.X, (double)rectangleTool.Rectangle.Top)));
							}
							else
							{
								lineCellTool.AddBranch(pointShinaTool, new PointTool(new UnitPoint((double)rectangleTool.Rectangle.Left, pointShinaTool.Point.Y)));
							}
						}
						else if (flag)
						{
							if (flag2)
							{
								lineCellTool.AddBranch(pointShinaTool, new PointTool(new UnitPoint(pointShinaTool.Point.X, (double)rectangleTool.Rectangle.Bottom)));
							}
							else
							{
								lineCellTool.AddBranch(pointShinaTool, new PointTool(new UnitPoint(pointShinaTool.Point.X, (double)rectangleTool.Rectangle.Top)));
							}
						}
						else if (flag3)
						{
							lineCellTool.AddBranch(pointShinaTool, new PointTool(new UnitPoint((double)rectangleTool.Rectangle.Right, pointShinaTool.Point.Y)));
						}
						else
						{
							lineCellTool.AddBranch(pointShinaTool, new PointTool(new UnitPoint((double)rectangleTool.Rectangle.Left, pointShinaTool.Point.Y)));
						}
						this.canvasPattern.AddObject(drawingLayer, lineCellTool);
					}
				}
			}
			this.method_7();
		}

		private void method_5(ShinaTool shinaTool_0, int int_0)
		{
			List<PointShinaTool> list = new List<PointShinaTool>();
			using (IEnumerator<DrawObjectBase> enumerator = shinaTool_0.ChildObjects.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					DrawObjectBase drawObjectBase = enumerator.Current;
					if (drawObjectBase.GetType() == typeof(PointShinaTool))
					{
						list.Add((PointShinaTool)drawObjectBase);
					}
				}
				goto IL_6E;
			}
			IL_53:
			shinaTool_0.RemoveCell(list[0]);
			list.Remove(list[0]);
			IL_6E:
			if (list.Count > 0)
			{
				goto IL_53;
			}
			if (shinaTool_0.P1.X == shinaTool_0.P2.X)
			{
				double num = Math.Min(shinaTool_0.P1.Y, shinaTool_0.P2.Y);
				double num2 = Math.Max(shinaTool_0.P1.Y, shinaTool_0.P2.Y);
				for (int i = 0; i < int_0; i++)
				{
					double double_ = num + (num2 - num) * (double)(i + 1) / (double)(int_0 + 1);
					shinaTool_0.AddPointShinaTool(new UnitPoint(shinaTool_0.P1.X, double_));
				}
				return;
			}
			double num3 = Math.Min(shinaTool_0.P1.X, shinaTool_0.P2.X);
			double num4 = Math.Max(shinaTool_0.P1.X, shinaTool_0.P2.X);
			for (int j = 0; j < int_0; j++)
			{
				double double_2 = num3 + (num4 - num3) * (double)(j + 1) / (double)(int_0 + 1);
				shinaTool_0.AddPointShinaTool(new UnitPoint(double_2, shinaTool_0.P1.Y));
			}
		}

		private void dgvSwitchs_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			this.method_7();
			this.canvasPattern.DoInvalidate(true);
		}

		private void dgvSwitchs_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			this.method_7();
			this.canvasPattern.DoInvalidate(true);
		}

		private void dgvSwitchs_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (this.dgvSwitchs.IsCurrentCellDirty)
			{
				this.dgvSwitchs.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void dgvSwitchs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			this.method_7();
			this.canvasPattern.DoInvalidate(true);
		}

		private void dgvSwitchs_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			e.Control.KeyDown -= this.method_6;
			e.Control.KeyDown += this.method_6;
		}

		private void method_6(object sender, KeyEventArgs e)
		{
			if ((Control.ModifierKeys == Keys.None || Control.ModifierKeys == Keys.Control) && e.KeyCode == Keys.Delete && this.dgvSwitchs.CurrentRow != null && !this.dgvSwitchs.CurrentRow.IsNewRow)
			{
				this.dgvSwitchs.Rows.Remove(this.dgvSwitchs.CurrentRow);
				this.dgvSwitchs.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void method_7()
		{
			if (this.canvasPattern.Layers.Count<ICanvasLayer>() == 0)
			{
				return;
			}
			DrawingLayer drawingLayer = (DrawingLayer)this.canvasPattern.Layers.First<ICanvasLayer>();
			IEnumerable<DrawObjectBase> objects = drawingLayer.Objects;
			if (FormPatternSettings.func_11 == null)
			{
				FormPatternSettings.func_11 = new Func<DrawObjectBase, bool>(FormPatternSettings.smethod_11);
			}
			List<DrawObjectBase> list = objects.Where(FormPatternSettings.func_11).ToList<DrawObjectBase>();
			while (list.Count > 0)
			{
				list[0].Remove(false, false);
				drawingLayer.RemoveObject(list[0]);
				list.Remove(list[0]);
			}
			IEnumerable<DrawObjectBase> objects2 = drawingLayer.Objects;
			if (FormPatternSettings.func_12 == null)
			{
				FormPatternSettings.func_12 = new Func<DrawObjectBase, bool>(FormPatternSettings.smethod_12);
			}
			List<DrawObjectBase> list2 = objects2.Where(FormPatternSettings.func_12).ToList<DrawObjectBase>();
			foreach (DrawObjectBase drawObjectBase in list2)
			{
				LineCellTool lineCellTool = (LineCellTool)drawObjectBase;
				int num = 1;
				foreach (object obj in ((IEnumerable)this.dgvSwitchs.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					try
					{
						object value = dataGridViewRow.Cells["columnTypeSwitch"].Value;
						if (value != null)
						{
							ObjectOnLine objectOnLine = lineCellTool.Branches[0].AddSwitchTool((TypeSwitch)Convert.ToInt32(value), (double)num / (double)this.dgvSwitchs.Rows.Count);
							objectOnLine.Text = num.ToString();
							this.canvasPattern.AddObject(drawingLayer, objectOnLine);
							objectOnLine.On = true;
						}
						num++;
					}
					catch
					{
					}
				}
			}
		}

		[CompilerGenerated]
		private static bool smethod_0(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(RectangleTool);
		}

		[CompilerGenerated]
		private static bool smethod_1(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(RectangleTool);
		}

		[CompilerGenerated]
		private static bool smethod_2(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(RectangleTool);
		}

		[CompilerGenerated]
		private static bool smethod_3(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(RectangleTool);
		}

		[CompilerGenerated]
		private static bool smethod_4(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(RectangleTool);
		}

		[CompilerGenerated]
		private static bool smethod_5(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(RectangleTool);
		}

		[CompilerGenerated]
		private static bool smethod_6(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(ShinaTool);
		}

		[CompilerGenerated]
		private static bool smethod_7(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(RectangleTool);
		}

		[CompilerGenerated]
		private static bool smethod_8(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(LineCellTool);
		}

		[CompilerGenerated]
		private static bool smethod_9(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(RectangleTool);
		}

		[CompilerGenerated]
		private static bool smethod_10(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(ShinaTool);
		}

		[CompilerGenerated]
		private static bool smethod_11(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0 is ObjectOnLine;
		}

		[CompilerGenerated]
		private static bool smethod_12(DrawObjectBase drawObjectBase_0)
		{
			return drawObjectBase_0.GetType() == typeof(LineCellTool);
		}

		private float float_0 = 0.3f;

		private PatternTP patternTP_0;

		private SQLSettings sqlsettings_0;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_0;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_1;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_2;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_3;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_4;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_5;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_6;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_7;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_8;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_9;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_10;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_11;

		[CompilerGenerated]
		private static Func<DrawObjectBase, bool> func_12;
	}
}
