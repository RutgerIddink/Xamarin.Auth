using Xamarin.Auth.Compat;
using Xamarin.Auth.Compat.Presenters;

namespace Xamarin.Auth.Compat.Presenters.UWP
{
    public static class AuthenticationConfiguration
    {
        public static void Init()
        {
            OAuthLoginPresenter.PlatformLogin = (authenticator) =>
            {
                var oauthLogin = new PlatformOAuthLoginPresenter();
                oauthLogin.Login(authenticator);
            };
        }
    }
}
