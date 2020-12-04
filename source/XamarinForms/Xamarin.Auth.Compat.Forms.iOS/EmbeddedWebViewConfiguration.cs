using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Auth.Compat.XamarinForms
{
    public partial class EmbeddedWebViewConfiguration 
        //: Xamarin.Auth.Compat.XamarinForms.IEmbeddedWebViewConfiguration
    {
        public bool IsUsingWKWebView
        {
            get
            {
                return global::Xamarin.Auth.Compat.WebViewConfiguration.IOS.IsUsingWKWebView;
            }
        }

        public string UserAgent
        {
            get
            {
                // User-Agent tweaks for Embedded WebViews 
                //  Android     WebView
                //  iOS         WKWebView
                return global::Xamarin.Auth.Compat.WebViewConfiguration.IOS.UserAgent;
            }
            set
            {
                // User-Agent tweaks for Embedded WebViews 
                //  Android     WebView
                //  iOS         WKWebView
                global::Xamarin.Auth.Compat.WebViewConfiguration.IOS.UserAgent = value;

                return;
            }
        }

    }
}
