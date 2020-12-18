using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace RequestsClient.RequestService
{
	// Token: 0x0200003D RID: 61
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class RequestsServiceSoapClient : ClientBase<RequestsServiceSoap>, RequestsServiceSoap
	{
		// Token: 0x06000111 RID: 273 RVA: 0x000074C0 File Offset: 0x000056C0
		public RequestsServiceSoapClient()
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000074C8 File Offset: 0x000056C8
		public RequestsServiceSoapClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000074D1 File Offset: 0x000056D1
		public RequestsServiceSoapClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000074DB File Offset: 0x000056DB
		public RequestsServiceSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000074E5 File Offset: 0x000056E5
		public RequestsServiceSoapClient(Binding binding, EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000074EF File Offset: 0x000056EF
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		SuccsessResponse RequestsServiceSoap.Succsess(SuccsessRequest request)
		{
			return base.Channel.Succsess(request);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00007500 File Offset: 0x00005700
		public Response Succsess(long RequestId, DateTime DateEnd)
		{
			return ((RequestsServiceSoap)this).Succsess(new SuccsessRequest
			{
				Body = new SuccsessRequestBody(),
				Body = 
				{
					RequestId = RequestId,
					DateEnd = DateEnd
				}
			}).Body.SuccsessResult;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00007547 File Offset: 0x00005747
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		RequestCancelResponse RequestsServiceSoap.RequestCancel(RequestCancelRequest request)
		{
			return base.Channel.RequestCancel(request);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00007558 File Offset: 0x00005758
		public Response RequestCancel(long RequestId)
		{
			return ((RequestsServiceSoap)this).RequestCancel(new RequestCancelRequest
			{
				Body = new RequestCancelRequestBody(),
				Body = 
				{
					RequestId = RequestId
				}
			}).Body.RequestCancelResult;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00007593 File Offset: 0x00005793
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		SendReqResponse RequestsServiceSoap.SendReq(SendReqRequest request)
		{
			return base.Channel.SendReq(request);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000075A4 File Offset: 0x000057A4
		public Response SendReq(Request req)
		{
			return ((RequestsServiceSoap)this).SendReq(new SendReqRequest
			{
				Body = new SendReqRequestBody(),
				Body = 
				{
					req = req
				}
			}).Body.SendReqResult;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000075DF File Offset: 0x000057DF
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		GetDictGroupWorksResponse RequestsServiceSoap.GetDictGroupWorks(GetDictGroupWorksRequest request)
		{
			return base.Channel.GetDictGroupWorks(request);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000075F0 File Offset: 0x000057F0
		public DICTIONARY[] GetDictGroupWorks()
		{
			return ((RequestsServiceSoap)this).GetDictGroupWorks(new GetDictGroupWorksRequest
			{
				Body = new GetDictGroupWorksRequestBody()
			}).Body.GetDictGroupWorksResult;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000761F File Offset: 0x0000581F
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		GetDictTypeDisableResponse RequestsServiceSoap.GetDictTypeDisable(GetDictTypeDisableRequest request)
		{
			return base.Channel.GetDictTypeDisable(request);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00007630 File Offset: 0x00005830
		public DICTIONARY[] GetDictTypeDisable()
		{
			return ((RequestsServiceSoap)this).GetDictTypeDisable(new GetDictTypeDisableRequest
			{
				Body = new GetDictTypeDisableRequestBody()
			}).Body.GetDictTypeDisableResult;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000765F File Offset: 0x0000585F
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		GetDictTypeRegionResponse RequestsServiceSoap.GetDictTypeRegion(GetDictTypeRegionRequest request)
		{
			return base.Channel.GetDictTypeRegion(request);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00007670 File Offset: 0x00005870
		public DICTIONARY[] GetDictTypeRegion()
		{
			return ((RequestsServiceSoap)this).GetDictTypeRegion(new GetDictTypeRegionRequest
			{
				Body = new GetDictTypeRegionRequestBody()
			}).Body.GetDictTypeRegionResult;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000769F File Offset: 0x0000589F
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		GetDictStatusResponse RequestsServiceSoap.GetDictStatus(GetDictStatusRequest request)
		{
			return base.Channel.GetDictStatus(request);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000076B0 File Offset: 0x000058B0
		public DICTIONARY[] GetDictStatus()
		{
			return ((RequestsServiceSoap)this).GetDictStatus(new GetDictStatusRequest
			{
				Body = new GetDictStatusRequestBody()
			}).Body.GetDictStatusResult;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000076DF File Offset: 0x000058DF
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		GetDictTypeOrganizationResponse RequestsServiceSoap.GetDictTypeOrganization(GetDictTypeOrganizationRequest request)
		{
			return base.Channel.GetDictTypeOrganization(request);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000076F0 File Offset: 0x000058F0
		public DICTIONARY[] GetDictTypeOrganization()
		{
			return ((RequestsServiceSoap)this).GetDictTypeOrganization(new GetDictTypeOrganizationRequest
			{
				Body = new GetDictTypeOrganizationRequestBody()
			}).Body.GetDictTypeOrganizationResult;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000771F File Offset: 0x0000591F
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		GetAddressElementResponse RequestsServiceSoap.GetAddressElement(GetAddressElementRequest request)
		{
			return base.Channel.GetAddressElement(request);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00007730 File Offset: 0x00005930
		public AddressElement[] GetAddressElement(long? parentId)
		{
			return ((RequestsServiceSoap)this).GetAddressElement(new GetAddressElementRequest
			{
				Body = new GetAddressElementRequestBody(),
				Body = 
				{
					parentId = parentId
				}
			}).Body.GetAddressElementResult;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000776B File Offset: 0x0000596B
		public void TestAddress()
		{
			base.Channel.TestAddress();
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00007778 File Offset: 0x00005978
		public void TestSendReq()
		{
			base.Channel.TestSendReq();
		}
	}
}
