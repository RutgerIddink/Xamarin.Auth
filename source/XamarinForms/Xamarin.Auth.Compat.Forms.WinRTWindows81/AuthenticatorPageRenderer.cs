﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Platform.WinRT;

[assembly:
    ExportRenderer
        (
            typeof(Xamarin.Auth.Compat.XamarinForms.AuthenticatorPage),
            typeof(Xamarin.Auth.Compat.XamarinForms.WinRT.AuthenticatorPageRenderer)
        )
]
namespace Xamarin.Auth.Compat.XamarinForms.WinRT
{
    public class AuthenticatorPageRenderer : Xamarin.Forms.Platform.WinRT.PageRenderer
    {
        private Xamarin.Auth.Compat.Authenticator authenticator;
        private Windows.UI.Xaml.Controls.Frame frame;

        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing)
                {
                    if (frame != null)
                    {
                        frame.NavigationFailed -= Frame_NavigationFailed;
                        frame.Navigated -= Frame_Navigated;
                        frame.Navigating -= Frame_Navigating;
                        frame.NavigationStopped -= Frame_NavigationStopped;
                        frame = null;
                    }

                    if (authenticator != null)
                    {
                        authenticator.Completed -= Authenticator_Completed;
                        authenticator.Error -= Authenticator_Error;
                        authenticator = null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Xamarin.Auth.Compat.AuthException("UWP Dispose");
            }

            base.Dispose(disposing);
        }

        protected override async void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Page> e)
        {
            try
            {
                base.OnElementChanged(e);

                System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer.OnElementChanged");

                if (e == null)
                    System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: e = {null}");
                else
                {
                    if (e.NewElement == null)
                        System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: e.NewElement = {null}");
                    if (e.OldElement == null)
                        System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: e.OldElement = {null}");
                }

                if (Element == null)
                    System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: Element is {null}");
                else
                    System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: Element is " + Element);

                if (Control == null)
                    System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: Control is {null}");
                else
                    System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: Control is " + Control);

                if (Control == null)
                {
                    WindowsPage windowsPage = new WindowsPage();

                    frame = windowsPage.Frame;
                    if (frame == null)
                    {
                        frame = new Windows.UI.Xaml.Controls.Frame
                        {
                            Language = global::Windows.Globalization.ApplicationLanguages.Languages[0]
                        };

                        frame.NavigationFailed += Frame_NavigationFailed;
                        frame.Navigated += Frame_Navigated;
                        frame.Navigating += Frame_Navigating;
                        frame.NavigationStopped += Frame_NavigationStopped;

                        windowsPage.Content = frame;
                    }

                    authenticator.Completed -= Authenticator_Completed;
                    authenticator.Completed += Authenticator_Completed;
                    authenticator.Error -= Authenticator_Error;
                    authenticator.Error += Authenticator_Error;

                    Type pageType = authenticator.GetUI();
                    frame.Navigate(pageType, authenticator);
                    Windows.UI.Xaml.Window.Current.Activate();
                }
            }
            catch (Exception ex)
            {
                throw new Xamarin.Auth.Compat.AuthException("UWP OnElementChanged");
            }

            return;
        }

        private void Frame_Navigating(object sender, Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: In UWP Frame_Navigating");

            switch (e.NavigationMode)
            {
                case Windows.UI.Xaml.Navigation.NavigationMode.Back:
                    System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: NavigationMode = Back");
                    break;
                case Windows.UI.Xaml.Navigation.NavigationMode.Forward:
                    System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: NavigationMode = Forward");
                    break;
                case Windows.UI.Xaml.Navigation.NavigationMode.New:
                    System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: NavigationMode = New");
                    break;
                case Windows.UI.Xaml.Navigation.NavigationMode.Refresh:
                    System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: NavigationMode = Refresh");
                    break;
            }
            System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: Cancel = " + e.Cancel);
            System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: SourcePageType = " + e.SourcePageType.ToString());

            return;
        }

        private void Frame_Navigated(object sender, Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: In WinRT Windows Frame_Navigated");

            return;
        }

        private async void Frame_NavigationFailed(object sender, Windows.UI.Xaml.Navigation.NavigationFailedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: In WinRT Windows Frame_NavigationFailed");

            return;
        }

        private async void Authenticator_Error(object sender, AuthenticatorErrorEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: In WinRT Windows Authenticator_Error");

            return;
        }

        private async void Authenticator_Completed(object sender, AuthenticatorCompletedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: In WinRT Windows Authenticator_Completed");
        }

        private void Frame_NavigationStopped(object sender, Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("AuthenticatorPageRenderer: In WinRT Windows Frame_Stopped");
        }
    }
}

