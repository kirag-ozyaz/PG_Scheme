using System;
using SchemeCtrl2.DrawTool;

internal class Class91
{
	public string Text
	{
		get
		{
			return this.string_0;
		}
	}

	public RectangleTool method_0()
	{
		return this.rectangleTool_0;
	}

	public Class91(RectangleTool rectangleTool_1)
	{
		this.rectangleTool_0 = rectangleTool_1;
		this.string_0 = rectangleTool_1.Text;
	}

	public override string ToString()
	{
		return this.string_0;
	}

	private string string_0;

	private RectangleTool rectangleTool_0;
}
