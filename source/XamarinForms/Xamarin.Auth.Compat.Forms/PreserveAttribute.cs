using System;

namespace Xamarin.Auth.Compat.XamarinForms
{
    public sealed class PreserveAttribute : System.Attribute
    {
        public bool AllMembers;
        public bool Conditional;
    }
}
