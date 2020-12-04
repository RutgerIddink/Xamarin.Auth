//Unable to resolve assembly 'Assembly(Name=System.Runtime, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a)' referenced by 'Assembly(Name=Xamarin.Auth.Compat.Extensions, Version=1.5.0.0, Culture=neutral, PublicKeyToken=null, Location=./source/Extensions/Xamarin.Auth.Compat.Extensions.Portable/bin/Debug/Xamarin.Auth.Compat.Extensions.dll)'.
namespace Xamarin.Auth.Compat
{
    public static partial class OAuth2AuthenticatorExtensions
    {
        public static System.Threading.Tasks.Task<int> RequestRefreshTokenAsync(this Xamarin.Auth.Compat.OAuth2Authenticator authenticator, string refreshToken) 
        { 
            // Unable to resolve assembly 'Assembly(Name=System.Threading.Tasks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a)' referenced by 'Assembly(Name=Xamarin.Auth.Compat.Extensions, Version=1.5.0.0, Culture=neutral, PublicKeyToken=null, Location=./source/Extensions/Xamarin.Auth.Compat.Extensions.Portable/bin/Debug/Xamarin.Auth.Compat.Extensions.dll)'.
            return default(System.Threading.Tasks.Task<int>); 
        }
    }
}
namespace Xamarin.Auth.Compat.AccountUtilities
{
    public partial class AccountManager
    {
        public AccountManager() { }
        public AccountManager(string serviceid, string map_key_password, string map_key_keymaterial, string map_key_salt) { }
        public string KeyKeyMaterial { get { return default(string); } }
        public string KeyPassword { get { return default(string); } }
        public string KeySalt { get { return default(string); } }
        public string ServiceId { get { return default(string); } }
        public bool CreateAndSaveAccount(string username, string password) { return default(bool); }
        public Xamarin.Auth.Compat.Account GetAccount(string username) 
        { 
            // Unable to resolve assembly 'Assembly(Name=Xamarin.Auth.Compat, Version=1.5.0.0, Culture=neutral, PublicKeyToken=null)' referenced by 'Assembly(Name=Xamarin.Auth.Compat.Extensions, Version=1.5.0.0, Culture=neutral, PublicKeyToken=null, Location=./source/Extensions/Xamarin.Auth.Compat.Extensions.Portable/bin/Debug/Xamarin.Auth.Compat.Extensions.dll)'.
            return default(Xamarin.Auth.Compat.Account); 
        }
        public bool LoginToAccount(string username, string password) { return default(bool); }
    }
}
namespace Xamarin.Auth.Compat.Cryptography
{
    public static partial class CryptoUtilities
    {
        public static string ByteArrayToString(byte[] data) { return default(string); }
        public static byte[] Decrypt(byte[] cipherText, byte[] keyMaterial) { return default(byte[]); }
        public static byte[] Encrypt(byte[] plainText, byte[] keyMaterial) { return default(byte[]); }
        public static byte[] Get256BitSalt() { return default(byte[]); }
        public static byte[] GetAES256KeyMaterial() { return default(byte[]); }
        public static byte[] GetHash(byte[] data, byte[] salt) { return default(byte[]); }
        public static byte[] StringToByteArray(string text) { return default(byte[]); }
    }
}
