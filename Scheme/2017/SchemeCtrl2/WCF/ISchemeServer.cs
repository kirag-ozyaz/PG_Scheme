using System;
using System.Collections.Generic;
using System.ServiceModel;
using SchemeCtrl2.DrawTool;

namespace SchemeCtrl2.WCF
{
	[ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(ICallBack))]
	public interface ISchemeServer
	{
		[OperationContract(IsOneWay = true, IsInitiating = true, IsTerminating = false)]
		void Join(string clientID);

		[OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = true)]
		void Leave(string clientID);

		[OperationContract(IsOneWay = false, IsInitiating = false, IsTerminating = false)]
		bool Check();

		[OperationContract(IsOneWay = true)]
		void SetClientState(string clientID, ClientState state);

		[OperationContract(IsOneWay = false)]
		ClientState GetClientState(string clientID);

		[OperationContract(IsOneWay = false)]
		List<ObjectBaseServer> GetAllObj(string clientID, int startIndex, int lenght);

		[OperationContract(IsOneWay = false)]
		int GetCountAllObj(string clientID);

		[OperationContract(IsOneWay = false)]
		List<ObjectOnLineServer> GetAllObjOnLine(string clientID, int startIndex, int lenght);

		[OperationContract(IsOneWay = false)]
		int GetCountAllObjOnLine(string clientID);

		[OperationContract(IsOneWay = false)]
		List<ObjectBaseServer> GetLoadedPoints(string clientID, int startIndex, int lenght);

		[OperationContract(IsOneWay = false)]
		int GetCountLoadedPoints(string clientID);

		[OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
		void ObjectOnLineChanged(ObjectOnLineServer objectOnline);

		[OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
		void ObjectChanged(ObjectBaseServer obj);

		[OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
		void ObjectOnLineOnChange(int idBase, bool on);

		[OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
		void StateOnLine(int idBase, int idRelation, int numBranch, double delta, States state, bool add, string id);
	}
}
