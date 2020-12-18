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
				return GeneralFormSettings.size_0;
			}
			set
			{
				GeneralFormSettings.size_0 = value;
				if (GeneralFormSettings.eventHandler_0 != null)
				{
					GeneralFormSettings.eventHandler_0(null, EventArgs.Empty);
				}
			}
		}

		public static float FontSize
		{
			get
			{
				return GeneralFormSettings.float_0;
			}
			set
			{
				GeneralFormSettings.float_0 = value;
				if (GeneralFormSettings.eventHandler_1 != null)
				{
					GeneralFormSettings.eventHandler_1(null, EventArgs.Empty);
				}
			}
		}

		[CompilerGenerated]
		internal static void SizeIconChanged(EventHandler value)
		{
			EventHandler eventHandler = GeneralFormSettings.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref GeneralFormSettings.eventHandler_0, value2, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		[CompilerGenerated]
		internal static void smethod_1(EventHandler value)
		{
			EventHandler eventHandler = GeneralFormSettings.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref GeneralFormSettings.eventHandler_0, value2, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		[CompilerGenerated]
		internal static void FontSizeChanged(EventHandler value)
		{
			EventHandler eventHandler = GeneralFormSettings.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref GeneralFormSettings.eventHandler_1, value2, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		[CompilerGenerated]
		internal static void smethod_3(EventHandler value)
		{
			EventHandler eventHandler = GeneralFormSettings.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref GeneralFormSettings.eventHandler_1, value2, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Note: this type is marked as 'beforefieldinit'.
		static GeneralFormSettings()
		{
			
			GeneralFormSettings.size_0 = new Size(16, 16);
			GeneralFormSettings.float_0 = 8.25f;
		}

		private static Size size_0;

		private static float float_0;

		[CompilerGenerated]
		private static EventHandler eventHandler_0;

		[CompilerGenerated]
		private static EventHandler eventHandler_1;
	}
}
