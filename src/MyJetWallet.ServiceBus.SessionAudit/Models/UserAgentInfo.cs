using System.Runtime.Serialization;

namespace MyJetWallet.ServiceBus.SessionAudit.Models
{
	[DataContract]
	public class UserAgentInfo
	{
		[DataMember(Order = 1)]
		public string IsMobile { get; set; }

		[DataMember(Order = 2)]
		public DeviceOperationSystem DeviceOperationSystem { get; set; }
	}
}