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
			if (new FormPatternSettings(this, sqlSet).ShowDialog() == DialogResult.OK)
			{
			}
		}

		public PatternTP()
		{
			
			
		}
	}
}
