using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Xml;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.WCF;

namespace SchemeCtrl2.DrawTool
{
	public class LineToolState
	{
		public LineToolState()
		{
			this.state = States.none;
			this.objectOnLine_0 = null;
		}

		public LineToolState(States state, Branch branch, UnitPoint clickPoint)
		{
			this.state = state;
			switch (this.state)
			{
			case States.grounded:
				this.objectOnLine_0 = new GroundingTool(branch);
				goto IL_83;
			case States.const_1:
				this.objectOnLine_0 = new OffTool(branch);
				goto IL_83;
			case States.break_down:
				this.objectOnLine_0 = new DamageTool(branch);
				goto IL_83;
			case States.not_phased:
				this.objectOnLine_0 = new NotPhasedTool(branch);
				goto IL_83;
			case States.Arrow:
				this.objectOnLine_0 = new ArrowTool(branch);
				goto IL_83;
			}
			this.objectOnLine_0 = null;
			IL_83:
			if (this.Mapping != null)
			{
				this.objectOnLine_0.MappingState = true;
				this.objectOnLine_0.State = this;
				branch.AddSwitchTool(this.Mapping, clickPoint);
			}
		}

		public LineToolState(Branch branch, double delta, States state)
		{
			this.state = state;
			switch (this.state)
			{
			case States.grounded:
				this.objectOnLine_0 = new GroundingTool(branch);
				goto IL_83;
			case States.const_1:
				this.objectOnLine_0 = new OffTool(branch);
				goto IL_83;
			case States.break_down:
				this.objectOnLine_0 = new DamageTool(branch);
				goto IL_83;
			case States.not_phased:
				this.objectOnLine_0 = new NotPhasedTool(branch);
				goto IL_83;
			case States.Arrow:
				this.objectOnLine_0 = new ArrowTool(branch);
				goto IL_83;
			}
			this.objectOnLine_0 = null;
			IL_83:
			if (this.Mapping != null)
			{
				this.objectOnLine_0.MappingState = true;
				this.objectOnLine_0.State = this;
				this.Mapping.Delta = delta;
				this.objectOnLine_0.RecalcAngle();
				branch.AddSwitchTool(this.objectOnLine_0);
			}
		}

		public LineToolState(Branch branch, XmlNode stateNode)
		{
			XmlAttribute xmlAttribute = (XmlAttribute)stateNode.Attributes.GetNamedItem("type");
			States states;
			if (xmlAttribute != null)
			{
				states = (States)Convert.ToInt32(xmlAttribute.Value);
			}
			else
			{
				states = States.none;
			}
			this.state = states;
			switch (this.state)
			{
			case States.grounded:
				this.objectOnLine_0 = new GroundingTool(branch);
				goto IL_AC;
			case States.const_1:
				this.objectOnLine_0 = new OffTool(branch);
				goto IL_AC;
			case States.break_down:
				this.objectOnLine_0 = new DamageTool(branch);
				goto IL_AC;
			case States.not_phased:
				this.objectOnLine_0 = new NotPhasedTool(branch);
				goto IL_AC;
			case States.Arrow:
				this.objectOnLine_0 = new ArrowTool(branch);
				goto IL_AC;
			}
			this.objectOnLine_0 = null;
			IL_AC:
			if (this.Mapping != null)
			{
				this.objectOnLine_0.MappingState = true;
				this.objectOnLine_0.State = this;
				xmlAttribute = (XmlAttribute)stateNode.Attributes.GetNamedItem("delta");
				this.Mapping.Delta = (double)Convert.ToSingle(xmlAttribute.Value, new CultureInfo(1033));
				xmlAttribute = (XmlAttribute)stateNode.Attributes.GetNamedItem("Text");
				if (xmlAttribute != null)
				{
					this.Mapping.Text = xmlAttribute.Value;
				}
				xmlAttribute = (XmlAttribute)stateNode.Attributes.GetNamedItem("TextPos");
				if (xmlAttribute != null)
				{
					this.Mapping.TextProperty.Visible = true;
					this.Mapping.TextProperty.Position = (ePositionText)Convert.ToInt32(xmlAttribute.Value);
				}
				this.objectOnLine_0.RecalcAngle();
				xmlAttribute = (XmlAttribute)stateNode.Attributes.GetNamedItem("gorMirror");
				if (xmlAttribute != null)
				{
					this.Mapping.GorMirror = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = (XmlAttribute)stateNode.Attributes.GetNamedItem("vertMirror");
				if (xmlAttribute != null)
				{
					this.Mapping.VertMirror = Convert.ToBoolean(xmlAttribute.Value);
				}
				xmlAttribute = (XmlAttribute)stateNode.Attributes.GetNamedItem("Color");
				if (xmlAttribute != null)
				{
					this.Mapping.UseSettingColor = false;
					this.Mapping.Color = Color.FromArgb(Convert.ToInt32(xmlAttribute.Value));
				}
				branch.AddSwitchTool(this.objectOnLine_0);
			}
		}

		public LineToolState(Branch branch, LineStateServer stateNode)
		{
			this.state = (States)stateNode.type;
			switch (this.state)
			{
			case States.grounded:
				this.objectOnLine_0 = new GroundingTool(branch);
				goto IL_89;
			case States.const_1:
				this.objectOnLine_0 = new OffTool(branch);
				goto IL_89;
			case States.break_down:
				this.objectOnLine_0 = new DamageTool(branch);
				goto IL_89;
			case States.not_phased:
				this.objectOnLine_0 = new NotPhasedTool(branch);
				goto IL_89;
			case States.Arrow:
				this.objectOnLine_0 = new ArrowTool(branch);
				goto IL_89;
			}
			this.objectOnLine_0 = null;
			IL_89:
			if (this.Mapping != null)
			{
				this.objectOnLine_0.MappingState = true;
				this.objectOnLine_0.State = this;
				this.Mapping.Delta = (double)stateNode.delta;
				this.Mapping.GorMirror = stateNode.GorMirror;
				this.Mapping.VertMirror = stateNode.VertMirror;
				this.objectOnLine_0.RecalcAngle();
				branch.AddSwitchTool(this.objectOnLine_0);
			}
		}

		public LineToolState Clone(Branch branch)
		{
			return new LineToolState
			{
				state = this.state,
				objectOnLine_0 = (ObjectOnLine)this.Mapping.Clone(true),
				objectOnLine_0 = 
				{
					Parent = branch
				}
			};
		}

		public ObjectOnLine Mapping
		{
			get
			{
				return this.objectOnLine_0;
			}
			set
			{
				this.objectOnLine_0 = value;
			}
		}

		public override string ToString()
		{
			switch (this.state)
			{
			case States.grounded:
				return "Заземлено";
			case States.const_1:
				return "Отключено";
			case States.break_down:
				return "Разрыв";
			case States.not_phased:
				return "Не сфазировано";
			case States.Arrow:
				return "Перенос нагрузки";
			}
			return base.ToString();
		}

		public void Remove(bool delSql)
		{
			if (this.Mapping != null)
			{
				LineTool lineTool = (LineTool)this.Mapping.Parent.Parent;
				if (delSql && this.Mapping.IdBase > 0)
				{
					this.Mapping.Remove(true, false);
				}
				else
				{
					this.Mapping.Remove(false, false);
				}
				this.Mapping.MappingState = false;
				this.Mapping = null;
				if (lineTool.States.Contains(this))
				{
					lineTool.RemoveState(this);
				}
			}
		}

		private ObjectOnLine objectOnLine_0;

		public States state;
	}
}
