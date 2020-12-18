using System;
using System.ServiceModel;

namespace SchemeCtrl2.WCF
{
	[ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(ISchemeCallback))]
	public interface ISchemeService
	{
		[OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
		void ObjectOnLineOnChange(int idBase, bool bool_0);

		[OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
		void StateOnLine(int idBase, int idRelation, int numBranch, double delta, int typeState, bool bool_0, string string_0, int idLineState);

		[OperationContract(IsOneWay = true, IsInitiating = true, IsTerminating = false)]
		void Join(string clientId);

		[OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = true)]
		void Leave();
	}
}
