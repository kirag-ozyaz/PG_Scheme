using System;
using System.CodeDom.Compiler;
using System.Drawing;
using System.ServiceModel;

[GeneratedCode("System.ServiceModel", "3.0.0.0")]
[ServiceContract(CallbackContract = typeof(ISchemeCallback), SessionMode = SessionMode.Required)]
public interface ISchemeService
{
	[OperationContract(AsyncPattern = true, Action = "http://tempuri.org/ISchemeService/Join", ReplyAction = "http://tempuri.org/ISchemeService/JoinResponse")]
	IAsyncResult BeginJoin(string clientId, AsyncCallback callback, object asyncState);

	bool EndJoin(IAsyncResult result);

	[OperationContract(IsOneWay = true, IsInitiating = false, Action = "http://tempuri.org/ISchemeService/Leave")]
	void Leave();

	[OperationContract(IsOneWay = true, IsInitiating = false, Action = "http://tempuri.org/ISchemeService/ObjectOnLineOnChange")]
	void ObjectOnLineOnChange(int idBase, bool bool_0);

	[OperationContract(IsOneWay = true, IsInitiating = false, Action = "http://tempuri.org/ISchemeService/StateOnLine")]
	void StateOnLine(int idBase, int idRelation, int numBranch, double delta, int typeState, bool bool_0, string string_0, int idLineState);

	[OperationContract(IsOneWay = true, IsInitiating = false, Action = "http://tempuri.org/ISchemeService/NodeChange")]
	void NodeChange(int idBase, int idAction, string text, PointF point, Color color);

	[OperationContract(IsOneWay = false, IsInitiating = false, Action = "http://tempuri.org/ISchemeService/Check")]
	bool Check();
}
