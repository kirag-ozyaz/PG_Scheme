using System;

namespace SchemeCtrl2.DrawTool
{
	public class ResponsibleAbonentTool : LabelTool
	{
		public override TextFont TextProperty
		{
			get
			{
				if (this.Layer != null && base.UseSettingsText)
				{
					TextFont textPropertyResponsibleAbonentTool = this.Layer.Parent.Settings.TextPropertyResponsibleAbonentTool;
					base.TextProperty = new TextFont(textPropertyResponsibleAbonentTool.FontName, textPropertyResponsibleAbonentTool.FontSize, textPropertyResponsibleAbonentTool.FontBold, textPropertyResponsibleAbonentTool.FontItalic, textPropertyResponsibleAbonentTool.FontUnderline, base.TextProperty.Position, base.TextProperty.FontVirtical, base.TextProperty.Visible, textPropertyResponsibleAbonentTool.Color);
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
					return this.Layer.Parent.Settings.VisibleResponsibleAbonentTool;
				}
				return base.Visible;
			}
			set
			{
				base.Visible = value;
			}
		}

		public ResponsibleAbonentTool()
		{
			this.Text = "Абн";
			this.TextProperty.Visible = true;
		}

		public override DrawObjectBase Clone(bool SaveParentRelation)
		{
			ResponsibleAbonentTool responsibleAbonentTool = new ResponsibleAbonentTool();
			responsibleAbonentTool.Copy(this);
			return responsibleAbonentTool;
		}

		public override int GetTypeObject()
		{
			return Convert.ToInt32(eTypeLabelTool.ResponsibleAbonent);
		}
	}
}
