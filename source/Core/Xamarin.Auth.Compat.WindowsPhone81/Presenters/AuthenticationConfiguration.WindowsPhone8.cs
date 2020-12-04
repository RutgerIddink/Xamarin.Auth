#if ! AZURE_MOBILE_SERVICES
using Xamarin.Auth.Compat;
using Xamarin.Auth.Compat.Presenters;
#else
using Xamarin.Auth.Compat._MobileServices;
using Xamarin.Auth.Compat._MobileServices.Presenters;
#endif

#if !AZURE_MOBILE_SERVICES
namespace Xamarin.Auth.Compat.Presenters.WinPhone
#else
namespace Xamarin.Auth.Compat._MobileServices.Presenters.WinPhone
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
