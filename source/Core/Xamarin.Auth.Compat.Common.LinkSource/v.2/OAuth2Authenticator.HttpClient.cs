using System;

namespace Xamarin.Auth.Compat
{
    /// <summary>
    /// </summary>
    #if XAMARIN_AUTH_INTERNAL
    internal partial class OAuth2Authenticator 
    #else
    public partial class OAuth2Authenticator
    #endif
    {
        public HttpWebClientFrameworkType HttpWebClientUsed
        {
            get;
            set;
        }
    }
}

