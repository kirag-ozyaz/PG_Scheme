using System;
using System.Drawing;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.Layers
{
	public class ShablonTP : DrawingLayer
	{
		public ShablonTP()
		{
			RectangleTool rectangleTool = new RectangleTool();
			rectangleTool.Rectangle = new RectangleF(0f, 0f, 5f, 5f);
			rectangleTool.Text = "ТП-???";
			rectangleTool.TextProperty.Visible = true;
			rectangleTool.TextProperty.Position = ePositionText.T;
			rectangleTool.UseSettingColor = false;
			rectangleTool.Color = Color.RoyalBlue;
			base.AddObject(rectangleTool);
			base.AddObject(new ShinaTool
			{
				P1 = new UnitPoint(0.5, 2.5),
				P2 = new UnitPoint(2.0, 2.5),
				Text = "1",
				TextProperty = 
				{
					Visible = true,
					Position = ePositionText.L
				},
				Parent = rectangleTool
			});
			base.AddObject(new ShinaTool
			{
				P1 = new UnitPoint(3.0, 2.5),
				P2 = new UnitPoint(4.5, 2.5),
				Text = "2",
				TextProperty = 
				{
					Visible = true,
					Position = ePositionText.R
				},
				Parent = rectangleTool
			});
			LineTool drawobject = new LineTool();
			base.AddObject(drawobject);
		}
	}
}
