﻿using System;
using System.Windows.Forms;

namespace Passport.Classes
{
	public class InputCheck
	{
		public static void OnlyDigit(object sender, KeyPressEventArgs e)
		{
			TextBox textBox = (TextBox)sender;
			if (textBox.Text.Length == 0 && e.KeyChar == '.')
			{
				textBox.Select(0, 0);
				textBox.Text = "0";
				textBox.Select(2, 0);
			}
			if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '.' || textBox.Text.IndexOf(".") != -1) && e.KeyChar != '\b')
			{
				e.Handled = true;
			}
		}

		public static void AddBindingNull(TextBox textBox_0)
		{
			if (textBox_0.DataBindings.Count > 0)
			{
				textBox_0.DataBindings[0].Parse += InputCheck.smethod_0;
			}
		}

		private static void smethod_0(object sender, ConvertEventArgs e)
		{
			if (e.Value.ToString().Length == 0)
			{
				e.Value = DBNull.Value;
			}
		}
	}
}
