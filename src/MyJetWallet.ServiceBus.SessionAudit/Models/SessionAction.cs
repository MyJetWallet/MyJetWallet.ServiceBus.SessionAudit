namespace MyJetWallet.ServiceBus.SessionAudit.Models
{
	public partial class SessionAuditEvent
	{
		public enum SessionAction
		{
			Login,
			Refresh,
			Logout,
			AutoClose
		}
	}
}