using System;
using System.Text;
using System.Threading.Tasks;

using Foundation;
using NetworkExtension;
using WebKit;

#if ! AZURE_MOBILE_SERVICES
namespace Xamarin.Auth
#else
namespace Xamarin.Auth._MobileServices
#endif
{
    /// <summary>
    /// Web view configuration.
    /// </summary>
    public static class WebViewConfiguration
    {
        public static class IOS
        {
            /// <summary>
            /// Gets or sets a value indicating whether this <see cref="T:Xamarin.Auth.WebAuthenticatorController"/> 
            /// Migrate to use WKWebView only, keep the variable read-only, always true
            /// </summary>
            /// <value><c>true</c> if is using WKW eb view; otherwise, <c>false</c>.</value>
            public static bool IsUsingWKWebView
            {
                get;
            } = true;


            static string user_agent = null;

            public static string UserAgent
            {
                get
                {
                    return user_agent;
                }
                set
                {
                    user_agent = value;

                    return;
                }
            }

            private static NSOperatingSystemVersion os_ver = NSProcessInfo.ProcessInfo.OperatingSystemVersion;
            private static string sys_ver = UIKit.UIDevice.CurrentDevice.SystemVersion;

            static IOS()
            {
                #if DEBUG
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Xamarin.Auth.WebViewConfiguration.IOS");
                sb.AppendLine($"         NSOperatingSystemVersion = {os_ver.Major}.{os_ver.Minor}");
                sb.AppendLine($"         SystemVersion            = {sys_ver}");
                sb.AppendLine($"WARNING");
                sb.AppendLine($"    in IOS 9.x+ use new WKWebView().wkwv.CustomUserAgent");
                sb.AppendLine($"    new WKWebView().CustomUserAgent");
                sb.AppendLine($"    in IOS 8.x use");
                sb.AppendLine($"    new WKWebView().CustomUserAgent");
                #endif

                return;
            }

            public static new string ToString()
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append    ($"         UserAgent                 = ");

                return sb.ToString();
            }
        }
    }
}
