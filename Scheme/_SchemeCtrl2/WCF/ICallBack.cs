using System;
using System.ServiceModel;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.WCF
{
	public interface ICallBack
	{
		[OperationContract(IsOneWay = true)]
		void DrawObjectBaseMove(int int_0, UnitPoint offset, bool selectedMove);

		[OperationContract(IsOneWay = true)]
		void ObjectOnLineOnChange(int idBase, bool bool_0);

		[OperationContract(IsOneWay = true)]
		void StateOnLine(int idBase, int idRelation, int numBranch, double delta, States state, bool bool_0);
	}
}
