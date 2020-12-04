#if ! AZURE_MOBILE_SERVICES
using Xamarin.Auth.Compat;
using Xamarin.Auth.Compat.Presenters;
#else
using Xamarin.Auth.Compat._MobileServices;
using Xamarin.Auth.Compat._MobileServices.Presenters;
#endif

#if !AZURE_MOBILE_SERVICES
namespace Xamarin.Auth.Compat.Presenters.WinRT
#else
namespace Xamarin.Auth.Compat._MobileServices.Presenters.WinRT
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
