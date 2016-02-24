#region

using System;
using JetBrains.Annotations;
using MyPhonePlugins;

#endregion

namespace AnotherCRM.Common
{
	[Serializable]
	public class CRMCallStatus
	{
		public string CallId { get; [UsedImplicitly]set; }
		public CallState State { get; [UsedImplicitly]set; }

		public CRMCallStatus(string callId, CallState state)
		{
			CallId = callId;
			State = state;
		}
	}
}