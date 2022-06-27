using System.Runtime.Serialization;

namespace MyJetWallet.ServiceBus.SessionAudit.Models
{
	[DataContract]
	public class UserAgentInfo
	{
		[DataMember(Order = 1)]
		public bool IsMobile { get; set; }

		[DataMember(Order = 2)]
		public DeviceOperationSystem DeviceOperationSystem { get; set; }
	}
}