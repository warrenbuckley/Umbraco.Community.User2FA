
using Google.Authenticator;
using Microsoft.Extensions.Options;
using Umbraco.Cms.Core.Models.Membership;
using Umbraco.Cms.Core.Security;
using Umbraco.Cms.Core.Services;

namespace Umbraco.Community.User2FA.Auth
{
	public class UmbracoUserAppAuthenticator : ITwoFactorProvider
	{
		public const string Name = "Umbraco.Community.User2FA.Authenticator";

		private readonly IUserService _userService;
		private readonly TwoFactorAuthOptions _options;

		public UmbracoUserAppAuthenticator(IUserService userService, IOptionsMonitor<TwoFactorAuthOptions> options)
		{
			_userService = userService;
			_options = options.CurrentValue;
		}

		public string ProviderName => Name;
	
		public async Task<ISetupTwoFactorModel> GetSetupDataAsync(Guid userOrMemberKey, string secret)
		{
			IUser? user = await _userService.GetAsync(userOrMemberKey);

			ArgumentNullException.ThrowIfNull(user);

			var twoFactorAuthenticator = new TwoFactorAuthenticator();
			SetupCode setupInfo = twoFactorAuthenticator.GenerateSetupCode(_options.AuthenticatorIssuerName, user.Username, secret, false);
			return await Task.FromResult<ISetupTwoFactorModel>(new TwoFactorAuthInfo()
			{
				QrCodeSetupImageUrl = setupInfo.QrCodeSetupImageUrl,
				Secret = secret
			});
		}

		public bool ValidateTwoFactorPIN(string secret, string code)
		{
			var twoFactorAuthenticator = new TwoFactorAuthenticator();
			return twoFactorAuthenticator.ValidateTwoFactorPIN(secret, code);
		}

		public bool ValidateTwoFactorSetup(string secret, string token) => ValidateTwoFactorPIN(secret, token);
	}
}
