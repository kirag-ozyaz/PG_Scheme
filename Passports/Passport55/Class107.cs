using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;

internal class Class107 : UITypeEditor
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
		Class107.Class108 @class = new Class107.Class108(context);
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

	internal class Class108 : ITypeDescriptorContext, IServiceProvider
	{
		public Class108(ITypeDescriptorContext itypeDescriptorContext_1)
		{
			this.itypeDescriptorContext_0 = itypeDescriptorContext_1;
		}

		public Class108(ITypeDescriptorContext itypeDescriptorContext_1, bool bool_1) : this(itypeDescriptorContext_1)
		{
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

		public object GetService(Type serviceType)
		{
			return this.itypeDescriptorContext_0.GetService(serviceType);
		}

		private ITypeDescriptorContext itypeDescriptorContext_0;

		private bool bool_0 = true;
	}
}
