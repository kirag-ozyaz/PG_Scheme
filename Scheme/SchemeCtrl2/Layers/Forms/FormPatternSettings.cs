using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
			
			this.float_0 = 0.3f;
			
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
			RectangleTool rectangleTool = (RectangleTool)this.canvasPattern.Layers.First<ICanvasLayer>().Objects.Single((DrawObjectBase obj) => obj.GetType() == typeof(RectangleTool));
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
			new SqlDataCommand(this.sqlsettings_0).SelectSqlData(this.dataTable_0, true, " where (parentKey  = ';SCM;PS;' or parentKey like ';SCM;BUS;%'  or parentKey = ';SCM;INLINE_OBJ;SWITCH;' ) and isgroup = 0 and deleted = 0", null, false, 0);
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
			((RectangleTool)this.canvasPattern.Layers.First<ICanvasLayer>().Objects.Single((DrawObjectBase obj) => obj.GetType() == typeof(RectangleTool))).TypeRectnagleTool = (eTypeRectangleTool)this.cmbTypeSubstation.SelectedValue;
			this.canvasPattern.DoInvalidate(true);
		}

		private void txtNameSubstation_TextChanged(object sender, EventArgs e)
		{
			this.canvasPattern.Layers.First<ICanvasLayer>().Objects.Single((DrawObjectBase obj) => obj.GetType() == typeof(RectangleTool)).Text = this.txtNameSubstation.Text;
			this.canvasPattern.DoInvalidate(true);
		}

		private void radioButtonRT_CheckedChanged(object sender, EventArgs e)
		{
			DrawObjectBase drawObjectBase = this.canvasPattern.Layers.First<ICanvasLayer>().Objects.Single((DrawObjectBase obj) => obj.GetType() == typeof(RectangleTool));
			drawObjectBase.TextProperty.Visible = true;
			drawObjectBase.TextProperty.Position = (ePositionText)((RadioButton)sender).Tag;
			this.canvasPattern.DoInvalidate(true);
		}

		private void radioButtonNotVisible_CheckedChanged(object sender, EventArgs e)
		{
			this.canvasPattern.Layers.First<ICanvasLayer>().Objects.Single((DrawObjectBase obj) => obj.GetType() == typeof(RectangleTool)).TextProperty.Visible = false;
			this.canvasPattern.DoInvalidate(true);
		}

		private void radioButtonGorizontal_CheckedChanged(object sender, EventArgs e)
		{
			DrawObjectBase drawObjectBase = this.canvasPattern.Layers.First<ICanvasLayer>().Objects.Single((DrawObjectBase obj) => obj.GetType() == typeof(RectangleTool));
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

		private void sRgGqySrTa(object sender, EventArgs e)
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

		private void method_3(int int_0, bool bool_0)
		{
			DrawingLayer drawingLayer = (DrawingLayer)this.canvasPattern.Layers.First<ICanvasLayer>();
			List<DrawObjectBase> list = (from obj in drawingLayer.Objects
			where obj.GetType() == typeof(ShinaTool)
			select obj).ToList<DrawObjectBase>();
			while (list.Count > 0)
			{
				list[0].Remove(false, true);
				list.Remove(list[0]);
			}
			RectangleTool rectangleTool = (RectangleTool)this.canvasPattern.Layers.First<ICanvasLayer>().Objects.Single((DrawObjectBase obj) => obj.GetType() == typeof(RectangleTool));
			this.method_2(rectangleTool.Rectangle);
			if (int_0 == 0)
			{
				return;
			}
			int num = 1;
			float num2 = (float)this.numericUpDownDistanceShins.Value;
			if (bool_0)
			{
				if (int_0 <= 3)
				{
					float num3 = rectangleTool.Rectangle.X + rectangleTool.Rectangle.Width / 2f;
					float num4 = rectangleTool.Rectangle.Y + this.float_0;
					float num5 = (rectangleTool.Rectangle.Height - 2f * this.float_0 + num2) / (float)int_0 - num2;
					for (int i = 0; i < int_0; i++)
					{
						ShinaTool shinaTool = new ShinaTool();
						DrawObjectBase drawObjectBase = shinaTool;
						int num6 = num;
						num = num6 + 1;
						drawObjectBase.Text = num6.ToString();
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
				int num7 = int_0 / 2;
				int num8 = int_0 - int_0 / 2;
				float num9 = rectangleTool.Rectangle.X + rectangleTool.Rectangle.Width / 3f;
				float num10 = rectangleTool.Rectangle.Y + this.float_0;
				float num11 = (rectangleTool.Rectangle.Height - 2f * this.float_0 + num2) / (float)num7 - num2;
				for (int j = 0; j < num7; j++)
				{
					ShinaTool shinaTool2 = new ShinaTool();
					DrawObjectBase drawObjectBase2 = shinaTool2;
					int num6 = num;
					num = num6 + 1;
					drawObjectBase2.Text = num6.ToString();
					shinaTool2.TypeShinaTool = (eTypeShinaTool)((int)this.cmbTypeShins.SelectedValue);
					shinaTool2.Parent = rectangleTool;
					shinaTool2.TextProperty.Visible = this.checkBoxVisibleTextShins.Checked;
					shinaTool2.TextProperty.Position = ePositionText.T;
					shinaTool2.P1 = new UnitPoint((double)num9, (double)(num10 + (num11 + num2) * (float)j));
					shinaTool2.P2 = new UnitPoint((double)num9, (double)(num10 + (num11 + num2) * (float)j + num11));
					this.canvasPattern.AddObject(drawingLayer, shinaTool2);
				}
				num9 = rectangleTool.Rectangle.X + 2f * (rectangleTool.Rectangle.Width / 3f);
				num11 = (rectangleTool.Rectangle.Height - 2f * this.float_0 + num2) / (float)num8 - num2;
				for (int k = 0; k < num8; k++)
				{
					ShinaTool shinaTool3 = new ShinaTool();
					DrawObjectBase drawObjectBase3 = shinaTool3;
					int num6 = num;
					num = num6 + 1;
					drawObjectBase3.Text = num6.ToString();
					shinaTool3.TypeShinaTool = (eTypeShinaTool)((int)this.cmbTypeShins.SelectedValue);
					shinaTool3.Parent = rectangleTool;
					shinaTool3.TextProperty.Visible = this.checkBoxVisibleTextShins.Checked;
					shinaTool3.TextProperty.Position = ePositionText.T;
					shinaTool3.P1 = new UnitPoint((double)num9, (double)(num10 + (num11 + num2) * (float)k));
					shinaTool3.P2 = new UnitPoint((double)num9, (double)(num10 + (num11 + num2) * (float)k + num11));
					this.canvasPattern.AddObject(drawingLayer, shinaTool3);
				}
				return;
			}
			else
			{
				if (int_0 <= 3)
				{
					float num12 = rectangleTool.Rectangle.X + this.float_0;
					float num13 = rectangleTool.Rectangle.Y + rectangleTool.Rectangle.Height / 2f;
					float num14 = (rectangleTool.Rectangle.Width - 2f * this.float_0 + num2) / (float)int_0 - num2;
					for (int l = 0; l < int_0; l++)
					{
						ShinaTool shinaTool4 = new ShinaTool();
						DrawObjectBase drawObjectBase4 = shinaTool4;
						int num6 = num;
						num = num6 + 1;
						drawObjectBase4.Text = num6.ToString();
						shinaTool4.TypeShinaTool = (eTypeShinaTool)((int)this.cmbTypeShins.SelectedValue);
						shinaTool4.Parent = rectangleTool;
						shinaTool4.TextProperty.Visible = this.checkBoxVisibleTextShins.Checked;
						shinaTool4.TextProperty.Position = ePositionText.L;
						shinaTool4.P1 = new UnitPoint((double)(num12 + (num14 + num2) * (float)l), (double)num13);
						shinaTool4.P2 = new UnitPoint((double)(num12 + (num14 + num2) * (float)l + num14), (double)num13);
						this.canvasPattern.AddObject(drawingLayer, shinaTool4);
					}
					return;
				}
				int num15 = int_0 / 2;
				int num16 = int_0 - int_0 / 2;
				float num17 = rectangleTool.Rectangle.X + this.float_0;
				float num18 = rectangleTool.Rectangle.Y + rectangleTool.Rectangle.Height / 3f;
				float num19 = (rectangleTool.Rectangle.Width - 2f * this.float_0 + num2) / (float)num15 - num2;
				for (int m = 0; m < num15; m++)
				{
					ShinaTool shinaTool5 = new ShinaTool();
					DrawObjectBase drawObjectBase5 = shinaTool5;
					int num6 = num;
					num = num6 + 1;
					drawObjectBase5.Text = num6.ToString();
					shinaTool5.TypeShinaTool = (eTypeShinaTool)((int)this.cmbTypeShins.SelectedValue);
					shinaTool5.Parent = rectangleTool;
					shinaTool5.TextProperty.Visible = this.checkBoxVisibleTextShins.Checked;
					shinaTool5.TextProperty.Position = ePositionText.L;
					shinaTool5.P1 = new UnitPoint((double)(num17 + (num19 + num2) * (float)m), (double)num18);
					shinaTool5.P2 = new UnitPoint((double)(num17 + (num19 + num2) * (float)m + num19), (double)num18);
					this.canvasPattern.AddObject(drawingLayer, shinaTool5);
				}
				num18 = rectangleTool.Rectangle.Y + 2f * (rectangleTool.Rectangle.Height / 3f);
				num19 = (rectangleTool.Rectangle.Width - 2f * this.float_0 + num2) / (float)num16 - num2;
				for (int n = 0; n < num16; n++)
				{
					ShinaTool shinaTool6 = new ShinaTool();
					DrawObjectBase drawObjectBase6 = shinaTool6;
					int num6 = num;
					num = num6 + 1;
					drawObjectBase6.Text = num6.ToString();
					shinaTool6.TypeShinaTool = (eTypeShinaTool)((int)this.cmbTypeShins.SelectedValue);
					shinaTool6.Parent = rectangleTool;
					shinaTool6.TextProperty.Visible = this.checkBoxVisibleTextShins.Checked;
					shinaTool6.TextProperty.Position = ePositionText.L;
					shinaTool6.P1 = new UnitPoint((double)(num17 + (num19 + num2) * (float)n), (double)num18);
					shinaTool6.P2 = new UnitPoint((double)(num17 + (num19 + num2) * (float)n + num19), (double)num18);
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
			List<DrawObjectBase> list = (from obj in drawingLayer.Objects
			where obj.GetType() == typeof(LineCellTool)
			select obj).ToList<DrawObjectBase>();
			while (list.Count > 0)
			{
				list[0].Remove(false, true);
				list.Remove(list[0]);
			}
			if (int_0 == 0)
			{
				return;
			}
			RectangleTool rectangleTool = (RectangleTool)this.canvasPattern.Layers.First<ICanvasLayer>().Objects.Single((DrawObjectBase obj) => obj.GetType() == typeof(RectangleTool));
			int num = 1;
			List<DrawObjectBase> list2 = (from obj in drawingLayer.Objects
			where obj.GetType() == typeof(ShinaTool)
			select obj).ToList<DrawObjectBase>();
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
						DrawObjectBase drawObjectBase3 = lineCellTool;
						int num2 = num;
						num = num2 + 1;
						drawObjectBase3.Text = num2.ToString();
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
				goto IL_6D;
			}
			IL_52:
			shinaTool_0.RemoveCell(list[0]);
			list.Remove(list[0]);
			IL_6D:
			if (list.Count > 0)
			{
				goto IL_52;
			}
			if (shinaTool_0.P1.X == shinaTool_0.P2.X)
			{
				double num = Math.Min(shinaTool_0.P1.Y, shinaTool_0.P2.Y);
				double num2 = Math.Max(shinaTool_0.P1.Y, shinaTool_0.P2.Y);
				for (int i = 0; i < int_0; i++)
				{
					double y = num + (num2 - num) * (double)(i + 1) / (double)(int_0 + 1);
					shinaTool_0.AddPointShinaTool(new UnitPoint(shinaTool_0.P1.X, y));
				}
				return;
			}
			double num3 = Math.Min(shinaTool_0.P1.X, shinaTool_0.P2.X);
			double num4 = Math.Max(shinaTool_0.P1.X, shinaTool_0.P2.X);
			for (int j = 0; j < int_0; j++)
			{
				double x = num3 + (num4 - num3) * (double)(j + 1) / (double)(int_0 + 1);
				shinaTool_0.AddPointShinaTool(new UnitPoint(x, shinaTool_0.P1.Y));
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
			List<DrawObjectBase> list = (from obj in drawingLayer.Objects
			where obj is ObjectOnLine
			select obj).ToList<DrawObjectBase>();
			while (list.Count > 0)
			{
				list[0].Remove(false, false);
				drawingLayer.RemoveObject(list[0]);
				list.Remove(list[0]);
			}
			foreach (DrawObjectBase drawObjectBase in (from obj in drawingLayer.Objects
			where obj.GetType() == typeof(LineCellTool)
			select obj).ToList<DrawObjectBase>())
			{
				LineCellTool lineCellTool = (LineCellTool)drawObjectBase;
				int num = 1;
				foreach (object obj2 in ((IEnumerable)this.dgvSwitchs.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
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

		private float float_0;

		private PatternTP patternTP_0;

		private SQLSettings sqlsettings_0;
	}
}
