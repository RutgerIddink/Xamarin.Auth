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
            return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        }
    }
}
