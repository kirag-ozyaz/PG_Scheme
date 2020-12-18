using System;
using System.Windows.Forms;
using DataSql;
using SchemeCtrl2.Layers.Forms;

namespace SchemeCtrl2.Layers
{
	public class PatternTP : DrawingLayer
	{
		public void ShowFormSettings(SQLSettings sqlSet)
		{
			FormPatternSettings formPatternSettings = new FormPatternSettings(this, sqlSet);
			if (formPatternSettings.ShowDialog() == DialogResult.OK)
			{
			}
		}
	}
}
