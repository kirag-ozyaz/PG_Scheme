using System;

namespace SchemeCtrl2.DrawTool
{
	public class SpecialLockingTool : LabelTool
	{
		public override string Text
		{
			get
			{
				return "Ключ";
			}
		}

		public override TextFont TextProperty
		{
			get
			{
				if (this.Layer != null && base.UseSettingsText)
				{
					TextFont textPropertySpecialLocking = this.Layer.Parent.Settings.TextPropertySpecialLocking;
					base.TextProperty = new TextFont(textPropertySpecialLocking.FontName, textPropertySpecialLocking.FontSize, textPropertySpecialLocking.FontBold, textPropertySpecialLocking.FontItalic, textPropertySpecialLocking.FontUnderline, base.TextProperty.Position, base.TextProperty.FontVirtical, base.TextProperty.Visible, textPropertySpecialLocking.Color);
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
					return this.Layer.Parent.Settings.VisibleSpecialLockingTool;
				}
				return base.Visible;
			}
			set
			{
				base.Visible = value;
			}
		}

		public SpecialLockingTool()
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.TextProperty.Visible = true;
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			SpecialLockingTool specialLockingTool = new SpecialLockingTool();
			specialLockingTool.Copy(this);
			return specialLockingTool;
		}

		public override int GetTypeObject()
		{
			return Convert.ToInt32(eTypeLabelTool.SpecialLocking);
		}
	}
}
