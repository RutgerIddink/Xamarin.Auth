using System;

#if ! AZURE_MOBILE_SERVICES
namespace Xamarin.Auth.Compat
#else
namespace Xamarin.Auth.Compat._MobileServices
#endif
{
    public class AuthenticationUI
    {
        public static AuthenticationUIType AuthenticationUIType 
        { 
            get; 
            set; 
        } = AuthenticationUIType.EmbeddedBrowser;
    }
}
