using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Scheme.Classes
{
	public static class GeneralFormSettings
	{
		public static Size SizeIcon
		{
			get
			{
				return GeneralFormSettings.sizeIcon;
			}
			set
			{
				GeneralFormSettings.sizeIcon = value;
				if (GeneralFormSettings.SizeIconChanged != null)
				{
					GeneralFormSettings.SizeIconChanged(null, EventArgs.Empty);
				}
			}
		}

		public static float FontSize
		{
			get
			{
				return GeneralFormSettings.fontSize;
			}
			set
			{
				GeneralFormSettings.fontSize = value;
				if (GeneralFormSettings.fontSizeChanged != null)
				{
					GeneralFormSettings.fontSizeChanged(null, EventArgs.Empty);
				}
			}
		}

		[CompilerGenerated]
		internal static void SizeIconChanged(EventHandler value)
		{
			EventHandler eventHandler = GeneralFormSettings.sizeIconChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref GeneralFormSettings.sizeIconChanged, value2, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		[CompilerGenerated]
		internal static void smethod_1(EventHandler value)
		{
			EventHandler eventHandler = GeneralFormSettings.sizeIconChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref GeneralFormSettings.sizeIconChanged, value2, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		[CompilerGenerated]
		internal static void FontSizeChanged(EventHandler value)
		{
			EventHandler eventHandler = GeneralFormSettings.fontSizeChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref GeneralFormSettings.fontSizeChanged, value2, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		[CompilerGenerated]
		internal static void smethod_3(EventHandler value)
		{
			EventHandler eventHandler = GeneralFormSettings.fontSizeChanged;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref GeneralFormSettings.fontSizeChanged, value2, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Note: this type is marked as 'beforefieldinit'.
		static GeneralFormSettings()
		{
			
			GeneralFormSettings.sizeIcon = new Size(16, 16);
			GeneralFormSettings.fontSize = 8.25f;
		}

		private static Size sizeIcon;

		private static float fontSize;

		[CompilerGenerated]
		private static EventHandler sizeIconChanged;

		[CompilerGenerated]
		private static EventHandler fontSizeChanged;
	}
}
