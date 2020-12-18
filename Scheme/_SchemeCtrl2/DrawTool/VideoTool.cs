using System;

namespace SchemeCtrl2.DrawTool
{
	public class VideoTool : LabelTool
	{
		public override string Text
		{
			get
			{
				return "ВИДЕО";
			}
		}

		public override TextFont TextProperty
		{
			get
			{
				if (this.Layer != null && base.UseSettingsText)
				{
					TextFont textPropertyTelemechanicsProtection = this.Layer.Parent.Settings.TextPropertyTelemechanicsProtection;
					base.TextProperty = new TextFont(textPropertyTelemechanicsProtection.FontName, textPropertyTelemechanicsProtection.FontSize, textPropertyTelemechanicsProtection.FontBold, textPropertyTelemechanicsProtection.FontItalic, textPropertyTelemechanicsProtection.FontUnderline, base.TextProperty.Position, base.TextProperty.FontVirtical, base.TextProperty.Visible, textPropertyTelemechanicsProtection.Color);
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
					return this.Layer.Parent.Settings.VisibleTelemechanicsProtectionTool;
				}
				return base.Visible;
			}
			set
			{
				base.Visible = value;
			}
		}

		public VideoTool()
		{
			this.TextProperty.Visible = true;
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			VideoTool videoTool = new VideoTool();
			videoTool.Copy(this);
			return videoTool;
		}

		public override int GetTypeObject()
		{
			return Convert.ToInt32(eTypeLabelTool.Video);
		}
	}
}
