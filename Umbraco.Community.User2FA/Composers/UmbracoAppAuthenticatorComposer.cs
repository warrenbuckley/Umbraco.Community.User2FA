using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Security;
using Umbraco.Community.User2FA.Auth;
using Umbraco.Extensions;

namespace Umbraco.Community.User2FA.Composers
{
	public class UmbracoAppAuthenticatorComposer : IComposer
	{
		public void Compose(IUmbracoBuilder builder)
		{
			var identityBuilder = new BackOfficeIdentityBuilder(builder.Services);
			identityBuilder.AddTwoFactorProvider<UmbracoUserAppAuthenticator>(UmbracoUserAppAuthenticator.Name);
		}
	}
}
