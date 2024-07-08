using System.ComponentModel.DataAnnotations;

namespace Umbraco.Community.User2FA.Auth
{
	public class TwoFactorAuthOptions
	{
		public const string ConfigName = "User2FA";

		/// <summary>
		/// The name of the QR 2fA Code issuer, typically the name of the site or application
		/// And is used to identify the issuer of the 2fA code in mobile authenticator apps
		/// </summary>
		/// <example>hackmakedo.com</example>
		/// <example>My Awesome Website</example>
		public string? AuthenticatorIssuerName { get; set; } = "Umbraco Community User 2FA";
    }
}
