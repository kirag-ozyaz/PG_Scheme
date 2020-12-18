using System;
using System.CodeDom.Compiler;
using System.Drawing;
using System.ServiceModel;
using System.ServiceModel.Channels;

[GeneratedCode("System.ServiceModel", "3.0.0.0")]
public class SchemeProxy : DuplexClientBase<ISchemeService>, ISchemeService
{
	public SchemeProxy(InstanceContext callbackInstance) : base(callbackInstance)
	{
	}

	public SchemeProxy(InstanceContext callbackInstance, string endpointConfigurationName) : base(callbackInstance, endpointConfigurationName)
	{
	}

	public SchemeProxy(InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : base(callbackInstance, endpointConfigurationName, remoteAddress)
	{
	}

	public SchemeProxy(InstanceContext callbackInstance, string endpointConfigurationName, EndpointAddress remoteAddress) : base(callbackInstance, endpointConfigurationName, remoteAddress)
	{
	}

	public SchemeProxy(InstanceContext callbackInstance, Binding binding, EndpointAddress remoteAddress) : base(callbackInstance, binding, remoteAddress)
	{
	}

	public IAsyncResult BeginJoin(string clientId, AsyncCallback callback, object asyncState)
	{
		return base.Channel.BeginJoin(clientId, callback, asyncState);
	}

	public bool EndJoin(IAsyncResult result)
	{
		return base.Channel.EndJoin(result);
	}

	public void Leave()
	{
		base.Channel.Leave();
	}

	public void ObjectOnLineOnChange(int idBase, bool bool_0)
	{
		base.Channel.ObjectOnLineOnChange(idBase, bool_0);
	}

	public void StateOnLine(int idBase, int idRelation, int numBranch, double delta, int typeState, bool bool_0, string string_0, int idLineState)
	{
		base.Channel.StateOnLine(idBase, idRelation, numBranch, delta, typeState, bool_0, string_0, idLineState);
	}

	public bool Check()
	{
		return base.Channel.Check();
	}

	public void NodeChange(int idBase, int idAction, string text, PointF point, Color color)
	{
		base.Channel.NodeChange(idBase, idAction, text, point, color);
	}
}
