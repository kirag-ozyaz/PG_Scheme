using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SchemeCtrl2.Canvas
{
	public static class Copying
	{
		public static bool IsSerializable(object obj)
		{
			MemoryStream serializationStream = new MemoryStream();
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			bool result;
			try
			{
				binaryFormatter.Serialize(serializationStream, obj);
				result = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Your object cannot be serialized. The reason is: " + ex.ToString());
				result = false;
			}
			return result;
		}

		public static void CopyToClipboard(object obj)
		{
			DataFormats.Format format = DataFormats.GetFormat(obj.GetType().FullName);
			DataObject dataObject = new DataObject();
			((IDataObject)dataObject).SetData(format.Name, false, obj);
			Clipboard.SetDataObject(dataObject, true);
		}

		public static object GetFromClipboard(Type T)
		{
			object result = null;
			IDataObject dataObject = Clipboard.GetDataObject();
			string fullName = T.FullName;
			if (dataObject.GetDataPresent(fullName))
			{
				result = dataObject.GetData(fullName);
			}
			return result;
		}
	}
}
