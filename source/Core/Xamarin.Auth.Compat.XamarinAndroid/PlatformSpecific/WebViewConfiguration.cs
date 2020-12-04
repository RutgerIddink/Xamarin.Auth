using System;
using System.Threading.Tasks;

using Android.Locations;
using Android.Webkit;

#if ! AZURE_MOBILE_SERVICES
namespace Xamarin.Auth.Compat
#else
namespace Xamarin.Auth.Compat._MobileServices
#endif
{
    /// <summary>
    /// Web view configuration.
    /// </summary>
    public static class WebViewConfiguration
    {
        public static class Android
        {
            public static string UserAgent
            {
                get;
                set;
            }

            static Android()
            {
                UserAgent = (new WebView(global::Android.App.Application.Context)).Settings.UserAgentString;

                return;
            }

        }
    }
}
