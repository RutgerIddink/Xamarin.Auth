﻿using Android.Content;
using Android.OS;


#if ! AZURE_MOBILE_SERVICES
using Xamarin.Auth.Compat;
using Xamarin.Auth.Compat.Presenters.XamarinAndroid;
#else
using Xamarin.Auth.Compat._MobileServices;
using Xamarin.Auth.Compat._MobileServices.Presenters;
#endif

#if !AZURE_MOBILE_SERVICES
namespace Xamarin.Auth.Compat.Presenters.XamarinAndroid
#else
namespace Xamarin.Auth.Compat._MobileServices.Presenters.XamarinAndroid
#endif
{
    public static class AuthenticationConfiguration
    {
        internal static Context Context
        {
            get;
            set;
        }

        public static void Init(Context context, Bundle bundle)
        {
            AuthenticationConfiguration.Context = context;

            OAuthLoginPresenter.PlatformLogin = (authenticator) =>
            {
                PlatformOAuthLoginPresenter oauthLogin = new PlatformOAuthLoginPresenter();
                oauthLogin.Login(authenticator);
            };
        }
    }
}
