using System;
using System.Runtime.Serialization;
using MyJetWallet.Domain;

namespace MyJetWallet.ServiceBus.SessionAudit.Models
{
	public partial class SessionAuditEvent
	{
		[DataContract]
		public class SessionItem
		{
			[DataMember(Order = 1)]
			public Guid RootSessionId { get; set; }

			[DataMember(Order = 2)]
			public string TraderId { get; set; }

			[DataMember(Order = 3)]
			public string BrandId { get; set; }

			[DataMember(Order = 4)]
			public DateTime CreateTime { get; set; }

			[DataMember(Order = 5)]
			public string UserAgent { get; set; }

			[DataMember(Order = 6)]
			public string IP { get; set; }

			[DataMember(Order = 7)]
			public string PublicKeyBase64 { get; set; }

			[DataMember(Order = 8)]
			public bool Passed2FA { get; set; }

			[DataMember(Order = 9)]
			public bool EmailVerified { get; set; }

			[DataMember(Order = 10)]
			public string Description { get; set; }

			[DataMember(Order = 11)]
			public PlatformType PlatformType { get; set; }

			[DataMember(Order = 12)]
			public LoginApplication Application { get; set; }

			[DataMember(Order = 13)]
			public string DeviceUid { get; set; }

			[DataMember(Order = 14)]
			public string Location { get; set; }

			[DataMember(Order = 15)]
			public string PhoneModel { get; set; }
		}
	}
}