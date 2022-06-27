using System;
using System.Runtime.Serialization;

namespace MyJetWallet.ServiceBus.SessionAudit.Models ;

	[DataContract]
	public partial class SessionAuditEvent
	{
		public const string TopicName = "tokens-manager-audit-session";

		[DataMember(Order = 1)]
		public SessionAction Action { get; set; }

		[DataMember(Order = 2)]
		public SessionItem Session { get; set; }

		[DataMember(Order = 3)]
		public string Comment { get; set; }

		[DataMember(Order = 4)]
		public DateTime Timestamp { get; set; } = DateTime.UtcNow;

		[DataMember(Order = 5)]
		public UserAgentInfo UserAgentInfo { get; set; }

		public static SessionAuditEvent Create(SessionAction action, string traderId, Guid rootSessionId, string comment, UserAgentInfo loginInfo = null)
		{
			return new SessionAuditEvent
			{
				Action = action,
				Comment = comment,
				UserAgentInfo = loginInfo,
				Session = new SessionItem
				{
					RootSessionId = rootSessionId,
					TraderId = traderId
				}
			};
		}
	}