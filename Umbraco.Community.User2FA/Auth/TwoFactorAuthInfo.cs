using System.Runtime.Serialization;
using Umbraco.Cms.Core.Security;

namespace Umbraco.Community.User2FA.Auth
{

	[DataContract]
	public class TwoFactorAuthInfo : ISetupTwoFactorModel
	{
		[DataMember(Name = "qrCodeSetupImageUrl")]
		public string? QrCodeSetupImageUrl { get; set; }

		[DataMember(Name = "secret")]
		public string? Secret { get; set; }
	}
}
