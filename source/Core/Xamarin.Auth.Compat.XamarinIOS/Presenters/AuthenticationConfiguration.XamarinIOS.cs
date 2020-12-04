using Xamarin.Auth.Compat;
using Xamarin.Auth.Compat.Presenters;

#if ! AZURE_MOBILE_SERVICES
namespace Xamarin.Auth.Compat.Presenters.XamarinIOS
#else
namespace Xamarin.Auth.Compat._MobileServices.Presenters.XamarinIOS
#endif
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
