using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.ServiceModel.Channels;
using j5c8XXscsIc6vD2Fg4l;
using WTbxUfsXa34kJl1qKMV;

namespace RequestsClient.RequestService
{
	// Token: 0x02000030 RID: 48
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class RequestsServiceSoapClient : ClientBase<RequestsServiceSoap>, RequestsServiceSoap
	{
		// Token: 0x06000191 RID: 401 RVA: 0x00007604 File Offset: 0x00005A04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequestsServiceSoapClient()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			base..ctor();
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00007620 File Offset: 0x00005A20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequestsServiceSoapClient(string endpointConfigurationName)
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
			RequestsServiceSoapClient.CJNajQLDAqZG7GWnXKu(this, endpointConfigurationName);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000763C File Offset: 0x00005A3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequestsServiceSoapClient(string endpointConfigurationName, string remoteAddress)
		{
			while (false)
			{
				object obj = null[0];
			}
			RequestsServiceSoapClient.AL7JQGLUCajKmalWJwk();
			base..ctor(endpointConfigurationName, remoteAddress);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000765C File Offset: 0x00005A5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequestsServiceSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress)
		{
			while (false)
			{
				object obj = null[0];
			}
			RequestsServiceSoapClient.AL7JQGLUCajKmalWJwk();
			base..ctor(endpointConfigurationName, remoteAddress);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000767C File Offset: 0x00005A7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public RequestsServiceSoapClient(Binding binding, EndpointAddress remoteAddress)
		{
			while (false)
			{
				object obj = null[0];
			}
			RequestsServiceSoapClient.AL7JQGLUCajKmalWJwk();
			RequestsServiceSoapClient.SF4qiGLJemsBZXd3Y34(this, binding, remoteAddress);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000769C File Offset: 0x00005A9C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		SuccsessResponse RequestsServiceSoap.Succsess(SuccsessRequest request)
		{
			while (false)
			{
				object obj = null[0];
			}
			return base.Channel.Succsess(request);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000076B8 File Offset: 0x00005AB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Response Succsess(long RequestId, DateTime DateEnd)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = 2;
			SuccsessRequest succsessRequest;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 1:
					succsessRequest.Body = new SuccsessRequestBody();
					num = 5;
					continue;
				case 2:
					goto IL_34;
				case 5:
					succsessRequest.Body.RequestId = RequestId;
					break;
				case 6:
					goto IL_B8;
				}
				IL_18:
				succsessRequest.Body.DateEnd = DateEnd;
				num = 6;
				if (RequestsServiceSoapClient.BkfRCDLp4b9yYaYHfqi())
				{
					continue;
				}
				IL_34:
				succsessRequest = new SuccsessRequest();
				RequestsServiceSoapClient.BkfRCDLp4b9yYaYHfqi();
				num = (RequestsServiceSoapClient.iHETueLOi2qYF4o6M3S() ? 4 : 0);
				continue;
				goto IL_18;
			}
			IL_B8:
			return ((RequestsServiceSoap)this).Succsess(succsessRequest).Body.SuccsessResult;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00007790 File Offset: 0x00005B90
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		RequestCancelResponse RequestsServiceSoap.RequestCancel(RequestCancelRequest request)
		{
			while (false)
			{
				object obj = null[0];
			}
			return base.Channel.RequestCancel(request);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000077AC File Offset: 0x00005BAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Response RequestCancel(long RequestId)
		{
			while (false)
			{
				object obj = null[0];
			}
			int num = (!RequestsServiceSoapClient.BkfRCDLp4b9yYaYHfqi()) ? 1 : 3;
			RequestCancelRequest requestCancelRequest;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 3:
					requestCancelRequest = new RequestCancelRequest();
					num = 4;
					if (!RequestsServiceSoapClient.iHETueLOi2qYF4o6M3S())
					{
						continue;
					}
					break;
				case 4:
					requestCancelRequest.Body = new RequestCancelRequestBody();
					break;
				case 5:
					goto IL_9A;
				}
				IL_84:
				requestCancelRequest.Body.RequestId = RequestId;
				num = 5;
				continue;
				goto IL_84;
			}
			IL_9A:
			return ((RequestsServiceSoap)this).RequestCancel(requestCancelRequest).Body.RequestCancelResult;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00007864 File Offset: 0x00005C64
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		SendReqResponse RequestsServiceSoap.SendReq(SendReqRequest request)
		{
			while (false)
			{
				object obj = null[0];
			}
			return base.Channel.SendReq(request);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00007880 File Offset: 0x00005C80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Response SendReq(Request req)
		{
			while (false)
			{
				object obj = null[0];
			}
			RequestsServiceSoapClient.BkfRCDLp4b9yYaYHfqi();
			int num = RequestsServiceSoapClient.iHETueLOi2qYF4o6M3S() ? 3 : 4;
			SendReqRequest sendReqRequest;
			for (;;)
			{
				switch (num)
				{
				case 0:
				case 4:
					sendReqRequest = new SendReqRequest();
					num = 1;
					continue;
				case 1:
					sendReqRequest.Body = new SendReqRequestBody();
					break;
				case 5:
					goto IL_A2;
				}
				IL_82:
				sendReqRequest.Body.req = req;
				num = 5;
				if (!RequestsServiceSoapClient.iHETueLOi2qYF4o6M3S())
				{
					continue;
				}
				continue;
				goto IL_82;
			}
			IL_A2:
			return ((RequestsServiceSoap)this).SendReq(sendReqRequest).Body.SendReqResult;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00007940 File Offset: 0x00005D40
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		GetDictGroupWorksResponse RequestsServiceSoap.GetDictGroupWorks(GetDictGroupWorksRequest request)
		{
			while (false)
			{
				object obj = null[0];
			}
			return base.Channel.GetDictGroupWorks(request);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000795C File Offset: 0x00005D5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DICTIONARY[] GetDictGroupWorks()
		{
			while (false)
			{
				object obj = null[0];
			}
			return ((RequestsServiceSoap)this).GetDictGroupWorks(new GetDictGroupWorksRequest
			{
				Body = new GetDictGroupWorksRequestBody()
			}).Body.GetDictGroupWorksResult;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000799C File Offset: 0x00005D9C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		GetDictTypeDisableResponse RequestsServiceSoap.GetDictTypeDisable(GetDictTypeDisableRequest request)
		{
			while (false)
			{
				object obj = null[0];
			}
			return base.Channel.GetDictTypeDisable(request);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000079B8 File Offset: 0x00005DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DICTIONARY[] GetDictTypeDisable()
		{
			while (false)
			{
				object obj = null[0];
			}
			return ((RequestsServiceSoap)this).GetDictTypeDisable(new GetDictTypeDisableRequest
			{
				Body = new GetDictTypeDisableRequestBody()
			}).Body.GetDictTypeDisableResult;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000079F8 File Offset: 0x00005DF8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		GetDictTypeRegionResponse RequestsServiceSoap.GetDictTypeRegion(GetDictTypeRegionRequest request)
		{
			while (false)
			{
				object obj = null[0];
			}
			return RequestsServiceSoapClient.BL3BycLIsh7pcVZ3lyn(base.Channel, request);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00007A14 File Offset: 0x00005E14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DICTIONARY[] GetDictTypeRegion()
		{
			while (false)
			{
				object obj = null[0];
			}
			return ((RequestsServiceSoap)this).GetDictTypeRegion(new GetDictTypeRegionRequest
			{
				Body = new GetDictTypeRegionRequestBody()
			}).Body.GetDictTypeRegionResult;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00007A54 File Offset: 0x00005E54
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		GetDictStatusResponse RequestsServiceSoap.GetDictStatus(GetDictStatusRequest request)
		{
			while (false)
			{
				object obj = null[0];
			}
			return RequestsServiceSoapClient.Jv8i64LZ1mu6cb6ARIf(base.Channel, request);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00007A70 File Offset: 0x00005E70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DICTIONARY[] GetDictStatus()
		{
			while (false)
			{
				object obj = null[0];
			}
			return RequestsServiceSoapClient.Jv8i64LZ1mu6cb6ARIf(this, new GetDictStatusRequest
			{
				Body = new GetDictStatusRequestBody()
			}).Body.GetDictStatusResult;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00007AB0 File Offset: 0x00005EB0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		GetDictTypeOrganizationResponse RequestsServiceSoap.GetDictTypeOrganization(GetDictTypeOrganizationRequest request)
		{
			while (false)
			{
				object obj = null[0];
			}
			return base.Channel.GetDictTypeOrganization(request);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00007ACC File Offset: 0x00005ECC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public DICTIONARY[] GetDictTypeOrganization()
		{
			while (false)
			{
				object obj = null[0];
			}
			return ((RequestsServiceSoap)this).GetDictTypeOrganization(new GetDictTypeOrganizationRequest
			{
				Body = new GetDictTypeOrganizationRequestBody()
			}).Body.GetDictTypeOrganizationResult;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00007B0C File Offset: 0x00005F0C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		GetAddressElementResponse RequestsServiceSoap.GetAddressElement(GetAddressElementRequest request)
		{
			while (false)
			{
				object obj = null[0];
			}
			return base.Channel.GetAddressElement(request);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00007B28 File Offset: 0x00005F28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AddressElement[] GetAddressElement(long? parentId)
		{
			while (false)
			{
				object obj = null[0];
			}
			return ((RequestsServiceSoap)this).GetAddressElement(new GetAddressElementRequest
			{
				Body = new GetAddressElementRequestBody(),
				Body = 
				{
					parentId = parentId
				}
			}).Body.GetAddressElementResult;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00007B74 File Offset: 0x00005F74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TestAddress()
		{
			while (false)
			{
				object obj = null[0];
			}
			base.Channel.TestAddress();
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00007B90 File Offset: 0x00005F90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TestSendReq()
		{
			while (false)
			{
				object obj = null[0];
			}
			RequestsServiceSoapClient.MiOuhtLc5tYAbboDRxv(base.Channel);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00007BAC File Offset: 0x00005FAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		static RequestsServiceSoapClient()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (false)
			{
				object obj = null[0];
			}
			RequestsServiceSoapClient.ekoPsGLzia0DKPkptcY();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00007BC4 File Offset: 0x00005FC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool BkfRCDLp4b9yYaYHfqi()
		{
			while (false)
			{
				object obj = null[0];
			}
			return true;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00007BD8 File Offset: 0x00005FD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool iHETueLOi2qYF4o6M3S()
		{
			while (false)
			{
				object obj = null[0];
			}
			return false;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00007BEC File Offset: 0x00005FEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void CJNajQLDAqZG7GWnXKu(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor(A_1);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00007C0C File Offset: 0x0000600C
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void AL7JQGLUCajKmalWJwk()
		{
			while (false)
			{
				object obj = null[0];
			}
			HdmwA4sAB9M6dTeLQJb.TqlX7ZmzmDDi2();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00007C24 File Offset: 0x00006024
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void SF4qiGLJemsBZXd3Y34(object A_0, object A_1, object A_2)
		{
			while (false)
			{
				object obj = null[0];
			}
			A_0..ctor(A_1, A_2);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00007C48 File Offset: 0x00006048
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object BL3BycLIsh7pcVZ3lyn(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return ((RequestsServiceSoap)A_0).GetDictTypeRegion(A_1);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00007C68 File Offset: 0x00006068
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static object Jv8i64LZ1mu6cb6ARIf(object A_0, object A_1)
		{
			while (false)
			{
				object obj = null[0];
			}
			return ((RequestsServiceSoap)A_0).GetDictStatus(A_1);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00007C88 File Offset: 0x00006088
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void MiOuhtLc5tYAbboDRxv(object A_0)
		{
			while (false)
			{
				object obj = null[0];
			}
			((RequestsServiceSoap)A_0).TestSendReq();
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00007CA4 File Offset: 0x000060A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ekoPsGLzia0DKPkptcY()
		{
			while (false)
			{
				object obj = null[0];
			}
			aNqu80syO4AxurQp3Hl.kLjw4iIsCLsZtxc4lksN0j();
		}
	}
}
