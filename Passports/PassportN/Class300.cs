using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

internal class Class300 : UITypeEditor
{
	public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
	{
		return UITypeEditorEditStyle.Modal;
	}

	public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
	{
		TypeConverter converter = TypeDescriptor.GetConverter(typeof(DataGridView));
		if (converter == null)
		{
			return value;
		}
		UITypeEditor uitypeEditor = (UITypeEditor)converter.GetProperties(new DataGridView())["Columns"].GetEditor(typeof(UITypeEditor));
		Class300.Class301 @class = new Class300.Class301(context);
		Control control = (Control)@class.Instance;
		ISite site = control.Site;
		if (control.Parent != null && control.Parent.Site != control.Site)
		{
			control.Site = control.Parent.Site;
		}
		object result = uitypeEditor.EditValue(@class, provider, value);
		if (control.Site != site)
		{
			control.Site = site;
		}
		return result;
	}

	public Class300()
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
	}

	internal class Class301 : ITypeDescriptorContext, IServiceProvider
	{
		public Class301(ITypeDescriptorContext itypeDescriptorContext_1)
		{
			Class330.Mus9JxKz1CNxy();
			this.bool_0 = true;
			base..ctor();
			this.itypeDescriptorContext_0 = itypeDescriptorContext_1;
		}

		public Class301(ITypeDescriptorContext itypeDescriptorContext_1, bool bool_1)
		{
			Class330.Mus9JxKz1CNxy();
			this..ctor(itypeDescriptorContext_1);
			this.bool_0 = bool_1;
		}

		public IContainer Container
		{
			get
			{
				return this.itypeDescriptorContext_0.Container;
			}
		}

		public object Instance
		{
			get
			{
				return this.Instance;
			}
		}

		public void OnComponentChanged()
		{
			this.itypeDescriptorContext_0.OnComponentChanged();
		}

		public bool OnComponentChanging()
		{
			return this.itypeDescriptorContext_0.OnComponentChanging();
		}

		public PropertyDescriptor PropertyDescriptor
		{
			get
			{
				return this.itypeDescriptorContext_0.PropertyDescriptor;
			}
		}

		public object GetService(Type service)
		{
			return this.itypeDescriptorContext_0.GetService(service);
		}

		private ITypeDescriptorContext itypeDescriptorContext_0;

		private bool bool_0;
	}
}
