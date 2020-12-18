using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace OfficeLB
{
	public class Base
	{
		public Base()
		{
			
			
		}

		public Base(object _obj)
		{
			
			
			this._obj = _obj;
		}

        internal void ctor(object _obj)
        {
            this._obj = _obj;
        }

        protected virtual void SetProperty(string PropertyName, object[] value)
		{
			this._obj.GetType().InvokeMember(PropertyName, BindingFlags.Public | BindingFlags.SetProperty, null, this._obj, value);
		}

		protected virtual object GetProperty(string PropertyName, object[] value)
		{
			return this._obj.GetType().InvokeMember(PropertyName, BindingFlags.Public | BindingFlags.GetProperty, null, this._obj, value);
		}

		protected virtual void InvokeMethod(string MethodName, object[] value)
		{
			this._obj.GetType().InvokeMember(MethodName, BindingFlags.Public | BindingFlags.InvokeMethod, null, this._obj, value);
		}

		protected virtual object InvokeReturn(string MethodName, object[] value)
		{
			return this._obj.GetType().InvokeMember(MethodName, BindingFlags.Public | BindingFlags.InvokeMethod, null, this._obj, value);
		}

		public virtual void Close()
		{
			this.InvokeMethod("Close", null);
			Marshal.ReleaseComObject(this._obj);
			GC.GetTotalMemory(true);
		}

		public virtual void Dispose()
		{
			Marshal.ReleaseComObject(this._obj);
			GC.GetTotalMemory(true);
		}

		protected object _obj;
	}
}
