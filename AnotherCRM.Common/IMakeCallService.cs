#region

using System.ServiceModel;

#endregion

namespace AnotherCRM.Common
{
	[ServiceContract]
	public interface IMakeCallService
	{
		[OperationContract(IsOneWay = true)]
		void MakeCall(string destination);

		[OperationContract(IsOneWay = true)]
		void HangUp(string callId);

		[OperationContract]
		bool Hello();

		[OperationContract]
		CRMCallStatus Status();
	}
}