using System;
using System.Data;
using System.Drawing;

namespace SchemeCtrl2.DrawTool
{
	public class FreeLabelTool : LabelTool
	{
		public FreeLabelTool()
		{
			
			
			this.Text = "Текст";
		}

		public FreeLabelTool(DataRow r)
		{
			
			
		}

		public override Color Color
		{
			get
			{
				if (this.Layer != null && base.UseSettingColor)
				{
					return this.Layer.Parent.Settings.NodeToolColor;
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

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			FreeLabelTool freeLabelTool = new FreeLabelTool();
			freeLabelTool.Copy(this);
			return freeLabelTool;
		}

		public override string ToString()
		{
			return this.Text;
		}

		public override int GetTypeObject()
		{
			return Convert.ToInt32(eTypeLabelTool.FreeLabel);
		}
	}
}
