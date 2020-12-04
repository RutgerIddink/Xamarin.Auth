using System;

#if ! AZURE_MOBILE_SERVICES
namespace Xamarin.Auth.Compat
#else
namespace Xamarin.Auth.Compat._MobileServices
#endif
{
    public static class FileHelper
	{
		public static string GetLocalStoragePath()
        {
            throw new NotImplementedException("Portable");

            #pragma warning disable 0162
            return string.Empty;
		}
	}
}
