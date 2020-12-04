using System;
#if !AZURE_MOBILE_SERVICES
using Xamarin.Auth.Compat;
#else
using Xamarin.Auth.Compat._MobileServices;
#endif

#if !AZURE_MOBILE_SERVICES
namespace Xamarin.Auth.Compat.Presenters
#else
namespace Xamarin.Auth.Compat._MobileServices.Presenters
#endif
{
#if XAMARIN_AUTH_INTERNAL
    internal class OAuthLoginPresenter
#else
    public class OAuthLoginPresenter
#endif
    {
        public event EventHandler<AuthenticatorCompletedEventArgs> Completed;

        public static Action<Authenticator> PlatformLogin;

        public void Login(Authenticator authenticator)
        {
            authenticator.Completed += OnAuthCompleted;

            PlatformLogin(authenticator);
        }

        void OnAuthCompleted(object sender, global::Xamarin.Auth.Compat.AuthenticatorCompletedEventArgs e)
        {
            if (Completed != null)
            {
                Completed(sender, e);
            }

            ((Authenticator)sender).Completed -= OnAuthCompleted;
        }
    }
}
