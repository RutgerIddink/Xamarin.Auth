#if !AZURE_MOBILE_SERVICES
namespace Xamarin.Auth.Compat.Presenters.XamarinAndroid
#else
namespace Xamarin.Auth.Compat._MobileServices.Presenters.XamarinAndroid
#endif
{
    #if XAMARIN_AUTH_INTERNAL
    internal class PlatformOAuthLoginPresenter
    #else
    public class PlatformOAuthLoginPresenter
    #endif
    {
        public void Login(Authenticator authenticator)
        {
            AuthenticationConfiguration.Context.StartActivity(authenticator.GetUI(AuthenticationConfiguration.Context));
        }
    }
}
