using System;

namespace SchemeCtrl2.DrawTool
{
	public class AutomaticEntryProvisionTool : LabelTool
	{
		public override string Text
		{
			get
			{
				return "АВР";
			}
		}

		public override TextFont TextProperty
		{
			get
			{
				if (this.Layer != null && base.UseSettingsText)
				{
					TextFont textPropertyAutomaticEntryProvision = this.Layer.Parent.Settings.TextPropertyAutomaticEntryProvision;
					base.TextProperty = new TextFont(textPropertyAutomaticEntryProvision.FontName, textPropertyAutomaticEntryProvision.FontSize, textPropertyAutomaticEntryProvision.FontBold, textPropertyAutomaticEntryProvision.FontItalic, textPropertyAutomaticEntryProvision.FontUnderline, base.TextProperty.Position, base.TextProperty.FontVirtical, base.TextProperty.Visible, textPropertyAutomaticEntryProvision.Color);
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
					return this.Layer.Parent.Settings.VisibleAutomaticEntryProvisionTool;
				}
				return base.Visible;
			}
			set
			{
				base.Visible = value;
			}
		}

		public AutomaticEntryProvisionTool()
		{
			
			
			this.TextProperty.Visible = true;
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			AutomaticEntryProvisionTool automaticEntryProvisionTool = new AutomaticEntryProvisionTool();
			automaticEntryProvisionTool.Copy(this);
			return automaticEntryProvisionTool;
		}

		public override int GetTypeObject()
		{
			return Convert.ToInt32(eTypeLabelTool.AutomaticEntryProvision);
		}
	}
}
