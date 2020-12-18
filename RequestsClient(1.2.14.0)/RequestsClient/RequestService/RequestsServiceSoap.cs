using System;
using System.CodeDom.Compiler;
using System.ServiceModel;

namespace RequestsClient.RequestService
{
	// Token: 0x0200000A RID: 10
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[ServiceContract(Namespace = "http://aisgorod.ru/", ConfigurationName = "RequestService.RequestsServiceSoap")]
	public interface RequestsServiceSoap
	{
		// Token: 0x060000A0 RID: 160
		[OperationContract(Action = "http://aisgorod.ru/Succsess", ReplyAction = "*")]
		SuccsessResponse Succsess(SuccsessRequest request);

		// Token: 0x060000A1 RID: 161
		[OperationContract(Action = "http://aisgorod.ru/RequestCancel", ReplyAction = "*")]
		RequestCancelResponse RequestCancel(RequestCancelRequest request);

		// Token: 0x060000A2 RID: 162
		[OperationContract(Action = "http://aisgorod.ru/SendReq", ReplyAction = "*")]
		SendReqResponse SendReq(SendReqRequest request);

		// Token: 0x060000A3 RID: 163
		[OperationContract(Action = "http://aisgorod.ru/GetDictGroupWorks", ReplyAction = "*")]
		GetDictGroupWorksResponse GetDictGroupWorks(GetDictGroupWorksRequest request);

		// Token: 0x060000A4 RID: 164
		[OperationContract(Action = "http://aisgorod.ru/GetDictTypeDisable", ReplyAction = "*")]
		GetDictTypeDisableResponse GetDictTypeDisable(GetDictTypeDisableRequest request);

		// Token: 0x060000A5 RID: 165
		[OperationContract(Action = "http://aisgorod.ru/GetDictTypeRegion", ReplyAction = "*")]
		GetDictTypeRegionResponse GetDictTypeRegion(GetDictTypeRegionRequest request);

		// Token: 0x060000A6 RID: 166
		[OperationContract(Action = "http://aisgorod.ru/GetDictStatus", ReplyAction = "*")]
		GetDictStatusResponse GetDictStatus(GetDictStatusRequest request);

		// Token: 0x060000A7 RID: 167
		[OperationContract(Action = "http://aisgorod.ru/GetDictTypeOrganization", ReplyAction = "*")]
		GetDictTypeOrganizationResponse GetDictTypeOrganization(GetDictTypeOrganizationRequest request);

		// Token: 0x060000A8 RID: 168
		[OperationContract(Action = "http://aisgorod.ru/GetAddressElement", ReplyAction = "*")]
		GetAddressElementResponse GetAddressElement(GetAddressElementRequest request);

		// Token: 0x060000A9 RID: 169
		[OperationContract(Action = "http://aisgorod.ru/TestAddress", ReplyAction = "*")]
		void TestAddress();

		// Token: 0x060000AA RID: 170
		[OperationContract(Action = "http://aisgorod.ru/TestSendReq", ReplyAction = "*")]
		void TestSendReq();
	}
}
