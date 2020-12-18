using System;
using System.CodeDom.Compiler;
using System.Drawing;
using System.ServiceModel;
using System.ServiceModel.Channels;

[GeneratedCode("System.ServiceModel", "3.0.0.0")]
public class SchemeProxy : DuplexClientBase<ISchemeService>, ISchemeService
{
	public SchemeProxy(InstanceContext callbackInstance)
	{
		
		base..ctor(callbackInstance);
	}

	public SchemeProxy(InstanceContext callbackInstance, string endpointConfigurationName)
	{
		
		base..ctor(callbackInstance, endpointConfigurationName);
	}

	public SchemeProxy(InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress)
	{
		
		base..ctor(callbackInstance, endpointConfigurationName, remoteAddress);
	}

	public SchemeProxy(InstanceContext callbackInstance, string endpointConfigurationName, EndpointAddress remoteAddress)
	{
		
		base..ctor(callbackInstance, endpointConfigurationName, remoteAddress);
	}

	public SchemeProxy(InstanceContext callbackInstance, Binding binding, EndpointAddress remoteAddress)
	{
		
		base..ctor(callbackInstance, binding, remoteAddress);
	}

	public IAsyncResult BeginJoin(string clientId, Guid databaseGuid, AsyncCallback callback, object asyncState)
	{
		return base.Channel.BeginJoin(clientId, databaseGuid, callback, asyncState);
	}

	public bool EndJoin(IAsyncResult result)
	{
		return base.Channel.EndJoin(result);
	}

	public void Leave()
	{
		base.Channel.Leave();
	}

	public void ObjectOnLineOnChange(int idBase, bool on, Guid databaseGuid)
	{
		base.Channel.ObjectOnLineOnChange(idBase, on, databaseGuid);
	}

	public void StateOnLine(int idBase, int idRelation, int numBranch, double delta, int typeState, bool add, string id, int idLineState, Guid databaseGuid)
	{
		base.Channel.StateOnLine(idBase, idRelation, numBranch, delta, typeState, add, id, idLineState, databaseGuid);
	}

	public bool Check()
	{
		return base.Channel.Check();
	}

	public void NodeChange(int idBase, int idAction, string text, PointF point, Color color, Guid databaseGuid)
	{
		base.Channel.NodeChange(idBase, idAction, text, point, color, databaseGuid);
	}

	public byte[] GetConsumersStates(int[] cunsumersId, Guid[] databaseGuid)
	{
		return base.Channel.GetConsumersStates(cunsumersId, databaseGuid);
	}
}
