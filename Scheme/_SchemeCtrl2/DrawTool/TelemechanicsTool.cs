using System;

namespace SchemeCtrl2.DrawTool
{
	public class TelemechanicsTool : LabelTool
	{
		public override string Text
		{
			get
			{
				return "ТМ";
			}
		}

		public override TextFont TextProperty
		{
			get
			{
				if (this.Layer != null && base.UseSettingsText)
				{
					TextFont textPropertyTelemechanics = this.Layer.Parent.Settings.TextPropertyTelemechanics;
					base.TextProperty = new TextFont(textPropertyTelemechanics.FontName, textPropertyTelemechanics.FontSize, textPropertyTelemechanics.FontBold, textPropertyTelemechanics.FontItalic, textPropertyTelemechanics.FontUnderline, base.TextProperty.Position, base.TextProperty.FontVirtical, base.TextProperty.Visible, textPropertyTelemechanics.Color);
					return base.TextProperty;
				}
				return base.TextProperty;
			}
			set
			{
				base.TextProperty = value;
			}
		}

		public override bool Visible
		{
			get
			{
				if (this.Parent != null && !this.Parent.Visible)
				{
					return false;
				}
				if (this.Layer != null && base.UseSettingsText)
				{
					return this.Layer.Parent.Settings.VisibleTelemechanicsTool;
				}
				return base.Visible;
			}
			set
			{
				base.Visible = value;
			}
		}

		public TelemechanicsTool()
		{
			this.TextProperty.Visible = true;
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			TelemechanicsTool telemechanicsTool = new TelemechanicsTool();
			telemechanicsTool.Copy(this);
			return telemechanicsTool;
		}

		public override int GetTypeObject()
		{
			return Convert.ToInt32(eTypeLabelTool.Telemechanics);
		}
	}
}
