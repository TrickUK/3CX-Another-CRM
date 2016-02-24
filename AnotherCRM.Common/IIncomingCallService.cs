#region

using System.ServiceModel;

#endregion

namespace AnotherCRM.Common
{
	[ServiceContract]
	public interface IIncomingCallService
	{
		[OperationContract(IsOneWay = true)]
		void IncomingCall(string number);

		[OperationContract(IsOneWay = true)]
		void StatusChanged(CRMCallStatus status);

		[OperationContract]
		bool Hello();

		[OperationContract]
		void Goodbye();
	}
}