using System;
using System.CodeDom.Compiler;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x02000017 RID: 23
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[ServiceContract(Namespace = "http://aisgorod.ru/", ConfigurationName = "RequestService.RequestsServiceSoap")]
	public interface RequestsServiceSoap
	{
		// Token: 0x060000C3 RID: 195
		[OperationContract(Action = "http://aisgorod.ru/Succsess", ReplyAction = "*")]
		SuccsessResponse Succsess(SuccsessRequest request);

		// Token: 0x060000C4 RID: 196
		[OperationContract(Action = "http://aisgorod.ru/RequestCancel", ReplyAction = "*")]
		RequestCancelResponse RequestCancel(RequestCancelRequest request);

		// Token: 0x060000C5 RID: 197
		[OperationContract(Action = "http://aisgorod.ru/SendReq", ReplyAction = "*")]
		SendReqResponse SendReq(SendReqRequest request);

		// Token: 0x060000C6 RID: 198
		[OperationContract(Action = "http://aisgorod.ru/GetDictGroupWorks", ReplyAction = "*")]
		GetDictGroupWorksResponse GetDictGroupWorks(GetDictGroupWorksRequest request);

		// Token: 0x060000C7 RID: 199
		[OperationContract(Action = "http://aisgorod.ru/GetDictTypeDisable", ReplyAction = "*")]
		GetDictTypeDisableResponse GetDictTypeDisable(GetDictTypeDisableRequest request);

		// Token: 0x060000C8 RID: 200
		[OperationContract(Action = "http://aisgorod.ru/GetDictTypeRegion", ReplyAction = "*")]
		GetDictTypeRegionResponse GetDictTypeRegion(GetDictTypeRegionRequest request);

		// Token: 0x060000C9 RID: 201
		[OperationContract(Action = "http://aisgorod.ru/GetDictStatus", ReplyAction = "*")]
		GetDictStatusResponse GetDictStatus(GetDictStatusRequest request);

		// Token: 0x060000CA RID: 202
		[OperationContract(Action = "http://aisgorod.ru/GetDictTypeOrganization", ReplyAction = "*")]
		GetDictTypeOrganizationResponse GetDictTypeOrganization(GetDictTypeOrganizationRequest request);

		// Token: 0x060000CB RID: 203
		[OperationContract(Action = "http://aisgorod.ru/GetAddressElement", ReplyAction = "*")]
		GetAddressElementResponse GetAddressElement(GetAddressElementRequest request);

		// Token: 0x060000CC RID: 204
		[OperationContract(Action = "http://aisgorod.ru/TestAddress", ReplyAction = "*")]
		void TestAddress();

		// Token: 0x060000CD RID: 205
		[OperationContract(Action = "http://aisgorod.ru/TestSendReq", ReplyAction = "*")]
		void TestSendReq();
	}
}
