//
//  Copyright 2012, Xamarin Inc.
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//        http://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Utilities;

using AuthenticateUIType = System.Object;

namespace Xamarin.Auth
{
    /// <summary>
    /// An authenticator that displays web pages until a given "redirect" page is encountered. It then
    /// returns an account with the fragment on that URL.
    /// </summary>
    #if XAMARIN_AUTH_INTERNAL
	internal partial class WebRedirectAuthenticator : WebAuthenticator
    #else
    public partial class WebRedirectAuthenticator : WebAuthenticator
    #endif
    {
        protected override AuthenticateUIType GetPlatformUI()
        {
            throw new NotImplementedException();
        }
    }
}
