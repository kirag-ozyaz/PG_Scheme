using System;
using System.Drawing;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.DrawTool
{
	public class ImageLabel : ImageTool
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

		public override void Move(UnitPoint offset, bool selectedMove)
		{
			if (!selectedMove && this.Selected)
			{
				return;
			}
			this.envelope.X = this.envelope.X + (float)offset.X;
			this.envelope.Y = this.envelope.Y + (float)offset.Y;
			if (this.method_7() != null && this.method_7().Layer != null && this.method_7().Layer.Parent != null)
			{
				this.Layer.Parent.Graphics = Graphics.FromHwnd(this.Layer.Parent.Handle);
				RectangleF boundingRect = this.method_7().GetBoundingRect(this.Parent.Layer.Parent, false);
				RectangleF rectangleText = this.GetRectangleText(this.Parent.Layer.Parent);
				if (this.envelope.X < boundingRect.X - rectangleText.Width)
				{
					this.envelope.X = boundingRect.X - rectangleText.Width;
				}
				if (this.envelope.Y < boundingRect.Y - rectangleText.Height)
				{
					this.envelope.Y = boundingRect.Y - rectangleText.Height;
				}
				if (this.envelope.X > boundingRect.Right)
				{
					this.envelope.X = boundingRect.Right;
				}
				if (this.envelope.Y > boundingRect.Bottom)
				{
					this.envelope.Y = boundingRect.Bottom;
				}
			}
			foreach (DrawObjectBase drawObjectBase in this.ChildObjects)
			{
				drawObjectBase.Move(offset, false);
			}
		}

		public ImageLabel()
		{
			
			this.bool_7 = true;
			
		}

		private bool bool_7;

		private DrawObjectBase drawObjectBase_2;
	}
}
